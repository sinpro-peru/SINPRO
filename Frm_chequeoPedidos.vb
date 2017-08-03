Public Class Frm_chequeoPedidos

    Dim fila As Integer = 100
    Dim chequeado As Boolean = False

    Private Sub Frm_chequeoPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Datos.consultaLogo(PictureBox3)
        tb_pedido.Focus()

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        tb_pedido.Enabled = True
        lbl_cliente.Visible = False
        Label1.Visible = False
        bt_cancelar.Visible = False
        bt_aceptar.Visible = False
        bt_modificar.Visible = False
        bt_bultos.Visible = False
        tb_pedido.Clear()
        DGV_Ped.Rows.Clear()
        tb_observacion.Clear()
        tb_bultos.Clear()
        tb_pedido.Focus()
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        Dim deny As Boolean = False

        If tb_bultos.Text <> "" Then
            DatosPedidoCliente.modifica_Pedido_Chequeo(CInt(tb_pedido.Text), tb_observacion.Text, tb_bultos.Text)
            MsgBox("Pedido chequeado exitosamente", MsgBoxStyle.Information, "SINPRO")
            deny = True
        Else
            MsgBox("Debe introducir el número de bultos", MsgBoxStyle.Critical, "Error")
        End If

        If deny Then

            tb_pedido.Enabled = True
            lbl_cliente.Visible = False
            Label1.Visible = False
            bt_cancelar.Visible = False
            bt_aceptar.Visible = False
            bt_modificar.Visible = False
            tb_pedido.Clear()
            DGV_Ped.Rows.Clear()
            tb_bultos.Clear()
            lbl_cliente.Text = ""
            tb_pedido.Focus()
            tb_observacion.Clear()

        End If


    End Sub

    Private Sub tb_pedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_pedido.KeyDown
        If e.KeyCode = Keys.Enter Then

            If tb_pedido.Text <> "" Then

                DatosPedidoCliente.consulta_pedido_chequeo(CInt(tb_pedido.Text), DGV_Ped, lbl_cliente, chequeado, tb_observacion, tb_bultos.Text, lbl_dest.Text)

                If DGV_Ped.RowCount > 0 Then

                    If chequeado = False Then
                        tb_pedido.Enabled = False
                        lbl_cliente.Visible = True
                        Label1.Visible = True
                        DGV_Ped.ClearSelection()
                        bt_aceptar.Visible = True
                        bt_modificar.Visible = True
                        bt_cancelar.Visible = True
                        bt_bultos.Visible = True
                    Else
                        MsgBox("Pedido inexistente o ya chequeado", MsgBoxStyle.Exclamation, "SINPRO")
                        tb_pedido.Clear()
                        tb_pedido.Focus()
                    End If

                Else

                    MsgBox("Pedido inexistente o ya chequeado", MsgBoxStyle.Exclamation, "SINPRO")
                    tb_pedido.Clear()
                    tb_pedido.Focus()

                End If

            End If

        End If
    End Sub

    Private Sub tb_pedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_pedido.KeyPress

        If (sender Is Me.tb_pedido) Then

            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

                e.Handled = False
                muestra_label(sender, 1)

            Else

                e.Handled = True
                muestra_label(sender, 0)
                Me.Label22.Text = "      Ingrese sólo números"

            End If

        End If

    End Sub

    Public Sub muestra_label(ByVal c As TextBox, ByVal tipo As Integer)
        If tipo = 0 Then
            Me.Label22.Location = New System.Drawing.Point(c.Location.X + c.Size.Width + 3, c.Location.Y)
            Me.ErrorProvider1.SetIconAlignment(Label22, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Me.ErrorProvider1.SetIconPadding(Label22, -20)
            Me.ErrorProvider1.SetError(Label22, "error")
            Me.Label22.Visible = True
            Me.Label22.BringToFront()
        Else
            Me.ErrorProvider1.SetError(c, "")
            Me.Label22.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click

        Dim deny As Boolean = False
        DatosPedidoCliente.modifica_observacion_pedido(tb_observacion.Text, CInt(tb_pedido.Text))
        MsgBox("Observación guardada exitosamente", MsgBoxStyle.Information, "SINPRO")
        deny = True

        If deny Then

            tb_pedido.Enabled = True
            lbl_cliente.Visible = False
            Label1.Visible = False
            bt_cancelar.Visible = False
            bt_aceptar.Visible = False
            bt_modificar.Visible = False
            tb_pedido.Clear()
            DGV_Ped.Rows.Clear()
            tb_bultos.Clear()
            lbl_cliente.Text = ""
            tb_pedido.Focus()
            tb_observacion.Clear()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If tb_bultos.Text = "" Then

            MsgBox("No existen bultos asociados", MsgBoxStyle.Critical)

        Else

            If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then

                Dim frm As New Frm_impresionBultos_BRWME
                'frm.recibe(DGV_TodasLasFacturas.SelectedRows(0).Cells(1).Value, Me.tb_bultos.Text, DGV_TodasLasFacturas.SelectedRows(0).Cells(4).Value, DGV_TodasLasFacturas.SelectedRows(0).Cells(3).Value)
                frm.Show()

            Else

                Dim frm As New Frm_impresionBultos
                'frm.recibe(DGV_TodasLasFacturas.SelectedRows(0).Cells(1).Value, Me.tb_bultos.Text, DGV_TodasLasFacturas.SelectedRows(0).Cells(4).Value, DGV_TodasLasFacturas.SelectedRows(0).Cells(3).Value)
                frm.Show()

            End If


        End If

    End Sub

    Private Sub bt_bultos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_bultos.Click

        If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Or My.Settings.Empresa = 8 Then

            Dim frm As New Frm_impresionBultos_BRWME
            frm.recibe(tb_pedido.Text, Me.tb_bultos.Text, lbl_dest.Text, lbl_cliente.Text)
            frm.Show()

        Else

            Dim frm As New Frm_impresionBultos
            frm.recibe(tb_pedido.Text, Me.tb_bultos.Text, lbl_dest.Text, lbl_cliente.Text)
            frm.Show()

        End If

    End Sub
End Class