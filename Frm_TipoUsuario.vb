Public Class Frm_TipoUsuario
    Inherits System.Windows.Forms.Form
    Private varboton As Integer = 0
    Dim cuantos As Integer = 0
    Dim aca As Boolean = False
    Dim h As Boolean = True
    Dim i As Boolean = True


    Private Sub Frm_TipoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        rb_Activos.Visible = True
        rb_eliminados.Visible = True
        rb_Activos.Checked = True
        DatosUsuarios.llenarTipos(tb_usuario, True)
        DatosTipoUsurio.llenarModulos(0, DGV_TipoUsuario)
        tb_usuario_SelectedIndexChanged(tb_usuario, New EventArgs)
        DGV_TipoUsuario.Columns(0).ReadOnly = True
        DGV_TipoUsuario.ClearSelection()
        'OrdenarFilas(DGV_TipoUsuario)
        OrdenarData(DGV_TipoUsuario)
        cb_ninguno.Visible = False
        cb_todos.Visible = False
        bt_aceptar.Visible = False
        tb_usuario.SelectedIndex = 0
        DGV_TipoUsuario.ReadOnly = True
        DGV_TipoUsuario.Columns(4).ReadOnly = True
        DGV_TipoUsuario.Columns(5).ReadOnly = True
        DGV_TipoUsuario.Columns(0).ReadOnly = True
        DGV_TipoUsuario.Columns(1).ReadOnly = True
        If h = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If
    End Sub
    Public Sub permisos(ByVal h1 As Boolean, ByVal i1 As Boolean)
        h = h1
        i = i1
    End Sub

    Private Sub tb_usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_usuario.SelectedIndexChanged
        Dim cont As Integer = 0
        If tb_usuario.Text = "" Then

            DatosTipoUsurio.llenarModulos(0, DGV_TipoUsuario)
            OrdenarData(DGV_TipoUsuario)



        Else

            If DGV_TipoUsuario.Rows.Count <> 0 Then
                For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                    DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
                    DGV_TipoUsuario.Rows(cont).Cells(4).Value = False

                Next
            End If



            DatosTipoUsurio.llenarModulos(CInt(tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Code), DGV_TipoUsuario)




        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then

            Me.Close()


        ElseIf e.Button Is Me.bt_nuevo Then
            Dim cont As Integer = 0
            DGV_TipoUsuario.ReadOnly = False
            DGV_TipoUsuario.Columns(0).ReadOnly = False
            DGV_TipoUsuario.Columns(1).ReadOnly = True
            DGV_TipoUsuario.Columns(4).ReadOnly = False
            DGV_TipoUsuario.Columns(5).ReadOnly = False
            varboton = 2
            tb_usuario.Visible = False
            tb_nuevo.Visible = True
            tb_nuevo.Focus()
            rb_Activos.Visible = False
            rb_eliminados.Visible = False
            bt_restaurar.Visible = False
            cb_ninguno.Enabled = True
            cb_todos.Enabled = True
            cb_ninguno.Checked = True
            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
                DGV_TipoUsuario.Rows(cont).Cells(4).Value = False
                If DGV_TipoUsuario.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                    DGV_TipoUsuario.Rows(cont).Cells(5).Value = False
                End If
            Next
            cb_ninguno.Visible = True
            cb_todos.Visible = True
            bt_aceptar.Visible = True
            bt_cancelar.Visible = True
            DatosTipoUsurio.llenarid(lb_id)

        ElseIf e.Button Is Me.bt_modificar Then
            If tb_usuario.SelectedText <> "" Or tb_usuario.Text <> "" Then
                If rb_Activos.Checked = True Then
                    bt_aceptar.Visible = True
                    bt_restaurar.Visible = False
                    cb_ninguno.Enabled = True
                    aca = True
                    cb_todos.Enabled = True
                    cb_ninguno.Visible = True
                    cb_todos.Visible = True
                    bt_cancelar.Visible = True
                    DGV_TipoUsuario.ReadOnly = False
                    DGV_TipoUsuario.Columns(1).ReadOnly = True
                    DGV_TipoUsuario.Columns(0).ReadOnly = False
                    DatosTipoUsurio.llenarid(lb_id)
                ElseIf rb_eliminados.Checked = True Then
                    bt_aceptar.Visible = False
                    bt_restaurar.Visible = True
                    bt_cancelar.Visible = True
                    DGV_TipoUsuario.Columns(0).ReadOnly = True
                    DGV_TipoUsuario.Columns(1).ReadOnly = True
                End If
                tb_usuario.Enabled = False
                rb_Activos.Visible = True
                rb_eliminados.Visible = True
                tb_usuario.Visible = True
                tb_nuevo.Visible = False
                lb_nom.Text = "Nombre:"
                varboton = 3
            Else
                MsgBox("Debe seleccionar un Tipo de Usuario para poder modificarlo", MsgBoxStyle.Critical, "Error")
            End If


        ElseIf e.Button Is Me.bt_eliminar Then
            If tb_usuario.SelectedText <> "" Or tb_usuario.Text <> "" Then
                If rb_Activos.Checked = True Then
                    tb_usuario.Visible = True
                    tb_nuevo.Visible = False
                    lb_nom.Text = "Nombre:"
                    Dim response As MsgBoxResult
                    Dim usuario As Boolean
                    DGV_TipoUsuario.Columns(0).ReadOnly = False
                    If tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Code.ToString <> "" Then
                        response = MsgBox("¿Confirma que desea eliminar el Tipo de Usuario '" + tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Name.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
                        If (response = MsgBoxResult.Yes) Then
                            DatosTipoUsurio.eliminarTipoUsuario(CInt(tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Code.ToString), usuario)
                            tb_usuario.ResetText()
                            DatosUsuarios.llenarTipos(tb_usuario, True)
                            DatosTipoUsurio.llenarModulos(0, DGV_TipoUsuario)
                            OrdenarData(DGV_TipoUsuario)
                            DGV_TipoUsuario.ClearSelection()

                        End If

                    End If
                Else
                    MsgBox("Ya el tipo de usuario se encuentra eliminado", MsgBoxStyle.Critical, "Error")
                    DGV_TipoUsuario.ClearSelection()

                End If
            Else
                MsgBox("Debe Seleccionar un Tipo de Usuario para poder eliminarlo", MsgBoxStyle.Critical, "Error")
                DGV_TipoUsuario.ClearSelection()
            End If
            rb_Activos.Checked = True
            tb_usuario.SelectedIndex = 0

        End If


    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim cont As Integer = 0
        Dim bo As Boolean = False



        If varboton = 2 Then
            lb_nom.Text = "Nombre:"
            tb_usuario.Visible = True
            tb_nuevo.Visible = False
            Dim cont2 As Integer = 0
            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1

                If DGV_TipoUsuario.Rows(cont).Cells(0).Value = True Then


                    If DGV_TipoUsuario.Rows(cont).Cells(5).Value.ToString = "" Then
                        bo = False
                    Else
                        bo = DGV_TipoUsuario.Rows(cont).Cells(5).Value
                    End If
                    DatosTipoUsurio.insertarTipoUsuario(CInt(lb_id.Text) + 1, CInt(DGV_TipoUsuario.Rows(cont).Cells(2).Value), tb_nuevo.Text, cont2, DGV_TipoUsuario.Rows(cont).Cells(4).Value, bo)
                    cont2 = cont2 + 1
                End If

            Next

            tb_usuario.ResetText()
            DatosUsuarios.llenarTipos(tb_usuario, True)
            DatosTipoUsurio.llenarModulos(0, DGV_TipoUsuario)
            OrdenarData(DGV_TipoUsuario)

            MsgBox("El nuevo usuario ha sido ingresado de forma exitosa", MsgBoxStyle.OkOnly)
            DGV_TipoUsuario.ReadOnly = True
            DGV_TipoUsuario.Columns(0).ReadOnly = True


        ElseIf varboton = 3 Then

            If rb_Activos.Checked = True Then

                For cont = 0 To DGV_TipoUsuario.Rows.Count - 1

                    If DGV_TipoUsuario.Rows(cont).Cells(5).Value.ToString = "" Then
                        bo = False
                    Else
                        bo = DGV_TipoUsuario.Rows(cont).Cells(5).Value
                    End If

                    DatosTipoUsurio.modificarTipoUsuario(CInt(tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Code), CInt(DGV_TipoUsuario.Rows(cont).Cells(2).Value), CBool(DGV_TipoUsuario.Rows(cont).Cells(0).Value), CBool(DGV_TipoUsuario.Rows(cont).Cells(4).Value), bo, cont)

                Next


                If DGV_TipoUsuario.Rows.Count <> 0 Then
                    For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                        DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
                    Next
                End If

                DatosTipoUsurio.llenarModulos(CInt(tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Code), DGV_TipoUsuario)


                MsgBox("El usuario ha sido modificado de forma exitosa, los cambios serán reflejados una vez reiniciado el sistema", MsgBoxStyle.Information)
                DGV_TipoUsuario.ReadOnly = True
                DGV_TipoUsuario.Columns(0).ReadOnly = True

            End If
            DGV_TipoUsuario.Columns(0).ReadOnly = True
        End If
        DGV_TipoUsuario.ReadOnly = True
        DGV_TipoUsuario.Columns(0).ReadOnly = True
        DGV_TipoUsuario.Columns(1).ReadOnly = True
        DGV_TipoUsuario.Columns(4).ReadOnly = True
        DGV_TipoUsuario.Columns(5).ReadOnly = True
        rb_Activos.Visible = True
        rb_eliminados.Visible = True
        cb_ninguno.Enabled = False
        cb_todos.Enabled = False
        cb_ninguno.Visible = False
        cb_todos.Visible = False
        tb_usuario.Enabled = True
        bt_restaurar.Visible = False
        bt_cancelar.Visible = False
        bt_aceptar.Visible = False
        tb_nuevo.Clear()
        For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
            DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
            DGV_TipoUsuario.Rows(cont).Cells(4).Value = False
            If DGV_TipoUsuario.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                DGV_TipoUsuario.Rows(cont).Cells(5).Value = False
            End If
        Next
        tb_usuario.ResetText()
        tb_usuario.Items.Clear()
        DatosUsuarios.llenarTipos(tb_usuario, True)
        tb_usuario.SelectedIndex = 0
        varboton = 0


    End Sub

    Private Sub bt_restaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_restaurar.Click
        Dim response As MsgBoxResult
        If tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Code.ToString <> "" Then

            response = MsgBox("¿Confirma que desea eliminar el Tipo de Usuario '" + tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Name.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar la Eliminación")
            If (response = MsgBoxResult.Yes) Then
                DatosTipoUsurio.RestaurarTipo(CInt(tb_usuario.Items.Item(Me.tb_usuario.SelectedIndex).Code))
                MsgBox("El usuario ha sido restaurado de forma exitosa", MsgBoxStyle.OkOnly)
                tb_usuario.ResetText()
                DatosUsuarios.llenarTipos(tb_usuario, False)
                DatosTipoUsurio.llenarModulos(0, DGV_TipoUsuario)
                OrdenarData(DGV_TipoUsuario)
                varboton = 0
                DGV_TipoUsuario.Columns(0).ReadOnly = True


            End If

        End If
        For cont As Integer = 0 To DGV_TipoUsuario.Rows.Count - 1
            DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
            DGV_TipoUsuario.Rows(cont).Cells(4).Value = False
            If DGV_TipoUsuario.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                DGV_TipoUsuario.Rows(cont).Cells(5).Value = False
            End If
        Next
        rb_Activos.Visible = True
        rb_eliminados.Visible = True
        bt_aceptar.Visible = True
        bt_eliminar.Visible = True
        tb_usuario.Enabled = True
        DGV_TipoUsuario.Columns(0).ReadOnly = True
        If tb_usuario.Items.Count > 0 Then
            tb_usuario.SelectedIndex = 0
        End If


    End Sub

    Private Sub rb_Activos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Activos.CheckedChanged
        Dim cont As Integer = 0
        If DGV_TipoUsuario.Rows.Count <> 0 Then
            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
            Next
        End If
        tb_usuario.ResetText()
        DatosUsuarios.llenarTipos(tb_usuario, True)
        DGV_TipoUsuario.ClearSelection()
        DGV_TipoUsuario.Columns(0).ReadOnly = True
        tb_usuario.Enabled = True
        cb_ninguno.Visible = False
        cb_todos.Visible = False
        bt_aceptar.Visible = False
        bt_restaurar.Visible = False
        bt_cancelar.Visible = False
        tb_usuario.SelectedIndex = 0

        varboton = 0
    End Sub

    Private Sub rb_eliminados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_eliminados.CheckedChanged
        Dim cont As Integer = 0
        If DGV_TipoUsuario.Rows.Count <> 0 Then
            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
                DGV_TipoUsuario.Rows(cont).Cells(4).Value = False
                If DGV_TipoUsuario.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                    DGV_TipoUsuario.Rows(cont).Cells(5).Value = False
                End If
            Next
        End If
        tb_usuario.ResetText()
        DatosUsuarios.llenarTipos(tb_usuario, False)
        DGV_TipoUsuario.ClearSelection()
        DGV_TipoUsuario.Columns(0).ReadOnly = True
        tb_usuario.Enabled = True
        cb_ninguno.Visible = False
        cb_todos.Visible = False
        varboton = 0
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        bt_restaurar.Visible = False
        If tb_usuario.Items.Count > 0 Then
            tb_usuario.SelectedIndex = 0

        End If


    End Sub
    Private Sub OrdenarData(ByVal DGV As DataGridView)


        Dim total As Integer = 0
        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        Dim cont3 As Integer = 0



        If DGV.Rows.Count <> 0 Then

            For cont = 0 To DGV.Rows.Count - 1
                For cont2 = 0 To DGV.Rows.Count - 1

                    If DGV.Rows(cont2).Cells(2).Value = DGV.Rows(cont).Cells(3).Value Then
                        If DGV.Rows(cont).Cells(2).Value <> DGV.Rows(cont2).Cells(3).Value Then


                            total = Espacio(DGV_TipoUsuario, cont)

                            'DGV.Rows(cont).Cells(1).Value = "    " + DGV.Rows(cont).Cells(1).Value.ToString()

                            For cont3 = 0 To total
                                DGV.Rows(cont).Cells(1).Value = "       " + DGV.Rows(cont).Cells(1).Value.ToString()
                            Next
                            cuantos = 0

                            DGV.Rows(cont).DefaultCellStyle.BackColor = Color.White

                        Else
                            DGV.Rows(cont).DefaultCellStyle.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))


                        End If

                    End If
                Next


            Next

        End If



    End Sub
    Public Function Espacio(ByVal DGV As DataGridView, ByVal cont As Integer) As Integer

        Dim cont2 As Integer = 0
        Dim igual As Boolean = True


        For cont2 = 0 To DGV.Rows.Count - 1

            If DGV.Rows(cont2).Cells(2).Value = DGV.Rows(cont).Cells(3).Value Then

                cuantos = cuantos + 1

                If DGV.Rows(cont2).Cells(3).Value <> DGV.Rows(cont2).Cells(2).Value Then

                    cuantos = Espacio(DGV_TipoUsuario, cont2)

                End If

            End If

        Next

        Return cuantos


    End Function


    Private Sub DGV_TipoUsuario_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_TipoUsuario.CellClick


        If e.ColumnIndex = 0 Then
            'cb_ninguno.Checked = False

            If DGV_TipoUsuario.Columns(0).ReadOnly = False Then

                Dim cont As Integer = 0

                Dim check As Boolean = False
                cb_ninguno.Checked = False
                cb_todos.Checked = False


                If varboton = 2 Or varboton = 3 Then

                    If DGV_TipoUsuario.Rows(e.RowIndex).Cells(0).EditedFormattedValue = False Then
                        check = True

                    Else
                        check = False
                        DGV_TipoUsuario.Rows(e.RowIndex).Cells(4).Value = False
                        If DGV_TipoUsuario.Rows(e.RowIndex).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                            DGV_TipoUsuario.Rows(e.RowIndex).Cells(5).Value = False
                        End If


                    End If



                    DGV_TipoUsuario.Columns(5).ReadOnly = True

                    If DGV_TipoUsuario.Rows.Count <> 0 Then

                        If DGV_TipoUsuario.CurrentRow.Cells(2).Value = DGV_TipoUsuario.CurrentRow.Cells(3).Value Then

                            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                                If DGV_TipoUsuario.CurrentRow.Cells(2).Value = DGV_TipoUsuario.Rows(cont).Cells(3).Value Then
                                    If DGV_TipoUsuario.Rows(cont).Cells(2).Value = DGV_TipoUsuario.CurrentRow.Cells(2).Value Then
                                        If DGV_TipoUsuario.Rows(cont).Cells(0).EditedFormattedValue = False Then
                                            check = True

                                        Else
                                            check = False
                                            DGV_TipoUsuario.Rows(e.RowIndex).Cells(4).Value = False
                                            If DGV_TipoUsuario.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                                                DGV_TipoUsuario.Rows(cont).Cells(5).Value = False
                                            End If


                                        End If
                                    End If


                                    If DGV_TipoUsuario.Rows(cont).Cells(2).Value <> DGV_TipoUsuario.CurrentRow.Cells(2).Value Then
                                        If check = True Then
                                            DGV_TipoUsuario.Rows(cont).Cells(0).Value = True



                                        Else
                                            DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
                                            DGV_TipoUsuario.Rows(cont).Cells(4).Value = False
                                            If DGV_TipoUsuario.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                                                DGV_TipoUsuario.Rows(cont).Cells(5).Value = False
                                            End If

                                        End If

                                    End If

                                End If
                            Next

                        ElseIf DGV_TipoUsuario.CurrentRow.Cells(2).Value <> DGV_TipoUsuario.CurrentRow.Cells(3).Value Then

                            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1


                                If DGV_TipoUsuario.CurrentRow.Cells(3).Value = DGV_TipoUsuario.Rows(cont).Cells(2).Value Then

                                    If DGV_TipoUsuario.Rows(cont).Cells(2).Value = DGV_TipoUsuario.Rows(cont).Cells(3).Value And DGV_TipoUsuario.Rows(cont).Cells(0).Value = False Then
                                        If DGV_TipoUsuario.CurrentRow.Cells(0).EditedFormattedValue = False Then
                                            DGV_TipoUsuario.Rows(cont).Cells(0).Value = True


                                        End If
                                    End If
                                End If
                            Next

                        End If

                    End If
                End If
            End If
            DGV_TipoUsuario.Columns(0).ReadOnly = False
            DGV_TipoUsuario.Columns(4).ReadOnly = False
            DGV_TipoUsuario.Columns(5).ReadOnly = False

        End If



        '------------------------------------------------------Columna 4----------------------------------------


        If e.ColumnIndex = 4 Then
            'cb_ninguno.Checked = False

            If DGV_TipoUsuario.Columns(4).ReadOnly = False Then


                If DGV_TipoUsuario.Rows(e.RowIndex).Cells(4).EditedFormattedValue = False Then
                    DGV_TipoUsuario.CurrentRow.Cells(4).Value = True
                    DGV_TipoUsuario.Rows(e.RowIndex).Cells(0).Value = True
                Else
                    DGV_TipoUsuario.Rows(e.RowIndex).Cells(4).Value = False
                End If

                Dim cont As Integer = 0

                Dim check As Boolean = False
                cb_ninguno.Checked = False
                cb_todos.Checked = False

                If varboton = 2 Or varboton = 3 Then

                    If DGV_TipoUsuario.Rows.Count <> 0 Then

                        If DGV_TipoUsuario.CurrentRow.Cells(2).Value = DGV_TipoUsuario.CurrentRow.Cells(3).Value Then

                            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                                If DGV_TipoUsuario.CurrentRow.Cells(2).Value = DGV_TipoUsuario.Rows(cont).Cells(3).Value Then
                                    If DGV_TipoUsuario.Rows(cont).Cells(2).Value = DGV_TipoUsuario.CurrentRow.Cells(2).Value Then
                                        If DGV_TipoUsuario.Rows(cont).Cells(4).EditedFormattedValue = False Then
                                            check = True

                                        Else
                                            check = False


                                        End If
                                    End If


                                    If DGV_TipoUsuario.Rows(cont).Cells(2).Value <> DGV_TipoUsuario.CurrentRow.Cells(2).Value Then
                                        If check = True Then
                                            DGV_TipoUsuario.Rows(cont).Cells(4).Value = True
                                            DGV_TipoUsuario.Rows(cont).Cells(0).Value = True

                                        Else
                                            DGV_TipoUsuario.Rows(cont).Cells(4).Value = False

                                        End If

                                    End If

                                End If
                            Next

                        ElseIf DGV_TipoUsuario.CurrentRow.Cells(2).Value <> DGV_TipoUsuario.CurrentRow.Cells(3).Value Then

                            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1


                                If DGV_TipoUsuario.CurrentRow.Cells(3).Value = DGV_TipoUsuario.Rows(cont).Cells(2).Value Then

                                    If DGV_TipoUsuario.Rows(cont).Cells(2).Value = DGV_TipoUsuario.Rows(cont).Cells(3).Value And DGV_TipoUsuario.Rows(cont).Cells(0).Value = False Then
                                        If DGV_TipoUsuario.CurrentRow.Cells(4).EditedFormattedValue = False Then
                                            DGV_TipoUsuario.Rows(cont).Cells(0).Value = True


                                        End If
                                    End If
                                End If
                            Next

                        End If

                    End If
                End If
            End If
            DGV_TipoUsuario.Columns(4).ReadOnly = False

        End If




        '------------------------------------------------------Columna 5----------------------------------------


        If e.ColumnIndex = 5 Then
            If DGV_TipoUsuario.Rows(e.RowIndex).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then



                If DGV_TipoUsuario.Columns(5).ReadOnly = False Then


                    If DGV_TipoUsuario.Rows(e.RowIndex).Cells(5).EditedFormattedValue = False Then
                        DGV_TipoUsuario.Rows(e.RowIndex).Cells(5).Value = True
                        DGV_TipoUsuario.Rows(e.RowIndex).Cells(0).Value = True

                    Else
                        DGV_TipoUsuario.Rows(e.RowIndex).Cells(5).Value = False
                    End If

                    Dim cont As Integer = 0

                    Dim check As Boolean = False
                    cb_ninguno.Checked = False
                    cb_todos.Checked = False


                    If varboton = 2 Or varboton = 3 Then



                        If DGV_TipoUsuario.Rows.Count <> 0 Then

                            If DGV_TipoUsuario.CurrentRow.Cells(2).Value = DGV_TipoUsuario.CurrentRow.Cells(3).Value Then

                                For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                                    If DGV_TipoUsuario.CurrentRow.Cells(2).Value = DGV_TipoUsuario.Rows(cont).Cells(3).Value Then
                                        If DGV_TipoUsuario.Rows(cont).Cells(2).Value = DGV_TipoUsuario.CurrentRow.Cells(2).Value Then
                                            If DGV_TipoUsuario.Rows(cont).Cells(5).EditedFormattedValue = False Then
                                                check = True

                                            Else
                                                check = False


                                            End If
                                        End If


                                        If DGV_TipoUsuario.Rows(cont).Cells(2).Value <> DGV_TipoUsuario.CurrentRow.Cells(2).Value Then
                                            If check = True Then
                                                DGV_TipoUsuario.Rows(cont).Cells(5).Value = True
                                                DGV_TipoUsuario.Rows(cont).Cells(0).Value = True

                                            Else
                                                DGV_TipoUsuario.Rows(cont).Cells(5).Value = False

                                            End If

                                        End If

                                    End If
                                Next

                            ElseIf DGV_TipoUsuario.CurrentRow.Cells(2).Value <> DGV_TipoUsuario.CurrentRow.Cells(3).Value Then

                                For cont = 0 To DGV_TipoUsuario.Rows.Count - 1


                                    If DGV_TipoUsuario.CurrentRow.Cells(3).Value = DGV_TipoUsuario.Rows(cont).Cells(2).Value Then

                                        If DGV_TipoUsuario.Rows(cont).Cells(2).Value = DGV_TipoUsuario.Rows(cont).Cells(3).Value And DGV_TipoUsuario.Rows(cont).Cells(0).Value = False Then
                                            If DGV_TipoUsuario.CurrentRow.Cells(5).EditedFormattedValue = False Then
                                                DGV_TipoUsuario.Rows(cont).Cells(0).Value = True


                                            End If

                                        End If

                                    End If

                                Next

                            End If

                        End If

                    End If

                End If

                DGV_TipoUsuario.Columns(5).ReadOnly = False

            End If

        End If
        DGV_TipoUsuario.ClearSelection()

    End Sub




    Private Sub OrdenarFilas(ByVal DGV As DataGridView)
        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        Dim cont3 As Integer = 0
        Dim igual As Boolean = False
        Dim idActual As Integer = 0
        Dim idAntActual As Integer = 0




        For cont = 0 To DGV.Rows.Count - 1
            DGV_busqueda.Rows.Add(DGV.Rows(cont).Cells(0).Value, DGV.Rows(cont).Cells(1).Value, DGV.Rows(cont).Cells(2).Value, DGV.Rows(cont2).Cells(3).Value)

        Next
        cont = 0
        DGV.Rows.Clear()


        For cont = 0 To DGV_busqueda.Rows.Count - 1
            idActual = DGV_busqueda.Rows(cont).Cells(2).Value
            idAntActual = DGV_busqueda.Rows(cont).Cells(3).Value


            If DGV.Rows.Count <> 0 Then
                igual = False
                For cont3 = 0 To DGV.Rows.Count - 1
                    If DGV_busqueda.Rows(cont).Cells(2).Value = DGV.Rows(cont3).Cells(2).Value Then
                        If DGV_busqueda.Rows(cont).Cells(3).Value = DGV.Rows(cont3).Cells(3).Value Then
                            igual = True
                        End If
                    End If



                Next
                If igual = False Then

                    DGV.Rows.Add(DGV_busqueda.Rows(cont).Cells(0).Value, DGV_busqueda.Rows(cont).Cells(1).Value, DGV_busqueda.Rows(cont).Cells(2).Value, DGV_busqueda.Rows(cont).Cells(3).Value)

                End If

            End If



            For cont2 = 0 To DGV_busqueda.Rows.Count - 1

                If idActual = DGV_busqueda.Rows(cont2).Cells(3).Value Then

                    If DGV_busqueda.Rows(cont2).Cells(2).Value <> DGV_busqueda.Rows(cont2).Cells(3).Value Then

                        DGV.Rows.Add(DGV_busqueda.Rows(cont2).Cells(0).Value, DGV_busqueda.Rows(cont2).Cells(1).Value, DGV_busqueda.Rows(cont2).Cells(2).Value, DGV_busqueda.Rows(cont2).Cells(3).Value)

                    End If

                End If

            Next

        Next

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_todos.CheckedChanged
        If aca = False Then
            Dim cont As Integer = 0
            If cb_todos.Checked = True Then
                cb_ninguno.Checked = False
                For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                    DGV_TipoUsuario.Rows(cont).Cells(0).Value = True
                Next
            End If
        End If
        aca = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_ninguno.CheckedChanged
        Dim cont As Integer = 0
        If cb_ninguno.Checked = True Then
            For cont = 0 To DGV_TipoUsuario.Rows.Count - 1
                DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
            Next
        End If

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        For cont As Integer = 0 To DGV_TipoUsuario.Rows.Count - 1
            DGV_TipoUsuario.Rows(cont).Cells(0).Value = False
            DGV_TipoUsuario.Rows(cont).Cells(4).Value = False
            If DGV_TipoUsuario.Rows(cont).Cells(5).AccessibilityObject.Help.ToString = "DataGridViewCheckBoxCell(DataGridViewCell)" Then
                DGV_TipoUsuario.Rows(cont).Cells(5).Value = False
            End If
        Next
        bt_restaurar.Visible = False
        bt_cancelar.Visible = False
        bt_aceptar.Visible = False
        tb_usuario.Enabled = True
        rb_Activos.Checked = True
        tb_usuario.ResetText()
        tb_nuevo.Clear()
        DatosUsuarios.llenarTipos(tb_usuario, True)
        DatosTipoUsurio.llenarModulos(0, DGV_TipoUsuario)
        OrdenarData(DGV_TipoUsuario)
        tb_usuario.Visible = True
        tb_nuevo.Visible = False
        cb_ninguno.Enabled = False
        cb_todos.Enabled = False
        cb_ninguno.Visible = False
        cb_todos.Visible = False
        DGV_TipoUsuario.ReadOnly = True
        DGV_TipoUsuario.Columns(0).ReadOnly = True
        DGV_TipoUsuario.Columns(1).ReadOnly = True
        varboton = 0
        rb_Activos.Visible = True
        rb_eliminados.Visible = True
        tb_usuario.SelectedIndex = 0





    End Sub





    Private Sub DGV_TipoUsuario_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_TipoUsuario.CellMouseClick

        If DGV_TipoUsuario.Columns(0).ReadOnly = False Then


            If e.ColumnIndex = 0 Then


                If e.RowIndex = 0 Then


                    If DGV_TipoUsuario.Rows(0).Cells(0).EditedFormattedValue = True Then

                        DGV_TipoUsuario.Rows(0).Cells(0).Value = False
                    Else

                        DGV_TipoUsuario.Rows(0).Cells(0).Value = True

                    End If
                    tb_usuario.Focus()
                    tb_usuario.Select()
                End If


                If e.RowIndex <> 0 Then


                    If DGV_TipoUsuario.Rows(e.RowIndex).Cells(0).EditedFormattedValue = True Then

                        DGV_TipoUsuario.Rows(e.RowIndex).Cells(0).Value = False
                    Else

                        DGV_TipoUsuario.Rows(e.RowIndex).Cells(0).Value = True

                    End If
                    tb_usuario.Focus()
                    tb_usuario.Select()
                End If


            End If

        End If


    End Sub

End Class