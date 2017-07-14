Public Class Frm_OcultarColmumnas

    Dim dgvC As DataGridView
    Dim dgvP As DataGridView
    Dim frm As Frm_Compras

    Private Sub Frm_OcultarColmumnas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm.Enabled = True
    End Sub

    Private Sub Frm_OcultarColmumnas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        For i As Integer = 0 To dgvC.ColumnCount - 1

            DGV_Compras.Rows.Add(dgvC.Columns(i).Visible, dgvC.Columns(i).HeaderText)

        Next

        For j As Integer = 0 To dgvP.ColumnCount - 1

            DGV_Pedidos.Rows.Add(dgvP.Columns(j).Visible, dgvP.Columns(j).HeaderText)

        Next

        DGV_Compras.Rows(6).Visible = False
        DGV_Compras.Rows(7).Visible = False

        DGV_Compras.ClearSelection()
        DGV_Pedidos.ClearSelection()

    End Sub

    Public Sub recibe(ByVal dgv1 As DataGridView, ByVal dgv2 As DataGridView, ByVal frm2 As Frm_Compras)

        dgvC = dgv1
        dgvP = dgv2
        frm = frm2

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For i As Integer = 0 To DGV_Compras.RowCount - 1

            dgvC.Columns(i).Visible = DGV_Compras.Rows(i).Cells(0).Value

        Next

        For j As Integer = 0 To DGV_Pedidos.RowCount - 1

            dgvP.Columns(j).Visible = DGV_Pedidos.Rows(j).Cells(0).Value

        Next

        DGV_Compras.Rows(0).ReadOnly = False
        DGV_Pedidos.Rows(0).ReadOnly = False
        dgvC.ScrollBars = ScrollBars.Both
        dgvP.ScrollBars = ScrollBars.Both

        frm.Enabled = True
        Me.Close()

    End Sub
End Class