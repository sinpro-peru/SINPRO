Public Class Frm_Configuracion_Pedidos

    Dim boton4 As Integer

    Private Sub tp_Almacen_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_Almacen.Enter
        DatosConfiguracion.llenar_almacenes(cb_almacen)
        DatosConfiguracion.consulta_Almacen(tb_almacen.Text)
    End Sub

    Private Sub tp_ArtculosPorPed_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_ArtculosPorPed.Enter
        DatosConfiguracion.ConsultaMaxArticulos(tb_maxArt.Text)
        tb_maxArt.Focus()
        tb_maxArt.SelectAll()
    End Sub

    Private Sub tp_autorizacionesPed_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_autorizacionesPed.Enter
        DatosConfiguracion.ConsultaParametrosAutorizacion(tb_MontoPedido.Text, tb_montoVencidas.Text, tb_MontoPorVencer.Text, chk_chequesDev.Checked)
        tb_montoVencidas.Focus()
        tb_montoVencidas.SelectAll()
    End Sub

    Private Sub tp_obsFactura_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_obsFactura.Enter
        DatosConfiguracion.consulta_obs(tb_obsFacturas.Text, 0)
    End Sub

    Private Sub tp_obsReportes_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_obsReportes.Enter
        DatosConfiguracion.consulta_obs(tb_obsReportes.Text, 1)
        DatosConfiguracion.consulta_obs(tb_leyenda.Text, 2)
    End Sub

    Private Sub tp_pedidosExpress_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_pedidosExpress.Enter
        chk_express.Checked = DatosConfiguracion.Consulta_pedidos_express()
    End Sub

    Private Sub tp_referencias_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_referencias.Enter
        tb_codReferencia.Clear()
        tb_buscarRef.Clear()
        tb_rifRef.Clear()
        tb_razonRef.Clear()
        tb_telefono1Ref.Clear()
        tb_telefono2Ref.Clear()
        tb_telefono3Ref.Clear()
        tb_ObsRef.Clear()

        tb_codReferencia.ReadOnly = True
        tb_buscarRef.ReadOnly = False
        tb_rifRef.ReadOnly = True
        tb_razonRef.ReadOnly = True
        tb_telefono1Ref.ReadOnly = True
        tb_telefono2Ref.ReadOnly = True
        tb_telefono3Ref.ReadOnly = True
        tb_ObsRef.ReadOnly = True

        bt_aceptarRef.Visible = False
        bt_cancelarRef.Visible = False

        boton4 = 0

        ToolBar3.Enabled = True

        DatosConfiguracion.Consulta_Empresas(DGV_Empresas, "")

        tb_buscarRef.Focus()
    End Sub

    Private Sub bt_almacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_almacen.Click
        If cb_almacen.Visible = False Then
            tb_almacen.Visible = False
            cb_almacen.Visible = True
            If cb_almacen.Items.Count > 0 Then
                cb_almacen.SelectedIndex = 0
            End If
        Else
            If cb_almacen.SelectedIndex <> -1 Then
                DatosConfiguracion.Inserta_almacen(CInt(cb_almacen.SelectedItem.code), cb_almacen.SelectedItem.name)
                cb_almacen.Visible = False
                tb_almacen.Visible = True
                DatosConfiguracion.consulta_Almacen(tb_almacen.Text)
            Else
                MsgBox("Debe seleccionar un almacén", MsgBoxStyle.Exclamation, "SINPRO")
            End If

        End If
    End Sub

    Private Sub ToolBar3_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar3.ButtonClick

        If e.Button Is Me.bt_salir3 Then

            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo3 Then

            boton4 = 1

            tb_codReferencia.Clear()
            tb_buscarRef.Clear()
            tb_rifRef.Clear()
            tb_razonRef.Clear()
            tb_telefono1Ref.Clear()
            tb_telefono2Ref.Clear()
            tb_telefono3Ref.Clear()
            tb_ObsRef.Clear()

            tb_buscarRef.ReadOnly = True
            tb_rifRef.ReadOnly = False
            tb_razonRef.ReadOnly = False
            tb_telefono1Ref.ReadOnly = False
            tb_telefono2Ref.ReadOnly = False
            tb_telefono3Ref.ReadOnly = False
            tb_ObsRef.ReadOnly = False

            bt_aceptarRef.Visible = True
            bt_cancelarRef.Visible = True

            ToolBar3.Enabled = False

            DatosConfiguracion.Consulta_Id_Empresa(tb_codReferencia.Text)

            tb_razonRef.Focus()

        ElseIf e.Button Is Me.bt_modificar3 Then
            Dim n As Integer
            n = DGV_Empresas.SelectedRows.Count
            If n = 0 Then
                MsgBox("Debe seleccionar la empresa que desea modificar", MsgBoxStyle.Critical)
            ElseIf n = 1 Then


                boton4 = 2
                tb_buscarRef.ReadOnly = True
                tb_rifRef.ReadOnly = False
                tb_razonRef.ReadOnly = False
                tb_telefono1Ref.ReadOnly = False
                tb_telefono2Ref.ReadOnly = False
                tb_telefono3Ref.ReadOnly = False
                tb_ObsRef.ReadOnly = False

                bt_aceptarRef.Visible = True
                bt_cancelarRef.Visible = True

                ToolBar3.Enabled = False

                tb_razonRef.Focus()
                tb_razonRef.SelectAll()


            End If
        ElseIf e.Button Is Me.bt_eliminar3 Then
            Dim n As Integer
            n = DGV_Empresas.SelectedRows.Count

            boton4 = 3

            If n = 0 Then
                MsgBox("Elija la empresa a eliminar", MsgBoxStyle.Critical, "Eliminar")
            ElseIf n = 1 Then

                If MsgBox("¿Está seguro que desea eliminar la empresa " & DGV_Empresas.SelectedRows(0).Cells(1).Value & "?", MsgBoxStyle.YesNo, "Confirmar Eliminación") = MsgBoxResult.Yes Then

                    DatosConfiguracion.Elimina_Empresa(DGV_Empresas.SelectedRows(0).Cells(0).Value)

                    tb_codReferencia.Clear()
                    tb_rifRef.Clear()
                    tb_razonRef.Clear()
                    tb_telefono1Ref.Clear()
                    tb_telefono2Ref.Clear()
                    tb_telefono3Ref.Clear()
                    tb_ObsRef.Clear()

                    DatosConfiguracion.Consulta_Empresas(DGV_Empresas, tb_buscarRef.Text)


                End If
            End If
        End If
    End Sub

    Private Sub bt_aceptarRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptarRef.Click

        Dim deny As Boolean = True

        If tb_rifRef.Text.Trim <> "" And tb_razonRef.Text.Trim <> "" And tb_telefono1Ref.Text.Trim <> "" Then

            If boton4 = 1 Then
                DatosConfiguracion.Inserta_Empresa(tb_rifRef.Text, tb_razonRef.Text, tb_telefono1Ref.Text, tb_telefono2Ref.Text, tb_telefono3Ref.Text, tb_ObsRef.Text)
                deny = False
            ElseIf boton4 = 2 Then
                DatosConfiguracion.Modifica_Empresa(tb_rifRef.Text, tb_razonRef.Text, tb_telefono1Ref.Text, tb_telefono2Ref.Text, tb_telefono3Ref.Text, tb_ObsRef.Text, tb_codReferencia.Text)
                deny = False
            End If



        Else

            MsgBox("Debe llenar todos los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

        End If

        If deny = False Then

            tb_codReferencia.Clear()
            tb_buscarRef.Clear()
            tb_rifRef.Clear()
            tb_razonRef.Clear()
            tb_telefono1Ref.Clear()
            tb_telefono2Ref.Clear()
            tb_telefono3Ref.Clear()
            tb_ObsRef.Clear()

            tb_codReferencia.ReadOnly = True
            tb_buscarRef.ReadOnly = False
            tb_rifRef.ReadOnly = True
            tb_razonRef.ReadOnly = True
            tb_telefono1Ref.ReadOnly = True
            tb_telefono2Ref.ReadOnly = True
            tb_telefono3Ref.ReadOnly = True
            tb_ObsRef.ReadOnly = True

            bt_aceptarRef.Visible = False
            bt_cancelarRef.Visible = False

            ToolBar3.Enabled = True

            DatosConfiguracion.Consulta_Empresas(DGV_Empresas, tb_buscarRef.Text)

            tb_buscarRef.Focus()

        End If

    End Sub

    Private Sub DGV_Empresas_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Empresas.CellClick, DGV_Empresas.KeyDown, DGV_Empresas.KeyUp

        If DGV_Empresas.SelectedRows.Count > 0 Then

            DatosConfiguracion.Consulta_Empresa(tb_rifRef.Text, tb_razonRef.Text, tb_telefono1Ref.Text, tb_telefono2Ref.Text, tb_telefono3Ref.Text, tb_ObsRef.Text, CInt(DGV_Empresas.SelectedRows(0).Cells(0).Value))
            tb_codReferencia.Text = DGV_Empresas.SelectedRows(0).Cells(0).Value.ToString

        End If

    End Sub

    Private Sub bt_cancelarRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelarRef.Click

        tb_codReferencia.Clear()
        tb_rifRef.Clear()
        tb_razonRef.Clear()
        tb_telefono1Ref.Clear()
        tb_telefono2Ref.Clear()
        tb_telefono3Ref.Clear()
        tb_ObsRef.Clear()

        tb_codReferencia.ReadOnly = True
        tb_buscarRef.ReadOnly = False
        tb_rifRef.ReadOnly = True
        tb_razonRef.ReadOnly = True
        tb_telefono1Ref.ReadOnly = True
        tb_telefono2Ref.ReadOnly = True
        tb_telefono3Ref.ReadOnly = True
        tb_ObsRef.ReadOnly = True

        bt_aceptarRef.Visible = False
        bt_cancelarRef.Visible = False

        ToolBar3.Enabled = True

        tb_buscarRef.Focus()

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If tab_pedidos.SelectedTab Is tp_ArtculosPorPed Then

            If tb_maxArt.Text <> "" Then

                DatosConfiguracion.ActualizaMaxArt(CInt(tb_maxArt.Text))
                MsgBox("Máximo de articulos registrado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

            Else

                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")

            End If

        ElseIf tab_pedidos.SelectedTab Is tp_autorizacionesPed Then

            If tb_MontoPedido.Text <> "" And tb_MontoPorVencer.Text <> "" And tb_montoVencidas.Text <> "" Then

                DatosConfiguracion.ActualizaParametrosAutorizacion(CDbl(tb_MontoPedido.Text), CDbl(tb_montoVencidas.Text), CDbl(tb_MontoPorVencer.Text), chk_chequesDev.Checked)
                MsgBox("Parámentros registrados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

            Else

                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")

            End If

        ElseIf tab_pedidos.SelectedTab Is tp_obsFactura Then

            DatosConfiguracion.Modifica_Obs(tb_obsFacturas.Text, "", "", 0)
            MsgBox("Parámetro modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf tab_pedidos.SelectedTab Is tp_obsReportes Then

            DatosConfiguracion.Modifica_Obs("", tb_obsReportes.Text, "", 1)
            DatosConfiguracion.Modifica_Obs("", "", tb_leyenda.Text, 2)
            MsgBox("Parámetros modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf tab_pedidos.SelectedTab Is tp_pedidosExpress Then

            DatosConfiguracion.Modifica_pedidos_express(chk_express.Checked)
            MsgBox("Parámetro modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        End If

        Me.Close()

    End Sub

    Private Sub tb_buscarRef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscarRef.TextChanged

        DatosConfiguracion.Consulta_Empresas(DGV_Empresas, tb_buscarRef.Text)

        tb_codReferencia.Clear()
        tb_rifRef.Clear()
        tb_razonRef.Clear()
        tb_telefono1Ref.Clear()
        tb_telefono2Ref.Clear()
        tb_telefono3Ref.Clear()
        tb_ObsRef.Clear()

    End Sub

    Private Sub bt_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aplicar.Click
        If tab_pedidos.SelectedTab Is tp_ArtculosPorPed Then

            If tb_maxArt.Text <> "" Then

                DatosConfiguracion.ActualizaMaxArt(CInt(tb_maxArt.Text))
                MsgBox("Máximo de articulos registrado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

            Else

                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")

            End If

        ElseIf tab_pedidos.SelectedTab Is tp_autorizacionesPed Then

            If tb_MontoPedido.Text <> "" And tb_MontoPorVencer.Text <> "" And tb_montoVencidas.Text <> "" Then

                DatosConfiguracion.ActualizaParametrosAutorizacion(CDbl(tb_MontoPedido.Text), CDbl(tb_montoVencidas.Text), CDbl(tb_MontoPorVencer.Text), chk_chequesDev.Checked)
                MsgBox("Parámentros registrados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

            Else

                MsgBox("Debe llenar los campos obligatorios", MsgBoxStyle.Exclamation, "Error")

            End If

        ElseIf tab_pedidos.SelectedTab Is tp_obsFactura Then

            DatosConfiguracion.Modifica_Obs(tb_obsFacturas.Text, "", "", 0)
            MsgBox("Parámetro modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf tab_pedidos.SelectedTab Is tp_obsReportes Then

            DatosConfiguracion.Modifica_Obs("", tb_obsReportes.Text, "", 1)
            DatosConfiguracion.Modifica_Obs("", "", tb_leyenda.Text, 2)
            MsgBox("Parámetros modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf tab_pedidos.SelectedTab Is tp_pedidosExpress Then

            DatosConfiguracion.Modifica_pedidos_express(chk_express.Checked)
            MsgBox("Parámetro modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        End If
    End Sub
End Class