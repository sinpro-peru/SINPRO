Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms
Module modReports

    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Private sFileName As String

    Private Function CreateStream(ByVal name As String, _
       ByVal fileNameExtension As String, _
       ByVal encoding As Encoding, ByVal mimeType As String, _
       ByVal willSeek As Boolean) As Stream

        sFileName = My.Computer.FileSystem.GetTempFileName
        Dim stream As Stream = _
            New FileStream(sFileName, FileMode.Create)

        m_streams.Add(stream)

        Return stream
    End Function
    ''' <summary>
    ''' Export the report to a stream from image device
    ''' </summary>
    ''' <param name="report"></param>
    ''' <remarks>Nothing</remarks>
    Public Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = _
        "<DeviceInfo>" + _
          "  <OutputFormat>EMF</OutputFormat>" + _
         "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, _
           warnings)

        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub
    ''' <summary>
    ''' Set up the printer and trigger the printing process
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PrintReport(ByVal printerName As String)


        If m_streams Is Nothing Or m_streams.Count = 0 Then
            Return
        End If

        Dim printDoc As New PrintDocument()
        printDoc.PrinterSettings.PrinterName = printerName 'Un comment this line to specify certain printer name
        If Not printDoc.PrinterSettings.IsValid Then
            Dim msg As String = String.Format( _
                "Can't find printer ""{0}"".", printerName)
            'Console.WriteLine(msg)
            MsgBox(msg, MsgBoxStyle.Critical, "Error")
            Return
        End If
        m_currentPageIndex = 0
        AddHandler printDoc.PrintPage, AddressOf PrintPage
        AddHandler printDoc.EndPrint, AddressOf Release
        printDoc.Print()
    End Sub
    Private Sub Release(ByVal sender As Object, _
ByVal ev As PrintEventArgs)
        Dim stream As Stream
        For Each stream In m_streams
            stream.Close()
        Next
        My.Computer.FileSystem.DeleteFile(sFileName)
    End Sub
    Private Sub PrintPage(ByVal sender As Object, _
ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ev.Graphics.DrawImage(pageImage, ev.PageBounds)

        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub
End Module
