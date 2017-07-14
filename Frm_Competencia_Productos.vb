Imports System.Data.OleDb
Public Class Frm_Competencia_Productos

    Dim num As Integer = 0
    Dim dgv_c As DataGridView
    Dim dgv_p As DataGridView

    Private Sub Frm_Competencia_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text
        rb_excel.Focus()

    End Sub

    Public Sub competecia(ByVal rif1 As String, ByVal nombre1 As String, ByRef index As Integer, ByRef dgv As DataGridView, ByRef dgvp As DataGridView)
        dgv_c = dgv
        tb_rif.Text = rif1
        tb_nombre.Text = nombre1
        num = index
        dgv_p = dgvp


    End Sub

    Private Sub rb_txt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_txt.CheckedChanged

        If rb_txt.Checked = True Then

            lbl_caractec2.Visible = True
            rb_carcter2.Visible = True
            rb_carcter2.Focus()

        Else

            lbl_caractec2.Visible = False
            rb_carcter2.Visible = False
            rb_carcter2.Text = ""

        End If

    End Sub

    Private Sub rb_csv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_csv.CheckedChanged

        If rb_csv.Checked = True Then

            lbl_Caracter.Visible = True
            tb_caracter.Visible = True
            tb_caracter.Focus()

        Else

            lbl_Caracter.Visible = False
            tb_caracter.Visible = False
            tb_caracter.Text = ""

        End If

    End Sub

    Private Sub bt_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_foto.Click

        Dim tipo As String = ""
        Dim file As New OpenFileDialog
        file.Title = "Browse the file"
        file.Filter = "All files (*.*)|*.*"

        If file.ShowDialog = Windows.Forms.DialogResult.OK Then

            tb_archivo.SelectAll()
            tb_archivo.Text = file.FileName

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DGV_Productos.Columns.Clear()
        cb_año.Items.Clear()
        cb_cod_imp.Items.Clear()
        cb_codfab.Items.Clear()
        cb_codOEM.Items.Clear()
        cb_descripcion.Items.Clear()
        cb_marca.Items.Clear()
        cb_modelo.Items.Clear()
        cb_precio.Items.Clear()
        cb_stock.Items.Clear()
        cb_año.Items.Add("(Ninguna)")
        cb_cod_imp.Items.Add("(Ninguna)")
        cb_codfab.Items.Add("(Ninguna)")
        cb_codOEM.Items.Add("(Ninguna)")
        cb_descripcion.Items.Add("(Ninguna)")
        cb_marca.Items.Add("(Ninguna)")
        cb_modelo.Items.Add("(Ninguna)")
        cb_precio.Items.Add("(Ninguna)")
        cb_stock.Items.Add("(Ninguna)")
        cb_año.SelectedIndex = 0
        cb_cod_imp.SelectedIndex = 0
        cb_codfab.SelectedIndex = 0
        cb_codOEM.SelectedIndex = 0
        cb_descripcion.SelectedIndex = 0
        cb_marca.SelectedIndex = 0
        cb_modelo.SelectedIndex = 0
        cb_precio.SelectedIndex = 0
        cb_stock.SelectedIndex = 0


        Dim tipo As String = ""
        Dim caracter As String = ""
        If rb_excel.Checked = True Then
            tipo = "E"
        ElseIf rb_txt.Checked = True Then
            tipo = "T"
            caracter = rb_carcter2.Text
        ElseIf rb_csv.Checked = True Then
            tipo = "C"
            caracter = tb_caracter.Text
        Else
            MsgBox("Debe seleccionar el tipo de archivo", MsgBoxStyle.Information, "Error")
        End If


        If tb_archivo.Text <> "" Then
            If tipo = "T" Or tipo = "C" Then

                If (tipo = "T" And rb_carcter2.Text = "") Or (tipo = "C" And tb_caracter.Text = "") Then
                    MsgBox("Debe decir cual es el caracter", MsgBoxStyle.Information, "Error")
                    If rb_carcter2.Visible = True Then
                        rb_carcter2.Focus()
                    Else
                        tb_caracter.Focus()
                    End If
                Else


                    If tipo = "T" Or tipo = "C" Then
                        If tipo = "T" Then
                            caracter = rb_carcter2.Text
                        Else
                            caracter = tb_caracter.Text
                        End If
                        LeerTxt(caracter, tipo)
                        tb_archivo.Text = ""
                        rb_csv.Checked = False
                        rb_txt.Checked = False
                        rb_txt.Checked = False
                        tb_caracter.Text = ""
                        rb_carcter2.Text = ""
                    End If


                End If
            ElseIf tipo = "E" Then

                LeerExcel()


            End If
        Else
            MsgBox("Debe cargar el archivo", MsgBoxStyle.Information, "Error")
            bt_foto.Focus()
        End If
    End Sub




    Private Sub LeerTxt(ByVal caracter As String, ByVal tipo As String)


        DGV_Productos.DataSource = Nothing
        DGV_Productos.Rows.Clear()

        Dim ubicacion As String = ""
        Dim c() As String
        Dim fileReader As String
        Dim cantidad As Integer = 0
        ubicacion = tb_archivo.Text.Trim
        fileReader = My.Computer.FileSystem.ReadAllText(ubicacion)

        c = Split(fileReader, vbNewLine)

        Dim i As Integer = 0
        Dim cols As Integer
        Dim f As Integer = c.Length / 2
        If c(f).LastIndexOf(caracter(0)) = c(f).Length - 1 Then
            cols = c(f).Split(caracter).Length - 1
        Else
            cols = c(f).Split(caracter).Length
        End If

        Dim column As New DataGridViewColumn

        While i <= cols
            Me.DGV_Productos.Columns.Add(i, "Columna " & i + 1)

            i = i + 1
        End While


        i = 0

        Dim row As New DataGridViewRow

        While i < c.Length
            If c(i).Length > 1 Then
                Me.DGV_Productos.Rows.Add(c(i).Split(caracter))
            End If
            i = i + 1
        End While
        For cont3 As Integer = 0 To DGV_Productos.RowCount - 1
            For cont4 As Integer = 0 To DGV_Productos.ColumnCount - 1
                If DGV_Productos.Rows(cont3).Cells(cont4).Value <> Nothing Then
                    DGV_Productos.Rows(cont3).Cells(cont4).Value = DGV_Productos.Rows(cont3).Cells(cont4).Value.ToString.Trim(",")
                End If

            Next

            Dim b As Boolean = False
            Dim cont5 As Integer = 0
            Dim cont6 As Integer = 0
            Dim valor As Integer = 0

            While cont5 <= DGV_Productos.ColumnCount - 1
                While cont6 <= DGV_Productos.RowCount - 1
                    If DGV_Productos.Rows(cont6).Cells(cont5).Value <> "" Then
                        b = True
                        cont6 = DGV_Productos.RowCount
                    End If

                    cont6 = cont6 + 1
                End While
                If b = False Then
                    If cont5 <> 0 Then
                        DGV_Productos.Columns.RemoveAt(cont5)
                        cont5 = cont5 - 1
                    Else
                        DGV_Productos.Columns.RemoveAt(0)
                        cont5 = cont5 - 1
                    End If
                End If

                cont5 = cont5 + 1
                cont6 = 0
                b = False
            End While

        Next


        If tipo = "C" Then

            For cont3 As Integer = 0 To DGV_Productos.RowCount - 1
                For cont4 As Integer = 0 To DGV_Productos.ColumnCount - 1
                    If DGV_Productos.Rows(cont3).Cells(cont4).Value <> Nothing Then
                        DGV_Productos.Rows(cont3).Cells(cont4).Value = DGV_Productos.Rows(cont3).Cells(cont4).Value.ToString.Trim(",")
                    End If

                Next

            Next

            Dim b As Boolean = False
            Dim cont5 As Integer = 0
            Dim cont6 As Integer = 0
            Dim valor As Integer = 0

            While cont5 <= DGV_Productos.ColumnCount - 1
                While cont6 <= DGV_Productos.RowCount - 1
                    If DGV_Productos.Rows(cont6).Cells(cont5).Value <> "" Then
                        b = True
                        cont6 = DGV_Productos.RowCount
                    End If

                    cont6 = cont6 + 1
                End While
                If b = False Then
                    If cont5 <> 0 Then
                        DGV_Productos.Columns.RemoveAt(cont5)
                        cont5 = cont5 - 1
                    Else
                        DGV_Productos.Columns.RemoveAt(0)
                        cont5 = cont5 - 1
                    End If
                End If

                cont5 = cont5 + 1
                cont6 = 0
                b = False
            End While

        End If



        For cont As Integer = 0 To DGV_Productos.ColumnCount - 1
            DGV_Productos.Columns(cont).HeaderText = ("Columna " & cont + 1)
            cb_año.Items.Add("Columna " & cont + 1)
            cb_cod_imp.Items.Add("Columna " & cont + 1)
            cb_codfab.Items.Add("Columna " & cont + 1)
            cb_codOEM.Items.Add("Columna " & cont + 1)
            cb_descripcion.Items.Add("Columna " & cont + 1)
            cb_marca.Items.Add("Columna " & cont + 1)
            cb_modelo.Items.Add("Columna " & cont + 1)
            cb_precio.Items.Add("Columna " & cont + 1)
            cb_stock.Items.Add("Columna " & cont + 1)

        Next

        DGV_Productos.ClearSelection()


    End Sub


    Private Sub LeerExcel()

        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim _filename As String = tb_archivo.Text
        Dim _conn As String
        _conn = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & _filename & ";" & "Extended Properties=Excel 12.0;"
        Dim _connection As OleDbConnection = New OleDbConnection(_conn)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim _command As OleDbCommand = New OleDbCommand()
        _command.Connection = _connection
        _command.CommandText = "SELECT * FROM [Hoja1$]"
        da.SelectCommand = _command

        Try
            da.Fill(ds1, "Hoja1")
            '_connection.Close()
            Dim columnas As Integer = 0
            Dim tabla As New DataTable
            'Dim tabla As DataTable = ds1.Tables(0)

            For cont As Integer = 0 To ds1.Tables.Item(0).Columns.Count - 1

                tabla.Columns.Add("Columna " & (cont + 1).ToString)
                tabla.Columns(cont).DataType = System.Type.GetType("System.String")
                cb_año.Items.Add("Columna " & cont + 1)
                cb_cod_imp.Items.Add("Columna " & cont + 1)
                cb_codfab.Items.Add("Columna " & cont + 1)
                cb_codOEM.Items.Add("Columna " & cont + 1)
                cb_descripcion.Items.Add("Columna " & cont + 1)
                cb_marca.Items.Add("Columna " & cont + 1)
                cb_modelo.Items.Add("Columna " & cont + 1)
                cb_precio.Items.Add("Columna " & cont + 1)
                cb_stock.Items.Add("Columna " & cont + 1)
                columnas = columnas + 1

            Next

            Dim arreglo(columnas - 1) As String

            For cont As Integer = 0 To arreglo.Length - 1
                arreglo(cont) = "Columna " & cont + 1
            Next

            tabla.Rows.Add(arreglo)

            For cont As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                tabla.Rows.Add()
                For cont2 As Integer = 0 To ds1.Tables(0).columns.Count - 1
                    tabla.Rows(cont).Item(cont2) = ds1.Tables(0).Rows(cont).Item(cont2)
                Next
            Next

            Dim cont3 As Integer = 0

            While cont3 < tabla.Rows.Count

                If tabla.Rows(cont3).IsNull(0) And tabla.Rows(cont3).IsNull(1) Then

                    tabla.Rows(cont3).Delete()
                Else
                    cont3 = cont3 + 1

                End If

            End While


            DGV_Productos.DataSource = tabla

            'Agregar_columna()
            DGV_Productos.ClearSelection()

        Catch e1 As Exception
            MessageBox.Show("Import Failed, correct Column name in the sheet!")
        End Try


    End Sub

   
 
    Private Sub bt_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cargar.Click

        Dim ci As Integer = 0
        Dim cf As Integer = 0
        Dim co As Integer = 0
        Dim cd As Integer = 0
        Dim cm As Integer = 0
        Dim cmo As Integer = 0
        Dim ca As Integer = 0
        Dim cs As Integer = 0
        Dim cp As Integer = 0


        Dim hacer As Boolean = False

        If (cb_precio.Text = "(Ninguna)") Or ((cb_cod_imp.Text = "(Ninguna)") And (cb_codfab.Text = "(Ninguna)") And (cb_codOEM.Text = "(Ninguna)")) Then

            MsgBox("Debe asignar el precio y al menos un código para cargar los productos ", MsgBoxStyle.Critical, "SIMPRO")

        Else

            If ((cb_año.Text = cb_cod_imp.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_cod_imp.Text <> "(Ninguna)"))) Or ((cb_año.Text = cb_codfab.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_codfab.Text <> "(Ninguna)"))) Or ((cb_año.Text = cb_codOEM.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_codOEM.Text <> "(Ninguna)"))) Or ((cb_año.Text = cb_descripcion.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_descripcion.Text <> "(Ninguna)"))) Or ((cb_año.Text = cb_marca.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_marca.Text <> "(Ninguna)"))) Or ((cb_año.Text = cb_modelo.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_modelo.Text <> "(Ninguna)"))) Or ((cb_año.Text = cb_precio.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_precio.Text <> "(Ninguna)"))) Or ((cb_año.Text = cb_stock.Text) And ((cb_año.Text <> "(Ninguna)") And (cb_stock.Text <> "(Ninguna)"))) Or ((cb_cod_imp.Text = cb_descripcion.Text) And ((cb_cod_imp.Text <> "(Ninguna)") And (cb_descripcion.Text <> "(Ninguna)"))) Or ((cb_cod_imp.Text = cb_marca.Text) And ((cb_cod_imp.Text <> "(Ninguna)") And (cb_marca.Text <> "(Ninguna)"))) Or ((cb_cod_imp.Text = cb_modelo.Text) And ((cb_cod_imp.Text <> "(Ninguna)") And (cb_modelo.Text <> "(Ninguna)"))) Or ((cb_cod_imp.Text = cb_precio.Text) And ((cb_cod_imp.Text <> "(Ninguna)") And (cb_precio.Text <> "(Ninguna)"))) Or ((cb_cod_imp.Text = cb_stock.Text) And ((cb_cod_imp.Text <> "(Ninguna)") And (cb_stock.Text <> "(Ninguna)"))) Or ((cb_codOEM.Text = cb_descripcion.Text) And ((cb_codOEM.Text <> "(Ninguna)") And (cb_descripcion.Text <> "(Ninguna)"))) Or ((cb_codOEM.Text = cb_marca.Text) And ((cb_codOEM.Text <> "(Ninguna)") And (cb_marca.Text <> "(Ninguna)"))) Or ((cb_codOEM.Text = cb_modelo.Text) And ((cb_codOEM.Text <> "(Ninguna)") And (cb_modelo.Text <> "(Ninguna)"))) Or ((cb_codOEM.Text = cb_precio.Text) And ((cb_codOEM.Text <> "(Ninguna)") And (cb_precio.Text <> "(Ninguna)"))) Or ((cb_codOEM.Text = cb_stock.Text) And ((cb_codOEM.Text <> "(Ninguna)") And (cb_stock.Text <> "(Ninguna)"))) Or ((cb_descripcion.Text = cb_marca.Text) And ((cb_descripcion.Text <> "(Ninguna)") And (cb_marca.Text <> "(Ninguna)"))) Or ((cb_descripcion.Text = cb_modelo.Text) And ((cb_descripcion.Text <> "(Ninguna)") And (cb_modelo.Text <> "(Ninguna)"))) Or ((cb_descripcion.Text = cb_precio.Text) And ((cb_descripcion.Text <> "(Ninguna)") And (cb_precio.Text <> "(Ninguna)"))) Or ((cb_descripcion.Text = cb_stock.Text) And ((cb_descripcion.Text <> "(Ninguna)") And (cb_stock.Text <> "(Ninguna)"))) Or ((cb_marca.Text = cb_modelo.Text) And ((cb_marca.Text <> "(Ninguna)") And (cb_modelo.Text <> "(Ninguna)"))) Or ((cb_marca.Text = cb_precio.Text) And ((cb_marca.Text <> "(Ninguna)") And (cb_precio.Text <> "(Ninguna)"))) Or ((cb_marca.Text = cb_stock.Text) And ((cb_marca.Text <> "(Ninguna)") And (cb_stock.Text <> "(Ninguna)"))) Or ((cb_modelo.Text = cb_precio.Text) And ((cb_modelo.Text <> "(Ninguna)") And (cb_precio.Text <> "(Ninguna)"))) Or ((cb_modelo.Text = cb_stock.Text) And ((cb_modelo.Text <> "(Ninguna)") And (cb_stock.Text <> "(Ninguna)"))) Or ((cb_precio.Text = cb_stock.Text) And ((cb_precio.Text <> "(Ninguna)") And (cb_stock.Text <> "(Ninguna)"))) Or ((cb_cod_imp.Text = cb_codfab.Text) And ((cb_cod_imp.Text <> "(Ninguna)") And (cb_codfab.Text <> "(Ninguna)"))) Or ((cb_cod_imp.Text = cb_codOEM.Text) And ((cb_cod_imp.Text <> "(Ninguna)") And (cb_codOEM.Text <> "(Ninguna)"))) Or ((cb_codfab.Text = cb_codOEM.Text) And ((cb_codfab.Text <> "(Ninguna)") And (cb_codOEM.Text <> "(Ninguna)"))) Then

                hacer = True

            End If


            If hacer = False Then


                For cont As Integer = 0 To DGV_Productos.ColumnCount - 1

                    If (cb_año.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        ca = cont
                        DGV_Productos.Columns(cont).HeaderText = "Año"

                    ElseIf (cb_cod_imp.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        ci = cont
                        DGV_Productos.Columns(cont).HeaderText = "Cod.Import."

                    ElseIf (cb_codfab.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        cf = cont
                        DGV_Productos.Columns(cont).HeaderText = "Cod.Fab."

                    ElseIf (cb_codOEM.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        co = cont
                        DGV_Productos.Columns(cont).HeaderText = "Cod.OEM"

                    ElseIf (cb_descripcion.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        cd = cont
                        DGV_Productos.Columns(cont).HeaderText = "Descripción"

                    ElseIf (cb_marca.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        cm = cont
                        DGV_Productos.Columns(cont).HeaderText = "Marca"

                    ElseIf (cb_modelo.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        cmo = cont
                        DGV_Productos.Columns(cont).HeaderText = "Modelo"

                    ElseIf (cb_precio.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        cp = cont
                        DGV_Productos.Columns(cont).HeaderText = "Precio"

                    ElseIf (cb_stock.Text.Trim = DGV_Productos.Columns(cont).HeaderText.Trim) Then

                        cs = cont
                        DGV_Productos.Columns(cont).HeaderText = "Stock"

                    Else

                        DGV_Productos.Columns(cont).Visible = False

                    End If
                Next
                DGV_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                
                Dim response As MsgBoxResult
                response = MsgBox("¿Está seguro de querer cargar estos productos?", MsgBoxStyle.YesNo, "Confirmar la Cargar")
               
                
                 If (response = MsgBoxResult.Yes) Then

                    Dim imp As String = ""
                    Dim fab As String = ""
                    Dim OEM As String = ""
                    Dim desc As String = ""
                    Dim Mar As String = ""
                    Dim mode As String = ""
                    Dim a As String = ""
                    Dim st As String = ""
                   
                    Try

                        For cont2 As Integer = 0 To DGV_Productos.RowCount - 1

                            If cb_cod_imp.Text = "(Ninguna)" Then
                                imp = ""
                            Else
                                imp = DGV_Productos.Rows(cont2).Cells(ci).Value
                            End If

                            If cb_codfab.Text = "(Ninguna)" Then
                                fab = ""
                            Else
                                fab = DGV_Productos.Rows(cont2).Cells(cf).Value
                            End If

                            If cb_codOEM.Text = "(Ninguna)" Then
                                OEM = ""
                            Else
                                OEM = DGV_Productos.Rows(cont2).Cells(co).Value
                            End If

                            If cb_descripcion.Text = "(Ninguna)" Then
                                desc = ""
                            Else
                                desc = DGV_Productos.Rows(cont2).Cells(cd).Value
                            End If

                            If cb_marca.Text = "(Ninguna)" Then
                                Mar = ""
                            Else
                                Mar = DGV_Productos.Rows(cont2).Cells(cm).Value
                            End If

                            If cb_modelo.Text = "(Ninguna)" Then
                                mode = ""
                            Else
                                mode = DGV_Productos.Rows(cont2).Cells(cmo).Value
                            End If

                            If cb_año.Text = "(Ninguna)" Then
                                a = ""
                            Else
                                a = DGV_Productos.Rows(cont2).Cells(ca).Value
                            End If

                            If cb_stock.Text = "(Ninguna)" Then
                                st = ""
                            Else
                                st = DGV_Productos.Rows(cont2).Cells(cs).Value
                            End If

                            DatosCompetencia.Inserta_productos_competencia(tb_rif.Text, imp, fab, OEM, desc, Mar, mode, a, st, CDbl(DGV_Productos.Rows(cont2).Cells(cp).Value))

                        Next
                    Catch ex As Exception

                        MsgBox("Verfique que la columna " & cb_precio.Text & " sea la adecuada para los precios")

                    End Try

                    'If f = False Then
                    MsgBox("Los prodcutos de " & tb_nombre.Text & " han sido cargados", MsgBoxStyle.Information, "SIMPRO")

                    DGV_Productos.Columns.Clear()
                    cb_año.Items.Clear()
                    cb_cod_imp.Items.Clear()
                    cb_codfab.Items.Clear()
                    cb_codOEM.Items.Clear()
                    cb_descripcion.Items.Clear()
                    cb_marca.Items.Clear()
                    cb_modelo.Items.Clear()
                    cb_precio.Items.Clear()
                    cb_stock.Items.Clear()
                    cb_año.Items.Add("(Ninguna)")
                    cb_cod_imp.Items.Add("(Ninguna)")
                    cb_codfab.Items.Add("(Ninguna)")
                    cb_codOEM.Items.Add("(Ninguna)")
                    cb_descripcion.Items.Add("(Ninguna)")
                    cb_marca.Items.Add("(Ninguna)")
                    cb_modelo.Items.Add("(Ninguna)")
                    cb_precio.Items.Add("(Ninguna)")
                    cb_stock.Items.Add("(Ninguna)")
                    cb_año.SelectedIndex = 0
                    cb_cod_imp.SelectedIndex = 0
                    cb_codfab.SelectedIndex = 0
                    cb_codOEM.SelectedIndex = 0
                    cb_descripcion.SelectedIndex = 0
                    cb_marca.SelectedIndex = 0
                    cb_modelo.SelectedIndex = 0
                    cb_precio.SelectedIndex = 0
                    cb_stock.SelectedIndex = 0
                    tb_archivo.Text = ""
                    rb_csv.Checked = False
                    rb_excel.Checked = False
                    rb_txt.Checked = False

                 

                Else

                    For cont As Integer = 0 To DGV_Productos.ColumnCount - 1
                        DGV_Productos.Columns(cont).Visible = True
                    Next

                    DGV_Productos.Columns(ci).HeaderText = ("Columna " & ci + 1)
                    DGV_Productos.Columns(cf).HeaderText = ("Columna " & cf + 1)
                    DGV_Productos.Columns(co).HeaderText = ("Columna " & co + 1)
                    DGV_Productos.Columns(cd).HeaderText = ("Columna " & cd + 1)
                    DGV_Productos.Columns(cm).HeaderText = ("Columna " & cm + 1)
                    DGV_Productos.Columns(cmo).HeaderText = ("Columna " & cmo + 1)
                    DGV_Productos.Columns(ca).HeaderText = ("Columna " & ca + 1)
                    DGV_Productos.Columns(cs).HeaderText = ("Columna " & cs + 1)
                    DGV_Productos.Columns(cp).HeaderText = ("Columna " & cp + 1)

                End If

         
            Else
                MsgBox("Hay una columna asignada más de una vez", MsgBoxStyle.Critical, "SIMPRO")
                hacer = False
            End If


        End If

    End Sub


    Private Sub Frm_Competencia_Productos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Frm_Competencia.recibe_num(num, dgv_c, dgv_p)

    End Sub

   
End Class