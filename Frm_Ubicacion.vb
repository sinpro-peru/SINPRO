Public Class Frm_Ubicacion

    Public frm As Frm_Inventario
    Public frm2 As Frm_Ajustes
    Public index As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click

        Me.Close()

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Try

            If Not frm Is Nothing Then

                If cb_almacen.SelectedIndex <> -1 And cb_cuarto.SelectedIndex <> -1 And cb_estante.SelectedIndex <> -1 And cb_tramo.SelectedIndex <> -1 Then

                    If frm.DGV_Productos.Visible Then

                        frm.DGV_Productos.Rows(index).Cells(7).Value = frm.Tb_Descripcion.Text
                        frm.DGV_Productos.Rows(index).Cells(9).Value = cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text
                        frm.DGV_Productos.Rows(index).Cells(10).Value = CInt(Me.cb_tramo.Items.Item(cb_tramo.SelectedIndex).code)
                        frm.DGV_Productos.Rows(index).Cells(11).Value = CInt(Me.cb_estante.Items.Item(cb_estante.SelectedIndex).code)
                        frm.DGV_Productos.Rows(index).Cells(12).Value = CInt(Me.cb_cuarto.Items.Item(cb_cuarto.SelectedIndex).code)
                        frm.DGV_Productos.Rows(index).Cells(13).Value = CInt(Me.cb_almacen.Items.Item(cb_almacen.SelectedIndex).code)

                        If Not frm.DGV_Productos.Rows(index).Cells(5).Value Is System.DBNull.Value Then
                            frm.DGV_Productos.Rows(index).Cells(6).Value = CInt(frm.DGV_Productos.Rows(index).Cells(5).Value) - CInt(frm.DGV_Productos.Rows(index).Cells(4).Value)
                        Else
                            frm.DGV_Productos.Rows(index).Cells(6).Value = CInt(frm.DGV_Productos.Rows(index).Cells(5).Value) - CInt(frm.DGV_Productos.Rows(index).Cells(4).Value)
                        End If

                    Else

                        frm.Dgv_ProductosI.Rows(index).Cells(7).Value = frm.Tb_Descripcion.Text
                        frm.Dgv_ProductosI.Rows(index).Cells(8).Value = cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text
                        frm.Dgv_ProductosI.Rows(index).Cells(9).Value = CInt(Me.cb_tramo.Items.Item(cb_tramo.SelectedIndex).code)
                        frm.Dgv_ProductosI.Rows(index).Cells(10).Value = CInt(Me.cb_estante.Items.Item(cb_estante.SelectedIndex).code)
                        frm.Dgv_ProductosI.Rows(index).Cells(11).Value = CInt(Me.cb_cuarto.Items.Item(cb_cuarto.SelectedIndex).code)
                        frm.Dgv_ProductosI.Rows(index).Cells(12).Value = CInt(Me.cb_almacen.Items.Item(cb_almacen.SelectedIndex).code)

                        If Not frm.Dgv_ProductosI.Rows(index).Cells(5).Value Is System.DBNull.Value Then
                            frm.Dgv_ProductosI.Rows(index).Cells(6).Value = CInt(frm.Dgv_ProductosI.Rows(index).Cells(5).Value) - CInt(frm.Dgv_ProductosI.Rows(index).Cells(4).Value)
                        Else
                            frm.Dgv_ProductosI.Rows(index).Cells(6).Value = CInt(frm.Dgv_ProductosI.Rows(index).Cells(4).Value)
                        End If


                    End If

                Else

                    MsgBox("Debe llenar todos los datos obligatorios", MsgBoxStyle.Exclamation, "SINPRO")

                End If


            Else

                If Not DatosAlmacenes.ExisteUbicacion(CInt(Me.cb_tramo.Items.Item(cb_tramo.SelectedIndex).code), frm2.DGV_Inventario.SelectedRows(0).Cells(2).Value) Then

                    frm2.DGV_Inventario.SelectedRows(0).Cells(6).Value = cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text
                    frm2.DGV_Inventario.SelectedRows(0).Cells(7).Value = CInt(Me.cb_tramo.Items.Item(cb_tramo.SelectedIndex).code)
                    frm2.DGV_Inventario.SelectedRows(0).Cells(10).Value = CInt(Me.cb_cuarto.Items.Item(cb_cuarto.SelectedIndex).code)
                    frm2.DGV_Inventario.SelectedRows(0).Cells(11).Value = CInt(Me.cb_almacen.Items.Item(cb_almacen.SelectedIndex).code)

                    'Inserto la ubicación
                    DatosProducto.InsertarUbicaciones(frm2.DGV_Inventario.SelectedRows(0).Cells(2).Value, Me.cb_tramo.Items.Item(cb_tramo.SelectedIndex).code, frm2.DGV_Inventario.SelectedRows(0).Cells(4).Value)

                    Dim index As Integer = frm2.DGV_Inventario.SelectedRows(0).Index

                    frm2.Sp_ConsultaProductosAjusteInvTableAdapter.Fill(frm2.MELDataSet.sp_ConsultaProductosAjusteInv)
                    frm2.CrearWhere()

                    frm2.DGV_Inventario.Rows(index).Cells(0).Selected = True
                    frm2.DGV_Inventario.FirstDisplayedScrollingRowIndex = index

                Else

                    MsgBox("Esta ubicación ya se encuentra registrada para este producto", MsgBoxStyle.Exclamation, "SINPRO")

                End If

            End If

            Me.Close()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Frm_Ubicacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not frm Is Nothing Then

            frm.Enabled = True

            If frm.DGV_Productos.Visible Then

                If frm.DGV_Productos.SelectedRows.Count > 0 Then

                    frm.DGV_Productos.SelectedRows(0).Cells(5).Selected = True
                    frm.DGV_Productos.BeginEdit(True)

                End If

            Else

                If frm.Dgv_ProductosI.SelectedRows.Count > 0 Then

                    frm.Dgv_ProductosI.SelectedRows(0).Cells(5).Selected = True
                    frm.Dgv_ProductosI.BeginEdit(True)

                End If

            End If

        Else

            frm2.Enabled = True

            If frm2.DGV_Inventario.SelectedRows.Count > 0 Then

                frm2.DGV_Inventario.SelectedRows(0).Cells(0).Selected = True
                frm2.DGV_Inventario.BeginEdit(True)

            End If

        End If

    End Sub

    Private Sub Frm_Ubicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DatosAlmacenes.llenar_almacen(cb_almacen)
        cb_almacen.Focus()

    End Sub

    Private Sub cb_cuarto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_cuarto.KeyDown

        If e.KeyCode = Keys.Enter Then

            cb_estante.Focus()

        End If

    End Sub

    Private Sub cb_cuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuarto.SelectedIndexChanged

        DatosAlmacenes.llenarestantes(cb_estante, cb_estante, CInt(Me.cb_cuarto.Items.Item(cb_cuarto.SelectedIndex).code))
        If cb_estante.Items.Count > 0 Then
            cb_estante.SelectedIndex = 0
        End If

    End Sub

    Private Sub cb_estante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_estante.KeyDown

        If e.KeyCode = Keys.Enter Then

            cb_tramo.Focus()

        End If

    End Sub

    Private Sub cb_estante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estante.SelectedIndexChanged

        DatosAlmacenes.llenartramos(cb_tramo, cb_tramo, CInt(Me.cb_estante.Items.Item(cb_estante.SelectedIndex).code))
        If cb_tramo.Items.Count > 0 Then
            cb_tramo.SelectedIndex = 0
        End If

    End Sub

    Private Sub cb_almacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_almacen.KeyDown

        If e.KeyCode = Keys.Enter Then

            cb_cuarto.Focus()

        End If

    End Sub

    Private Sub cb_almacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacen.SelectedIndexChanged

        DatosAlmacenes.llenarcuartos(cb_cuarto, cb_cuarto, CInt(Me.cb_almacen.Items.Item(cb_almacen.SelectedIndex).code))
        If cb_cuarto.Items.Count > 0 Then
            cb_cuarto.SelectedIndex = 0
        End If

    End Sub

    Private Sub cb_tramo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cb_tramo.KeyDown

        If e.KeyCode = Keys.Enter Then

            bt_aceptar_Click(bt_aceptar, New EventArgs)

        End If

    End Sub

End Class