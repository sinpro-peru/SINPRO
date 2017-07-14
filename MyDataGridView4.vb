Public Class MyDataGridView4

    Inherits DataGridView

    Public frm As Frm_CalculoCostos

    <System.Security.Permissions.UIPermission(System.Security.Permissions.SecurityAction.LinkDemand, Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)> Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        ' Extract the key code from the key value. 
        Try
            Dim key As Keys = keyData And Keys.KeyCode
            If key = Keys.Enter And Me.CurrentCell.ColumnIndex = 0 Then

                If Frm_CalculoCostos.columna Then

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then

                        Me.ClearSelection()
                        frm.focoAceptar(Me.FindForm)

                    Else


                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(0).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If

                Else
                    Me.CurrentRow.Cells(1).Selected = True
                    Return Me.BeginEdit(True)
                End If

            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 1 Then

                If Frm_CalculoCostos.columna Then

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then

                        Me.ClearSelection()
                        frm.focoAceptar(Me.FindForm)

                    Else


                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(1).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If

                Else

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then
                        frm.focoAceptar(Me.FindForm)
                    Else
                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(6).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)
                    End If

                End If

            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 6 Then

                If Frm_CalculoCostos.columna Then

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else

                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(6).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If

                Else
                    Me.CurrentRow.Cells(9).Selected = True
                    Return Me.BeginEdit(True)
                End If



            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 9 Then

                If Frm_CalculoCostos.columna Then
                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else
                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(9).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)
                    End If
                Else
                    Me.CurrentRow.Cells(11).Selected = True
                    Return Me.BeginEdit(True)

                End If



            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 11 Then

                If Frm_CalculoCostos.columna Then

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else
                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(11).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)
                    End If

                Else

                    Me.CurrentRow.Cells(20).Selected = True
                    Return Me.BeginEdit(True)

                End If

            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 20 Then

                'frm.AplicarFlitro(Me.FindForm, frm.choice)

                If Frm_CalculoCostos.columna Then

                    'frm.cb_status_SelectedIndexChanged(frm, New EventArgs)

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then

                        frm.focoAceptar(Me.FindForm)

                    Else

                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(20).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If



                Else
                    Me.CurrentRow.Cells(0).Selected = True
                    Return Me.BeginEdit(True)
                End If



            ElseIf key = Keys.Delete Then
                Return Me.ProcessDeleteKey(keyData)
            ElseIf key = Keys.Down Then
                Return Me.ProcessDownKey(keyData)
            ElseIf key = Keys.Up Then
                Return Me.ProcessUpKey(keyData)
            End If
            Return MyBase.ProcessDialogKey(keyData)
        Catch ex As Exception
            Return Me.EndEdit
        End Try

    End Function

    <System.Security.Permissions.SecurityPermission( _
        System.Security.Permissions.SecurityAction.LinkDemand, Flags:= _
        System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)> _
    Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
        ' Handle the ENTER key as if it were a RIGHT ARROW key. 
        Try

            If e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 0 Then

                If Frm_CalculoCostos.columna Then
                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else

                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(1).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If

                Else
                    Me.CurrentRow.Cells(1).Selected = True
                    Return Me.BeginEdit(True)
                End If

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 1 Then

                If Frm_CalculoCostos.columna Then
                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else

                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(1).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If

                Else

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then
                        frm.focoAceptar(Me.FindForm)
                    Else
                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(6).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)
                    End If

                End If

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 6 Then

                If Frm_CalculoCostos.columna Then

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else

                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(6).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If

                Else
                    Me.CurrentRow.Cells(9).Selected = True
                    Return Me.BeginEdit(True)
                End If

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 9 Then

                If Frm_CalculoCostos.columna Then
                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else
                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(9).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)
                    End If
                Else
                    Me.CurrentRow.Cells(11).Selected = True
                    Return Me.BeginEdit(True)

                End If

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 11 Then

                If Frm_CalculoCostos.columna Then

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else
                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(11).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)
                    End If

                Else

                    Me.CurrentRow.Cells(20).Selected = True
                    Return Me.BeginEdit(True)

                End If

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 20 Then

                'frm.AplicarFlitro(Me.FindForm, frm.choice)

                If Frm_CalculoCostos.columna Then

                    If Me.CurrentCell.RowIndex = Me.RowCount - 1 Then


                        frm.focoAceptar(Me.FindForm)

                    Else

                        Me.Rows(Me.CurrentRow.Index + Saltar(Me.CurrentRow.Index)).Cells(20).Selected = True
                        frm.Dgv_Costos_CellClick(frm.Dgv_Costos, New EventArgs)
                        Return Me.BeginEdit(True)

                    End If

                Else
                    Me.CurrentRow.Cells(0).Selected = True
                    Return Me.BeginEdit(True)
                End If

            ElseIf e.KeyCode = Keys.Delete Then
                Return Me.ProcessDeleteKey(e.KeyData)
            ElseIf e.KeyCode = Keys.Down Then
                Return Me.ProcessDownKey(e.KeyData)
            ElseIf e.KeyCode = Keys.Up Then
                Return Me.ProcessUpKey(e.KeyData)
            End If
            Return MyBase.ProcessDialogKey(e.KeyData)
        Catch ex As Exception
            Return Me.EndEdit
        End Try

    End Function

    Private Sub InitializeComponent()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public Function Saltar(ByVal Fila As Integer) As Integer

        Dim cont As Integer = 0

        While Fila < Me.RowCount

            If Me.Rows(Fila + 1).Visible Then

                cont = cont + 1
                Fila = Me.RowCount

            Else

                cont = cont + 1

            End If

            Fila = Fila + 1

        End While

        Return cont

    End Function

End Class
