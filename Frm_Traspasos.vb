Public Class Frm_Traspasos

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacen.SelectedValueChanged, cb_almacen2.SelectedValueChanged

        If sender Is Me.cb_almacen Then
            DatosAlmacenes.llenar_cuartos(cb_cuarto, cb_almacen.SelectedValue)
        Else
            DatosAlmacenes.llenar_cuartos(cb_cuarto2, cb_almacen2.SelectedValue)
        End If

    End Sub

    Private Sub cb_cuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuarto.SelectedValueChanged, cb_cuarto2.SelectedValueChanged

        If sender Is Me.cb_cuarto Then
            DatosAlmacenes.llenar_estantes(cb_estante, cb_cuarto.SelectedValue)
        Else
            DatosAlmacenes.llenar_estantes(cb_estante2, cb_cuarto2.SelectedValue)
        End If

    End Sub

    Private Sub cb_estante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estante.SelectedValueChanged, cb_estante2.SelectedValueChanged

        If sender Is Me.cb_estante Then
            DatosAlmacenes.llenar_tramos(cb_tramo, cb_estante.SelectedValue)
        Else
            DatosAlmacenes.llenar_tramos(cb_tramo2, cb_estante2.SelectedValue)
        End If

    End Sub


    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Close()
        Frm_Almacenes.Show()
        Frm_Almacenes.Focus()
    End Sub

    Private Sub Frm_Traspasos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Table_Almacen' Puede moverla o quitarla según sea necesario.
        Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)
        cb_almacen.ResetText()
        cb_almacen2.ResetText()
        cb_cuarto.ResetText()
        cb_cuarto2.ResetText()
        cb_estante.ResetText()
        cb_estante2.ResetText()
        cb_tramo.ResetText()
        cb_tramo2.ResetText()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim Desde As String = ""
        Dim hasta As String = ""

        If cb_cuarto.Text = "*" Then

            Desde = cb_almacen.Text

        ElseIf cb_estante.Text = "*" Then

            Desde = cb_almacen.Text + "-" + cb_cuarto.Text

        ElseIf cb_tramo.Text = "*" Then

            Desde = cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text
        Else

            Desde = cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text

        End If

        If cb_cuarto2.Text = "*" Then

            hasta = cb_almacen2.Text

        ElseIf cb_estante2.Text = "*" Then

            hasta = cb_almacen2.Text + "-" + cb_cuarto2.Text

        ElseIf cb_tramo2.Text = "*" Then

            hasta = cb_almacen2.Text + "-" + cb_cuarto2.Text + "-" + cb_estante2.Text

        Else

            hasta = cb_almacen2.Text + "-" + cb_cuarto2.Text + "-" + cb_estante2.Text + "-" + cb_tramo2.Text

        End If

        If Not cb_tramo.Text = "" And Not cb_tramo2.Text = "" Then

            If cb_cuarto.Text = "*" Then

                DatosAlmacenes.Traspasos_Almacenes(cb_tramo2.SelectedValue, cb_almacen.SelectedValue, Desde, Hasta)

            ElseIf cb_estante.Text = "*" Then

                DatosAlmacenes.Traspasos_Cuartos(cb_tramo2.SelectedValue, cb_cuarto.SelectedValue, Desde, Hasta)

            ElseIf cb_tramo.Text = "*" Then

                DatosAlmacenes.Traspasos_Almacenes(cb_tramo2.SelectedValue, cb_estante.SelectedValue, Desde, Hasta)

            Else

                DatosAlmacenes.Traspasos_Tramos(cb_tramo.SelectedValue, cb_tramo2.SelectedValue, Desde, Hasta)

            End If

            Frm_Almacenes.Llenar_DGVs_Almacen()
            cb_almacen.ResetText()
            cb_almacen2.ResetText()
            cb_cuarto.ResetText()
            cb_cuarto2.ResetText()
            cb_estante.ResetText()
            cb_estante2.ResetText()
            cb_tramo.ResetText()
            cb_tramo2.ResetText()


        Else
            MsgBox("Existe un campo obligatorio vacío", MsgBoxStyle.Critical)
        End If

    End Sub
End Class