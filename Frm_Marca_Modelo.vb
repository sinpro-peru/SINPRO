Public Class Frm_Marca_Modelo
    Dim catalogo As Boolean = False
    Dim w As Boolean
    Dim e As Boolean
    Private Sub Frm_Marca_Modelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.sp_consultaCatalogo2' table. You can move, or remove it, as needed.
        Me.Sp_consultaCatalogo2TableAdapter.Fill(Me.MELDataSet.sp_consultaCatalogo2)
        Try
            Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
            DatosMarcaModelo.llenarComboAno(Cbac_Ano)
            If DGV_Marcas.SelectedRows.Count > 0 Then
                DatosMarcaModelo.llenarComboModelos(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value, Cbac_Modelo)
            End If
            DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
            DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
            DatosMarcaModelo.llenarComboVersion(Cbac_Version)
            DGV_Marcas.ClearSelection()
            Label5.Text = DGV_Marcas.Rows.Count
            DomainUpDown2.SelectedIndex = 0

            If w = False Then
                Me.bt_nuevo.Visible = False
                Me.bt_eliminar.Visible = False
                Me.bt_modificar.Visible = False
                Me.bt_reporte.Visible = False
            End If

            TextBox1.Focus()

        Catch ex As Exception
            MsgBox("Error cargando marcas", MsgBoxStyle.Critical, "SINPRO")
        End Try

    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Sub DGV_Marcas_Selection_Changed(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_Marcas.KeyDown, DGV_Marcas.KeyUp, DGV_Marcas.CellClick

        Try
            DGV_MarcaCatalogo.ClearSelection()
            Dim Marca As String = ""
            If DGV_Marcas.SelectedRows.Count > 0 Then
                Marca = Me.DGV_Marcas.SelectedRows(0).Cells(0).Value
            End If

            LimpiarDatosModelo()

            If DGV_Marcas.SelectedRows.Count > 0 Then
                DatosMarcaModelo.llenarModelos(Marca, DGV_MarcaModelo)
            End If

            Label9.Text = DGV_MarcaModelo.RowCount
            If DGV_Marcas.SelectedRows.Count > 0 Then
                tb_foto.Text = DatosMarcaModelo.LlenarLogo(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString)
            End If

            '            DGV_MarcaCatalogo.Rows.Clear()
            If catalogo Then
                GroupBox2.Visible = False
                gb_catalogo.Visible = True
                DGV_MarcaCatalogo.Visible = True
                If DGV_Marcas.SelectedRows.Count > 0 Then
                    'DatosMarcaModelo.ConsultaCatalogoMarca(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, DGV_MarcaCatalogo)
                    CrearWhere()
                    DGV_MarcaCatalogo.Select()
                    DGV_Marcas.Select()
                End If
            Else
                GroupBox2.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is Me.bt_nuevo Then
            GroupBox2.Visible = True
            GroupBox2.Enabled = True
            tb_nombre.Clear()
            ToolBar1.Enabled = False
            catalogo = False
            tb_nombre.Visible = True
            Lbl_Nombre.Visible = True
            LblLogo.Visible = True
            tb_foto.Visible = True
            bt_foto.Visible = True
            GroupBox2.Visible = True
            Button2.Visible = False
            bt_EliminarModelo.Visible = False
            'GroupBox2.Enabled = False
            LimpiarDatosModelo()
            DGV_MarcaModelo.Rows.Clear()
            tb_nombre.Focus()


            Bt_ModificarModelo.Visible = False
            tb_foto.Clear()

            DatosMarcaModelo.llenarComboAno(Cbac_Ano)
            Cbac_Modelo.Items.Add("Nuevo")
            DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
            DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
            DatosMarcaModelo.llenarComboVersion(Cbac_Version)
            bt_LimpiarLogo.Visible = True
            bt_LimpiarFoto.Visible = False
            Bt_FinalizarModelo.Enabled = True
            Bt_FinalizarModelo.Visible = True
            bt_cancelar.Enabled = True
            bt_cancelar.Visible = True
            Bt_FinalizarModelo.Location = New System.Drawing.Point(618, 519)
            bt_cancelar.Location = New System.Drawing.Point(704, 519)

        ElseIf e.Button Is Me.bt_modificar Then
            If DGV_Marcas.SelectedRows.Count > 0 Then

                Bt_FinalizarModelo.Location = New System.Drawing.Point(731, 519)
                bt_cancelar.Location = New System.Drawing.Point(817, 519)
                TextBox1.Enabled = False
                DGV_Marcas.Enabled = False
                ToolBar1.Enabled = False
                catalogo = False
                gb_catalogo.Visible = False
                GroupBox2.Visible = True
                LblModelo.Visible = True
                LblMotor.Visible = True
                LblObs.Visible = True
                LblAno.Visible = True
                LblVersion.Visible = True
                LblPuertas.Visible = True
                Cbac_Ano.Visible = True
                Cbac_Modelo.Visible = True
                Cbac_Motor.Visible = True
                Cbac_Puertas.Visible = True
                Cbac_Version.Visible = True
                Tb_Obs.Visible = True
                GroupBox2.Enabled = True
                Label11.Visible = True
                Button1.Visible = True
                TextBox7.Visible = True
                bt_EliminarModelo.Visible = True
                Button2.Visible = True
                LblLogo.Visible = True
                tb_foto.Visible = True
                bt_foto.Visible = True
                tb_nombre.Visible = True
                bt_cancelar.Visible = True
                Bt_FinalizarModelo.Visible = True
                Bt_ModificarModelo.Visible = True
                DatosMarcaModelo.llenarComboAno(Cbac_Ano)
                If Label5.Text = "0" Then
                    MsgBox("Debe seleccionar un modelo", MsgBoxStyle.Critical)
                    TextBox1.Clear()
                    TextBox1.Enabled = True
                    DGV_Marcas.Enabled = True
                    ToolBar1.Enabled = True
                    Label11.Visible = False
                    Button1.Visible = False
                    TextBox7.Visible = False
                    bt_EliminarModelo.Visible = False
                    Button2.Visible = False
                    LblLogo.Visible = False
                    tb_foto.Visible = False
                    bt_foto.Visible = False
                    tb_nombre.Visible = False
                    bt_cancelar.Visible = False
                    Bt_FinalizarModelo.Visible = False
                    Bt_ModificarModelo.Visible = False
                    bt_LimpiarFoto.Visible = False
                    bt_LimpiarLogo.Visible = False
                    tb_foto.Clear()
                    TextBox7.Clear()
                Else
                    DatosMarcaModelo.llenarComboModelos(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value, Cbac_Modelo)
                    TextBox1.Text = DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString()
                End If
                DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
                DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
                DatosMarcaModelo.llenarComboVersion(Cbac_Version)
                bt_LimpiarLogo.Visible = True
                bt_LimpiarFoto.Visible = True
                Lbl_Nombre.Visible = True
                tb_nombre.Text = Me.DGV_Marcas.SelectedRows(0).Cells(0).Value
                tb_nombre.Focus()
                tb_nombre.SelectAll()
            Else
                MsgBox("Debe seleccionar una marca para modificarla", MsgBoxStyle.Exclamation, "SINPRO")
            End If
        ElseIf e.Button Is Me.bt_salir Then

            Me.Close()

        ElseIf e.Button Is Me.bt_eliminar Then

            catalogo = False
            If Label5.Text = "0" Then
                MsgBox("Debe seleccionar una marca", MsgBoxStyle.Critical)
            Else
                If DGV_MarcaModelo.Rows.Count > 0 Then
                    Dim a As Integer = MsgBox("La marca posee modelos asociados! Desea Continuar?", MsgBoxStyle.YesNo)
                    If a = vbYes Then
                        DatosMarcaModelo.EliminarMarca(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString)
                    End If
                    DGV_MarcaModelo.Rows.Clear()
                ElseIf DGV_MarcaModelo.Rows.Count = 0 Then
                    DatosMarcaModelo.EliminarMarca(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString)
                End If
            End If
            LimpiarDatosModelo()
            Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
            DatosMarcaModelo.llenarModelos(DGV_Marcas.SelectedCells.Item(0).Value.ToString, DGV_MarcaModelo)

            Cbac_Ano.Items.Add("Nuevo")
            Cbac_Modelo.Items.Add("Nuevo")
            Cbac_Motor.Items.Add("Nuevo")
            Cbac_Puertas.Items.Add("Nuevo")
            Cbac_Version.Items.Add("Nuevo")
            PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
            Label5.Text = DGV_Marcas.Rows.Count

        ElseIf e.Button Is Me.bt_reporte Then

            If DGV_Marcas.SelectedRows.Count > 0 Then

                If chk_exist.Checked = False Then
                    chk_exist.Checked = True
                End If

                Sp_consultaCatalogo2TableAdapter.Fill(Me.MELDataSet.sp_consultaCatalogo2)
                CrearWhere()

                If DGV_MarcaModelo.SelectedRows.Count > 0 Then
                    catalogo = True
                    gb_catalogo.Visible = True
                    DGV_MarcaCatalogo.Visible = True
                    GroupBox2.Visible = False
                    DGV_MarcaCatalogo.Select()
                    'DatosMarcaModelo.ConsultaCatalogo(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, DGV_MarcaModelo.SelectedRows(0).Cells(0).Value, DGV_MarcaModelo.SelectedRows(0).Cells(1).Value, DGV_MarcaModelo.SelectedRows(0).Cells(3).Value, DGV_MarcaModelo.SelectedRows(0).Cells(2).Value, DGV_MarcaModelo.SelectedRows(0).Cells(4).Value, DGV_MarcaCatalogo)
                    Label7.Text = DGV_MarcaCatalogo.RowCount
                Else
                    catalogo = True
                    gb_catalogo.Visible = True
                    DGV_MarcaCatalogo.Visible = True
                    GroupBox2.Visible = False
                    DGV_MarcaCatalogo.Visible = True
                    DGV_Marcas.Select()
                    'DatosMarcaModelo.ConsultaCatalogoMarca(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, DGV_MarcaCatalogo)
                    Label7.Text = DGV_MarcaCatalogo.RowCount
                End If

                DGV_MarcaCatalogo.ClearSelection()

            Else

                MsgBox("Debe seleccionar una marca", MsgBoxStyle.Critical)

            End If

        End If

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        LimpiarDatosModelo()
        LblLogo.Visible = False
        tb_foto.Visible = False
        bt_foto.Visible = False
        Label11.Visible = False
        Button1.Visible = False
        Lbl_Nombre.Visible = False
        tb_nombre.Visible = False
        GroupBox2.Enabled = False
        bt_EliminarModelo.Visible = False
        Button2.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        Bt_FinalizarModelo.Visible = False
        tb_foto.Visible = False
        bt_cancelar.Visible = False
        Bt_ModificarModelo.Visible = False
        PictureBox1.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
        tb_foto.Clear()
        bt_LimpiarFoto.Visible = False
        bt_LimpiarLogo.Visible = False
        DGV_Marcas.Select()
        ToolBar1.Enabled = True
        TextBox1.Clear()
        TextBox1.Enabled = True
        DGV_Marcas.Enabled = True
        DGV_Marcas.ClearSelection()
        DGV_MarcaModelo.Rows.Clear()
    End Sub

    Private Sub DGV_MarcaModelo__Selection_Changed(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_MarcaModelo.KeyDown, DGV_MarcaModelo.KeyUp, DGV_MarcaModelo.CellClick

        Try
            Me.Cbac_Ano.Text = ""
            Me.Cbac_Modelo.Text = ""
            Me.Cbac_Puertas.Text = ""
            Me.Cbac_Version.Text = ""
            Me.Cbac_Motor.Text = ""
            Me.Tb_Obs.Text = ""
            Me.Cbac_Modelo.SelectedText = Me.DGV_MarcaModelo.SelectedRows(0).Cells(0).Value.ToString
            Me.Cbac_Ano.SelectedText = Me.DGV_MarcaModelo.SelectedRows(0).Cells(1).Value.ToString
            Me.Cbac_Motor.SelectedText = Me.DGV_MarcaModelo.SelectedRows(0).Cells(2).Value.ToString
            Me.Cbac_Puertas.SelectedText = Me.DGV_MarcaModelo.SelectedRows(0).Cells(3).Value.ToString
            Me.Cbac_Version.SelectedText = Me.DGV_MarcaModelo.SelectedRows(0).Cells(4).Value.ToString
            Me.Tb_Obs.Text = Me.DGV_MarcaModelo.SelectedRows(0).Cells(5).Value.ToString

            TextBox7.Text = DatosMarcaModelo.LlenarFoto(Me.Cbac_Modelo.Text, Me.Cbac_Ano.Text, Me.Cbac_Puertas.Text, Me.Cbac_Motor.Text, Me.Cbac_Version.Text)

            Dim v() As String = DatosMarcaModelo.DevolverVectorModelo(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, Me.Cbac_Modelo.Text, Me.Cbac_Ano.Text, Me.Cbac_Puertas.Text, Me.Cbac_Motor.Text, Me.Cbac_Version.Text, Me.Tb_Obs.Text)
            'DGV_MarcaCatalogo.Rows.Clear()


            If catalogo Then
                gb_catalogo.Visible = True
                DGV_MarcaCatalogo.Visible = True
                'DatosMarcaModelo.ConsultaCatalogo(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, DGV_MarcaModelo.SelectedRows(0).Cells(0).Value, DGV_MarcaModelo.SelectedRows(0).Cells(1).Value, DGV_MarcaModelo.SelectedRows(0).Cells(3).Value, DGV_MarcaModelo.SelectedRows(0).Cells(2).Value, DGV_MarcaModelo.SelectedRows(0).Cells(4).Value, DGV_MarcaCatalogo)
                CrearWhere()
                DGV_MarcaModelo.Select()
            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub LimpiarDatosModelo()

        Cbac_Ano.Items.Clear()
        Cbac_Modelo.Items.Clear()
        Cbac_Motor.Items.Clear()
        Cbac_Puertas.Items.Clear()
        Cbac_Version.Items.Clear()
        Tb_Obs.Clear()
        Cbac_Ano.Text = ""
        Cbac_Modelo.Text = ""
        Cbac_Motor.Text = ""
        Cbac_Puertas.Text = ""
        Cbac_Version.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()


    End Sub

    Public Sub AgregarNuevoEnComboBox()

        Cbac_Ano.Items.Add("Nuevo")
        Cbac_Modelo.Items.Add("Nuevo")
        Cbac_Motor.Items.Add("Nuevo")
        Cbac_Puertas.Items.Add("Nuevo")
        Cbac_Version.Items.Add("Nuevo")

    End Sub

    Private Sub Cbac_Modelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbac_Modelo.SelectedIndexChanged
        If Cbac_Modelo.Text = "Nuevo" Then
            TextBox2.Visible = True
            TextBox2.Focus()
        Else
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub Cbac_Ano_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbac_Ano.SelectedIndexChanged
        If Cbac_Ano.Text = "Nuevo" Then
            TextBox3.Visible = True
            TextBox3.Focus()
        Else
            TextBox3.Visible = False
        End If
    End Sub

    Private Sub Cbac_Motor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbac_Motor.SelectedIndexChanged
        If Cbac_Motor.Text = "Nuevo" Then
            TextBox4.Visible = True
            TextBox4.Focus()
        Else
            TextBox4.Visible = False
        End If
    End Sub


    Private Sub Cbac_Puertas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbac_Puertas.SelectedIndexChanged
        If Cbac_Puertas.Text = "Nuevo" Then
            TextBox5.Visible = True
            TextBox5.Focus()
        Else
            TextBox5.Visible = False
        End If
    End Sub

    Private Sub Cbac_Version_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbac_Version.SelectedIndexChanged
        If Cbac_Version.Text = "Nuevo" Then
            TextBox6.Visible = True
            TextBox6.Focus()
        Else
            TextBox6.Visible = False
        End If
    End Sub

    Private Sub textbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (sender Is Me.TextBox2) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "-" Or Char.IsLetter(e.KeyChar) Or e.KeyChar = " " Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Sólo letras, números y/o (-)"
            End If
        End If
    End Sub

    Private Sub textbox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (sender Is Me.TextBox3) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "-" Or e.KeyChar = "+" Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Sólo números, (+) y/o (-)"
            End If
        End If
    End Sub

    Private Sub textbox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (sender Is Me.TextBox4) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Or Char.IsLetter(e.KeyChar) Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Sólo letras, números y/o (.)"
            End If
        End If
    End Sub

    Private Sub textbox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (sender Is Me.TextBox5) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = " " Or Char.IsLetter(e.KeyChar) Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Sólo letras, números y/o (.)"
            End If
        End If
    End Sub

    Private Sub textbox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If (sender Is Me.TextBox6) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Or Char.IsLetter(e.KeyChar) Or e.KeyChar = " " Or e.KeyChar = "-" Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Sólo letras, números, (.) y/o (-)"
            End If
        End If
    End Sub

    Private Sub tb_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_nombre.KeyPress
        If (sender Is Me.tb_nombre) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or e.KeyChar = " " Or e.KeyChar = "-" Then
                e.Handled = False
                muestra_label(sender, 1)
            Else
                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Sólo letras, números, (.) y/o (-)"
            End If
        End If
    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.ErrorProvider1.SetIconAlignment(c, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 31, 213 + c.Location.Y)
            Me.ErrorProvider1.SetIconPadding(c, 5)
            Me.ErrorProvider1.SetError(c, "error")
            Me.Label22.Visible = True
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Modelo, Ano, Puertas, Motor, Version As String
        Modelo = ""
        Ano = ""
        Puertas = ""
        Motor = ""
        Version = ""
        If Cbac_Modelo.Text = "Nuevo" Then
            Modelo = TextBox2.Text
        Else
            Modelo = Cbac_Modelo.Text
        End If
        If Cbac_Ano.Text = "Nuevo" Then
            Ano = TextBox3.Text
        Else
            Ano = Cbac_Ano.Text
        End If
        If Cbac_Puertas.Text = "Nuevo" Then
            Puertas = TextBox5.Text
        Else
            Puertas = Cbac_Puertas.Text
        End If
        If Cbac_Motor.Text = "Nuevo" Then
            Motor = TextBox4.Text
        Else
            Motor = Cbac_Motor.Text
        End If
        If Cbac_Version.Text = "Nuevo" Then
            Version = TextBox6.Text
        Else
            Version = Cbac_Version.Text
        End If

        If Modelo <> "" Then
            If Ano = "" Then
                Ano = "-"
            End If
            If Version = "" Then
                Version = "-"
            End If
            If Motor = "" Then
                Motor = "-"
            End If
            If Puertas = "" Then
                Puertas = "-"
            End If
            If Tb_Obs.Text = "" Then
                Tb_Obs.Text = "-"
            End If
            DatosMarcaModelo.InsertaModelo(DGV_Marcas.SelectedCells.Item(0).Value.ToString, Modelo, Ano, Puertas, Motor, Version, Tb_Obs.Text, TextBox7.Text)
            DGV_MarcaModelo.Rows.Clear()
            DatosMarcaModelo.llenarModelos(DGV_Marcas.SelectedCells.Item(0).Value.ToString, DGV_MarcaModelo)
            LimpiarDatosModelo()
            DatosMarcaModelo.llenarComboAno(Cbac_Ano)
            DatosMarcaModelo.llenarComboModelos(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value, Cbac_Modelo)
            DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
            DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
            DatosMarcaModelo.llenarComboVersion(Cbac_Version)
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
        Else
            MsgBox("No pueden haber campos obligatorios vacíos.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub bt_regresar_click() Handles bt_regresar.Click
        gb_catalogo.Visible = False
        GroupBox2.Visible = True
        DGV_MarcaModelo.Select()
        catalogo = False
    End Sub


    Private Sub Bt_CancelarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_FinalizarModelo.Click

        Dim Marca As String = tb_nombre.Text

        Dim resp As Integer
        Dim nom As String
        Dim a As Boolean = False

        If tb_nombre.Visible = True And TextBox1.Text <> "" And tb_nombre.Text <> "" And TextBox1.Text <> "" Then

            If tb_nombre.Text = "" Then
                MsgBox("No puede existir una marca sin nombre")

            Else
                DatosMarcaModelo.ModificaMarca(TextBox1.Text, tb_foto.Text, tb_nombre.Text)
                a = True
            End If

        End If


        'Marca = TextBox1.Text
        If Marca = "" And tb_nombre.Visible Then
            MsgBox("Introduzca una marca", MsgBoxStyle.Critical)
        ElseIf tb_nombre.Visible = True And Marca <> "" And a = False Then

            If DatosMarcaModelo.Revisar(DGV_Marcas, Marca) Then
                tb_nombre.Text = ""
                bt_cancelar.Visible = True
            ElseIf a = False Then
                DatosMarcaModelo.InsertaMarca(tb_nombre.Text, tb_foto.Text)
                nom = tb_nombre.Text
                Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
                DGV_Marcas.Rows(DatosMarcaModelo.SelccionarMarcaDGV(DGV_Marcas, Marca)).Selected = True
                Lbl_Nombre.Visible = False
                tb_nombre.Visible = False
                tb_foto.Visible = False
                LblLogo.Visible = False
                bt_foto.Visible = False
                bt_LimpiarLogo.Visible = False
                ToolBar1.Enabled = True
                resp = MsgBox("Desea agregar modelos a la nueva marca?", MsgBoxStyle.YesNo)
                DGV_MarcaModelo.Rows.Clear()
                TextBox1.Text = nom
            End If
            DatosMarcaModelo.llenarComboAno(Cbac_Ano)
            DatosMarcaModelo.llenarComboModelos(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value, Cbac_Modelo)
            DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
            DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
            DatosMarcaModelo.llenarComboVersion(Cbac_Version)

        Else

        End If

        tb_nombre.Visible = False
        Label5.Text = DGV_Marcas.Rows.Count

        DGV_Marcas.Enabled = True
        DGV_Marcas.ClearSelection()
        DGV_MarcaModelo.Rows.Clear()
        TextBox1.Text = tb_nombre.Text
        TextBox1.Clear()
        LblLogo.Visible = False
        tb_foto.Visible = False
        bt_LimpiarLogo.Visible = False
        bt_foto.Visible = False
        TextBox1.Clear()
        TextBox1.Enabled = True
        bt_cancelar.Visible = False
        bt_EliminarModelo.Visible = False
        Bt_FinalizarModelo.Visible = False
        Bt_ModificarModelo.Visible = False
        ToolBar1.Enabled = True
        bt_LimpiarFoto.Visible = False
        bt_LimpiarLogo.Visible = False
        Lbl_Nombre.Visible = False

        If resp = vbYes Then
            GroupBox2.Enabled = True
            tb_foto.Visible = False
            bt_foto.Visible = False
            LblLogo.Visible = False
            bt_LimpiarLogo.Visible = False
            ToolBar1.Enabled = False
            TextBox7.Visible = True
            Label11.Visible = True
            Button1.Visible = True
            bt_LimpiarFoto.Visible = True
            TextBox1.Enabled = False
            TextBox1.Text = Marca
            DatosMarcaModelo.llenarComboAno(Cbac_Ano)
            DatosMarcaModelo.llenarComboModelos(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value, Cbac_Modelo)
            DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
            DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
            DatosMarcaModelo.llenarComboVersion(Cbac_Version)
            bt_cancelar.Visible = True
            bt_EliminarModelo.Visible = True
            Bt_FinalizarModelo.Visible = True
            Button2.Visible = True
            Bt_ModificarModelo.Visible = True
        Else
            bt_EliminarModelo.Visible = False
            Bt_ModificarModelo.Visible = False
            GroupBox2.Enabled = False
            Label11.Visible = False
            Button1.Visible = False
            TextBox7.Visible = False
            Button2.Visible = False
            bt_LimpiarFoto.Visible = False
            ToolBar1.Enabled = True
            LimpiarDatosModelo()
            TextBox1.Clear()
            tb_foto.Clear()
            tb_nombre.Clear()
        End If
        Bt_FinalizarModelo.Location = New System.Drawing.Point(731, 519)
        bt_cancelar.Location = New System.Drawing.Point(817, 519)
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.TextBox7.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Try
            Me.PictureBox2.Image = Image.FromFile(Me.TextBox7.Text)
        Catch
            PictureBox2.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
        End Try
    End Sub

    Private Sub Bt_ModificarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_ModificarModelo.Click

        Dim Modelo, Ano, Puertas, Motor, Version As String
        Modelo = ""
        Ano = ""
        Puertas = ""
        Motor = ""
        Version = ""

        If Cbac_Modelo.Text = "Nuevo" Then
            Modelo = TextBox2.Text
        Else
            Modelo = Cbac_Modelo.Text
        End If
        If Cbac_Ano.Text = "Nuevo" Then
            Ano = TextBox3.Text
        Else
            Ano = Cbac_Ano.Text
        End If
        If Cbac_Puertas.Text = "Nuevo" Then
            Puertas = TextBox5.Text
        Else
            Puertas = Cbac_Puertas.Text
        End If
        If Cbac_Motor.Text = "Nuevo" Then
            Motor = TextBox4.Text
        Else
            Motor = Cbac_Motor.Text
        End If
        If Cbac_Version.Text = "Nuevo" Then
            Version = TextBox6.Text
        Else
            Version = Cbac_Version.Text
        End If
        Try
            If Modelo <> "" And Ano <> "" And Puertas <> "" And Version <> "" And Motor <> "" Then

                DatosMarcaModelo.ModificaModelo(DatosMarcaModelo.DevolverVectorModelo(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(0).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(1).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(3).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(2).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(4).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(5).Value.ToString), Modelo, Ano, Puertas, Motor, Version, Tb_Obs.Text, TextBox7.Text)
                LimpiarDatosModelo()
                DGV_MarcaModelo.Rows.Clear()
                DatosMarcaModelo.llenarModelos(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, DGV_MarcaModelo)
                MsgBox("Modelo modificado Satisfactoriamente.")
                TextBox2.Visible = False
                TextBox3.Visible = False
                TextBox4.Visible = False
                TextBox5.Visible = False
                TextBox6.Visible = False
            ElseIf DGV_MarcaModelo.SelectedRows(0).Cells(0).Value = "" Then

            Else
                MsgBox("Existe un campo obligatorio vacío.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un modelo")
        End Try



        DatosMarcaModelo.llenarComboAno(Cbac_Ano)
        DatosMarcaModelo.llenarComboModelos(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value, Cbac_Modelo)
        DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
        DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
        DatosMarcaModelo.llenarComboVersion(Cbac_Version)
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave, TextBox3.Leave, TextBox4.Leave, TextBox5.Leave, TextBox6.Leave, tb_nombre.Leave
        Label22.Visible = False
        ErrorProvider1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not TextBox1.Text = "" Then
            DGV_Marcas.DataSource = Nothing
            DGV_Marcas.Rows.Clear()
            DatosMarcaModelo.BuscarPorMarca(TextBox1.Text, DGV_Marcas)
        Else
            DGV_Marcas.DataSource = SpconsultaMarcaBindingSource
            Me.Sp_consultaMarcaTableAdapter.Fill(Me.MELDataSet.sp_consultaMarca)
        End If
        Label5.Text = DGV_Marcas.Rows.Count
        If Label5.Text = "0" Then
            DGV_MarcaModelo.Rows.Clear()
        Else
            DatosMarcaModelo.llenarModelos(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, DGV_MarcaModelo)
        End If
        Me.Cbac_Ano.Text = ""
        Me.Cbac_Modelo.Text = ""
        Me.Cbac_Puertas.Text = ""
        Me.Cbac_Version.Text = ""
        Me.Cbac_Motor.Text = ""
        Me.Tb_Obs.Text = ""
    End Sub

    Private Sub bt_EliminarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_EliminarModelo.Click

        If DGV_MarcaModelo.Rows.Count = 0 Then
            MsgBox("No hay ningún modelo en la lista", MsgBoxStyle.Critical)

        Else
            Try
                DatosMarcaModelo.EliminarModelo(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(0).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(1).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(3).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(2).Value.ToString, Me.DGV_MarcaModelo.SelectedRows(0).Cells(4).Value.ToString)
                LimpiarDatosModelo()
                DGV_MarcaModelo.Rows.Clear()
                DatosMarcaModelo.llenarModelos(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, DGV_MarcaModelo)
                PictureBox2.Image = New Bitmap(MyClass.GetType(), "Theme Manager.png")
                DGV_MarcaModelo.Select()
            Catch ex As Exception
                MsgBox("Debe seleccionar un modelo")
            End Try

        End If

        DatosMarcaModelo.llenarComboAno(Cbac_Ano)
        DatosMarcaModelo.llenarComboModelos(Me.DGV_Marcas.SelectedRows(0).Cells(0).Value, Cbac_Modelo)
        DatosMarcaModelo.llenarComboMotor(Cbac_Motor)
        DatosMarcaModelo.llenarComboPuertas(Cbac_Puertas)
        DatosMarcaModelo.llenarComboVersion(Cbac_Version)

    End Sub

    Private Sub bt_catalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Cbac_Modelo.Text <> "" And Cbac_Ano.Text <> "" And Cbac_Puertas.Text <> "" And Cbac_Version.Text <> "" And Cbac_Motor.Text <> "" Then
            gb_catalogo.Visible = True
            GroupBox2.Visible = False
            DatosMarcaModelo.ConsultaCatalogo(DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString, Me.Cbac_Modelo.Text, Me.Cbac_Ano.Text, Me.Cbac_Puertas.Text, Me.Cbac_Motor.Text, Me.Cbac_Version.Text, DGV_MarcaCatalogo)
            DGV_MarcaModelo.Select()
        Else

            MsgBox("Debe seleccionar un modelo", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub bt_LimpiarLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_LimpiarFoto.Click
        Me.TextBox7.Clear()
    End Sub

    Private Sub bt_EliminarLogoM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_LimpiarLogo.Click
        Me.tb_foto.Clear()
    End Sub

    Private Sub DGV_MarcaCatalogo_Row(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_MarcaCatalogo.RowsAdded, DGV_MarcaCatalogo.RowsRemoved

        Label7.Text = DGV_MarcaCatalogo.RowCount

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If DGV_Marcas.Rows.Count > 0 Then
            If e.KeyData = Keys.Enter Then

                Me.DGV_Marcas.Rows(0).Cells(0).Selected = True
                DGV_Marcas.Focus()

            End If

        End If

    End Sub

    Public Sub CrearWhere()

        'Sp_infoGeneralComprasBindingSource.ResetBindings(True)
        Dim where As String = ""
        Dim y As String = ""

        If DGV_MarcaModelo.SelectedRows.Count > 0 Then

            Dim Modelo As String = ""

            Modelo = DGV_MarcaModelo.SelectedRows(0).Cells(0).Value.ToString

            If DGV_MarcaModelo.SelectedRows(0).Cells(1).Value.ToString = "-" Then
                Modelo = Modelo + ""
            Else
                Modelo = Modelo + " " + DGV_MarcaModelo.SelectedRows(0).Cells(1).Value.ToString + " "
            End If

            If DGV_MarcaModelo.SelectedRows(0).Cells(3).Value.ToString = "-" Then
                Modelo = Modelo + ""
            Else
                Modelo = Modelo + " " + DGV_MarcaModelo.SelectedRows(0).Cells(3).Value.ToString + " "
            End If

            If DGV_MarcaModelo.SelectedRows(0).Cells(2).Value.ToString = "-" Then
                Modelo = Modelo + ""
            Else
                Modelo = Modelo + " " + DGV_MarcaModelo.SelectedRows(0).Cells(2).Value.ToString + " "
            End If

            If DGV_MarcaModelo.SelectedRows(0).Cells(4).Value.ToString = "-" Then
                Modelo = Modelo + ""
            Else
                Modelo = Modelo + " " + DGV_MarcaModelo.SelectedRows(0).Cells(4).Value.ToString
            End If

            where = where + "Modelo LIKE '%" & Modelo & "%'" + y

            'DGV_MarcaModelo.SelectedRows(0).Cells(0).Value, DGV_MarcaModelo.SelectedRows(0).Cells(1).Value, DGV_MarcaModelo.SelectedRows(0).Cells(3).Value, DGV_MarcaModelo.SelectedRows(0).Cells(2).Value, DGV_MarcaModelo.SelectedRows(0).Cells(4).Value

            y = " and "

        Else

            where = where + "MARCA LIKE '%" & DGV_Marcas.SelectedRows(0).Cells(0).Value.ToString & "%'" + y
            y = " and "

        End If

        If chk_exist.Checked Then
            where = where + y + "CantidadExistencia > 0"
        End If

        Me.SpconsultaCatalogo2BindingSource.Filter = where

        DGV_MarcaCatalogo.ClearSelection()

    End Sub

    
    Private Sub chk_exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_exist.CheckedChanged
        CrearWhere()
    End Sub
End Class