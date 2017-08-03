Public Class Frm_Comprascargadas

    Dim TablaProductos As New DataTable
    Dim frm As Frm_ModificarFacturaCompra
    Public f17 As Frm_Compras

    Private Sub Frm_Comprascargadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        DateTimePicker2.Value = DateAdd(DateInterval.Year, -3, Today)
        Me.DomainUpDown1.Items.Clear()
        Me.DomainUpDown1.Items.Add("Código Compra")
        Me.DomainUpDown1.Items.Add("Código Factura")
        Me.DomainUpDown1.Items.Add("Proveedor")
        Me.DomainUpDown1.Items.Add("Código Producto")
        Me.DomainUpDown1.Items.Add("Código Fábrica")
        DateTimePicker1.Value = Today
        Me.DomainUpDown1.SelectedIndex = 1
        DatosComprasCargadas.consulta_compras(Me.DGV_Pedidos, lbl_dolares.Text, lbl_euros.Text)
        DGV_Pedidos.ClearSelection()
        tb_buscarcodigo.Focus()
        tb_buscarcodigo.Select()

    End Sub

    Private Sub DGV_Pedidos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pedidos.CellContentDoubleClick

    End Sub

    Private Sub DGV_Pedidos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV_Pedidos.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            'DGV_Pedidos.ClearSelection()
            tb_buscarcodigo.Focus()
            tb_buscarcodigo.SelectAll()
        End If
    End Sub


    Public Sub DGV_Pedidos_CellClick(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Pedidos.CellClick, DGV_Pedidos.KeyUp

        If DGV_Pedidos.SelectedRows.Count > 0 Then

            lbl_codigoFac.Text = DGV_Pedidos.SelectedRows(0).Cells(0).Value.ToString
            DateTimePicker1.Value = DGV_Pedidos.SelectedRows(0).Cells(1).Value
            lbl_proveedor.Text = DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString
            lbl_codigo.Text = DGV_Pedidos.SelectedRows(0).Cells(3).Value.ToString
            lbl_codCompra.Text = DGV_Pedidos.SelectedRows(0).Cells(4).Value.ToString
            DatosComprasCargadas.consulta_datos_compra(DGV_Productos, tb_obs.Text, tb_flete.Text, tb_aranceles.Text, tb_otros.Text, Lbl_moneda.Text, CInt(DGV_Pedidos.SelectedRows(0).Cells(3).Value), lbl_TCA.Text, lbl_TCO.Text, lbl_Margen.Text, lbl_totalArt.Text, lbl_totalUni.Text)
            Total()
            DGV_Productos.ClearSelection()

        End If

    End Sub



    Private Sub tb_buscarcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscarcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then

            If DGV_Pedidos.RowCount > 0 Then

                DGV_Pedidos.Focus()
                DGV_Pedidos.Rows(0).Cells(0).Selected = True
                DGV_Pedidos_CellClick(DGV_Pedidos, New EventArgs)

            End If

        End If
    End Sub

   
    Private Sub tb_buscarcodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_buscarcodigo.TextChanged

        If DomainUpDown1.SelectedIndex = 0 Or DomainUpDown1.SelectedIndex = 1 Then
            lbl_codigo.Text = ""
            lbl_codCompra.Text = ""
            lbl_proveedor.Text = ""
            tb_obs.Clear()
            lbl_codigoFac.Text = ""
            lbl_codigoFac.Text = ""
            DateTimePicker1.Value = Today
            tb_flete.Clear()
            tb_aranceles.Clear()
            tb_otros.Clear()
            Lbl_moneda.Text = ""
            lb_totalP.Text = "0,00"
            lbl_totalArt.Text = "0"
            lbl_totalUni.Text = "0"
            lbl_costoT.Text = "0,00"
            lbl_precioV.Text = "0,00"
            DGV_Productos.Rows.Clear()
        End If

        If DomainUpDown1.SelectedIndex = 0 Then
            DatosComprasCargadas.consulta_compras_like(DGV_Pedidos, tb_buscarcodigo.Text, 0, lbl_dolares.Text, lbl_euros.Text, DateTimePicker2.Value, DateTimePicker3.Value)
            DGV_Pedidos.ClearSelection()
        ElseIf DomainUpDown1.SelectedIndex = 1 Then
            DatosComprasCargadas.consulta_compras_like(DGV_Pedidos, tb_buscarcodigo.Text, 1, lbl_dolares.Text, lbl_euros.Text, DateTimePicker2.Value, DateTimePicker3.Value)
            DGV_Pedidos.ClearSelection()
        ElseIf DomainUpDown1.SelectedIndex = 2 Then
            DatosComprasCargadas.consulta_compras_like(DGV_Pedidos, tb_buscarcodigo.Text, 2, lbl_dolares.Text, lbl_euros.Text, DateTimePicker2.Value, DateTimePicker3.Value)
            DGV_Pedidos.ClearSelection()
        ElseIf DomainUpDown1.SelectedIndex = 3 Then
            If DGV_Pedidos.SelectedRows.Count > 0 Then
                DatosComprasCargadas.consulta_Productos_compra(DGV_Productos, tb_buscarcodigo.Text, CInt(lbl_codCompra.Text), 0)
                DGV_Productos.ClearSelection()
            End If
        ElseIf DomainUpDown1.SelectedIndex = 4 Then
            If DGV_Pedidos.SelectedRows.Count > 0 Then
                DatosComprasCargadas.consulta_Productos_compra(DGV_Productos, tb_buscarcodigo.Text, CInt(lbl_codCompra.Text), 1)
                DGV_Productos.ClearSelection()
            End If
        End If
    End Sub

    
    Private Sub DomainUpDown1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown1.SelectedIndexChanged
        tb_buscarcodigo.Focus()
        tb_buscarcodigo.SelectAll()
    End Sub

    Public Sub Total()


        Dim cont As Integer

        lb_totalP.Text = "0,00"
        lbl_costoT.Text = "0,00"
        lbl_precioV.Text = "0,00"

        If DGV_Productos.Rows.Count <> 0 Then

            For cont = 0 To DGV_Productos.RowCount - 1

                lb_totalP.Text = Format(CDbl(lb_totalP.Text) + (CDbl(DGV_Productos.Rows(cont).Cells(0).Value) * CDbl(DGV_Productos.Rows(cont).Cells(5).Value)), "#,##0.00")
                lbl_costoT.Text = Format(CDbl(lbl_costoT.Text) + (CDbl(DGV_Productos.Rows(cont).Cells(0).Value) * CDbl(DGV_Productos.Rows(cont).Cells(11).Value)), "#,##0.00")
                lbl_precioV.Text = Format(CDbl(lbl_precioV.Text) + (CDbl(DGV_Productos.Rows(cont).Cells(0).Value) * CDbl(DGV_Productos.Rows(cont).Cells(12).Value)), "#,##0.00")

            Next

            lb_totalP.Text = lb_totalP.Text + Lbl_moneda.Text
            lbl_costoT.Text = lbl_costoT.Text + "Bs."
            lbl_precioV.Text = lbl_precioV.Text + "Bs."

        End If

    End Sub

    Private Sub DGV_Pedidos_RowsAdded(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_Pedidos.RowsAdded, DGV_Pedidos.RowsRemoved

        Label2.Text = DGV_Pedidos.RowCount

    End Sub

    Public Sub GridAExcel(ByVal ElGrid As DataGridView)

        Dim ColVisibles As Integer = 0
        Dim FilasVisibles As Integer = 0

        Dim colCant As Integer = 0
        Dim colFOB As Integer = 0
        Dim colFlete As Integer = 0
        Dim colCIF As Integer = 0
        Dim colAran As Integer = 0
        Dim colOtros As Integer = 0
        Dim colCosto As Integer = 0

        Dim totalCant As Integer = 0
        Dim totalFob As Double = 0
        Dim totalFlete As Double = 0
        Dim totalAran As Double = 0
        Dim totalOtros As Double = 0
        Dim totalCosto As Double = 0

        'Creamos las variables
        Dim total As Double = 0
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            If ElGrid.RowCount > 0 Then

                'Añadimos el Libro al programa, y la hoja al libro
                exLibro = exApp.Workbooks.Add
                exHoja = exLibro.Worksheets.Add()

                ' ¿Cuantas columnas y cuantas filas?
                Dim NCol As Integer = ElGrid.ColumnCount
                Dim NRow As Integer = ElGrid.RowCount


                'Tituto

                exHoja.Range(exApp.Cells(1, 1), exApp.Cells(1, 6)).Merge(1)
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

                    exHoja.Cells.Item(1, 1) = "Importadora Mil-26 S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29469954-5"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)642.11.15"
                    exHoja.Cells.Item(4, 1) = "Email.: distribuidoramil26@gmail.com"

                ElseIf My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                    exHoja.Cells.Item(1, 1) = "Comercializadora BRWME, S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-31135455-7"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)761.10.31"
                    exHoja.Cells.Item(4, 1) = "Email.: brwmesa@gmail.com"

                ElseIf My.Settings.Empresa = 8 Then

                    exHoja.Cells.Item(1, 1) = "Nombre empresa Perú, S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-11111111-1"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (1111)111.11.11"
                    exHoja.Cells.Item(4, 1) = "Email.: peru@gmail.com"

                End If

                exHoja.Cells.Item(6, 1) = "Compra nro.: " + lbl_codigo.Text
                exHoja.Cells.Item(1, 7) = "Fecha: " + Today.ToShortDateString
                exHoja.Cells.Item(7, 1) = "Proveedor: " + lbl_proveedor.Text
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
                            exHoja.Cells.Item(10, a) = ElGrid.Columns(i - 1).HeaderText.ToString + " (" + Lbl_moneda.Text + ")"
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

                    If ElGrid.Rows(Fila - 1).Visible Then

                        FilasVisibles = FilasVisibles + 1

                        Dim b As Integer = 2

                        For cont5 As Integer = 0 To ElGrid.ColumnCount - 1

                            If ElGrid.Columns(cont5).Visible Then

                                exHoja.Cells.Item((valor), b).ClearFormats()
                                exHoja.Cells.Item((valor), b) = ElGrid.Rows(Fila - 1).Cells(cont5).Value

                                If cont5 = 0 Then

                                    totalCant = totalCant + ElGrid.Rows(Fila - 1).Cells(cont5).Value

                                ElseIf cont5 = 6 Then

                                    totalFob = totalFob + ElGrid.Rows(Fila - 1).Cells(cont5).Value

                                ElseIf cont5 = 7 Then

                                    totalFlete = totalFlete + (ElGrid.Rows(Fila - 1).Cells(cont5).Value * ElGrid.Rows(Fila - 1).Cells(0).Value)

                                ElseIf cont5 = 10 Then

                                    totalAran = totalAran + (ElGrid.Rows(Fila - 1).Cells(cont5).Value * ElGrid.Rows(Fila - 1).Cells(0).Value)

                                ElseIf cont5 = 11 Then

                                    totalOtros = totalOtros + (ElGrid.Rows(Fila - 1).Cells(cont5).Value * ElGrid.Rows(Fila - 1).Cells(0).Value)

                                ElseIf cont5 = 12 Then

                                    totalCosto = totalCosto + (ElGrid.Rows(Fila - 1).Cells(cont5).Value * ElGrid.Rows(Fila - 1).Cells(0).Value)

                                End If

                                If cont5 = 6 Or cont5 = 7 Or cont5 = 8 Or cont5 = 10 Or cont5 = 11 Or cont5 = 12 Or cont5 = 9 Or cont5 = 13 Then

                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).NumberFormat = "#.##0,00"
                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 4

                                ElseIf cont5 = 0 Then

                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 3

                                Else

                                    exHoja.Cells.Item((valor), b) = exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).Text()
                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 2

                                End If

                                b = b + 1

                            End If

                        Next

                        acum = acum + (CInt(ElGrid.Rows(Fila - 1).Cells(0).Value) * CDbl(ElGrid.Rows(Fila - 1).Cells(5).Value))
                        'acumFlete = acumFlete + (CDbl(ElGrid.Rows(Fila - 1).Cells(7).Value) * CInt(ElGrid.Rows(Fila - 1).Cells(1).Value))

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
                    exHoja.Range(exApp.Cells(10, 2), exApp.Cells((cont) + 10, ColVisibles + 1)).BorderAround() '
                    '                                                                                          '
                    '--------------------------------------- BORDE --------------------------------------------'

                    exApp.Cells.Item((cont) + 11, 1) = "Totales"

                    exApp.Cells.Item((cont) + 11, 2) = totalCant
                    exApp.Cells.Item((cont) + 11, 8) = Format(totalFob, "#,##0.00")
                    exApp.Cells.Item((cont) + 11, 9) = Format(totalFlete, "#,##0.00")
                    exApp.Cells.Item((cont) + 11, 12) = Format(totalAran, "#,##0.00")
                    exApp.Cells.Item((cont) + 11, 13) = Format(totalOtros, "#,##0.00")
                    exApp.Cells.Item((cont) + 11, 14) = Format(totalCosto, "#,##0.00")

                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Size = 11
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 1), exApp.Cells(cont + 11, 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Size = 10
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 11, 2), exApp.Cells(cont + 11, ColVisibles + 1)).BorderAround()

                    If ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible Then
                        exHoja.Range(exApp.Cells(cont + 11, 3), exApp.Cells(cont + 11, 3)).NumberFormat = "0"
                    ElseIf ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible = False Then
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

    Public Sub GridAExcelCompras(ByVal ElGrid As DataGridView)

        Dim ColVisibles As Integer = 0
        Dim FilasVisibles As Integer = 0

        Dim totalCompras As Double = 0

        'Creamos las variables
        Dim total As Double = 0
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            If ElGrid.RowCount > 0 Then

                'Añadimos el Libro al programa, y la hoja al libro
                exLibro = exApp.Workbooks.Add
                exHoja = exLibro.Worksheets.Add()

                ' ¿Cuantas columnas y cuantas filas?
                Dim NCol As Integer = ElGrid.ColumnCount
                Dim NRow As Integer = ElGrid.RowCount


                'Tituto

                exHoja.Range(exApp.Cells(1, 1), exApp.Cells(1, 6)).Merge(1)
                exHoja.Range(exApp.Cells(2, 1), exApp.Cells(2, 6)).Merge(1)
                exHoja.Range(exApp.Cells(3, 1), exApp.Cells(3, 6)).Merge(1)
                exHoja.Range(exApp.Cells(4, 1), exApp.Cells(4, 6)).Merge(1)
                exHoja.Range(exApp.Cells(1, 7), exApp.Cells(1, 9)).Merge(1)

                If My.Settings.Empresa = 2 Then

                    exHoja.Cells.Item(1, 1) = "Importadora Autopartes Global S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29580803-8"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)731.22.82"
                    exHoja.Cells.Item(4, 1) = "Email.: agsaonline@gmail.com"

                ElseIf My.Settings.Empresa = 3 Then

                    exHoja.Cells.Item(1, 1) = "Importadora Mil-26 S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-29469954-5"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)642.11.15"
                    exHoja.Cells.Item(4, 1) = "Email.: distribuidoramil26@gmail.com"

                ElseIf My.Settings.Empresa = 1 Or My.Settings.Empresa = 4 Or My.Settings.Empresa = 6 Or My.Settings.Empresa = 7 Then

                    exHoja.Cells.Item(1, 1) = "Comercializadora BRWME, S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-31135455-7"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (0212)761.10.31"
                    exHoja.Cells.Item(4, 1) = "Email.: brwmesa@gmail.com"

                ElseIf My.Settings.Empresa = 8 Then

                    exHoja.Cells.Item(1, 1) = "Nombre empresa Perú, S.A."
                    exHoja.Cells.Item(2, 1) = "RIF: J-11111111-1"
                    exHoja.Cells.Item(3, 1) = "Tlf.: (1111)111.11.11"
                    exHoja.Cells.Item(4, 1) = "Email.: peru@gmail.com"

                End If

                exHoja.Cells.Item(1, 7) = "Fecha: " + Today.ToShortDateString
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

                        exHoja.Cells.Item(6, a) = ElGrid.Columns(i - 1).HeaderText.ToString
                        ColVisibles = ColVisibles + 1
                        a = a + 1

                    End If

                Next

                exHoja.Range(exApp.Cells(7, 5), exApp.Cells(NRow + 10, 5)).Select()
                exApp.Selection.numberformat = "#.##0,00"
                exHoja.Cells(1, 1).select()
                Dim cont As Integer = 0
                Dim valor As Integer = 7
                Dim acum As Double = 0
                Dim acumFlete As Double = 0

                For Fila As Integer = 1 To NRow

                    If ElGrid.Rows(Fila - 1).Visible Then

                        FilasVisibles = FilasVisibles + 1

                        Dim b As Integer = 2

                        For cont5 As Integer = 0 To ElGrid.ColumnCount - 1

                            If ElGrid.Columns(cont5).Visible Then

                                exHoja.Cells.Item((valor), b).ClearFormats()
                                exHoja.Cells.Item((valor), b) = ElGrid.Rows(Fila - 1).Cells(cont5).Value

                                If cont5 = 5 Then

                                    totalCompras = totalCompras + ElGrid.Rows(Fila - 1).Cells(cont5).Value

                                Else

                                    exHoja.Cells.Item((valor), b) = exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).Text()
                                    exHoja.Range(exApp.Cells(valor, b), exApp.Cells(valor, b)).HorizontalAlignment = 2

                                End If

                                b = b + 1

                            End If

                        Next

                        cont = cont + 1
                        valor = valor + 1


                    End If

                    exHoja.Cells(Fila + 11, 7).select()

                Next

                If cont > 0 Then

                    exApp.Visible = True

                    'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
                    exHoja.Rows.Item(6).font.name = "Arial"
                    exHoja.Rows.Item(6).font.size = 10
                    exHoja.Rows.Item(6).Font.Bold = 1
                    exHoja.Rows.Item(6).HorizontalAlignment = 3

                    '--------------------------------------- BORDE --------------------------------------------'
                    '                                                                                          '
                    exHoja.Range(exApp.Cells(6, 2), exApp.Cells((cont) + 6, ColVisibles + 1)).BorderAround() '
                    '                                                                                          '
                    '--------------------------------------- BORDE --------------------------------------------'

                    exApp.Cells.Item((cont) + 7, 1) = "Totales"

                    exApp.Cells.Item((cont) + 7, 5) = Format(totalCompras, "#,##0.00")


                    exHoja.Range(exApp.Cells(cont + 7, 1), exApp.Cells(cont + 7, 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 7, 1), exApp.Cells(cont + 7, 1)).Font.Size = 11
                    exHoja.Range(exApp.Cells(cont + 7, 1), exApp.Cells(cont + 7, 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 7, 1), exApp.Cells(cont + 7, 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 7, 2), exApp.Cells(cont + 7, ColVisibles + 1)).Font.Name = "Arial"
                    exHoja.Range(exApp.Cells(cont + 7, 2), exApp.Cells(cont + 7, ColVisibles + 1)).Font.Size = 10
                    exHoja.Range(exApp.Cells(cont + 7, 2), exApp.Cells(cont + 7, ColVisibles + 1)).Font.Bold = True
                    exHoja.Range(exApp.Cells(cont + 7, 2), exApp.Cells(cont + 7, ColVisibles + 1)).Font.Italic = True
                    exHoja.Range(exApp.Cells(cont + 7, 2), exApp.Cells(cont + 7, ColVisibles + 1)).BorderAround()

                    If ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible Then
                        exHoja.Range(exApp.Cells(cont + 7, 3), exApp.Cells(cont + 7, 3)).NumberFormat = "0"
                    ElseIf ElGrid.Columns(1).Visible And ElGrid.Columns(0).Visible = False Then
                        exHoja.Range(exApp.Cells(cont + 7, 2), exApp.Cells(cont + 7, 2)).NumberFormat = "0"
                    End If

                End If

                exHoja.Range(exApp.Cells(6, 2), exApp.Cells(6, ColVisibles + 1)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(6, 2), exApp.Cells(6, ColVisibles + 1)).Font.Size = 10
                exHoja.Range(exApp.Cells(6, 2), exApp.Cells(6, ColVisibles + 1)).Font.Bold = True
                exHoja.Range(exApp.Cells(6, 2), exApp.Cells(6, ColVisibles + 1)).Font.Italic = True
                exHoja.Range(exApp.Cells(6, 2), exApp.Cells(6, ColVisibles + 1)).BorderAround()

                exHoja.Range(exApp.Cells(6, 2), exApp.Cells((cont) + 6, ColVisibles + 1)).Font.Name = "Arial"
                exHoja.Range(exApp.Cells(6, 2), exApp.Cells((cont) + 6, ColVisibles + 1)).Font.Size = 9

                exHoja.Range(exApp.Cells(6, 2), exApp.Cells((cont) + 6, ColVisibles + 1)).Columns.AutoFit()
                exHoja.Columns.AutoFit()
                exHoja.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape

                'Aplicación visible
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GridAExcel(DGV_Productos)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TablaProductos.Rows.Clear()
        TablaProductos.Columns.Clear()

        If DGV_Pedidos.SelectedRows.Count > 0 Then

            TablaProductos.Columns.Add(New DataColumn("Codigo"))
            TablaProductos.Columns.Add(New DataColumn("CodigoProductoF"))
            TablaProductos.Columns.Add(New DataColumn("Nombre"))
            TablaProductos.Columns.Add(New DataColumn("CantidadExistencia"))
            TablaProductos.Columns.Add(New DataColumn("CantidadPedido"))
            TablaProductos.Columns.Add(New DataColumn("Ubicación"))
            TablaProductos.Columns.Add(New DataColumn("Cantidad"))
            TablaProductos.Columns.Add(New DataColumn("Modelo"))
            DatosPedidosCompras.consulta_productos_nacionalizados(TablaProductos, CInt(lbl_codigo.Text))

            Dim pn As New R_Productos_Nacionalizados

            pn.valores(TablaProductos, CInt(lbl_codigo.Text), DGV_Pedidos.SelectedRows(0).Cells(2).Value.ToString())
            pn.Show()

        Else
            MsgBox("Debe seleccionar el pedido", MsgBoxStyle.Exclamation, "Mensaje de error")

        End If
    End Sub

    Private Sub DGV_Productos_Pedido_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Productos.CellDoubleClick

        If e.ColumnIndex = 1 Then

            If DGV_Productos.SelectedRows.Count > 0 Then

                If Not IsNothing(f17) Then

                    If Not f17.IsDisposed Then

                        f17.WindowState = FormWindowState.Normal
                        f17.BringToFront()
                        f17.cb_buscar.SelectedIndex = 0
                        f17.chk_exacto.Checked = True
                        If My.Settings.Empresa = 1 Then
                            f17.chk_fr.Checked = True
                        End If
                        f17.tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(1).Value
                        If f17.DGV_Productos.RowCount > 0 Then
                            f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                            f17.DGV_Productos_CellContentClick(f17.DGV_Productos, New EventArgs)
                        End If

                    Else

                        f17 = New Frm_Compras

                        For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                            If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                                f17.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                                cont = Frm_Principal.frm.Rows.Count
                            End If
                        Next

                        f17.Show()
                        f17.cb_buscar.SelectedIndex = 0
                        f17.chk_exacto.Checked = True
                        If My.Settings.Empresa = 1 Then
                            f17.chk_fr.Checked = True
                        End If
                        f17.tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(1).Value
                        If f17.DGV_Productos.RowCount > 0 Then
                            f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                            f17.DGV_Productos_CellContentClick(f17.DGV_Productos, New EventArgs)
                        End If

                    End If

                Else

                    f17 = New Frm_Compras

                    For cont As Integer = 0 To Frm_Principal.frm.Rows.Count - 1
                        If Frm_Principal.frm.Rows(cont).Item(0).ToString.ToUpper = ("Info. General").ToUpper Then
                            f17.permisos(Frm_Principal.frm.Rows(cont).Item(1), Frm_Principal.frm.Rows(cont).Item(2))
                            cont = Frm_Principal.frm.Rows.Count
                        End If
                    Next

                    f17.Show()
                    f17.cb_buscar.SelectedIndex = 0
                    f17.chk_exacto.Checked = True
                    If My.Settings.Empresa = 1 Then
                        f17.chk_fr.Checked = True
                    End If
                    f17.tb_buscarcodigo.Text = DGV_Productos.SelectedRows(0).Cells(1).Value
                    If f17.DGV_Productos.RowCount > 0 Then
                        f17.DGV_Productos.Rows(0).Cells(0).Selected = True
                        f17.DGV_Productos_CellContentClick(f17.DGV_Productos, New EventArgs)
                    End If

                End If

            End If

        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged, DateTimePicker3.ValueChanged

        If DomainUpDown1.SelectedIndex = 0 Then
            DatosComprasCargadas.consulta_compras_like(DGV_Pedidos, tb_buscarcodigo.Text, 0, lbl_dolares.Text, lbl_euros.Text, DateTimePicker2.Value, DateTimePicker3.Value)
            DGV_Pedidos.ClearSelection()
        ElseIf DomainUpDown1.SelectedIndex = 1 Then
            DatosComprasCargadas.consulta_compras_like(DGV_Pedidos, tb_buscarcodigo.Text, 1, lbl_dolares.Text, lbl_euros.Text, DateTimePicker2.Value, DateTimePicker3.Value)
            DGV_Pedidos.ClearSelection()
        ElseIf DomainUpDown1.SelectedIndex = 2 Then
            DatosComprasCargadas.consulta_compras_like(DGV_Pedidos, tb_buscarcodigo.Text, 2, lbl_dolares.Text, lbl_euros.Text, DateTimePicker2.Value, DateTimePicker3.Value)
            DGV_Pedidos.ClearSelection()
        End If

    End Sub

    Private Sub DGV_Pedidos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Pedidos.CellDoubleClick
        If e.ColumnIndex = 0 Then

            If Not IsNothing(frm) Then

                If Not frm.IsDisposed Then

                    frm.Prov = DGV_Pedidos.SelectedRows(0).Cells(2).Value
                    frm.CodC = DGV_Pedidos.SelectedRows(0).Cells(4).Value
                    frm.Fact = DGV_Pedidos.SelectedRows(0).Cells(0).Value
                    frm.Dgv_Compras = Me.DGV_Pedidos
                    frm.WindowState = FormWindowState.Normal
                    frm.BringToFront()

                Else

                    frm = New Frm_ModificarFacturaCompra
                    frm.Prov = DGV_Pedidos.SelectedRows(0).Cells(2).Value
                    frm.CodC = DGV_Pedidos.SelectedRows(0).Cells(4).Value
                    frm.Fact = DGV_Pedidos.SelectedRows(0).Cells(0).Value
                    frm.Dgv_Compras = Me.DGV_Pedidos
                    frm.Show()

                End If

            Else

                frm = New Frm_ModificarFacturaCompra
                frm.Prov = DGV_Pedidos.SelectedRows(0).Cells(2).Value
                frm.CodC = DGV_Pedidos.SelectedRows(0).Cells(4).Value
                frm.Fact = DGV_Pedidos.SelectedRows(0).Cells(0).Value
                frm.Dgv_Compras = Me.DGV_Pedidos
                frm.Show()

            End If

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GridAExcelCompras(DGV_Pedidos)
    End Sub
End Class