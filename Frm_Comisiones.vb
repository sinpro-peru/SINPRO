Public Class Frm_Comisiones
    Dim varBoton As Integer = 0
    Private swLoad As Boolean = False
    Private swLoad2 As Boolean = False
    Public OcultaCom As Boolean = False
    Dim w As Boolean
    Dim e As Boolean

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then
            Me.Close()
        ElseIf e.Button Is Me.bt_nuevo Then
            If Not Me.tb_vendedor.SelectedItem Is Nothing Then
                varBoton = 1
                DatosComisiones.consulta_identidadComision(Me.lb_codigo.Text)
                Me.GroupBox1.Visible = True
                Me.Label6.Visible = True
                Me.DGV_comisiones.Rows.Clear()
                Me.DGV_Recibos.Visible = True
                Me.DGV_pagadas.Rows.Clear()
                Me.DGV_pagadas.Visible = False
                Me.ToolBar1.Enabled = False
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
                Me.lb_header.Text = "Recibos Asociados"
                Me.bt_agregar.Visible = True
                Me.DGV_comisiones.Columns(10).ReadOnly = False
                Me.lb_total.Text = "0,00"
                Me.lb_totalP.Text = "0,00"
            Else
                MsgBox("Debe seleccionar el vendedor al cual desea pagar comisión")
            End If
        ElseIf e.Button Is Me.bt_modificar Then
            varBoton = 2
            If Not Me.DGV_pagadas.SelectedRows.Count = 0 Then
                Me.ToolBar1.Enabled = False
                Me.DGV_comisiones.Columns(10).ReadOnly = False
                Me.DGV_pagadas.Enabled = False
                Me.DGV_pagadas.ForeColor = Color.Gray
                Me.bt_aceptar.Visible = True
                Me.bt_cancelar.Visible = True
            Else
                MsgBox("Debe seleccionar la comisión pagada que desea modificar")
            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            varBoton = 3
            If Not Me.DGV_pagadas.SelectedRows.Count = 0 Then
                Me.ToolBar1.Enabled = False


                DatosComisiones.elimina_Comision(Me.DGV_pagadas.SelectedRows(0).Cells(0).Value)
                For cont As Integer = 0 To DGV_comisiones.RowCount - 1
                    DatosComisiones.Actualiza_recibo(DGV_comisiones.Rows(cont).Cells(12).Value.ToString)
                Next

                Datos.Inserta_Actividad("Eliminó la comisión nro." + DGV_pagadas.SelectedRows(0).Cells(0).Value.ToString + " del vendedor (" + Me.tb_vendedor.SelectedItem.col2.ToString + ") " + Me.tb_vendedor.SelectedItem.col1.ToString)

                MsgBox("La comisión ha sido eliminada existosamente")

                Me.ToolBar1.Enabled = True
                Me.DGV_comisiones.Rows.Clear()
                Me.lb_header.Text = "Comisiones Pagadas"
                swLoad2 = False
                DatosComisiones.consulta_comisiones_pagadas(Me.DGV_pagadas, Me.tb_vendedor.SelectedItem.col2, swLoad2, Me.lb_total.Text, OcultaCom)
                Me.DGV_pagadas.ClearSelection()
        Else
            MsgBox("Debe seleccionar la comisión pagada que desea eliminar")
        End If

        ElseIf e.Button Is Me.bt_imprimir Then

            If tb_vendedor.SelectedIndex <> -1 And DGV_pagadas.SelectedRows.Count > 0 Then

                Dim frm As New R_Comision
                If RadioButton4.Checked Then
                    frm.tipo = 0
                ElseIf RadioButton5.Checked Then
                    frm.tipo = 1
                End If

                frm.OcultaCom = Me.OcultaCom
                frm.recibe(tb_vendedor.Text, DGV_pagadas.SelectedRows(0).Cells(2).Value, DGV_pagadas.SelectedRows(0).Cells(3).Value, DGV_comisiones)
                frm.Show()

            Else

                MsgBox("Debe seleccionar un vendedor y una comisión para imprimir sus detalles", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        End If
    End Sub

    Private Sub Form37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Datos.consulta_vendedores(Me.tb_vendedor)
        EditarVendedorFactMenuItem.Visible = False
        Me.lb_mes.Text = "(" + mes() + ")"
        Me.GroupBox1.Visible = False
        Me.Label6.Visible = False
        Me.DGV_pagadas.Visible = True
        Me.DGV_Recibos.Visible = False
        Me.bt_agregar.Visible = False
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
        End If
    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Private Function llenos() As Boolean
        Dim ll As Boolean = False
        If (Not Me.tb_vendedor.SelectedItem Is Nothing) And (Not (Me.RadioButton1.Checked = False And Me.RadioButton2.Checked = False And Me.RadioButton3.Checked = False)) Then
            ll = True
        Else
            ll = False
        End If
        Return ll
    End Function
    Private Function mes() As String
        Dim m As Integer = Today.AddMonths(-1).Month
        Dim m2 As String = ""
        If m = 1 Then
            m2 = "Enero"
        ElseIf m = 2 Then
            m2 = "Febrero"
        ElseIf m = 3 Then
            m2 = "Marzo"
        ElseIf m = 4 Then
            m2 = "Abril"
        ElseIf m = 5 Then
            m2 = "Mayo"
        ElseIf m = 6 Then
            m2 = "Junio"
        ElseIf m = 7 Then
            m2 = "Julio"
        ElseIf m = 8 Then
            m2 = "Agosto"
        ElseIf m = 9 Then
            m2 = "Septiembre"
        ElseIf m = 10 Then
            m2 = "Octubre"
        ElseIf m = 11 Then
            m2 = "Noviembre"
        ElseIf m = 12 Then
            m2 = "Diciembre"
        End If
        Return m2
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If llenos() Then
            Dim F1 As String = ""
            Dim F2 As String = ""
            Dim Parametro As Boolean = False
            If Me.RadioButton2.Checked = True Then
                F1 = "01/" + Today.AddMonths(-1).Month.ToString + "/" + Today.AddMonths(-1).Year.ToString
                F2 = "01/" + Today.Month.ToString + "/" + Today.Year.ToString
            ElseIf Me.RadioButton3.Checked = True Then
                F1 = Me.tb_fecha1.Value.Date
                F2 = Me.tb_fecha2.Value.Date
            Else
                F1 = Today
                F2 = Today
                Parametro = True
            End If
            swLoad = False
            Me.DGV_comisiones.Rows.Clear()
            DatosRecibo.consulta_recibos_vendedor_pendientes(Me.DGV_Recibos, Me.tb_vendedor.SelectedItem.Col2, F1, F2, Parametro, swLoad, Me.lb_totalP.Text, OcultaCom)
            If Me.DGV_Recibos.Rows.Count = 0 Then
                MsgBox("El vendedor no posee recibos asociados en el rango de tiempo seleccionado.")
            Else
                Me.DGV_Recibos.ClearSelection()
                Me.lb_total.Text = 0
            End If
        Else
            MsgBox("Debe seleccionar el vendedor y el período deseado.")
        End If

    End Sub

    Private Sub DGV_Pagadas_selection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_pagadas.SelectionChanged
        If swLoad2 = True And Not Me.DGV_pagadas.SelectedRows.Count = 0 Then
            DatosComisiones.consulta_facturas_comisiones_pagadas(Me.DGV_comisiones, Me.DGV_pagadas.SelectedRows(0).Cells(0).Value, Me.lb_total.Text, Me.w, OcultaCom)
            Me.DGV_comisiones.ClearSelection()
        End If
    End Sub

    Private Sub DGV_comisiones_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_comisiones.CellEndEdit
        If DGV_comisiones.SelectedRows(0).Cells(10).Value.ToString = "" Or DGV_comisiones.SelectedRows(0).Cells(10).Value = "0" Then

            Me.DGV_comisiones.SelectedRows(0).Cells(11).Value = "0,00"
            Me.DGV_comisiones.SelectedRows(0).Cells(10).Value = "0,00"

        End If
    End Sub
    Private Sub dgv_comisiones_CellParsing(ByVal sender As Object, ByVal e As DataGridViewCellParsingEventArgs) Handles DGV_comisiones.CellParsing
        If Me.DGV_comisiones.Columns(e.ColumnIndex).Name = "por" Then
            If e IsNot Nothing Then
                If e.Value IsNot Nothing Then
                    If e.Value <> "" And IsNumeric(e.Value) Then
                        Me.lb_total.Text = CDbl(Me.lb_total.Text) - Me.DGV_comisiones.SelectedRows(0).Cells(11).Value
                        Me.DGV_comisiones.SelectedRows(0).Cells(11).Value = (e.Value / 100) * Me.DGV_comisiones.SelectedRows(0).Cells(9).Value
                        Me.lb_total.Text = Format(CDbl(Me.lb_total.Text) + Me.DGV_comisiones.SelectedRows(0).Cells(11).Value, "#,##0.00")
                    Else
                        Me.DGV_comisiones.SelectedRows(0).Cells(11).Value = "0,00"
                        Me.DGV_comisiones.SelectedRows(0).Cells(10).Value = "0,00"
                        Me.lb_total.Text = CDbl(Me.lb_total.Text) - Me.DGV_comisiones.SelectedRows(0).Cells(11).Value
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bt_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregar.Click
        If Not Me.DGV_Recibos.SelectedRows.Count = 0 Then
            Dim i As Integer = Me.DGV_Recibos.SelectedRows.Count - 1
            While 0 <= i
                DatosVendedores.consulta_CalculoComision(Me.DGV_comisiones, Me.DGV_Recibos.SelectedRows(i).Cells(0).Value, Me.lb_total.Text, CDbl(Me.lb_total.Text))
                Me.DGV_Recibos.Rows.RemoveAt(Me.DGV_Recibos.SelectedRows(i).Index)
                i = i - 1
            End While
            Me.DGV_comisiones.ClearSelection()
        Else
            MsgBox("Debe seleccionar los recibos que desea pagar.")
        End If

    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        If varBoton = 1 Then
            Dim F1 As String = ""
            Dim F2 As Date
            Dim F3 As String = ""
            If Me.RadioButton2.Checked = True Then
                F1 = "01/" + Today.AddMonths(-1).Month.ToString + "/" + Today.AddMonths(-1).Year.ToString
                F2 = "01/" + Today.Month.ToString + "/" + Today.Year.ToString
                F2 = F2.AddDays(-1).Date
                F3 = Format(F2, "dd/MM/yyyy").ToString
            ElseIf Me.RadioButton3.Checked = True Then
                F1 = Me.tb_fecha1.Value.Date
                F2 = Me.tb_fecha2.Value.Date
                F3 = F2
            End If

            DatosComisiones.inserta_comision(Me.tb_vendedor.SelectedItem.col2, Today(), F1, F3, CDbl(Me.lb_total.Text))
            Dim i As Integer = 0
            While i < Me.DGV_comisiones.Rows.Count
                DatosComisiones.inserta_factura_comision(CInt(Me.lb_codigo.Text), Me.DGV_comisiones.Rows(i).Cells(13).Value, Me.DGV_comisiones.Rows(i).Cells(12).Value, Me.DGV_comisiones.Rows(i).Cells(10).Value)
                i = i + 1
            End While

            Datos.Inserta_Actividad("Creó la comisión nro. " + lb_codigo.Text + " del vendedor (" + Me.tb_vendedor.SelectedItem.col2.ToString + ") " + Me.tb_vendedor.SelectedItem.col1.ToString)

            Dim resp As Integer = MsgBox("La comisión ha sido registrada exitosamente, desea imprimir los detalles?", MsgBoxStyle.YesNo, "SINPRO")

            If resp = vbYes Then
                Dim frm As New R_Comision
                frm.OcultaCom = Me.OcultaCom
                frm.recibe(tb_vendedor.Text, F1, F3, DGV_comisiones)
                frm.Show()
            End If

            Me.GroupBox1.Visible = False
            Me.bt_agregar.Visible = False
        ElseIf varBoton = 2 Then
            DatosComisiones.elimina_Facturas_Comision(Me.DGV_pagadas.SelectedRows(0).Cells(0).Value)
            Dim i As Integer = 0
            While i < Me.DGV_comisiones.Rows.Count
                DatosComisiones.inserta_factura_comision(Me.DGV_pagadas.SelectedRows(0).Cells(0).Value, Me.DGV_comisiones.Rows(i).Cells(13).Value, Me.DGV_comisiones.Rows(i).Cells(12).Value, Me.DGV_comisiones.Rows(i).Cells(10).Value)
                i = i + 1
            End While
            DatosComisiones.modifica_MontoComision(Me.DGV_pagadas.SelectedRows(0).Cells(0).Value, CDbl(Me.lb_total.Text))
            Me.DGV_pagadas.ForeColor = Color.Black
            Me.DGV_pagadas.Enabled = True
            Datos.Inserta_Actividad("Modificó la comisión nro. " + lb_codigo.Text + " del vendedor (" + Me.tb_vendedor.SelectedItem.col2.ToString + ") " + Me.tb_vendedor.SelectedItem.col1.ToString)
            MsgBox("La comisión ha sido modificada exitosamente.")
            swLoad2 = False
            DatosComisiones.consulta_comisiones_pagadas(Me.DGV_pagadas, Me.tb_vendedor.SelectedItem.col2, swLoad2, Me.lb_totalP.Text, OcultaCom)
            Me.DGV_pagadas.ClearSelection()
        End If
        Me.ToolBar1.Enabled = True
        Me.lb_header.Text = "Comisiones Pagadas"
        Me.DGV_Recibos.Rows.Clear()
        Me.DGV_Recibos.Visible = False
        Me.DGV_pagadas.Visible = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.lb_totalP.Text = "0,00"
        Me.lb_total.ResetText()
        bt_agregar.Visible = False
    End Sub

    Private Sub tb_vendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_vendedor.SelectedIndexChanged
        swLoad2 = False
        DatosComisiones.consulta_comisiones_pagadas(Me.DGV_pagadas, Me.tb_vendedor.SelectedItem.col2, swLoad2, Me.lb_totalP.Text, OcultaCom)
        Me.DGV_pagadas.ClearSelection()
        Me.DGV_comisiones.Rows.Clear()
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        If varBoton = 1 Then
            Me.GroupBox1.Visible = False
            Me.Label6.Visible = False
            Me.DGV_Recibos.Visible = False
            Me.DGV_pagadas.Visible = True
        ElseIf varBoton = 2 Then
            Me.DGV_pagadas.ForeColor = Color.Black
            Me.DGV_pagadas.Enabled = True
        End If
        Me.ToolBar1.Enabled = True
        Me.bt_aceptar.Visible = False
        Me.bt_cancelar.Visible = False
        Me.DGV_comisiones.Rows.Clear()
        Me.DGV_Recibos.Rows.Clear()
        Me.lb_totalP.Text = "0,00"
        Me.lb_total.ResetText()
        Me.lb_header.Text = "Comisiones Pagadas"
        bt_agregar.Visible = False

    End Sub

    Private Sub DGV_Recibos_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGV_Recibos.RowsRemoved
        Me.lb_totalP.Text = FormatNumber(total_dgv_recibos(), 2)
    End Sub
    Public Function total_dgv_recibos() As Double
        Dim total As Double = 0.0
        Dim i As Integer
        While i < Me.DGV_Recibos.Rows.Count
            total = total + Me.DGV_Recibos.Rows(i).Cells(3).Value
            i = i + 1
        End While
        Return Math.Round(total, 2)
    End Function

    Private Sub EditarVendedorFactMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarVendedorFactMenuItem.Click

        If DGV_comisiones.SelectedRows.Count > 0 Then

            Dim frm As New Frm_ListadoClientes
            frm.tipo = 1
            frm.factura = DGV_comisiones.SelectedRows(0).Cells(1).Value.ToString
            frm.comi = Me
            frm.vende = tb_vendedor.Text.Trim
            frm.Show()

        End If

    End Sub

    Private Sub DGV_Comisiones_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_comisiones.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                If Not DGV_comisiones.Rows(hti.RowIndex).Selected Then

                    DGV_comisiones.ClearSelection()

                    DGV_comisiones.Rows(hti.RowIndex).Selected = True

                End If

            End If

        End If

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

        If bt_agregar.Visible = False Then

            EditarVendedorFactMenuItem.Visible = False

        Else

            EditarVendedorFactMenuItem.Visible = True

        End If

    End Sub

    Private Sub bt_agregar_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_agregar.VisibleChanged

        If bt_agregar.Visible = False Then

            EditarVendedorFactMenuItem.Visible = False

        Else

            EditarVendedorFactMenuItem.Visible = True

        End If

    End Sub

End Class