Public Class ComboBoxAutoComplete
    Inherits System.Windows.Forms.ComboBox

    Private Sub ComboBoxAutoComplete_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        'If the combo box is used for wildcard searches then don't do the autocomplete if a wildcard character has been entered.

        AutoComplete(Me, e)

    End Sub

    Private Sub AutoComplete(ByVal cbo As ComboBox, ByVal e As System.Windows.Forms.KeyEventArgs)

        Dim Index As Integer
        Dim Actual As String
        Dim Found As String
        Dim MatchFound As Boolean
        Dim sw As Boolean = True

        'If the contents of the combo have been removed then select the first entry in the combo box list.
        '' cbo.Text = cbo.Text.Trim
        '' If cbo.Text.Length = 0 Then
        '' cbo.SelectedIndex = 0
        '' cbo.SelectAll()
        '' Return
        '' End If

        'If the backspace key was pressed then remove the last character that was typed in and try to find a match.
        'Note that the selected text from the last character typed in to the end of the combo text field will also be deleted.
        '' If e.KeyCode = Keys.Back Then
        '' cbo.Text = cbo.Text.Substring(0, cbo.Text.Length - 1)
        '' End If

        ' Do nothing for some keys such as navigation keys.
        If ((e.KeyCode = Keys.Left) Or _
            (e.KeyCode = Keys.Right) Or _
            (e.KeyCode = Keys.Up) Or _
            (e.KeyCode = Keys.Down) Or _
            (e.KeyCode = Keys.PageUp) Or _
            (e.KeyCode = Keys.PageDown) Or _
            (e.KeyCode = Keys.Home) Or _
            (e.KeyCode = Keys.End)) Then
            Return
        End If

        Do
            ' Store the actual text that has been typed.
            Actual = cbo.Text

            ' Find the first match for the typed value.
            Index = cbo.FindString(Actual)

            ' Get the text of the first match.
            'if index > -1 then a match was found.
            If (Index > -1) Then
                Found = cbo.Items(Index).ToString()
                If sw = False Then
                    cbo.Text = Found
                    cbo.SelectionStart = Actual.Length
                    cbo.SelectionLength = Found.Length - Actual.Length
                    cbo.SelectedIndex = Index
                    sw = True
                End If
                ' Select this item from the list.
                '' cbo.SelectedIndex = Index

                ' Select the portion of the text that was automatically added so that any additional typing will replace it.
                ''cbo.SelectionStart = Actual.Length

                ''cbo.SelectionLength = Found.Length - Actual.Length
                MatchFound = True
            Else
                'If there isn't a match and the text typed in is only one character or nothing then just select the first
                'entry in the combo box.
                If Actual.Length = 1 Or Actual.Length = 0 Then
                    '' cbo.SelectedIndex = 0
                    '' cbo.SelectAll()
                    MatchFound = True
                Else
                    'if there isn't a match for the text typed in then remove the last character of the text typed in
                    'and try to find a match.
                    ''cbo.SelectionStart = Actual.Length - 1
                    ''cbo.SelectionLength = Actual.Length - 1
                    cbo.Text = cbo.Text.Substring(0, cbo.Text.Length - 1)
                    sw = False
                End If
            End If

        Loop Until MatchFound

    End Sub

End Class
