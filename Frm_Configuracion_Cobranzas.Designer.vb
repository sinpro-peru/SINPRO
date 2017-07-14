<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Configuracion_Cobranzas
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
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IVA")
        Me.tab_cobranzas = New System.Windows.Forms.TabControl
        Me.tp_asociacion = New System.Windows.Forms.TabPage
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.tb_monto = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.tp_ajustes = New System.Windows.Forms.TabPage
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.tb_montoAjustes = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.tp_egresos = New System.Windows.Forms.TabPage
        Me.Label84 = New System.Windows.Forms.Label
        Me.GroupBox19 = New System.Windows.Forms.GroupBox
        Me.bt_cancelarS = New System.Windows.Forms.Button
        Me.bt_agregarS = New System.Windows.Forms.Button
        Me.Label80 = New System.Windows.Forms.Label
        Me.tb_obsS = New System.Windows.Forms.TextBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.tb_identS = New System.Windows.Forms.TextBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.tb_nombreS = New System.Windows.Forms.TextBox
        Me.GroupBox20 = New System.Windows.Forms.GroupBox
        Me.bt_cancelarC = New System.Windows.Forms.Button
        Me.bt_agregarCat = New System.Windows.Forms.Button
        Me.Label83 = New System.Windows.Forms.Label
        Me.tb_nombreC = New System.Windows.Forms.TextBox
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.bt_EliminarSubCategoria = New System.Windows.Forms.Button
        Me.bt_agregarSubCategoria = New System.Windows.Forms.Button
        Me.bt_ModificarSubCategoria = New System.Windows.Forms.Button
        Me.Label78 = New System.Windows.Forms.Label
        Me.tb_busquedaS = New System.Windows.Forms.TextBox
        Me.lb_Subcategoria = New System.Windows.Forms.ListBox
        Me.GroupBox18 = New System.Windows.Forms.GroupBox
        Me.bt_eliminarCategoria = New System.Windows.Forms.Button
        Me.bt_ModificarCategoria = New System.Windows.Forms.Button
        Me.bt_agregarCategoria = New System.Windows.Forms.Button
        Me.Label79 = New System.Windows.Forms.Label
        Me.tb_busquedaC = New System.Windows.Forms.TextBox
        Me.lb_categoria = New System.Windows.Forms.ListBox
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.bt_aplicar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.tab_cobranzas.SuspendLayout()
        Me.tp_asociacion.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tp_ajustes.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tp_egresos.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_cobranzas
        '
        Me.tab_cobranzas.Controls.Add(Me.tp_asociacion)
        Me.tab_cobranzas.Controls.Add(Me.tp_ajustes)
        Me.tab_cobranzas.Controls.Add(Me.tp_egresos)
        Me.tab_cobranzas.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_cobranzas.HotTrack = True
        Me.tab_cobranzas.Location = New System.Drawing.Point(5, 3)
        Me.tab_cobranzas.Multiline = True
        Me.tab_cobranzas.Name = "tab_cobranzas"
        Me.tab_cobranzas.SelectedIndex = 0
        Me.tab_cobranzas.Size = New System.Drawing.Size(881, 456)
        Me.tab_cobranzas.TabIndex = 21
        '
        'tp_asociacion
        '
        Me.tp_asociacion.BackColor = System.Drawing.Color.White
        Me.tp_asociacion.Controls.Add(Me.GroupBox12)
        Me.tp_asociacion.Location = New System.Drawing.Point(4, 24)
        Me.tp_asociacion.Name = "tp_asociacion"
        Me.tp_asociacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_asociacion.Size = New System.Drawing.Size(873, 428)
        Me.tp_asociacion.TabIndex = 9
        Me.tp_asociacion.Text = "Monto Asociación "
        Me.tp_asociacion.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.Label41)
        Me.GroupBox12.Controls.Add(Me.Label42)
        Me.GroupBox12.Controls.Add(Me.Label44)
        Me.GroupBox12.Controls.Add(Me.Panel5)
        Me.GroupBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox12.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox12.Location = New System.Drawing.Point(7, 16)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(858, 396)
        Me.GroupBox12.TabIndex = 15
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Monto Asociación de Depositos"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label41.Location = New System.Drawing.Point(216, 308)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(143, 20)
        Me.Label41.TabIndex = 76
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label41.Visible = False
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(222, 67)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(442, 48)
        Me.Label42.TabIndex = 18
        Me.Label42.Text = "Establezca el monto límite para la busqueda automática de facturas para realizar " & _
            "la asociación automática de depositos"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label44.Location = New System.Drawing.Point(564, 285)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(131, 23)
        Me.Label44.TabIndex = 15
        Me.Label44.Text = "(*)Datos requeridos"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.tb_monto)
        Me.Panel5.Controls.Add(Me.Label47)
        Me.Panel5.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(225, 169)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(439, 65)
        Me.Panel5.TabIndex = 8
        '
        'tb_monto
        '
        Me.tb_monto.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_monto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_monto.Location = New System.Drawing.Point(307, 22)
        Me.tb_monto.Name = "tb_monto"
        Me.tb_monto.Size = New System.Drawing.Size(94, 22)
        Me.tb_monto.TabIndex = 1
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(7, 25)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(325, 23)
        Me.Label47.TabIndex = 4
        Me.Label47.Text = "(*)Monto límite de diferencia del deposito:"
        '
        'tp_ajustes
        '
        Me.tp_ajustes.BackColor = System.Drawing.Color.White
        Me.tp_ajustes.Controls.Add(Me.GroupBox16)
        Me.tp_ajustes.Location = New System.Drawing.Point(4, 24)
        Me.tp_ajustes.Name = "tp_ajustes"
        Me.tp_ajustes.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_ajustes.Size = New System.Drawing.Size(873, 428)
        Me.tp_ajustes.TabIndex = 12
        Me.tp_ajustes.Text = "Monto Ajustes"
        Me.tp_ajustes.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.White
        Me.GroupBox16.Controls.Add(Me.Label57)
        Me.GroupBox16.Controls.Add(Me.Label58)
        Me.GroupBox16.Controls.Add(Me.Label59)
        Me.GroupBox16.Controls.Add(Me.Panel7)
        Me.GroupBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox16.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox16.Location = New System.Drawing.Point(10, 19)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(854, 397)
        Me.GroupBox16.TabIndex = 16
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Monto Ajustes automáticos"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label57.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label57.Location = New System.Drawing.Point(194, 309)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(143, 20)
        Me.Label57.TabIndex = 76
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label57.Visible = False
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(200, 68)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(442, 48)
        Me.Label58.TabIndex = 18
        Me.Label58.Text = "Establezca el monto límite para los ajustes de saldo automáticos cuando se cree u" & _
            "n recibo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label59.Location = New System.Drawing.Point(542, 286)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(131, 23)
        Me.Label59.TabIndex = 15
        Me.Label59.Text = "(*)Datos requeridos"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.tb_montoAjustes)
        Me.Panel7.Controls.Add(Me.Label60)
        Me.Panel7.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(192, 170)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(460, 65)
        Me.Panel7.TabIndex = 8
        '
        'tb_montoAjustes
        '
        Me.tb_montoAjustes.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_montoAjustes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_montoAjustes.Location = New System.Drawing.Point(345, 22)
        Me.tb_montoAjustes.Name = "tb_montoAjustes"
        Me.tb_montoAjustes.Size = New System.Drawing.Size(94, 22)
        Me.tb_montoAjustes.TabIndex = 1
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(-1, 25)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(349, 19)
        Me.Label60.TabIndex = 4
        Me.Label60.Text = "(*)Monto límite de saldo pendiente para asoción:"
        '
        'tp_egresos
        '
        Me.tp_egresos.BackColor = System.Drawing.Color.White
        Me.tp_egresos.Controls.Add(Me.Label84)
        Me.tp_egresos.Controls.Add(Me.GroupBox19)
        Me.tp_egresos.Controls.Add(Me.GroupBox20)
        Me.tp_egresos.Controls.Add(Me.GroupBox17)
        Me.tp_egresos.Controls.Add(Me.GroupBox18)
        Me.tp_egresos.Location = New System.Drawing.Point(4, 24)
        Me.tp_egresos.Name = "tp_egresos"
        Me.tp_egresos.Size = New System.Drawing.Size(873, 428)
        Me.tp_egresos.TabIndex = 18
        Me.tp_egresos.Text = "Categorías egresos"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Eras Demi ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(13, 31)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(590, 15)
        Me.Label84.TabIndex = 10007
        Me.Label84.Text = "Agregue, Modifique o Elimina las categorías y Sub-Categorías para asociar cada eg" & _
            "reso de la compañía"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.bt_cancelarS)
        Me.GroupBox19.Controls.Add(Me.bt_agregarS)
        Me.GroupBox19.Controls.Add(Me.Label80)
        Me.GroupBox19.Controls.Add(Me.tb_obsS)
        Me.GroupBox19.Controls.Add(Me.Label81)
        Me.GroupBox19.Controls.Add(Me.tb_identS)
        Me.GroupBox19.Controls.Add(Me.Label82)
        Me.GroupBox19.Controls.Add(Me.tb_nombreS)
        Me.GroupBox19.Location = New System.Drawing.Point(508, 126)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(348, 190)
        Me.GroupBox19.TabIndex = 7
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Detalles Sub-Categoría"
        '
        'bt_cancelarS
        '
        Me.bt_cancelarS.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelarS.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_cancelarS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_cancelarS.Location = New System.Drawing.Point(236, 155)
        Me.bt_cancelarS.Name = "bt_cancelarS"
        Me.bt_cancelarS.Size = New System.Drawing.Size(34, 29)
        Me.bt_cancelarS.TabIndex = 10039
        Me.bt_cancelarS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarS
        '
        Me.bt_agregarS.BackColor = System.Drawing.Color.Transparent
        Me.bt_agregarS.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarS.Image = Global.Tesis_Nueva.My.Resources.Resources.check_16x16
        Me.bt_agregarS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarS.Location = New System.Drawing.Point(196, 155)
        Me.bt_agregarS.Name = "bt_agregarS"
        Me.bt_agregarS.Size = New System.Drawing.Size(34, 29)
        Me.bt_agregarS.TabIndex = 10038
        Me.bt_agregarS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_agregarS.UseVisualStyleBackColor = False
        Me.bt_agregarS.Visible = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(7, 79)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(92, 15)
        Me.Label80.TabIndex = 5
        Me.Label80.Text = "Observaciones"
        '
        'tb_obsS
        '
        Me.tb_obsS.Location = New System.Drawing.Point(113, 76)
        Me.tb_obsS.Multiline = True
        Me.tb_obsS.Name = "tb_obsS"
        Me.tb_obsS.ReadOnly = True
        Me.tb_obsS.Size = New System.Drawing.Size(228, 74)
        Me.tb_obsS.TabIndex = 4
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(7, 53)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(85, 15)
        Me.Label81.TabIndex = 3
        Me.Label81.Text = "Cedula / R.I.F."
        '
        'tb_identS
        '
        Me.tb_identS.Location = New System.Drawing.Point(113, 50)
        Me.tb_identS.Name = "tb_identS"
        Me.tb_identS.ReadOnly = True
        Me.tb_identS.Size = New System.Drawing.Size(100, 22)
        Me.tb_identS.TabIndex = 2
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(7, 27)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(103, 15)
        Me.Label82.TabIndex = 1
        Me.Label82.Text = "Nombre / Razón"
        '
        'tb_nombreS
        '
        Me.tb_nombreS.Location = New System.Drawing.Point(113, 24)
        Me.tb_nombreS.Name = "tb_nombreS"
        Me.tb_nombreS.ReadOnly = True
        Me.tb_nombreS.Size = New System.Drawing.Size(100, 22)
        Me.tb_nombreS.TabIndex = 0
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.bt_cancelarC)
        Me.GroupBox20.Controls.Add(Me.bt_agregarCat)
        Me.GroupBox20.Controls.Add(Me.Label83)
        Me.GroupBox20.Controls.Add(Me.tb_nombreC)
        Me.GroupBox20.Location = New System.Drawing.Point(508, 60)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(341, 60)
        Me.GroupBox20.TabIndex = 6
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Detalles Categoría"
        '
        'bt_cancelarC
        '
        Me.bt_cancelarC.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cancelarC.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_cancelarC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_cancelarC.Location = New System.Drawing.Point(301, 21)
        Me.bt_cancelarC.Name = "bt_cancelarC"
        Me.bt_cancelarC.Size = New System.Drawing.Size(34, 29)
        Me.bt_cancelarC.TabIndex = 10038
        Me.bt_cancelarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarCat
        '
        Me.bt_agregarCat.BackColor = System.Drawing.Color.Transparent
        Me.bt_agregarCat.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_agregarCat.Image = Global.Tesis_Nueva.My.Resources.Resources.check_16x16
        Me.bt_agregarCat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCat.Location = New System.Drawing.Point(261, 21)
        Me.bt_agregarCat.Name = "bt_agregarCat"
        Me.bt_agregarCat.Size = New System.Drawing.Size(34, 29)
        Me.bt_agregarCat.TabIndex = 10037
        Me.bt_agregarCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_agregarCat.UseVisualStyleBackColor = False
        Me.bt_agregarCat.Visible = False
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(3, 27)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(56, 15)
        Me.Label83.TabIndex = 1
        Me.Label83.Text = "Nombre"
        '
        'tb_nombreC
        '
        Me.tb_nombreC.Location = New System.Drawing.Point(64, 24)
        Me.tb_nombreC.Name = "tb_nombreC"
        Me.tb_nombreC.ReadOnly = True
        Me.tb_nombreC.Size = New System.Drawing.Size(191, 22)
        Me.tb_nombreC.TabIndex = 0
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.bt_EliminarSubCategoria)
        Me.GroupBox17.Controls.Add(Me.bt_agregarSubCategoria)
        Me.GroupBox17.Controls.Add(Me.bt_ModificarSubCategoria)
        Me.GroupBox17.Controls.Add(Me.Label78)
        Me.GroupBox17.Controls.Add(Me.tb_busquedaS)
        Me.GroupBox17.Controls.Add(Me.lb_Subcategoria)
        Me.GroupBox17.Location = New System.Drawing.Point(237, 60)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(255, 312)
        Me.GroupBox17.TabIndex = 5
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Sub-Categoría"
        '
        'bt_EliminarSubCategoria
        '
        Me.bt_EliminarSubCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_EliminarSubCategoria.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_EliminarSubCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_EliminarSubCategoria.Location = New System.Drawing.Point(152, 273)
        Me.bt_EliminarSubCategoria.Name = "bt_EliminarSubCategoria"
        Me.bt_EliminarSubCategoria.Size = New System.Drawing.Size(34, 29)
        Me.bt_EliminarSubCategoria.TabIndex = 10011
        Me.bt_EliminarSubCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarSubCategoria
        '
        Me.bt_agregarSubCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregarSubCategoria.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarSubCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarSubCategoria.Location = New System.Drawing.Point(74, 273)
        Me.bt_agregarSubCategoria.Name = "bt_agregarSubCategoria"
        Me.bt_agregarSubCategoria.Size = New System.Drawing.Size(34, 29)
        Me.bt_agregarSubCategoria.TabIndex = 30
        Me.bt_agregarSubCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_ModificarSubCategoria
        '
        Me.bt_ModificarSubCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ModificarSubCategoria.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarSubCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarSubCategoria.Location = New System.Drawing.Point(114, 273)
        Me.bt_ModificarSubCategoria.Name = "bt_ModificarSubCategoria"
        Me.bt_ModificarSubCategoria.Size = New System.Drawing.Size(34, 29)
        Me.bt_ModificarSubCategoria.TabIndex = 10010
        Me.bt_ModificarSubCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(6, 24)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(66, 15)
        Me.Label78.TabIndex = 5
        Me.Label78.Text = "Búsqueda"
        '
        'tb_busquedaS
        '
        Me.tb_busquedaS.Location = New System.Drawing.Point(77, 21)
        Me.tb_busquedaS.Name = "tb_busquedaS"
        Me.tb_busquedaS.Size = New System.Drawing.Size(100, 22)
        Me.tb_busquedaS.TabIndex = 4
        '
        'lb_Subcategoria
        '
        Me.lb_Subcategoria.FormattingEnabled = True
        Me.lb_Subcategoria.ItemHeight = 15
        Me.lb_Subcategoria.Location = New System.Drawing.Point(8, 51)
        Me.lb_Subcategoria.Name = "lb_Subcategoria"
        Me.lb_Subcategoria.Size = New System.Drawing.Size(240, 214)
        Me.lb_Subcategoria.TabIndex = 0
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.bt_eliminarCategoria)
        Me.GroupBox18.Controls.Add(Me.bt_ModificarCategoria)
        Me.GroupBox18.Controls.Add(Me.bt_agregarCategoria)
        Me.GroupBox18.Controls.Add(Me.Label79)
        Me.GroupBox18.Controls.Add(Me.tb_busquedaC)
        Me.GroupBox18.Controls.Add(Me.lb_categoria)
        Me.GroupBox18.Location = New System.Drawing.Point(9, 60)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(212, 312)
        Me.GroupBox18.TabIndex = 4
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Categoría"
        '
        'bt_eliminarCategoria
        '
        Me.bt_eliminarCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminarCategoria.Image = Global.Tesis_Nueva.My.Resources.Resources.delete
        Me.bt_eliminarCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_eliminarCategoria.Location = New System.Drawing.Point(113, 276)
        Me.bt_eliminarCategoria.Name = "bt_eliminarCategoria"
        Me.bt_eliminarCategoria.Size = New System.Drawing.Size(34, 29)
        Me.bt_eliminarCategoria.TabIndex = 10009
        Me.bt_eliminarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_ModificarCategoria
        '
        Me.bt_ModificarCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ModificarCategoria.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_ModificarCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_ModificarCategoria.Location = New System.Drawing.Point(75, 276)
        Me.bt_ModificarCategoria.Name = "bt_ModificarCategoria"
        Me.bt_ModificarCategoria.Size = New System.Drawing.Size(34, 29)
        Me.bt_ModificarCategoria.TabIndex = 10008
        Me.bt_ModificarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bt_agregarCategoria
        '
        Me.bt_agregarCategoria.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregarCategoria.Image = Global.Tesis_Nueva.My.Resources.Resources.Add_16x161
        Me.bt_agregarCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_agregarCategoria.Location = New System.Drawing.Point(37, 276)
        Me.bt_agregarCategoria.Name = "bt_agregarCategoria"
        Me.bt_agregarCategoria.Size = New System.Drawing.Size(34, 29)
        Me.bt_agregarCategoria.TabIndex = 29
        Me.bt_agregarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(5, 27)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(66, 15)
        Me.Label79.TabIndex = 3
        Me.Label79.Text = "Búsqueda"
        '
        'tb_busquedaC
        '
        Me.tb_busquedaC.Location = New System.Drawing.Point(74, 24)
        Me.tb_busquedaC.Name = "tb_busquedaC"
        Me.tb_busquedaC.Size = New System.Drawing.Size(100, 22)
        Me.tb_busquedaC.TabIndex = 2
        '
        'lb_categoria
        '
        Me.lb_categoria.FormattingEnabled = True
        Me.lb_categoria.ItemHeight = 15
        Me.lb_categoria.Location = New System.Drawing.Point(7, 51)
        Me.lb_categoria.Name = "lb_categoria"
        Me.lb_categoria.Size = New System.Drawing.Size(197, 214)
        Me.lb_categoria.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(329, 193)
        Me.TreeView1.Name = "TreeView1"
        TreeNode3.Name = ""
        TreeNode3.Text = "IVA"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.TreeView1.Scrollable = False
        Me.TreeView1.Size = New System.Drawing.Size(76, 37)
        Me.TreeView1.TabIndex = 17
        '
        'bt_aplicar
        '
        Me.bt_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aplicar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aplicar.ForeColor = System.Drawing.Color.Black
        Me.bt_aplicar.Location = New System.Drawing.Point(507, 481)
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
        Me.bt_cancelar.Location = New System.Drawing.Point(403, 481)
        Me.bt_cancelar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 19
        Me.bt_cancelar.Text = "Cancelar"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_aceptar.ForeColor = System.Drawing.Color.Black
        Me.bt_aceptar.Location = New System.Drawing.Point(299, 481)
        Me.bt_aceptar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 18
        Me.bt_aceptar.Text = "Aceptar"
        '
        'Frm_Configuracion_Cobranzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(888, 516)
        Me.Controls.Add(Me.tab_cobranzas)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.bt_aplicar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Configuracion_Cobranzas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuaraciones Cobranzas"
        Me.tab_cobranzas.ResumeLayout(False)
        Me.tp_asociacion.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tp_ajustes.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.tp_egresos.ResumeLayout(False)
        Me.tp_egresos.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_cobranzas As System.Windows.Forms.TabControl
    Friend WithEvents tp_asociacion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tb_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents tp_ajustes As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents tb_montoAjustes As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents tp_egresos As System.Windows.Forms.TabPage
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelarS As System.Windows.Forms.Button
    Friend WithEvents bt_agregarS As System.Windows.Forms.Button
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents tb_obsS As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents tb_identS As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents tb_nombreS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_cancelarC As System.Windows.Forms.Button
    Friend WithEvents bt_agregarCat As System.Windows.Forms.Button
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents tb_nombreC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_EliminarSubCategoria As System.Windows.Forms.Button
    Friend WithEvents bt_agregarSubCategoria As System.Windows.Forms.Button
    Friend WithEvents bt_ModificarSubCategoria As System.Windows.Forms.Button
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents tb_busquedaS As System.Windows.Forms.TextBox
    Friend WithEvents lb_Subcategoria As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_eliminarCategoria As System.Windows.Forms.Button
    Friend WithEvents bt_ModificarCategoria As System.Windows.Forms.Button
    Friend WithEvents bt_agregarCategoria As System.Windows.Forms.Button
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents tb_busquedaC As System.Windows.Forms.TextBox
    Friend WithEvents lb_categoria As System.Windows.Forms.ListBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents bt_aplicar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
End Class
