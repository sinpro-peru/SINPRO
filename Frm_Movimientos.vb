Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Frm_Movimientos


    Dim fecha As Integer = 0




    Private Sub Frm_Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Datos.consultaLogo(Me.PictureBox3)
        DatosMovimientos.consulta_bancos(cb_banco)
        'cb_banco.SelectedIndex = 0
        cb_egreso.Items.Add("(Ninguna)")
        cb_ingreso.Items.Add("(Ninguna)")
        cb_numerodep.Items.Add("(Ninguna)")
        cb_fecha.Items.Add("(Ninguna)")
        tb_descripcion.Items.Add("(Ninguna)")
        tb_oficina.Items.Add("(Ninguna)")
        cb_egreso.SelectedIndex = 0
        tb_oficina.SelectedIndex = 0
        cb_ingreso.SelectedIndex = 0
        cb_numerodep.SelectedIndex = 0
        cb_fecha.SelectedIndex = 0
        tb_descripcion.SelectedIndex = 0
        cb_f1.SelectedIndex = 0
        cb_f2.SelectedIndex = 1
        cb_f3.SelectedIndex = 2

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
                cb_egreso.Items.Add("Columna " & cont + 1)
                cb_ingreso.Items.Add("Columna " & cont + 1)
                cb_numerodep.Items.Add("Columna " & cont + 1)
                cb_fecha.Items.Add("Columna " & cont + 1)
                tb_descripcion.Items.Add("Columna " & cont + 1)
                tb_oficina.Items.Add("Columna " & cont + 1)
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


            DGV_Movimientos.DataSource = tabla

            Agregar_columna()
            DGV_Movimientos.ClearSelection()

        Catch e1 As Exception
            MessageBox.Show("Import Failed, correct Column name in the sheet!")
        End Try

       
    End Sub

    Private Sub LeerTxt(ByVal caracter As String, ByVal tipo As String)

        DGV_Movimientos.DataSource = Nothing
        DGV_Movimientos.Rows.Clear()

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
            Me.DGV_Movimientos.Columns.Add(i, "Columna " & i + 1)
            i = i + 1
        End While

        If cb_banco.SelectedItem.code.ToString = "9" Or cb_banco.SelectedItem.code.ToString = "8" Then
            Me.DGV_Movimientos.Columns.Add(i, "Columna " & i + 1)
        End If

        i = 0

        Dim row As New DataGridViewRow

        If cb_banco.SelectedItem.code.ToString = "9" Then

            While i < c.Length

                If c(i).Length > 1 Then

                    If CDbl(c(i).Split(caracter)(3).Trim.Replace("+", "")) > 0 Then
                        Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter)(0).Replace("/", ""), c(i).Split(caracter)(1), c(i).Split(caracter)(2), _
                        CDbl(c(i).Split(caracter)(3).Trim.Replace("+", "").Replace("-", "")), " ", c(i).Split(caracter)(4), "")
                    Else
                        Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter)(0).Replace("/", ""), c(i).Split(caracter)(1), c(i).Split(caracter)(2), " ", _
                        CDbl(c(i).Split(caracter)(3).Trim.Replace("+", "").Replace("-", "")), c(i).Split(caracter)(4), "")
                    End If

                End If
                i = i + 1
            End While

        ElseIf cb_banco.SelectedItem.code = "2" Then

            While i < c.Length

                If c(i).Length > 1 Then

                    If CDbl(c(i).Split(caracter)(4)) = 0 Then

                        Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter)(0), c(i).Split(caracter)(1), c(i).Split(caracter)(2), _
                        c(i).Split(caracter)(3), "", CDbl(c(i).Split(caracter)(5) / 100), CDbl(c(i).Split(caracter)(6)) / 100, _
                        c(i).Split(caracter)(7), c(i).Split(caracter)(8), c(i).Split(caracter)(9), c(i).Split(caracter)(10))

                    ElseIf CDbl(c(i).Split(caracter)(5)) = 0 Then

                        Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter)(0), c(i).Split(caracter)(1), c(i).Split(caracter)(2), _
                        c(i).Split(caracter)(3), CDbl(c(i).Split(caracter)(4) / 100), "", CDbl(c(i).Split(caracter)(6)) / 100, _
                        c(i).Split(caracter)(7), c(i).Split(caracter)(8), c(i).Split(caracter)(9), c(i).Split(caracter)(10))

                    Else

                        Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter)(0), c(i).Split(caracter)(1), c(i).Split(caracter)(2), _
                        c(i).Split(caracter)(3), CDbl(c(i).Split(caracter)(4)) / 100, CDbl(c(i).Split(caracter)(5) / 100), CDbl(c(i).Split(caracter)(6)) / 100, _
                        c(i).Split(caracter)(7), c(i).Split(caracter)(8), c(i).Split(caracter)(9), c(i).Split(caracter)(10))

                    End If

                End If

                i = i + 1

            End While

        ElseIf cb_banco.SelectedItem.code.ToString = "8" Then

            While i < c.Length

                If c(i).Length > 1 Then

                    If CDbl(c(i).Split(caracter)(5).Trim.Replace("+", "")) > 0 Then
                        Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter)(0), c(i).Split(caracter)(1).Replace("/", ""), c(i).Split(caracter)(2), _
                        c(i).Split(caracter)(3), c(i).Split(caracter)(4), _
                        CDbl(c(i).Split(caracter)(5).Trim.Replace("+", "").Replace("-", "")), " ", c(i).Split(caracter)(6), "")
                    Else
                        Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter)(0), c(i).Split(caracter)(1).Replace("/", ""), c(i).Split(caracter)(2), _
                        c(i).Split(caracter)(3), c(i).Split(caracter)(4), _
                        " ", CDbl(c(i).Split(caracter)(5).Trim.Replace("+", "").Replace("-", "")), c(i).Split(caracter)(6), "")
                    End If

                End If
                i = i + 1
            End While


        Else

            While i < c.Length

                If c(i).Length > 1 Then

                    Me.DGV_Movimientos.Rows.Add(c(i).Split(caracter))

                End If
                i = i + 1
            End While

        End If

        For cont3 As Integer = 0 To DGV_Movimientos.RowCount - 1
            For cont4 As Integer = 0 To DGV_Movimientos.ColumnCount - 1
                If DGV_Movimientos.Rows(cont3).Cells(cont4).Value <> Nothing Then
                    DGV_Movimientos.Rows(cont3).Cells(cont4).Value = DGV_Movimientos.Rows(cont3).Cells(cont4).Value.ToString.Trim(",")
                End If

            Next

            Dim b As Boolean = False
            Dim cont5 As Integer = 0
            Dim cont6 As Integer = 0
            Dim valor As Integer = 0

            While cont5 <= DGV_Movimientos.ColumnCount - 1
                While cont6 <= DGV_Movimientos.RowCount - 1

                    If Not DGV_Movimientos.Rows(cont6).Cells(cont5).Value Is Nothing Then
                        If DGV_Movimientos.Rows(cont6).Cells(cont5).Value.ToString <> "" Then
                            b = True
                            cont6 = DGV_Movimientos.RowCount
                        End If
                    End If

                    cont6 = cont6 + 1
                End While
                If b = False Then
                    If cont5 <> 0 Then
                        DGV_Movimientos.Columns.RemoveAt(cont5)
                        cont5 = cont5 - 1
                    Else
                        DGV_Movimientos.Columns.RemoveAt(0)
                        cont5 = cont5 - 1
                    End If
                End If

                cont5 = cont5 + 1
                cont6 = 0
                b = False
            End While

        Next


        If tipo = "C" Then

            For cont3 As Integer = 0 To DGV_Movimientos.RowCount - 1
                For cont4 As Integer = 0 To DGV_Movimientos.ColumnCount - 1
                    If DGV_Movimientos.Rows(cont3).Cells(cont4).Value <> Nothing Then
                        DGV_Movimientos.Rows(cont3).Cells(cont4).Value = DGV_Movimientos.Rows(cont3).Cells(cont4).Value.ToString.Trim(",")
                    End If

                Next

            Next

            Dim b As Boolean = False
            Dim cont5 As Integer = 0
            Dim cont6 As Integer = 0
            Dim valor As Integer = 0

            While cont5 <= DGV_Movimientos.ColumnCount - 1
                While cont6 <= DGV_Movimientos.RowCount - 1
                    If DGV_Movimientos.Rows(cont6).Cells(cont5).Value <> "" Then
                        b = True
                        cont6 = DGV_Movimientos.RowCount
                    End If

                    cont6 = cont6 + 1
                End While
                If b = False Then
                    If cont5 <> 0 Then
                        DGV_Movimientos.Columns.RemoveAt(cont5)
                        cont5 = cont5 - 1
                    Else
                        DGV_Movimientos.Columns.RemoveAt(0)
                        cont5 = cont5 - 1
                    End If
                End If

                cont5 = cont5 + 1
                cont6 = 0
                b = False
            End While

        End If



        For cont As Integer = 0 To DGV_Movimientos.ColumnCount - 1
            DGV_Movimientos.Columns(cont).HeaderText = ("Columna " & cont + 1)
            cb_egreso.Items.Add("Columna " & cont + 1)
            cb_ingreso.Items.Add("Columna " & cont + 1)
            cb_numerodep.Items.Add("Columna " & cont + 1)
            cb_fecha.Items.Add("Columna " & cont + 1)
            tb_descripcion.Items.Add("Columna " & cont + 1)
            tb_oficina.Items.Add("Columna " & cont + 1)

        Next
        Agregar_columna()
        DGV_Movimientos.ClearSelection()


    End Sub



    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click
        Dim ce As Integer = 0
        Dim cf As Integer = 0
        Dim ci As Integer = 0
        Dim cn As Integer = 0
        Dim cd As Integer = 0
        Dim co As Integer = 0
        Dim hacer As Boolean = False

        If (cb_egreso.Text = cb_ingreso.Text) Or (cb_egreso.Text = cb_fecha.Text) Or (cb_fecha.Text = cb_ingreso.Text) Or (cb_numerodep.Text = cb_ingreso.Text) Or (cb_numerodep.Text = cb_egreso.Text) Or (cb_numerodep.Text = cb_fecha.Text) Or (tb_descripcion.Text = cb_ingreso.Text) Or (tb_descripcion.Text = cb_egreso.Text) Or (tb_descripcion.Text = cb_fecha.Text) Or (tb_descripcion.Text = cb_numerodep.Text) Or (tb_oficina.Text = cb_banco.Text) Or (tb_oficina.Text = cb_fecha.Text) Or (tb_oficina.Text = cb_numerodep.Text) Or (tb_oficina.Text = tb_descripcion.Text) Or (tb_oficina.Text = cb_egreso.Text) Or (tb_oficina.Text = cb_ingreso.Text) Then
            hacer = True
        End If

        If hacer = False Then


            For cont As Integer = 0 To DGV_Movimientos.ColumnCount - 1
                If (cb_egreso.Text.Trim = DGV_Movimientos.Columns(cont).HeaderText.Trim) Then
                    ce = cont
                    DGV_Movimientos.Columns(cont).HeaderText = "Egresos"
                ElseIf (cb_fecha.Text.Trim = DGV_Movimientos.Columns(cont).HeaderText.Trim) Then
                    cf = cont
                    DGV_Movimientos.Columns(cont).HeaderText = "Fecha"
                ElseIf (cb_ingreso.Text.Trim = DGV_Movimientos.Columns(cont).HeaderText.Trim) Then
                    ci = cont
                    DGV_Movimientos.Columns(cont).HeaderText = "Ingresos"
                ElseIf (cb_numerodep.Text.Trim = DGV_Movimientos.Columns(cont).HeaderText.Trim) Then
                    cn = cont
                    DGV_Movimientos.Columns(cont).HeaderText = "Número Deposito"
                ElseIf (tb_descripcion.Text.Trim = DGV_Movimientos.Columns(cont).HeaderText.Trim) Then
                    cd = cont
                    DGV_Movimientos.Columns(cont).HeaderText = "Descripción"
                ElseIf (tb_oficina.Text.Trim = DGV_Movimientos.Columns(cont).HeaderText.Trim) Then
                    co = cont
                    DGV_Movimientos.Columns(cont).HeaderText = "Oficina"
                Else
                    DGV_Movimientos.Columns(cont).Visible = False

                End If
            Next


            DGV_Movimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Dim response As MsgBoxResult
            Dim f As Boolean = False


            response = MsgBox("¿Está seguro de querer cargar estos movimientos?", MsgBoxStyle.YesNo, "Confirmar la Cargar")
            If (response = MsgBoxResult.Yes) Then
                verificaFecha(cf, f)
                If f = False Then
                    For cont2 As Integer = 0 To DGV_Movimientos.RowCount - 1
                        Try
                            DatosMovimientos.inserta_movimientos(DGV_Movimientos.Rows(cont2).Cells(cn).Value, CDate(DGV_Movimientos.Rows(cont2).Cells(cf).Value).ToShortDateString, cb_banco.SelectedItem.code, DGV_Movimientos.Rows(cont2).Cells(ce).Value, DGV_Movimientos.Rows(cont2).Cells(ci).Value, f, DGV_Movimientos.Rows(cont2).Cells(cd).Value, DGV_Movimientos.Rows(cont2).Cells(co).Value, 0)
                        Catch ex As Exception

                            f = True
                            cont2 = DGV_Movimientos.RowCount
                        End Try

                    Next
                End If

                If f = False Then
                    MsgBox("Los movimientos bancarios han sido cargados", MsgBoxStyle.Information, "SIMPRO")
                    DGV_Movimientos.Rows.Clear()
                    cb_banco.SelectedIndex = 0
                    cb_egreso.Items.Clear()
                    cb_fecha.Items.Clear()
                    cb_numerodep.Items.Clear()
                    cb_ingreso.Items.Clear()
                    tb_descripcion.Items.Clear()
                    cb_egreso.Items.Add("(Ninguna)")
                    cb_ingreso.Items.Add("(Ninguna)")
                    cb_numerodep.Items.Add("(Ninguna)")
                    cb_fecha.Items.Add("(Ninguna)")
                    tb_descripcion.Items.Add("(Ninguna)")
                    tb_oficina.Items.Add("(Ninguna)")
                    cb_egreso.SelectedIndex = 0
                    cb_ingreso.SelectedIndex = 0
                    cb_numerodep.SelectedIndex = 0
                    cb_fecha.SelectedIndex = 0
                    cb_f1.SelectedIndex = 0
                    cb_f2.SelectedIndex = 1
                    cb_f3.SelectedIndex = 2
                    tb_descripcion.SelectedIndex = 0

                    tb_oficina.SelectedIndex = 0
                    DGV_Movimientos.Columns.Clear()
                    tb_archivo.Text = ""
                    rb_csv.Checked = False
                    rb_excel.Checked = False
                    rb_txt.Checked = False
                Else
                    MsgBox("Hubo un error insertando los movimientos, verifique el formato de la fecha", MsgBoxStyle.Critical, "SIMPRO")
                    f = False
                    For cont As Integer = 0 To DGV_Movimientos.ColumnCount - 1
                        DGV_Movimientos.Columns(cont).Visible = True
                    Next
                    DGV_Movimientos.Columns(ce).HeaderText = ("Columna " & ce + 1)
                    DGV_Movimientos.Columns(cf).HeaderText = ("Columna " & cf + 1)
                    DGV_Movimientos.Columns(ci).HeaderText = ("Columna " & ci + 1)
                    DGV_Movimientos.Columns(cn).HeaderText = ("Columna " & cn + 1)
                    DGV_Movimientos.Columns(cd).HeaderText = ("Columna " & cd + 1)
                    DGV_Movimientos.Columns(co).HeaderText = ("Columna " & co + 1)
                End If

            Else
                For cont As Integer = 0 To DGV_Movimientos.ColumnCount - 1
                    DGV_Movimientos.Columns(cont).Visible = True
                Next
                DGV_Movimientos.Columns(ce).HeaderText = ("Columna " & ce + 1)
                DGV_Movimientos.Columns(cf).HeaderText = ("Columna " & cf + 1)
                DGV_Movimientos.Columns(ci).HeaderText = ("Columna " & ci + 1)
                DGV_Movimientos.Columns(cn).HeaderText = ("Columna " & cn + 1)
                DGV_Movimientos.Columns(cd).HeaderText = ("Columna " & cd + 1)
                DGV_Movimientos.Columns(co).HeaderText = ("Columna " & co + 1)

            End If
            Dim palabra(3) As String
            Dim fec As String = ""
            DGV_Movimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                palabra = DGV_Movimientos.Rows(cont).Cells(fecha).Value.ToString.Split("/")

                For cont2 As Integer = 0 To palabra.Length - 1

                    fec = fec & palabra(cont2).ToString

                Next
                DGV_Movimientos.Rows(cont).Cells(fecha).Value = fec
                fec = ""
            Next
        Else
            MsgBox("Hay una columna asignada más de una vez", MsgBoxStyle.Critical, "SIMPRO")
            hacer = False
        End If
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

    Private Sub tb_caracter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_caracter.KeyDown, rb_carcter2.KeyDown
        If e.KeyData = Keys.Enter Then
            bt_foto.Focus()
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

        If cb_banco.SelectedIndex <> -1 Then

            DGV_Movimientos.Columns.Clear()
            cb_numerodep.Items.Clear()
            cb_egreso.Items.Clear()
            cb_fecha.Items.Clear()
            cb_ingreso.Items.Clear()
            tb_oficina.Items.Clear()
            tb_descripcion.Items.Clear()
            cb_egreso.Items.Add("(Ninguna)")
            cb_ingreso.Items.Add("(Ninguna)")
            cb_numerodep.Items.Add("(Ninguna)")
            cb_fecha.Items.Add("(Ninguna)")
            tb_oficina.Items.Add("(Ninguna)")
            tb_descripcion.Items.Add("(Ninguna)")
            cb_egreso.SelectedIndex = 0
            tb_descripcion.SelectedIndex = 0
            cb_ingreso.SelectedIndex = 0
            cb_numerodep.SelectedIndex = 0
            cb_fecha.SelectedIndex = 0
            tb_oficina.SelectedIndex = 0
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
                        MsgBox("Debe escribir un caracter", MsgBoxStyle.Information, "Error")
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

        Else

            MsgBox("Debe seleccionar un banco", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub verificaFecha(ByVal f As Integer, ByRef b As Boolean)
        Try
            For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                DGV_Movimientos.Rows(cont).Cells(f).Value = DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(0, 8)
            Next
            Dim t As String = ""
            fecha = f
            '----dia/mes/año
            If cb_f1.Text = "dd" And cb_f2.Text = "mm" And cb_f3.Text = "aaaa" Then
                For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                    DGV_Movimientos.Rows(cont).Cells(f).Value = DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(0, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(2, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(4, 4)
                Next
                '----año/mes/dia
            ElseIf cb_f1.Text = "aaaa" And cb_f2.Text = "mm" And cb_f3.Text = "dd" Then
                For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                    DGV_Movimientos.Rows(cont).Cells(f).Value = DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(6) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(4, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(0, 4)
                Next
                '----mes/dia/año
            ElseIf cb_f1.Text = "mm" And cb_f2.Text = "dd" And cb_f3.Text = "aaaa" Then
                For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                    DGV_Movimientos.Rows(cont).Cells(f).Value = DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(2, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(0, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(4, 4)
                Next
                '----dia/año/mes
            ElseIf cb_f1.Text = "dd" And cb_f2.Text = "aaaa" And cb_f3.Text = "mm" Then
                For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                    DGV_Movimientos.Rows(cont).Cells(f).Value = DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(0, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(6) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(2, 4)
                Next
                '----año/dia/mes
            ElseIf cb_f1.Text = "aaaa" And cb_f2.Text = "dd" And cb_f3.Text = "mm" Then
                For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                    DGV_Movimientos.Rows(cont).Cells(f).Value = DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(2, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(6) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(0, 4)
                Next
                '----mes/año/dia
            ElseIf cb_f1.Text = "mm" And cb_f2.Text = "aaaa" And cb_f3.Text = "dd" Then
                For cont As Integer = 0 To DGV_Movimientos.RowCount - 1
                    DGV_Movimientos.Rows(cont).Cells(f).Value = DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(6) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(0, 2) & "/" & DGV_Movimientos.Rows(cont).Cells(f).Value.ToString.Substring(2, 4)
                Next

            End If
            b = False
        Catch ex As Exception
            b = True
        End Try





    End Sub




    Public Sub eliminavacias()

        Dim v As Boolean = False
        Dim v2 As Boolean = False
        Dim cont As Integer = 0

        While cont <= DGV_Movimientos.RowCount - 1

            For cont2 As Integer = 0 To DGV_Movimientos.ColumnCount - 1
                If DGV_Movimientos.Rows(cont).Cells(cont2).Value <> Nothing Then
                    v = True
                    cont2 = DGV_Movimientos.ColumnCount
                End If

            Next
            If v = False Then
                DGV_Movimientos.Rows.RemoveAt(cont)
                cont = cont - 1
            End If
            v = False
            cont = cont + 1
        End While
        cont = 0

        While cont <= DGV_Movimientos.ColumnCount - 1

            For cont2 As Integer = 0 To DGV_Movimientos.RowCount - 1
                If DGV_Movimientos.Rows(cont2).Cells(cont).Value <> Nothing Then
                    v2 = True
                    cont2 = DGV_Movimientos.RowCount
                End If

            Next
            If v2 = False Then
                DGV_Movimientos.Columns.RemoveAt(cont)
                cont = cont - 1
            End If
            v2 = False
            cont = cont + 1
        End While


    End Sub

    Public Sub Agregar_columna()
        DGV_Movimientos.Columns.Add("Columnna " & DGV_Movimientos.Columns.Count.ToString, "Columna " & (DGV_Movimientos.Columns.Count + 1).ToString)
        cb_egreso.Items.Add("Columna " & DGV_Movimientos.Columns.Count.ToString)
        cb_ingreso.Items.Add("Columna " & DGV_Movimientos.Columns.Count.ToString)
        cb_numerodep.Items.Add("Columna " & DGV_Movimientos.Columns.Count.ToString)
        cb_fecha.Items.Add("Columna " & DGV_Movimientos.Columns.Count.ToString)
        tb_descripcion.Items.Add("Columna " & DGV_Movimientos.Columns.Count.ToString)
        tb_oficina.Items.Add("Columna " & DGV_Movimientos.Columns.Count.ToString)
        DGV_Movimientos.ReadOnly = False
        For cont As Integer = 0 To DGV_Movimientos.Columns.Count - 1

            If cont < DGV_Movimientos.Columns.Count - 1 Then
                DGV_Movimientos.Columns(cont).ReadOnly = True
            Else
                DGV_Movimientos.Columns(cont).ReadOnly = False
            End If

        Next

    End Sub


End Class