Public Class MyDataGridView3
    Inherits DataGridView

    <System.Security.Permissions.UIPermission(System.Security.Permissions.SecurityAction.LinkDemand, Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)> Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        ' Extract the key code from the key value. 
        Try
            Dim key As Keys = keyData And Keys.KeyCode
            If key = Keys.Enter And Me.CurrentCell.ColumnIndex = 0 Then

                Me.CurrentRow.Cells(5).Selected = True
                Return Me.BeginEdit(True)

            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 5 Then

                Me.CurrentRow.Cells(6).Selected = True
                Return Me.BeginEdit(True)

            ElseIf key = Keys.Enter And Me.CurrentCell.ColumnIndex = 6 Then

                Me.Rows(Me.CurrentRow.Index + 1).Cells(0).Selected = True
                Return Me.BeginEdit(True)

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

                Me.CurrentRow.Cells(5).Selected = True
                Return Me.BeginEdit(True)

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 5 Then

                Me.CurrentRow.Cells(6).Selected = True
                Return Me.BeginEdit(True)

            ElseIf e.KeyCode = Keys.Enter And Me.CurrentCell.ColumnIndex = 6 Then

                Me.Rows(Me.CurrentRow.Index + 1).Cells(0).Selected = True
                Return Me.BeginEdit(True)

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
End Class