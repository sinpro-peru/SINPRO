Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

    Public Class DataGridEnableTextBoxColumn
        Inherits DataGridTextBoxColumn
        Private _col As Integer
    Private tool As New ToolTip
    Public m As Boolean

        'Fields
        'Constructors
        'Events
        'Methods
    Public Delegate Sub EnableCellEventHandler(ByVal sender As Object, ByVal e As DataGridEnableEventArgs)
    Public Delegate Sub TKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)


        Public Sub New(ByVal column As Integer)
            MyBase.New()
            _col = column

        End Sub
    Public Event CheckCellEnabled As EnableCellEventHandler
    Public Event TextBoxKeyDown As KeyEventHandler


    Protected Overloads Overrides Sub Paint(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal backBrush As Brush, ByVal foreBrush As Brush, ByVal alignToRight As Boolean)

        'can remove this if you don't want to vary the color of diabled cells
        Dim enabled As Boolean
        enabled = True
        Dim e As DataGridEnableEventArgs
        e = New DataGridEnableEventArgs(rowNum, _col, enabled)
        RaiseEvent CheckCellEnabled(Me, e)
        'If Not (e.EnableValue) And m = True Then
        '    backBrush = Brushes.Chocolate
        'Else
        '    backBrush = Brushes.Azure
        'End If
        If Not (e.EnableValue) Then
            backBrush = Brushes.Azure
        End If
        'end of coloring code

        MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)

    End Sub


    Private Sub HandleKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        'Ignora la tecla presionada si no es dígito o tecla de control
        Console.WriteLine(e.KeyCode)
        Console.WriteLine(e.KeyValue)

    End Sub


    Protected Overloads Overrides Sub Edit(ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal bounds As Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        Dim enabled As Boolean
        enabled = True
        Dim e As DataGridEnableEventArgs
        e = New DataGridEnableEventArgs(rowNum, _col, enabled)
        RaiseEvent CheckCellEnabled(Me, e)
        If e.EnableValue Then
            MyBase.Edit(source, rowNum, bounds, [readOnly], instantText, cellIsVisible)
        End If
    End Sub
End Class
