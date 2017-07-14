Public Class Frm_Configuracion_Web

    Private Sub Frm_Configuracion_Web_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MELDataSet.Tbl_Grupo' table. You can move, or remove it, as needed.
        Me.Tbl_GrupoTableAdapter.Fill(Me.MELDataSet.Tbl_Grupo, 0, 0, "")
    End Sub

    Private Sub tp_funciones_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_funciones.Enter

        DatosConfiguracion.Consulta_funciones_activas_web(chk_ped.Checked, chk_dev.Checked, chk_rec.Checked, chk_listados.Checked)

    End Sub

    Private Sub tp_comentarios_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_comentarios.Enter

        If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then
            'Aqui va la lectura del TXT
            Datos.LeeTxt(tb_comentarioWeb.Text, 0)
            Datos.LeeTxt(tb_comentarioWeb2.Text, 1)
        Else
            DatosConfiguracion.consulta_mensaje_bienvenida(tb_comentarioWeb.Text, tb_comentarioWeb2.Text, tb_comentarioWeb3.Text, tb_comentarioWeb4.Text, tb_tituloV.Text, tb_tituloC.Text, tb_tituloA.Text, tb_tituloAd.Text)
        End If

    End Sub


    Private Sub tp_resaltarCompras_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_resaltarCompras.Enter

        Datos.consultaDiasResaltar(tb_diasResaltar.Text)

    End Sub

    Private Sub bt_aceptarIva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptarIva.Click

        If Tab_Web.SelectedTab Is tp_comentarios Then

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                Dim suc1 As Boolean = Datos.EscribeTxt(tb_comentarioWeb.Text, 0)
                Dim suc2 As Boolean = Datos.EscribeTxt(tb_comentarioWeb2.Text, 1)

                If suc1 And suc2 Then
                    MsgBox("Archivos modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
                Else
                    MsgBox("Error modificando archivos puede ser que los archivos estén en uso", MsgBoxStyle.Critical, "Error")
                End If

            Else
                DatosConfiguracion.Modifica_Mensaje_Bienvenida(tb_comentarioWeb.Text, tb_comentarioWeb2.Text, tb_comentarioWeb3.Text, tb_comentarioWeb4.Text, tb_tituloV.Text, tb_tituloC.Text, tb_tituloA.Text, tb_tituloAd.Text)
                MsgBox("Parámetros modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
            End If

        ElseIf Tab_Web.SelectedTab Is tp_funciones Then

            DatosConfiguracion.Modifica_funciones_activas_web(chk_ped.Checked, chk_dev.Checked, chk_rec.Checked, chk_listados.Checked)
            MsgBox("Parámetros modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf Tab_Web.SelectedTab Is tp_resaltarCompras Then

            Datos.ModificaDiasResaltar(tb_diasResaltar.Text)
            MsgBox("Parámetro modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf Tab_Web.SelectedTab Is tp_OcultarGrupos Then
            DatosConfiguracion.Modificar_Grupos_Ocultos(DGV_GruposWeb)
            MsgBox("Parámetros modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
        End If

        Me.Close()

    End Sub

    Private Sub bt_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aplicar.Click

        If Tab_Web.SelectedTab Is tp_comentarios Then

            If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                Dim suc1 As Boolean = Datos.EscribeTxt(tb_comentarioWeb.Text, 0)
                Dim suc2 As Boolean = Datos.EscribeTxt(tb_comentarioWeb2.Text, 1)

                If suc1 And suc2 Then
                    MsgBox("Archivos modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
                Else
                    MsgBox("Error modificando archivos puede ser que los archivos estén en uso", MsgBoxStyle.Critical, "Error")
                End If

            Else
                DatosConfiguracion.Modifica_Mensaje_Bienvenida(tb_comentarioWeb.Text, tb_comentarioWeb2.Text, tb_comentarioWeb3.Text, tb_comentarioWeb4.Text, tb_tituloV.Text, tb_tituloC.Text, tb_tituloA.Text, tb_tituloAd.Text)
            End If

        ElseIf Tab_Web.SelectedTab Is tp_funciones Then

            DatosConfiguracion.Modifica_funciones_activas_web(chk_ped.Checked, chk_dev.Checked, chk_rec.Checked, chk_listados.Checked)
            MsgBox("Parámetros modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf Tab_Web.SelectedTab Is tp_resaltarCompras Then

            Datos.ModificaDiasResaltar(tb_diasResaltar.Text)
            MsgBox("Parámetro modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")

        ElseIf Tab_Web.SelectedTab Is tp_OcultarGrupos Then
            DatosConfiguracion.Modificar_Grupos_Ocultos(DGV_GruposWeb)
            MsgBox("Parámetros modificados satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
        End If

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_agregarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarGrupo.Click

        If DGV_Grupos.SelectedRows.Count > 0 Then
            DGV_GruposWeb.Rows.Add(DGV_Grupos.SelectedRows(0).Cells(0).Value, DGV_Grupos.SelectedRows(0).Cells(1).Value)
            DGV_Grupos.Rows.RemoveAt(DGV_Grupos.SelectedRows(0).Index)
            DGV_Grupos.ClearSelection()
            DGV_GruposWeb.ClearSelection()
        End If

    End Sub

    Private Sub tp_OcultarGrupos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_OcultarGrupos.Enter
        DatosConfiguracion.Consultar_Grupos_No_Ocultos(DGV_Grupos)
        DatosConfiguracion.Consultar_Grupos_Ocultos(DGV_GruposWeb)
        DGV_Grupos.ClearSelection()
        DGV_GruposWeb.ClearSelection()
    End Sub

    Private Sub bt_eliminarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarGrupo.Click
        If DGV_GruposWeb.SelectedRows.Count > 0 Then
            DGV_Grupos.Rows.Add(DGV_GruposWeb.SelectedRows(0).Cells(0).Value, DGV_GruposWeb.SelectedRows(0).Cells(1).Value)
            DGV_GruposWeb.Rows.RemoveAt(DGV_GruposWeb.SelectedRows(0).Index)
            DGV_Grupos.ClearSelection()
            DGV_GruposWeb.ClearSelection()
        End If
    End Sub


End Class