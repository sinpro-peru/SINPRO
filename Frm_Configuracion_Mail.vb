Public Class Frm_Configuracion_Mail

    Private Sub tp_correos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tp_correos.Enter
        DatosCorreos.Consultar_Config_Correos(DGV_Eventos)
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If tab_correos.SelectedTab Is tp_correos Then
            DatosCorreos.Modificar_Config_Correos(DGV_Eventos)
            MsgBox("Parámetros modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
        ElseIf tab_correos.SelectedTab Is tp_correosListados Then

        End If

        Me.Close()

    End Sub

    Private Sub bt_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aplicar.Click

        If tab_correos.SelectedTab Is tp_correos Then
            DatosCorreos.Modificar_Config_Correos(DGV_Eventos)
            MsgBox("Parámetros modificado satisfactoriamente", MsgBoxStyle.Information, "SINPRO")
        ElseIf tab_correos.SelectedTab Is tp_correosListados Then

        End If

    End Sub

    Private Sub Frm_Configuracion_Mail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatosCorreos.Consultar_Config_Correos(DGV_Eventos)
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub
End Class