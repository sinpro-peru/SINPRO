Public Class Frm_AsignacionFlete

    Public pedido As Integer = 0
    Public flete As Double = 0
    Public otros As Double = 0
    Public dgv As MyDataGridView4
    Public Tipo As String = ""
    Public frm As Frm_CalculoCostos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        For contador As Integer = 0 To frm.Dgv_Costos.RowCount - 1

            frm.Dgv_Costos.Rows(contador).Cells(7).Value = 0.0

        Next

        Dim cont As Integer = 0
        Dim cont2 As Integer = 1
        Dim esta As Boolean = False
        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        'Dim d As Double = 0
        'Dim f As Double = 0

        Dim vacio As Boolean = False
        Dim fila As Integer = 0

        'If My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Then

        '    'Paso 1: Cantidad de renglón por peso
        '    For cont = 0 To DGV_Pesos.RowCount - 1

        '        Dim cant As Integer = 0

        '        If DGV_Pesos.Rows(cont).Cells(1).Value IsNot Nothing Then

        '            If DGV_Pesos.Rows(cont).Cells(1).Value.ToString Then

        '                For cont2 = 0 To dgv.RowCount - 1

        '                    If dgv.Rows(cont2).Visible And dgv.Rows(cont2).Cells(0).Value.ToString.ToUpper <> "S" Then

        '                        If DGV_Pesos.Rows(cont).Cells(0).Value.ToString.ToUpper.Trim = dgv.Rows(cont2).Cells(4).Value.ToString.ToUpper.Trim And dgv.Rows(cont2).Cells(0).Value.ToString <> "S" Then

        '                            cant = cant + CInt(dgv.Rows(cont2).Cells(1).Value)

        '                        End If

        '                    End If

        '                Next

        '                DGV_Pesos.Rows(cont).Cells(2).Value = cant

        '                a = a + (CDbl(DGV_Pesos.Rows(cont).Cells(1).Value) * CDbl(DGV_Pesos.Rows(cont).Cells(2).Value))

        '            Else

        '                fila = cont
        '                vacio = True

        '            End If
        '        Else

        '            fila = cont
        '            vacio = True

        '        End If
        '        'End If

        '    Next

        '    If vacio = False Then

        '        'Paso 2: Total flete / a
        '        b = flete / a

        '        'Paso 3: Peso de c/renglon * b

        '        For cont = 0 To DGV_Pesos.RowCount - 1

        '            c = CDbl(DGV_Pesos.Rows(cont).Cells(1).Value) * b
        '            DGV_Pesos.Rows(cont).Cells(3).Value = Format(c, "#,##0.00")

        '            For cont2 = 0 To dgv.RowCount - 1

        '                If dgv.Rows(cont2).Visible And dgv.Rows(cont2).Cells(0).Value.ToString.ToUpper <> "S" Then

        '                    If DGV_Pesos.Rows(cont).Cells(0).Value.ToString.ToUpper.Trim = dgv.Rows(cont2).Cells(4).Value.ToString.ToUpper.Trim Then

        '                        dgv.Rows(cont2).Cells(7).Value = CDbl(DGV_Pesos.Rows(cont).Cells(3).Value)

        '                    End If

        '                    dgv.Rows(cont2).Cells(11).Value = CDbl(Format(CDbl(dgv.Rows(cont2).Cells(8).Value) * (otros / 100), "#,##0.00"))

        '                End If

        '            Next

        '        Next

        '        frm.ReCalcular()
        '        Me.Hide()

        '    Else

        '        MsgBox("Debe llenar todos los pesos", MsgBoxStyle.Critical, "Error")
        '        Me.DGV_Pesos.CurrentCell = Me.DGV_Pesos(1, fila)
        '        Me.DGV_Pesos.BeginEdit(True)

        '    End If

        'Else

        'Paso 1: Cantidad de renglón por peso
        For cont = 0 To DGV_Pesos.RowCount - 1

            Dim cant As Integer = 0

            If DGV_Pesos.Rows(cont).Cells(1).Value IsNot Nothing Then

                If DGV_Pesos.Rows(cont).Cells(1).Value.ToString <> "" Then

                    For cont2 = 0 To dgv.RowCount - 1

                        If dgv.Rows(cont2).Visible And dgv.Rows(cont2).Cells(0).Value.ToString.ToUpper <> "S" Then

                            If dgv.Rows(cont2).Cells(4).Value.ToString.Trim.Length = DGV_Pesos.Rows(cont).Cells(0).Value.ToString.Trim.Length Then

                                If DGV_Pesos.Rows(cont).Cells(0).Value.ToString.ToUpper.Trim = dgv.Rows(cont2).Cells(4).Value.ToString.ToUpper.Trim And dgv.Rows(cont2).Cells(0).Value.ToString <> "S" Then

                                    cant = cant + CInt(dgv.Rows(cont2).Cells(1).Value)

                                End If

                                'ElseIf dgv.Rows(cont2).Cells(4).Value.ToString.Trim.Length > DGV_Pesos.Rows(cont).Cells(0).Value.ToString.Trim.Length Then

                                '    If DGV_Pesos.Rows(cont).Cells(0).Value.ToString.ToUpper.Trim = dgv.Rows(cont2).Cells(4).Value.ToString.ToUpper.Trim.Substring(0, DGV_Pesos.Rows(cont).Cells(0).Value.ToString.Length).Trim Then

                                '        For cont3 As Integer = 0 To DGV_Pesos.RowCount - 1

                                '            If DGV_Pesos.Rows(cont3).Cells(0).Value.ToString.ToUpper.Trim = dgv.Rows(cont2).Cells(4).Value.ToString.ToUpper.Trim Then

                                '                esta = True

                                '            End If

                                '        Next

                                '        If esta = False Then

                                '            cant = cant + CInt(dgv.Rows(cont2).Cells(1).Value)

                                '        End If

                                '    End If

                            End If

                        End If

                    Next

                    DGV_Pesos.Rows(cont).Cells(2).Value = cant

                    a = a + (CDbl(DGV_Pesos.Rows(cont).Cells(1).Value) * CDbl(DGV_Pesos.Rows(cont).Cells(2).Value))

                Else

                    fila = cont
                    vacio = True

                End If
            Else

                fila = cont
                vacio = True

            End If
            'End If

        Next

        If vacio = False Then

            'Paso 2: Total flete / a
            b = flete / a

            'Paso 3: Peso de c/renglon * b

            For cont = 0 To DGV_Pesos.RowCount - 1

                c = CDbl(DGV_Pesos.Rows(cont).Cells(1).Value) * b
                DGV_Pesos.Rows(cont).Cells(3).Value = Format(c, "#,##0.00")

                For cont2 = 0 To dgv.RowCount - 1

                    If dgv.Rows(cont2).Visible And dgv.Rows(cont2).Cells(0).Value.ToString.ToUpper <> "S" Then

                        If dgv.Rows(cont2).Cells(4).Value.ToString.Length > DGV_Pesos.Rows(cont).Cells(0).Value.ToString.Length Then

                            If DGV_Pesos.Rows(cont).Cells(0).Value.ToString.ToUpper.Trim = dgv.Rows(cont2).Cells(4).Value.ToString.ToUpper.Trim.Substring(0, DGV_Pesos.Rows(cont).Cells(0).Value.ToString.Length).Trim Then

                                dgv.Rows(cont2).Cells(7).Value = CDbl(DGV_Pesos.Rows(cont).Cells(3).Value)

                            End If

                        ElseIf dgv.Rows(cont2).Cells(4).Value.ToString.Length = DGV_Pesos.Rows(cont).Cells(0).Value.ToString.Length Then

                            If DGV_Pesos.Rows(cont).Cells(0).Value.ToString.ToUpper.Trim = dgv.Rows(cont2).Cells(4).Value.ToString.ToUpper.Trim Then

                                dgv.Rows(cont2).Cells(7).Value = CDbl(DGV_Pesos.Rows(cont).Cells(3).Value)

                            End If

                        End If

                        dgv.Rows(cont2).Cells(11).Value = CDbl(Format(CDbl(dgv.Rows(cont2).Cells(8).Value) * (otros / 100), "#,##0.00"))

                    End If

                Next

            Next

            frm.ReCalcular()
            Me.Hide()

        Else

            MsgBox("Debe llenar todos los pesos", MsgBoxStyle.Critical, "Error")
            Me.DGV_Pesos.CurrentCell = Me.DGV_Pesos(1, fila)
            Me.DGV_Pesos.BeginEdit(True)

        End If

        'End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Me.Hide()
    End Sub

    Public Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pesos.CellClick
        Try
            Me.DGV_Pesos.CurrentCell = Me.DGV_Pesos(1, e.RowIndex)
            Me.DGV_Pesos.BeginEdit(True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_AsignacionFlete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DatosAsignacionFlete.Dgv_Pesos(DGV_Pesos, pedido, Tipo)
        DGV_Pesos.Focus()
        click2()

    End Sub

    Public Sub click2() Handles Me.Shown
        DataGridView1_CellContentClick(DGV_Pesos, New DataGridViewCellEventArgs(0, 0))
    End Sub

    Public Sub recibe(ByVal pedido2 As Integer, ByVal flete2 As Double, ByVal otros2 As Double, ByRef dgv2 As MyDataGridView4, ByVal tipo2 As String)

        pedido = pedido2
        flete = flete2
        dgv = dgv2
        otros = otros2
        Tipo = tipo2

    End Sub

    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) And (Not e.KeyChar = "."c) Then
            e.Handled = False
        Else

            e.Handled = True

        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_Pesos.EditingControlShowing
        If Me.DGV_Pesos.CurrentCell.ColumnIndex = 1 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
            End If
        End If
    End Sub

    Private Sub DGV_Pesos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pesos.CellEndEdit
        If Not Me.DGV_Pesos.CurrentCell.Value Is System.DBNull.Value Then

            If Me.DGV_Pesos.CurrentRow.Cells(0).Value = "" Or Me.DGV_Pesos.CurrentRow.Cells(0).Value Is Nothing Then

                Me.DGV_Pesos.CurrentRow.Cells(0).Value = Format(0, "#,##0.00")

            Else

                Try
                    If CheckBox1.Focused = False Then
                        Me.DGV_Pesos.CurrentCell = Me.DGV_Pesos(DGV_Pesos.CurrentCell.ColumnIndex, DGV_Pesos.CurrentCell.RowIndex + 1)
                        Me.DGV_Pesos.BeginEdit(True)
                    Else
                        Me.DGV_Pesos.EndEdit()
                        Me.DGV_Pesos.ClearSelection()
                    End If
                Catch ex As Exception
                    bt_aceptar.Focus()
                    DGV_Pesos.ClearSelection()
                End Try

            End If


        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            For cont As Integer = 0 To DGV_Pesos.RowCount - 1
                DGV_Pesos.Rows(cont).Cells(1).Value = 1
            Next
        Else
            For cont As Integer = 0 To DGV_Pesos.RowCount - 1
                DGV_Pesos.Rows(cont).Cells(1).Value = ""
            Next
        End If

        DGV_Pesos.ClearSelection()
        DGV_Pesos.EndEdit()

        bt_aceptar.Focus()

    End Sub

    Private Sub Frm_AsignacionFlete_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        If Me.Visible Then

            If DGV_Pesos.RowCount > 0 Then

                DGV_Pesos.Focus()
                DGV_Pesos.Select()
                click2()

            End If

        End If

    End Sub

End Class