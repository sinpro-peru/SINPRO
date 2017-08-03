Imports System.Configuration

Public Class Frm_Login
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_aceptar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
    Friend WithEvents tb_login As System.Windows.Forms.TextBox
    Friend WithEvents tb_password As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkDominio As System.Windows.Forms.LinkLabel
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents tb_dominio As System.Windows.Forms.TextBox
    Friend WithEvents LabeDominio As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_sesion As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bt_aceptar = New System.Windows.Forms.Button
        Me.bt_cancelar = New System.Windows.Forms.Button
        Me.tb_login = New System.Windows.Forms.TextBox
        Me.tb_password = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.cb_tipo = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LinkDominio = New System.Windows.Forms.LinkLabel
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.tb_dominio = New System.Windows.Forms.TextBox
        Me.LabeDominio = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cb_sesion = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Login:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Password:"
        '
        'bt_aceptar
        '
        Me.bt_aceptar.BackColor = System.Drawing.Color.White
        Me.bt_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_aceptar.Location = New System.Drawing.Point(262, 252)
        Me.bt_aceptar.Name = "bt_aceptar"
        Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aceptar.TabIndex = 4
        Me.bt_aceptar.Text = "Aceptar"
        Me.bt_aceptar.UseVisualStyleBackColor = False
        '
        'bt_cancelar
        '
        Me.bt_cancelar.BackColor = System.Drawing.Color.White
        Me.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Location = New System.Drawing.Point(350, 252)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 5
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = False
        '
        'tb_login
        '
        Me.tb_login.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_login.Location = New System.Drawing.Point(319, 26)
        Me.tb_login.Name = "tb_login"
        Me.tb_login.Size = New System.Drawing.Size(123, 21)
        Me.tb_login.TabIndex = 0
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.Location = New System.Drawing.Point(319, 58)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(123, 21)
        Me.tb_password.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(231, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 72)
        Me.Panel1.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 240)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'cb_tipo
        '
        Me.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Local", "Remoto"})
        Me.cb_tipo.Location = New System.Drawing.Point(43, 18)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(121, 22)
        Me.cb_tipo.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_tipo)
        Me.GroupBox1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(244, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de acceso:"
        '
        'LinkDominio
        '
        Me.LinkDominio.AutoSize = True
        Me.LinkDominio.LinkColor = System.Drawing.Color.SteelBlue
        Me.LinkDominio.Location = New System.Drawing.Point(238, 219)
        Me.LinkDominio.Name = "LinkDominio"
        Me.LinkDominio.Size = New System.Drawing.Size(56, 14)
        Me.LinkDominio.TabIndex = 23
        Me.LinkDominio.TabStop = True
        Me.LinkDominio.Text = "Dominio:"
        Me.LinkDominio.Visible = False
        '
        'bt_modificar
        '
        Me.bt_modificar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.bt_modificar.Image = Global.Tesis_Nueva.My.Resources.Resources.Update16x16
        Me.bt_modificar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_modificar.Location = New System.Drawing.Point(417, 214)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(25, 26)
        Me.bt_modificar.TabIndex = 10047
        Me.bt_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_modificar.Visible = False
        '
        'tb_dominio
        '
        Me.tb_dominio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dominio.Location = New System.Drawing.Point(295, 214)
        Me.tb_dominio.Name = "tb_dominio"
        Me.tb_dominio.Size = New System.Drawing.Size(115, 22)
        Me.tb_dominio.TabIndex = 10048
        Me.tb_dominio.Visible = False
        '
        'LabeDominio
        '
        Me.LabeDominio.AutoSize = True
        Me.LabeDominio.Location = New System.Drawing.Point(296, 219)
        Me.LabeDominio.Name = "LabeDominio"
        Me.LabeDominio.Size = New System.Drawing.Size(53, 14)
        Me.LabeDominio.TabIndex = 10049
        Me.LabeDominio.Text = "Dominio"
        Me.LabeDominio.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_sesion)
        Me.GroupBox2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conectarse a:"
        '
        'cb_sesion
        '
        Me.cb_sesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sesion.FormattingEnabled = True
        Me.cb_sesion.Items.AddRange(New Object() {"AGSA", "Mil26"})
        Me.cb_sesion.Location = New System.Drawing.Point(18, 18)
        Me.cb_sesion.Name = "cb_sesion"
        Me.cb_sesion.Size = New System.Drawing.Size(166, 22)
        Me.cb_sesion.TabIndex = 3
        '
        'Frm_Login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bt_cancelar
        Me.ClientSize = New System.Drawing.Size(465, 281)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabeDominio)
        Me.Controls.Add(Me.tb_dominio)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.LinkDominio)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_login)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_aceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticación de Usuario"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public tipo As Integer
    Public user As String = ""
    Public conexion As Integer
    Dim conectado As Boolean = False
    Dim eliminado As Boolean = False


    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If cb_tipo.Text = "Local" Then

            If My.Settings.Empresa <> 0 Then

                If cb_sesion.Text = "AGSA" Then
                    My.Settings.Empresa = 2
                ElseIf cb_sesion.Text = "Comer. BRWME" Then
                    My.Settings.Empresa = 1
                ElseIf cb_sesion.Text = "Mil26" Then
                    My.Settings.Empresa = 3
                ElseIf cb_sesion.Text = "Dist. BRWME" Then
                    My.Settings.Empresa = 4
                ElseIf cb_sesion.Text = "DANGER" Then
                    My.Settings.Empresa = 5
                ElseIf cb_sesion.Text = "CONAVE" Then
                    My.Settings.Empresa = 6
                ElseIf cb_sesion.Text = "VENPER" Then
                    My.Settings.Empresa = 7
                ElseIf cb_sesion.Text = "Perú" Then
                    My.Settings.Empresa = 8
                End If

            End If

            Try

                My.Settings.UserLogin = tb_login.Text.ToLower

                If My.Settings.Empresa = 2 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "AGSA"
                    My.Settings.NombreEmpresaLargo = "Importadora Autopartes Global, S.A."
                    Tesis_Nueva.My.Settings.CabezeraNC = True
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = True
                    Tesis_Nueva.My.Settings.PedidosExpress = True

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.1.3;Initial Catalog=AGSA;User ID=HugoEstrada; Password=Hugo16096946"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.1.3;Initial Catalog=AGSA;User ID=HugoEstrada; Password=Hugo16096946"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.1.3;Initial Catalog=AGSA;User ID=HugoEstrada; Password=Hugo16096946"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                    My.Settings.EmailEnvio = "no-responder@autopartesglobal.com"
                    My.Settings.EmailPass = "noresponder00"
                    My.Settings.EmailSMTPPort = 587
                    My.Settings.EmailSMTP = "smtp.gmail.com"

                ElseIf My.Settings.Empresa = 3 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "Mil26"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = True

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.1.11;Initial Catalog=Mil26;User ID=Administrador; Password=Bahamut14"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.1.11;Initial Catalog=Mil26;User ID=Administrador; Password=Bahamut14"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.1.11;Initial Catalog=Mil26;User ID=Administrador; Password=Bahamut14"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "FACTURAS"

                ElseIf My.Settings.Empresa = 1 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "C. BRWME"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=BRWME;User ID=HugoEstrada; Password=Hugo16096946"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.0.2;Initial Catalog=BRWME;User ID=HugoEstrada; Password=Hugo16096946"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.0.2;Initial Catalog=BRWME;User ID=HugoEstrada; Password=Hugo16096946"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 4 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "D. BRWME"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=BRWME_D;User ID=HugoEstrada; Password=Hugo16096946"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.0.2;Initial Catalog=BRWME_D;User ID=HugoEstrada; Password=Hugo16096946"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.0.2;Initial Catalog=BRWME_D;User ID=HugoEstrada; Password=Hugo16096946"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 5 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "DANGER"
                    Tesis_Nueva.My.Settings.CabezeraNC = True
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = True

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.10.4;Initial Catalog=DANGER;User ID=SINPRO; Password=SINPRO1234"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.10.4;Initial Catalog=DANGER;User ID=SINPRO; Password=SINPRO1234"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.10.4;Initial Catalog=DANGER;User ID=SINPRO; Password=SINPRO1234"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP PSC 1400 series en Servidor"
                    Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                ElseIf My.Settings.Empresa = 6 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "CONAVE"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=CONAVE;User ID=HugoEstrada; Password=Hugo16096946"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.0.2;Initial Catalog=CONAVE;User ID=HugoEstrada; Password=Hugo16096946"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.0.2;Initial Catalog=CONAVE;User ID=HugoEstrada; Password=Hugo16096946"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 7 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "VENPER"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=VENPER;User ID=HugoEstrada; Password=Hugo16096946"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.0.2;Initial Catalog=VENPER;User ID=HugoEstrada; Password=Hugo16096946"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.0.2;Initial Catalog=VENPER;User ID=HugoEstrada; Password=Hugo16096946"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 8 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "Perú"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=192.168.1.133;Initial Catalog=SINPRO;User ID=sinpro; Password=LimaPeru2017"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.1.133;Initial Catalog=SINPRO;User ID=sinpro; Password=LimaPeru2017"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.1.133;Initial Catalog=SINPRO;User ID=sinpro; Password=LimaPeru2017"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 0 Then

                    If cb_sesion.Text = "AGSA" Then

                        My.Settings.Empresa = 2
                        Tesis_Nueva.My.Settings.CabezeraNC = True
                        Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                        Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                        Tesis_Nueva.My.Settings.CodigoFabricaFact = True
                        Tesis_Nueva.My.Settings.PedidosExpress = True

                    ElseIf cb_sesion.Text = "Comer. BRWME" Then

                        My.Settings.Empresa = 1
                        Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                        Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                        Tesis_Nueva.My.Settings.CabezeraNC = False
                        Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                        Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                        Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                        Tesis_Nueva.My.Settings.PedidosExpress = False

                    ElseIf cb_sesion.Text = "Mil26" Then

                        My.Settings.Empresa = 3
                        Tesis_Nueva.My.Settings.CabezeraNC = True
                        Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                        Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                        Tesis_Nueva.My.Settings.CodigoFabricaFact = True
                        Tesis_Nueva.My.Settings.PedidosExpress = True

                    ElseIf cb_sesion.Text = "Dist. BRWME" Then

                        My.Settings.Empresa = 4
                        Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                        Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                        Tesis_Nueva.My.Settings.CabezeraNC = False
                        Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                        Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                        Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                        Tesis_Nueva.My.Settings.PedidosExpress = False

                    ElseIf cb_sesion.Text = "DANGER" Then

                        My.Settings.Empresa = 5
                        Tesis_Nueva.My.Settings.CabezeraNC = True
                        Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                        Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                        Tesis_Nueva.My.Settings.CodigoFabricaFact = True

                    ElseIf cb_sesion.Text = "CONAVE" Then

                        My.Settings.Empresa = 6
                        Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                        Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                        Tesis_Nueva.My.Settings.CabezeraNC = False
                        Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                        Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                        Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                        Tesis_Nueva.My.Settings.PedidosExpress = False

                    ElseIf cb_sesion.Text = "VENPER" Then

                        My.Settings.Empresa = 7
                        Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                        Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                        Tesis_Nueva.My.Settings.CabezeraNC = False
                        Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                        Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                        Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                        Tesis_Nueva.My.Settings.PedidosExpress = False

                    End If


                    My.Settings.NombreEmpresaLargo = "Nombre Empresa Largo"
                    My.Settings.RIFEmpresa = "RIF"

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        'Frm_Principal.conex.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=" + cb_sesion.Text + "; User ID=larry.magallanes; Password=lo200606650mc"
                        'Frm_Principal.conex.ConnectionString = "Data Source=192.168.1.2;Initial Catalog=" + cb_sesion.Text + "; User ID=larry.magallanes; Password=lo200606650mc"
                        'Frm_Principal.conex.ConnectionString = "Data Source=LARRY-LAPTOP;Initial Catalog=" + cb_sesion.Text + "; User ID=larrymagallanes; Password=lo200606650mc"
                        Frm_Principal.conex.ConnectionString = "Data Source=globaltechsolutions.no-ip.org,9433;Initial Catalog=" + cb_sesion.Text + "; User ID=lmagallanes; Password=200606650"
                    End If

                    'Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.0.2;Initial Catalog=" + cb_sesion.Text + "; User ID=larry.magallanes; Password=lo200606650mc"
                    'Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=192.168.1.2;Initial Catalog=" + cb_sesion.Text + "; User ID=larry.magallanes; Password=lo200606650mc"
                    'Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=LARRY-LAPTOP;Initial Catalog=" + cb_sesion.Text + "; User ID=larrymagallanes; Password=lo200606650mc"
                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=globaltechsolutions.no-ip.org,9433;Initial Catalog=" + cb_sesion.Text + "; User ID=lmagallanes; Password=200606650"

                    'Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.0.2;Initial Catalog=" + cb_sesion.Text + "; User ID=larry.magallanes; Password=lo200606650mc"
                    'Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=192.168.1.2;Initial Catalog=" + cb_sesion.Text + "; User ID=larry.magallanes; Password=lo200606650mc"
                    'Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=LARRY-LAPTOP;Initial Catalog=" + cb_sesion.Text + ";User ID=larrymagallanes; Password=lo200606650mc"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=globaltechsolutions.no-ip.org,9433;Initial Catalog=" + cb_sesion.Text + "; User ID=lmagallanes; Password=200606650"

                    My.Settings.EmailEnvio = "no-responder@autopartesglobal.com"
                    My.Settings.EmailPass = "noresponder00"
                    My.Settings.EmailSMTPPort = 587
                    My.Settings.EmailSMTP = "smtp.gmail.com"

                End If


                If conectado = False Then

                    Frm_Principal.conex.Open()

                End If

            Catch ex As Exception

                If Not Frm_Principal.conex.State = ConnectionState.Open Then

                    Frm_Principal.NotifyIcon1.ShowBalloonTip(5000, "SINPRO", "Error de conexión con el servidor, es posible que la base de datos no esté disponible", ToolTipIcon.Error)
                    Frm_Principal.conex.Close()

                End If

            End Try

        ElseIf cb_tipo.Text = "Remoto" Then

            'My.Settings.Empresa = 0

            If My.Settings.Empresa <> 0 Then

                If cb_sesion.Text = "AGSA" Then

                    My.Settings.Empresa = 2
                    Tesis_Nueva.My.Settings.CabezeraNC = True
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = True
                    Tesis_Nueva.My.Settings.PedidosExpress = True

                ElseIf cb_sesion.Text = "Comer. BRWME" Then

                    My.Settings.Empresa = 1
                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                ElseIf cb_sesion.Text = "Mil26" Then

                    My.Settings.Empresa = 3
                    Tesis_Nueva.My.Settings.CabezeraNC = True
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = True
                    Tesis_Nueva.My.Settings.PedidosExpress = True

                ElseIf cb_sesion.Text = "Dist. BRWME" Then

                    My.Settings.Empresa = 4
                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                ElseIf cb_sesion.Text = "DANGER" Then

                    My.Settings.Empresa = 5
                    Tesis_Nueva.My.Settings.CabezeraNC = True
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = True

                ElseIf cb_sesion.Text = "CONAVE" Then

                    My.Settings.Empresa = 6
                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                ElseIf cb_sesion.Text = "VENPER" Then

                    My.Settings.Empresa = 7
                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                ElseIf cb_sesion.Text = "Perú" Then

                    My.Settings.Empresa = 8
                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "Epson LX-300+"

                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False
                    Tesis_Nueva.My.Settings.PedidosExpress = False

                End If

            End If

            conexion = 0

            My.Settings.UserLogin = tb_login.Text.ToLower
            Dim texto As String = ""
            'Datos.RetornaDominio(texto)

            If Frm_Principal.conex.State = ConnectionState.Closed Then

                If My.Settings.Empresa = 1 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "C. BRWME (Remoto)"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=BRWME; User ID=web; Password=Miami006"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=BRWME; User ID=web; Password=Miami006"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=BRWME; User ID=web; Password=Miami006"

                ElseIf My.Settings.Empresa = 2 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "AGSA (Remoto)"
                    My.Settings.NombreEmpresaLargo = "Importadora Autopartes Global, S.A."
                    Tesis_Nueva.My.Settings.CabezeraNC = True
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = True

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:agsamil26.dyndns.ws;Initial Catalog=AGSA; User ID=HugoEstrada; Password=Hugo16096946"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:agsamil26.dyndns.ws;Initial Catalog=AGSA; User ID=HugoEstrada; Password=Hugo16096946"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:agsamil26.dyndns.ws;Initial Catalog=AGSA; User ID=HugoEstrada; Password=Hugo16096946"

                    My.Settings.EmailEnvio = "no-responder@autopartesglobal.com"
                    My.Settings.EmailPass = "noresponder00"
                    My.Settings.EmailSMTPPort = 587
                    My.Settings.EmailSMTP = "smtp.gmail.com"

                ElseIf My.Settings.Empresa = 3 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "Mil26 (Remoto)"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:agsamil26.dyndns.ws;Initial Catalog=Mil26; User ID=Administrador; Password=Bahamut14"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:agsamil26.dyndns.ws;Initial Catalog=Mil26; User ID=Administrador; Password=Bahamut14"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:agsamil26.dyndns.ws;Initial Catalog=Mil26; User ID=Administrador; Password=Bahamut14"

                ElseIf My.Settings.Empresa = 4 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "D. BRWME (Remoto)"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=BRWME_D; User ID=web; Password=Miami006"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=BRWME_D; User ID=web; Password=Miami006"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=BRWME_D; User ID=web; Password=Miami006"

                ElseIf My.Settings.Empresa = 5 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "DANGER (Remoto)"
                    Tesis_Nueva.My.Settings.CabezeraNC = True
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = False
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = True

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:danger22.dyndns.org;Initial Catalog=DANGER;User ID=SINPRO; Password=SINPRO1234"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:danger22.dyndns.org;Initial Catalog=DANGER;User ID=SINPRO; Password=SINPRO1234"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:danger22.dyndns.org;Initial Catalog=DANGER;User ID=SINPRO; Password=SINPRO1234"

                ElseIf My.Settings.Empresa = 6 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "CONAVE (Remoto)"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=CONAVE; User ID=web; Password=Miami006"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=CONAVE; User ID=web; Password=Miami006"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=CONAVE; User ID=web; Password=Miami006"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 7 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "VENPER (Remoto)"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=VENPER; User ID=web; Password=Miami006"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=VENPER; User ID=web; Password=Miami006"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:brwmesa.dyndns.org;Initial Catalog=VENPER; User ID=web; Password=Miami006"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 8 Then

                    Tesis_Nueva.My.Settings.NombreEmpresa = "Perú (Remoto)"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=tcp:brwmesaperu.dyndns.org;Initial Catalog=SINPRO; User ID=web; Password=LimaPeru2017"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=tcp:brwmesaperu.dyndns.org;Initial Catalog=SINPRO; User ID=web; Password=LimaPeru2017"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=tcp:brwmesaperu.dyndns.org;Initial Catalog=SINPRO; User ID=web; Password=LimaPeru2017"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                ElseIf My.Settings.Empresa = 0 Then

                    If cb_sesion.Text = "AGSA" Then
                        My.Settings.Empresa = 2
                    ElseIf cb_sesion.Text = "Comer. BRWME" Then
                        My.Settings.Empresa = 1
                    ElseIf cb_sesion.Text = "Mil26" Then
                        My.Settings.Empresa = 3
                    ElseIf cb_sesion.Text = "Dist. BRWME" Then
                        My.Settings.Empresa = 4
                    ElseIf cb_sesion.Text = "DANGER" Then
                        My.Settings.Empresa = 5
                    ElseIf cb_sesion.Text = "CONAVE" Then
                        My.Settings.Empresa = 6
                    ElseIf cb_sesion.Text = "VENPER" Then
                        My.Settings.Empresa = 7
                    End If

                    Tesis_Nueva.My.Settings.NombreEmpresa = "TEST"
                    Tesis_Nueva.My.Settings.CabezeraNC = False
                    Tesis_Nueva.My.Settings.Nro_Control_Editable = True
                    Tesis_Nueva.My.Settings.Nro_Imp_Visible = True
                    Tesis_Nueva.My.Settings.CodigoFabricaFact = False

                    If Not Frm_Principal.conex.State = ConnectionState.Open Then
                        Frm_Principal.conex.ConnectionString = "Data Source=globaltechsolutions.no-ip.org,9433;Initial Catalog=" + cb_sesion.Text + "; User ID=lmagallanes; Password=200606650"
                    End If

                    Tesis_Nueva.My.Settings.MELConnectionString = "Data Source=globaltechsolutions.no-ip.org,9433;Initial Catalog=" + cb_sesion.Text + "; User ID=lmagallanes; Password=200606650"
                    Tesis_Nueva.My.Settings.MELPRUEBAConnectionString = "Data Source=globaltechsolutions.no-ip.org,9433;Initial Catalog=" + cb_sesion.Text + "; User ID=lmagallanes; Password=200606650"

                    Tesis_Nueva.My.Settings.DocsPrinter = "HP LaserJet Professional P1606dn"
                    Tesis_Nueva.My.Settings.FactPrinter = "EPSON LX-300+/II (Copiar 1)"

                End If

                Frm_Principal.conex.Open()

            End If


        End If


        Dim sw As Boolean = False
        If Me.tb_login.Text = "" Or Me.tb_password.Text = "" Or Me.cb_tipo.Text = "" Then

            MsgBox("Debe Ingresar un Login y Password", MsgBoxStyle.Critical)

            If tb_login.Text = "" Then
                tb_login.Focus()
            ElseIf tb_password.Text = "" Then
                tb_password.Focus()
            End If

            Frm_Principal.conex.Close()

        Else

            Dim conex2 As New SqlClient.SqlConnection
            conex2.ConnectionString = Frm_Principal.conex.ConnectionString

            DatosLogin.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
            Datos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)

            DatosLogin.verifica(Me.tb_login.Text, Me.tb_password.Text, sw, tipo, eliminado, user)

            If sw = True Then

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
                DatosNotaCredito.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosComprasProveedores.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosConfiguracion.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosGuiaTransporte.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosBanco.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosComisiones.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosMarcaModelo.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAlmacenes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAjustes.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAnalisisPedido.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAjustesPorNC.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAnalisisCobranza.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosUsuarios.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosTipoUsurio.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAsignacionFlete.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosCalculoCostos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAgregarAPedido.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosCargarCompras.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosPedidoCliente.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosComprasCargadas.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosExportarAExcel.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosMovimientos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosDSS.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosAjusteSaldo.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosCompetencia.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosMensaje.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand, tb_login.Text)
                DatosGastos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosInventario.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)
                DatosCorreos.inicializar(Frm_Principal.conex, Frm_Principal.Sqlcommand)

                Frm_Principal.esconderMenuItem(tipo)
                Frm_Principal.user_l = tb_login.Text
                Frm_Principal.user_n = user
                Frm_Principal.Show()
                Me.Hide()

            Else

                MsgBox("Login o Password Incorrecto")
                Frm_Principal.conex.Close()
                tb_login.Focus()
                tb_login.SelectAll()
                Frm_Principal.conex.Close()

            End If
        End If
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        End
    End Sub

    Private Sub Frm_Login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.Empresa = 1 Then
            cb_sesion.Items.Clear()
            cb_sesion.Items.Add("Comer. BRWME")
            cb_sesion.Items.Add("Dist. BRWME")
            cb_sesion.Items.Add("CONAVE")
            cb_sesion.Items.Add("DANGER")
            cb_sesion.Items.Add("VENPER")
            cb_sesion.SelectedIndex = 0
        ElseIf My.Settings.Empresa = 2 Then
            cb_sesion.Items.Clear()
            cb_sesion.Items.Add("AGSA")
            cb_sesion.Items.Add("Mil26")
            cb_sesion.Items.Add("Pruebas Web_AGSA")
            cb_sesion.SelectedIndex = 0
        ElseIf My.Settings.Empresa = 3 Then
            cb_sesion.Items.Clear()
            cb_sesion.Items.Add("Mil26")
            cb_sesion.Items.Add("AGSA")
            cb_sesion.SelectedIndex = 0
        ElseIf My.Settings.Empresa = 5 Then
            cb_sesion.Items.Clear()
            cb_sesion.Items.Add("DANGER")
            cb_sesion.Items.Add("Comer. BRWME")
            cb_sesion.Items.Add("Dist. BRWME")
            cb_sesion.Items.Add("CONAVE")
            cb_sesion.SelectedIndex = 0
        ElseIf My.Settings.Empresa = 8 Then
            cb_sesion.Items.Clear()
            cb_sesion.Items.Add("Perú")
            cb_sesion.SelectedIndex = 0
        Else

            cb_sesion.Items.Clear()

            cb_sesion.Items.Add("AGSA")
            cb_sesion.Items.Add("BRWME")
            cb_sesion.Items.Add("BRWME_D")
            cb_sesion.Items.Add("CONAVE")
            cb_sesion.Items.Add("DANGER")
            cb_sesion.Items.Add("Mil26")
            cb_sesion.Items.Add("VENPER")

            cb_sesion.SelectedIndex = 0

        End If


        cb_tipo.SelectedIndex = 0
        Me.tb_login.Focus()

    End Sub

    Private Sub LinkDominio_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkDominio.LinkClicked
        LabeDominio.Visible = False
        tb_dominio.Text = LabeDominio.Text
        tb_dominio.Visible = True
        bt_modificar.Visible = True

    End Sub

    Private Sub cb_tipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then

            cb_sesion.Focus()

        End If
    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tipo.SelectedIndexChanged
        If cb_tipo.SelectedIndex = 1 Then
            'Dim texto As String = ""
            'Datos.RetornaDominio(texto)
            'LabeDominio.Text = texto
            'LinkDominio.Visible = True
            'LabeDominio.Visible = True
        Else
            LinkDominio.Visible = False
            LabeDominio.Visible = False
            tb_dominio.Visible = False
            bt_modificar.Visible = False
        End If
    End Sub

    Private Sub tb_login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_login.KeyDown
        If e.KeyCode = Keys.Enter Then

            tb_password.Focus()

        End If

    End Sub

    Private Sub tb_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_password.KeyDown
        If e.KeyCode = Keys.Enter Then

            cb_tipo.Focus()

        End If
    End Sub

    Private Sub cb_sesion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_sesion.KeyDown
        If e.KeyCode = Keys.Enter Then

            bt_aceptar.Focus()

        End If
    End Sub

End Class
