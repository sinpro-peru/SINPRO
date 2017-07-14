<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Configuracion_Web
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
        Me.Tab_Web = New System.Windows.Forms.TabControl
        Me.tp_comentarios = New System.Windows.Forms.TabPage
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.tb_tituloAd = New System.Windows.Forms.TextBox
        Me.Label100 = New System.Windows.Forms.Label
        Me.Label103 = New System.Windows.Forms.Label
        Me.tb_comentarioWeb4 = New System.Windows.Forms.TextBox
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.tb_tituloA = New System.Windows.Forms.TextBox
        Me.Label99 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.tb_comentarioWeb3 = New System.Windows.Forms.TextBox
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.tb_tituloC = New System.Windows.Forms.TextBox
        Me.Label98 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.tb_comentarioWeb2 = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.tb_tituloV = New System.Windows.Forms.TextBox
        Me.Label97 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.tb_comentarioWeb = New System.Windows.Forms.TextBox
        Me.tp_resaltarCompras = New System.Windows.Forms.TabPage
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label68 = New System.Windows.Forms.Label
        Me.tb_diasResaltar = New System.Windows.Forms.TextBox
        Me.tp_funciones = New System.Windows.Forms.TabPage
        Me.S = New System.Windows.Forms.GroupBox
        Me.Label101 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.chk_listados = New System.Windows.Forms.CheckBox
        Me.chk_rec = New System.Windows.Forms.CheckBox
        Me.chk_dev = New System.Windows.Forms.CheckBox
        Me.chk_ped = New System.Windows.Forms.CheckBox
        Me.tp_OcultarGrupos = New System.Windows.Forms.TabPage
        Me.bt_eliminarGrupo = New System.Windows.Forms.Button
        Me.bt_agregarGrupo = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGV_GruposWeb = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV_Grupos = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_iva = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.bt_aplicar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptarIva = New System.Windows.Forms.Button
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.TblGrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_GrupoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.Tbl_GrupoTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tab_Web.SuspendLayout()
        Me.tp_comentarios.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.tp_resaltarCompras.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.tp_funciones.SuspendLayout()
        Me.S.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.tp_OcultarGrupos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_GruposWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Grupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_Web
        '
        Me.Tab_Web.Controls.Add(Me.tp_comentarios)
        Me.Tab_Web.Controls.Add(Me.tp_resaltarCompras)
        Me.Tab_Web.Controls.Add(Me.tp_funciones)
        Me.Tab_Web.Controls.Add(Me.tp_OcultarGrupos)
        Me.Tab_Web.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Web.HotTrack = True
        Me.Tab_Web.Location = New System.Drawing.Point(4, 3)
        Me.Tab_Web.Multiline = True
        Me.Tab_Web.Name = "Tab_Web"
        Me.Tab_Web.SelectedIndex = 0
        Me.Tab_Web.Size = New System.Drawing.Size(882, 454)
        Me.Tab_Web.TabIndex = 17
        '
        'tp_comentarios
        '
        Me.tp_comentarios.BackColor = System.Drawing.Color.White
        Me.tp_comentarios.Controls.Add(Me.Panel18)
        Me.tp_comentarios.Controls.Add(Me.Panel16)
        Me.tp_comentarios.Controls.Add(Me.Panel9)
        Me.tp_comentarios.Controls.Add(Me.Label61)
        Me.tp_comentarios.Controls.Add(Me.Label63)
        Me.tp_comentarios.Controls.Add(Me.Panel8)
        Me.tp_comentarios.Location = New System.Drawing.Point(4, 24)
        Me.tp_comentarios.Name = "tp_comentarios"
        Me.tp_comentarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_comentarios.Size = New System.Drawing.Size(874, 426)
        Me.tp_comentarios.TabIndex = 13
        Me.tp_comentarios.Text = "Comentarios Web"
        Me.tp_comentarios.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.tb_tituloAd)
        Me.Panel18.Controls.Add(Me.Label100)
        Me.Panel18.Controls.Add(Me.Label103)
        Me.Panel18.Controls.Add(Me.tb_comentarioWeb4)
        Me.Panel18.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel18.Location = New System.Drawing.Point(435, 223)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(426, 100)
        Me.Panel18.TabIndex = 31
        '
        'tb_tituloAd
        '
        Me.tb_tituloAd.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tituloAd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_tituloAd.Location = New System.Drawing.Point(117, 2)
        Me.tb_tituloAd.Multiline = True
        Me.tb_tituloAd.Name = "tb_tituloAd"
        Me.tb_tituloAd.Size = New System.Drawing.Size(299, 22)
        Me.tb_tituloAd.TabIndex = 29
        '
        'Label100
        '
        Me.Label100.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label100.Location = New System.Drawing.Point(5, 4)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(117, 22)
        Me.Label100.TabIndex = 30
        Me.Label100.Text = "(*) Titulo Ad.:"
        '
        'Label103
        '
        Me.Label103.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label103.Location = New System.Drawing.Point(5, 30)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(106, 36)
        Me.Label103.TabIndex = 4
        Me.Label103.Text = "(*) Comentario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Admin:"
        '
        'tb_comentarioWeb4
        '
        Me.tb_comentarioWeb4.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comentarioWeb4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_comentarioWeb4.Location = New System.Drawing.Point(117, 26)
        Me.tb_comentarioWeb4.Multiline = True
        Me.tb_comentarioWeb4.Name = "tb_comentarioWeb4"
        Me.tb_comentarioWeb4.Size = New System.Drawing.Size(299, 68)
        Me.tb_comentarioWeb4.TabIndex = 1
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.tb_tituloA)
        Me.Panel16.Controls.Add(Me.Label99)
        Me.Panel16.Controls.Add(Me.Label96)
        Me.Panel16.Controls.Add(Me.tb_comentarioWeb3)
        Me.Panel16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel16.Location = New System.Drawing.Point(435, 108)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(426, 103)
        Me.Panel16.TabIndex = 24
        '
        'tb_tituloA
        '
        Me.tb_tituloA.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tituloA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_tituloA.Location = New System.Drawing.Point(117, 2)
        Me.tb_tituloA.Multiline = True
        Me.tb_tituloA.Name = "tb_tituloA"
        Me.tb_tituloA.Size = New System.Drawing.Size(299, 22)
        Me.tb_tituloA.TabIndex = 29
        '
        'Label99
        '
        Me.Label99.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label99.Location = New System.Drawing.Point(5, 4)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(117, 22)
        Me.Label99.TabIndex = 30
        Me.Label99.Text = "(*) Titulo A.:"
        '
        'Label96
        '
        Me.Label96.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label96.Location = New System.Drawing.Point(5, 30)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(106, 36)
        Me.Label96.TabIndex = 4
        Me.Label96.Text = "(*) Comentario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Almacenes:"
        '
        'tb_comentarioWeb3
        '
        Me.tb_comentarioWeb3.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comentarioWeb3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_comentarioWeb3.Location = New System.Drawing.Point(117, 26)
        Me.tb_comentarioWeb3.Multiline = True
        Me.tb_comentarioWeb3.Name = "tb_comentarioWeb3"
        Me.tb_comentarioWeb3.Size = New System.Drawing.Size(299, 68)
        Me.tb_comentarioWeb3.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.tb_tituloC)
        Me.Panel9.Controls.Add(Me.Label98)
        Me.Panel9.Controls.Add(Me.Label62)
        Me.Panel9.Controls.Add(Me.tb_comentarioWeb2)
        Me.Panel9.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(6, 223)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(426, 100)
        Me.Panel9.TabIndex = 23
        '
        'tb_tituloC
        '
        Me.tb_tituloC.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tituloC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_tituloC.Location = New System.Drawing.Point(117, 2)
        Me.tb_tituloC.Multiline = True
        Me.tb_tituloC.Name = "tb_tituloC"
        Me.tb_tituloC.Size = New System.Drawing.Size(299, 22)
        Me.tb_tituloC.TabIndex = 27
        '
        'Label98
        '
        Me.Label98.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label98.Location = New System.Drawing.Point(5, 3)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(117, 22)
        Me.Label98.TabIndex = 28
        Me.Label98.Text = "(*) Titulo C.:"
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(5, 28)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(106, 36)
        Me.Label62.TabIndex = 4
        Me.Label62.Text = "(*) Comentario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Clientes:"
        '
        'tb_comentarioWeb2
        '
        Me.tb_comentarioWeb2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comentarioWeb2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_comentarioWeb2.Location = New System.Drawing.Point(117, 26)
        Me.tb_comentarioWeb2.Multiline = True
        Me.tb_comentarioWeb2.Name = "tb_comentarioWeb2"
        Me.tb_comentarioWeb2.Size = New System.Drawing.Size(299, 68)
        Me.tb_comentarioWeb2.TabIndex = 1
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(200, 48)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(469, 16)
        Me.Label61.TabIndex = 22
        Me.Label61.Text = "Escriba aquí los comentarios a mostrar en su página web en la ventana de inicio"
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label63.Location = New System.Drawing.Point(721, 326)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(131, 23)
        Me.Label63.TabIndex = 21
        Me.Label63.Text = "(*)Datos requeridos"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.tb_tituloV)
        Me.Panel8.Controls.Add(Me.Label97)
        Me.Panel8.Controls.Add(Me.Label64)
        Me.Panel8.Controls.Add(Me.tb_comentarioWeb)
        Me.Panel8.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(6, 108)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(426, 103)
        Me.Panel8.TabIndex = 20
        '
        'tb_tituloV
        '
        Me.tb_tituloV.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tituloV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_tituloV.Location = New System.Drawing.Point(117, 2)
        Me.tb_tituloV.Multiline = True
        Me.tb_tituloV.Name = "tb_tituloV"
        Me.tb_tituloV.Size = New System.Drawing.Size(299, 22)
        Me.tb_tituloV.TabIndex = 25
        '
        'Label97
        '
        Me.Label97.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label97.Location = New System.Drawing.Point(5, 3)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(117, 22)
        Me.Label97.TabIndex = 26
        Me.Label97.Text = "(*) Titulo V.:"
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(5, 31)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(106, 36)
        Me.Label64.TabIndex = 4
        Me.Label64.Text = "(*) Comentario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Vendedores:"
        '
        'tb_comentarioWeb
        '
        Me.tb_comentarioWeb.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comentarioWeb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_comentarioWeb.Location = New System.Drawing.Point(117, 27)
        Me.tb_comentarioWeb.Multiline = True
        Me.tb_comentarioWeb.Name = "tb_comentarioWeb"
        Me.tb_comentarioWeb.Size = New System.Drawing.Size(299, 68)
        Me.tb_comentarioWeb.TabIndex = 1
        '
        'tp_resaltarCompras
        '
        Me.tp_resaltarCompras.BackColor = System.Drawing.Color.White
        Me.tp_resaltarCompras.Controls.Add(Me.Label65)
        Me.tp_resaltarCompras.Controls.Add(Me.Label66)
        Me.tp_resaltarCompras.Controls.Add(Me.Label67)
        Me.tp_resaltarCompras.Controls.Add(Me.Panel10)
        Me.tp_resaltarCompras.Location = New System.Drawing.Point(4, 24)
        Me.tp_resaltarCompras.Name = "tp_resaltarCompras"
        Me.tp_resaltarCompras.Size = New System.Drawing.Size(874, 426)
        Me.tp_resaltarCompras.TabIndex = 14
        Me.tp_resaltarCompras.Text = "Resaltar compras Web"
        Me.tp_resaltarCompras.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(234, 51)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(432, 16)
        Me.Label65.TabIndex = 22
        Me.Label65.Text = "Establezca la cantidad de días de antiguedad de las compras mostradas"
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(234, 67)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(356, 23)
        Me.Label66.TabIndex = 23
        Me.Label66.Text = "en su página web"
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label67.Location = New System.Drawing.Point(359, 207)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(131, 23)
        Me.Label67.TabIndex = 21
        Me.Label67.Text = "(*)Datos requeridos"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Label68)
        Me.Panel10.Controls.Add(Me.tb_diasResaltar)
        Me.Panel10.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(332, 139)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(177, 60)
        Me.Panel10.TabIndex = 20
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Location = New System.Drawing.Point(0, 19)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(56, 23)
        Me.Label68.TabIndex = 4
        Me.Label68.Text = "(*)Días:"
        '
        'tb_diasResaltar
        '
        Me.tb_diasResaltar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_diasResaltar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_diasResaltar.Location = New System.Drawing.Point(56, 16)
        Me.tb_diasResaltar.Name = "tb_diasResaltar"
        Me.tb_diasResaltar.Size = New System.Drawing.Size(100, 22)
        Me.tb_diasResaltar.TabIndex = 1
        Me.tb_diasResaltar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tp_funciones
        '
        Me.tp_funciones.BackColor = System.Drawing.Color.White
        Me.tp_funciones.Controls.Add(Me.S)
        Me.tp_funciones.Location = New System.Drawing.Point(4, 24)
        Me.tp_funciones.Name = "tp_funciones"
        Me.tp_funciones.Size = New System.Drawing.Size(874, 426)
        Me.tp_funciones.TabIndex = 20
        Me.tp_funciones.Text = "Funciones Web"
        Me.tp_funciones.UseVisualStyleBackColor = True
        '
        'S
        '
        Me.S.BackColor = System.Drawing.Color.White
        Me.S.Controls.Add(Me.Label101)
        Me.S.Controls.Add(Me.Label102)
        Me.S.Controls.Add(Me.Panel17)
        Me.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S.ForeColor = System.Drawing.Color.SteelBlue
        Me.S.Location = New System.Drawing.Point(10, 9)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(854, 410)
        Me.S.TabIndex = 15
        Me.S.TabStop = False
        Me.S.Text = "Funciones web activas"
        '
        'Label101
        '
        Me.Label101.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label101.Location = New System.Drawing.Point(191, 49)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(432, 16)
        Me.Label101.TabIndex = 18
        Me.Label101.Text = "Elija las funcionalidades que tendrá activa su página web"
        '
        'Label102
        '
        Me.Label102.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label102.Location = New System.Drawing.Point(191, 65)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(432, 23)
        Me.Label102.TabIndex = 19
        Me.Label102.Text = "Si desactiva una opción el usuario sólo podrá acceder al modo consulta"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel17.Controls.Add(Me.chk_listados)
        Me.Panel17.Controls.Add(Me.chk_rec)
        Me.Panel17.Controls.Add(Me.chk_dev)
        Me.Panel17.Controls.Add(Me.chk_ped)
        Me.Panel17.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel17.Location = New System.Drawing.Point(212, 120)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(387, 133)
        Me.Panel17.TabIndex = 8
        '
        'chk_listados
        '
        Me.chk_listados.AutoSize = True
        Me.chk_listados.ForeColor = System.Drawing.Color.Black
        Me.chk_listados.Location = New System.Drawing.Point(26, 93)
        Me.chk_listados.Name = "chk_listados"
        Me.chk_listados.Size = New System.Drawing.Size(114, 19)
        Me.chk_listados.TabIndex = 3
        Me.chk_listados.Text = "Listados Online"
        Me.chk_listados.UseVisualStyleBackColor = True
        '
        'chk_rec
        '
        Me.chk_rec.AutoSize = True
        Me.chk_rec.ForeColor = System.Drawing.Color.Black
        Me.chk_rec.Location = New System.Drawing.Point(26, 68)
        Me.chk_rec.Name = "chk_rec"
        Me.chk_rec.Size = New System.Drawing.Size(112, 19)
        Me.chk_rec.TabIndex = 2
        Me.chk_rec.Text = "Recibos Online"
        Me.chk_rec.UseVisualStyleBackColor = True
        '
        'chk_dev
        '
        Me.chk_dev.AutoSize = True
        Me.chk_dev.ForeColor = System.Drawing.Color.Black
        Me.chk_dev.Location = New System.Drawing.Point(26, 43)
        Me.chk_dev.Name = "chk_dev"
        Me.chk_dev.Size = New System.Drawing.Size(147, 19)
        Me.chk_dev.TabIndex = 1
        Me.chk_dev.Text = "Devoluciones Online"
        Me.chk_dev.UseVisualStyleBackColor = True
        '
        'chk_ped
        '
        Me.chk_ped.AutoSize = True
        Me.chk_ped.ForeColor = System.Drawing.Color.Black
        Me.chk_ped.Location = New System.Drawing.Point(26, 18)
        Me.chk_ped.Name = "chk_ped"
        Me.chk_ped.Size = New System.Drawing.Size(114, 19)
        Me.chk_ped.TabIndex = 0
        Me.chk_ped.Text = "Pedidos Online"
        Me.chk_ped.UseVisualStyleBackColor = True
        '
        'tp_OcultarGrupos
        '
        Me.tp_OcultarGrupos.BackColor = System.Drawing.Color.White
        Me.tp_OcultarGrupos.Controls.Add(Me.Label1)
        Me.tp_OcultarGrupos.Controls.Add(Me.bt_eliminarGrupo)
        Me.tp_OcultarGrupos.Controls.Add(Me.bt_agregarGrupo)
        Me.tp_OcultarGrupos.Controls.Add(Me.GroupBox2)
        Me.tp_OcultarGrupos.Controls.Add(Me.GroupBox1)
        Me.tp_OcultarGrupos.Location = New System.Drawing.Point(4, 24)
        Me.tp_OcultarGrupos.Name = "tp_OcultarGrupos"
        Me.tp_OcultarGrupos.Size = New System.Drawing.Size(874, 426)
        Me.tp_OcultarGrupos.TabIndex = 21
        Me.tp_OcultarGrupos.Text = "Ocultar Grupos Web"
        Me.tp_OcultarGrupos.UseVisualStyleBackColor = True
        '
        'bt_eliminarGrupo
        '
        Me.bt_eliminarGrupo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminarGrupo.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarGrupo.Location = New System.Drawing.Point(403, 216)
        Me.bt_eliminarGrupo.Name = "bt_eliminarGrupo"
        Me.bt_eliminarGrupo.Size = New System.Drawing.Size(34, 29)
        Me.bt_eliminarGrupo.TabIndex = 33
        Me.bt_eliminarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarGrupo
        '
        Me.bt_agregarGrupo.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregarGrupo.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarGrupo.Location = New System.Drawing.Point(403, 173)
        Me.bt_agregarGrupo.Name = "bt_agregarGrupo"
        Me.bt_agregarGrupo.Size = New System.Drawing.Size(34, 27)
        Me.bt_agregarGrupo.TabIndex = 32
        Me.bt_agregarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_GruposWeb)
        Me.GroupBox2.Location = New System.Drawing.Point(459, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 216)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grupos ocultos"
        '
        'DGV_GruposWeb
        '
        Me.DGV_GruposWeb.AllowUserToAddRows = False
        Me.DGV_GruposWeb.AllowUserToDeleteRows = False
        Me.DGV_GruposWeb.AllowUserToResizeColumns = False
        Me.DGV_GruposWeb.AllowUserToResizeRows = False
        Me.DGV_GruposWeb.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_GruposWeb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_GruposWeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_GruposWeb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DGV_GruposWeb.Location = New System.Drawing.Point(6, 21)
        Me.DGV_GruposWeb.MultiSelect = False
        Me.DGV_GruposWeb.Name = "DGV_GruposWeb"
        Me.DGV_GruposWeb.ReadOnly = True
        Me.DGV_GruposWeb.RowHeadersVisible = False
        Me.DGV_GruposWeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_GruposWeb.Size = New System.Drawing.Size(255, 189)
        Me.DGV_GruposWeb.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_Grupos)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grupos del sistema"
        '
        'DGV_Grupos
        '
        Me.DGV_Grupos.AllowUserToAddRows = False
        Me.DGV_Grupos.AllowUserToDeleteRows = False
        Me.DGV_Grupos.AllowUserToResizeColumns = False
        Me.DGV_Grupos.AllowUserToResizeRows = False
        Me.DGV_Grupos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Grupos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Grupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre})
        Me.DGV_Grupos.Location = New System.Drawing.Point(6, 21)
        Me.DGV_Grupos.MultiSelect = False
        Me.DGV_Grupos.Name = "DGV_Grupos"
        Me.DGV_Grupos.ReadOnly = True
        Me.DGV_Grupos.RowHeadersVisible = False
        Me.DGV_Grupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Grupos.Size = New System.Drawing.Size(255, 189)
        Me.DGV_Grupos.TabIndex = 0
        '
        'Id
        '
        Me.Id.HeaderText = "Cod."
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 60
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 170
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(290, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 60)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(160, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 23)
        Me.Label2.TabIndex = 3
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
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(0, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 4
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label36.Location = New System.Drawing.Point(493, 231)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(131, 23)
        Me.Label36.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(192, 91)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(356, 23)
        Me.Label20.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(192, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(432, 16)
        Me.Label19.TabIndex = 18
        '
        'bt_aplicar
        '
        Me.bt_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aplicar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aplicar.ForeColor = System.Drawing.Color.Black
        Me.bt_aplicar.Location = New System.Drawing.Point(508, 476)
        Me.bt_aplicar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_aplicar.Name = "bt_aplicar"
        Me.bt_aplicar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aplicar.TabIndex = 20
        Me.bt_aplicar.Text = "Aplicar"
        '
        'bt_cancelar
        '
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelar.ForeColor = System.Drawing.Color.Black
        Me.bt_cancelar.Location = New System.Drawing.Point(404, 476)
        Me.bt_cancelar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 19
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptarIva
        '
        Me.bt_aceptarIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptarIva.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptarIva.ForeColor = System.Drawing.Color.Black
        Me.bt_aceptarIva.Location = New System.Drawing.Point(300, 476)
        Me.bt_aceptarIva.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_aceptarIva.Name = "bt_aceptarIva"
        Me.bt_aceptarIva.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptarIva.TabIndex = 18
        Me.bt_aceptarIva.Text = "Aceptar"
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGrupoBindingSource
        '
        Me.TblGrupoBindingSource.DataMember = "Tbl_Grupo"
        Me.TblGrupoBindingSource.DataSource = Me.MELDataSet
        '
        'Tbl_GrupoTableAdapter
        '
        Me.Tbl_GrupoTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(174, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Seleccione los grupos de productos que no se visualizarán en la web ni en los lis" & _
            "tados"
        '
        'Frm_Configuracion_Web
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(888, 516)
        Me.Controls.Add(Me.bt_aplicar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptarIva)
        Me.Controls.Add(Me.Tab_Web)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Configuracion_Web"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones WEB"
        Me.Tab_Web.ResumeLayout(False)
        Me.tp_comentarios.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.tp_resaltarCompras.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.tp_funciones.ResumeLayout(False)
        Me.S.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.tp_OcultarGrupos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_GruposWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_Grupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Web As System.Windows.Forms.TabControl
    Friend WithEvents tp_comentarios As System.Windows.Forms.TabPage
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents tb_tituloAd As System.Windows.Forms.TextBox
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents tb_comentarioWeb4 As System.Windows.Forms.TextBox
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents tb_tituloA As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents tb_comentarioWeb3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents tb_tituloC As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents tb_comentarioWeb2 As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents tb_tituloV As System.Windows.Forms.TextBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents tb_comentarioWeb As System.Windows.Forms.TextBox
    Friend WithEvents tp_resaltarCompras As System.Windows.Forms.TabPage
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents tb_diasResaltar As System.Windows.Forms.TextBox
    Friend WithEvents tp_funciones As System.Windows.Forms.TabPage
    Friend WithEvents S As System.Windows.Forms.GroupBox
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents chk_listados As System.Windows.Forms.CheckBox
    Friend WithEvents chk_rec As System.Windows.Forms.CheckBox
    Friend WithEvents chk_dev As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ped As System.Windows.Forms.CheckBox
    Friend WithEvents tp_OcultarGrupos As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents bt_aplicar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptarIva As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_eliminarGrupo As System.Windows.Forms.Button
    Friend WithEvents bt_agregarGrupo As System.Windows.Forms.Button
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents TblGrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_GrupoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.Tbl_GrupoTableAdapter
    Friend WithEvents DGV_Grupos As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_GruposWeb As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
