Public Class Frm_Configuracion_Cobranzas

    Dim boton3 As Integer

    Private Sub Frm_Configuracion_Cobranzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatosConfiguracion.consulta_montoAsociacion(tb_monto.Text)
        tb_monto.Focus()
        tb_monto.SelectAll()
    End Sub

    Private Sub tp_ajustes_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_ajustes.Enter
        DatosConfiguracion.consulta_MontoAjuste(tb_montoAjustes.Text)
        tb_montoAjustes.Focus()
        tb_montoAjustes.SelectAll()
    End Sub

    Private Sub tp_asociacion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_asociacion.Enter
        DatosConfiguracion.consulta_montoAsociacion(tb_monto.Text)
        tb_monto.Focus()
        tb_monto.SelectAll()
    End Sub


    Private Sub tp_egresos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_egresos.Enter
        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()
        bt_agregarS.Visible = False
        bt_agregarCat.Visible = False

        bt_agregarCategoria.Enabled = True
        bt_ModificarCategoria.Enabled = False
        bt_eliminarCategoria.Enabled = False

        bt_agregarSubCategoria.Enabled = False
        bt_ModificarSubCategoria.Enabled = False
        bt_EliminarSubCategoria.Enabled = False

        tb_nombreC.Clear()

        tb_busquedaS.Clear()
        tb_busquedaC.Clear()

        tb_nombreS.ReadOnly = True
        tb_identS.ReadOnly = True
        tb_obsS.ReadOnly = True
        tb_nombreC.ReadOnly = True

        DatosMovimientos.consulta_categoria(lb_categoria, 0, "", 0)

        lb_Subcategoria.Items.Clear()

        tb_busquedaC.Focus()
    End Sub


    Private Sub bt_agregarCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCategoria.Click

        tb_nombreC.ReadOnly = False
        tb_nombreC.Clear()
        bt_agregarCat.Visible = True

        bt_ModificarCategoria.Enabled = False
        bt_eliminarCategoria.Enabled = False
        bt_agregarSubCategoria.Enabled = False
        bt_ModificarSubCategoria.Enabled = False
        bt_EliminarSubCategoria.Enabled = False

        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()

        boton3 = 1

        tb_nombreC.Focus()
        lb_categoria.ClearSelected()

    End Sub

    Private Sub bt_agregarSubCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarSubCategoria.Click

        If lb_categoria.SelectedItems.Count > 0 Then

            tb_nombreS.Clear()
            tb_identS.Clear()
            tb_obsS.Clear()

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True

            bt_agregarCategoria.Enabled = False
            bt_ModificarCategoria.Enabled = False
            bt_eliminarCategoria.Enabled = False
            bt_agregarSubCategoria.Enabled = False
            bt_ModificarSubCategoria.Enabled = False
            bt_EliminarSubCategoria.Enabled = False

            lb_Subcategoria.ClearSelected()

            tb_nombreS.ReadOnly = False
            tb_identS.ReadOnly = False
            tb_obsS.ReadOnly = False
            bt_agregarS.Visible = True

            boton3 = 1

            tb_nombreS.Focus()


        Else

            MsgBox("Debe seleccionar una categoría para asociarla", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub tb_busquedaC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_busquedaC.TextChanged
        tb_nombreC.Clear()
        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()

        bt_ModificarCategoria.Enabled = False
        bt_eliminarCategoria.Enabled = False
        bt_agregarSubCategoria.Enabled = False
        bt_ModificarSubCategoria.Enabled = False
        bt_EliminarSubCategoria.Enabled = False

        lb_Subcategoria.Items.Clear()
        DatosMovimientos.consulta_categoria(lb_categoria, 0, tb_busquedaC.Text, 2)
    End Sub

    Private Sub tb_busquedaS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_busquedaS.KeyDown

        If e.KeyCode = Keys.Enter Then

            If lb_Subcategoria.Items.Count > 0 Then

                lb_Subcategoria.SelectedIndex = 0
                lb_Subcategoria.Focus()
                lb_Subcategoria.Select()

            End If

        End If

    End Sub

    Private Sub tb_busquedaS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_busquedaS.TextChanged

        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()

        If lb_categoria.SelectedItems.Count > 0 Then
            DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_categoria.SelectedItem.code.ToString), tb_busquedaS.Text, 4)
        End If

        bt_ModificarCategoria.Enabled = True
        bt_eliminarCategoria.Enabled = True
        bt_agregarSubCategoria.Enabled = True
        bt_ModificarSubCategoria.Enabled = False
        bt_EliminarSubCategoria.Enabled = False

    End Sub

    Private Sub bt_ModificarCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarCategoria.Click

        If lb_categoria.SelectedItems.Count > 0 Then

            tb_nombreC.ReadOnly = False
            bt_agregarCat.Visible = True

            bt_agregarCategoria.Enabled = False
            bt_ModificarCategoria.Enabled = False
            bt_eliminarCategoria.Enabled = False
            bt_agregarSubCategoria.Enabled = False
            bt_ModificarSubCategoria.Enabled = False
            bt_EliminarSubCategoria.Enabled = False

            boton3 = 2

            tb_nombreC.Focus()

        Else

            MsgBox("Debe seleccionar una categoría para modificar", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub bt_agregarCat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCat.Click

        If tb_nombreC.Text.Trim <> "" Then

            If boton3 = 1 Then

                DatosMovimientos.Inserta_Categoria(tb_nombreC.Text)

            ElseIf boton3 = 2 Then

                DatosMovimientos.Modifica_Categoria(tb_nombreC.Text, CInt(lb_categoria.SelectedItem.code.ToString))
                lb_Subcategoria.Items.Clear()

            End If

            DatosMovimientos.consulta_categoria(lb_categoria, 0, "", 0)

            tb_nombreS.Clear()
            tb_identS.Clear()
            tb_obsS.Clear()
            tb_nombreC.Clear()

            bt_agregarCat.Visible = False
            bt_agregarS.Visible = False

            tb_nombreC.ReadOnly = True
            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True

            bt_agregarCategoria.Enabled = True
            bt_ModificarCategoria.Enabled = False
            bt_eliminarCategoria.Enabled = False
            bt_agregarSubCategoria.Enabled = False
            bt_ModificarSubCategoria.Enabled = False
            bt_EliminarSubCategoria.Enabled = False

            boton3 = 0

        Else

            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub bt_agregarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarS.Click

        If lb_categoria.SelectedItems.Count > 0 Then

            If tb_nombreS.Text.Trim <> "" And tb_identS.Text.Trim <> "" Then

                If boton3 = 1 Then

                    DatosMovimientos.Inserta_Sub_Categoria(tb_nombreS.Text, tb_identS.Text, tb_obsS.Text, CInt(lb_categoria.SelectedItem.code.ToString))

                ElseIf boton3 = 2 Then

                    'Modificar
                    DatosMovimientos.Modifica_Sub_Categoria(tb_nombreS.Text, tb_identS.Text, tb_obsS.Text, CInt(lb_categoria.SelectedItem.code.ToString), CInt(lb_Subcategoria.SelectedItem.code.ToString))

                End If

                DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_categoria.SelectedItem.code.ToString), tb_busquedaS.Text, 4)

                tb_nombreS.Clear()
                tb_identS.Clear()
                tb_obsS.Clear()

                bt_agregarCat.Visible = False
                bt_agregarS.Visible = False

                bt_agregarCategoria.Enabled = True
                bt_ModificarCategoria.Enabled = True
                bt_eliminarCategoria.Enabled = True
                bt_agregarSubCategoria.Enabled = True
                bt_ModificarSubCategoria.Enabled = False
                bt_EliminarSubCategoria.Enabled = False

                tb_nombreS.ReadOnly = True
                tb_identS.ReadOnly = True
                tb_obsS.ReadOnly = True
                boton3 = 0

            Else

                MsgBox("Debe llenar todos los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            MsgBox("Debe seleccionar una categoría para asociar", MsgBoxStyle.Exclamation, "SINPRO")

        End If


    End Sub

    Private Sub lb_categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_categoria.SelectedIndexChanged


        If lb_categoria.SelectedItems.Count > 0 Then

            boton3 = 0

            tb_nombreC.Text = lb_categoria.SelectedItem.name.ToString
            tb_nombreC.ReadOnly = True
            bt_agregarCat.Visible = False

            bt_agregarCategoria.Enabled = True
            bt_ModificarCategoria.Enabled = True
            bt_eliminarCategoria.Enabled = True

            bt_ModificarSubCategoria.Enabled = False
            bt_EliminarSubCategoria.Enabled = False
            bt_agregarSubCategoria.Enabled = True

            tb_nombreS.Clear()
            tb_identS.Clear()
            tb_obsS.Clear()

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True

            DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_categoria.SelectedItem.code.ToString), tb_busquedaS.Text, 4)

        End If

    End Sub

    Private Sub lb_Subcategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_Subcategoria.SelectedIndexChanged

        boton3 = 0

        If lb_Subcategoria.SelectedItems.Count > 0 Then

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True
            bt_agregarS.Visible = False

            bt_agregarCategoria.Enabled = True
            bt_ModificarCategoria.Enabled = True
            bt_eliminarCategoria.Enabled = True
            bt_agregarSubCategoria.Enabled = True
            bt_ModificarSubCategoria.Enabled = True
            bt_EliminarSubCategoria.Enabled = True

            DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_Subcategoria.SelectedItem.code.ToString), tb_busquedaS.Text, 1, tb_nombreS.Text, tb_identS.Text, tb_obsS.Text)

        End If

    End Sub


    Private Sub bt_ModificarSubCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarSubCategoria.Click

        If lb_Subcategoria.SelectedItems.Count > 0 Then

            tb_nombreS.ReadOnly = True
            tb_identS.ReadOnly = True
            tb_obsS.ReadOnly = True

            bt_agregarCategoria.Enabled = False
            bt_ModificarCategoria.Enabled = False
            bt_eliminarCategoria.Enabled = False
            bt_agregarSubCategoria.Enabled = False
            bt_ModificarSubCategoria.Enabled = False
            bt_EliminarSubCategoria.Enabled = False

            tb_nombreS.ReadOnly = False
            tb_identS.ReadOnly = False
            tb_obsS.ReadOnly = False
            bt_agregarS.Visible = True

            boton3 = 2

            tb_nombreS.Focus()


        Else

            MsgBox("Debe seleccionar una sub-categoría para modificarla", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub bt_EliminarSubCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_EliminarSubCategoria.Click

        If lb_Subcategoria.SelectedItems.Count > 0 Then

            Dim borrado As Boolean = False
            DatosMovimientos.elimina_Subcategoria(CInt(lb_Subcategoria.SelectedItem.code.ToString), borrado)

            If borrado Then
                DatosMovimientos.consulta_Subcategoria(lb_Subcategoria, CInt(lb_categoria.SelectedItem.code.ToString), tb_busquedaS.Text, 4)
                tb_nombreS.Clear()
                tb_obsS.Clear()
                tb_identS.Clear()
            End If

        Else

            MsgBox("Debe seleccionar una Sub-Categoría para eliminar", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub bt_eliminarCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarCategoria.Click

        If lb_categoria.SelectedItems.Count > 0 Then

            Dim borrado As Boolean = False

            DatosMovimientos.elimina_categoria(CInt(lb_categoria.SelectedItem.code.ToString), borrado)

            If borrado Then

                DatosMovimientos.consulta_categoria(lb_categoria, 0, "", 0)
                lb_Subcategoria.Items.Clear()
                tb_nombreC.Clear()
                tb_nombreS.Clear()
                tb_obsS.Clear()
                tb_identS.Clear()

            End If

        Else

            MsgBox("Debe seleccionar una Categoría para eliminar", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub tb_busquedaC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_busquedaC.KeyDown

        If e.KeyCode = Keys.Enter Then

            If lb_categoria.Items.Count > 0 Then

                lb_categoria.SelectedIndex = 0
                lb_categoria.Focus()
                lb_categoria.Select()

            End If

        End If

    End Sub

    Private Sub bt_cancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelarC.Click

        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()
        tb_nombreC.Clear()

        bt_agregarCat.Visible = False
        bt_agregarS.Visible = False

        tb_nombreC.ReadOnly = True
        tb_nombreS.ReadOnly = True
        tb_identS.ReadOnly = True
        tb_obsS.ReadOnly = True

        bt_agregarCategoria.Enabled = True
        bt_ModificarCategoria.Enabled = False
        bt_eliminarCategoria.Enabled = False
        bt_agregarSubCategoria.Enabled = False
        bt_ModificarSubCategoria.Enabled = False
        bt_EliminarSubCategoria.Enabled = False

        boton3 = 0

    End Sub

    Private Sub bt_cancelarS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelarS.Click

        tb_nombreS.Clear()
        tb_identS.Clear()
        tb_obsS.Clear()

        bt_agregarCat.Visible = False
        bt_agregarS.Visible = False

        bt_agregarCategoria.Enabled = True
        bt_ModificarCategoria.Enabled = True
        bt_eliminarCategoria.Enabled = True
        bt_agregarSubCategoria.Enabled = True
        bt_ModificarSubCategoria.Enabled = False
        bt_EliminarSubCategoria.Enabled = False

        tb_nombreS.ReadOnly = True
        tb_identS.ReadOnly = True
        tb_obsS.ReadOnly = True
        boton3 = 0

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If tab_cobranzas.SelectedTab Is tp_ajustes Then

            If tb_montoAjustes.Text <> "" Then
                DatosConfiguracion.inserta_MontoAjuste(CDbl(tb_montoAjustes.Text))
            Else
                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")
                tb_montoAjustes.Focus()
            End If

        ElseIf tab_cobranzas.SelectedTab Is tp_asociacion Then

            If tb_monto.Text <> "" Then
                DatosConfiguracion.Modificar_monto_asociacion(CDbl(tb_monto.Text))
            Else
                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")
                tb_monto.Focus()
            End If

        End If

        Me.Close()

    End Sub

    Private Sub bt_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aplicar.Click

        If tab_cobranzas.SelectedTab Is tp_ajustes Then

            If tb_montoAjustes.Text <> "" Then
                DatosConfiguracion.inserta_MontoAjuste(CDbl(tb_montoAjustes.Text))
            Else
                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")
                tb_montoAjustes.Focus()
            End If

        ElseIf tab_cobranzas.SelectedTab Is tp_asociacion Then

            If tb_monto.Text <> "" Then
                DatosConfiguracion.Modificar_monto_asociacion(CDbl(tb_monto.Text))
            Else
                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")
                tb_monto.Focus()
            End If

        End If

    End Sub
End Class