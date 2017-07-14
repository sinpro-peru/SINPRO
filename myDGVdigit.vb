Imports Microsoft.VisualBasic

Public Class MyDGVdigit
    Inherits DataGridView

    <System.Security.Permissions.UIPermission(System.Security.Permissions.SecurityAction.LinkDemand, Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)> Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        ' Extract the key code from the key value. 
        Dim key As Keys = keyData And Keys.KeyCode
        If Char.IsDigit(ChrW(key)) Then

        Else
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    <System.Security.Permissions.SecurityPermission( _
        System.Security.Permissions.SecurityAction.LinkDemand, Flags:= _
        System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)> _
    Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
        ' Handle the ENTER key as if it were a RIGHT ARROW key. 
        'If e.KeyCode = Keys.Enter Then
        '    If Not Me.CurrentRow.Cells.Item(0).EditedFormattedValue = "" Then
        '        Me.CurrentRow.Selected = True
        '        Return Me.EndEdit()
        '    End If
        'End If
        Return MyBase.ProcessDataGridViewKey(e)
    End Function
End Class