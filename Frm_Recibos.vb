Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Frm_Recibos
    Inherits System.Windows.Forms.Form
    Dim user As String = ""
    Dim user_name As String = ""
    Dim antCH As Boolean = False
    Dim indexRec As Integer = 0
    Dim numDeposito As String = ""
    Dim FechaMov As Date
    Dim MontoCHD As Double
    Public varBoton As Integer = 0
    Public frm1 As Frm_Consulta_Movimientos
    Dim sw_ch As Boolean = False
    Public choice As Integer
    Private swC As Boolean = False
    Private indice As Integer = 0
    Private swX As Boolean = False
    Dim numFactura As Integer = 0
    Dim numRecibo As Integer = 0
    Dim otra As Boolean = False
    Dim dgv_mov As DataGridView
    Dim dgv_f As DataGridView
    Dim dgv_c As DataGridView
    Dim dgv_chpd As DataGridView
    Dim tip As Boolean = False
    Dim borrada As Integer = -1
    Dim facR As Integer = 0
    Dim line As Integer
    Dim cb As String
    Dim td As Date
    Dim th As Date
    Dim rf As Boolean
    Dim rb As Boolean
    Dim devolviendo As Boolean = False
    Dim movchpd As Boolean = False
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DGV_Recibos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents l_saldo As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents l_monto As System.Windows.Forms.Label
    Friend WithEvents lb_deuda As System.Windows.Forms.Label
    Friend WithEvents tb_fechaD As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_observacion As System.Windows.Forms.TextBox
    Friend WithEvents l_razon As System.Windows.Forms.Label
    Friend WithEvents l_codCliente As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bt_procesar As System.Windows.Forms.Button
    Friend WithEvents ch_dev As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents l_con As System.Windows.Forms.Label
    Friend WithEvents ch_contEspecial As System.Windows.Forms.CheckBox
    Friend WithEvents l_retencion As System.Windows.Forms.Label
    Friend WithEvents tb_retencion As System.Windows.Forms.TextBox
    Friend WithEvents l_p As System.Windows.Forms.Label
    Friend WithEvents DGV_R As System.Windows.Forms.DataGridView
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.ComboBox
    Friend WithEvents tb_fechaCD As System.Windows.Forms.DateTimePicker
    Private cli As Boolean = False
    Dim w As Boolean = False
    Dim e As Boolean = False
    Friend WithEvents DGV_Fact As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ch_pd As System.Windows.Forms.CheckBox
    Friend WithEvents tb_dep_chd As System.Windows.Forms.TextBox
    Friend WithEvents lb_depdev As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents SpconsultaRecibos2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaRecibos2TableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaRecibos2TableAdapter
    Friend WithEvents CodigoReciboDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NControlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonsocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContEspecialDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NDepositoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhraseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DGV_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContEspecial2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Devolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Retencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tb_compRet As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_confirmados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pendientes As System.Windows.Forms.RadioButton
    Friend WithEvents bt_confirmar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents l_recibosPC As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chk_comp As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents tb_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label


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
    Friend WithEvents l_recibos As System.Windows.Forms.Label
    Friend WithEvents groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents l_recibo As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tb_control As System.Windows.Forms.TextBox
    Friend WithEvents tb_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents tb_deposito As System.Windows.Forms.TextBox
    Friend WithEvents tb_cheque As System.Windows.Forms.TextBox
    Friend WithEvents tb_monto As System.Windows.Forms.TextBox
    Friend WithEvents tb_buscarcodigo As System.Windows.Forms.TextBox
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents tb_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_banco As MTGCComboBox
    Friend WithEvents tb_bancodep As MTGCComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents notas As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Recibos))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.bt_nuevo = New System.Windows.Forms.ToolBarButton
        Me.bt_modificar = New System.Windows.Forms.ToolBarButton
        Me.bt_eliminar = New System.Windows.Forms.ToolBarButton
        Me.bt_confirmar = New System.Windows.Forms.ToolBarButton
        Me.bt_salir = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.l_recibos = New System.Windows.Forms.Label
        Me.groupbox1 = New System.Windows.Forms.GroupBox
        Me.tb_usuario = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.chk_comp = New System.Windows.Forms.CheckBox
        Me.tb_compRet = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lb_depdev = New System.Windows.Forms.Label
        Me.tb_dep_chd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ch_pd = New System.Windows.Forms.CheckBox
        Me.tb_fechaCD = New System.Windows.Forms.DateTimePicker
        Me.tb_retencion = New System.Windows.Forms.TextBox
        Me.l_p = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lb_deuda = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.l_saldo = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label29 = New System.Windows.Forms.Label
        Me.l_monto = New System.Windows.Forms.Label
        Me.ch_contEspecial = New System.Windows.Forms.CheckBox
        Me.l_con = New System.Windows.Forms.Label
        Me.ch_dev = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.l_razon = New System.Windows.Forms.Label
        Me.l_codCliente = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_fechaD = New System.Windows.Forms.DateTimePicker
        Me.tb_observacion = New System.Windows.Forms.TextBox
        Me.tb_bancodep = New MTGCComboBox
        Me.notas = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.tb_banco = New MTGCComboBox
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tb_fecha = New System.Windows.Forms.DateTimePicker
        Me.tb_monto = New System.Windows.Forms.TextBox
        Me.tb_cheque = New System.Windows.Forms.TextBox
        Me.tb_deposito = New System.Windows.Forms.TextBox
        Me.tb_efectivo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.tb_control = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.l_retencion = New System.Windows.Forms.Label
        Me.l_recibo = New System.Windows.Forms.Label
        Me.bt_procesar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_buscarcodigo = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.DGV_Recibos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Recibo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDep = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Devolucion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Retencion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_R = New System.Windows.Forms.DataGridView
        Me.CodigoReciboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NControlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RazonsocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContEspecialDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NDepositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhraseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SpconsultaRecibos2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.DomainUpDown1 = New System.Windows.Forms.ComboBox
        Me.DGV_Fact = New System.Windows.Forms.DataGridView
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Venc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DGV_Clientes = New System.Windows.Forms.DataGridView
        Me.CodigoRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.N = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContEspecial2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rb_confirmados = New System.Windows.Forms.RadioButton
        Me.rb_pendientes = New System.Windows.Forms.RadioButton
        Me.Sp_consultaRecibos2TableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaRecibos2TableAdapter
        Me.l_recibosPC = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.groupbox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpconsultaRecibos2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Fact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.bt_nuevo, Me.bt_modificar, Me.bt_eliminar, Me.bt_confirmar, Me.bt_salir})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(70, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(-2, -1)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(374, 65)
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
        'bt_confirmar
        '
        Me.bt_confirmar.Enabled = False
        Me.bt_confirmar.ImageIndex = 5
        Me.bt_confirmar.Name = "bt_confirmar"
        Me.bt_confirmar.Text = "Confirmar"
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
        Me.ImageList2.Images.SetKeyName(5, "ok_000.gif")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total por confirmar:"
        '
        'l_recibos
        '
        Me.l_recibos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_recibos.Location = New System.Drawing.Point(121, 386)
        Me.l_recibos.Name = "l_recibos"
        Me.l_recibos.Size = New System.Drawing.Size(34, 23)
        Me.l_recibos.TabIndex = 4
        Me.l_recibos.Text = "#"
        Me.l_recibos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.White
        Me.groupbox1.Controls.Add(Me.tb_usuario)
        Me.groupbox1.Controls.Add(Me.Label20)
        Me.groupbox1.Controls.Add(Me.Label13)
        Me.groupbox1.Controls.Add(Me.chk_comp)
        Me.groupbox1.Controls.Add(Me.tb_compRet)
        Me.groupbox1.Controls.Add(Me.Label4)
        Me.groupbox1.Controls.Add(Me.lb_depdev)
        Me.groupbox1.Controls.Add(Me.tb_dep_chd)
        Me.groupbox1.Controls.Add(Me.Label2)
        Me.groupbox1.Controls.Add(Me.ch_pd)
        Me.groupbox1.Controls.Add(Me.tb_fechaCD)
        Me.groupbox1.Controls.Add(Me.tb_retencion)
        Me.groupbox1.Controls.Add(Me.l_p)
        Me.groupbox1.Controls.Add(Me.Label22)
        Me.groupbox1.Controls.Add(Me.Panel3)
        Me.groupbox1.Controls.Add(Me.Panel2)
        Me.groupbox1.Controls.Add(Me.ch_contEspecial)
        Me.groupbox1.Controls.Add(Me.l_con)
        Me.groupbox1.Controls.Add(Me.ch_dev)
        Me.groupbox1.Controls.Add(Me.Label12)
        Me.groupbox1.Controls.Add(Me.l_razon)
        Me.groupbox1.Controls.Add(Me.l_codCliente)
        Me.groupbox1.Controls.Add(Me.Label9)
        Me.groupbox1.Controls.Add(Me.Label6)
        Me.groupbox1.Controls.Add(Me.tb_fechaD)
        Me.groupbox1.Controls.Add(Me.tb_observacion)
        Me.groupbox1.Controls.Add(Me.tb_bancodep)
        Me.groupbox1.Controls.Add(Me.notas)
        Me.groupbox1.Controls.Add(Me.Label23)
        Me.groupbox1.Controls.Add(Me.tb_banco)
        Me.groupbox1.Controls.Add(Me.bt_cancelar)
        Me.groupbox1.Controls.Add(Me.bt_aceptar)
        Me.groupbox1.Controls.Add(Me.tb_fecha)
        Me.groupbox1.Controls.Add(Me.tb_monto)
        Me.groupbox1.Controls.Add(Me.tb_cheque)
        Me.groupbox1.Controls.Add(Me.tb_deposito)
        Me.groupbox1.Controls.Add(Me.tb_efectivo)
        Me.groupbox1.Controls.Add(Me.Label8)
        Me.groupbox1.Controls.Add(Me.Label17)
        Me.groupbox1.Controls.Add(Me.tb_control)
        Me.groupbox1.Controls.Add(Me.Label18)
        Me.groupbox1.Controls.Add(Me.Label21)
        Me.groupbox1.Controls.Add(Me.Label15)
        Me.groupbox1.Controls.Add(Me.Label14)
        Me.groupbox1.Controls.Add(Me.Label11)
        Me.groupbox1.Controls.Add(Me.Label10)
        Me.groupbox1.Controls.Add(Me.Label5)
        Me.groupbox1.Controls.Add(Me.Label24)
        Me.groupbox1.Controls.Add(Me.l_retencion)
        Me.groupbox1.Controls.Add(Me.l_recibo)
        Me.groupbox1.Controls.Add(Me.bt_procesar)
        Me.groupbox1.Location = New System.Drawing.Point(409, 23)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(607, 365)
        Me.groupbox1.TabIndex = 6
        Me.groupbox1.TabStop = False
        '
        'tb_usuario
        '
        Me.tb_usuario.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usuario.Location = New System.Drawing.Point(100, 304)
        Me.tb_usuario.MaxLength = 50
        Me.tb_usuario.Name = "tb_usuario"
        Me.tb_usuario.Size = New System.Drawing.Size(131, 22)
        Me.tb_usuario.TabIndex = 112
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 312)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 23)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "Usuario:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 335)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 23)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Comprobante Recibido:"
        '
        'chk_comp
        '
        Me.chk_comp.AutoSize = True
        Me.chk_comp.Enabled = False
        Me.chk_comp.Location = New System.Drawing.Point(162, 338)
        Me.chk_comp.Name = "chk_comp"
        Me.chk_comp.Size = New System.Drawing.Size(15, 14)
        Me.chk_comp.TabIndex = 110
        Me.chk_comp.UseVisualStyleBackColor = True
        '
        'tb_compRet
        '
        Me.tb_compRet.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_compRet.Location = New System.Drawing.Point(461, 124)
        Me.tb_compRet.MaxLength = 18
        Me.tb_compRet.Name = "tb_compRet"
        Me.tb_compRet.ReadOnly = True
        Me.tb_compRet.Size = New System.Drawing.Size(113, 22)
        Me.tb_compRet.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Comp. Retención:"
        '
        'lb_depdev
        '
        Me.lb_depdev.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_depdev.Location = New System.Drawing.Point(341, 225)
        Me.lb_depdev.Name = "lb_depdev"
        Me.lb_depdev.Size = New System.Drawing.Size(117, 23)
        Me.lb_depdev.TabIndex = 107
        Me.lb_depdev.Text = "Nº Depósito:"
        Me.lb_depdev.Visible = False
        '
        'tb_dep_chd
        '
        Me.tb_dep_chd.Location = New System.Drawing.Point(463, 220)
        Me.tb_dep_chd.Name = "tb_dep_chd"
        Me.tb_dep_chd.ReadOnly = True
        Me.tb_dep_chd.Size = New System.Drawing.Size(128, 22)
        Me.tb_dep_chd.TabIndex = 106
        Me.tb_dep_chd.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Cheque PD:"
        '
        'ch_pd
        '
        Me.ch_pd.AutoSize = True
        Me.ch_pd.Enabled = False
        Me.ch_pd.Location = New System.Drawing.Point(100, 199)
        Me.ch_pd.Name = "ch_pd"
        Me.ch_pd.Size = New System.Drawing.Size(15, 14)
        Me.ch_pd.TabIndex = 104
        Me.ch_pd.UseVisualStyleBackColor = True
        '
        'tb_fechaCD
        '
        Me.tb_fechaCD.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fechaCD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_fechaCD.Location = New System.Drawing.Point(478, 196)
        Me.tb_fechaCD.Name = "tb_fechaCD"
        Me.tb_fechaCD.Size = New System.Drawing.Size(113, 22)
        Me.tb_fechaCD.TabIndex = 103
        Me.tb_fechaCD.Visible = False
        '
        'tb_retencion
        '
        Me.tb_retencion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_retencion.Location = New System.Drawing.Point(544, 99)
        Me.tb_retencion.MaxLength = 3
        Me.tb_retencion.Name = "tb_retencion"
        Me.tb_retencion.Size = New System.Drawing.Size(30, 22)
        Me.tb_retencion.TabIndex = 100
        Me.tb_retencion.Visible = False
        '
        'l_p
        '
        Me.l_p.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_p.Location = New System.Drawing.Point(574, 103)
        Me.l_p.Name = "l_p"
        Me.l_p.Size = New System.Drawing.Size(20, 20)
        Me.l_p.TabIndex = 102
        Me.l_p.Text = "%"
        Me.l_p.Visible = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(386, 337)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(208, 22)
        Me.Label22.TabIndex = 46
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lb_deuda)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.l_saldo)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(342, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(251, 45)
        Me.Panel3.TabIndex = 81
        '
        'lb_deuda
        '
        Me.lb_deuda.Location = New System.Drawing.Point(136, 1)
        Me.lb_deuda.Name = "lb_deuda"
        Me.lb_deuda.Size = New System.Drawing.Size(102, 23)
        Me.lb_deuda.TabIndex = 78
        Me.lb_deuda.Text = "0"
        Me.lb_deuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 23)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Saldo a Favor:"
        '
        'l_saldo
        '
        Me.l_saldo.Location = New System.Drawing.Point(132, 20)
        Me.l_saldo.Name = "l_saldo"
        Me.l_saldo.Size = New System.Drawing.Size(106, 24)
        Me.l_saldo.TabIndex = 77
        Me.l_saldo.Text = "0"
        Me.l_saldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 3)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 23)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "Pendiente:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.l_monto)
        Me.Panel2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(342, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 30)
        Me.Panel2.TabIndex = 80
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 4)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 23)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Monto Recibo:"
        '
        'l_monto
        '
        Me.l_monto.Location = New System.Drawing.Point(137, 0)
        Me.l_monto.Name = "l_monto"
        Me.l_monto.Size = New System.Drawing.Size(102, 23)
        Me.l_monto.TabIndex = 74
        Me.l_monto.Text = "0"
        Me.l_monto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ch_contEspecial
        '
        Me.ch_contEspecial.AutoSize = True
        Me.ch_contEspecial.Enabled = False
        Me.ch_contEspecial.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_contEspecial.Location = New System.Drawing.Point(460, 102)
        Me.ch_contEspecial.Name = "ch_contEspecial"
        Me.ch_contEspecial.Size = New System.Drawing.Size(15, 14)
        Me.ch_contEspecial.TabIndex = 99
        Me.ch_contEspecial.UseVisualStyleBackColor = True
        Me.ch_contEspecial.Visible = False
        '
        'l_con
        '
        Me.l_con.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_con.Location = New System.Drawing.Point(342, 102)
        Me.l_con.Name = "l_con"
        Me.l_con.Size = New System.Drawing.Size(107, 20)
        Me.l_con.TabIndex = 98
        Me.l_con.Text = "Cont. Especial:"
        Me.l_con.Visible = False
        '
        'ch_dev
        '
        Me.ch_dev.AutoSize = True
        Me.ch_dev.Enabled = False
        Me.ch_dev.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_dev.Location = New System.Drawing.Point(462, 201)
        Me.ch_dev.Name = "ch_dev"
        Me.ch_dev.Size = New System.Drawing.Size(15, 14)
        Me.ch_dev.TabIndex = 96
        Me.ch_dev.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(342, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 23)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Cheque Devuelto:"
        '
        'l_razon
        '
        Me.l_razon.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_razon.Location = New System.Drawing.Point(100, 55)
        Me.l_razon.Name = "l_razon"
        Me.l_razon.Size = New System.Drawing.Size(236, 23)
        Me.l_razon.TabIndex = 94
        Me.l_razon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'l_codCliente
        '
        Me.l_codCliente.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_codCliente.Location = New System.Drawing.Point(100, 31)
        Me.l_codCliente.Name = "l_codCliente"
        Me.l_codCliente.Size = New System.Drawing.Size(98, 23)
        Me.l_codCliente.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Razón Social:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Código Cliente:"
        '
        'tb_fechaD
        '
        Me.tb_fechaD.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fechaD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_fechaD.Location = New System.Drawing.Point(461, 171)
        Me.tb_fechaD.Name = "tb_fechaD"
        Me.tb_fechaD.Size = New System.Drawing.Size(130, 22)
        Me.tb_fechaD.TabIndex = 10
        '
        'tb_observacion
        '
        Me.tb_observacion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_observacion.Location = New System.Drawing.Point(344, 267)
        Me.tb_observacion.MaxLength = 250
        Me.tb_observacion.Multiline = True
        Me.tb_observacion.Name = "tb_observacion"
        Me.tb_observacion.Size = New System.Drawing.Size(252, 56)
        Me.tb_observacion.TabIndex = 11
        '
        'tb_bancodep
        '
        Me.tb_bancodep.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_bancodep.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_bancodep.ColumnNum = 1
        Me.tb_bancodep.ColumnWidth = "100"
        Me.tb_bancodep.DisplayMember = "Text"
        Me.tb_bancodep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_bancodep.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_bancodep.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_bancodep.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.tb_bancodep.DropDownWidth = 170
        Me.tb_bancodep.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bancodep.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_bancodep.GridLineHorizontal = False
        Me.tb_bancodep.GridLineVertical = False
        Me.tb_bancodep.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_bancodep.Location = New System.Drawing.Point(461, 147)
        Me.tb_bancodep.ManagingFastMouseMoving = True
        Me.tb_bancodep.ManagingFastMouseMovingInterval = 30
        Me.tb_bancodep.Name = "tb_bancodep"
        Me.tb_bancodep.Size = New System.Drawing.Size(130, 23)
        Me.tb_bancodep.TabIndex = 9
        '
        'notas
        '
        Me.notas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notas.Location = New System.Drawing.Point(459, 279)
        Me.notas.Name = "notas"
        Me.notas.Size = New System.Drawing.Size(120, 20)
        Me.notas.TabIndex = 77
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(342, 150)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(133, 20)
        Me.Label23.TabIndex = 76
        Me.Label23.Text = "Banco a Depositar:"
        '
        'tb_banco
        '
        Me.tb_banco.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.tb_banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_banco.ColumnNum = 2
        Me.tb_banco.ColumnWidth = "135;0"
        Me.tb_banco.DisplayMember = "Text"
        Me.tb_banco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tb_banco.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tb_banco.DropDownForeColor = System.Drawing.Color.Black
        Me.tb_banco.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.tb_banco.DropDownWidth = 175
        Me.tb_banco.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_banco.GridLineColor = System.Drawing.Color.LightGray
        Me.tb_banco.GridLineHorizontal = False
        Me.tb_banco.GridLineVertical = False
        Me.tb_banco.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.tb_banco.Location = New System.Drawing.Point(100, 165)
        Me.tb_banco.ManagingFastMouseMoving = True
        Me.tb_banco.ManagingFastMouseMovingInterval = 30
        Me.tb_banco.Name = "tb_banco"
        Me.tb_banco.Size = New System.Drawing.Size(130, 23)
        Me.tb_banco.TabIndex = 5
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.Color.White
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.Location = New System.Drawing.Point(305, 337)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 13
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        '
        'bt_aceptar
        '
        Me.bt_aceptar.BackColor = System.Drawing.Color.White
        Me.bt_aceptar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.Location = New System.Drawing.Point(220, 337)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 12
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = False
        '
        'tb_fecha
        '
        Me.tb_fecha.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_fecha.Location = New System.Drawing.Point(100, 110)
        Me.tb_fecha.Name = "tb_fecha"
        Me.tb_fecha.Size = New System.Drawing.Size(130, 22)
        Me.tb_fecha.TabIndex = 3
        '
        'tb_monto
        '
        Me.tb_monto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_monto.Location = New System.Drawing.Point(100, 251)
        Me.tb_monto.MaxLength = 50
        Me.tb_monto.Name = "tb_monto"
        Me.tb_monto.Size = New System.Drawing.Size(131, 22)
        Me.tb_monto.TabIndex = 7
        '
        'tb_cheque
        '
        Me.tb_cheque.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cheque.Location = New System.Drawing.Point(100, 223)
        Me.tb_cheque.MaxLength = 18
        Me.tb_cheque.Name = "tb_cheque"
        Me.tb_cheque.Size = New System.Drawing.Size(130, 22)
        Me.tb_cheque.TabIndex = 6
        '
        'tb_deposito
        '
        Me.tb_deposito.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_deposito.Location = New System.Drawing.Point(100, 138)
        Me.tb_deposito.MaxLength = 18
        Me.tb_deposito.Name = "tb_deposito"
        Me.tb_deposito.Size = New System.Drawing.Size(130, 22)
        Me.tb_deposito.TabIndex = 4
        '
        'tb_efectivo
        '
        Me.tb_efectivo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_efectivo.Location = New System.Drawing.Point(100, 278)
        Me.tb_efectivo.MaxLength = 50
        Me.tb_efectivo.Name = "tb_efectivo"
        Me.tb_efectivo.Size = New System.Drawing.Size(131, 22)
        Me.tb_efectivo.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Fecha:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 171)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Banco:"
        '
        'tb_control
        '
        Me.tb_control.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_control.Location = New System.Drawing.Point(100, 83)
        Me.tb_control.MaxLength = 100
        Me.tb_control.Name = "tb_control"
        Me.tb_control.Size = New System.Drawing.Size(130, 22)
        Me.tb_control.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(342, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 23)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Fecha Depósito:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(343, 248)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Observación:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 257)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 23)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Monto:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Efectivo:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "N° Cheque:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "N° Depósito:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "N°Control:"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(461, 336)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(133, 23)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "(*) Datos Requeridos"
        '
        'l_retencion
        '
        Me.l_retencion.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_retencion.Location = New System.Drawing.Point(476, 101)
        Me.l_retencion.Name = "l_retencion"
        Me.l_retencion.Size = New System.Drawing.Size(71, 20)
        Me.l_retencion.TabIndex = 101
        Me.l_retencion.Text = "Retención:"
        Me.l_retencion.Visible = False
        '
        'l_recibo
        '
        Me.l_recibo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_recibo.Location = New System.Drawing.Point(101, 85)
        Me.l_recibo.Name = "l_recibo"
        Me.l_recibo.Size = New System.Drawing.Size(91, 23)
        Me.l_recibo.TabIndex = 8
        Me.l_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.l_recibo.Visible = False
        '
        'bt_procesar
        '
        Me.bt_procesar.BackColor = System.Drawing.Color.White
        Me.bt_procesar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_procesar.Location = New System.Drawing.Point(221, 338)
        Me.bt_procesar.Name = "bt_procesar"
        Me.bt_procesar.Size = New System.Drawing.Size(75, 23)
        Me.bt_procesar.TabIndex = 95
        Me.bt_procesar.Text = "Procesar"
        Me.bt_procesar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(408, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(608, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Datos del Recibo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_buscarcodigo
        '
        Me.tb_buscarcodigo.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_buscarcodigo.Location = New System.Drawing.Point(187, 108)
        Me.tb_buscarcodigo.Name = "tb_buscarcodigo"
        Me.tb_buscarcodigo.Size = New System.Drawing.Size(216, 25)
        Me.tb_buscarcodigo.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(5, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(398, 23)
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
        Me.Label16.Location = New System.Drawing.Point(408, 410)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(615, 23)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Histórico de Recibos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Recibos
        '
        Me.DGV_Recibos.AllowUserToAddRows = False
        Me.DGV_Recibos.AllowUserToDeleteRows = False
        Me.DGV_Recibos.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DGV_Recibos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Recibos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Recibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Recibo, Me.DataGridViewTextBoxColumn2, Me.FechaDeposito, Me.DataGridViewTextBoxColumn5, Me.MontoDep, Me.DataGridViewTextBoxColumn4, Me.codF, Me.Devolucion, Me.Retencion, Me.DataGridViewTextBoxColumn3})
        Me.DGV_Recibos.Location = New System.Drawing.Point(408, 431)
        Me.DGV_Recibos.Name = "DGV_Recibos"
        Me.DGV_Recibos.RowHeadersVisible = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Recibos.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DGV_Recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Recibos.ShowEditingIcon = False
        Me.DGV_Recibos.Size = New System.Drawing.Size(615, 255)
        Me.DGV_Recibos.TabIndex = 75
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'Recibo
        '
        Me.Recibo.HeaderText = "Recibo"
        Me.Recibo.Name = "Recibo"
        Me.Recibo.ReadOnly = True
        Me.Recibo.Visible = False
        Me.Recibo.Width = 68
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaF."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'FechaDeposito
        '
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.FechaDeposito.DefaultCellStyle = DataGridViewCellStyle9
        Me.FechaDeposito.HeaderText = "FechaD."
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.ReadOnly = True
        Me.FechaDeposito.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.HeaderText = "MontoF."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 83
        '
        'MontoDep
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.MontoDep.DefaultCellStyle = DataGridViewCellStyle11
        Me.MontoDep.HeaderText = "MontoD."
        Me.MontoDep.Name = "MontoDep"
        Me.MontoDep.ReadOnly = True
        Me.MontoDep.Width = 83
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dias"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 45
        '
        'codF
        '
        Me.codF.HeaderText = "codF"
        Me.codF.Name = "codF"
        Me.codF.ReadOnly = True
        Me.codF.Visible = False
        '
        'Devolucion
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Devolucion.DefaultCellStyle = DataGridViewCellStyle13
        Me.Devolucion.HeaderText = "NC"
        Me.Devolucion.Name = "Devolucion"
        Me.Devolucion.ReadOnly = True
        Me.Devolucion.Width = 70
        '
        'Retencion
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Retencion.DefaultCellStyle = DataGridViewCellStyle14
        Me.Retencion.HeaderText = "Ret."
        Me.Retencion.Name = "Retencion"
        Me.Retencion.ReadOnly = True
        Me.Retencion.Visible = False
        Me.Retencion.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Iva"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DGV_R
        '
        Me.DGV_R.AllowUserToAddRows = False
        Me.DGV_R.AllowUserToDeleteRows = False
        Me.DGV_R.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.DGV_R.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGV_R.AutoGenerateColumns = False
        Me.DGV_R.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_R.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoReciboDataGridViewTextBoxColumn, Me.NControlDataGridViewTextBoxColumn, Me.CodigoClienteDataGridViewTextBoxColumn, Me.RazonsocialDataGridViewTextBoxColumn, Me.ContEspecialDataGridViewCheckBoxColumn, Me.NDepositoDataGridViewTextBoxColumn, Me.PhraseDataGridViewTextBoxColumn, Me.PDDataGridViewCheckBoxColumn})
        Me.DGV_R.DataSource = Me.SpconsultaRecibos2BindingSource
        Me.DGV_R.Location = New System.Drawing.Point(7, 138)
        Me.DGV_R.MultiSelect = False
        Me.DGV_R.Name = "DGV_R"
        Me.DGV_R.RowHeadersVisible = False
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_R.RowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DGV_R.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_R.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_R.ShowEditingIcon = False
        Me.DGV_R.Size = New System.Drawing.Size(398, 248)
        Me.DGV_R.TabIndex = 76
        '
        'CodigoReciboDataGridViewTextBoxColumn
        '
        Me.CodigoReciboDataGridViewTextBoxColumn.DataPropertyName = "CodigoRecibo"
        Me.CodigoReciboDataGridViewTextBoxColumn.HeaderText = "CodigoRecibo"
        Me.CodigoReciboDataGridViewTextBoxColumn.Name = "CodigoReciboDataGridViewTextBoxColumn"
        Me.CodigoReciboDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoReciboDataGridViewTextBoxColumn.Visible = False
        '
        'NControlDataGridViewTextBoxColumn
        '
        Me.NControlDataGridViewTextBoxColumn.DataPropertyName = "NControl"
        Me.NControlDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.NControlDataGridViewTextBoxColumn.Name = "NControlDataGridViewTextBoxColumn"
        Me.NControlDataGridViewTextBoxColumn.ReadOnly = True
        Me.NControlDataGridViewTextBoxColumn.Width = 60
        '
        'CodigoClienteDataGridViewTextBoxColumn
        '
        Me.CodigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoCliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.Name = "CodigoClienteDataGridViewTextBoxColumn"
        Me.CodigoClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoClienteDataGridViewTextBoxColumn.Width = 62
        '
        'RazonsocialDataGridViewTextBoxColumn
        '
        Me.RazonsocialDataGridViewTextBoxColumn.DataPropertyName = "razonsocial"
        Me.RazonsocialDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.RazonsocialDataGridViewTextBoxColumn.Name = "RazonsocialDataGridViewTextBoxColumn"
        Me.RazonsocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonsocialDataGridViewTextBoxColumn.Width = 253
        '
        'ContEspecialDataGridViewCheckBoxColumn
        '
        Me.ContEspecialDataGridViewCheckBoxColumn.DataPropertyName = "contEspecial"
        Me.ContEspecialDataGridViewCheckBoxColumn.HeaderText = "contEspecial"
        Me.ContEspecialDataGridViewCheckBoxColumn.Name = "ContEspecialDataGridViewCheckBoxColumn"
        Me.ContEspecialDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ContEspecialDataGridViewCheckBoxColumn.Visible = False
        '
        'NDepositoDataGridViewTextBoxColumn
        '
        Me.NDepositoDataGridViewTextBoxColumn.DataPropertyName = "NDeposito"
        Me.NDepositoDataGridViewTextBoxColumn.HeaderText = "NDeposito"
        Me.NDepositoDataGridViewTextBoxColumn.Name = "NDepositoDataGridViewTextBoxColumn"
        Me.NDepositoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NDepositoDataGridViewTextBoxColumn.Visible = False
        '
        'PhraseDataGridViewTextBoxColumn
        '
        Me.PhraseDataGridViewTextBoxColumn.DataPropertyName = "phrase"
        Me.PhraseDataGridViewTextBoxColumn.HeaderText = "phrase"
        Me.PhraseDataGridViewTextBoxColumn.Name = "PhraseDataGridViewTextBoxColumn"
        Me.PhraseDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhraseDataGridViewTextBoxColumn.Visible = False
        '
        'PDDataGridViewCheckBoxColumn
        '
        Me.PDDataGridViewCheckBoxColumn.DataPropertyName = "PD"
        Me.PDDataGridViewCheckBoxColumn.HeaderText = "PD"
        Me.PDDataGridViewCheckBoxColumn.Name = "PDDataGridViewCheckBoxColumn"
        Me.PDDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PDDataGridViewCheckBoxColumn.Visible = False
        '
        'SpconsultaRecibos2BindingSource
        '
        Me.SpconsultaRecibos2BindingSource.DataMember = "sp_consultaRecibos2"
        Me.SpconsultaRecibos2BindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DomainUpDown1.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.FormattingEnabled = True
        Me.DomainUpDown1.Location = New System.Drawing.Point(9, 107)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(172, 26)
        Me.DomainUpDown1.TabIndex = 77
        '
        'DGV_Fact
        '
        Me.DGV_Fact.AllowUserToAddRows = False
        Me.DGV_Fact.AllowUserToDeleteRows = False
        Me.DGV_Fact.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_Fact.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Fact.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Fact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Fact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Fecha, Me.Venc, Me.Dias, Me.Monto, Me.column1, Me.Nro, Me.Iva, Me.NC})
        Me.DGV_Fact.Location = New System.Drawing.Point(5, 431)
        Me.DGV_Fact.Name = "DGV_Fact"
        Me.DGV_Fact.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Fact.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Fact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Fact.ShowEditingIcon = False
        Me.DGV_Fact.Size = New System.Drawing.Size(398, 256)
        Me.DGV_Fact.TabIndex = 71
        '
        'Cod
        '
        Me.Cod.HeaderText = "Fact."
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Width = 55
        '
        'Fecha
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 75
        '
        'Venc
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Venc.DefaultCellStyle = DataGridViewCellStyle3
        Me.Venc.HeaderText = "Vencimiento"
        Me.Venc.Name = "Venc"
        Me.Venc.ReadOnly = True
        Me.Venc.Width = 75
        '
        'Dias
        '
        Me.Dias.HeaderText = "D."
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 33
        '
        'Monto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Monto.HeaderText = "Total"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 67
        '
        'column1
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.column1.DefaultCellStyle = DataGridViewCellStyle5
        Me.column1.HeaderText = "Pend."
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Width = 68
        '
        'Nro
        '
        Me.Nro.HeaderText = "Nro"
        Me.Nro.Name = "Nro"
        Me.Nro.Visible = False
        '
        'Iva
        '
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.Visible = False
        '
        'NC
        '
        Me.NC.HeaderText = "NC"
        Me.NC.Name = "NC"
        Me.NC.ReadOnly = True
        Me.NC.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 63)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 19)
        Me.CheckBox1.TabIndex = 78
        Me.CheckBox1.Text = "Cheques Posdatados"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.AllowUserToAddRows = False
        Me.DGV_Clientes.AllowUserToDeleteRows = False
        Me.DGV_Clientes.AllowUserToResizeRows = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        Me.DGV_Clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DGV_Clientes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoRecibo, Me.N, Me.Cliente2, Me.Razon, Me.ContEspecial2})
        Me.DGV_Clientes.Location = New System.Drawing.Point(7, 138)
        Me.DGV_Clientes.MultiSelect = False
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.ReadOnly = True
        Me.DGV_Clientes.RowHeadersVisible = False
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Clientes.RowsDefaultCellStyle = DataGridViewCellStyle19
        Me.DGV_Clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Clientes.ShowEditingIcon = False
        Me.DGV_Clientes.Size = New System.Drawing.Size(398, 248)
        Me.DGV_Clientes.TabIndex = 79
        Me.DGV_Clientes.Visible = False
        '
        'CodigoRecibo
        '
        Me.CodigoRecibo.HeaderText = "Column2"
        Me.CodigoRecibo.Name = "CodigoRecibo"
        Me.CodigoRecibo.ReadOnly = True
        Me.CodigoRecibo.Visible = False
        '
        'N
        '
        Me.N.HeaderText = "N"
        Me.N.Name = "N"
        Me.N.ReadOnly = True
        Me.N.Visible = False
        '
        'Cliente2
        '
        Me.Cliente2.HeaderText = "Cliente"
        Me.Cliente2.Name = "Cliente2"
        Me.Cliente2.ReadOnly = True
        Me.Cliente2.Width = 75
        '
        'Razon
        '
        Me.Razon.HeaderText = "Razón Social"
        Me.Razon.Name = "Razon"
        Me.Razon.ReadOnly = True
        Me.Razon.Width = 300
        '
        'ContEspecial2
        '
        Me.ContEspecial2.HeaderText = "ContEspecial"
        Me.ContEspecial2.Name = "ContEspecial2"
        Me.ContEspecial2.ReadOnly = True
        Me.ContEspecial2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rb_confirmados)
        Me.Panel1.Controls.Add(Me.rb_pendientes)
        Me.Panel1.Location = New System.Drawing.Point(178, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 24)
        Me.Panel1.TabIndex = 10055
        '
        'rb_confirmados
        '
        Me.rb_confirmados.AutoSize = True
        Me.rb_confirmados.Checked = True
        Me.rb_confirmados.Font = New System.Drawing.Font("Eras Medium ITC", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_confirmados.Location = New System.Drawing.Point(9, 2)
        Me.rb_confirmados.Name = "rb_confirmados"
        Me.rb_confirmados.Size = New System.Drawing.Size(93, 18)
        Me.rb_confirmados.TabIndex = 10056
        Me.rb_confirmados.TabStop = True
        Me.rb_confirmados.Text = "Confirmados"
        Me.rb_confirmados.UseVisualStyleBackColor = True
        '
        'rb_pendientes
        '
        Me.rb_pendientes.AutoSize = True
        Me.rb_pendientes.Font = New System.Drawing.Font("Eras Medium ITC", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_pendientes.Location = New System.Drawing.Point(119, 2)
        Me.rb_pendientes.Name = "rb_pendientes"
        Me.rb_pendientes.Size = New System.Drawing.Size(97, 18)
        Me.rb_pendientes.TabIndex = 10055
        Me.rb_pendientes.Text = "Por confirmar"
        Me.rb_pendientes.UseVisualStyleBackColor = True
        '
        'Sp_consultaRecibos2TableAdapter
        '
        Me.Sp_consultaRecibos2TableAdapter.ClearBeforeFill = True
        '
        'l_recibosPC
        '
        Me.l_recibosPC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_recibosPC.Location = New System.Drawing.Point(361, 386)
        Me.l_recibosPC.Name = "l_recibosPC"
        Me.l_recibosPC.Size = New System.Drawing.Size(34, 23)
        Me.l_recibosPC.TabIndex = 10057
        Me.l_recibosPC.Text = "#"
        Me.l_recibosPC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 387)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 23)
        Me.Label19.TabIndex = 10056
        Me.Label19.Text = "Total Confirmados:"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 85)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(170, 19)
        Me.CheckBox2.TabIndex = 10058
        Me.CheckBox2.Text = "Comprobante Pendiente"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Frm_Recibos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 709)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.l_recibosPC)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGV_Fact)
        Me.Controls.Add(Me.tb_buscarcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.l_recibos)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DGV_Recibos)
        Me.Controls.Add(Me.DGV_R)
        Me.Controls.Add(Me.DGV_Clientes)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-3, -3)
        Me.MaximumSize = New System.Drawing.Size(1034, 740)
        Me.MinimumSize = New System.Drawing.Size(1022, 706)
        Me.Name = "Frm_Recibos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Recibos"
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpconsultaRecibos2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Fact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public Sub usuario(ByVal U As String, ByVal un As String)
        user = My.Settings.UserLogin
        user_name = My.Settings.UserName
    End Sub

    Private Sub Frm_Recibos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not frm1 Is Nothing Then
            frm1.f39 = Nothing
        End If
    End Sub
    Private Sub Form36_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

            'TODO: This line of code loads data into the 'MELDataSet.sp_consultaRecibos2' table. You can move, or remove it, as needed.
            Me.Sp_consultaRecibos2TableAdapter.Fill(Me.MELDataSet.sp_consultaRecibos2)

            user = My.Settings.UserLogin
            user_name = My.Settings.UserName

            Me.rb_confirmados.Checked = True

            Me.tb_usuario.ReadOnly = True
            Me.tb_monto.ReadOnly = True
            Me.tb_bancodep.Enabled = False
            Me.tb_banco.Enabled = False
            Me.tb_deposito.ReadOnly = True
            Me.tb_cheque.ReadOnly = True
            Me.tb_fecha.Enabled = False
            Me.tb_efectivo.ReadOnly = True
            Me.tb_control.ReadOnly = True
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.bt_procesar.Visible = False
            Me.tb_fechaD.Enabled = False
            Me.tb_observacion.Enabled = False
            Me.notas.Visible = True
            Me.tb_retencion.ReadOnly = True
            Me.tb_fechaD.Value = Today.Date
            DatosBanco.consulta_bancos(Me.tb_banco)
            DatosBanco.consulta_bancosCuentas(Me.tb_bancodep)
            Dim cant As Integer = 0
            'DatosRecibo.consulta_recibos_todos(Me.DGV_R, cant, False)
            l_recibos.Text = cant
            Me.DomainUpDown1.Items.Clear()
            Me.DomainUpDown1.Items.Add("Razón Social")
            Me.DomainUpDown1.Items.Add("N°Recibo")
            Me.DomainUpDown1.Items.Add("N°Factura")
            Me.DomainUpDown1.Items.Add("N°Depósito")
            Me.DomainUpDown1.Items.Add("Monto")
            Me.DomainUpDown1.SelectedIndex = 1
            Me.tb_retencion.Text = 0
            DGV_R.ClearSelection()

            If Me.w = False Then
                Me.bt_eliminar.Visible = False
                Me.bt_modificar.Visible = False
            End If

            If Me.e = False Then
                Me.bt_nuevo.Visible = False
            End If

            Dim Sum As Object
            Sum = Me.MELDataSet.sp_consultaRecibos2.Compute("COUNT(CodigoRecibo)", "")
            l_recibos.Text = Sum

            Dim Sum2 As Object
            Sum2 = Me.MELDataSet.sp_consultaRecibos2.Compute("COUNT(CodigoRecibo)", "Confirmado = False")
            l_recibosPC.Text = Sum2

            tb_buscarcodigo.Focus()

        Catch ex As Exception

        End Try

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
            Me.ch_pd.Visible = True
            Me.chk_comp.Enabled = True
            Me.ch_pd.Checked = False
            Dim cant As Integer = 0
            Me.DGV_R.Columns(1).Visible = False
            Me.DGV_R.Columns(3).Width = 310
            Me.ToolBar1.Enabled = False
            DatosRecibo.consulta_clientes(Me.DGV_Clientes, cant)
            DGV_Clientes.Visible = True
            DGV_R.SendToBack()
            cli = True
            varBoton = 1
            limpia()
            tb_usuario.Text = user_name
            DatosBanco.consulta_bancos(Me.tb_banco)
            DatosBanco.consulta_bancosCuentas(Me.tb_bancodep)
            For cont As Integer = 0 To tb_bancodep.Items.Count - 1
                If tb_bancodep.Items(cont).Text.ToString.Trim = "Mercantil" Then
                    tb_bancodep.SelectedIndex = cont
                End If
            Next
            tb_bancodep.Enabled = True
            DatosRecibo.identidad_Recibo(Me.l_recibo.Text)
            Me.Label12.Visible = False
            Me.ch_dev.Visible = False
            Me.l_razon.ResetText()
            Me.l_codCliente.ResetText()
            Me.l_monto.Text = 0
            Me.l_saldo.Text = 0
            RemoveHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            Me.tb_buscarcodigo.Clear()
            AddHandler tb_buscarcodigo.TextChanged, AddressOf tb_buscar_TextChanged
            Me.DGV_Recibos.Rows.Clear()
            Me.DGV_Fact.Rows.Clear()
            Me.tb_efectivo.Enabled = True
            Me.DGV_Recibos.Enabled = False
            Me.ch_contEspecial.Visible = False
            Me.l_con.Visible = False
            Me.l_retencion.Visible = False
            Me.tb_retencion.Visible = False
            Me.tb_buscarcodigo.Focus()
            Me.tb_fechaCD.Enabled = True
            Me.tb_observacion.ResetText()
            Me.tb_monto.ReadOnly = True
            Me.DomainUpDown1.Items.RemoveAt(2)
            Me.DomainUpDown1.Items.RemoveAt(2)
            Me.DomainUpDown1.Items.RemoveAt(1)
            Me.DomainUpDown1.SelectedIndex = 0
            Me.DomainUpDown1.Items.Add("Código Cliente")
            DGV_Clientes.ClearSelection()
            DGV_R.ClearSelection()
        ElseIf e.Button Is Me.bt_modificar Then
            varBoton = 2
            cli = True
            Dim n1 As Integer
            n1 = Me.DGV_R.SelectedRows.Count
            If n1 = 1 Then
                Me.chk_comp.Enabled = True
                Me.tb_control.ReadOnly = False
                Me.tb_fecha.Enabled = True
                Me.l_saldo.Text = 0
                Me.tb_observacion.Enabled = True
                Me.DGV_Recibos.Enabled = False
                Me.DGV_R.Enabled = False
                Me.DGV_Fact.Enabled = False
                Me.tb_buscarcodigo.Enabled = False
                Me.ToolBar1.Enabled = False
                Me.DomainUpDown1.Enabled = False
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                Me.tb_fechaCD.Enabled = False
                Me.antCH = Me.ch_dev.Checked

                Me.DomainUpDown1.Items.RemoveAt(2)
                Me.DomainUpDown1.Items.RemoveAt(2)
                Me.DomainUpDown1.SelectedIndex = 1
                tb_bancodep.Enabled = True
                Me.ch_pd.Enabled = False
                If ch_pd.Checked Then
                    Me.ch_dev.Enabled = False
                    Me.tb_monto.ReadOnly = True
                    Me.tb_cheque.ReadOnly = False
                Else
                    Me.ch_dev.Enabled = True
                End If
                If ch_dev.Checked Then
                    Me.ch_dev.Enabled = True
                Else
                    Me.ch_dev.Enabled = False
                End If

                If ch_contEspecial.Checked Then
                    Me.chk_comp.Enabled = True
                    Me.tb_compRet.ReadOnly = False
                End If

                Me.tb_control.Focus()
            ElseIf n1 = 0 Then
                MsgBox("Debe seleccionar el recibo que desea modificar", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                MsgBox("Solo puede modificar un recibo a la vez", MsgBoxStyle.OkOnly, "Mensaje de Error")
            End If
        ElseIf e.Button Is Me.bt_confirmar Then

            If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then

                If DGV_R.SelectedRows.Count > 0 Then

                    Dim resp As Integer = MsgBox("Está seguro que desea confirmar este recibo de pago?", MsgBoxStyle.YesNo, "SINPRO")

                    If resp = vbYes Then

                        'Confirmar Recibo
                        If DatosRecibo.Confirma_Recibo(tb_deposito.Text, CInt(tb_bancodep.SelectedItem.col2.ToString), tb_monto.Text, CInt(DGV_R.SelectedRows(0).Cells(0).Value)) Then

                            Dim tope As String = ""
                            DatosConfiguracion.consulta_MontoAjuste(tope)

                            Datos.Inserta_Actividad("Confirmó el recibo nro. " + tb_control.Text + " del cliente (" + l_codCliente.Text + ") " + l_razon.Text)

                            '-----------------------------------------------------------------------------------------------------------------

                            'Revisa y crea ajustes automáticos al cliente

                            For cont As Integer = 0 To DGV_Fact.RowCount - 1

                                For cont2 As Integer = 0 To DGV_Recibos.RowCount - 1

                                    If DGV_Fact.Rows(cont).Cells(0).Value.ToString = DGV_Recibos.Rows(cont2).Cells(0).Value.ToString And DGV_Fact.Rows(cont).Visible Then

                                        If Math.Abs(CDbl(DGV_Fact.Rows(cont).Cells(5).Value)) - (Math.Abs(CDbl(DGV_Recibos.Rows(cont).Cells(5).Value)) + Math.Abs(CDbl(DGV_Recibos.Rows(cont).Cells(9).Value))) <= CDbl(tope) And CDbl(DGV_Fact.Rows(cont).Cells(5).Value) <> 0 Then
                                            DatosAjusteSaldo.InsertaAjuste(Today.Date, user, CInt(DGV_Fact.Rows(cont).Cells(6).Value), _
                                            Format(CDbl(Math.Abs(CDbl(DGV_Fact.Rows(cont).Cells(5).Value)) - (Math.Abs(CDbl(DGV_Recibos.Rows(cont).Cells(5).Value)) + Math.Abs(CDbl(DGV_Recibos.Rows(cont).Cells(9).Value)))) * -1, "#,##0.00"), "Ajuste Automático")
                                        End If

                                    End If

                                Next

                            Next

                            If Math.Abs(CDbl(l_saldo.Text)) <= CDbl(tope) And CDbl(l_saldo.Text) <> 0 Then

                                DatosAjusteSaldo.InsertaAjuste(Today.Date, user, CInt(DGV_Recibos.Rows(DGV_Recibos.RowCount - 1).Cells(7).Value), _
                                Format(CDbl(l_saldo.Text), "#,##0.00"), "Ajuste Automático")

                            End If

                            '-----------------------------------------------------------------------------------------------------------------

                            Me.Sp_consultaRecibos2TableAdapter.Fill(Me.MELDataSet.sp_consultaRecibos2)
                            CrearWhere()
                            tb_buscarcodigo.Focus()
                            tb_buscarcodigo.SelectAll()

                        End If

                        If varBoton = 10 Then
                            Me.frm1.Button3_Click(frm1.Button3, New EventArgs)
                            Me.Close()
                        End If

                    End If

                Else

                    MsgBox("Debe seleccionar un recibo para confirmarlo", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            End If

        ElseIf e.Button Is Me.bt_eliminar Then
            varBoton = 3
            Dim response As MsgBoxResult
            Dim cod As Integer
            If Me.DGV_R.SelectedRows.Count = 0 Then
                MsgBox("Debe seleccionar el recibo que desea eliminar ", MsgBoxStyle.OkOnly, "Mensaje de Error")
            Else
                Dim pagado As Boolean = False
                DatosRecibo.consulta_ReciboPagado(CInt(Me.DGV_R.SelectedRows(0).Cells(0).Value), pagado)
                If pagado = False Then

                    response = MsgBox("¿Confirma que desea eliminar (" + Me.DGV_R.SelectedRows.Count.ToString + ") recibo(s)?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")

                    If (response = MsgBoxResult.Yes) Then

                        Dim i As Integer = 0

                        While i < Me.DGV_R.SelectedRows.Count

                            cod = CInt(Me.DGV_R.SelectedRows(i).Cells(0).Value)

                            DatosRecibo.elimina_Facturas_Recibo(cod)
                            DatosRecibo.elimina_Recibo(cod)

                            If Me.tb_monto.Text <> "" And ch_pd.Checked = False Then
                                Dim esta As Boolean = False

                                DatosMovimientos.modifica_movimientos(tb_deposito.Text, False, 0, 0, esta, tb_fechaD.Value)

                                If esta = False And rb_confirmados.Checked Then
                                    DatosMovimientos.Inserta_movimiento(tb_deposito.Text, CInt(tb_bancodep.SelectedItem.col2.ToString), "Depósito", tb_monto.Text, "", "", tb_fechaD.Value, False)
                                End If

                            End If
                            i = i + 1
                        End While

                        Datos.Inserta_Actividad("Eliminó el recibo nro. " + tb_control.Text + " del cliente (" + l_codCliente.Text + ") " + l_razon.Text)

                        Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Recibo eliminado satisfactoriamente", ToolTipIcon.Info)
                        limpia()

                        Me.Sp_consultaRecibos2TableAdapter.Fill(Me.MELDataSet.sp_consultaRecibos2)
                        CrearWhere()

                        Dim Sum As Object
                        Sum = Me.MELDataSet.sp_consultaRecibos2.Compute("COUNT(CodigoRecibo)", "")

                        If rb_confirmados.Checked Then
                            l_recibos.Text = Sum
                        Else
                            l_recibosPC.Text = Sum
                        End If


                        Me.DGV_Fact.Rows.Clear()
                        Me.DGV_Recibos.Rows.Clear()

                    End If
                    varBoton = 0
                Else
                    MsgBox("El recibo que desea eliminar tiene comisiones pagadas asociadas. Primero elimine la comisión y luego el recibo.")
                End If
            End If
        End If
    End Sub
    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        If otra = True Then
            If Not frm1 Is Nothing Then
                frm1.f39 = Nothing
            End If
            Me.Close()
        Else
            cli = False
            tb_bancodep.Enabled = False
            Me.DGV_R.Enabled = True
            Me.DGV_Clientes.Enabled = True
            Me.notas.Visible = False
            Me.tb_buscarcodigo.Enabled = True
            Me.ToolBar1.Enabled = True
            Me.DomainUpDown1.Enabled = True
            Me.tb_bancodep.Enabled = False
            Me.chk_comp.Enabled = False
            Me.tb_banco.Enabled = False
            Me.tb_usuario.Clear()
            Me.tb_cheque.ReadOnly = True
            Me.tb_fecha.Enabled = False
            Me.tb_efectivo.Enabled = False
            Me.tb_monto.ReadOnly = True
            Me.tb_control.ReadOnly = True
            Me.tb_deposito.ReadOnly = True
            Me.bt_aceptar.Visible = False
            Me.bt_cancelar.Visible = False
            Me.tb_fechaD.Enabled = False
            tb_compRet.ReadOnly = False
            Me.tb_retencion.Enabled = False
            Me.DomainUpDown1.SelectedItem = 1
            Me.tb_observacion.Enabled = False
            Dim cant As Integer = 0
            If varBoton = 1 Then
                DGV_Clientes.Visible = False
                DGV_Clientes.SendToBack()
                Me.DGV_R.Columns(1).Visible = True
                Me.DGV_R.Columns(3).Width = 260
                Me.tb_buscarcodigo.Text = ""
                Dim c As Integer = 0
                'DatosRecibo.consulta_recibos_todos(Me.DGV_R, c, Me.CheckBox1.Checked)
                CrearWhere()
                'Me.l_recibos.Text = c
            End If
            Me.bt_procesar.Visible = False
            varBoton = 0
            muestra_label(Me.tb_control, 1)
            Me.tb_buscarcodigo.Focus()
            Me.ch_pd.Checked = False
            Me.ch_pd.Enabled = False
            DatosBanco.consulta_bancos(Me.tb_banco)
            DatosBanco.consulta_bancosCuentas(Me.tb_bancodep)
            Me.ch_dev.Enabled = False
            Me.DomainUpDown1.Items.Clear()
            Me.DomainUpDown1.Items.Add("Razón Social")
            Me.DomainUpDown1.Items.Add("N°Recibo")
            Me.DomainUpDown1.Items.Add("N°Factura")
            Me.DomainUpDown1.Items.Add("N°Depósito")
            Me.DomainUpDown1.Items.Add("Monto")
            Me.DomainUpDown1.SelectedIndex = 0
            Me.Label12.Visible = True
            Me.ch_dev.Visible = True
            Me.tb_compRet.ReadOnly = True
            DGV_R_Selectedindex()
        End If
    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If (Me.tb_monto.Text = "" And (Me.tb_efectivo.Text = "" Or Not IsNumeric(Me.tb_efectivo.Text)) Or (chk_comp.Checked And tb_compRet.Text = "")) Then
            ll = True
        Else
            ll = False
        End If
        Return ll
    End Function

    Private Function suma(ByRef ac As Double) As Boolean
        Dim ll As Boolean = False
        Dim i As Integer = 0
        Dim acum As Double = 0
        While i < Me.DGV_Recibos.Rows.Count
            acum = acum + Math.Round(CDbl(Me.DGV_Recibos(5, i).Value), 2)
            i = i + 1
        End While
        If Math.Round(acum, 2) = CDbl(Me.l_monto.Text) Then
            ll = False
        Else
            ll = True
        End If
        ac = acum
        Return ll
    End Function

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False
        cli = False
        If Me.DGV_Recibos.Rows.Count <> 0 Then
            If (varBoton = 1) Then
                If llenos() Then
                    MsgBox("Debe ingresar todos los datos requeridos (*)")
                    deny = True
                Else
                    If Me.ch_pd.Checked Then
                        If Me.tb_cheque.Text = "" Then
                            MsgBox("Por favor ingresar el N° del cheque posdatado.")
                            deny = True
                        End If
                    Else
                        If CDbl(Me.l_saldo.Text) > 0 And Me.DGV_Fact.Rows.Count >= 1 Then
                            If Me.ch_dev.Checked = False Then
                                Dim resp As MsgBoxResult
                                resp = MsgBox("El monto del recibo supera el monto deudor. Esto generará un saldo a favor del cliente a pesar que posee otras facturas pendientes de cobro. ¿Es esto correcto?", MsgBoxStyle.YesNo)
                                If resp = MsgBoxResult.No Then
                                    deny = True
                                Else
                                    deny = False
                                End If
                            End If
                        Else
                            Dim acum As Double = 0
                            If suma(acum) Then
                                Dim resp As MsgBoxResult
                                resp = MsgBox("El monto del recibo no concuerda con los montos depositados de las facturas. Esto generará un saldo a favor del cliente. Es esto correcto? ", MsgBoxStyle.YesNo)
                                If resp = MsgBoxResult.No Then
                                    deny = True
                                Else
                                    deny = False
                                End If
                            End If

                            If tb_compRet.Text = "" And ch_contEspecial.Checked Then
                                MsgBox("Por favor ingresar el N° de comprobante de Retención")
                                deny = True
                            End If

                        End If
                    End If

                    If deny = False Then
                        DGV_Recibos(5, (DGV_Recibos.Rows.Count - 1)).Value = FormatNumber(DGV_Recibos(5, (DGV_Recibos.Rows.Count - 1)).Value + CDbl(Me.l_saldo.Text), 2)
                        Dim tope As String = ""
                        DatosConfiguracion.consulta_MontoAjuste(tope)

                        'If CDbl(Me.l_saldo.Text) <> 0 And CDbl(Me.l_saldo.Text) < CDbl(tope) Then
                        '    DatosAjusteSaldo.InsertaAjuste(Today.Date, user, DGV_Recibos(7, (DGV_Recibos.Rows.Count - 1)).Value, CDbl(Me.l_saldo.Text), "Ajuste Automático")
                        'End If

                        Dim ret As Double
                        If Me.tb_retencion.Visible = False Then
                            ret = 0
                        Else
                            ret = Me.tb_retencion.Text
                        End If

                        If Me.tb_banco.Text = "" Then

                            Dim cont As Integer = 0

                            While cont < tb_banco.Items.Count
                                If tb_banco.Items(cont).col1.ToString.ToUpper = "SIN INFORMACION" Then
                                    tb_banco.SelectedIndex = cont
                                    cont = tb_banco.Items.Count + 1
                                Else
                                    cont = cont + 1
                                End If
                            End While

                        End If

                        If Me.tb_bancodep.Text = "" Then

                            Dim cont As Integer = 0

                            While cont < tb_bancodep.Items.Count
                                If tb_bancodep.Items(cont).col1.ToString.ToUpper = "SIN INFORMACION" Then
                                    tb_bancodep.SelectedIndex = cont
                                    cont = tb_bancodep.Items.Count + 1
                                Else
                                    cont = cont + 1
                                End If
                            End While

                        End If

                        Try
                            DatosRecibo.inserta_recibo(Me.tb_control.Text, Me.tb_monto.Text, Me.tb_fecha.Value, Me.tb_deposito.Text, Me.tb_banco.SelectedItem.col2, Me.tb_cheque.Text, Me.tb_efectivo.Text, Me.tb_bancodep.SelectedItem.col2, Me.tb_fechaD.Value, Me.tb_observacion.Text, Me.ch_dev.Checked, ret, Me.tb_fechaCD.Value, Me.ch_pd.Checked, Me.tb_dep_chd.Text, Me.tb_compRet.Text, 0, chk_comp.Checked, tb_usuario.Text)
                            DatosRecibo.identidad_Recibo(Me.l_recibo.Text)
                        Catch ex As Exception
                            MsgBox("Error registrando recibo, verifique que se hayan ingresado todos los datos", MsgBoxStyle.Critical)
                        End Try

                        Dim row As Integer = 0

                        While row < Me.DGV_Recibos.Rows.Count
                            DatosRecibo.inserta_Factura_Recibo(CInt(Me.DGV_Recibos(7, row).Value), CInt(Me.l_recibo.Text), CDbl(Me.DGV_Recibos(5, row).Value), CDbl(Me.DGV_Recibos(9, row).Value))
                            row = row + 1
                        End While

                        Datos.Inserta_Actividad("Creó el recibo nro. " + tb_control.Text + " del cliente (" + l_codCliente.Text + ") " + l_razon.Text)

                        '-----------------------------------------------------------------------------------------------------------------

                        'Revisa y crea ajustes automáticos al cliente

                        For cont As Integer = 0 To DGV_Fact.RowCount - 1

                            For cont2 As Integer = 0 To DGV_Recibos.RowCount - 1

                                If DGV_Fact.Rows(cont).Cells(0).Value.ToString = DGV_Recibos.Rows(cont2).Cells(0).Value.ToString And DGV_Fact.Rows(cont).Visible Then

                                    If Math.Abs(CDbl(DGV_Fact.Rows(cont).Cells(5).Value)) <= CDbl(tope) And CDbl(DGV_Fact.Rows(cont).Cells(5).Value) <> 0 Then
                                        DatosAjusteSaldo.InsertaAjuste(Today.Date, user, CInt(DGV_Fact.Rows(cont).Cells(6).Value), _
                                        Format(CDbl(DGV_Fact.Rows(cont).Cells(5).Value) * -1, "#,##0.00"), "Ajuste Automático")
                                    End If

                                End If

                            Next

                        Next


                        If Math.Abs(CDbl(l_saldo.Text)) <= CDbl(tope) And CDbl(l_saldo.Text) <> 0 Then

                            DatosAjusteSaldo.InsertaAjuste(Today.Date, user, CInt(DGV_Recibos.Rows(DGV_Recibos.RowCount - 1).Cells(7).Value), _
                            Format(CDbl(l_saldo.Text), "#,##0.00"), "Ajuste Automático")

                        End If

                        '-----------------------------------------------------------------------------------------------------------------

                    End If
                End If
            ElseIf (varBoton = 2) Then
                If llenos() Then
                    MsgBox("Debe ingresar todos los datos requeridos (*)")
                    deny = True
                Else
                    Dim acum As Double = 0
                    If CDbl(Me.l_saldo.Text) > 0 And Me.DGV_Fact.Rows.Count >= 1 Then
                        If Me.ch_dev.Checked = False Then
                            Dim resp As MsgBoxResult
                            resp = MsgBox("El monto del recibo supera el monto deudor. Esto generará un saldo a favor del cliente a pesar que posee otras factuas pendientes de cobro. ¿Es esto correcto?", MsgBoxStyle.YesNo)
                            If resp = MsgBoxResult.No Then
                                deny = True
                            Else
                                deny = False
                            End If
                        End If
                    Else
                        If Me.ch_dev.Checked = False And Me.ch_pd.Checked = False Then
                            If suma(acum) Then
                                Dim resp As MsgBoxResult
                                resp = MsgBox("El monto del recibo no concuerda con los montos depositados de las facturas. Esto generará un saldo a favor del cliente. Es esto correcto? ", MsgBoxStyle.YesNo)
                                If resp = MsgBoxResult.No Then
                                    deny = True
                                Else
                                    deny = False
                                End If
                            End If
                        End If
                    End If
                    If deny = False Then
                        If Me.tb_retencion.Visible = False Then
                            Me.tb_retencion.Text = 0
                        End If

                        If Me.tb_banco.Text = "" Then

                            Dim cont As Integer = 0

                            While cont < tb_banco.Items.Count
                                If tb_banco.Items(cont).col1.ToString.ToUpper = "SIN INFORMACION" Then
                                    tb_banco.SelectedIndex = cont
                                    cont = tb_banco.Items.Count + 1
                                Else
                                    cont = cont + 1
                                End If
                            End While

                        End If

                        If Me.tb_bancodep.Text = "" Then

                            Dim cont As Integer = 0

                            While cont < tb_bancodep.Items.Count
                                If tb_bancodep.Items(cont).col1.ToString.ToUpper = "SIN INFORMACION" Then
                                    tb_bancodep.SelectedIndex = cont
                                    cont = tb_bancodep.Items.Count + 1
                                Else
                                    cont = cont + 1
                                End If
                            End While

                        End If

                        If sw_ch <> ch_dev.Checked And ch_dev.Checked = False And otra = False Then
                            DatosMovimientos.inserta_movimientos(Me.tb_dep_chd.Text, tb_fechaD.Text, tb_bancodep.SelectedItem.col2, tb_monto.Text, "", True, "", "", 0)
                            DatosRecibo.modifica_recibo(CInt(Me.l_recibo.Text), Me.tb_control.Text, Me.tb_monto.Text, Me.tb_fecha.Value, Me.tb_deposito.Text, Me.tb_banco.SelectedItem.Col2, Me.tb_cheque.Text, Me.tb_efectivo.Text, Me.tb_bancodep.SelectedItem.Col2, Me.tb_fechaD.Value, Me.tb_observacion.Text, Me.ch_dev.Checked, CDbl(Me.tb_retencion.Text), Me.tb_fechaCD.Value, "", Me.ch_pd.Checked, Me.tb_compRet.Text, 0, chk_comp.Checked)
                        Else
                            DatosRecibo.modifica_recibo(CInt(Me.l_recibo.Text), Me.tb_control.Text, Me.tb_monto.Text, Me.tb_fecha.Value, Me.tb_deposito.Text, Me.tb_banco.SelectedItem.Col2, Me.tb_cheque.Text, Me.tb_efectivo.Text, Me.tb_bancodep.SelectedItem.Col2, Me.tb_fechaD.Value, Me.tb_observacion.Text, Me.ch_dev.Checked, CDbl(Me.tb_retencion.Text), Me.tb_fechaCD.Value, Me.tb_dep_chd.Text, Me.ch_pd.Checked, Me.tb_compRet.Text, 0, chk_comp.Checked)
                        End If

                        If movchpd Or ch_dev.Checked Then
                            DatosRecibo.elimina_Facturas_Recibo(CInt(Me.l_recibo.Text))
                            Dim row As Integer = 0
                            While row < Me.DGV_Recibos.Rows.Count
                                DatosRecibo.inserta_Factura_Recibo(CInt(Me.DGV_Recibos(7, row).Value), CInt(Me.l_recibo.Text), CDbl(Me.DGV_Recibos(5, row).Value), CDbl(Me.DGV_Recibos(9, row).Value))
                                row = row + 1
                            End While
                        End If

                        If ch_dev.Checked And ch_dev.Checked <> antCH Then

                            Dim ch As Boolean = False

                            'Envío de email
                            Dim usuarios As Boolean = False
                            Dim vendedores As Boolean = False
                            Dim clientes As Boolean = False
                            Dim categoria As Integer = 3
                            Dim sub_categoria As Integer = 6

                            DatosCorreos.Consultar_Config_Correos(usuarios, vendedores, clientes, categoria)

                            If (vendedores Or clientes) Then
                                DatosCorreos.Crear_Correo(sub_categoria, CInt(Me.l_recibo.Text))
                            End If

                        End If

                        Datos.Inserta_Actividad("Modificó el recibo nro. " + tb_control.Text + " del cliente (" + l_codCliente.Text + ") " + l_razon.Text)

                        '-----------------------------------------------------------------------------------------------------------------

                        Dim tope As String = ""
                        DatosConfiguracion.consulta_MontoAjuste(tope)

                        'Revisa y crea ajustes automáticos al cliente

                        For cont As Integer = 0 To DGV_Fact.RowCount - 1

                            For cont2 As Integer = 0 To DGV_Recibos.RowCount - 1

                                If DGV_Fact.Rows(cont).Cells(0).Value.ToString = DGV_Recibos.Rows(cont2).Cells(0).Value.ToString And DGV_Fact.Rows(cont).Visible Then

                                    If Math.Abs(CDbl(DGV_Fact.Rows(cont).Cells(5).Value)) <= CDbl(tope) And CDbl(DGV_Fact.Rows(cont).Cells(5).Value) <> 0 Then
                                        DatosAjusteSaldo.InsertaAjuste(Today.Date, user, CInt(DGV_Fact.Rows(cont).Cells(6).Value), _
                                        Format(CDbl(DGV_Fact.Rows(cont).Cells(5).Value) * -1, "#,##0.00"), "Ajuste Automático")
                                    End If

                                End If

                            Next

                        Next

                        '-----------------------------------------------------------------------------------------------------------------


                    End If
                End If
            ElseIf (varBoton = 3) Then
                Me.DGV_Recibos.Rows.Clear()
            ElseIf (varBoton = 5) Then

                If llenos() Then

                    MsgBox("Debe ingresar todos los datos requeridos (*)")
                    deny = True

                Else

                    If Me.tb_banco.Text = "" Then

                        Dim cont As Integer = 0

                        While cont < tb_banco.Items.Count
                            If tb_banco.Items(cont).col1.ToString.ToUpper = "SIN INFORMACION" Then
                                tb_banco.SelectedIndex = cont
                                cont = tb_banco.Items.Count + 1
                            Else
                                cont = cont + 1
                            End If
                        End While

                    End If

                    If Me.tb_bancodep.Text = "" Then

                        Dim cont As Integer = 0

                        While cont < tb_bancodep.Items.Count
                            If tb_bancodep.Items(cont).col1.ToString.ToUpper = "SIN INFORMACION" Then
                                tb_bancodep.SelectedIndex = cont
                                cont = tb_bancodep.Items.Count + 1
                            Else
                                cont = cont + 1
                            End If
                        End While

                    End If

                    For cont As Integer = 0 To indexRec
                        DatosRecibo.Modifica_Factura_Recibo(CInt(DGV_Recibos.Rows(cont).Cells(7).Value), numRecibo, DGV_Recibos.Rows(cont).Cells(5).Value, DGV_Recibos.Rows(cont).Cells(9).Value)
                    Next

                    If sw_ch <> ch_dev.Checked And ch_dev.Checked = False And otra = False Then
                        DatosRecibo.modifica_recibo(CInt(Me.l_recibo.Text), Me.tb_control.Text, Me.tb_monto.Text, Me.tb_fecha.Value, Me.tb_deposito.Text, Me.tb_banco.SelectedItem.Col2, Me.tb_cheque.Text, Me.tb_efectivo.Text, Me.tb_bancodep.SelectedItem.Col2, Me.tb_fechaD.Value, Me.tb_observacion.Text, Me.ch_dev.Checked, CDbl(Me.tb_retencion.Text), Me.tb_fechaCD.Value, "", Me.ch_pd.Checked, Me.tb_compRet.Text, 1, chk_comp.Checked)
                    Else
                        DatosRecibo.modifica_recibo(CInt(Me.l_recibo.Text), Me.tb_control.Text, Me.tb_monto.Text, Me.tb_fecha.Value, Me.tb_deposito.Text, Me.tb_banco.SelectedItem.Col2, Me.tb_cheque.Text, Me.tb_efectivo.Text, Me.tb_bancodep.SelectedItem.Col2, Me.tb_fechaD.Value, Me.tb_observacion.Text, Me.ch_dev.Checked, CDbl(Me.tb_retencion.Text), Me.tb_fechaCD.Value, Me.tb_dep_chd.Text, Me.ch_pd.Checked, Me.tb_compRet.Text, 1, chk_comp.Checked)
                    End If

                    'Insertar recibo nuevo con el monto del cheque dev con dev = 1

                    Dim ret As Double
                    If Me.tb_retencion.Visible = False Then
                        ret = 0
                    Else
                        ret = Me.tb_retencion.Text
                    End If
                    If Me.tb_banco.Text = "" Then
                        Me.tb_banco.Text = "Sin Informacion"
                    End If
                    If Me.tb_bancodep.Text = "" Then
                        Me.tb_bancodep.SelectedIndex = 0
                    End If

                    If tb_control.Text.ToString.Trim <> "" Then
                        DatosRecibo.inserta_recibo("0" & Me.tb_control.Text, MontoCHD, Me.tb_fecha.Value, Me.tb_deposito.Text & "-1", Me.tb_banco.SelectedItem.col2, Me.tb_cheque.Text, "0", Me.tb_bancodep.SelectedItem.col2, Me.tb_fechaD.Value, "Cheque Devuelto", 1, ret, FechaMov, 0, numDeposito, Me.tb_compRet.Text, 1, chk_comp.Checked, tb_usuario.Text)
                    Else
                        DatosRecibo.inserta_recibo("S/N", MontoCHD, Me.tb_fecha.Value, Me.tb_deposito.Text & "-1", Me.tb_banco.SelectedItem.col2, Me.tb_cheque.Text, "0", Me.tb_bancodep.SelectedItem.col2, Me.tb_fechaD.Value, "Cheque Devuelto", 1, ret, FechaMov, 0, numDeposito, Me.tb_compRet.Text, 1, chk_comp.Checked, tb_usuario.Text)
                    End If


                    Dim cod As Integer = DatosRecibo.consulta_UltimoCodRecibo()

                    Dim row As Integer = 0


                    For cont As Integer = 0 To indexRec
                        DatosRecibo.inserta_Factura_Recibo(CInt(DGV_Recibos.Rows(cont).Cells(7).Value), cod, 0, 0)
                    Next

                    MsgBox("Cheque devuelto procesado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
                    Datos.Inserta_Actividad("Modificó el recibo nro. " + tb_control.Text + " del cliente (" + l_codCliente.Text + ") " + l_razon.Text)
                    otra = True

                End If

            End If
            If deny = False Then
                Me.tb_bancodep.Enabled = False
                Me.tb_banco.Enabled = False
                Me.tb_monto.ReadOnly = True
                Me.tb_cheque.ReadOnly = True
                Me.tb_fecha.Enabled = False
                Me.tb_efectivo.Enabled = False
                Me.tb_control.ReadOnly = True
                Me.tb_usuario.Clear()
                Me.tb_deposito.ReadOnly = True
                Me.tb_compRet.ReadOnly = True
                Me.DGV_Fact.Enabled = True
                Me.DGV_Recibos.Enabled = True
                tb_compRet.ReadOnly = True
                Me.tb_observacion.Enabled = False
                Dim cant As Integer = 0
                Me.tb_fechaD.Enabled = False
                Me.chk_comp.Enabled = False
                Me.DGV_R.Enabled = True
                Me.DGV_Clientes.Enabled = True
                DatosBanco.consulta_bancos(Me.tb_banco)
                DatosBanco.consulta_bancosCuentas(Me.tb_bancodep)
                Me.tb_buscarcodigo.Enabled = True
                Me.ToolBar1.Enabled = True
                Me.DomainUpDown1.Enabled = True
                Me.bt_aceptar.Visible = False
                Me.bt_cancelar.Visible = False
                Me.ch_dev.Enabled = False
                Me.tb_retencion.ReadOnly = True
                If varBoton = 1 Then
                    Me.DGV_R.Columns(1).Visible = True
                    Me.DGV_R.Columns(3).Width = 260
                End If
                If otra = True Then

                    If Me.ch_dev.Checked Then
                        Frm_Consulta_Movimientos.filaBorrar(numDeposito, Me.dgv_mov, Me.dgv_f, line, Me.cb, Me.td, Me.th, tip, Me.dgv_chpd, tb_fechaCD.Value)
                    Else
                        Frm_Consulta_Movimientos.filaBorrar(numDeposito, Me.dgv_mov, Me.dgv_f, line, Me.cb, Me.td, Me.th, tip, Me.dgv_chpd, tb_fechaD.Value)
                    End If

                    Frm_Consulta_Movimientos.dgv_mov_selectionchanged()
                    Me.Close()
                Else

                    If varBoton = 1 Then
                        Me.tb_buscarcodigo.Text = ""
                        DGV_Clientes.Visible = False
                        DGV_Clientes.SendToBack()
                        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaRecibos2' table. You can move, or remove it, as needed.
                        Me.Sp_consultaRecibos2TableAdapter.Fill(Me.MELDataSet.sp_consultaRecibos2)
                        CrearWhere()
                        DGV_R.ClearSelection()
                        varBoton = 0
                        Dim inn As Integer = buscaindex(CInt(Me.l_recibo.Text))
                        Me.DGV_R.FirstDisplayedScrollingRowIndex = inn
                        Me.DGV_R.Rows(inn).Selected = True
                        Me.DGV_R_Selectedindex()
                    ElseIf varBoton = 2 Then
                        varBoton = 0
                        Dim index As Integer = Me.DGV_R.SelectedRows(0).Index

                        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaRecibos2' table. You can move, or remove it, as needed.
                        Me.Sp_consultaRecibos2TableAdapter.Fill(Me.MELDataSet.sp_consultaRecibos2)
                        CrearWhere()

                        'Dim inn As Integer = buscaindex(CInt(Me.l_recibo.Text))
                        'Me.DGV_R.FirstDisplayedScrollingRowIndex = inn

                        SpconsultaRecibos2BindingSource.Filter = "CodigoRecibo = " & l_recibo.Text

                        If DGV_R.RowCount > 0 Then
                            Me.DGV_R.Rows(0).Cells(1).Selected = True
                            Me.DGV_R_Selectedindex()
                        End If

                    End If

                    Me.DomainUpDown1.Items.Clear()
                    Me.DomainUpDown1.Items.Add("Razón Social")
                    Me.DomainUpDown1.Items.Add("N°Recibo")
                    Me.DomainUpDown1.Items.Add("N°Factura")
                    Me.DomainUpDown1.Items.Add("N°Depósito")
                    Me.DomainUpDown1.Items.Add("Monto")
                    Me.DomainUpDown1.SelectedIndex = 0
                    Me.Label12.Visible = True
                    Me.ch_dev.Visible = True
                    Me.tb_retencion.ReadOnly = True
                End If
            End If
        Else
            MsgBox("Por favor seleccione la(s) factura(s) asociadas al recibo.")
        End If
    End Sub
    Public Function buscaindex(ByVal cod As Integer) As Integer
        Dim i As Integer = 0
        While i < Me.DGV_R.Rows.Count
            If Me.DGV_R.Rows(i).Cells(0).Value = cod Then
                Return i
            End If
            i = i + 1
        End While
        Return 0
    End Function
    Public Sub limpia()
        tb_usuario.Clear()
        Me.chk_comp.Checked = False
        Me.tb_monto.Clear()
        Me.tb_cheque.Clear()
        Me.tb_fecha.ResetText()
        Me.tb_fechaD.ResetText()
        Me.tb_compRet.Clear()
        Me.tb_efectivo.Clear()
        Me.tb_control.Clear()
        Me.tb_deposito.Clear()
        ch_pd.Checked = False
        ch_contEspecial.Checked = False

        l_codCliente.Text = ""
        l_razon.Text = ""

        Me.DGV_Recibos.Rows.Clear()
        Me.DGV_Fact.Rows.Clear()

        If Not varBoton = 2 Then
            Me.tb_banco.Items.Clear()
            Me.tb_banco.ResetText()
            Me.tb_bancodep.Items.Clear()
            Me.tb_bancodep.ResetText()
        End If
    End Sub

    Public Sub dgv_R_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Clientes.CellDoubleClick
        If varBoton = 1 Then
            Me.DGV_R.Enabled = False
            Me.DGV_Clientes.Enabled = False
            Me.notas.Visible = False
            Me.tb_buscarcodigo.Enabled = False
            Me.ToolBar1.Enabled = False
            Me.DomainUpDown1.Enabled = False
            Me.tb_monto.ReadOnly = True
            Me.tb_cheque.ReadOnly = True
            Me.tb_fecha.Enabled = True
            Me.tb_efectivo.ReadOnly = False
            Me.tb_control.ReadOnly = False
            Me.tb_deposito.ReadOnly = True
            Me.tb_banco.Enabled = False
            Me.bt_aceptar.Visible = False
            Me.bt_procesar.Visible = True
            Me.bt_cancelar.Visible = True
            Me.tb_observacion.Enabled = True
            Me.DGV_Recibos.Rows.Clear()
            Me.tb_fechaD.Enabled = True
            Me.tb_bancodep.Enabled = True
            Me.tb_observacion.Enabled = True
            Me.DGV_Fact.Enabled = False

            If Me.ch_contEspecial.Checked = True Then

                Me.chk_comp.Checked = False
                Me.chk_comp.Enabled = True

                Me.tb_retencion.ReadOnly = False
                Me.tb_retencion.Enabled = True

                If My.Settings.Empresa <> 5 Then
                    tb_retencion.Text = "75"
                Else
                    tb_retencion.Text = "100"
                End If

            End If

            Me.ch_pd.Enabled = True
            Me.tb_control.Focus()
        End If
    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged
        If Me.DGV_R.Enabled = True Then
            Dim s1 As String
            If varBoton = 0 Then
                CrearWhere()
                limpia()
                DGV_Fact.Rows.Clear()
                DGV_Recibos.Rows.Clear()
            Else
                If choice = 0 Then
                    s1 = "%" + Me.tb_buscarcodigo.Text + "%"
                    DatosRecibo.lv_Cliente(Me.DGV_Clientes, s1, 0, 0)
                    DGV_R.ClearSelection()
                    DGV_Fact.Rows.Clear()
                    DGV_Recibos.Rows.Clear()
                ElseIf choice = 1 Then
                    s1 = "%" + Me.tb_buscarcodigo.Text + "%"
                    DatosRecibo.lv_Cliente(Me.DGV_Clientes, s1, 1, 0)
                    DGV_R.ClearSelection()
                    DGV_Fact.Rows.Clear()
                    DGV_Recibos.Rows.Clear()
                ElseIf choice = 2 Then
                    s1 = "%" + Me.tb_buscarcodigo.Text + "%"
                    DatosRecibo.lv_Cliente(Me.DGV_Clientes, s1, 2, 0)
                    DGV_R.ClearSelection()
                    DGV_Fact.Rows.Clear()
                    DGV_Recibos.Rows.Clear()
                End If
                DGV_Clientes.ClearSelection()
                l_recibos.Text = Me.DGV_Clientes.Rows.Count
            End If

        End If
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged

        choice = Me.DomainUpDown1.SelectedIndex
        Me.tb_buscarcodigo.Text = ""
        Me.tb_buscarcodigo.Focus()
    End Sub


    '------------------------- VALIDACIONES

    Private Sub tb_telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_deposito.KeyPress, tb_cheque.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "." Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números"
        End If
    End Sub

    Private Sub tb_RET_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_retencion.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            muestra_label(sender, 1)
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números"
        End If
    End Sub


    Private Sub tb_numeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_monto.KeyPress, tb_efectivo.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then
            If (Me.tb_monto.Text.Contains(",") And e.KeyChar = ",") Or (Me.tb_efectivo.Text.Contains(",") And e.KeyChar = ",") Or (Me.tb_monto.Text.Contains(",") And e.KeyChar = ".") Or (Me.tb_efectivo.Text.Contains(",") And e.KeyChar = ".") Then
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "       Solo una coma."
            Else
                If e.KeyChar = "." Then
                    e.KeyChar = ","
                End If
                e.Handled = False
                muestra_label(sender, 1)
            End If
        Else
            e.Handled = True
            muestra_label(sender, 0)
            Me.Label22.Text = "      Ingrese sólo números"
        End If
    End Sub

    Private Sub tb_control_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_control.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.tb_fecha.Focus()
        Else
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "S" Or e.KeyChar = "/" Or e.KeyChar = "N" Or e.KeyChar = "C" Or e.KeyChar = "D" Then
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                    muestra_label(sender, 1)
                Else
                    If (Me.tb_control.Text.Contains("S") Or Me.tb_control.Text.Contains("/") Or Me.tb_control.Text.Contains("N")) And Char.IsNumber(e.KeyChar) Then
                        e.Handled = True
                        muestra_label(sender, 0)
                        Me.Label22.Text = "       Sólo permite S/N, CD ó numero."
                    Else
                        e.Handled = False
                        muestra_label(sender, 1)
                    End If
                End If
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Ingrese sólo números ó S/N"
            End If
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

    Private Sub tb_rif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_deposito.LostFocus, tb_cheque.LostFocus
        muestra_label(sender, 1)
    End Sub

    Public Sub nuevo()
        swX = True
    End Sub

    Public Sub DGV_Fact_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Fact.CellDoubleClick
        If e.ColumnIndex = 0 And varBoton = 0 Then
            Dim F13 As New Frm_Facturas_Ventas
            F13.cualVentana(2, Me.DGV_Fact.SelectedCells(6).Value, Me.DGV_Fact.SelectedCells(0).Value, CInt(Me.DGV_R.SelectedRows(0).Cells(2).Value), Me.DGV_R.SelectedRows(0).Cells(3).Value)
            F13.Show()
            F13.SpConsultaClienteFacturaBindingSource.Filter = "Control = '" & DGV_Fact.SelectedRows(0).Cells(0).Value.ToString & "'"
            F13.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
            F13.DGV_TodasLasFacturas.Select()
            F13.DGV_TodasLasFacturas_CellClick()
        Else
            If varBoton = 1 Then
                If Me.l_monto.Text = "" Then
                    MsgBox("Para asociar una factura primero debes insertar un monto de cheque o efectivo")
                Else

                    If Not CDbl(Me.l_monto.Text) > 0 Then
                        MsgBox("Para asociar una factura primero debes insertar un monto de cheque o efectivo")
                    Else

                        Dim checarow As Integer = fila_dgvRecibos(Me.DGV_Fact.SelectedRows(0).Cells(6).Value)

                        If checarow = -1 Or devolviendo = True Or ch_pd.Checked = False Then

                            If CDbl(Me.l_saldo.Text) > 0 Or Me.DGV_Fact.SelectedRows(0).Cells(5).Value < 0 Then

                                Dim iva2 As Double = Me.DGV_Fact.SelectedRows(0).Cells(7).Value / 100
                                Dim base As Double = 0
                                Dim sinR As Double = 0

                                If Me.ch_contEspecial.Checked = False Or Me.DGV_Fact.SelectedRows(0).Cells(5).Value < 0 Then
                                    base = Me.DGV_Fact.SelectedRows(0).Cells(5).Value
                                    sinR = Math.Round(base, 2)
                                Else
                                    base = Me.DGV_Fact.SelectedRows(0).Cells(5).Value / (1 + iva2)
                                    sinR = Math.Round(base + (base * (1 - (CDbl(Me.tb_retencion.Text) / 100)) * iva2), 2)
                                End If

                                If CDbl(Me.l_saldo.Text) >= sinR Then

                                    Dim fila As Integer = fila_dgvRecibos(Me.DGV_Fact.SelectedRows(0).Cells(6).Value)

                                    If fila = -1 Then

                                        'Voy por aquí
                                        Me.DGV_Recibos.Rows.Add(ObtenerValoresFila(Me.DGV_Fact.SelectedRows(0), Me.DGV_Fact.SelectedRows(0).Cells(5).Value, Me.ch_contEspecial.Checked, False))

                                        If Me.DGV_Recibos.Rows(Me.DGV_Recibos.Rows.Count - 1).Cells(5).Value < 0 Then
                                            Me.DGV_Recibos.Rows(Me.DGV_Recibos.Rows.Count - 1).Cells(5).Style.ForeColor = Color.Blue
                                        End If

                                    Else

                                        Me.DGV_Recibos.Rows(fila).Cells(5).Value = Me.DGV_Recibos.Rows(fila).Cells(5).Value + Me.DGV_Fact.SelectedRows(0).Cells(5).Value
                                        Dim valor As Double
                                        valor = CDbl(Me.l_saldo.Text) / (1 + (iva2 * (1 - (CDbl(Me.tb_retencion.Text) / 100))))
                                        Me.DGV_Recibos.Rows(fila).Cells(9).Value = Math.Round((Math.Round(valor + valor * iva2, 2)) / (1 + (Me.DGV_Fact.SelectedRows(0).Cells(7).Value / 100)) * (CDbl(Me.tb_retencion.Text) / 100) * (Me.DGV_Fact.SelectedRows(0).Cells(7).Value / 100), 2)

                                    End If

                                    If Not Me.ch_pd.Checked Then
                                        Me.DGV_Fact.Rows.RemoveAt(Me.DGV_Fact.SelectedRows(0).Index)
                                    End If

                                Else

                                    Dim valor As Double
                                    valor = CDbl(Me.l_saldo.Text) / (1 + (iva2 * (1 - (CDbl(Me.tb_retencion.Text) / 100))))

                                    Dim fila As Integer = fila_dgvRecibos(Me.DGV_Fact.SelectedRows(0).Cells(6).Value)

                                    If fila = -1 Then

                                        Me.DGV_Recibos.Rows.Add(ObtenerValoresFila(Me.DGV_Fact.SelectedRows(0), (Math.Round(valor + valor * iva2, 2)), Me.ch_contEspecial.Checked, True))
                                        Dim row As Integer = Me.DGV_Recibos.Rows.Count - 1
                                        Dim iva As Double = (Me.DGV_Recibos.Rows(row).Cells(10).Value / 100)
                                        Dim ret As Double = Me.DGV_Recibos.Rows(row).Cells(9).Value
                                        Dim dep As Double = Me.DGV_Recibos.Rows(row).Cells(5).Value
                                        Me.DGV_Fact.SelectedRows(0).Cells(5).Value = Me.DGV_Fact.SelectedRows(0).Cells(5).Value - (dep + ret)

                                    Else

                                        Me.DGV_Recibos.Rows(fila).Cells(5).Value = Me.DGV_Recibos.Rows(fila).Cells(5).Value + CDbl(Me.l_saldo.Text)
                                        Me.DGV_Recibos.Rows(fila).Cells(9).Value = Math.Round((Math.Round(valor + valor * iva2, 2)) / (1 + (Me.DGV_Fact.SelectedRows(0).Cells(7).Value / 100)) * (CDbl(Me.tb_retencion.Text) / 100) * (Me.DGV_Fact.SelectedRows(0).Cells(7).Value / 100), 2)
                                        Me.DGV_Fact.SelectedRows(0).Cells(5).Value = Me.DGV_Fact.SelectedRows(0).Cells(5).Value - CDbl(Me.l_saldo.Text)

                                    End If

                                    Me.lb_deuda.Text = Me.total_dgv_fact()
                                    Me.l_saldo.Text = 0

                                End If

                            Else
                                MsgBox("Ya no puede seguir asociando facturas (Saldo Insuficiente)")
                            End If
                        Else
                            MsgBox("Ya la factura seleccionada está asociada al cheque posdatado.")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub tb_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_monto.TextChanged
        If Not varBoton = 0 Then
            If Not Me.tb_efectivo.Text = "" And Not Me.tb_monto.Text = "" Then
                Me.l_monto.Text = FormatNumber(CDbl(Me.tb_monto.Text) + CDbl(Me.tb_efectivo.Text), 2)
            ElseIf Me.tb_efectivo.Text = "" And Me.tb_monto.Text = "" Then
                Me.l_monto.Text = 0
            ElseIf Me.tb_monto.Text = "" Then
                Me.l_monto.Text = FormatNumber(CDbl(Me.tb_efectivo.Text), 2)
                Me.l_saldo.Text = Me.tb_efectivo.Text
            Else
                Me.l_monto.Text = FormatNumber(CDbl(Me.tb_monto.Text), 2)
            End If
            If varBoton = 1 Then
                Me.l_saldo.Text = Me.l_monto.Text
            ElseIf varBoton = 2 Then
                Dim Tot As Double
                Dim row As Integer = 0
                While row < Me.DGV_Recibos.Rows.Count
                    Tot = Tot + CDbl(Me.DGV_Recibos(5, row).Value)
                    row = row + 1
                End While
                Me.l_saldo.Text = FormatNumber(CDbl(Me.l_monto.Text) - Math.Round(Tot, 2), 2)
            End If
        Else
            If Me.tb_monto.Text = "" Then
                Me.l_monto.Text = Me.tb_efectivo.Text
            ElseIf Me.tb_efectivo.Text = "" Then
                Me.l_monto.Text = Me.tb_monto.Text
            Else
                Me.l_monto.Text = FormatNumber(CDbl(Me.tb_monto.Text) + CDbl(Me.tb_efectivo.Text), 2)
            End If
        End If
    End Sub

    Private Sub tb_efectivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_efectivo.TextChanged
        If Not varBoton = 0 Then
            If Not Me.tb_monto.Text = "" And Not (Me.tb_efectivo.Text = "" Or Not IsNumeric(Me.tb_efectivo.Text)) Then
                Me.l_monto.Text = FormatNumber(CDbl(Me.tb_monto.Text) + CDbl(Me.tb_efectivo.Text), 2)
            ElseIf Me.tb_efectivo.Text = "" And Me.tb_monto.Text = "" Then
                Me.l_monto.Text = 0
            ElseIf Me.tb_efectivo.Text = "" Then
                Me.l_monto.Text = FormatNumber(CDbl(Me.tb_monto.Text), 2)
                Me.l_saldo.Text = Me.l_monto.Text
            Else
                If IsNumeric(Me.tb_efectivo.Text) Then
                    Me.l_monto.Text = FormatNumber(CDbl(Me.tb_efectivo.Text), 2)
                End If
            End If
            If varBoton = 1 Then
                Me.l_saldo.Text = Me.l_monto.Text
            ElseIf varBoton = 2 Then
                Dim Tot As Double
                Dim row As Integer = 0
                While row < Me.DGV_Recibos.Rows.Count
                    Tot = Tot + CDbl(Me.DGV_Recibos(5, row).Value)
                    row = row + 1
                End While
                Me.l_saldo.Text = CDbl(Me.l_monto.Text) - Math.Round(Tot, 2)
            End If
        Else
            If Me.tb_monto.Text = "" Then
                Me.l_monto.Text = Me.tb_efectivo.Text
            ElseIf Me.tb_efectivo.Text = "" Then
                Me.l_monto.Text = Me.tb_monto.Text
            Else
                Me.l_monto.Text = CDbl(Me.tb_monto.Text) + CDbl(Me.tb_efectivo.Text)
            End If
        End If
    End Sub

    Function ObtenerValoresFila(ByRef fila As DataGridViewRow, ByVal fac As Double, ByVal contE As Boolean, ByVal ultimo As Boolean) As Object()

        Dim Contenido(Me.DGV_Fact.ColumnCount + 2) As Object

        Contenido(0) = fila.Cells(0).Value
        Contenido(1) = Me.l_recibo.Text
        Contenido(2) = fila.Cells(1).Value

        If fila.Cells(5).Value < 0 Then
            Contenido(3) = ""
        Else
            Contenido(3) = Me.tb_fechaD.Value.Date
            Contenido(6) = DateDiff(DateInterval.Day, fila.Cells(1).Value, Me.tb_fechaD.Value)
        End If

        Contenido(4) = fila.Cells(4).Value
        Contenido(7) = fila.Cells(6).Value
        Contenido(8) = fila.Cells(8).Value

        If contE = True Then

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 5 Or My.Settings.Empresa = 7 Then

                Contenido(9) = Math.Round(fac / (1 + (fila.Cells(7).Value / 100)) * (CDbl(Me.tb_retencion.Text) / 100) * (fila.Cells(7).Value / 100), 2)
                Contenido(5) = Math.Round(fac - Contenido(9), 2)

            Else

                Contenido(9) = Math.Round(fac / (1 + (fila.Cells(7).Value / 100)) * (CDbl(Me.tb_retencion.Text) / 100) * (fila.Cells(7).Value / 100), 2)
                Contenido(5) = Math.Round(fac - Contenido(9), 2)

            End If


        Else

            If ch_pd.Checked Then
                Contenido(5) = 0
            Else
                Contenido(5) = fac
            End If

            Contenido(9) = 0

        End If

        Contenido(10) = fila.Cells(7).Value

        Return Contenido

    End Function
    Function ObtenerValoresFilaRecibo(ByVal fila As DataGridViewRow) As Object()
        Dim Contenido(Me.DGV_Fact.ColumnCount) As Object
        Contenido(0) = fila.Cells(0).Value
        Contenido(1) = fila.Cells(2).Value
        Contenido(2) = DateAdd(DateInterval.Day, 15, fila.Cells(2).Value)
        Contenido(3) = DateDiff(DateInterval.Day, fila.Cells(2).Value, Today())
        Contenido(4) = CDbl(fila.Cells(4).Value)
        Contenido(5) = CDbl(fila.Cells(5).Value) + CDbl(fila.Cells(9).Value)
        Contenido(6) = fila.Cells(7).Value
        Contenido(7) = CDbl(fila.Cells(10).Value)
        Contenido(8) = fila.Cells(8).Value
        Return Contenido
    End Function

    Private Sub DGV_Recibos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Recibos.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Try
                Dim F As New Frm_Facturas_Ventas
                F.cualVentana(2, Me.DGV_Recibos.SelectedCells(7).Value, Me.DGV_R.SelectedCells(0).Value, CInt(Me.DGV_R.SelectedRows(0).Cells(2).Value), Me.DGV_R.SelectedRows(0).Cells(3).Value)
                F.Show()
                F.SpConsultaClienteFacturaBindingSource.Filter = "Control = '" & DGV_Recibos.SelectedRows(0).Cells(0).Value.ToString & "'"
                F.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
                F.DGV_TodasLasFacturas.Select()
                F.DGV_TodasLasFacturas_CellClick()
            Catch ex As Exception
                MsgBox("Error consultando factura", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub bt_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_procesar.Click
        Dim deny As Boolean = False
        cli = False
        If (varBoton = 1) Then
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else
                Try
                    If tb_retencion.Text = "" And tb_retencion.Visible = True Then
                        tb_retencion.Text = 0
                        If CDbl(tb_retencion.Text) < 0 Or CDbl(tb_retencion.Text) > 100 Then
                            MsgBox("La retención es un porcentaje, debe estar entre 0 y 100%", MsgBoxStyle.Exclamation, "SINPRO")
                            tb_retencion.Focus()
                            deny = True
                        End If
                    ElseIf tb_retencion.Visible = True Then
                        If CDbl(tb_retencion.Text) < 0 Or CDbl(tb_retencion.Text) > 100 Then
                            MsgBox("La retención es un porcentaje, debe estar entre 0 y 100%", MsgBoxStyle.Exclamation, "SINPRO")
                            tb_retencion.Focus()
                            deny = True
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Debe ingresar sólo números en el campo retención", MsgBoxStyle.Exclamation, "SINPRO")
                    tb_retencion.Clear()
                    tb_retencion.Focus()
                    deny = True
                End Try
            End If
        ElseIf (varBoton = 2) Then
            If llenos() Then
                MsgBox("Debe ingresar todos los datos requeridos (*)")
                deny = True
            Else
                Try
                    If tb_retencion.Text = "" And tb_retencion.Visible = True Then
                        tb_retencion.Text = 0
                        If CDbl(tb_retencion.Text) < 0 Or CDbl(tb_retencion.Text) > 100 Then
                            MsgBox("La retención es un porcentaje, debe estar entre 0 y 100%", MsgBoxStyle.Exclamation, "SINPRO")
                            tb_retencion.Focus()
                            deny = True
                        End If
                    ElseIf tb_retencion.Visible = True Then
                        If CDbl(tb_retencion.Text) < 0 Or CDbl(tb_retencion.Text) > 100 Then
                            MsgBox("La retención es un porcentaje, debe estar entre 0 y 100%", MsgBoxStyle.Exclamation, "SINPRO")
                            tb_retencion.Focus()
                            deny = True
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Debe ingresar sólo números en el campo retención", MsgBoxStyle.Exclamation, "SINPRO")
                    tb_retencion.Clear()
                    tb_retencion.Focus()
                    deny = True
                End Try
            End If
        End If

        If deny = False Then
            Me.tb_monto.ReadOnly = True
            Me.tb_efectivo.ReadOnly = True
            Me.DGV_Fact.Enabled = True
            Me.DGV_Recibos.Enabled = True
            tb_bancodep.Enabled = True
            Me.bt_procesar.Visible = False
            Me.bt_aceptar.Visible = True
            Me.tb_retencion.Enabled = False
            DGV_R.ClearSelection()
            Me.ch_pd.Enabled = False
        End If
    End Sub
    Public Function fila_dgvRecibos(ByVal cod As Integer) As Integer
        Dim fila As Integer = -1
        Dim i As Integer = 0
        While i < Me.DGV_Recibos.Rows.Count
            If Me.DGV_Recibos.Rows(i).Cells(7).Value = cod Then
                fila = i
                Return fila
            End If
            i = i + 1
        End While
        Return fila
    End Function
    Public Function fila_dgvFacturas(ByVal cod As Integer) As Integer
        Dim fila As Integer = -1
        Dim i As Integer = 0
        While i < Me.DGV_Fact.Rows.Count
            If Me.DGV_Fact.Rows(i).Cells(0).Value = cod Then
                fila = i
                Return fila
            End If
            i = i + 1
        End While
        Return fila
    End Function

    Public Function total_dgv_recibos() As Double
        Dim total As Double = 0.0
        Dim i As Integer
        While i < Me.DGV_Recibos.Rows.Count
            total = total + Me.DGV_Recibos.Rows(i).Cells(5).Value
            i = i + 1
        End While
        Return Math.Round(total, 2)
    End Function

    Private Sub ch_dev_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_dev.CheckedChanged
        If varBoton = 1 Or varBoton = 2 Then
            If Me.ch_dev.Checked = True Then
                Me.tb_fechaCD.Visible = True
                Dim x As Integer = 0
                Dim y As Integer = 0
                Dim sw As Boolean = False
                While x < Me.DGV_Recibos.Rows.Count
                    sw = False
                    y = 0
                    While y < Me.DGV_Fact.Rows.Count
                        If Me.DGV_Recibos.Rows(x).Cells(0).Value = Me.DGV_Fact.Rows(y).Cells(0).Value Then
                            sw = True
                            Me.DGV_Fact.Rows(y).Cells(5).Value = CDbl(Me.DGV_Fact.Rows(y).Cells(5).Value + Me.DGV_Recibos.Rows(x).Cells(5).Value + Me.DGV_Recibos.Rows(x).Cells(8).Value + Me.DGV_Recibos.Rows(x).Cells(9).Value)
                            Me.lb_deuda.Text = Me.total_dgv_fact()
                            Me.DGV_Recibos.Rows(x).Cells(5).Value = 0
                            Me.DGV_Recibos.Rows(x).Cells(9).Value = 0
                        End If
                        y = y + 1
                    End While
                    If sw = False Then
                        Me.DGV_Fact.Rows.Add(ObtenerValoresFilaRecibo(Me.DGV_Recibos.Rows(x)))
                        Me.DGV_Recibos.Rows(x).Cells(5).Value = 0
                        Me.DGV_Recibos.Rows(x).Cells(9).Value = 0
                    End If
                    x = x + 1
                End While
            Else
                If checadgv_recibos() Then
                    Me.tb_fechaCD.Visible = False
                    Me.l_saldo.Text = Me.l_monto.Text
                    Dim i As Integer = 0
                    While i < DGV_Recibos.Rows.Count
                        Dim fila As Integer
                        fila = fila_dgvFacturas(DGV_Recibos.Rows(0).Cells(0).Value)
                        If fila = -1 Then
                        Else
                            DGV_Fact.Rows(fila).Selected = True
                            varBoton = 1
                            devolviendo = True
                            DGV_Recibos.Rows.RemoveAt(0)
                            DGV_Fact_CellDoubleClick(DGV_Fact, New DataGridViewCellEventArgs(0, fila))
                        End If
                        i = i + 1
                    End While
                    varBoton = 2
                Else
                    varBoton = 5
                    Me.ch_dev.Checked = True
                    MsgBox("No puede devolver un cheque de facturas ya canceladas en otro recibo")
                    varBoton = 2
                End If

            End If
        ElseIf varBoton = 0 Then
            If Me.ch_dev.Checked = True Then
                Me.tb_fechaCD.Visible = True
                Me.tb_fechaCD.Enabled = False
                Me.lb_depdev.Visible = True
                Me.tb_dep_chd.Visible = True
            Else
                Me.tb_fechaCD.Visible = False
                Me.lb_depdev.Visible = False
                Me.tb_dep_chd.Visible = False
            End If
        End If
        devolviendo = False

    End Sub
    Function checadgv_recibos() As Boolean
        Dim sw As Boolean = False
        Dim i As Integer = 0
        While i < DGV_Recibos.Rows.Count
            Dim fila As Integer = -1
            fila = fila_dgvFacturas(DGV_Recibos.Rows(0).Cells(0).Value)
            If fila = -1 Then
                sw = True
                i = DGV_Recibos.Rows.Count
            Else
            End If
            i = i + 1
        End While
        Return sw
    End Function
    Function total_dgv_fact() As Double
        Dim i As Integer = 0
        Dim acum As Double = 0
        While i < Me.DGV_Fact.Rows.Count
            acum = acum + Me.DGV_Fact.Rows(i).Cells(5).Value
            i = i + 1
        End While
        Return FormatNumber(acum, 2)
    End Function

    Private Sub DGV_Fact_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DGV_Fact.RowsAdded
        Me.lb_deuda.Text = Me.total_dgv_fact()
    End Sub

    Private Sub DGV_Fact_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGV_Fact.RowsRemoved
        Me.lb_deuda.Text = Me.total_dgv_fact()
    End Sub

    Private Sub DGV_R_selectedindexchange(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_R.KeyUp, DGV_R.KeyDown
        Me.DGV_R_Selectedindex()
    End Sub
    Private Sub DGV_R_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_R.CellClick, DGV_Clientes.CellClick
        Me.DGV_R_Selectedindex()
    End Sub

    Public Sub DGV_R_Selectedindex()

        If DGV_Clientes.Visible = False Then

            If Me.DGV_R.SelectedRows.Count > 0 Then

                Dim cod As Integer = 0
                cod = CInt(Me.DGV_R.SelectedRows(0).Cells(0).Value)

                If Not varBoton = 1 Then

                    Dim bancodep As String = ""
                    DatosBanco.consulta_bancos(Me.tb_banco)
                    DatosBanco.consulta_bancosCuentas(Me.tb_bancodep)
                    DatosRecibo.consulta_Recibo(cod, Me.tb_control.Text, Me.tb_monto.Text, Me.tb_fecha.Value, Me.tb_fechaD.Value, Me.tb_banco, Me.tb_cheque.Text, Me.tb_deposito.Text, Me.tb_observacion.Text, Me.tb_efectivo.Text, bancodep, Me.ch_dev, Me.tb_retencion.Text, Me.tb_fechaCD.Value, Me.ch_pd, Me.tb_dep_chd.Text, tb_bancodep, tb_compRet.Text, chk_comp.Checked, tb_usuario.Text)
                    sw_ch = Me.ch_dev.Checked
                    Dim cont As Integer = 0
                    DatosRecibo.consulta_facturas(Me.DGV_Recibos, cod, Me.tb_fechaD.Value, Me.DGV_R.SelectedRows(0).Cells(2).Value)
                    Me.l_recibo.Text = Me.DGV_R.SelectedRows(0).Cells(0).Value
                    Me.l_codCliente.Text = CInt(Me.DGV_R.SelectedRows(0).Cells(2).Value)
                    Me.l_razon.Text = Me.DGV_R.SelectedRows(0).Cells(3).Value
                    Me.ch_contEspecial.Checked = Me.DGV_R.SelectedRows(0).Cells(4).Value
                    DatosRecibo.consulta_cliente_R(CInt(Me.DGV_R.SelectedRows(0).Cells(2).Value), Me.DGV_Fact, Me.lb_deuda, Me.l_saldo)

                Else

                    DatosRecibo.consulta_cliente_R(CInt(Me.DGV_R.SelectedRows(0).Cells(2).Value), Me.DGV_Fact, Me.lb_deuda, Me.l_saldo)
                    Me.l_codCliente.Text = CInt(Me.DGV_R.SelectedRows(0).Cells(2).Value)
                    Me.l_razon.Text = Me.DGV_R.SelectedRows(0).Cells(3).Value
                    Me.l_saldo.Text = Me.l_monto.Text
                    Me.ch_contEspecial.Checked = Me.DGV_R.SelectedRows(0).Cells(4).Value

                End If

                If Me.ch_contEspecial.Checked = True Then

                    Me.l_con.Visible = True
                    Me.ch_contEspecial.Visible = True
                    Me.l_retencion.Visible = True
                    Me.tb_retencion.Visible = True
                    Me.DGV_Recibos.Columns(9).Visible = True
                    Me.l_p.Visible = True
                    Me.chk_comp.Visible = True
                    Me.chk_comp.Checked = True

                Else

                    Me.chk_comp.Visible = False
                    Me.chk_comp.Checked = False
                    Me.l_con.Visible = False
                    Me.ch_contEspecial.Visible = False
                    Me.l_retencion.Visible = False
                    Me.tb_retencion.Visible = False
                    Me.DGV_Recibos.Columns(9).Visible = False
                    Me.l_p.Visible = False

                End If

                Me.DGV_Fact.ClearSelection()
                Me.DGV_Recibos.ClearSelection()

            End If

        Else

            If Me.DGV_Clientes.SelectedRows.Count > 0 Then
                Dim cod As Integer = 0
                cod = CInt(Me.DGV_Clientes.SelectedRows(0).Cells(0).Value)
                If Not varBoton = 1 Then
                    Dim bancodep As String = ""
                    DatosRecibo.consulta_Recibo(cod, Me.tb_control.Text, Me.tb_monto.Text, Me.tb_fecha.Value, Me.tb_fechaD.Value, Me.tb_banco, Me.tb_cheque.Text, Me.tb_deposito.Text, Me.tb_observacion.Text, Me.tb_efectivo.Text, bancodep, Me.ch_dev, Me.tb_retencion.Text, Me.tb_fechaCD.Value, Me.ch_pd, Me.tb_dep_chd.Text, tb_bancodep, tb_compRet.Text, chk_comp.Checked, tb_usuario.Text)
                    sw_ch = Me.ch_dev.Checked
                    Dim cont As Integer = 0
                    DatosRecibo.consulta_facturas(Me.DGV_Recibos, cod, Me.tb_fechaD.Value, Me.DGV_Clientes.SelectedRows(0).Cells(2).Value)
                    Me.l_recibo.Text = Me.DGV_Clientes.SelectedRows(0).Cells(0).Value
                    Me.l_codCliente.Text = CInt(Me.DGV_Clientes.SelectedRows(0).Cells(2).Value)
                    Me.l_razon.Text = Me.DGV_Clientes.SelectedRows(0).Cells(3).Value
                    Me.ch_contEspecial.Checked = Me.DGV_Clientes.SelectedRows(0).Cells(4).Value
                    DatosRecibo.consulta_cliente_R(CInt(Me.DGV_Clientes.SelectedRows(0).Cells(2).Value), Me.DGV_Fact, Me.lb_deuda, Me.l_saldo)
                Else
                    DatosRecibo.consulta_cliente_R(CInt(Me.DGV_Clientes.SelectedRows(0).Cells(2).Value), Me.DGV_Fact, Me.lb_deuda, Me.l_saldo)
                    Me.l_codCliente.Text = CInt(Me.DGV_Clientes.SelectedRows(0).Cells(2).Value)
                    Me.l_razon.Text = Me.DGV_Clientes.SelectedRows(0).Cells(3).Value
                    Me.l_saldo.Text = Me.l_monto.Text
                    Me.ch_contEspecial.Checked = Me.DGV_Clientes.SelectedRows(0).Cells(4).Value
                End If
                If Me.ch_contEspecial.Checked = True Then
                    Me.l_con.Visible = True
                    Me.ch_contEspecial.Visible = True
                    Me.l_retencion.Visible = True
                    Me.tb_retencion.Visible = True
                    Me.DGV_Recibos.Columns(9).Visible = True
                    Me.l_p.Visible = True
                Else
                    Me.l_con.Visible = False
                    Me.ch_contEspecial.Visible = False
                    Me.l_retencion.Visible = False
                    Me.tb_retencion.Visible = False
                    Me.DGV_Recibos.Columns(9).Visible = False
                    Me.l_p.Visible = False
                End If
                Me.DGV_Fact.ClearSelection()
                Me.DGV_Recibos.ClearSelection()
            End If

        End If
    End Sub

    Public Sub tb_buscarcodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown

        If varBoton <> 1 And varBoton <> 2 And varBoton <> 3 Then

            If DGV_R.Rows.Count > 0 Then
                If e.KeyData = Keys.Enter Then
                    Me.DGV_R.Rows(0).Cells(2).Selected = True
                    DGV_R.Focus()
                End If
            End If

        Else

            If DGV_Clientes.Rows.Count > 0 Then
                If e.KeyData = Keys.Enter Then
                    Me.DGV_Clientes.Rows(0).Cells(2).Selected = True
                    DGV_Clientes.Focus()
                    Me.DGV_R_Selectedindex()
                End If
            End If

        End If
    End Sub

    Private Sub tb_fechaD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_fechaD.ValueChanged
        If Me.DGV_Recibos.Rows.Count > 0 Then
            Dim i As Integer = 0
            While i < Me.DGV_Recibos.Rows.Count
                Me.DGV_Recibos.Rows(i).Cells(3).Value = Me.tb_fechaD.Value.Date
                Me.DGV_Recibos.Rows(i).Cells(6).Value = DateDiff(DateInterval.Day, Me.DGV_Recibos.Rows(i).Cells(2).Value, Me.tb_fechaD.Value)
                i = i + 1
            End While
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub movimientos(ByVal numD As String, ByVal codCliente As String, ByVal montoD As Double, ByVal fechaD As Date, ByVal banco As String, ByVal razon As String, ByVal numFact As String, ByVal dgv_movimientos As DataGridView, ByVal dgv_fac As DataGridView, ByVal linea As Integer, ByVal t As Boolean, ByVal comboBanc As String, ByVal fechaDesde As Date, ByVal fechaH As Date, ByVal rbfecha As Boolean, ByVal rbbanco As Boolean, ByVal swret As Boolean, ByVal ret As Double, ByVal u As String)

        user = u
        dgv_mov = dgv_movimientos
        dgv_f = dgv_fac
        line = linea
        cb = comboBanc
        ch_contEspecial.Checked = swret
        td = fechaDesde
        th = fechaH
        rf = rbfecha
        rb = rbbanco
        Dim cont As Integer = 0
        Dim valor As Integer = 0
        otra = True
        varBoton = 1
        numDeposito = numD

        ToolBar1_ButtonClick(ToolBar1, New System.Windows.Forms.ToolBarButtonClickEventArgs(bt_nuevo))
        If t = True Then
            tip = t
            dgv_fac.Enabled = True
        Else
            Me.DGV_Fact.Enabled = False
        End If
        DomainUpDown1.SelectedIndex = 1
        tb_buscarcodigo.Text = codCliente
        DGV_Clientes.Rows(0).Cells(2).Selected = True
        DGV_R_Selectedindex()
        dgv_R_DoubleClick(DGV_Clientes, New System.EventArgs)
        Dim fila As Integer = 0
        Me.tb_monto.ReadOnly = True
        Me.tb_efectivo.ReadOnly = True
        Me.DGV_Recibos.Enabled = True
        tb_monto.Text = FormatNumber(montoD, 2)
        tb_fechaD.Value = fechaD


        Dim cont2 As Integer = 0

        While cont2 < tb_bancodep.Items.Count
            If tb_bancodep.Items(cont2).col1.ToString.ToUpper = banco.ToUpper Then
                tb_bancodep.SelectedIndex = cont2
                cont2 = tb_bancodep.Items.Count + 1
            Else
                cont2 = cont2 + 1
            End If
        End While

        tb_deposito.Text = numD
        tb_deposito.Enabled = False
        Me.tb_fechaD.Enabled = False
        Me.tb_bancodep.Enabled = False
        Me.tb_retencion.Text = ret
        If ch_contEspecial.Checked And ret = 0 Then
            If My.Settings.Empresa <> 5 Then
                tb_retencion.Text = "75"
            Else
                tb_retencion.Text = "100"
            End If
        End If
        DGV_R.ClearSelection()
        Me.bt_procesar.Visible = False
        Me.bt_aceptar.Visible = True

        If t = False Then
            Try
                Dim a As Integer = CInt(numFact)
                fila = fila_dgvFacturas(numFact)
                DGV_Fact.Rows(fila).Selected = True
                DGV_Fact_CellDoubleClick(DGV_Fact, New System.Windows.Forms.DataGridViewCellEventArgs(0, fila))
                Me.tb_retencion.Enabled = False
            Catch ex As Exception
                Me.DGV_Fact.Enabled = True
            End Try

        Else
            Me.tb_retencion.Enabled = True
            Me.DGV_Fact.Enabled = True
        End If

    End Sub
    Public Sub movimientos_chpd(ByVal numD As String, ByVal codCliente As String, ByVal montoD As Double, ByVal fechaD As Date, ByVal banco As String, ByVal razon As String, ByVal codR As String, ByVal dgv_movimientos As DataGridView, ByVal dgv_fac As DataGridView, ByVal linea As Integer, ByVal t As Boolean, ByVal comboBanc As String, ByVal fechaDesde As Date, ByVal fechaH As Date, ByVal rbfecha As Boolean, ByVal rbbanco As Boolean, ByVal swret As Boolean, ByVal ret As Double, ByVal dgvchpd As DataGridView)
        movchpd = True
        dgv_mov = dgv_movimientos
        dgv_f = dgv_fac
        line = linea
        cb = comboBanc
        td = fechaDesde
        th = fechaH
        rf = rbfecha
        rb = rbbanco
        dgv_chpd = dgvchpd
        Dim cont As Integer = 0
        Dim valor As Integer = 0
        otra = True
        numDeposito = numD
        SpconsultaRecibos2BindingSource.Filter = "CodigoRecibo = " & codR.ToString & ""
        DGV_R.Rows(0).Cells(1).Selected = True
        DGV_R_Selectedindex()
        ToolBar1_ButtonClick(ToolBar1, New System.Windows.Forms.ToolBarButtonClickEventArgs(bt_modificar))
        Me.DGV_Fact.Enabled = True
        Me.ch_pd.Checked = False
        Dim i As Integer = 0
        tb_monto.Text = FormatNumber(montoD, 2)
        Me.l_saldo.Text = FormatNumber(Me.tb_monto.Text, 2)
        While i < Me.DGV_Recibos.Rows.Count
            Dim filaF As Integer
            Dim fact As Integer = Me.DGV_Recibos.Rows(0).Cells(0).Value
            Me.DGV_Recibos.Rows(0).Cells(0).Selected = True
            DGV_Recibos_KeyDown(DGV_Recibos, New KeyEventArgs(Keys.Delete))
            filaF = fila_dgvFacturas(fact)
            varBoton = 1
            If filaF <> -1 Then
                If i = 0 Then
                    l_saldo.Text = tb_monto.Text
                End If
                Me.DGV_Fact.Rows(filaF).Selected = True
                Me.DGV_Fact_CellDoubleClick(Me.DGV_Fact, New System.Windows.Forms.DataGridViewCellEventArgs(1, filaF))
            End If
            i = i + 1
        End While
        varBoton = 2
        Me.DGV_Recibos.ReadOnly = True
        Dim fila As Integer = 0
        Me.tb_monto.ReadOnly = True
        Me.tb_efectivo.ReadOnly = True
        Me.DGV_Recibos.Enabled = True
        tb_fechaD.Value = fechaD
        tb_bancodep.Text = banco
        tb_deposito.Text = numD
        tb_deposito.Enabled = False
        Me.tb_fechaD.Enabled = False
        Me.tb_bancodep.Enabled = False
        Me.tb_retencion.Text = ret
        DGV_R.ClearSelection()
        Me.bt_procesar.Visible = False
        Me.bt_aceptar.Visible = True
    End Sub
    Public Sub devueltos(ByVal numR As Integer, ByVal dgv As DataGridView, ByVal dgvc As DataGridView, ByVal fechad As Date, ByVal dgv_fact As DataGridView, ByVal num As String, ByVal ctrl As String)
        dgv_mov = dgv
        dgv_c = dgvc
        dgv_f = dgv_fact
        DomainUpDown1.SelectedIndex = 1
        numDeposito = num
        tb_buscarcodigo.Text = ctrl
        SpconsultaRecibos2BindingSource.Filter = "CodigoRecibo = " & numR.ToString
        DGV_R.Rows(0).Cells(1).Selected = True
        DGV_R_Selectedindex()
        Me.tb_dep_chd.Text = num
        Me.tb_dep_chd.Visible = True
        Me.lb_depdev.Visible = True
        ToolBar1_ButtonClick(ToolBar1, New System.Windows.Forms.ToolBarButtonClickEventArgs(bt_modificar))
        Me.ch_dev.Checked = True
        Me.tb_fechaCD.Value = fechad
        tb_buscarcodigo.ReadOnly = True
        otra = True
    End Sub

    Public Sub Clientes(ByVal recibo As String)
        Dim num As Integer = 0
        For cont As Integer = 0 To DGV_R.RowCount - 1
            If DGV_R.Rows(cont).Cells(0).Value.ToString = recibo Then
                num = cont
                cont = DGV_R.RowCount
            End If
        Next
        choice = 4
        tb_buscarcodigo.Text = recibo
        DGV_R.Rows(0).Cells(1).Selected = True
        DGV_R_Selectedindex()
        DGV_R.Enabled = False
        DGV_Fact.Enabled = False
        DGV_Recibos.Enabled = False
        DomainUpDown1.Text = "Codigo"
        DomainUpDown1.Enabled = False
        tb_buscarcodigo.ReadOnly = True
    End Sub


    Private Sub ch_pd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pd.CheckedChanged
        If ch_pd.Checked Then
            Me.tb_efectivo.Text = ""
            Me.tb_efectivo.ReadOnly = True
            Me.tb_cheque.ReadOnly = False
            Me.tb_monto.ReadOnly = False
            If varBoton = 1 Then
                Me.tb_cheque.Focus()
            End If
        Else
            Me.tb_efectivo.Text = ""
            Me.tb_efectivo.ReadOnly = False
            Me.tb_cheque.ReadOnly = True
            Me.tb_monto.ReadOnly = True
        End If

    End Sub

    Private Sub DGV_Recibos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Recibos.KeyDown
        If e.KeyCode = Keys.Delete Then
            borrada = Me.DGV_Recibos.SelectedRows(0).Index
            facR = Me.DGV_Recibos.SelectedRows(0).Cells(7).Value
            If Me.bt_aceptar.Visible = True Then
                If Not Me.ch_pd.Checked Then
                    Dim Tot As Double
                    Dim row As Integer = 0
                    While row < Me.DGV_Recibos.Rows.Count
                        Tot = Tot + CDbl(Me.DGV_Recibos(5, row).Value)
                        row = row + 1
                    End While
                    Dim i As Integer
                    Dim sw As Boolean = False
                    While i < Me.DGV_Fact.Rows.Count
                        If Me.DGV_Fact.Rows(i).Cells(0).Value = Me.DGV_Recibos.SelectedRows(0).Cells(0).Value Then
                            sw = True
                            Me.DGV_Fact.Rows(i).Cells(5).Value = CDbl(Me.DGV_Fact.Rows(i).Cells(5).Value) + Me.DGV_Recibos.SelectedRows(0).Cells(5).Value + Me.DGV_Recibos.SelectedRows(0).Cells(8).Value + Me.DGV_Recibos.SelectedRows(0).Cells(9).Value
                            Me.DGV_Fact.Rows(i).Cells(7).Value = Me.DGV_Recibos.SelectedRows(0).Cells(10).Value
                            If varBoton = 1 Then
                                Me.l_saldo.Text = CDbl(Me.l_saldo.Text) + Me.DGV_Recibos.SelectedRows(0).Cells(5).Value
                            ElseIf varBoton = 2 Then
                                Me.l_saldo.Text = CDbl(Me.tb_monto.Text) + CDbl(Me.tb_efectivo.Text) - Tot
                            End If
                            i = Me.DGV_Fact.Rows.Count
                        End If
                        i = i + 1
                    End While
                    If sw = False Then
                        Me.DGV_Fact.Rows.Add(ObtenerValoresFilaRecibo(Me.DGV_Recibos.SelectedRows(0)))
                        If Me.DGV_Fact.Rows(Me.DGV_Fact.Rows.Count - 1).Cells(5).Value < 0 Then
                            Me.DGV_Fact.Rows(Me.DGV_Fact.Rows.Count - 1).Cells(5).Style.ForeColor = Color.Blue
                        End If

                        If varBoton = 1 Then
                            Me.l_saldo.Text = FormatNumber(CDbl(Me.l_saldo.Text) + Me.DGV_Recibos.SelectedRows(0).Cells(5).Value, 2)
                        ElseIf varBoton = 2 Then
                            Me.l_saldo.Text = FormatNumber(CDbl(Me.l_monto.Text) - Tot, 2)
                        End If
                    End If
                    Me.lb_deuda.Text = FormatNumber(Me.total_dgv_fact(), 2)
                    Me.DGV_Recibos.Rows.RemoveAt(Me.DGV_Recibos.SelectedRows(0).Index)
                Else
                    If Me.DGV_Recibos.Rows.Count = 1 Then
                        Dim filaF As Integer
                        filaF = fila_dgvFacturas(Me.DGV_Recibos.SelectedRows(0).Cells(0).Value)
                        If Me.l_saldo.Text <= Me.DGV_Fact(5, filaF).Value Then
                            Me.l_saldo.Text = FormatNumber(Me.tb_monto.Text, 2)
                        Else
                            Me.l_saldo.Text = FormatNumber(CDbl(Me.l_saldo.Text) + Me.DGV_Fact(5, filaF).Value, 2)
                        End If
                        Me.DGV_Recibos.Rows.RemoveAt(Me.DGV_Recibos.SelectedRows(0).Index)
                    Else
                        If Me.DGV_Recibos.SelectedRows(0).Index = Me.DGV_Recibos.Rows.Count - 1 Then
                            Me.DGV_Recibos.Rows.RemoveAt(Me.DGV_Recibos.SelectedRows(0).Index)
                            Dim filaF As Integer
                            filaF = fila_dgvFacturas(Me.DGV_Recibos.SelectedRows(0).Cells(0).Value)
                            Dim i As Integer = 0
                            Dim acum As Double = 0
                            While i < Me.DGV_Recibos.Rows.Count
                                Dim o As Integer = 0
                                While o < Me.DGV_Fact.Rows.Count
                                    If Me.DGV_Fact.Rows(o).Cells(6).Value = Me.DGV_Recibos.Rows(i).Cells(7).Value Then
                                        acum = acum + Me.DGV_Fact.Rows(o).Cells(5).Value
                                        o = Me.DGV_Fact.Rows.Count
                                    End If
                                    o = o + 1
                                End While
                                i = i + 1
                            End While
                            Me.l_saldo.Text = FormatNumber(CDbl(Me.tb_monto.Text) - acum, 2)
                        Else
                            MsgBox("Sólo puede eliminar la última fila.")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        CrearWhere()

    End Sub


    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If DomainUpDown1.SelectedIndex = 0 Then

            where = where + y + "RazonSocial LIKE '%" & tb_buscarcodigo.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 1 Then

            where = where + y + "NControl LIKE '%" & tb_buscarcodigo.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 2 Then

            where = where + y + "Phrase LIKE '%" & tb_buscarcodigo.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 3 Then

            where = where + y + "NDeposito LIKE '%" & tb_buscarcodigo.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 4 Then

            where = where + y + "Monto LIKE '%" & tb_buscarcodigo.Text & "%'"
            y = " and "

        End If

        If CheckBox1.Checked Then
            where = where + y + "PD = True"
            y = " and "
        End If

        If My.Settings.Empresa <> 1 And My.Settings.Empresa <> 4 And My.Settings.Empresa <> 6 And My.Settings.Empresa <> 7 And My.Settings.Empresa <> 5 Then

            If rb_confirmados.Checked Then
                where = where + y + "Confirmado = True"
                y = " and "
            ElseIf rb_pendientes.Checked Then
                where = where + y + "Confirmado = False"
                y = " and "
            End If

            If CheckBox2.Checked Then
                where = where + y + "ComprobanteRecibido = False"
                y = " and "
            End If

        End If

        Me.SpconsultaRecibos2BindingSource.Filter = where
        DGV_R.ClearSelection()

        Dim Sum As Object
        Sum = Me.MELDataSet.sp_consultaRecibos2.Compute("COUNT(CodigoRecibo)", where)

        If rb_pendientes.Checked Then
            where = where + y + "Confirmado = false"
            l_recibosPC.Text = Sum
        Else
            where = where + y + "Confirmado = True"
            l_recibos.Text = Sum
        End If

        limpia()

    End Sub

    Private Sub ch_contEspecial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_contEspecial.CheckedChanged
        If varBoton = 1 Or varBoton = 2 And ch_contEspecial.Visible Then
            If ch_contEspecial.Checked Then
                tb_compRet.ReadOnly = False
            Else
                tb_compRet.ReadOnly = True
            End If
        End If
    End Sub

    Public Sub Cheque_Dev_Desglosado(ByVal numD As String, ByVal codCliente As String, ByVal montoD As Double, ByVal fechaD As Date, ByVal banco As String, ByVal razon As String, ByVal numFact As String, ByVal dgv_movimientos As DataGridView, ByVal dgv_fac As DataGridView, ByVal linea As Integer, ByVal t As Boolean, ByVal comboBanc As String, ByVal fechaDesde As Date, ByVal fechaH As Date, ByVal rbfecha As Boolean, ByVal rbbanco As Boolean, ByVal swret As Boolean, ByVal ret As Double, ByVal u As String, ByVal numR As String)

        Dim deny As Boolean = False
        user = u
        dgv_mov = dgv_movimientos
        dgv_f = dgv_fac
        line = linea
        cb = comboBanc
        ch_contEspecial.Checked = swret
        td = fechaDesde
        th = fechaH
        rf = rbfecha
        MontoCHD = montoD
        rb = rbbanco
        Dim cont As Integer = 0
        Dim valor As Integer = 0
        otra = True
        numDeposito = numD
        numRecibo = numR
        numFactura = CInt(numFact)
        FechaMov = fechaD

        SpconsultaRecibos2BindingSource.Filter = "CodigoRecibo = '" & numR & "'"

        DGV_R.Rows(0).Cells(2).Selected = True
        DGV_R_click(DGV_R, New DataGridViewCellEventArgs(DGV_R.CurrentCell.ColumnIndex, DGV_R.CurrentCell.RowIndex))
        ToolBar1_ButtonClick(ToolBar1, New ToolBarButtonClickEventArgs(bt_modificar))
        varBoton = 5

        Dim cont2 As Integer = 0
        Dim dif As Double = montoD

        While dif > 0

            If dif >= DGV_Recibos.Rows(cont2).Cells(5).Value Then


                dif = dif - CDbl(DGV_Recibos.Rows(cont2).Cells(5).Value)
                DGV_Recibos.Rows(cont2).Cells(5).Value = Format(0, "#,##0.00")


                If ch_contEspecial.Checked Then

                    DGV_Recibos.Rows(cont2).Cells(9).Value = Format(0, "#,##0.00")

                End If

                If dif = 0 Then

                    indexRec = cont2

                End If

            Else

                If ch_contEspecial.Checked Then

                    DGV_Recibos.Rows(cont2).Cells(9).Value = Format(CDbl(DGV_Recibos.Rows(cont2).Cells(9).Value) - _
                                                                    (dif / 1.03) * (CDbl(DGV_Recibos.Rows(cont2).Cells(10).Value) / 100) _
                                                                    * ((CDbl(tb_retencion.Text)) / 100), "#,##0.00")

                End If

                DGV_Recibos.Rows(cont2).Cells(5).Value = Format(CDbl(DGV_Recibos.Rows(cont2).Cells(5).Value) - dif, "#,##0.00")

                dif = 0

                indexRec = cont2

            End If

            cont2 = cont2 + 1


        End While



    End Sub

    Private Sub rb_confirmados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_confirmados.CheckedChanged

        If rb_confirmados.Checked Then
            bt_nuevo.Enabled = True
            bt_modificar.Enabled = True
            bt_confirmar.Enabled = False
        End If

        CrearWhere()

    End Sub

    Private Sub rb_pendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pendientes.CheckedChanged

        If rb_pendientes.Checked Then

            bt_nuevo.Enabled = False
            bt_modificar.Enabled = False
            bt_confirmar.Enabled = True

        End If

        CrearWhere()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        CrearWhere()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_usuario.TextChanged

    End Sub

    Private Sub DGV_R_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_R.CellContentClick

    End Sub

    Private Sub DGV_Recibos_RowsRemoved(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Recibos.RowsRemoved, DGV_Recibos.RowsAdded

        If varBoton = 1 Then

            l_saldo.Text = l_monto.Text

            For cont As Integer = 0 To DGV_Recibos.RowCount - 1

                'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                '    If Not ch_contEspecial.Checked Then
                '        Me.l_saldo.Text = Format(CDbl(Me.l_saldo.Text) - (DGV_Recibos.Rows(cont).Cells(5).Value), "#,##0.00")
                '    Else
                '        Me.l_saldo.Text = Format(CDbl(Me.l_saldo.Text) - (DGV_Recibos.Rows(cont).Cells(5).Value) - (DGV_Recibos.Rows(cont).Cells(9).Value), "#,##0.00")
                '    End If

                'Else

                Me.l_saldo.Text = Format(CDbl(Me.l_saldo.Text) - (DGV_Recibos.Rows(cont).Cells(5).Value), "#,##0.00")

                'End If

            Next

        End If

    End Sub

End Class
