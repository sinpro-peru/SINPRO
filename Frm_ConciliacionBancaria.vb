Public Class Frm_ConciliacionBancaria

    Public User As String = ""

    Private Sub bt_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_salir.Click
        Me.Close()
    End Sub

    Private Sub Frm_ConciliacionBancaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.sp_consulta_Movimientos_Asociados' table. You can move, or remove it, as needed.
        Me.Sp_consulta_Movimientos_AsociadosTableAdapter.Fill(Me.MELDataSet.sp_consulta_Movimientos_Asociados)

        chk_fecha.Checked = True

        dtp_desde.Value = "01/" & Month(Today).ToString & "/" & Year(Today).ToString
        dtp_hasta.Value = Today

    End Sub

    Private Sub chk_banco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_banco.CheckedChanged

        If chk_banco.Checked = True Then

            DatosMovimientos.consulta_bancos_depositos(cb_bancos)

            cb_bancos.Enabled = True
            If cb_bancos.Items.Count > 0 Then
                cb_bancos.SelectedIndex = 0
            End If

        Else

            cb_bancos.Enabled = False
            cb_bancos.Items.Clear()

        End If

        CrearWhere()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'TODO: This line of code loads data into the 'MELDataSet.sp_consulta_Movimientos_Asociados' table. You can move, or remove it, as needed.
        Me.Sp_consulta_Movimientos_AsociadosTableAdapter.Fill(Me.MELDataSet.sp_consulta_Movimientos_Asociados)
        CrearWhere()
        dgv_movimientos.ClearSelection()

    End Sub

    Private Sub chk_fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_fecha.CheckedChanged

        dtp_desde.Enabled = chk_fecha.Checked
        dtp_hasta.Enabled = chk_fecha.Checked

        CrearWhere()

    End Sub

    Private Sub cb_bancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_bancos.SelectedIndexChanged
        CrearWhere()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_categoria.CheckedChanged

        cb_categoria.Enabled = chk_categoria.Checked

        If Not chk_categoria.Checked Then
            cb_categoria.Items.Clear()
            chk_subCategoria.Checked = False
        Else
            DatosMovimientos.consulta_categorias(cb_categoria, "", 0, 0)
            If cb_categoria.Items.Count > 0 Then
                cb_categoria.SelectedIndex = 0
            End If
            If chk_subCategoria.Checked Then
                If cb_categoria.SelectedIndex <> -1 Then
                    DatosMovimientos.consulta_subcategorias(cb_subCategoria, "", CInt(cb_categoria.SelectedItem.code), 4)
                End If
            End If
            End If

            chk_subCategoria.Enabled = chk_categoria.Checked
            CrearWhere()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_categoria.SelectedIndexChanged
        CrearWhere()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_subCategoria.CheckedChanged
        cb_subCategoria.Enabled = chk_subCategoria.Checked
        If Not chk_subCategoria.Checked Then
            cb_subCategoria.Items.Clear()
        Else
            If cb_categoria.SelectedIndex <> -1 Then
                DatosMovimientos.consulta_subcategorias(cb_subCategoria, "", CInt(cb_categoria.SelectedItem.code), 4)
                If cb_subCategoria.Items.Count > 0 Then
                    cb_subCategoria.SelectedIndex = 0
                End If
            End If
        End If
        CrearWhere()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_subCategoria.SelectedIndexChanged
        CrearWhere()
    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If chk_banco.Checked And cb_bancos.SelectedIndex <> -1 Then

            where = where + y + "Banco = '" & cb_bancos.Text & "'"
            y = " and "

        End If

        If chk_fecha.Checked Then

            where = where + y + "Fecha >= '" & dtp_desde.Value.ToString & "' and Fecha <= '" & dtp_hasta.Value.ToString & "'"
            y = " and "

        End If

        If chk_categoria.Checked Then

            where = where + y + "NombreC = '" & cb_categoria.Text & "'"
            y = " and "

        End If

        If chk_subCategoria.Checked Then

            where = where + y + "NombreS = '" & cb_subCategoria.Text & "'"
            y = " and "

        End If

        SpconsultaMovimientosAsociadosBindingSource.Filter = where
        dgv_movimientos.ClearSelection()

    End Sub

    Private Sub dtp_desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_desde.ValueChanged

        If dtp_desde.Enabled Then
            CrearWhere()
        End If

    End Sub

    Private Sub dtp_hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_hasta.ValueChanged
        If dtp_hasta.Enabled Then
            CrearWhere()
        End If
    End Sub
End Class