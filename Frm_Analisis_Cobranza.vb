Public Class Frm_Analisis_Cobranza

    Dim texto As String = ""
    Dim enter1 As Boolean = False
    Dim down As Boolean = False
    Dim up As Boolean = False
    Dim selected As Boolean = False
    Dim entre As Boolean = False
    Dim cargo As Boolean = False

    Public Sub Frm_Analisis_Cobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: This line of code loads data into the 'MELDataSet.Tbl_Vendedor' table. You can move, or remove it, as needed.
        Me.Tbl_VendedorTableAdapter.Fill(Me.MELDataSet.Tbl_Vendedor, 0)
        'TODO: This line of code loads data into the 'MELDataSet.sp_analisisCobranzas' table. You can move, or remove it, as needed.
        Me.Sp_analisisCobranzasTableAdapter.Fill(Me.MELDataSet.sp_analisisCobranzas)
        'TODO: This line of code loads data into the 'MELDataSet.Tbl_Cliente' table. You can move, or remove it, as needed.
        Me.Tbl_ClienteTableAdapter.Fill(Me.MELDataSet.Tbl_Cliente, 0)

        Me.txt_final.Text = "               --- Escriba Cliente ---"
        Me.txt_finalVend.Text = "               --- Escriba Vendedor ---"
        Me.Tbl_ClienteTableAdapter.Fill(Me.MELDataSet.Tbl_Cliente, 0)
        Me.ListBox1.Visible = False

        'ch_vendedor.Checked = True
        dtp_de.Enabled = True
        dtp_hasta.Enabled = True
        'DatosAnalisisCobranza.ConsultaFacturasVendedor(0, DGV_Facturas, lb_totalP)
        CrearWhere()
        cargo = True
        dtp_de.Enabled = False
        dtp_de.Value = DateAdd(DateInterval.Month, -3, Today.Date)
        dtp_hasta.Enabled = False
        dtp_hasta.Value = Today.Date


    End Sub


    'Private Sub tb_vendedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    tb_vendedor.DroppedDown = True
    'End Sub


    'Private Sub tb_vendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim cod As String = ""
    '    entre = False

    '    If ch_vendedor.Checked = True And ch_cliente.Checked = False Then

    '        If tb_vendedor.SelectedIndex <> -1 Then

    '            If tb_vendedor.Text <> "" Then
    '                If tb_vendedor.Text = "Todos" Then

    '                    DatosAnalisisCobranza.ConsultaFacturasVendedor(0, DGV_Facturas, lb_totalP)
    '                    DatosAnalisisCobranza.consulta_clienteCombo(cb_cliente, True)
    '                    Format(lb_totalP.Text, "#,##0.00")

    '                Else

    '                    Try
    '                        cod = tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Code.ToString.Substring(0, 2)
    '                        DatosAnalisisCobranza.ConsultaFacturasVendedor(CInt(cod), DGV_Facturas, lb_totalP)
    '                        Format(lb_totalP.Text, "#,##0.00")
    '                    Catch ex As Exception

    '                    End Try

    '                End If

    '            End If

    '        End If

    '        DatosAnalisisCobranza.consulta_VendedorLike(tb_vendedor, tb_vendedor.Text, texto)


    '    ElseIf ch_vendedor.Checked = True And ch_cliente.Checked = True Then

    '        If tb_vendedor.SelectedIndex <> -1 Then

    '            If tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Name.ToString <> "" And tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Name.ToString <> "Todos" Then

    '                If entre = False Then
    '                    cod = tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Code.ToString.Substring(0, 2)
    '                    cb_cliente.ResetText()
    '                    DatosAnalisisCobranza.consulta_clienteVendedor(cb_cliente, False, CInt(cod))
    '                    entre = True
    '                End If


    '                cod = tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Code.ToString.Substring(0, 2)
    '                DatosAnalisisCobranza.ConsultaFacturasVendedor(CInt(cod), DGV_Facturas, lb_totalP)
    '                Format(lb_totalP.Text, "#,##0.00")

    '            Else

    '                DatosAnalisisCobranza.ConsultaFacturasVendedor(0, DGV_Facturas, lb_totalP)
    '                Format(lb_totalP.Text, "#,##0.00")


    '            End If

    '        End If

    '        DatosAnalisisCobranza.consulta_VendedorLike(tb_vendedor, tb_vendedor.Text, texto)

    '    End If


    '    If ch_fecha.Checked = True Then

    '        Dim cont As Integer = 0
    '        Dim cont2 As Integer = 0
    '        Dim fechaDe As Date
    '        Dim fechaHasta As Date
    '        Dim fechaAct As Date
    '        lb_totalP.Text = "0,00"
    '        For cont2 = 0 To DGV_Facturas.Rows.Count - 1
    '            DGV_Facturas.Rows(cont2).Visible = True
    '            lb_totalP.Text = Format((CDbl(lb_totalP.Text) + CDbl(DGV_Facturas.Rows(cont2).Cells(8).Value)), "#,##0.00")
    '        Next
    '        lb_totalP.Text = "0,00"
    '        If ch_fecha.Checked = True Then
    '            fechaDe = CDate(dtp_de.Value)
    '            fechaHasta = CDate(dtp_hasta.Value)

    '            For cont = 0 To DGV_Facturas.Rows.Count - 1
    '                fechaAct = CDate(DGV_Facturas.Rows(cont).Cells(0).Value.ToString.Substring(0, 10))

    '                If (fechaDe > fechaAct) Or (fechaHasta < fechaAct) Then

    '                    DGV_Facturas.Rows(cont).Visible = False
    '                Else

    '                    lb_totalP.Text = Format((CDbl(lb_totalP.Text) + CDbl(DGV_Facturas.Rows(cont).Cells(8).Value)), "#,##0.00")
    '                    If CDbl(lb_totalP.Text) <= 0.0 Then

    '                        lb_totalP.Text = "0,00"

    '                    End If

    '                End If

    '            Next
    '        End If

    '        DatosAnalisisCobranza.consulta_VendedorLike(tb_vendedor, tb_vendedor.Text, texto)

    '    End If
    '    'If Me.tb_vendedor.Text.Length = 0 Then
    '    '    Me.tb_vendedor.SelectedIndex = 0
    '    '    Me.tb_vendedor.SelectionStart = Me.tb_vendedor.Text.Length
    '    'End If
    '    Me.tb_vendedor.SelectionStart = Me.tb_vendedor.Text.Length

    'End Sub

    'Private Sub cb_cliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.cb_cliente.DroppedDown = True
    'End Sub


    'Private Sub cb_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim cod As String = ""
    '    If ch_vendedor.Checked = False And ch_cliente.Checked = True Then

    '        If cb_cliente.Text = "" And cb_cliente.Text = "Todos" Then

    '            DatosAnalisisCobranza.consulta_cliente(0, DGV_Facturas, lb_totalP)

    '        Else
    '            'Errorrrrrrrrrrrrr
    '            cod = cb_cliente.Items.Item(Me.cb_cliente.SelectedIndex).Code.ToString
    '            DatosAnalisisCobranza.consulta_cliente(CInt(cod), DGV_Facturas, lb_totalP)
    '            Format(lb_totalP.Text, "#,##0.00")

    '        End If

    '    ElseIf ch_vendedor.Checked = True And ch_cliente.Checked = True Then
    '        If tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Name.ToString <> "" And tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Name.ToString <> "Todos" Then

    '            If entre = False Then
    '                cod = tb_vendedor.Items.Item(Me.tb_vendedor.SelectedIndex).Code.ToString.Substring(0, 2)
    '                DatosAnalisisCobranza.consulta_clienteVendedor(cb_cliente, False, cod)
    '                entre = True
    '            End If


    '        End If

    '        If cb_cliente.Text = "" Or cb_cliente.Text = "Todos" Then

    '            DatosAnalisisCobranza.consulta_cliente(0, DGV_Facturas, lb_totalP)
    '            Format(lb_totalP.Text, "#,##0.00")

    '        Else

    '            cod = cb_cliente.Items.Item(Me.cb_cliente.SelectedIndex).Code.ToString
    '            DatosAnalisisCobranza.consulta_cliente(CInt(cod), DGV_Facturas, lb_totalP)
    '            Format(lb_totalP.Text, "#,##0.00")

    '        End If



    '    End If



    '    If ch_fecha.Checked = True Then

    '        Dim cont As Integer = 0
    '        Dim cont2 As Integer = 0
    '        Dim fechaDe As Date
    '        Dim fechaHasta As Date
    '        Dim fechaAct As Date
    '        lb_totalP.Text = "0,00"
    '        For cont2 = 0 To DGV_Facturas.Rows.Count - 1
    '            DGV_Facturas.Rows(cont2).Visible = True
    '            lb_totalP.Text = Format((CDbl(lb_totalP.Text) + CDbl(DGV_Facturas.Rows(cont2).Cells(8).Value)), "#,##0.00")
    '        Next
    '        lb_totalP.Text = "0,00"
    '        If ch_fecha.Checked = True Then
    '            fechaDe = CDate(dtp_de.Value)
    '            fechaHasta = CDate(dtp_hasta.Value)

    '            For cont = 0 To DGV_Facturas.Rows.Count - 1
    '                fechaAct = CDate(DGV_Facturas.Rows(cont).Cells(0).Value.ToString.Substring(0, 10))

    '                If (fechaDe > fechaAct) Or (fechaHasta < fechaAct) Then

    '                    DGV_Facturas.Rows(cont).Visible = False
    '                Else

    '                    lb_totalP.Text = Format((CDbl(lb_totalP.Text) + CDbl(DGV_Facturas.Rows(cont).Cells(8).Value)), "#,##0.00")
    '                    If CDbl(lb_totalP.Text) <= 0.0 Then

    '                        lb_totalP.Text = "0,00"

    '                    End If

    '                End If

    '            Next
    '        End If



    '    End If

    '    Dim conteo As Integer = 0

    '    For conteo = 0 To DGV_Facturas.Rows.Count - 1
    '        If DGV_Facturas.Rows(conteo).Visible = True Then

    '            If cb_cliente.Text <> "" Then
    '                If cb_cliente.SelectedIndex <> -1 Then

    '                    DGV_Facturas.Rows(conteo).Cells(2).Value = cb_cliente.Items.Item(Me.cb_cliente.SelectedIndex).Code.ToString

    '                    DGV_Facturas.Rows(conteo).Cells(3).Value = cb_cliente.Items.Item(Me.cb_cliente.SelectedIndex).Name.ToString
    '                End If
    '            End If

    '        End If

    '    Next



    'End Sub

    Private Sub ch_vendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_vendedor.CheckedChanged

        '        Dim cod As String = ""


        If ch_vendedor.Checked = False Then
            Me.txt_finalVend.Text = "               --- Escriba Vendedor ---"
            Me.txt_finalVend.Font = New Font(txt_finalVend.Font, FontStyle.Italic)
            Me.txt_finalVend.ForeColor = System.Drawing.Color.Gray
            txt_finalVend.Enabled = False
            ListBox2.Visible = False
            CrearWhere()
            'cb_cliente.ResetText()
            'DatosAnalisisCobranza.consulta_clienteCombo(cb_cliente, True)

        ElseIf ch_vendedor.Checked = True Then
            ch_cliente.Checked = False
            'tb_vendedor.Text = "Todos"
            txt_finalVend.Enabled = True
            txt_finalVend.ResetText()
            Me.txt_finalVend.Font = New Font(txt_finalVend.Font, FontStyle.Regular)
            Me.txt_finalVend.ForeColor = System.Drawing.Color.Black
            txt_finalVend.Focus()
            ListBox2.Visible = True

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_cliente.CheckedChanged

        'Dim cont3 As Integer = 0
        lb_totalP.Text = "0,00"

        If ch_cliente.Checked = False Then
            Me.txt_final.Text = "               --- Escriba Cliente ---"
            Me.txt_final.Font = New Font(txt_finalVend.Font, FontStyle.Italic)
            Me.txt_final.ForeColor = System.Drawing.Color.Gray
            txt_final.Enabled = False
            ListBox1.Visible = False
            CrearWhere()
            'cb_cliente.ResetText()
            'DatosAnalisisCobranza.consulta_clienteCombo(cb_cliente, True)

        ElseIf ch_cliente.Checked = True Then
            ch_vendedor.Checked = False
            'tb_vendedor.Text = "Todos"
            txt_final.Enabled = True
            txt_final.ResetText()
            Me.txt_final.Font = New Font(txt_final.Font, FontStyle.Regular)
            Me.txt_final.ForeColor = System.Drawing.Color.Black
            ListBox1.Visible = True
            txt_final.Focus()

        End If

    End Sub

    Private Sub ch_fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_fecha.CheckedChanged

        dtp_de.Enabled = True
        dtp_hasta.Enabled = True
        CrearWhere()

    End Sub

    Public Sub dtp_de_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_de.ValueChanged

        CrearWhere()

    End Sub

    Public Sub dtp_hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_hasta.ValueChanged

        CrearWhere()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim r As New R_Analisis_Cobranza
        Dim mostrar As Boolean = ch_vendedor.Checked

        r.valores_AnalisisCobranza(Me.DGV_Facturas, Me.lb_totalP, mostrar, txt_finalVend.Text)
        r.Show()

    End Sub

    Private Sub txt_final_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_final.TextChanged
        If Me.ListBox1.Visible = True Then
            Me.TblClienteBindingSource.Filter = "RazonSocial  LIKE '%" & txt_final.Text & "%'"
        End If
    End Sub
    Private Sub txt_final_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_final.KeyDown
        If e.KeyData = Keys.Down Then
            Me.ListBox1.Visible = True
            Me.ListBox1.Focus()

            If Me.ListBox1.Items.Count > 1 Then
                Me.ListBox1.SelectedIndex = 1
            End If

        ElseIf e.KeyData = Keys.Enter And Me.ListBox1.Visible Then

            Me.ListBox1.Visible = False
            If Me.ListBox1.Items.Count > 0 Then
                Me.txt_final.Text = Me.ListBox1.SelectedItem(0).ToString
                Me.Label1.Text = Me.ListBox1.SelectedValue
                CrearWhere()
                Me.ListBox1.SelectedIndex = 0
            Else
                Me.txt_final.Text = ""
            End If

            Me.txt_final.SelectionStart = Me.txt_final.Text.Length

        End If
    End Sub
    Private Sub txt_final_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_final.KeyPress
        Me.ListBox1.Visible = True
    End Sub
    Private Sub txt_final_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_final.GotFocus
        If Me.txt_final.Text = "               --- Escriba Cliente ---" Then
            Me.txt_final.Text = ""
            Me.TblClienteBindingSource.Filter = "RazonSocial  LIKE '%" & Me.txt_final.Text & "%'"
            Me.ListBox1.Visible = True
        End If
    End Sub
    Private Sub ListBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyData = Keys.Up And Me.ListBox1.SelectedIndex = 0 Then
            Me.txt_final.Focus()
        ElseIf e.KeyData = Keys.Enter Then
            Me.ListBox1.Visible = False
            If ListBox1.Items.Count > 0 Then
                Me.txt_final.Text = Me.ListBox1.SelectedItem(0).ToString
                Me.Label1.Text = Me.ListBox1.SelectedValue
            End If
            CrearWhere()
            Me.ListBox1.SelectedIndex = 0
            Me.txt_final.Focus()
            Me.txt_final.SelectionStart = Me.txt_final.Text.Length
        End If
    End Sub
    Private Sub ListBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        Me.ListBox1.Visible = False
        If ListBox1.Items.Count > 0 Then
            Me.txt_final.Text = Me.ListBox1.SelectedItem(0).ToString
            Me.Label1.Text = Me.ListBox1.SelectedValue
        End If
        CrearWhere()
        Me.ListBox1.SelectedIndex = 0
        Me.txt_final.Focus()
        Me.txt_final.SelectionStart = Me.txt_final.Text.Length
    End Sub

    '------------------------------------------------------ COMBO VENDEDOR ------------------------------------------------------'

    Private Sub txt_final_TextChanged2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.TextChanged
        If Me.ListBox2.Visible = True Then
            Me.TblVendedorBindingSource.Filter = "Nombre  LIKE '%" & txt_finalVend.Text & "%'"
            'CrearWhere()
            'Else
            '    Me.TblClienteBindingSource.Filter = "RazonSocial LIKE '%%'"
        End If
    End Sub
    Private Sub txt_final_KeyDown2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_finalVend.KeyDown
        If e.KeyData = Keys.Down Then
            Me.ListBox2.Visible = True
            Me.ListBox2.Focus()

            If Me.ListBox2.Items.Count > 1 Then
                Me.ListBox2.SelectedIndex = 1
            End If

        ElseIf e.KeyData = Keys.Enter And Me.ListBox2.Visible Then

            Me.ListBox2.Visible = False
            If Me.ListBox2.Items.Count > 0 Then
                Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
                Me.Label2.Text = Me.ListBox2.SelectedValue
                CrearWhere()
                Me.ListBox2.SelectedIndex = 0
            Else
                Me.txt_finalVend.Text = ""
            End If

            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length

        End If
    End Sub
    Private Sub txt_final_KeyPress2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_finalVend.KeyPress
        Me.ListBox2.Visible = True
    End Sub
    Private Sub txt_final_Focus2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_finalVend.GotFocus
        If Me.txt_finalVend.Text = "               --- Escriba Vendedor ---" Then
            Me.txt_finalVend.Text = ""
            Me.TblVendedorBindingSource.Filter = "Nombre  LIKE '%" & Me.txt_finalVend.Text & "%'"
            Me.ListBox2.Visible = True
        End If
    End Sub
    Public Sub ListBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyData = Keys.Up And Me.ListBox1.SelectedIndex = 0 Then
            Me.txt_finalVend.Focus()
        ElseIf e.KeyData = Keys.Enter Then
            Me.ListBox2.Visible = False
            Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
            Me.Label2.Text = Me.ListBox2.SelectedValue
            CrearWhere()
            Me.ListBox2.SelectedIndex = 0
            Me.txt_finalVend.Focus()
            Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
        End If
    End Sub
    Private Sub ListBox2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        Me.ListBox2.Visible = False
        Me.txt_finalVend.Text = Me.ListBox2.SelectedItem(1).ToString
        Me.Label2.Text = Me.ListBox2.SelectedValue
        CrearWhere()
        Me.ListBox2.SelectedIndex = 0
        Me.txt_finalVend.Focus()
        Me.txt_finalVend.SelectionStart = Me.txt_finalVend.Text.Length
    End Sub

    Public Sub CrearWhere()

        'Sp_infoGeneralComprasBindingSource.ResetBindings(True)
        Dim where As String = ""
        Dim y As String = ""

        If ch_cliente.Checked And Label1.Text <> "Label1" Then

            where = where + "CodigoCliente = '" & Label1.Text & "'" + y
            y = " and "

        ElseIf ch_vendedor.Checked And Label2.Text <> "Label2" Then

            where = where + "Vendedor = '" & Label2.Text & "'" + y
            y = " and "

        End If

        If ch_fecha.Checked Then

            where = where + y + "Fecha >= '" & dtp_de.Value & "' and Fecha <= '" & dtp_hasta.Value & "'"

        End If

        Me.SpanalisisCobranzasBindingSource.Filter = where

        'For cont As Integer = 0 To DGV_Facturas.Rows.Count - 1

        '    lb_totalP.Text = Format((CDbl(lb_totalP.Text) + CDbl(DGV_Facturas.Rows(cont).Cells(8).Value)), "#,##0.00")

        'Next

        'If CDbl(lb_totalP.Text) <= 0.0 Then

        '    lb_totalP.Text = "0,00"

        'End If

        If Me.MELDataSet.sp_analisisCobranzas.Rows.Count > 0 Then

            Dim Sum As Object
            Sum = Me.MELDataSet.sp_analisisCobranzas.Compute("SUM(montoPendiente)", where)

            If Sum.GetType.ToString = "System.DBNull" Then
                Me.lb_totalP.Text = Format(0, "#,##0.00")
            Else
                Me.lb_totalP.Text = Format(CDbl(Sum), "#,##0.00")
            End If


            Dim Count As Object
            Count = Me.MELDataSet.sp_analisisCobranzas.Compute("COUNT(montoPendiente)", where)
            Me.lbl_totalFact.Text = Count.ToString

        Else
            Me.lb_totalP.Text = Format(0, "#,##0.00")
        End If

        DGV_Facturas.ClearSelection()

    End Sub

    Private Sub DGV_Facturas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Facturas.CellDoubleClick

        If e.ColumnIndex = 1 Then

            Dim F13 As New Frm_Facturas_Ventas
            F13.Show()
            F13.tb_buscarcodigo.Text = DGV_Facturas.SelectedRows(0).Cells(1).Value.ToString
            F13.DGV_TodasLasFacturas.Rows(0).Cells(1).Selected = True
            F13.DGV_TodasLasFacturas.Select()
            F13.DGV_TodasLasFacturas_CellClick()

        ElseIf e.ColumnIndex = 3 Or e.ColumnIndex = 2 Then

            Dim F13 As New Frm_Clientes
            F13.Show()
            F13.DomainUpDown1.SelectedIndex = 0
            F13.tb_buscarcodigo.Text = DGV_Facturas.SelectedRows(0).Cells(2).Value.ToString
            F13.DataGridViewRazon.Rows(0).Cells(0).Selected = True
            F13.DataGridViewRazon.Select()
            F13.DataGridViewRazon_SelectionChanged(F13.DataGridViewRazon, New EventArgs)

        End If
    End Sub

End Class