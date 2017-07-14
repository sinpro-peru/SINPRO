Public Class Frm_Mult_Mod_Ubi
    Private row As Integer
    Private cant As Integer
    Private total As Integer
    Private frm As Frm_Pedidos_Clientes

    Public Sub valores(ByVal cod As String, ByVal cant3 As String, ByVal rowv As Integer, ByVal frm2 As Frm_Pedidos_Clientes, ByVal cant2 As Integer)
        DatosPedidoCliente.consulta_producto_modelos(cod, lb_modelos)
        lb_modelos.SelectedIndex = 0
        DatosPedidoCliente.consulta_producto_ubicacion(Me.Dgv_Ubicacion, cod, cant3)
        cant = cant2
        total = cant3
        row = rowv
        frm = frm2
        Me.Button1.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If frm.DGV2.RowCount > 0 Then
            Dim index As Integer = frm.DGV2.SelectedRows(0).Index
            frm.Enabled = True
            frm.Focus()
            frm.DGV2.Focus()
            If frm.DGV2.RowCount > 0 Then
                frm.DGV2.Rows(index).Cells(0).Selected = True
                frm.DGV2.BeginEdit(True)
            End If
        End If
        Me.Close()
    End Sub
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim acum As Integer = 0
        Dim sw As Boolean = False
        Dim sw2 As Boolean = False
        Dim sw3 As Boolean = False
        While i < Me.Dgv_Ubicacion.Rows.Count And sw = False
            If Me.Dgv_Ubicacion(2, i).Value IsNot Nothing And Not Me.Dgv_Ubicacion(2, i).Value = "" Then
                sw2 = True
                If CInt(Me.Dgv_Ubicacion(2, i).Value) > CInt(Me.Dgv_Ubicacion(1, i).Value) Then
                    sw = True
                Else
                    acum = acum + CInt(Me.Dgv_Ubicacion(2, i).Value)
                End If
            End If
            i = i + 1
        End While
        If sw = False Then
            If acum > total Then
                sw3 = True
            End If
        End If

        If sw = True Then
            MsgBox("La cantidad a pedir no puede ser mayor a la existente en la ubicación seleccionada.")
        ElseIf sw2 = False Or acum = 0 Then
            MsgBox("Oops! No has agregado cantidad. Por favor hazlo o presiona el botón Cancelar.")
        ElseIf sw3 = True Then
            MsgBox("La cantidad a pedir no puede ser mayor a la solicitada (" & total.ToString & ").")
        Else
            If frm.DGV2.RowCount > 0 Then
                If frm.DGV2.SelectedRows(0).Index <> frm.DGV2.RowCount - 1 Then
                    Dim index As Integer = frm.DGV2.SelectedRows(0).Index
                    Frm_Principal.Frm_Pedidos_Clientes.ObtenerValoresFila(Me.lb_modelos.Text, Me.Dgv_Ubicacion, row, cant)
                    Frm_Principal.Frm_Pedidos_Clientes.DGV_Productos_Pedido.ClearSelection()
                    frm.Enabled = True
                    frm.Focus()
                    frm.DGV2.Focus()
                    If frm.DGV2.RowCount > 0 Then

                        If index >= frm.DGV2.RowCount Then

                            frm.DGV2.Rows(index - 1).Cells(0).Selected = True

                        Else

                            frm.DGV2.Rows(index).Cells(0).Selected = True

                        End If

                    End If
                Else
                    Dim index As Integer = frm.DGV2.SelectedRows(0).Index - 1
                    Frm_Principal.Frm_Pedidos_Clientes.ObtenerValoresFila(Me.lb_modelos.Text, Me.Dgv_Ubicacion, row, cant)
                    Frm_Principal.Frm_Pedidos_Clientes.DGV_Productos_Pedido.ClearSelection()
                    frm.Enabled = True
                    frm.Focus()
                    frm.DGV2.Focus()
                    If frm.DGV2.RowCount > 0 And index <> -1 Then
                        frm.DGV2.Rows(index).Cells(0).Selected = True
                    End If
                End If
            End If

            'frm.DGV2_Key(frm.DGV2, New Windows.Forms.KeyEventArgs(Keys.Up))
            'frm.DGV2.BeginEdit(True)
            Me.Close()
        End If
    End Sub

    Private Sub Dgv_Ubicacion_CellClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Dgv_Ubicacion.CellClick, Dgv_Ubicacion.KeyUp, Dgv_Ubicacion.KeyDown

        Dgv_Ubicacion.SelectedRows(0).Cells(2).Selected = True

    End Sub

    Private Sub Frm_Mult_Mod_Ubi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frm.DGV2.RowCount > 0 And frm.DGV2.SelectedRows.Count > 0 Then
            Dim index As Integer = frm.DGV2.SelectedRows(0).Index
            frm.Enabled = True
            frm.Focus()
            frm.DGV2.Focus()
            If frm.DGV2.RowCount > 0 Then
                frm.DGV2.Rows(index).Cells(0).Selected = True
                frm.DGV2.BeginEdit(True)
            End If
        End If
    End Sub

    Private Sub Frm_Mult_Mod_Ubi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text
    End Sub
End Class