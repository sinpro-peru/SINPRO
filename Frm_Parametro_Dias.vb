Public Class Frm_Parametro_Dias

    Public Tipo As Integer

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Frm_Parametro_Dias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Datos.consultaDiasResaltar(tb_dias.Text)
        tb_dias.Focus()
        tb_dias.SelectAll()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Datos.ModificaDiasResaltar(tb_dias.Text)

        If Tipo = 0 Then
            Dim r_Lis_Alf_fab As New R_Listado_AlfabeticoFabrica
            r_Lis_Alf_fab.Show()
        ElseIf Tipo = 1 Then
            Dim r_LisC As New R_Listado_Modelo_Cantidad
            r_LisC.Show()
        End If

        Me.Close()

    End Sub
End Class