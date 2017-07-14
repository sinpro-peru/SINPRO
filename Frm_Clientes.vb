Imports System.Data.SqlClient

Public Class Frm_Clientes
    Inherits System.Windows.Forms.Form
    Dim Usuario As String = ""
    Dim dirCliente As String = ""
    Dim dir As String = ""
    Dim dirEnvio As String = ""
    Private user1 As String = ""
    Dim CodigoAnt As String = ""
    Dim varBoton As Integer = 0
    Private choice As Integer
    Private swC As Boolean = False
    Private indice As Integer = 0
    Private swX As Boolean = False
    Dim tipocsv As Integer = 0
    Dim datos2 As Boolean = False
    Dim clientes2 As Boolean = False
    Public pcdm As Integer = 0
    Public password As String = ""
    Public pcdm2 As Integer = 0
    Friend WithEvents DGV_Fact As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewRazon As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Private cli As Boolean = False
    Dim e As Boolean = True
    Friend WithEvents bt_autorizar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dev As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ajuste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasCred As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_vendedor2 As MTGCComboBox
    Friend WithEvents chk_filtro As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tb_direccionE As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents bt_chequearRIF As System.Windows.Forms.Button
    Friend WithEvents chk_fletePago As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chk_cambiarCod As System.Windows.Forms.CheckBox
    Friend WithEvents tb_limite As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tb_password As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents tb_user As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents chk_auto As System.Windows.Forms.CheckBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tb_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_celular As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ch_contribuyente As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lb_totalDeuda As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lb_favor As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lb_porVencer As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lb_vencido As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tb_codigo As System.Windows.Forms.TextBox
    Friend WithEvents tb_vendedor As MTGCComboBox
    Friend WithEvents tb_estado As MTGCComboBox
    Friend WithEvents tb_zona As MTGCComboBox
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_clasificacion As System.Windows.Forms.TextBox
    Friend WithEvents tb_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_email As System.Windows.Forms.TextBox
    Friend WithEvents tb_fax As System.Windows.Forms.TextBox
    Friend WithEvents tb_telefono2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_telefono1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_direccion As System.Windows.Forms.TextBox
    Friend WithEvents tb_rif As System.Windows.Forms.TextBox
    Friend WithEvents tb_gerente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_representante As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tb_razon As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lb_empresa As System.Windows.Forms.ListBox
    Friend WithEvents cb_empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents tb_chequesDev As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents tb_montoC As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_empresa3 As System.Windows.Forms.ListBox
    Friend WithEvents tb_comen3 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents dtp_inicio3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents tb_chequesDev3 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents tb_montoC3 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents cb_empresa3 As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_empresa2 As System.Windows.Forms.ListBox
    Friend WithEvents tb_comen2 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents dtp_inicio2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents tb_chequesDev2 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents tb_montoC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cb_empresa2 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents tb_comen As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Sp_consultaEmpresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaEmpresaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaEmpresaTableAdapter
    Friend WithEvents Sp_consultaEmpresaTableAdapter2 As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaEmpresaTableAdapter
    Friend WithEvents sp_consultaEmpresaBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaEmpresaTableAdapter3 As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaEmpresaTableAdapter
    Friend WithEvents sp_consultaEmpresaBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents chk_guardar3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_guardar2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_guardar As System.Windows.Forms.CheckBox
    Dim w As Boolean = True


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
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_modificar As System.Windows.Forms.ToolBarButton
    Friend WithEvents bt_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Clientes))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_autorizar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DGV_Fact = New System.Windows.Forms.DataGridView
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Venc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiasCred = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Recibo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDep = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dev = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ret = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codigoRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ajuste = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewRazon = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.chk_filtro = New System.Windows.Forms.CheckBox
        Me.tb_vendedor2 = New MTGCComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.tb_direccionE = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.bt_chequearRIF = New System.Windows.Forms.Button
        Me.chk_fletePago = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.chk_cambiarCod = New System.Windows.Forms.CheckBox
        Me.tb_limite = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.tb_password = New System.Windows.Forms.MaskedTextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.tb_user = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.chk_auto = New System.Windows.Forms.CheckBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.tb_observacion = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.tb_celular = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.ch_contribuyente = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lb_totalDeuda = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.lb_favor = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.lb_porVencer = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lb_vencido = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.tb_codigo = New System.Windows.Forms.TextBox
        Me.tb_vendedor = New MTGCComboBox
        Me.tb_estado = New MTGCComboBox
        Me.tb_zona = New MTGCComboBox
        Me.tb_clasificacion = New System.Windows.Forms.TextBox
        Me.tb_fecha = New System.Windows.Forms.DateTimePicker
        Me.tb_email = New System.Windows.Forms.TextBox
        Me.tb_fax = New System.Windows.Forms.TextBox
        Me.tb_telefono2 = New System.Windows.Forms.TextBox
        Me.tb_telefono1 = New System.Windows.Forms.TextBox
        Me.tb_direccion = New System.Windows.Forms.TextBox
        Me.tb_rif = New System.Windows.Forms.TextBox
        Me.tb_gerente = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tb_representante = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.tb_razon = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lb_empresa3 = New System.Windows.Forms.ListBox
        Me.sp_consultaEmpresaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.chk_guardar3 = New System.Windows.Forms.CheckBox
        Me.tb_comen3 = New System.Windows.Forms.TextBox
        Me.dtp_inicio3 = New System.Windows.Forms.DateTimePicker
        Me.Label48 = New System.Windows.Forms.Label
        Me.tb_chequesDev3 = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.tb_montoC3 = New System.Windows.Forms.TextBox
        Me.cb_empresa3 = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lb_empresa2 = New System.Windows.Forms.ListBox
        Me.sp_consultaEmpresaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_guardar2 = New System.Windows.Forms.CheckBox
        Me.tb_comen2 = New System.Windows.Forms.TextBox
        Me.dtp_inicio2 = New System.Windows.Forms.DateTimePicker
        Me.Label43 = New System.Windows.Forms.Label
        Me.tb_chequesDev2 = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.tb_montoC2 = New System.Windows.Forms.TextBox
        Me.cb_empresa2 = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lb_empresa = New System.Windows.Forms.ListBox
        Me.Sp_consultaEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_guardar = New System.Windows.Forms.CheckBox
        Me.tb_comen = New System.Windows.Forms.TextBox
        Me.dtp_inicio = New System.Windows.Forms.DateTimePicker
        Me.Label40 = New System.Windows.Forms.Label
        Me.tb_chequesDev = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.tb_montoC = New System.Windows.Forms.TextBox
        Me.cb_empresa = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.Sp_consultaEmpresaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaEmpresaTableAdapter
        Me.Sp_consultaEmpresaTableAdapter2 = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaEmpresaTableAdapter
        Me.Sp_consultaEmpresaTableAdapter3 = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaEmpresaTableAdapter
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Fact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewRazon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.sp_consultaEmpresaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.sp_consultaEmpresaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Sp_consultaEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_autorizar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(18, 12)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(352, 65)
        Me.ToolBar1.TabIndex = 0
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
        'bt_autorizar
        '
        Me.bt_autorizar.ImageIndex = 6
        Me.bt_autorizar.Name = "bt_autorizar"
        Me.bt_autorizar.Text = "Autorizar"
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 441)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "#"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(388, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(640, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Datos del Cliente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(174, 71)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(198, 22)
        Me.tb_buscarcodigo.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'DGV_Fact
        '
        Me.DGV_Fact.AllowUserToAddRows = False
        Me.DGV_Fact.AllowUserToDeleteRows = False
        Me.DGV_Fact.AllowUserToResizeColumns = False
        Me.DGV_Fact.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        Me.DGV_Fact.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_Fact.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Fact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Fact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Fecha, Me.Venc, Me.Dias, Me.Monto, Me.Column1, Me.Nro, Me.DiasCred, Me.CH})
        Me.DGV_Fact.Location = New System.Drawing.Point(2, 484)
        Me.DGV_Fact.Name = "DGV_Fact"
        Me.DGV_Fact.RowHeadersVisible = False
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.DGV_Fact.RowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DGV_Fact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Fact.ShowEditingIcon = False
        Me.DGV_Fact.Size = New System.Drawing.Size(383, 224)
        Me.DGV_Fact.TabIndex = 71
        '
        'Cod
        '
        Me.Cod.HeaderText = "Fact."
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Width = 52
        '
        'Fecha
        '
        DataGridViewCellStyle12.Format = "dd/MM/yy"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle12
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 57
        '
        'Venc
        '
        DataGridViewCellStyle13.Format = "dd/MM/yy"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Venc.DefaultCellStyle = DataGridViewCellStyle13
        Me.Venc.HeaderText = "Vencim."
        Me.Venc.Name = "Venc"
        Me.Venc.ReadOnly = True
        Me.Venc.Width = 60
        '
        'Dias
        '
        Me.Dias.HeaderText = "D."
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 30
        '
        'Monto
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle14
        Me.Monto.HeaderText = "Total"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 67
        '
        'Column1
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column1.HeaderText = "Pend."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'Nro
        '
        Me.Nro.HeaderText = "Nro"
        Me.Nro.Name = "Nro"
        Me.Nro.Visible = False
        '
        'DiasCred
        '
        Me.DiasCred.HeaderText = "DiasCred"
        Me.DiasCred.Name = "DiasCred"
        Me.DiasCred.Visible = False
        '
        'CH
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CH.DefaultCellStyle = DataGridViewCellStyle16
        Me.CH.HeaderText = "CH"
        Me.CH.Name = "CH"
        Me.CH.Width = 30
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(2, 463)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(383, 23)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Facturas Pendiente de Pago"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(388, 463)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(636, 23)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Histórico de Recibos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Recibo, Me.DataGridViewTextBoxColumn2, Me.FechaDeposito, Me.DataGridViewTextBoxColumn5, Me.MontoDep, Me.DataGridViewTextBoxColumn4, Me.Num, Me.Dev, Me.Ret, Me.codigoRecibo, Me.Ajuste})
        Me.DataGridView1.Location = New System.Drawing.Point(389, 485)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 8.75!)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(635, 223)
        Me.DataGridView1.TabIndex = 75
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fact."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'Recibo
        '
        Me.Recibo.HeaderText = "Rec."
        Me.Recibo.Name = "Recibo"
        Me.Recibo.ReadOnly = True
        Me.Recibo.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaF"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 73
        '
        'FechaDeposito
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaDeposito.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaDeposito.HeaderText = "FechaD"
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.ReadOnly = True
        Me.FechaDeposito.Width = 73
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "MontoF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'MontoDep
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.MontoDep.DefaultCellStyle = DataGridViewCellStyle5
        Me.MontoDep.HeaderText = "MontoD"
        Me.MontoDep.Name = "MontoDep"
        Me.MontoDep.ReadOnly = True
        Me.MontoDep.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dias"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 37
        '
        'Num
        '
        Me.Num.HeaderText = "Num"
        Me.Num.Name = "Num"
        Me.Num.Visible = False
        '
        'Dev
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Dev.DefaultCellStyle = DataGridViewCellStyle7
        Me.Dev.HeaderText = "NC"
        Me.Dev.Name = "Dev"
        Me.Dev.ReadOnly = True
        Me.Dev.Width = 65
        '
        'Ret
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Ret.DefaultCellStyle = DataGridViewCellStyle8
        Me.Ret.HeaderText = "Ret."
        Me.Ret.Name = "Ret"
        Me.Ret.ReadOnly = True
        Me.Ret.Width = 55
        '
        'codigoRecibo
        '
        Me.codigoRecibo.HeaderText = "codR"
        Me.codigoRecibo.Name = "codigoRecibo"
        Me.codigoRecibo.ReadOnly = True
        Me.codigoRecibo.Visible = False
        '
        'Ajuste
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Ajuste.DefaultCellStyle = DataGridViewCellStyle9
        Me.Ajuste.HeaderText = "Ajuste"
        Me.Ajuste.Name = "Ajuste"
        Me.Ajuste.ReadOnly = True
        Me.Ajuste.Width = 52
        '
        'DataGridViewRazon
        '
        Me.DataGridViewRazon.AllowUserToAddRows = False
        Me.DataGridViewRazon.AllowUserToDeleteRows = False
        Me.DataGridViewRazon.AllowUserToResizeColumns = False
        Me.DataGridViewRazon.AllowUserToResizeRows = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        Me.DataGridViewRazon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewRazon.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewRazon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRazon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.DataGridViewRazon.Location = New System.Drawing.Point(8, 126)
        Me.DataGridViewRazon.MultiSelect = False
        Me.DataGridViewRazon.Name = "DataGridViewRazon"
        Me.DataGridViewRazon.RowHeadersVisible = False
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewRazon.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewRazon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewRazon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRazon.ShowEditingIcon = False
        Me.DataGridViewRazon.Size = New System.Drawing.Size(365, 311)
        Me.DataGridViewRazon.TabIndex = 76
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
        DataGridViewCellStyle19.Format = "d"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn6.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 265
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(8, 69)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(160, 23)
        Me.DomainUpDown1.TabIndex = 77
        '
        'chk_filtro
        '
        Me.chk_filtro.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_filtro.Location = New System.Drawing.Point(8, 99)
        Me.chk_filtro.Name = "chk_filtro"
        Me.chk_filtro.Size = New System.Drawing.Size(148, 21)
        Me.chk_filtro.TabIndex = 83
        Me.chk_filtro.Text = "Filtrar por vendedor"
        '
        'tb_vendedor2
        '
        Me.tb_vendedor2.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_vendedor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_vendedor2.ColumnNum = 2
        Me.tb_vendedor2.ColumnWidth = "100;44"
        Me.tb_vendedor2.DisplayMember = "Text"
        Me.tb_vendedor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_vendedor2.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_vendedor2.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_vendedor2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_vendedor2.DropDownWidth = 164
        Me.tb_vendedor2.Enabled = False
        Me.tb_vendedor2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_vendedor2.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_vendedor2.GridLineHorizontal = False
        Me.tb_vendedor2.GridLineVertical = False
        Me.tb_vendedor2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_vendedor2.Location = New System.Drawing.Point(174, 97)
        Me.tb_vendedor2.ManagingFastMouseMoving = True
        Me.tb_vendedor2.ManagingFastMouseMovingInterval = 30
        Me.tb_vendedor2.Name = "tb_vendedor2"
        Me.tb_vendedor2.Size = New System.Drawing.Size(199, 23)
        Me.tb_vendedor2.TabIndex = 84
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(383, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(657, 432)
        Me.TabControl1.TabIndex = 10062
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.tb_direccionE)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.bt_chequearRIF)
        Me.TabPage1.Controls.Add(Me.chk_fletePago)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.chk_cambiarCod)
        Me.TabPage1.Controls.Add(Me.tb_limite)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.tb_password)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.tb_user)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.chk_auto)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.tb_observacion)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.tb_celular)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.ch_contribuyente)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.tb_codigo)
        Me.TabPage1.Controls.Add(Me.tb_vendedor)
        Me.TabPage1.Controls.Add(Me.tb_estado)
        Me.TabPage1.Controls.Add(Me.tb_zona)
        Me.TabPage1.Controls.Add(Me.tb_clasificacion)
        Me.TabPage1.Controls.Add(Me.tb_fecha)
        Me.TabPage1.Controls.Add(Me.tb_email)
        Me.TabPage1.Controls.Add(Me.tb_fax)
        Me.TabPage1.Controls.Add(Me.tb_telefono2)
        Me.TabPage1.Controls.Add(Me.tb_telefono1)
        Me.TabPage1.Controls.Add(Me.tb_direccion)
        Me.TabPage1.Controls.Add(Me.tb_rif)
        Me.TabPage1.Controls.Add(Me.tb_gerente)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.tb_representante)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.tb_razon)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(649, 404)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Cliente"
        '
        'tb_direccionE
        '
        Me.tb_direccionE.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccionE.Location = New System.Drawing.Point(101, 174)
        Me.tb_direccionE.MaxLength = 200
        Me.tb_direccionE.Multiline = True
        Me.tb_direccionE.Name = "tb_direccionE"
        Me.tb_direccionE.ReadOnly = True
        Me.tb_direccionE.Size = New System.Drawing.Size(291, 54)
        Me.tb_direccionE.TabIndex = 10117
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(3, 180)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(100, 31)
        Me.Label36.TabIndex = 10118
        Me.Label36.Text = "Dirección" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Entrega:"
        '
        'bt_chequearRIF
        '
        Me.bt_chequearRIF.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_chequearRIF.Enabled = False
        Me.bt_chequearRIF.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_chequearRIF.Image = Global.Tesis_Nueva.My.Resources.Resources.check_16x16
        Me.bt_chequearRIF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_chequearRIF.Location = New System.Drawing.Point(234, 51)
        Me.bt_chequearRIF.Name = "bt_chequearRIF"
        Me.bt_chequearRIF.Size = New System.Drawing.Size(25, 21)
        Me.bt_chequearRIF.TabIndex = 10116
        Me.bt_chequearRIF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_chequearRIF.UseVisualStyleBackColor = False
        '
        'chk_fletePago
        '
        Me.chk_fletePago.Enabled = False
        Me.chk_fletePago.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fletePago.Location = New System.Drawing.Point(617, 303)
        Me.chk_fletePago.Name = "chk_fletePago"
        Me.chk_fletePago.Size = New System.Drawing.Size(14, 20)
        Me.chk_fletePago.TabIndex = 10115
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(398, 304)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 21)
        Me.Label20.TabIndex = 10114
        Me.Label20.Text = "Flete Pago:"
        '
        'chk_cambiarCod
        '
        Me.chk_cambiarCod.AutoSize = True
        Me.chk_cambiarCod.Location = New System.Drawing.Point(397, 4)
        Me.chk_cambiarCod.Name = "chk_cambiarCod"
        Me.chk_cambiarCod.Size = New System.Drawing.Size(121, 19)
        Me.chk_cambiarCod.TabIndex = 10113
        Me.chk_cambiarCod.Text = "Cambiar Código"
        Me.chk_cambiarCod.UseVisualStyleBackColor = True
        Me.chk_cambiarCod.Visible = False
        '
        'tb_limite
        '
        Me.tb_limite.Enabled = False
        Me.tb_limite.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_limite.Location = New System.Drawing.Point(487, 234)
        Me.tb_limite.MaxLength = 18
        Me.tb_limite.Name = "tb_limite"
        Me.tb_limite.Size = New System.Drawing.Size(144, 22)
        Me.tb_limite.TabIndex = 10112
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(398, 239)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 15)
        Me.Label19.TabIndex = 10111
        Me.Label19.Text = "Lim. Crédito:"
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(102, 376)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.ReadOnly = True
        Me.tb_password.Size = New System.Drawing.Size(130, 22)
        Me.tb_password.TabIndex = 10110
        Me.tb_password.UseSystemPasswordChar = True
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 380)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 23)
        Me.Label35.TabIndex = 10109
        Me.Label35.Text = "Password:"
        '
        'tb_user
        '
        Me.tb_user.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(102, 353)
        Me.tb_user.MaxLength = 50
        Me.tb_user.Name = "tb_user"
        Me.tb_user.ReadOnly = True
        Me.tb_user.Size = New System.Drawing.Size(130, 22)
        Me.tb_user.TabIndex = 10107
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(4, 357)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(57, 17)
        Me.Label34.TabIndex = 10108
        Me.Label34.Text = "User:"
        '
        'chk_auto
        '
        Me.chk_auto.Enabled = False
        Me.chk_auto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_auto.Location = New System.Drawing.Point(617, 282)
        Me.chk_auto.Name = "chk_auto"
        Me.chk_auto.Size = New System.Drawing.Size(14, 20)
        Me.chk_auto.TabIndex = 10106
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(397, 283)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(125, 21)
        Me.Label27.TabIndex = 10105
        Me.Label27.Text = "Cliente autorizado:"
        '
        'tb_observacion
        '
        Me.tb_observacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_observacion.Location = New System.Drawing.Point(102, 298)
        Me.tb_observacion.MaxLength = 250
        Me.tb_observacion.Multiline = True
        Me.tb_observacion.Name = "tb_observacion"
        Me.tb_observacion.ReadOnly = True
        Me.tb_observacion.Size = New System.Drawing.Size(290, 54)
        Me.tb_observacion.TabIndex = 10104
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(1, 304)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(95, 23)
        Me.Label32.TabIndex = 10103
        Me.Label32.Text = "Observación:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 10081
        Me.Label14.Text = "Representante:"
        '
        'tb_celular
        '
        Me.tb_celular.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_celular.Location = New System.Drawing.Point(276, 69)
        Me.tb_celular.MaxLength = 18
        Me.tb_celular.Name = "tb_celular"
        Me.tb_celular.ReadOnly = True
        Me.tb_celular.Size = New System.Drawing.Size(116, 22)
        Me.tb_celular.TabIndex = 10102
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(397, 261)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(159, 20)
        Me.Label28.TabIndex = 10100
        Me.Label28.Text = "Contribuyente Especial:"
        '
        'ch_contribuyente
        '
        Me.ch_contribuyente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_contribuyente.Location = New System.Drawing.Point(617, 258)
        Me.ch_contribuyente.Name = "ch_contribuyente"
        Me.ch_contribuyente.Size = New System.Drawing.Size(14, 20)
        Me.ch_contribuyente.TabIndex = 10099
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lb_totalDeuda)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.lb_favor)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.lb_porVencer)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.lb_vencido)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(397, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 96)
        Me.Panel3.TabIndex = 10098
        '
        'lb_totalDeuda
        '
        Me.lb_totalDeuda.Location = New System.Drawing.Point(114, 43)
        Me.lb_totalDeuda.Name = "lb_totalDeuda"
        Me.lb_totalDeuda.Size = New System.Drawing.Size(106, 18)
        Me.lb_totalDeuda.TabIndex = 84
        Me.lb_totalDeuda.Text = "0,00"
        Me.lb_totalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 44)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 20)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "Total Deuda:"
        '
        'lb_favor
        '
        Me.lb_favor.Location = New System.Drawing.Point(116, 61)
        Me.lb_favor.Name = "lb_favor"
        Me.lb_favor.Size = New System.Drawing.Size(106, 18)
        Me.lb_favor.TabIndex = 82
        Me.lb_favor.Text = "0,00"
        Me.lb_favor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 64)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(99, 20)
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "Saldo a Favor:"
        '
        'lb_porVencer
        '
        Me.lb_porVencer.Location = New System.Drawing.Point(118, 4)
        Me.lb_porVencer.Name = "lb_porVencer"
        Me.lb_porVencer.Size = New System.Drawing.Size(102, 18)
        Me.lb_porVencer.TabIndex = 78
        Me.lb_porVencer.Text = "0,00"
        Me.lb_porVencer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 20)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Vencido:"
        '
        'lb_vencido
        '
        Me.lb_vencido.Location = New System.Drawing.Point(114, 24)
        Me.lb_vencido.Name = "lb_vencido"
        Me.lb_vencido.Size = New System.Drawing.Size(106, 18)
        Me.lb_vencido.TabIndex = 77
        Me.lb_vencido.Text = "0,00"
        Me.lb_vencido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 4)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 18)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "Por Vencer:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(397, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 30)
        Me.Panel2.TabIndex = 10097
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 4)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 23)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Monto Pagado:"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(118, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(102, 23)
        Me.Label30.TabIndex = 74
        Me.Label30.Text = "0,00"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(2, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 23)
        Me.Label12.TabIndex = 10077
        Me.Label12.Text = "Email:"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(488, 362)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 20)
        Me.Label22.TabIndex = 10094
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'tb_codigo
        '
        Me.tb_codigo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codigo.Location = New System.Drawing.Point(313, 3)
        Me.tb_codigo.MaxLength = 3
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(78, 22)
        Me.tb_codigo.TabIndex = 10096
        '
        'tb_vendedor
        '
        Me.tb_vendedor.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_vendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_vendedor.ColumnNum = 2
        Me.tb_vendedor.ColumnWidth = "100;44"
        Me.tb_vendedor.DisplayMember = "Text"
        Me.tb_vendedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_vendedor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_vendedor.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_vendedor.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_vendedor.DropDownWidth = 164
        Me.tb_vendedor.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_vendedor.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_vendedor.GridLineHorizontal = False
        Me.tb_vendedor.GridLineVertical = False
        Me.tb_vendedor.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_vendedor.Location = New System.Drawing.Point(101, 3)
        Me.tb_vendedor.ManagingFastMouseMoving = True
        Me.tb_vendedor.ManagingFastMouseMovingInterval = 30
        Me.tb_vendedor.Name = "tb_vendedor"
        Me.tb_vendedor.Size = New System.Drawing.Size(206, 23)
        Me.tb_vendedor.TabIndex = 10063
        '
        'tb_estado
        '
        Me.tb_estado.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_estado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_estado.ColumnNum = 1
        Me.tb_estado.ColumnWidth = "100"
        Me.tb_estado.DisplayMember = "Text"
        Me.tb_estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_estado.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_estado.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_estado.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.tb_estado.DropDownWidth = 170
        Me.tb_estado.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_estado.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_estado.GridLineHorizontal = False
        Me.tb_estado.GridLineVertical = False
        Me.tb_estado.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_estado.Location = New System.Drawing.Point(487, 210)
        Me.tb_estado.ManagingFastMouseMoving = True
        Me.tb_estado.ManagingFastMouseMovingInterval = 30
        Me.tb_estado.Name = "tb_estado"
        Me.tb_estado.Size = New System.Drawing.Size(144, 23)
        Me.tb_estado.TabIndex = 10087
        '
        'tb_zona
        '
        Me.tb_zona.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_zona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_zona.ColumnNum = 2
        Me.tb_zona.ColumnWidth = "135;20"
        Me.tb_zona.DisplayMember = "Text"
        Me.tb_zona.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_zona.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_zona.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_zona.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.tb_zona.DropDownWidth = 175
        Me.tb_zona.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_zona.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_zona.GridLineHorizontal = False
        Me.tb_zona.GridLineVertical = False
        Me.tb_zona.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_zona.Location = New System.Drawing.Point(487, 186)
        Me.tb_zona.ManagingFastMouseMoving = True
        Me.tb_zona.ManagingFastMouseMovingInterval = 30
        Me.tb_zona.Name = "tb_zona"
        Me.tb_zona.Size = New System.Drawing.Size(144, 23)
        Me.tb_zona.TabIndex = 10086
        '
        'tb_clasificacion
        '
        Me.tb_clasificacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_clasificacion.Location = New System.Drawing.Point(535, 323)
        Me.tb_clasificacion.MaxLength = 1
        Me.tb_clasificacion.Name = "tb_clasificacion"
        Me.tb_clasificacion.Size = New System.Drawing.Size(96, 22)
        Me.tb_clasificacion.TabIndex = 10083
        Me.tb_clasificacion.Text = "C"
        Me.tb_clasificacion.Visible = False
        '
        'tb_fecha
        '
        Me.tb_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_fecha.Location = New System.Drawing.Point(487, 163)
        Me.tb_fecha.Name = "tb_fecha"
        Me.tb_fecha.Size = New System.Drawing.Size(144, 22)
        Me.tb_fecha.TabIndex = 10084
        '
        'tb_email
        '
        Me.tb_email.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_email.Location = New System.Drawing.Point(102, 229)
        Me.tb_email.MaxLength = 50
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(206, 22)
        Me.tb_email.TabIndex = 10076
        '
        'tb_fax
        '
        Me.tb_fax.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fax.Location = New System.Drawing.Point(275, 94)
        Me.tb_fax.MaxLength = 18
        Me.tb_fax.Name = "tb_fax"
        Me.tb_fax.Size = New System.Drawing.Size(116, 22)
        Me.tb_fax.TabIndex = 10074
        '
        'tb_telefono2
        '
        Me.tb_telefono2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono2.Location = New System.Drawing.Point(101, 97)
        Me.tb_telefono2.MaxLength = 18
        Me.tb_telefono2.Name = "tb_telefono2"
        Me.tb_telefono2.Size = New System.Drawing.Size(130, 22)
        Me.tb_telefono2.TabIndex = 10072
        '
        'tb_telefono1
        '
        Me.tb_telefono1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono1.Location = New System.Drawing.Point(101, 74)
        Me.tb_telefono1.MaxLength = 18
        Me.tb_telefono1.Name = "tb_telefono1"
        Me.tb_telefono1.Size = New System.Drawing.Size(130, 22)
        Me.tb_telefono1.TabIndex = 10070
        '
        'tb_direccion
        '
        Me.tb_direccion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccion.Location = New System.Drawing.Point(101, 120)
        Me.tb_direccion.MaxLength = 200
        Me.tb_direccion.Multiline = True
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(291, 53)
        Me.tb_direccion.TabIndex = 10068
        '
        'tb_rif
        '
        Me.tb_rif.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_rif.Location = New System.Drawing.Point(101, 51)
        Me.tb_rif.MaxLength = 12
        Me.tb_rif.Name = "tb_rif"
        Me.tb_rif.Size = New System.Drawing.Size(130, 22)
        Me.tb_rif.TabIndex = 10067
        '
        'tb_gerente
        '
        Me.tb_gerente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_gerente.Location = New System.Drawing.Point(102, 252)
        Me.tb_gerente.MaxLength = 50
        Me.tb_gerente.Name = "tb_gerente"
        Me.tb_gerente.Size = New System.Drawing.Size(206, 22)
        Me.tb_gerente.TabIndex = 10078
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(398, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 10069
        Me.Label8.Text = "(*)Fecha:"
        '
        'tb_representante
        '
        Me.tb_representante.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_representante.Location = New System.Drawing.Point(102, 275)
        Me.tb_representante.MaxLength = 50
        Me.tb_representante.Name = "tb_representante"
        Me.tb_representante.Size = New System.Drawing.Size(206, 22)
        Me.tb_representante.TabIndex = 10080
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(398, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 23)
        Me.Label17.TabIndex = 10085
        Me.Label17.Text = "(*)Zona:"
        '
        'tb_razon
        '
        Me.tb_razon.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_razon.Location = New System.Drawing.Point(101, 28)
        Me.tb_razon.MaxLength = 100
        Me.tb_razon.Name = "tb_razon"
        Me.tb_razon.Size = New System.Drawing.Size(291, 22)
        Me.tb_razon.TabIndex = 10065
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(398, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 23)
        Me.Label18.TabIndex = 10088
        Me.Label18.Text = "(*)Estado:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 10062
        Me.Label4.Text = "Código:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(398, 326)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(137, 20)
        Me.Label21.TabIndex = 10089
        Me.Label21.Text = "(*)Clas. ABC:"
        Me.Label21.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1, 256)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 23)
        Me.Label15.TabIndex = 10082
        Me.Label15.Text = "Gerente:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 32)
        Me.Label13.TabIndex = 10079
        Me.Label13.Text = "(*)Dirección" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Facturación:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(231, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 10075
        Me.Label11.Text = "Fax:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 10073
        Me.Label10.Text = "Teléfono 2:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 10071
        Me.Label9.Text = "Teléfono 1:"
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(1, 54)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 23)
        Me.label6.TabIndex = 10066
        Me.label6.Text = "(*)R.I.F.:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 10064
        Me.Label5.Text = "(*)Razón Social:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(102, 28)
        Me.TextBox1.MaxLength = 100
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 22)
        Me.TextBox1.TabIndex = 10090
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(497, 364)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(133, 23)
        Me.Label24.TabIndex = 10095
        Me.Label24.Text = "(*) Datos Requeridos"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(144, 275)
        Me.TextBox2.MaxLength = 18
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 22)
        Me.TextBox2.TabIndex = 10091
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(229, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 23)
        Me.Label23.TabIndex = 10101
        Me.Label23.Text = "Celular:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(649, 406)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Referencias"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lb_empresa3)
        Me.GroupBox3.Controls.Add(Me.chk_guardar3)
        Me.GroupBox3.Controls.Add(Me.tb_comen3)
        Me.GroupBox3.Controls.Add(Me.dtp_inicio3)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Controls.Add(Me.tb_chequesDev3)
        Me.GroupBox3.Controls.Add(Me.Label49)
        Me.GroupBox3.Controls.Add(Me.tb_montoC3)
        Me.GroupBox3.Controls.Add(Me.cb_empresa3)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Controls.Add(Me.Label51)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(635, 126)
        Me.GroupBox3.TabIndex = 20028
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Referencia 3"
        '
        'lb_empresa3
        '
        Me.lb_empresa3.DataSource = Me.sp_consultaEmpresaBindingSource3
        Me.lb_empresa3.DisplayMember = "RazonSocial"
        Me.lb_empresa3.FormattingEnabled = True
        Me.lb_empresa3.ItemHeight = 15
        Me.lb_empresa3.Location = New System.Drawing.Point(115, 39)
        Me.lb_empresa3.Name = "lb_empresa3"
        Me.lb_empresa3.Size = New System.Drawing.Size(232, 79)
        Me.lb_empresa3.TabIndex = 20017
        Me.lb_empresa3.ValueMember = "Id"
        Me.lb_empresa3.Visible = False
        '
        'sp_consultaEmpresaBindingSource3
        '
        Me.sp_consultaEmpresaBindingSource3.DataMember = "sp_consultaEmpresa"
        Me.sp_consultaEmpresaBindingSource3.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_guardar3
        '
        Me.chk_guardar3.AutoSize = True
        Me.chk_guardar3.Enabled = False
        Me.chk_guardar3.Location = New System.Drawing.Point(410, 70)
        Me.chk_guardar3.Name = "chk_guardar3"
        Me.chk_guardar3.Size = New System.Drawing.Size(61, 19)
        Me.chk_guardar3.TabIndex = 20022
        Me.chk_guardar3.Text = "Activa"
        Me.chk_guardar3.UseVisualStyleBackColor = True
        '
        'tb_comen3
        '
        Me.tb_comen3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_comen3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_comen3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comen3.ForeColor = System.Drawing.Color.Black
        Me.tb_comen3.Location = New System.Drawing.Point(115, 69)
        Me.tb_comen3.Multiline = True
        Me.tb_comen3.Name = "tb_comen3"
        Me.tb_comen3.ReadOnly = True
        Me.tb_comen3.Size = New System.Drawing.Size(232, 49)
        Me.tb_comen3.TabIndex = 20019
        '
        'dtp_inicio3
        '
        Me.dtp_inicio3.Enabled = False
        Me.dtp_inicio3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inicio3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicio3.Location = New System.Drawing.Point(526, 15)
        Me.dtp_inicio3.Name = "dtp_inicio3"
        Me.dtp_inicio3.Size = New System.Drawing.Size(105, 22)
        Me.dtp_inicio3.TabIndex = 20020
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(407, 18)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(106, 19)
        Me.Label48.TabIndex = 20024
        Me.Label48.Text = "Inicio relaciones:"
        '
        'tb_chequesDev3
        '
        Me.tb_chequesDev3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_chequesDev3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_chequesDev3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_chequesDev3.ForeColor = System.Drawing.Color.Black
        Me.tb_chequesDev3.Location = New System.Drawing.Point(526, 41)
        Me.tb_chequesDev3.Name = "tb_chequesDev3"
        Me.tb_chequesDev3.ReadOnly = True
        Me.tb_chequesDev3.Size = New System.Drawing.Size(88, 21)
        Me.tb_chequesDev3.TabIndex = 20021
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(407, 43)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(109, 19)
        Me.Label49.TabIndex = 20022
        Me.Label49.Text = "(*)Cheques. Dev.:"
        '
        'tb_montoC3
        '
        Me.tb_montoC3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_montoC3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_montoC3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_montoC3.ForeColor = System.Drawing.Color.Black
        Me.tb_montoC3.Location = New System.Drawing.Point(115, 45)
        Me.tb_montoC3.Name = "tb_montoC3"
        Me.tb_montoC3.ReadOnly = True
        Me.tb_montoC3.Size = New System.Drawing.Size(88, 21)
        Me.tb_montoC3.TabIndex = 20018
        '
        'cb_empresa3
        '
        Me.cb_empresa3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_empresa3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_empresa3.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_empresa3.ForeColor = System.Drawing.Color.Black
        Me.cb_empresa3.Location = New System.Drawing.Point(115, 21)
        Me.cb_empresa3.Name = "cb_empresa3"
        Me.cb_empresa3.ReadOnly = True
        Me.cb_empresa3.Size = New System.Drawing.Size(232, 21)
        Me.cb_empresa3.TabIndex = 20016
        Me.cb_empresa3.Text = "Seleccione"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(6, 69)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(88, 18)
        Me.Label47.TabIndex = 20026
        Me.Label47.Text = "Comentarios:"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(6, 23)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(106, 20)
        Me.Label50.TabIndex = 20018
        Me.Label50.Text = "(*)Razón Social:"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(6, 47)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(111, 19)
        Me.Label51.TabIndex = 20020
        Me.Label51.Text = "(*)Monto Crédito:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lb_empresa2)
        Me.GroupBox2.Controls.Add(Me.chk_guardar2)
        Me.GroupBox2.Controls.Add(Me.tb_comen2)
        Me.GroupBox2.Controls.Add(Me.dtp_inicio2)
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.tb_chequesDev2)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.tb_montoC2)
        Me.GroupBox2.Controls.Add(Me.cb_empresa2)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 126)
        Me.GroupBox2.TabIndex = 20027
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Referencia 2"
        '
        'lb_empresa2
        '
        Me.lb_empresa2.DataSource = Me.sp_consultaEmpresaBindingSource2
        Me.lb_empresa2.DisplayMember = "RazonSocial"
        Me.lb_empresa2.FormattingEnabled = True
        Me.lb_empresa2.ItemHeight = 15
        Me.lb_empresa2.Location = New System.Drawing.Point(116, 39)
        Me.lb_empresa2.Name = "lb_empresa2"
        Me.lb_empresa2.Size = New System.Drawing.Size(232, 79)
        Me.lb_empresa2.TabIndex = 20017
        Me.lb_empresa2.ValueMember = "Id"
        Me.lb_empresa2.Visible = False
        '
        'sp_consultaEmpresaBindingSource2
        '
        Me.sp_consultaEmpresaBindingSource2.DataMember = "sp_consultaEmpresa"
        Me.sp_consultaEmpresaBindingSource2.DataSource = Me.MELDataSet
        '
        'chk_guardar2
        '
        Me.chk_guardar2.AutoSize = True
        Me.chk_guardar2.Enabled = False
        Me.chk_guardar2.Location = New System.Drawing.Point(410, 70)
        Me.chk_guardar2.Name = "chk_guardar2"
        Me.chk_guardar2.Size = New System.Drawing.Size(61, 19)
        Me.chk_guardar2.TabIndex = 20022
        Me.chk_guardar2.Text = "Activa"
        Me.chk_guardar2.UseVisualStyleBackColor = True
        '
        'tb_comen2
        '
        Me.tb_comen2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_comen2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_comen2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comen2.ForeColor = System.Drawing.Color.Black
        Me.tb_comen2.Location = New System.Drawing.Point(116, 69)
        Me.tb_comen2.Multiline = True
        Me.tb_comen2.Name = "tb_comen2"
        Me.tb_comen2.ReadOnly = True
        Me.tb_comen2.Size = New System.Drawing.Size(232, 49)
        Me.tb_comen2.TabIndex = 20019
        '
        'dtp_inicio2
        '
        Me.dtp_inicio2.Enabled = False
        Me.dtp_inicio2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inicio2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicio2.Location = New System.Drawing.Point(527, 15)
        Me.dtp_inicio2.Name = "dtp_inicio2"
        Me.dtp_inicio2.Size = New System.Drawing.Size(105, 22)
        Me.dtp_inicio2.TabIndex = 20020
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(408, 18)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(106, 19)
        Me.Label43.TabIndex = 20024
        Me.Label43.Text = "Inicio relaciones:"
        '
        'tb_chequesDev2
        '
        Me.tb_chequesDev2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_chequesDev2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_chequesDev2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_chequesDev2.ForeColor = System.Drawing.Color.Black
        Me.tb_chequesDev2.Location = New System.Drawing.Point(527, 41)
        Me.tb_chequesDev2.Name = "tb_chequesDev2"
        Me.tb_chequesDev2.ReadOnly = True
        Me.tb_chequesDev2.Size = New System.Drawing.Size(88, 21)
        Me.tb_chequesDev2.TabIndex = 20021
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(408, 43)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(97, 19)
        Me.Label44.TabIndex = 20022
        Me.Label44.Text = "(*)Cheques. Dev.:"
        '
        'tb_montoC2
        '
        Me.tb_montoC2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_montoC2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_montoC2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_montoC2.ForeColor = System.Drawing.Color.Black
        Me.tb_montoC2.Location = New System.Drawing.Point(116, 45)
        Me.tb_montoC2.Name = "tb_montoC2"
        Me.tb_montoC2.ReadOnly = True
        Me.tb_montoC2.Size = New System.Drawing.Size(88, 21)
        Me.tb_montoC2.TabIndex = 20018
        '
        'cb_empresa2
        '
        Me.cb_empresa2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_empresa2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_empresa2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_empresa2.ForeColor = System.Drawing.Color.Black
        Me.cb_empresa2.Location = New System.Drawing.Point(116, 21)
        Me.cb_empresa2.Name = "cb_empresa2"
        Me.cb_empresa2.ReadOnly = True
        Me.cb_empresa2.Size = New System.Drawing.Size(232, 21)
        Me.cb_empresa2.TabIndex = 20016
        Me.cb_empresa2.Text = "Seleccione"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(6, 69)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 18)
        Me.Label42.TabIndex = 20026
        Me.Label42.Text = "Comentarios:"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(7, 23)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(98, 20)
        Me.Label45.TabIndex = 20018
        Me.Label45.Text = "(*)Razón Social:"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(6, 47)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(111, 19)
        Me.Label46.TabIndex = 20020
        Me.Label46.Text = "(*)Monto Crédito:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_empresa)
        Me.GroupBox1.Controls.Add(Me.chk_guardar)
        Me.GroupBox1.Controls.Add(Me.tb_comen)
        Me.GroupBox1.Controls.Add(Me.dtp_inicio)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.tb_chequesDev)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.tb_montoC)
        Me.GroupBox1.Controls.Add(Me.cb_empresa)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 126)
        Me.GroupBox1.TabIndex = 20019
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referencia 1"
        '
        'lb_empresa
        '
        Me.lb_empresa.DataSource = Me.Sp_consultaEmpresaBindingSource
        Me.lb_empresa.DisplayMember = "RazonSocial"
        Me.lb_empresa.FormattingEnabled = True
        Me.lb_empresa.ItemHeight = 15
        Me.lb_empresa.Location = New System.Drawing.Point(117, 39)
        Me.lb_empresa.Name = "lb_empresa"
        Me.lb_empresa.Size = New System.Drawing.Size(232, 79)
        Me.lb_empresa.TabIndex = 20017
        Me.lb_empresa.ValueMember = "Id"
        Me.lb_empresa.Visible = False
        '
        'Sp_consultaEmpresaBindingSource
        '
        Me.Sp_consultaEmpresaBindingSource.DataMember = "sp_consultaEmpresa"
        Me.Sp_consultaEmpresaBindingSource.DataSource = Me.MELDataSet
        '
        'chk_guardar
        '
        Me.chk_guardar.AutoSize = True
        Me.chk_guardar.Checked = True
        Me.chk_guardar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_guardar.Enabled = False
        Me.chk_guardar.Location = New System.Drawing.Point(412, 70)
        Me.chk_guardar.Name = "chk_guardar"
        Me.chk_guardar.Size = New System.Drawing.Size(61, 19)
        Me.chk_guardar.TabIndex = 20022
        Me.chk_guardar.Text = "Activa"
        Me.chk_guardar.UseVisualStyleBackColor = True
        '
        'tb_comen
        '
        Me.tb_comen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_comen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_comen.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comen.ForeColor = System.Drawing.Color.Black
        Me.tb_comen.Location = New System.Drawing.Point(117, 69)
        Me.tb_comen.Multiline = True
        Me.tb_comen.Name = "tb_comen"
        Me.tb_comen.ReadOnly = True
        Me.tb_comen.Size = New System.Drawing.Size(232, 49)
        Me.tb_comen.TabIndex = 20019
        '
        'dtp_inicio
        '
        Me.dtp_inicio.Enabled = False
        Me.dtp_inicio.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicio.Location = New System.Drawing.Point(528, 15)
        Me.dtp_inicio.Name = "dtp_inicio"
        Me.dtp_inicio.Size = New System.Drawing.Size(105, 22)
        Me.dtp_inicio.TabIndex = 20020
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(409, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(106, 19)
        Me.Label40.TabIndex = 20024
        Me.Label40.Text = "Inicio relaciones:"
        '
        'tb_chequesDev
        '
        Me.tb_chequesDev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_chequesDev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_chequesDev.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_chequesDev.ForeColor = System.Drawing.Color.Black
        Me.tb_chequesDev.Location = New System.Drawing.Point(528, 41)
        Me.tb_chequesDev.Name = "tb_chequesDev"
        Me.tb_chequesDev.ReadOnly = True
        Me.tb_chequesDev.Size = New System.Drawing.Size(88, 21)
        Me.tb_chequesDev.TabIndex = 20021
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(409, 43)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(119, 19)
        Me.Label39.TabIndex = 20022
        Me.Label39.Text = "(*)Cheques. Dev.:"
        '
        'tb_montoC
        '
        Me.tb_montoC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_montoC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_montoC.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_montoC.ForeColor = System.Drawing.Color.Black
        Me.tb_montoC.Location = New System.Drawing.Point(117, 45)
        Me.tb_montoC.Name = "tb_montoC"
        Me.tb_montoC.ReadOnly = True
        Me.tb_montoC.Size = New System.Drawing.Size(88, 21)
        Me.tb_montoC.TabIndex = 20018
        '
        'cb_empresa
        '
        Me.cb_empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_empresa.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_empresa.ForeColor = System.Drawing.Color.Black
        Me.cb_empresa.Location = New System.Drawing.Point(117, 21)
        Me.cb_empresa.Name = "cb_empresa"
        Me.cb_empresa.ReadOnly = True
        Me.cb_empresa.Size = New System.Drawing.Size(232, 21)
        Me.cb_empresa.TabIndex = 20016
        Me.cb_empresa.Text = "Seleccione"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(8, 69)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 18)
        Me.Label41.TabIndex = 20026
        Me.Label41.Text = "Comentarios:"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 23)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(98, 20)
        Me.Label37.TabIndex = 20018
        Me.Label37.Text = "(*)Razón Social:"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 47)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(111, 19)
        Me.Label38.TabIndex = 20020
        Me.Label38.Text = "(*)Monto Crédito:"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(722, 436)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 10093
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(637, 436)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 10092
        Me.bt_aceptar.Text = "Aceptar"
        '
        'Sp_consultaEmpresaTableAdapter
        '
        Me.Sp_consultaEmpresaTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaEmpresaTableAdapter2
        '
        Me.Sp_consultaEmpresaTableAdapter2.ClearBeforeFill = True
        '
        'Sp_consultaEmpresaTableAdapter3
        '
        Me.Sp_consultaEmpresaTableAdapter3.ClearBeforeFill = True
        '
        'Frm_Clientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1048, 728)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tb_vendedor2)
        Me.Controls.Add(Me.chk_filtro)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGV_Fact)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.DataGridViewRazon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.MaximizeBox = False
        Me.Name = "Frm_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Clientes"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Fact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewRazon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.sp_consultaEmpresaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.sp_consultaEmpresaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Sp_consultaEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Me.tb_clasificacion.ReadOnly = True
        Me.tb_codigo.ReadOnly = True
        Me.tb_direccion.ReadOnly = True
        Me.tb_email.ReadOnly = True
        Me.tb_estado.Enabled = False
        Me.tb_fax.ReadOnly = True
        Me.tb_fecha.Enabled = False
        Me.tb_gerente.ReadOnly = True
        Me.tb_razon.ReadOnly = True
        Me.tb_representante.ReadOnly = True
        Me.tb_rif.ReadOnly = True
        Me.tb_telefono1.ReadOnly = True
        Me.tb_telefono2.ReadOnly = True
        Me.tb_vendedor.Enabled = False
        Me.tb_zona.Enabled = False
        Me.ch_contribuyente.Enabled = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Datos.consulta_vendedores(Me.tb_vendedor)
        Datos.consulta_vendedores(Me.tb_vendedor2)
        'Datos.consulta_zonas(Me.tb_zona)
        Dim cant As Integer = 0
        Datos.consulta_clientes(Me.DataGridViewRazon, cant)
        Label2.Text = cant
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código")
        Me.DomainUpDown1.Items.Add("Razón Social")
        Me.DomainUpDown1.SelectedIndex = 1
        DataGridViewRazon.ClearSelection()
        tb_buscarcodigo.Focus()
        tb_buscarcodigo.Select()

        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If
        If Me.e = False Then
            Me.bt_autorizar.Visible = False
            Me.chk_auto.Enabled = False
        End If
        Me.bt_autorizar.Visible = Me.e
    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Public Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then
            If swC = True Then
                swC = False
            End If
            If swX Then
                swX = False
            End If
            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo Then
            cli = True
            varBoton = 1
            limpia()

            Me.chk_filtro.Checked = False
            Me.chk_filtro.Enabled = False

            Datos.consulta_vendedores(Me.tb_vendedor)
            Datos.consulta_zonas(Me.tb_zona)

            Me.tb_estado.Items.Clear()
            Me.DGV_Fact.Rows.Clear()
            Me.DataGridView1.Rows.Clear()
            Me.tb_user.Clear()

            Me.MELDataSet.EnforceConstraints = False
            Me.Sp_consultaEmpresaTableAdapter.Fill(Me.MELDataSet.sp_consultaEmpresa, "", 0, 2)
            Me.Sp_consultaEmpresaTableAdapter2.Fill(Me.MELDataSet.sp_consultaEmpresa, "", 0, 2)
            Me.Sp_consultaEmpresaTableAdapter3.Fill(Me.MELDataSet.sp_consultaEmpresa, "", 0, 2)

            chk_guardar.Enabled = True
            chk_guardar_CheckedChanged(chk_guardar, New EventArgs)
            chk_guardar2.Enabled = True
            chk_guardar2_CheckedChanged(chk_guardar2, New EventArgs)
            chk_guardar3.Enabled = True
            chk_guardar3_CheckedChanged(chk_guardar3, New EventArgs)

            chk_cambiarCod.Visible = True
            chk_cambiarCod.Enabled = False
            chk_cambiarCod.Checked = True

            user1 = ""
            Me.Label30.Text = "0,00"
            Me.lb_vencido.Text = "0,00"
            Me.lb_porVencer.Text = "0,00"
            Me.bt_chequearRIF.Enabled = True
            Me.DataGridViewRazon.Enabled = False
            Me.chk_fletePago.Checked = False
            Me.chk_filtro.Enabled = False
            Me.tb_vendedor2.Enabled = False
            Me.tb_direccionE.ReadOnly = False
            Me.tb_direccionE.Clear()
            Me.tb_user.ReadOnly = False
            Me.tb_limite.Enabled = True
            Me.tb_password.ReadOnly = False
            Me.tb_codigo.Clear()
            Me.chk_fletePago.Enabled = True
            Me.tb_buscarcodigo.Enabled = False
            Me.ToolBar1.Enabled = False
            Me.tb_user.ClearUndo()
            Me.tb_password.Clear()
            Me.DomainUpDown1.Enabled = False
            Me.tb_celular.ReadOnly = False
            Me.tb_observacion.ReadOnly = False
            Me.tb_clasificacion.ReadOnly = False
            Me.tb_direccion.ReadOnly = False
            Me.tb_email.ReadOnly = False
            Me.tb_estado.Enabled = True
            Me.tb_fax.ReadOnly = False
            Me.tb_fecha.Enabled = True
            Me.tb_gerente.ReadOnly = False
            Me.tb_razon.ReadOnly = False
            Me.tb_representante.ReadOnly = False
            Me.tb_rif.ReadOnly = False
            Me.tb_telefono1.ReadOnly = False
            Me.tb_telefono2.ReadOnly = False
            Me.tb_vendedor.Enabled = True
            Me.tb_zona.Enabled = True
            chk_auto.Enabled = True
            Me.ch_contribuyente.Enabled = True
            Me.bt_aceptar.Visible = True
            Me.bt_cancelar.Visible = True
            Me.DataGridViewRazon.ClearSelection()
            Me.chk_auto.Checked = True

            If TabControl1.SelectedIndex = 1 Then
                chk_guardar.Checked = True
                cb_empresa.Focus()
            ElseIf TabControl1.SelectedIndex = 0 Then
                Me.tb_vendedor.DroppedDown = True
                Me.tb_vendedor.Focus()
            End If

            Me.DomainUpDown1.SelectedIndex = 1
            tb_clasificacion.Text = "C"
            RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            Me.tb_buscarcodigo.Clear()
            AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged

        ElseIf e.Button Is Me.bt_modificar Then
            varBoton = 2
            cli = True
            Dim n1 As Integer
            n1 = Me.DataGridViewRazon.SelectedRows.Count

            If n1 = 1 Then

                Me.MELDataSet.EnforceConstraints = False
                Me.Sp_consultaEmpresaTableAdapter.Fill(Me.MELDataSet.sp_consultaEmpresa, "", 0, 2)
                Me.Sp_consultaEmpresaTableAdapter2.Fill(Me.MELDataSet.sp_consultaEmpresa, "", 0, 2)
                Me.Sp_consultaEmpresaTableAdapter3.Fill(Me.MELDataSet.sp_consultaEmpresa, "", 0, 2)

                dirCliente = tb_direccion.Text
                dirEnvio = tb_direccionE.Text

                Me.chk_filtro.Enabled = False
                Usuario = tb_user.Text
                password = tb_password.Text
                user1 = tb_user.Text
                Me.tb_vendedor.Enabled = True
                Me.bt_chequearRIF.Enabled = True
                Me.tb_codigo.Enabled = True
                Me.DataGridViewRazon.Enabled = False
                Me.tb_buscarcodigo.Enabled = False
                Me.tb_user.ReadOnly = False
                Me.tb_direccionE.ReadOnly = False
                chk_cambiarCod.Visible = True
                Me.chk_filtro.Enabled = False
                Me.tb_vendedor2.Enabled = False

                dir = tb_direccion.Text

                chk_guardar.Enabled = True
                chk_guardar_CheckedChanged(chk_guardar, New EventArgs)
                chk_guardar2.Enabled = True
                chk_guardar2_CheckedChanged(chk_guardar2, New EventArgs)
                chk_guardar3.Enabled = True
                chk_guardar3_CheckedChanged(chk_guardar3, New EventArgs)

                Me.tb_limite.Enabled = True
                Me.chk_fletePago.Enabled = True
                Me.tb_password.ReadOnly = False
                Me.ToolBar1.Enabled = False
                Me.DomainUpDown1.Enabled = False
                Me.CodigoAnt = tb_codigo.Text
                Me.tb_clasificacion.ReadOnly = False
                Me.tb_direccion.ReadOnly = False
                Me.tb_email.ReadOnly = False

                If Me.e = False Then
                    Me.chk_auto.Enabled = False
                Else
                    Me.chk_auto.Enabled = True
                End If

                Me.tb_celular.ReadOnly = False
                Me.tb_observacion.ReadOnly = False
                Me.tb_estado.Enabled = True
                Me.tb_fax.ReadOnly = False
                Me.tb_fecha.Enabled = True
                Me.tb_gerente.ReadOnly = False
                Me.tb_razon.ReadOnly = False
                Me.tb_representante.ReadOnly = False
                Me.tb_rif.ReadOnly = False
                Me.tb_telefono1.ReadOnly = False
                Me.tb_telefono2.ReadOnly = False
                Me.tb_zona.Enabled = True
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                Me.ch_contribuyente.Enabled = True

                If TabControl1.SelectedIndex = 1 Then
                    cb_empresa.Focus()
                End If

                'Me.DomainUpDown1.SelectedIndex = 1
                RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
                'Me.tb_buscarcodigo.Clear()
                AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            ElseIf n1 = 0 Then
                MsgBox("Debe seleccionar el cliente que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                MsgBox("Solo puede modificar un cliente a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")
            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            varBoton = 3


            Dim n2 As Integer
            Dim response As MsgBoxResult
            Dim cod As Integer
            n2 = Me.DataGridViewRazon.SelectedRows.Count

            If n2 = 0 Then
                MsgBox("Debe seleccionar el cliente que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
            ElseIf n2 = 1 Then

                response = MsgBox("¿Confirma que desea eliminar el cliente '" + Me.DataGridViewRazon.SelectedRows(0).Cells(1).Value + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                If (response = MsgBoxResult.Yes) Then
                    cod = CInt(Me.DataGridViewRazon.SelectedRows(0).Cells(0).Value)

                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                    '    Datos.elimina_cliente_dist(cod)
                    '    Datos.elimina_cliente_comer(cod)
                    '    Datos.elimina_cliente_CONAVE(cod)

                    'Else

                    Datos.elimina_cliente(cod)

                    'End If

                    clientes2 = True

                    If tb_user.Text <> "" And tb_password.Text <> "" Then

                        datos2 = True

                    End If

                    Datos.Inserta_Actividad("Eliminó el cliente (" + tb_codigo.Text + ") " + tb_razon.Text)

                    MsgBox("Cliente Eliminado Exitosamente")
                    Me.DataGridViewRazon.Rows.Clear()

                    limpia()
                    LimpiarReferencias()
                    Dim cant As Integer = 0
                    Datos.consulta_clientes(DataGridViewRazon, cant)
                    Label2.Text = cant
            End If
            Else
            End If
            Me.DataGridViewRazon.ClearSelection()

        ElseIf e.Button Is Me.bt_autorizar Then

            If DataGridViewRazon.SelectedRows.Count > 0 Then

                If chk_auto.Checked Then

                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                    '    Datos.Autoriza_Desautoriza_Cliente_dist(DataGridViewRazon.SelectedRows(0).Cells(0).Value, False)
                    '    Datos.Autoriza_Desautoriza_Cliente_comer(DataGridViewRazon.SelectedRows(0).Cells(0).Value, False)
                    '    Datos.Autoriza_Desautoriza_Cliente_CONAVE(DataGridViewRazon.SelectedRows(0).Cells(0).Value, False)
                    '    MsgBox("Cliente desautorizado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
                    'Else
                    Datos.Autoriza_Desautoriza_Cliente(DataGridViewRazon.SelectedRows(0).Cells(0).Value, False)
                    'End If

                    Datos.Inserta_Actividad("Desautorizó el cliente (" + tb_codigo.Text + ") " + tb_razon.Text)

                Else

                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                    '    Datos.Autoriza_Desautoriza_Cliente_dist(DataGridViewRazon.SelectedRows(0).Cells(0).Value, True)
                    '    Datos.Autoriza_Desautoriza_Cliente_comer(DataGridViewRazon.SelectedRows(0).Cells(0).Value, True)
                    '    Datos.Autoriza_Desautoriza_Cliente_CONAVE(DataGridViewRazon.SelectedRows(0).Cells(0).Value, True)
                    '    MsgBox("Cliente autorizado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
                    'Else
                    Datos.Autoriza_Desautoriza_Cliente(DataGridViewRazon.SelectedRows(0).Cells(0).Value, True)
                    'End If

                    Datos.Inserta_Actividad("Autorizó el cliente (" + tb_codigo.Text + ") " + tb_razon.Text)

                End If

            DataGridViewRazon_SelectionChanged(DataGridViewRazon, New EventArgs)

        Else

            MsgBox("Debe seleccionar un cliente para autorizar/desautorizar", MsgBoxStyle.Exclamation, "SINPRO")

        End If

        End If
    End Sub
    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        cli = False
        Me.DataGridViewRazon.Enabled = True
        LimpiarReferencias()

        chk_guardar.Checked = False
        chk_guardar2.Checked = False
        chk_guardar3.Checked = False

        chk_guardar.Enabled = False
        chk_guardar2.Enabled = False
        chk_guardar3.Enabled = False

        Me.tb_buscarcodigo.Enabled = True
        Me.ToolBar1.Enabled = True
        Me.DomainUpDown1.Enabled = True
        Me.tb_codigo.Clear()
        Me.tb_user.ReadOnly = True
        Me.chk_filtro.Enabled = True
        'Me.tb_vendedor2.Enabled = True
        Me.bt_chequearRIF.Enabled = False
        Me.tb_password.ReadOnly = True
        Me.tb_clasificacion.Clear()
        Me.tb_direccion.Clear()
        user1 = ""
        Me.tb_direccionE.ReadOnly = True
        Me.tb_direccionE.Clear()
        Me.Label30.Text = "0,00"
        Me.lb_vencido.Text = "0,00"
        Me.lb_porVencer.Text = "0,00"
        Me.lb_totalDeuda.Text = "0,00"
        Me.chk_auto.Enabled = False
        Me.chk_filtro.Enabled = True
        Me.chk_filtro.Checked = False
        Me.chk_cambiarCod.Visible = False
        Me.chk_cambiarCod.Checked = False
        Me.tb_email.Clear()
        Me.tb_vendedor.Items.Clear()
        Me.tb_vendedor.ResetText()
        Me.tb_zona.Items.Clear()
        Me.tb_zona.ResetText()
        Me.tb_user.Clear()
        Me.chk_fletePago.Enabled = False
        Me.tb_password.Clear()
        Me.tb_estado.Enabled = False
        Me.tb_vendedor.Enabled = False
        Me.tb_zona.Enabled = False
        Me.tb_estado.Items.Clear()
        Me.tb_estado.ResetText()
        Me.tb_fax.Clear()
        Me.tb_fecha.ResetText()
        Me.tb_gerente.Clear()
        Me.tb_razon.Clear()
        Me.tb_representante.Clear()
        Me.tb_rif.Clear()
        Me.tb_telefono1.Clear()
        Me.tb_telefono2.Clear()
        Me.tb_celular.ReadOnly = True
        Me.tb_observacion.ReadOnly = True
        tb_celular.Clear()
        tb_observacion.Clear()
        Me.ch_contribuyente.Checked = False
        Me.ch_contribuyente.Enabled = False
        Me.tb_clasificacion.ReadOnly = True
        Me.tb_direccion.ReadOnly = True
        Me.tb_email.ReadOnly = True
        Me.tb_fax.ReadOnly = True
        Me.tb_fecha.Enabled = False
        Me.tb_gerente.ReadOnly = True
        Me.tb_razon.ReadOnly = True
        Me.tb_representante.ReadOnly = True
        Me.tb_rif.ReadOnly = True
        Me.tb_telefono1.ReadOnly = True
        Me.tb_telefono2.ReadOnly = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.tb_limite.Enabled = False
        Me.tb_codigo.Enabled = True
        varBoton = 0
        Me.DomainUpDown1.SelectedItem = 1
        Dim cant As Integer = 0
        Datos.consulta_clientes(Me.DataGridViewRazon, cant)
        Me.DataGridViewRazon.ClearSelection()
        Me.DGV_Fact.Rows.Clear()
        Me.DataGridView1.Rows.Clear()
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
        Me.tb_buscarcodigo.Select()
    End Sub

    Private Function llenos() As Boolean

        Dim ll As Boolean = False

        If Me.tb_razon.Text = "" Or Me.tb_rif.Text = "" Or Me.tb_fecha.Text = "" Or Me.tb_vendedor.Text = "" Or Me.tb_zona.Text = "" Or Me.tb_estado.Text = "" Or Me.tb_clasificacion.Text = "" Or tb_direccion.Text = "" Then
            ll = True
        Else
            ll = False

            If chk_guardar.Checked Then
                If tb_montoC.Text.Trim <> "" And tb_chequesDev.Text.Trim <> "" And cb_empresa.Text.Trim <> "" Then
                    ll = False
                Else
                    ll = True
                End If
            End If

            If chk_guardar2.Checked Then
                If tb_montoC2.Text.Trim <> "" And tb_chequesDev2.Text.Trim <> "" And cb_empresa2.Text.Trim <> "" Then
                    ll = False
                Else
                    ll = True
                End If
            End If

            If chk_guardar3.Checked Then
                If tb_montoC3.Text.Trim <> "" And tb_chequesDev3.Text.Trim <> "" And cb_empresa3.Text.Trim <> "" Then
                    ll = False
                Else
                    ll = True
                End If
            End If

        End If

        Return ll
    End Function



    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False
        Dim clien As Integer = 0
        Dim usuario As Boolean = False

        If tb_limite.Text.Trim = "" Then
            tb_limite.Text = "0,00"
        End If

        cli = False
        If (varBoton = 1) Then
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else

                If tb_direccionE.Text = "" Then
                    tb_direccionE.Text = tb_direccion.Text
                End If

                If Datos.ExisteRif(tb_rif.Text) = False Then

                    DatosUsuarios.consulta_usuario_existe(tb_user.Text, usuario)

                    If usuario = False Then

                        tb_direccion.Text = tb_direccion.Text.Replace(Chr(13), " ")

                        If tb_user.Text.Trim <> "" And tb_password.Text.Trim <> "" Then

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                            '    DatosUsuarios.modifica_password_Dist(tb_user.Text, tb_password.Text, 3, user1, False)
                            '    DatosUsuarios.modifica_password_comer(tb_user.Text, tb_password.Text, 3, user1, False)
                            '    DatosUsuarios.modifica_password_CONAVE(tb_user.Text, tb_password.Text, 3, user1, False)

                            'Else

                            DatosUsuarios.modifica_password(tb_user.Text, tb_password.Text, 3, user1, False, tb_razon.Text)

                            'End If

                        End If

                        'If My.Settings.Empresa = 4 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 6 Then

                        '    Datos.inserta_cliente_Dist(tb_codigo.Text, tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, CInt(Me.tb_vendedor.SelectedItem.Col2()), tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.Col1, tb_clasificacion.Text, chk_auto.Checked, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
                        '    Datos.inserta_cliente_comer(tb_codigo.Text, tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, CInt(Me.tb_vendedor.SelectedItem.Col2()), tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.Col1, tb_clasificacion.Text, chk_auto.Checked, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
                        '    Datos.inserta_cliente_CONAVE(tb_codigo.Text, tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, CInt(Me.tb_vendedor.SelectedItem.Col2()), tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.Col1, tb_clasificacion.Text, chk_auto.Checked, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
                        '    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Cliente Ha Sido Registrado Exitosamente", ToolTipIcon.Info)

                        'Else
                        Datos.inserta_cliente(tb_codigo.Text, tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, CInt(Me.tb_vendedor.SelectedItem.Col2()), tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.Col1, tb_clasificacion.Text, chk_auto.Checked, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
                        'End If

                        Datos.Inserta_Actividad("Creó el cliente (" + tb_codigo.Text + ") " + tb_razon.Text)

                        If chk_guardar.Checked Then

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                            '    Datos.InsertaReferencia_dist(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)
                            '    Datos.InsertaReferencia_comer(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)
                            '    Datos.InsertaReferencia_CONAVE(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)

                            'Else

                            Datos.InsertaReferencia(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)

                            'End If

                        End If

                        If chk_guardar2.Checked Then

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                            '    Datos.InsertaReferencia_dist(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)
                            '    Datos.InsertaReferencia_comer(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)
                            '    Datos.InsertaReferencia_CONAVE(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)

                            'Else

                            Datos.InsertaReferencia(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)

                            'End If

                        End If

                        If chk_guardar3.Checked Then

                            'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                            '    Datos.InsertaReferencia_dist(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                            '    Datos.InsertaReferencia_comer(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                            '    Datos.InsertaReferencia_CONAVE(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                            'Else
                            Datos.InsertaReferencia(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                            'End If

                        End If

                        datos2 = True

                        If tb_user.Text <> "" And tb_password.Text <> "" Then

                            clientes2 = True

                        End If

                    Else

                        MsgBox("El usuario ya se encuentra registrado", MsgBoxStyle.Critical)
                        deny = True
                        tb_user.Focus()
                        tb_user.SelectAll()

                    End If

                Else
                    MsgBox("El rif ya está registrado para otro cliente", MsgBoxStyle.Exclamation, "SINPRO")
                    deny = True
                    tb_rif.Focus()
                    tb_rif.SelectAll()
                End If

            End If
        ElseIf (varBoton = 2) Then

            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else

                Dim detener As Boolean = False

                If tb_user.Text.Trim <> "" And tb_password.Text.Trim <> "" Then

                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                    '    DatosUsuarios.modifica_password_Dist(tb_user.Text, tb_password.Text, 3, user1, detener)
                    '    DatosUsuarios.modifica_password_comer(tb_user.Text, tb_password.Text, 3, user1, detener)
                    '    DatosUsuarios.modifica_password_CONAVE(tb_user.Text, tb_password.Text, 3, user1, detener)

                    'Else

                    DatosUsuarios.modifica_password(tb_user.Text, tb_password.Text, 3, user1, detener, tb_razon.Text)

                    'End If

                    Datos.Inserta_Actividad("Modificó el cliente (" + tb_codigo.Text + ") " + tb_razon.Text)

            End If

                If detener = False Then

                    clien = CInt(tb_codigo.Text)

                    tb_direccion.Text = tb_direccion.Text.Replace(Chr(13), " ")

                    'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                    '    If dirCliente = dirEnvio Then

                    '        Datos.modifica_cliente_dist(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)
                    '        Datos.modifica_cliente_comer(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)
                    '        Datos.modifica_cliente_CONAVE(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)

                    '    Else
                    '        If dir <> tb_direccion.Text Then
                    '            Dim resp As Integer = MsgBox("Desea copiar la dirección fiscal en la dirección de envío?", MsgBoxStyle.YesNo, "SINPRO")

                    '            If resp = vbYes Then
                    '                Datos.modifica_cliente_dist(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)
                    '                Datos.modifica_cliente_comer(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)
                    '                Datos.modifica_cliente_CONAVE(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)
                    '            Else
                    '                Datos.modifica_cliente_dist(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)
                    '                Datos.modifica_cliente_comer(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)
                    '                Datos.modifica_cliente_CONAVE(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)

                    '            End If

                    '        Else
                    '            Datos.modifica_cliente_dist(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)
                    '            Datos.modifica_cliente_comer(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)
                    '            Datos.modifica_cliente_CONAVE(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)
                    '        End If

                    '    End If

                    '    Datos.EliminaReferenciasCliente_dist(CInt(tb_codigo.Text))
                    '    Datos.EliminaReferenciasCliente_comer(CInt(tb_codigo.Text))
                    '    Datos.EliminaReferenciasCliente_CONAVE(CInt(tb_codigo.Text))
                    '    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "El Cliente Ha Sido Modificado Exitosamente", ToolTipIcon.Info)

                    'Else

                    If dirCliente = dirEnvio Then
                        Datos.modifica_cliente(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)
                    Else

                        If dir <> tb_direccion.Text Then

                            Dim resp As Integer = MsgBox("Desea copiar la dirección fiscal en la dirección de envío?", MsgBoxStyle.YesNo, "SINPRO")

                            If resp = vbYes Then
                                Datos.modifica_cliente(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccion.Text)
                            Else
                                Datos.modifica_cliente(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)
                            End If

                        Else

                            Datos.modifica_cliente(tb_razon.Text, tb_rif.Text, Me.tb_fecha.Value, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, tb_vendedor.SelectedItem.Col2, tb_zona.SelectedItem.Col2, tb_estado.SelectedItem.col1, tb_clasificacion.Text, chk_auto.Checked, CInt(tb_codigo.Text), Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, tb_user.Text, tb_password.Text, tb_limite.Text, CInt(CodigoAnt), chk_fletePago.Checked, tb_direccionE.Text)

                        End If

                    End If

                    Datos.EliminaReferenciasCliente(CInt(tb_codigo.Text))

                    'End If

                    If chk_guardar.Checked Then

                        'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                        '    Datos.InsertaReferencia_dist(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)
                        '    Datos.InsertaReferencia_comer(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)
                        '    Datos.InsertaReferencia_CONAVE(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)

                        'Else

                        Datos.InsertaReferencia(CInt(tb_codigo.Text), CInt(cb_empresa.Tag), CDbl(tb_montoC.Text), CInt(tb_chequesDev.Text), dtp_inicio.Value, tb_comen.Text)

                        'End If

                    End If

                    If chk_guardar2.Checked Then

                        'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

                        '    Datos.InsertaReferencia_dist(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)
                        '    Datos.InsertaReferencia_comer(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)
                        '    Datos.InsertaReferencia_CONAVE(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)

                        'Else

                        Datos.InsertaReferencia(CInt(tb_codigo.Text), CInt(cb_empresa2.Tag), CDbl(tb_montoC2.Text), CInt(tb_chequesDev2.Text), dtp_inicio2.Value, tb_comen2.Text)

                        'End If

                    End If

                    If chk_guardar3.Checked Then

                        'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then
                        '    Datos.InsertaReferencia_dist(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                        '    Datos.InsertaReferencia_comer(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                        '    Datos.InsertaReferencia_CONAVE(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                        'Else
                        Datos.InsertaReferencia(CInt(tb_codigo.Text), CInt(cb_empresa3.Tag), CDbl(tb_montoC3.Text), CInt(tb_chequesDev3.Text), dtp_inicio3.Value, tb_comen3.Text)
                        'End If

                    End If

                    datos2 = True

                    If tb_user.Text <> "" And tb_password.Text <> "" And (Me.Usuario <> tb_user.Text Or password <> tb_password.Text) Then

                        clientes2 = True

                    End If

                Else

                    MsgBox("El usuario ya se encuentra registrado", MsgBoxStyle.Critical)
                    deny = True
                    tb_codigo.Focus()
                    tb_codigo.SelectAll()

                End If

            End If

        End If

        If deny = False Then

            Dim cant As Integer = 0

            Dim index As Integer = 0

            If DataGridViewRazon.SelectedRows.Count > 0 Then
                index = DataGridViewRazon.SelectedRows(0).Index
            End If

            Label2.Text = cant
            Me.Usuario = ""
            user1 = ""
            Me.DataGridViewRazon.Enabled = True
            Me.tb_buscarcodigo.Enabled = True
            Me.ToolBar1.Enabled = True
            Me.DomainUpDown1.Enabled = True

            If varBoton = 1 Then
                Me.DataGridViewRazon.ClearSelection()
            End If

            Me.tb_clasificacion.Clear()
            Me.tb_direccion.Clear()
            Me.tb_email.Clear()
            Me.chk_cambiarCod.Visible = False
            Me.chk_cambiarCod.Checked = False
            Me.tb_fax.Clear()
            Me.tb_fecha.ResetText()
            Me.bt_chequearRIF.Enabled = False
            Me.tb_gerente.Clear()
            Me.tb_razon.Clear()
            Me.tb_representante.Clear()
            Me.tb_rif.Clear()
            Me.tb_telefono1.Clear()
            LimpiarReferencias()
            Me.tb_user.ReadOnly = True
            Me.tb_password.ReadOnly = True
            Me.tb_telefono2.Clear()
            Me.chk_filtro.Enabled = True
            Me.chk_filtro.Checked = False
            'Me.tb_vendedor2.Enabled = True
            Me.tb_direccionE.ReadOnly = True
            Me.tb_direccionE.Clear()
            Me.ch_contribuyente.Checked = False
            Me.ch_contribuyente.Enabled = False
            Me.tb_celular.ReadOnly = True
            Me.tb_limite.Enabled = False
            Me.chk_fletePago.Enabled = False
            Me.tb_observacion.ReadOnly = True
            tb_celular.Clear()
            chk_auto.Enabled = False
            tb_observacion.Clear()
            Me.tb_vendedor.Items.Clear()
            Me.tb_vendedor.ResetText()
            Me.tb_zona.Items.Clear()
            Me.tb_zona.ResetText()
            Me.tb_estado.Enabled = False
            Me.tb_vendedor.Enabled = False
            Me.tb_zona.Enabled = False
            Me.tb_estado.Items.Clear()
            Me.tb_estado.ResetText()
            Me.tb_clasificacion.ReadOnly = True
            Me.tb_direccion.ReadOnly = True
            Me.tb_email.ReadOnly = True
            Me.tb_fax.ReadOnly = True
            Me.tb_fecha.Enabled = False
            Me.tb_gerente.ReadOnly = True
            Me.tb_razon.ReadOnly = True
            Me.tb_representante.ReadOnly = True
            Me.tb_rif.ReadOnly = True
            Me.tb_telefono1.ReadOnly = True
            Me.tb_telefono2.ReadOnly = True
            Me.Label30.Text = "0,00"
            Me.lb_vencido.Text = "0,00"
            Me.lb_porVencer.Text = "0,00"
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False

            chk_guardar.Checked = False
            chk_guardar2.Checked = False
            chk_guardar3.Checked = False

            chk_guardar.Enabled = False
            chk_guardar2.Enabled = False
            chk_guardar3.Enabled = False

            Me.DataGridViewRazon.ClearSelection()

            If varBoton = 2 Then

                DataGridViewRazon.Focus()
                DataGridViewRazon.Rows(index).Selected = True
                DataGridViewRazon.SelectedRows(0).Cells(0).Value = tb_codigo.Text
                DataGridViewRazon_SelectionChanged(DataGridViewRazon, New EventArgs)
                tb_buscarcodigo.Focus()

            Else

                tb_buscarcodigo.Clear()
                Datos.consulta_clientes(DataGridViewRazon, cant)
                Me.tb_codigo.Clear()

            End If

            varBoton = 0

        End If
    End Sub

    Public Sub limpia()
        Me.DataGridViewRazon.Rows.Clear()
        LimpiarReferencias()
        Me.tb_clasificacion.Clear()
        Me.tb_direccion.Clear()
        Me.tb_email.Clear()
        Me.tb_fax.Clear()
        tb_celular.Clear()
        tb_observacion.Clear()
        Me.tb_fecha.ResetText()
        Me.tb_gerente.Clear()
        Me.tb_razon.Clear()
        Me.tb_representante.Clear()
        Me.tb_rif.Clear()
        Me.Label30.Text = "0,00"
        Me.lb_vencido.Text = "0,00"
        Me.lb_porVencer.Text = "0,00"
        Me.tb_telefono1.Clear()
        Me.tb_telefono2.Clear()
        If varBoton = 3 Then
            Me.tb_codigo.Clear()
        End If
        If Not varBoton = 2 Then

            Me.tb_vendedor.Items.Clear()
            Me.tb_vendedor.ResetText()
            Me.tb_zona.Items.Clear()
            Me.tb_zona.ResetText()
            Me.tb_estado.Items.Clear()
            Me.tb_estado.ResetText()

        End If
    End Sub


    Public Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (DataGridViewRazon.SelectedRows.Count = 0) Then
            Dim cod As Integer = 0
            cod = CInt(Me.DataGridViewRazon.SelectedRows(0).Cells(0).Value)

            Datos.consulta_cliente2(cod, tb_codigo.Text, tb_razon.Text, tb_rif.Text, tb_fecha.Text, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, Me.tb_vendedor, Me.tb_zona, Me.tb_estado, tb_clasificacion.Text, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, chk_auto.Checked, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
            Datos.consulta_cliente3(cod, Me.DGV_Fact, Me.lb_vencido, Me.lb_porVencer, Me.lb_totalDeuda, Me.lb_favor)

        End If
    End Sub
    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If Me.DataGridViewRazon.Enabled = True Then
            Dim s1 As String
            s1 = Me.tb_buscarcodigo.Text + "%"

            Dim choice2 As Integer = 0

            If chk_filtro.Checked Then
                choice2 = choice + 2
            End If

            If chk_filtro.Checked And Not tb_vendedor2.SelectedItem Is Nothing Then

                If choice2 = 0 Then
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 0, 0)
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                ElseIf choice2 = 1 Then
                    s1 = "%" + s1
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 1, 0)
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                ElseIf choice2 = 2 Then
                    s1 = "%" + s1
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 2, CInt(tb_vendedor2.SelectedItem.col2.ToString))
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                ElseIf choice2 = 3 Then
                    s1 = "%" + s1
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 3, CInt(tb_vendedor2.SelectedItem.col2.ToString))
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                End If

            Else

                If choice = 0 Then
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 0, 0)
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                ElseIf choice = 1 Then
                    s1 = "%" + s1
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 1, 0)
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                ElseIf choice2 = 2 Then
                    s1 = "%" + s1
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 2, CInt(tb_vendedor2.SelectedItem.col2.ToString))
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                ElseIf choice2 = 3 Then
                    s1 = "%" + s1
                    Datos.lv_Cliente(Me.DataGridViewRazon, s1, 3, CInt(tb_vendedor2.SelectedItem.col2.ToString))
                    Label2.Text = Me.DataGridViewRazon.Rows.Count
                    DataGridViewRazon.ClearSelection()
                End If

            End If



            cli = False

            Me.tb_codigo.Clear()
            Me.tb_clasificacion.Clear()
            Me.tb_direccion.Clear()
            Me.Label30.Text = "0,00"
            Me.lb_vencido.Text = "0,00"
            Me.lb_porVencer.Text = "0,00"
            Me.lb_totalDeuda.Text = "0,00"
            chk_auto.Enabled = False
            Me.tb_email.Clear()
            Me.tb_vendedor.Items.Clear()
            Me.tb_vendedor.ResetText()
            Me.tb_direccionE.Clear()
            Me.tb_zona.Items.Clear()
            Me.tb_zona.ResetText()
            Me.tb_user.Clear()
            Me.chk_fletePago.Checked = False
            Me.chk_auto.Checked = False
            Me.tb_password.Clear()
            Me.tb_estado.Items.Clear()
            Me.tb_estado.ResetText()
            Me.tb_fax.Clear()
            Me.tb_fecha.ResetText()
            Me.tb_gerente.Clear()
            Me.tb_razon.Clear()
            Me.tb_representante.Clear()
            Me.tb_rif.Clear()
            Me.tb_telefono1.Clear()
            Me.tb_telefono2.Clear()
            tb_celular.Clear()
            tb_observacion.Clear()
            Me.ch_contribuyente.Checked = False
            Me.DataGridViewRazon.ClearSelection()
            Me.DGV_Fact.Rows.Clear()
            Me.DataGridView1.Rows.Clear()
            LimpiarReferencias()

        End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub
    Public Sub abreM(ByVal cod As Integer, ByVal ind As Integer)
        swC = True
        indice = ind
        Dim sw2 As Boolean = False
        Dim cont As Integer = 0
        While (cont <= Me.DataGridViewRazon.SelectedRows.Count) And (sw2 = False)
            'While (cont <= Me.ListView1.Items.Count) And (sw2 = False)
            If CInt(Me.DataGridViewRazon.SelectedRows(0).Cells(0).Value) = cod Then

                sw2 = True
            Else
                cont = cont + 1
            End If
        End While
        Me.DataGridViewRazon.Rows(cont).Selected = True
        'Me.ListView1.Items(cont).Selected = True
        Datos.consulta_cliente2(cod, tb_codigo.Text, tb_razon.Text, tb_rif.Text, tb_fecha.Text, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, Me.tb_vendedor, Me.tb_zona, Me.tb_estado, tb_clasificacion.Text, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, chk_auto.Checked, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
        Datos.consulta_cliente3(cod, Me.DGV_Fact, Me.lb_vencido, Me.lb_porVencer, Me.lb_totalDeuda, Me.lb_favor)
        Me.ToolBar1_ButtonClick(New ToolBar, New ToolBarButtonClickEventArgs(Me.bt_modificar))
    End Sub

    '  ------------------------- VALIDACIONES

    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_telefono2.KeyPress, tb_telefono1.KeyPress, tb_fax.KeyPress, tb_celular.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "." Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números"
        End If
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y + 1)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_rif.LostFocus
        muestra_label(sender, 1)
    End Sub

    Private Sub tb_clasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_clasificacion.KeyPress
        If e.KeyChar = "a" Or e.KeyChar = "b" Or e.KeyChar = "c" Or Char.IsControl(e.KeyChar) Or e.KeyChar = "A" Or e.KeyChar = "B" Or e.KeyChar = "C" Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
        End If
        Me.Label22.Text = "      Ingrese sólo A,B ó C"
    End Sub
    Public Sub nuevo()
        swX = True
    End Sub

    Private Sub tb_zona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_zona.SelectedIndexChanged
        Me.tb_estado.Items.Clear()
        Me.tb_estado.Text = ""
        If Me.tb_zona.SelectedItem.col1 = "Capital" Then
            Datos.consulta_Estados(Me.tb_estado, 1)
        ElseIf Me.tb_zona.SelectedItem.col1 = "Centro y Occidente" Then
            Datos.consulta_Estados(Me.tb_estado, 2)
        ElseIf Me.tb_zona.SelectedItem.col1 = "Los Andes" Then
            Datos.consulta_Estados(Me.tb_estado, 3)
        ElseIf Me.tb_zona.SelectedItem.col1 = "Los Llanos" Then
            Datos.consulta_Estados(Me.tb_estado, 0)
        ElseIf Me.tb_zona.SelectedItem.col1 = "Oriente" Then
            Datos.consulta_Estados(Me.tb_estado, 4)
        ElseIf Me.tb_zona.SelectedItem.col1 = "Sur" Then
            Datos.consulta_Estados(Me.tb_estado, 5)
        ElseIf Me.tb_zona.SelectedItem.col1 = "Venezuela" Then
            Datos.consulta_Estados(Me.tb_estado, 6)
        End If
    End Sub
    Private Sub tb_vendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_vendedor.SelectedIndexChanged
        If varBoton = 1 Or (varBoton = 2 And chk_cambiarCod.Checked And chk_cambiarCod.Visible) Then
            Dim codigo As Integer
            Datos.consulta_clientes_vendedor(Me.tb_vendedor.SelectedItem.Col2(), codigo)
            Me.tb_codigo.Text = (codigo + 1)
        End If
    End Sub

    Private Sub DGV_Fact_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Fact.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim F13 As New Frm_Facturas_Ventas
            F13.cualVentana(2, Me.DGV_Fact.SelectedCells(6).Value, Me.DGV_Fact.SelectedCells(0).Value, CInt(Me.DataGridViewRazon.SelectedRows(0).Cells(0).Value), Me.DataGridViewRazon.SelectedRows(0).Cells(1).Value)
            F13.Show()
            F13.SpConsultaClienteFacturaBindingSource.Filter = "Control = '" & DGV_Fact.SelectedRows(0).Cells(0).Value.ToString & "'"
            F13.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
            F13.DGV_TodasLasFacturas.Select()
            F13.DGV_TodasLasFacturas_CellClick()

        End If
    End Sub

    Public Sub ponerceroslbdeuda()
        If lb_porVencer.Text = "0" Or lb_porVencer.Text = ",00" Or lb_porVencer.Text = "0,00" Then
            lb_porVencer.Text = "0,00"
        Else
            lb_porVencer.Text = Format(CDbl(lb_porVencer.Text), "#,##0.00")
        End If
    End Sub

    Public Sub ponerceroslabel30()
        If Label30.Text = "0" Or Label30.Text = ",00" Or Label30.Text = "0,00" Then
            Label30.Text = "0,00"
        Else
            Label30.Text = Format(CDbl(Label30.Text), "#,##0.00")
        End If
        If lb_vencido.Text = "0" Or lb_vencido.Text = ",00" Or lb_vencido.Text = "0,00" Then
            lb_vencido.Text = "0,00"
        Else
            lb_vencido.Text = Format(CDbl(lb_vencido.Text), "#,##0.00")
        End If
    End Sub

    Public Sub ponerceroslabel27()
        If lb_vencido.Text = "0" Or lb_vencido.Text = ",00" Or lb_vencido.Text = "0,00" Then
            lb_vencido.Text = "0,00"
        Else
            lb_vencido.Text = Format(CDbl(lb_vencido.Text), "#,##0.00")
        End If
    End Sub

    Public Sub DataGridViewRazon_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DataGridViewRazon.CellClick, DataGridViewRazon.KeyDown, DataGridViewRazon.KeyUp

        If Not (DataGridViewRazon.SelectedRows.Count = 0) Then


            Dim cod As Integer = 0
            cod = CInt(Me.DataGridViewRazon.SelectedRows(0).Cells(0).Value)

            If varBoton = 2 Then
                Datos.consulta_cliente2(cod, tb_codigo.Text, tb_razon.Text, tb_rif.Text, tb_fecha.Text, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, Me.tb_vendedor, Me.tb_zona, Me.tb_estado, tb_clasificacion.Text, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, chk_auto.Checked, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
                Datos.consulta_cliente3(tb_codigo.Text, Me.DGV_Fact, Me.lb_vencido, Me.lb_porVencer, Me.lb_totalDeuda, Me.lb_favor)
                DatosRecibo.consulta_recibos_cliente(DataGridView1, CInt(tb_codigo.Text))
            Else
                Datos.consulta_cliente2(cod, tb_codigo.Text, tb_razon.Text, tb_rif.Text, tb_fecha.Text, tb_telefono1.Text, tb_telefono2.Text, tb_fax.Text, tb_email.Text, tb_direccion.Text, tb_representante.Text, tb_gerente.Text, Me.tb_vendedor, Me.tb_zona, Me.tb_estado, tb_clasificacion.Text, Me.ch_contribuyente.Checked, tb_celular.Text, tb_observacion.Text, chk_auto.Checked, tb_user.Text, tb_password.Text, tb_limite.Text, chk_fletePago.Checked, tb_direccionE.Text)
                Datos.consulta_cliente3(cod, Me.DGV_Fact, Me.lb_vencido, Me.lb_porVencer, Me.lb_totalDeuda, Me.lb_favor)
                DatosRecibo.consulta_recibos_cliente(DataGridView1, CInt(DataGridViewRazon.SelectedRows(0).Cells(0).Value))
            End If

            Vencidos()
            Dim pagado As Double = 0
            If DataGridView1.RowCount > 0 Then
                Dim cont As Integer = 0
                For cont = 0 To DataGridView1.RowCount - 1
                    pagado = pagado + CDbl(DataGridView1.Rows(cont).Cells(5).Value)
                Next
                Label30.Text = Format(pagado, "#,##0.00")
            Else
                Label30.Text = "0,00"
            End If
            Dim total As Double = 0


            ' '' '' '' ''If CDbl(lbl_NotasC.Text) <> 0 Then
            ' '' '' '' ''    If CDbl(lb_deuda.Text) >= CDbl(lbl_NotasC.Text) Then
            ' '' '' '' ''        lb_deuda.Text = CDbl(lb_deuda.Text) - CDbl(lbl_NotasC.Text)
            ' '' '' '' ''    End If
            ' '' '' '' ''    If CDbl(Label27.Text) >= CDbl(lbl_NotasC.Text) Then
            ' '' '' '' ''        Label27.Text = CDbl(Label27.Text) - CDbl(lbl_NotasC.Text)
            ' '' '' '' ''    End If
            ' '' '' '' ''End If

            Datos.contador(pcdm, tb_zona, tb_zona.Text)
            Datos.contador(pcdm2, tb_estado, tb_estado.Text)

            If ch_contribuyente.Checked Then

                DataGridView1.Columns(9).Visible = True

            Else

                DataGridView1.Columns(9).Visible = False

            End If

            LimpiarReferencias()

            Datos.ConsultaReferenciasCliente(cb_empresa.Text, cb_empresa.Tag, tb_montoC.Text, tb_chequesDev.Text, dtp_inicio.Value, tb_comen.Text, chk_guardar.Checked, _
                                             cb_empresa2.Text, cb_empresa2.Tag, tb_montoC2.Text, tb_chequesDev2.Text, dtp_inicio2.Value, tb_comen2.Text, chk_guardar2.Checked, _
                                             cb_empresa3.Text, cb_empresa3.Tag, tb_montoC3.Text, tb_chequesDev3.Text, dtp_inicio3.Value, tb_comen3.Text, chk_guardar3.Checked, _
                                             CInt(DataGridViewRazon.SelectedRows(0).Cells(0).Value))

        End If


        DGV_Fact.ClearSelection()
        DataGridView1.ClearSelection()

    End Sub

    Public Sub Vencidos()

        Dim cont As Integer = 0
        Dim sum As Double = 0
        Dim afavor As Double = 0

        For cont = 0 To DGV_Fact.RowCount - 1
            If DGV_Fact.Rows(cont).Cells(3).Value.ToString = "" Then

                afavor = afavor - DGV_Fact.Rows(cont).Cells(5).Value
            Else
                If DGV_Fact.Rows(cont).Cells(3).Value > DGV_Fact.Rows(cont).Cells(7).Value Then

                    sum = sum + DGV_Fact.Rows(cont).Cells(5).Value

                End If
            End If

            Me.lb_favor.Text = Format(afavor, "#,##0.00")

            lb_vencido.Text = Format(sum, "#,##0.00")

        Next

    End Sub

    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If DataGridViewRazon.Rows.Count > 0 Then
            If DataGridViewRazon.Rows.Count > 0 Then
                If e.KeyData = Keys.Enter Then

                    Me.DataGridViewRazon.Rows(0).Cells(0).Selected = True
                    DataGridViewRazon.Focus()

                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim F As New Frm_Facturas_Ventas
            F.cualVentana(2, Me.DataGridView1.SelectedCells(7).Value, Me.DataGridView1.SelectedCells(0).Value, CInt(Me.DataGridViewRazon.SelectedRows(0).Cells(0).Value), Me.DataGridViewRazon.SelectedRows(0).Cells(1).Value)
            F.Show()
            F.SpConsultaClienteFacturaBindingSource.Filter = "Control = '" & DataGridView1.SelectedRows(0).Cells(0).Value.ToString & "'"
            F.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
            F.DGV_TodasLasFacturas.Select()
            F.DGV_TodasLasFacturas_CellClick()
        ElseIf e.ColumnIndex = 1 Then
            Dim R As New Frm_Recibos
            R.Show()
            R.CheckBox1.Visible = False
            R.choice = 1
            R.tb_buscarcodigo.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            R.DGV_R.Rows(0).Cells(1).Selected = True
            R.DGV_R_Selectedindex()
        End If

    End Sub

    Private Sub tb_limite_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_limite.KeyPress

        If (sender Is Me.tb_limite) Then

            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

                e.Handled = False
                muestra_label(sender, 1)

            Else

                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Ingrese sólo números"

            End If

        End If

    End Sub


    Private Sub tb_observacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_observacion.KeyPress

        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetterOrDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSeparator(e.KeyChar)) And Not e.KeyChar = Chr(13) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_chequearRIF.Click

        If Datos.ExisteRif(tb_rif.Text) = False Then
            MsgBox("El rif no está registrado!", MsgBoxStyle.Information, "SINPRO")
        Else
            MsgBox("El rif ya está registrado para otro cliente", MsgBoxStyle.Exclamation, "SINPRO")
            tb_rif.Focus()
            tb_rif.SelectAll()
        End If

    End Sub

    Private Sub tb_vendedor2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_vendedor2.SelectedIndexChanged

        If DomainUpDown1.SelectedIndex = 0 Then
            Datos.lv_Cliente(Me.DataGridViewRazon, "%" & tb_buscarcodigo.Text & "%", 2, CInt(tb_vendedor2.SelectedItem.col2.ToString))
        Else
            Datos.lv_Cliente(Me.DataGridViewRazon, "%" & tb_buscarcodigo.Text & "%", 3, CInt(tb_vendedor2.SelectedItem.col2.ToString))
        End If

        Label2.Text = DataGridViewRazon.RowCount.ToString
        DataGridViewRazon.ClearSelection()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filtro.CheckedChanged

        tb_vendedor2.Enabled = chk_filtro.Checked

        If chk_filtro.Checked = False Then
            tb_vendedor2.Text = ""
        Else
            tb_vendedor2.Focus()
            tb_vendedor2.DroppedDown = True
        End If

        If chk_filtro.Checked = False Or (chk_filtro.Checked = True And tb_vendedor2.SelectedIndex <> -1) Then
            tb_buscar_TextChanged(tb_buscarcodigo, New EventArgs)
        End If

    End Sub

    'Combo Empresas

    Private Sub cb_empresa_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_empresa.MouseClick
        Try
            If lb_empresa.Visible = False And cb_empresa.ReadOnly = False Then
                lb_empresa.Visible = True
                Me.Sp_consultaEmpresaBindingSource.RemoveFilter()
                lb_empresa.SelectedItem = cb_empresa.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_empresa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_empresa.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_empresa.Visible = False Then
                    Me.Sp_consultaEmpresaBindingSource.RemoveFilter()
                    lb_empresa.Visible = True
                    lb_empresa.SelectedValue = cb_empresa.Text
                Else
                    If lb_empresa.Items.Count > 1 Then
                        lb_empresa.Focus()
                        lb_empresa.SelectedIndex = lb_empresa.SelectedIndex + 1
                    Else
                        cb_empresa.SelectionStart = 0
                        cb_empresa.SelectionLength = cb_empresa.Text.Length
                        cb_empresa.Focus()
                    End If
                End If
            ElseIf e.KeyData = Keys.Up Then
                If lb_empresa.Visible = True Then
                    If lb_empresa.Items.Count > 1 Then
                        lb_empresa.Focus()
                        lb_empresa.SelectedIndex = lb_empresa.SelectedIndex - 1
                    End If
                End If
            ElseIf e.KeyData = Keys.Enter And lb_empresa.Visible Then
                lb_empresa.Visible = False
                If lb_empresa.Items.Count > 0 Then
                    cb_empresa.Text = lb_empresa.Text
                    cb_empresa.Tag = lb_empresa.SelectedItem(0).ToString
                    lb_empresa3.Visible = False
                Else
                    cb_empresa.Text = ""
                End If
                cb_empresa.SelectionStart = cb_empresa.Text.Length
            ElseIf e.KeyData = Keys.Back Then
                If cb_empresa.Text.Length <= 1 Or cb_empresa.SelectedText <> "" Then
                    Me.Sp_consultaEmpresaBindingSource.RemoveFilter()
                Else
                    Me.Sp_consultaEmpresaBindingSource.Filter = "razonsocial like '%" & cb_empresa.Text & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cb_empresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_empresa.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "."c Then
                If Me.cb_empresa.SelectedText <> "" Then
                    Me.Sp_consultaEmpresaBindingSource.Filter = "razonsocial like '%" & e.KeyChar & "%'"
                Else
                    Me.Sp_consultaEmpresaBindingSource.Filter = "razonsocial like '%" & cb_empresa.Text & e.KeyChar & "%'"
                End If

                If lb_empresa.Items.Count = 0 Then
                    e.Handled = True
                    Me.Sp_consultaEmpresaBindingSource.Filter = "razonsocial like '%" & cb_empresa.Text & "%'"
                Else
                    e.Handled = False

                    If cb_empresa.ReadOnly = False Then
                        lb_empresa.Visible = True
                    Else
                        lb_empresa.Visible = False
                    End If

                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False

                If cb_empresa.ReadOnly = False Then
                    lb_empresa.Visible = True
                Else
                    lb_empresa.Visible = False
                End If

            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_empresa_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_empresa.GotFocus
        Try
            If cb_empresa.Text = "Seleccione" And cb_empresa.ReadOnly = False Then
                cb_empresa.Text = ""
                Me.Sp_consultaEmpresaBindingSource.Filter = "razonsocial like '%" & cb_empresa.Text & "%'"
                lb_empresa.Visible = True
                lb_empresa.BringToFront()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_empresa.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_empresa.SelectedIndex = 1 Then
                    cb_empresa.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_empresa.Visible = False
                cb_empresa.Text = lb_empresa.Text
                cb_empresa.Tag = lb_empresa.SelectedItem(0).ToString
                lb_empresa.Visible = False
                cb_empresa.Focus()
                cb_empresa.SelectionStart = cb_empresa.Text.Length
            End If
        Catch ex As Exception

        Finally

        End Try

    End Sub
    Private Sub lb_client_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_empresa.MouseClick
        Try

            lb_empresa.Visible = False
            cb_empresa.Text = lb_empresa.Text
            cb_empresa.Tag = lb_empresa.SelectedItem(0).ToString
            lb_empresa.Visible = False
            cb_empresa.Focus()
            cb_empresa.SelectionStart = cb_empresa.Text.Length

        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

    'Combo Empresas2

    Private Sub cb_empresa2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_empresa2.MouseClick
        Try
            If lb_empresa2.Visible = False And cb_empresa2.ReadOnly = False Then
                lb_empresa2.Visible = True
                Me.sp_consultaEmpresaBindingSource2.RemoveFilter()
                lb_empresa2.SelectedItem = cb_empresa2.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_empresa2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_empresa2.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_empresa2.Visible = False Then
                    Me.sp_consultaEmpresaBindingSource2.RemoveFilter()
                    lb_empresa2.Visible = True
                    lb_empresa2.SelectedValue = cb_empresa2.Text
                Else
                    If lb_empresa2.Items.Count > 1 Then
                        lb_empresa2.Focus()
                        lb_empresa2.SelectedIndex = lb_empresa2.SelectedIndex + 1
                    Else
                        cb_empresa2.SelectionStart = 0
                        cb_empresa2.SelectionLength = cb_empresa2.Text.Length
                        cb_empresa2.Focus()
                    End If
                End If
            ElseIf e.KeyData = Keys.Up Then
                If lb_empresa2.Visible = True Then
                    If lb_empresa2.Items.Count > 1 Then
                        lb_empresa2.Focus()
                        lb_empresa2.SelectedIndex = lb_empresa2.SelectedIndex - 1
                    End If
                End If
            ElseIf e.KeyData = Keys.Enter And lb_empresa2.Visible Then
                lb_empresa2.Visible = False
                If lb_empresa2.Items.Count > 0 Then
                    cb_empresa2.Text = lb_empresa2.Text
                    cb_empresa2.Tag = lb_empresa2.SelectedItem(0).ToString
                    lb_empresa2.Visible = False
                Else
                    cb_empresa2.Text = ""
                End If
                cb_empresa2.SelectionStart = cb_empresa2.Text.Length
            ElseIf e.KeyData = Keys.Back Then
                If cb_empresa2.Text.Length <= 1 Or cb_empresa2.SelectedText <> "" Then
                    Me.sp_consultaEmpresaBindingSource2.RemoveFilter()
                Else
                    Me.sp_consultaEmpresaBindingSource2.Filter = "razonsocial like '%" & cb_empresa2.Text & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cb_empresa2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_empresa2.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "."c Then
                If Me.cb_empresa2.SelectedText <> "" Then
                    Me.sp_consultaEmpresaBindingSource2.Filter = "razonsocial like '%" & e.KeyChar & "%'"
                Else
                    Me.sp_consultaEmpresaBindingSource2.Filter = "razonsocial like '%" & cb_empresa2.Text & e.KeyChar & "%'"
                End If

                If lb_empresa2.Items.Count = 0 Then
                    e.Handled = True
                    Me.sp_consultaEmpresaBindingSource2.Filter = "razonsocial like '%" & cb_empresa2.Text & "%'"
                Else
                    e.Handled = False

                    If cb_empresa2.ReadOnly = False Then
                        lb_empresa2.Visible = True
                    Else
                        lb_empresa2.Visible = False
                    End If

                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False

                If cb_empresa2.ReadOnly = False Then
                    lb_empresa2.Visible = True
                Else
                    lb_empresa2.Visible = False
                End If

            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_empresa2_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_empresa2.GotFocus
        Try
            If cb_empresa2.Text = "Seleccione" And cb_empresa2.ReadOnly = False Then
                cb_empresa2.Text = ""
                Me.sp_consultaEmpresaBindingSource2.Filter = "razonsocial like '%" & cb_empresa2.Text & "%'"
                lb_empresa2.Visible = True
                lb_empresa2.BringToFront()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_client2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_empresa2.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_empresa2.SelectedIndex = 1 Then
                    cb_empresa2.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_empresa2.Visible = False
                cb_empresa2.Text = lb_empresa2.Text
                cb_empresa2.Tag = lb_empresa2.SelectedItem(0).ToString
                lb_empresa2.Visible = False
                cb_empresa2.Focus()
                cb_empresa2.SelectionStart = cb_empresa2.Text.Length
            End If
        Catch ex As Exception

        Finally

        End Try

    End Sub
    Private Sub lb_client2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_empresa2.MouseClick
        Try
            lb_empresa2.Visible = False

            cb_empresa2.Text = lb_empresa2.Text
            cb_empresa2.Tag = lb_empresa2.SelectedItem(0).ToString
            lb_empresa2.Visible = False
            cb_empresa2.Focus()
            cb_empresa2.SelectionStart = cb_empresa2.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

    'Combo Empresas3

    Private Sub cb_empresa3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cb_empresa3.MouseClick
        Try
            If lb_empresa3.Visible = False And cb_empresa3.ReadOnly = False Then
                lb_empresa3.Visible = True
                Me.sp_consultaEmpresaBindingSource3.RemoveFilter()
                lb_empresa3.SelectedItem = cb_empresa3.Text
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cb_empresa3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_empresa3.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If lb_empresa3.Visible = False Then
                    Me.sp_consultaEmpresaBindingSource3.RemoveFilter()
                    lb_empresa3.Visible = True
                    lb_empresa3.SelectedValue = cb_empresa3.Text
                Else
                    If lb_empresa3.Items.Count > 1 Then
                        lb_empresa3.Focus()
                        lb_empresa3.SelectedIndex = lb_empresa3.SelectedIndex + 1
                    Else
                        cb_empresa3.SelectionStart = 0
                        cb_empresa3.SelectionLength = cb_empresa3.Text.Length
                        cb_empresa3.Focus()
                    End If
                End If
            ElseIf e.KeyData = Keys.Up Then
                If lb_empresa3.Visible = True Then
                    If lb_empresa3.Items.Count > 1 Then
                        lb_empresa3.Focus()
                        lb_empresa3.SelectedIndex = lb_empresa3.SelectedIndex - 1
                    End If
                End If
            ElseIf e.KeyData = Keys.Enter And lb_empresa3.Visible Then
                lb_empresa3.Visible = False
                If lb_empresa3.Items.Count > 0 Then
                    cb_empresa3.Text = lb_empresa3.Text
                    cb_empresa3.Tag = lb_empresa3.SelectedItem(0).ToString
                    lb_empresa3.Visible = False
                Else
                    cb_empresa3.Text = ""
                End If
                cb_empresa3.SelectionStart = cb_empresa3.Text.Length
            ElseIf e.KeyData = Keys.Back Then
                If cb_empresa3.Text.Length <= 1 Or cb_empresa3.SelectedText <> "" Then
                    Me.sp_consultaEmpresaBindingSource3.RemoveFilter()
                Else
                    Me.sp_consultaEmpresaBindingSource3.Filter = "razonsocial like '%" & cb_empresa3.Text & "%'"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cb_empresa3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_empresa3.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "."c Then
                If Me.cb_empresa3.SelectedText <> "" Then
                    Me.sp_consultaEmpresaBindingSource3.Filter = "razonsocial like '%" & e.KeyChar & "%'"
                Else
                    Me.sp_consultaEmpresaBindingSource3.Filter = "razonsocial like '%" & cb_empresa3.Text & e.KeyChar & "%'"
                End If

                If lb_empresa3.Items.Count = 0 Then
                    e.Handled = True
                    Me.sp_consultaEmpresaBindingSource3.Filter = "razonsocial like '%" & cb_empresa3.Text & "%'"
                Else
                    e.Handled = False

                    If cb_empresa3.ReadOnly = False Then
                        lb_empresa3.Visible = True
                    Else
                        lb_empresa3.Visible = False
                    End If

                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False

                If cb_empresa3.ReadOnly = False Then
                    lb_empresa3.Visible = True
                Else
                    lb_empresa3.Visible = False
                End If

            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_empresa3_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_empresa3.GotFocus
        Try
            If cb_empresa3.Text = "Seleccione" And cb_empresa3.ReadOnly = False Then
                cb_empresa3.Text = ""
                Me.sp_consultaEmpresaBindingSource3.Filter = "razonsocial like '%" & cb_empresa3.Text & "%'"
                lb_empresa3.Visible = True
                lb_empresa3.BringToFront()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub lb_client3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_empresa3.KeyDown
        Try
            If e.KeyData = Keys.Up Then
                If lb_empresa3.SelectedIndex = 1 Then
                    cb_empresa3.Focus()
                End If
            ElseIf e.KeyData = Keys.Enter Then
                lb_empresa3.Visible = False
                cb_empresa3.Text = lb_empresa3.Text
                cb_empresa3.Tag = lb_empresa3.SelectedItem(0).ToString
                lb_empresa3.Visible = False
                cb_empresa3.Focus()
                cb_empresa3.SelectionStart = cb_empresa3.Text.Length
            End If
        Catch ex As Exception

        Finally

        End Try

    End Sub
    Private Sub lb_client3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_empresa3.MouseClick
        Try
            lb_empresa3.Visible = False

            cb_empresa3.Text = lb_empresa3.Text
            cb_empresa3.Tag = lb_empresa3.SelectedItem(0).ToString
            lb_empresa3.Visible = False
            cb_empresa3.Focus()
            cb_empresa3.SelectionStart = cb_empresa3.Text.Length
        Catch ex As Exception

        End Try

    End Sub

    '--------------fin combo

    Private Sub chk_guardar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_guardar.CheckedChanged

        If chk_guardar.Enabled Then

            cb_empresa.ReadOnly = Not chk_guardar.Checked
            lb_empresa.Visible = False
            tb_montoC.ReadOnly = Not chk_guardar.Checked
            tb_comen.ReadOnly = Not chk_guardar.Checked
            dtp_inicio.Enabled = chk_guardar.Checked
            tb_chequesDev.ReadOnly = Not chk_guardar.Checked

            If chk_guardar.Checked = False Then

                cb_empresa.Clear()
                lb_empresa.Visible = False
                tb_montoC.Clear()
                tb_comen.Clear()
                dtp_inicio.Value = Today
                tb_chequesDev.Clear()

            End If

        End If

    End Sub

    Private Sub chk_guardar2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_guardar2.CheckedChanged

        If chk_guardar2.Enabled Then

            cb_empresa2.ReadOnly = Not chk_guardar2.Checked
            lb_empresa2.Visible = False
            tb_montoC2.ReadOnly = Not chk_guardar2.Checked
            tb_comen2.ReadOnly = Not chk_guardar2.Checked
            dtp_inicio2.Enabled = chk_guardar2.Checked
            tb_chequesDev2.ReadOnly = Not chk_guardar2.Checked

            If Not chk_guardar2.Checked Then

                cb_empresa2.Clear()
                lb_empresa2.Visible = False
                tb_montoC2.Clear()
                tb_comen2.Clear()
                dtp_inicio2.Value = Today
                tb_chequesDev2.Clear()

            End If

        End If

    End Sub

    Private Sub chk_guardar3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_guardar3.CheckedChanged

        If chk_guardar3.Enabled Then

            cb_empresa3.ReadOnly = Not chk_guardar3.Checked
            lb_empresa3.Visible = False
            tb_montoC3.ReadOnly = Not chk_guardar3.Checked
            tb_comen3.ReadOnly = Not chk_guardar3.Checked
            dtp_inicio3.Enabled = chk_guardar3.Checked
            tb_chequesDev3.ReadOnly = Not chk_guardar3.Checked

            If Not chk_guardar3.Checked Then

                cb_empresa3.Clear()
                lb_empresa3.Visible = False
                tb_montoC3.Clear()
                tb_comen3.Clear()
                dtp_inicio3.Value = Today
                tb_chequesDev3.Clear()

            End If

        End If

    End Sub

    Public Sub LimpiarReferencias()

        cb_empresa.Text = "Seleccione"
        lb_empresa.Visible = False
        tb_montoC.Clear()
        tb_comen.Clear()
        dtp_inicio.Value = Today
        tb_chequesDev.Clear()
        chk_guardar.Checked = False
        chk_guardar_CheckedChanged(chk_guardar, New EventArgs)

        cb_empresa2.Text = "Seleccione"
        lb_empresa2.Visible = False
        tb_montoC2.Clear()
        tb_comen2.Clear()
        dtp_inicio2.Value = Today
        tb_chequesDev2.Clear()
        chk_guardar2.Checked = False
        chk_guardar2_CheckedChanged(chk_guardar2, New EventArgs)

        cb_empresa3.Text = "Seleccione"
        lb_empresa3.Visible = False
        tb_montoC3.Clear()
        tb_comen3.Clear()
        dtp_inicio3.Value = Today
        tb_chequesDev3.Clear()
        chk_guardar3.Checked = False
        chk_guardar3_CheckedChanged(chk_guardar3, New EventArgs)

    End Sub

    Private Sub tb_direccionE_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_direccionE.TextChanged

        If varBoton = 2 Then
            dirEnvio = tb_direccionE.Text
        End If

    End Sub

End Class
