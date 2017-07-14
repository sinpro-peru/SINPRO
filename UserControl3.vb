Imports Dundas.Charting.WinControl
Imports Dundas.Charting.WinControl.ChartTypes
Imports Dundas.Extensions
Imports System.Drawing

Public Class UserControl3

    'Private Sub Chart1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseDown

    '    Try
    '        ' Call Hit Test Method
    '        Dim result As HitTestResult = Chart1.HitTest(e.X, e.Y)

    '        ' Check if data point is already exploded
    '        Dim exploded As Boolean = False

    '        If Chart1.Series(0).Points(result.PointIndex).CustomAttributes = "Exploded=true" Then
    '            exploded = True
    '        Else
    '            exploded = False
    '        End If

    '        ' Remove all exploded attributes
    '        Dim point As DataPoint
    '        For Each point In Chart1.Series(0).Points
    '            point.CustomAttributes = ""
    '        Next point

    '        ' If data point is already exploded get out.
    '        If exploded Then
    '            Return
    '        End If

    '        ' If data point is selected
    '        If result.ChartElementType = ChartElementType.DataPoint Then
    '            ' Set Attribute
    '            Dim point1 As DataPoint = Chart1.Series(0).Points(result.PointIndex)
    '            point1.CustomAttributes = "Exploded = true"
    '        End If

    '        ' If legend item is selected
    '        If result.ChartElementType = ChartElementType.LegendItem Then
    '            ' Set Attribute
    '            Dim point2 As DataPoint = Chart1.Series(0).Points(result.PointIndex)
    '            point2.CustomAttributes = "Exploded = true"
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub 'Chart1_MouseDown

    '' Mouse Move Event
    'Private Sub Chart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseMove
    '    Try
    '        ' Call Hit Test Method
    '        Dim result As HitTestResult = Chart1.HitTest(e.X, e.Y)

    '        ' Reset Data Point Attributes
    '        Dim point As DataPoint
    '        For Each point In Chart1.Series(0).Points
    '            point.BackGradientEndColor = Color.Black
    '            point.BackHatchStyle = ChartHatchStyle.None
    '            point.BorderWidth = 1
    '        Next point

    '        ' If a Data Point or a Legend item is selected.
    '        If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.LegendItem Then
    '            ' Set cursor type 
    '            Me.Cursor = Cursors.Hand

    '            ' Find selected data point
    '            Dim point3 As DataPoint = Chart1.Series(0).Points(result.PointIndex)

    '            ' Set End Gradient Color to White
    '            point3.BackGradientEndColor = Color.White

    '            ' Set selected hatch style
    '            point3.BackHatchStyle = ChartHatchStyle.Percent25

    '            ' Increase border width
    '            point3.BorderWidth = 2
    '        Else
    '            ' Set default cursor
    '            Me.Cursor = Cursors.Default
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub 'Chart1_MouseMove 

End Class
