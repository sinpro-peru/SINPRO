Public Class Frm_ExportarAExcel

    Public Codigo As Integer
    Public Proveedor As String
    Public Moneda As String
    Public Tipo As String
    Public TotalFOB As Double
    Public TotalFOBs As Double
    Public TotalCIF As Double
    Public TotalCIFBs As Double
    Public TotalArt As Integer
    Public TotalArancBs As Double
    Public TotalOtros As Double
    Public Fecha As Date
    Public dgv As New DataGridView

    Private Sub Frm_ExportarAExcel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        filtrarDGV()
        dgv.ClearSelection()
        Dim a As Integer
        For cont As Integer = 0 To dgv.RowCount - 1
            If dgv.Rows(cont).Visible Then
                a = cont
                cont = dgv.RowCount - 1
            End If
        Next
        dgv.FirstDisplayedScrollingRowIndex = a
    End Sub

    Private Sub Frm_ExportarAExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        For cont As Integer = 0 To dgv.ColumnCount - 1
            DGV_Pesos.Rows.Add(False, dgv.Columns(cont).HeaderText)
        Next
    End Sub

    Public Sub recibe(ByVal codigo2 As Integer, ByVal dgv2 As DataGridView, ByVal Prov As String, ByVal Fechaa As Date, ByVal Mon As String, ByVal Tipo2 As String, ByVal TF As Double, ByVal TFBs As Double, ByVal TC As Double, ByVal TCBs As Double, ByVal TOt As Double, ByVal TAranBs As Double, ByVal TArt As Integer, ByVal filtro As String)

        Codigo = codigo2
        'dgv = dgv2
        Fecha = Fechaa
        Tipo = Tipo2
        Proveedor = Prov
        Moneda = Mon
        TotalFOB = TF
        TotalFOBs = TFBs
        TotalCIF = TC
        TotalCIFBs = TCBs
        TotalArt = TArt
        TotalArancBs = TAranBs
        TotalOtros = TOt


        Dim cont As Integer
        Dim cont2 As Integer = 0

        If dgv.Rows.Count <> 0 Then

            For cont = 0 To dgv.Rows.Count - 1
                If Not dgv.Rows(cont).Cells(0).Value Is Nothing Then
                    If filtro <> "Todos" Then
                        If dgv.Rows(cont).Cells(0).Value <> filtro Then
                            dgv.Rows(cont).Visible = False
                        Else
                            dgv.Rows(cont).Visible = True
                        End If
                    Else
                        dgv.Rows(cont).Visible = True
                    End If
                End If
            Next

        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Todos.CheckedChanged
        For cont As Integer = 0 To DGV_Pesos.RowCount - 1
            DGV_Pesos.Rows(cont).Cells(0).Value = Chk_Todos.Checked
        Next
    End Sub

    Public Sub GridAExcel(ByRef ElGrid As DataGridView)

        Dim ColVisibles As Integer = 0
        Dim FilasVisibles As Integer = 0

        Dim colCant As Integer = 0
        Dim colFOB As Integer = 0
        Dim colFlete As Integer = 0
        Dim colCIF As Integer = 0
        Dim colAran As Integer = 0
        Dim colOtros As Integer = 0
        Dim colCosto As Integer = 0


        For cont As Integer = 0 To DGV_Pesos.RowCount - 1
            For cont2 As Integer = 0 To ElGrid.ColumnCount - 1
                If ElGrid.Columns(cont2).HeaderText = DGV_Pesos.Rows(cont).Cells(1).Value.ToString And DGV_Pesos.Rows(cont).Cells(0).Value = False Then
                    dgv.Columns(cont2).Visible = False
                ElseIf ElGrid.Columns(cont2).HeaderText = DGV_Pesos.Rows(cont).Cells(1).Value.ToString And DGV_Pesos.Rows(cont).Cells(0).Value = True Then
                    dgv.Columns(cont2).Visible = True
                End If
            Next
        Next

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount


            'Tituto

            exHoja.Range(exApp.Cells(1, 1), exApp.Cells(1, 5)).Merge(1)
            exHoja.Range(exApp.Cells(2, 1), exApp.Cells(2, 6)).Merge(1)
            exHoja.Range(exApp.Cells(3, 1), exApp.Cells(3, 6)).Merge(1)
            exHoja.Range(exApp.Cells(4, 1), exApp.Cells(4, 6)).Merge(1)
            exHoja.Range(exApp.Cells(6, 1), exApp.Cells(6, 5)).Merge(1)
            exHoja.Range(exApp.Cells(7, 1), exApp.Cells(7, 8)).Merge(1)
            exHoja.Range(exApp.Cells(1, 7), exApp.Cells(1, 9)).Merge(1)

            If My.Settings.Empresa = 2 Then

                exHoja.Cells.Item(1, 1) = "Importadora Autopartes Global S.A."
                exHoja.Cells.Item(2, 1) = "RIF: J-29580803-8"
                exHoja.Cells.Item(3, 1) = "Tlf.: (0212)731.22.82"
                exHoja.Cells.Item(4, 1) = "Email.: agsaonline@gmail.com"

            ElseIf My.Settings.Empresa = 3 Then

                exHoja.Cells.Item(1, 1) = "Distribuidora Mil26 S.A."
                exHoja.Cells.Item(2, 1) = "RIF: J-29469954-5"
                exHoja.Cells.Item(3, 1) = "Tlf.: (0212)642.11.15"
                exHoja.Cells.Item(4, 1) = "Email.: distribuidoramil26@gmail.com"

            ElseIf My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                exHoja.Cells.Item(1, 1) = "Comercializadora BRWME, S.A."
                exHoja.Cells.Item(2, 1) = "RIF: J-31135455-7"
                exHoja.Cells.Item(3, 1) = "Tlf.: (0212)761.10.31"
                exHoja.Cells.Item(4, 1) = "Email.: brwmesa@gmail.com"

            End If

            exHoja.Cells.Item(6, 1) = "Orden de compra nro.: " + Codigo.ToString
            exHoja.Cells.Item(1, 6) = "Fecha: " + Fecha.ToShortDateString
            exHoja.Cells.Item(7, 1) = "Sres.: " + Proveedor + ", favor despachar los siguientes items"
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).Font.italic = 1
            exHoja.Rows.Item(1).Font.name = "Arial"
            exHoja.Rows.Item(1).Font.size = 11
            exHoja.Rows.Item(1).HorizontalAlignment = 2
            exHoja.Rows.Item(2).Font.Bold = 1
            exHoja.Rows.Item(2).HorizontalAlignment = 2
            exHoja.Rows.Item(2).Font.name = "Arial"
            exHoja.Rows.Item(2).Font.size = 11
            exHoja.Rows.Item(2).Font.italic = 1
            exHoja.Rows.Item(3).Font.Bold = 1
            exHoja.Rows.Item(3).Font.italic = 1
            exHoja.Rows.Item(3).Font.name = "Arial"
            exHoja.Rows.Item(3).Font.size = 11
            exHoja.Rows.Item(3).HorizontalAlignment = 2
            exHoja.Rows.Item(4).Font.Bold = 1
            exHoja.Rows.Item(4).Font.italic = 1
            exHoja.Rows.Item(4).Font.name = "Arial"
            exHoja.Rows.Item(4).Font.size = 11
            exHoja.Rows.Item(6).HorizontalAlignment = 2
            exHoja.Rows.Item(6).Font.Bold = 1
            exHoja.Rows.Item(6).Font.italic = 1
            exHoja.Rows.Item(6).Font.name = "Arial"
            exHoja.Rows.Item(6).Font.size = 11
            exHoja.Rows.Item(7).HorizontalAlignment = 2
            exHoja.Rows.Item(7).Font.Bold = 1
            exHoja.Rows.Item(7).Font.italic = 1
            exHoja.Rows.Item(7).Font.name = "Arial"
            exHoja.Rows.Item(7).Font.size = 11
            exHoja.Rows.Item(7).HorizontalAlignment = 2

            Dim a As Integer = 2

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol

                If ElGrid.Columns(i - 1).Visible Then

                    If i = 2 Then
                        colCant = a
                    ElseIf i = 7 Then
                        exHoja.Cells.Item(10, a) = ElGrid.Columns(i - 1).HeaderText.ToString + " (" + Moneda + ")"
                        colFOB = a
                    ElseIf i = 8 Then
                        colFlete = a
                    ElseIf i = 9 Then
                        colCIF = a
                    ElseIf i = 11 Then
                        colAran = a
                    ElseIf i = 12 Then
                        colOtros = a
                    ElseIf i = 13 Then
                        colCosto = a
                    End If

                    exHoja.Cells.Item(10, a) = ElGrid.Columns(i - 1).HeaderText.ToString

                    ColVisibles = ColVisibles + 1

                    a = a + 1

                End If

            Next

            exHoja.Range(exApp.Cells(11, 7), exApp.Cells(NRow + 10, 7)).Select()
            exApp.Selection.numberformat = "#.##0,00"
            exHoja.Cells(1, 1).select()
            Dim cont As Integer = 0
            Dim valor As Integer = 11
            Dim acum As Double = 0
            Dim acumFlete As Double = 0

            For Fila As Integer = 1 To NRow

                ProgressBar1.Value = (Fila / NRow) * 100

                FilasVisibles = FilasVisibles + 1

                If ElGrid.Rows(Fila - 1).Visible = True Then

                    Dim b As Integer = 2

                    For cont5 As Integer = 0 To ElGrid.ColumnCount - 1

                        If ElGrid.Columns(cont5).Visible Then

                            exHoja.Cells.Item((valor), b).ClearFormats()
                            exHoja.Cells.Item((valor), b) = ElGrid.Rows(Fila - 1).Cells(cont5).Value

                            If cont5 = 6 Or cont5 = 7 Or cont5 = 8 Or cont5 = 9 Or cont5 = 10 Or cont5 = 11 Or cont5 = 12 Or cont5 = 13 Or cont5 = 14 Or cont5 = 15 Or cont5 = 16 Or cont5 = 20 Or cont5 = 23 Or cont5 = 24 Then

                                exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).NumberFormat = "#.##0,00"
                                exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 4

                            ElseIf cont5 = 1 Or cont5 = 17 Or cont5 = 19 Then

                                exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 3

                            Else

                                exHoja.Cells.Item((valor), b) = exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).Text()
                                exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 2

                            End If

                            b = b + 1

                        End If

                    Next

                    acum = acum + (CInt(ElGrid.Rows(Fila - 1).Cells(1).Value) * CDbl(ElGrid.Rows(Fila - 1).Cells(12).Value))
                    acumFlete = acumFlete + (CDbl(ElGrid.Rows(Fila - 1).Cells(7).Value) * CInt(ElGrid.Rows(Fila - 1).Cells(1).Value))

                    cont = cont + 1
                    valor = valor + 1

                End If

                exHoja.Cells(Fila + 11, 7).select()

            Next

            If cont > 0 Then

                exApp.Visible = True

                'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
                exHoja.Rows.Item(10).font.name = "Arial"
                exHoja.Rows.Item(10).font.size = 10
                exHoja.Rows.Item(10).Font.Bold = 1
                exHoja.Rows.Item(10).HorizontalAlignment = 3

                '--------------------------------------- BORDE --------------------------------------------'
                '                                                                                          '
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(valor, ColVisibles + 1)).BorderAround() '
                '                                                                                          '
                '--------------------------------------- BORDE --------------------------------------------'

                If dgv.Columns(1).Visible Or dgv.Columns(6).Visible Or dgv.Columns(7).Visible Or dgv.Columns(8).Visible Or dgv.Columns(10).Visible Or dgv.Columns(11).Visible Or dgv.Columns(12).Visible Then

                    If dgv.Columns(1).Visible Then
                        exApp.Cells.Item((cont) + 11, colCant) = TotalArt
                    End If
                    If dgv.Columns(6).Visible Then
                        exApp.Cells.Item((cont) + 11, colFOB) = TotalFOB
                    End If
                    If dgv.Columns(7).Visible Then
                        exApp.Cells.Item((cont) + 11, colFlete) = acumFlete
                    End If
                    If dgv.Columns(8).Visible Then
                        exApp.Cells.Item((cont) + 11, colCIF) = TotalCIF
                    End If
                    If dgv.Columns(10).Visible Then
                        exApp.Cells.Item((cont) + 11, colAran) = TotalArancBs
                    End If
                    If dgv.Columns(11).Visible Then
                        exApp.Cells.Item((cont) + 11, colOtros) = TotalOtros
                    End If
                    If dgv.Columns(12).Visible Then
                        exApp.Cells.Item((cont) + 11, colCosto) = acum
                    End If


                    exApp.Cells.Item((cont) + 11, 1) = "Totales"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Size = 11
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Size = 10
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).BorderAround()
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).NumberFormat = "#.##0,00"

                    If dgv.Columns(1).Visible And dgv.Columns(0).Visible Then
                        exHoja.Range(exApp.Cells(cont + 11, 3), exApp.Cells(cont + 11, 3)).NumberFormat = "0"
                    ElseIf dgv.Columns(1).Visible And dgv.Columns(0).Visible = False Then
                        exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, 2)).NumberFormat = "0"
                    End If

                End If


                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Size = 10
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Bold = True
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).Font.Italic = True
                exHoja.Range(exApp.Cells(10, 2), exApp.Cells(10, ColVisibles + 1)).BorderAround()

                exHoja.Range(exApp.Cells(11, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(11, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).Font.Size = 9

                exHoja.Range(exApp.Cells(10, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).Columns.AutoFit()
                exHoja.Columns.AutoFit()
                exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape

                'Aplicación visible
                exHoja.Cells(1, 1).Focus()
                exApp.Application.Visible = True

                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing

            Else

                exApp.Quit()
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing

                MsgBox("La lista se encuentra vacia", MsgBoxStyle.Critical, "Error al exportar a Excel")

            End If


        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        End Try


    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Me.Size = New System.Drawing.Size(278, 454)
        Label1.Visible = True
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        GridAExcel(dgv)
        Me.Close()
    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        filtrarDGV()
        dgv.ClearSelection()
        Dim a As Integer
        For cont As Integer = 0 To dgv.RowCount - 1
            If dgv.Rows(cont).Visible Then
                a = cont
                cont = dgv.RowCount - 1
            End If
        Next
        dgv.FirstDisplayedScrollingRowIndex = a
        Me.Close()
    End Sub



    Public Sub filtrarDGV()

        For cont As Integer = 0 To dgv.ColumnCount - 1

            dgv.Columns(cont).Visible = True

        Next

        dgv.Columns(dgv.ColumnCount - 5).Visible = False
        dgv.Columns(dgv.ColumnCount - 4).Visible = False
        dgv.Columns(dgv.ColumnCount - 3).Visible = False
        dgv.Columns(dgv.ColumnCount - 2).Visible = False
        dgv.Columns(dgv.ColumnCount - 1).Visible = False

    End Sub
End Class