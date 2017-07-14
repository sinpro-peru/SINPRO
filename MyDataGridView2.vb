Public Class MyDataGridView2
    Inherits DataGridView

    Public frm As Frm_Ajustes

    <System.Security.Permissions.UIPermission(System.Security.Permissions.SecurityAction.LinkDemand, Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)> Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        ' Extract the key code from the key value. 
        Try
            Dim key As Keys = keyData And Keys.KeyCode
            If key = Keys.Enter And Me.CurrentCell.ColumnIndex = 0 Then

                Return Me.ProcessRightKey(keyData)

            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 1 Then

                If Me.CurrentRow.Cells(0).Value <> "" Then

                    If (CInt(Me.CurrentRow.Cells(0).Value) + CInt(Me.CurrentRow.Cells(4).Value)) >= 0 Then

                        Me.CurrentRow.Cells(0).Selected = True
                        Return Me.ProcessEscapeKey(keyData)

                    ElseIf (CInt(Me.CurrentRow.Cells(0).Value) + CInt(Me.CurrentRow.Cells(4).Value)) < 0 Then

                        Me.CurrentRow.Cells(0).Selected = True
                        Frm_Ajustes.recibe_valor(True)
                        Return Me.EndEdit

                    End If

                Else

                    Me.CurrentRow.Cells(0).Selected = True
                    Frm_Ajustes.EdicionEnCantidad(True)
                    Return Me.EndEdit

                End If

            ElseIf key = Keys.ControlKey Then

                frm.tb_buscar.Focus()
                frm.tb_buscar.SelectAll()
                Me.ClearSelection()
                Return Me.EndEdit

            End If

            Return MyBase.ProcessDialogKey(keyData)

        Catch ex As Exception

            If Me.RowCount > 0 Then
                Me.CurrentRow.Cells(0).Selected = True
                Frm_Ajustes.recibe_valor(True)
                Return Me.EndEdit
            End If

        End Try

    End Function

    <System.Security.Permissions.SecurityPermission( _
        System.Security.Permissions.SecurityAction.LinkDemand, Flags:= _
        System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)> _
    Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
        ' Handle the ENTER key as if it were a RIGHT ARROW key. 
        Try

            If e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 0 Then

                Return Me.ProcessLeftKey(e.KeyData)

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 1 Then

                If Me.CurrentRow.Cells(0).Value <> "" And Me.CurrentRow.Cells(1).Value <> "" Then

                    If (CInt(Me.CurrentRow.Cells(0).Value) <= CInt(Me.CurrentRow.Cells(4).Value)) Then

                        Me.CurrentRow.Cells(0).Selected = True
                        Return Me.ProcessEscapeKey(e.KeyData)

                    ElseIf (CInt(Me.CurrentRow.Cells(0).Value) + CInt(Me.CurrentRow.Cells(4).Value)) < 0 Then

                        Me.CurrentRow.Cells(0).Selected = True
                        Frm_Ajustes.recibe_valor(True)
                        Return Me.EndEdit

                    End If

                Else

                    Me.CurrentRow.Cells(0).Selected = True
                    Frm_Ajustes.EdicionEnCantidad(True)
                    Return Me.EndEdit

                End If

            ElseIf e.KeyCode = Keys.ControlKey Then

                frm.tb_buscar.Focus()
                frm.tb_buscar.SelectAll()
                Me.ClearSelection()
                Return Me.EndEdit

            End If

            Return MyBase.ProcessDataGridViewKey(e)

        Catch ex As Exception

            If Me.RowCount > 0 Then
                Me.CurrentRow.Cells(0).Selected = True
                Frm_Ajustes.recibe_valor(True)
                Return Me.EndEdit
            End If

        End Try

    End Function

    Private Sub InitializeComponent()

        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class