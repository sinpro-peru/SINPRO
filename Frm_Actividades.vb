Public Class Frm_Actividades

    Public User As String

    Private Sub Frm_Actividades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MELDataSet.sp_consulta_actividades_SINPRO' table. You can move, or remove it, as needed.
        Me.Sp_consulta_actividades_SINPROTableAdapter.Fill(Me.MELDataSet.sp_consulta_actividades_SINPRO)

        DomainUpDown1.SelectedIndex = 0
        DGV_Actividades.ClearSelection()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        DateTimePicker1.Enabled = CheckBox1.Checked
        DateTimePicker2.Enabled = CheckBox1.Checked
    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If DomainUpDown1.SelectedIndex = 0 Then

            where = where + y + "Actividad LIKE '%" & tb_buscar.Text & "%'"
            y = " and "

        ElseIf DomainUpDown1.SelectedIndex = 1 Then

            where = where + y + "Usuario LIKE '%" & tb_buscar.Text & "%'"
            y = " and "

        End If

        If CheckBox1.Checked Then

            where = where + y + "Fecha >= '" & DateTimePicker1.Value & "' AND Fecha <= '" & DateTimePicker2.Value & "'"

        End If

        Sp_consulta_actividades_SINPROBindingSource.Filter = where
        DGV_Actividades.ClearSelection()

    End Sub

    Private Sub tb_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_buscar.TextChanged
        CrearWhere()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        If DateTimePicker1.Enabled Then
            CrearWhere()
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

        If DateTimePicker2.Enabled Then
            CrearWhere()
        End If

    End Sub
End Class