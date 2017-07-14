Public Class Frm_Parametro_Fecha

    Dim tipo As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tipo = 0 Then
            Dim r_fac As New R_FacturasPagadas
            r_fac.valores_FacturasPagadas(Me.DateTimePicker1.Value.Date, Me.DateTimePicker2.Value.Date)
            r_fac.Show()
            Me.Close()
        ElseIf tipo = 1 Then
            Dim frm As New R_ProductosDanados
            frm.recibe(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, "", 0)
            frm.Show()
            Me.Close()
        ElseIf tipo = 2 Then
            Dim frm As New R_LibroVentas
            frm.recibe(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            frm.Show()
            Me.Close()
        End If
    End Sub

    Public Sub recibe(ByVal Tip As Integer)
        tipo = Tip
    End Sub

    Private Sub Frm_Parametro_Fecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text
    End Sub
End Class