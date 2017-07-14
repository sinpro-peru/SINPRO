Public Class Frm_AgregarAPedido
    Public codigo As String
    Public tipo As Integer = 0
    Public CodigoPedido As Integer = 0
    Dim nombre As String
    Dim primero As Boolean = False
    Dim proveedores As New Collection
    Dim esta As Boolean = False
    Dim entro As Boolean = False
    Public pedido As String = ""
    Public moneda As String = ""
    Public frm As Frm_Compras
    Public frm2 As Frm_Pedidos_Proveedores


    Private Sub bt_eliminarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarCuarto.Click

        If tb_proveedor.Enabled = True Then

            proveedores.Clear()
            Me.tb_cantidad.Focus()
            Me.tb_nuevo.Text = ""
            Me.TblFabricaBindingSource.RemoveFilter()
            entro = True
            lb_cant.Text = "0"
            pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString

            If Not frm Is Nothing Then
                frm.Enabled = True
            ElseIf Not frm2 Is Nothing Then
                frm2.Enabled = True
            End If

            lb_proveedor.Visible = False
            Me.Visible = False

        Else

            tb_proveedor.Enabled = True
            tb_nuevo.Visible = False
            tb_codfab.Visible = False
            lb_cod.Visible = False
            tb_codfab.Clear()
            tb_cantidad.Clear()
            Me.tb_cantidad.Focus()
            lb_proveedor.Visible = False
            entro = True

        End If

    End Sub

    Private Sub Frm_AgregarAPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Tbl_Fabrica' Puede moverla o quitarla según sea necesario.
        Me.Tbl_FabricaTableAdapter.Fill(Me.MELDataSet.Tbl_Fabrica, 0)

        If tipo = 0 Then
            Me.CancelButton = bt_eliminarCuarto
            ti_fabricas.Text = "Últimos 5 pedidos"
        Else
            Me.CancelButton = Button2
            ti_fabricas.Text = "Pedidos asociados"
        End If

        If primero = False Then
            DatosAgregarAPedido.consulta_proveedores(Me.tb_proveedor, codigo, True)
            Me.tb_cantidad.Select()
            Me.tb_cantidad.Focus()
            If tb_proveedor.Items.Count > 0 Then
                tb_proveedor.SelectedIndex = 0
                DatosAgregarAPedido.consulta_top_pedido(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_pedido, tipo)
            End If
            tb_proveedor.Items.Add("NUEVO")
            If DGV_pedido.Rows.Count > 0 Then
                DGV_pedido.Rows(0).Cells(0).Selected = True
                If DGV_pedido.RowCount > 0 Then
                    lb_cant.Text = "0"
                    DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
                End If
            End If
            DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)

            If tb_proveedor.SelectedIndex <> -1 Then
                DatosAgregarAPedido.consulta_moneda(lbl_moneda, CInt(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code))
            End If

            If tb_proveedor.Text <> "NUEVO" And tb_proveedor.Text.Trim <> "" Then
                Me.tb_cantidad.Select()
                Me.tb_cantidad.Focus()
            Else
                If tb_proveedor.Items.Count = 1 Then
                    tb_proveedor.SelectedIndex = 0
                End If
                tb_nuevo.Select()
                tb_nuevo.Focus()
            End If

            DGV_pedido.Rows(0).Cells(0).Selected = True

            primero = True

        End If

    End Sub

    Private Sub tb_proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.SelectedIndexChanged
        If tb_proveedor.Text.ToUpper <> "NUEVO" Then
            DatosAgregarAPedido.consulta_top_pedido(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_pedido, tipo)
            If DGV_pedido.Rows.Count > 0 Then
                DGV_pedido.Rows(0).Cells(0).Selected = True
                If DGV_pedido.RowCount > 0 Then

                    lbl_moneda.Text = ""
                    DatosAgregarAPedido.consulta_moneda(lbl_moneda, tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code)
                    lb_cant.Text = "0"
                    DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
                End If
            End If
            DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)

        Else

            TblFabricaBindingSource.RemoveFilter()

            tb_proveedor.Enabled = False
            tb_nuevo.Visible = True
            lb_proveedor.Visible = True
            If tipo = 0 Or (tipo = 1 And RadioButton1.Checked) Then
                tb_codfab.Visible = True
                tb_codfab.Focus()
                lb_cod.Visible = True
            End If

            lbl_moneda.Text = ""
            tb_nuevo.Focus()

            End If

    End Sub

    Public Sub producto_pedido(ByVal cod As String, ByVal nom As String, ByVal modelo As String, ByVal dgv As DataGridView, ByVal e As Boolean)

        proveedores.Clear()
        codigo = cod
        Me.lb_producto.Text = nom & " " & modelo
        Me.lb_codigo.Text = cod
        Me.tb_cantidad.Text = ""
        Dim cont As Integer
        For cont = 0 To dgv.Rows.Count - 1

            proveedores.Add(dgv.Rows(cont).Cells(0).Value, cont)

        Next

        entro = e

    End Sub

    Public Sub producto_pedido2(ByVal cod As String, ByVal nom As String, ByVal modelo As String, ByVal e As Boolean)

        proveedores.Clear()
        codigo = cod
        Me.lb_producto.Text = nom & " " & modelo
        Me.lb_codigo.Text = cod
        Me.tb_cantidad.Text = ""
        entro = e

    End Sub

    Private Sub tb_proveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_proveedor.TextChanged
        If tb_proveedor.Text.ToUpper = "NUEVO" Then
            DatosAgregarAPedido.consulta_proveedores(Me.tb_proveedor, codigo, False)
            If lb_proveedor.Items.Count > 0 Then
                tb_proveedor.Enabled = False
                'lb_proveedor.SelectedIndex = 0
                tb_nuevo.Visible = True
                If tipo = 0 Or (tipo = 1 And RadioButton1.Checked) Then
                    tb_codfab.Visible = True
                    tb_codfab.Focus()
                    lb_proveedor.Visible = True
                    lb_cod.Visible = True
                End If
                
                tb_nuevo.Focus()
            End If

        End If

    End Sub

    Private Sub bt_agregarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCuarto.Click

        If My.Settings.Empresa = 0 Or My.Settings.Empresa = 1 Then

            If DatosAgregarAPedido.existe_producto(codigo) Then

                If tb_cantidad.Text <> "" Then

                    If DGV_pedido.SelectedRows(0).Cells(0).Value.ToString <> "Nuevo" Then

                        If tb_proveedor.Text <> "NUEVO" Then
                            If CInt(lb_cant.Text) > 0 Then
                                Dim resp As Integer = MsgBox("Ya existen unidades en el pedido, desea sumar " + tb_cantidad.Text + " unidades a las ya existentes? Total unidades del pedido: " + lb_cant.Text, MsgBoxStyle.YesNo, "SINPRO")

                                If resp = vbYes Then
                                    DatosAgregarAPedido.actualizarPedido(DGV_pedido.SelectedRows(0).Cells(0).Value, codigo, tb_cantidad.Text)
                                    tb_cantidad.Clear()
                                    tb_codfab.Clear()
                                    lb_cant.Text = "0"
                                    proveedores.Clear()
                                    Me.tb_cantidad.Focus()
                                    entro = True
                                    pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                                    frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                    frm.Enabled = True
                                    Me.Visible = False

                                Else

                                    tb_cantidad.Clear()
                                    tb_codfab.Clear()
                                    lb_cant.Text = "0"
                                    proveedores.Clear()
                                    Me.tb_cantidad.Focus()
                                    entro = True
                                    pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                                    frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                    frm.Enabled = True
                                    Me.Visible = False

                                End If

                            Else

                                DatosAgregarAPedido.actualizarPedido(DGV_pedido.SelectedRows(0).Cells(0).Value, codigo, tb_cantidad.Text)
                                tb_cantidad.Clear()
                                tb_codfab.Clear()
                                lb_cant.Text = "0"
                                proveedores.Clear()
                                Me.tb_cantidad.Focus()
                                entro = True
                                pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                                Me.Visible = False

                            End If

                        Else

                            If tb_codfab.Text = "" Then
                                tb_codfab.Text = " "
                            End If

                            If tb_codfab.Text <> "" Then
                                DatosAgregarAPedido.insertar_producto_fabrica(DGV_pedido.SelectedRows(0).Cells(0).Value, codigo, tb_codfab.Text, tb_cantidad.Text, True, tb_nuevo.Tag, True)

                                Dim pro As String
                                pro = lb_proveedor.SelectedItem(1).ToString
                                tb_nuevo.Visible = False
                                lb_cod.Visible = False
                                tb_codfab.Visible = False
                                DatosAgregarAPedido.consulta_proveedores(Me.tb_proveedor, codigo, True)
                                tb_proveedor.Items.Add("NUEVO")
                                tb_proveedor.Text = pro
                                tb_proveedor.Enabled = True
                                tb_cantidad.Clear()
                                tb_codfab.Clear()
                                Me.tb_cantidad.Focus()
                                DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                                proveedores.Clear()
                                entro = True
                                lb_cant.Text = "0"
                                pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                                Me.Visible = False


                            Else
                                MsgBox("Debe introducir un Código de Fábrica", MsgBoxStyle.Critical, "Error!")
                                tb_codfab.Focus()
                            End If

                        End If

                    Else

                        If tb_nuevo.Visible = True Then

                            If tb_codfab.Text <> "" Then
                                DatosAgregarAPedido.insertar_producto_fabrica(0, codigo, tb_codfab.Text, tb_cantidad.Text, False, tb_nuevo.Tag, True)
                                If tb_proveedor.Items.Count <> 0 Then
                                    tb_proveedor.SelectedIndex = 0
                                    DatosAgregarAPedido.consulta_top_pedido(tb_nuevo.Tag, DGV_pedido, tipo)
                                    DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)
                                End If

                                If DGV_pedido.Rows.Count <> 0 Then
                                    DGV_pedido.Rows(0).Cells(0).Selected = True
                                    If DGV_pedido.RowCount > 0 Then
                                        lb_cant.Text = "0"
                                        DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)

                                    End If
                                End If
                                Dim pro As String
                                pro = lb_proveedor.SelectedItem(1).ToString
                                tb_nuevo.Visible = False
                                lb_cod.Visible = False
                                tb_codfab.Visible = False
                                DatosAgregarAPedido.consulta_proveedores(Me.tb_proveedor, codigo, True)
                                tb_proveedor.Items.Add("NUEVO")
                                tb_proveedor.Text = pro
                                'DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                                tb_proveedor.Enabled = True
                                tb_cantidad.Clear()
                                tb_codfab.Clear()

                                proveedores.Clear()
                                entro = True
                                lb_cant.Text = "0"
                                pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                                Me.Visible = False
                            Else
                                MsgBox("Debe introducir un Código de Fábrica", MsgBoxStyle.Critical, "Error!")
                                tb_codfab.Focus()
                            End If
                        Else
                            DatosAgregarAPedido.insertar_producto_fabrica(0, codigo, tb_codfab.Text, tb_cantidad.Text, False, tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, False)
                            tb_cantidad.Clear()
                            DatosAgregarAPedido.consulta_top_pedido(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_pedido, tipo)
                            DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)
                            DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                            tb_cantidad.Clear()
                            proveedores.Clear()
                            lb_cant.Text = "0"
                            DGV_pedido.Rows(0).Cells(0).Selected = True

                            pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                            frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                            frm.Enabled = True
                            Me.Visible = False

                        End If

                    End If
                Else
                    MsgBox("Debe introducir una cantidad", MsgBoxStyle.Critical, "Error!")
                    tb_cantidad.Focus()

                End If

            Else

                MsgBox("Este producto no está registrado en comercializadora, no puede insertarlo en el pedido", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Else

            If tb_cantidad.Text <> "" Then

                If DGV_pedido.SelectedRows(0).Cells(0).Value.ToString <> "Nuevo" Then

                    If tb_proveedor.Text <> "NUEVO" Then
                        If CInt(lb_cant.Text) > 0 Then
                            Dim resp As Integer = MsgBox("Ya existen unidades en el pedido, desea sumar " + tb_cantidad.Text + " unidades a las ya existentes? Total unidades del pedido: " + lb_cant.Text, MsgBoxStyle.YesNo, "SINPRO")

                            If resp = vbYes Then
                                DatosAgregarAPedido.actualizarPedido(DGV_pedido.SelectedRows(0).Cells(0).Value, codigo, tb_cantidad.Text)
                                tb_cantidad.Clear()
                                tb_codfab.Clear()
                                lb_cant.Text = "0"
                                proveedores.Clear()
                                Me.tb_cantidad.Focus()
                                entro = True
                                pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                                Me.Visible = False

                            Else

                                tb_cantidad.Clear()
                                tb_codfab.Clear()
                                lb_cant.Text = "0"
                                proveedores.Clear()
                                Me.tb_cantidad.Focus()
                                entro = True
                                pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                                Me.Visible = False

                            End If

                        Else

                            DatosAgregarAPedido.actualizarPedido(DGV_pedido.SelectedRows(0).Cells(0).Value, codigo, tb_cantidad.Text)
                            tb_cantidad.Clear()
                            tb_codfab.Clear()
                            lb_cant.Text = "0"
                            proveedores.Clear()
                            Me.tb_cantidad.Focus()
                            entro = True
                            pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                            frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                            frm.Enabled = True
                            Me.Visible = False

                        End If

                    Else

                        If tb_codfab.Text = "" Then
                            tb_codfab.Text = " "
                        End If

                        If tb_codfab.Text <> "" Then
                            DatosAgregarAPedido.insertar_producto_fabrica(DGV_pedido.SelectedRows(0).Cells(0).Value, codigo, tb_codfab.Text, tb_cantidad.Text, True, tb_nuevo.Tag, True)

                            Dim pro As String
                            pro = lb_proveedor.SelectedItem(1).ToString
                            tb_nuevo.Visible = False
                            lb_cod.Visible = False
                            tb_codfab.Visible = False
                            DatosAgregarAPedido.consulta_proveedores(Me.tb_proveedor, codigo, True)
                            tb_proveedor.Items.Add("NUEVO")
                            tb_proveedor.Text = pro
                            tb_proveedor.Enabled = True
                            tb_cantidad.Clear()
                            tb_codfab.Clear()
                            Me.tb_cantidad.Focus()
                            DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                            proveedores.Clear()
                            entro = True
                            lb_cant.Text = "0"
                            pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                            frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                            frm.Enabled = True
                            Me.Visible = False


                        Else
                            MsgBox("Debe introducir un Código de Fábrica", MsgBoxStyle.Critical, "Error!")
                            tb_codfab.Focus()
                        End If

                    End If

                Else

                    If tb_nuevo.Visible = True Then

                        If tb_codfab.Text <> "" Then
                            DatosAgregarAPedido.insertar_producto_fabrica(0, codigo, tb_codfab.Text, tb_cantidad.Text, False, tb_nuevo.Tag, True)
                            If tb_proveedor.Items.Count <> 0 Then
                                tb_proveedor.SelectedIndex = 0
                                DatosAgregarAPedido.consulta_top_pedido(tb_nuevo.Tag, DGV_pedido, tipo)
                                DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)
                            End If

                            If DGV_pedido.Rows.Count <> 0 Then
                                DGV_pedido.Rows(0).Cells(0).Selected = True
                                If DGV_pedido.RowCount > 0 Then
                                    lb_cant.Text = "0"
                                    DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)

                                End If
                            End If
                            Dim pro As String
                            pro = lb_proveedor.SelectedItem(1).ToString
                            tb_nuevo.Visible = False
                            lb_cod.Visible = False
                            tb_codfab.Visible = False
                            DatosAgregarAPedido.consulta_proveedores(Me.tb_proveedor, codigo, True)
                            tb_proveedor.Items.Add("NUEVO")
                            tb_proveedor.Text = pro
                            'DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                            tb_proveedor.Enabled = True
                            tb_cantidad.Clear()
                            tb_codfab.Clear()

                            proveedores.Clear()
                            entro = True
                            lb_cant.Text = "0"
                            pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                            frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                            frm.Enabled = True
                            Me.Visible = False
                        Else
                            MsgBox("Debe introducir un Código de Fábrica", MsgBoxStyle.Critical, "Error!")
                            tb_codfab.Focus()
                        End If
                    Else
                        DatosAgregarAPedido.insertar_producto_fabrica(0, codigo, tb_codfab.Text, tb_cantidad.Text, False, tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, False)
                        tb_cantidad.Clear()
                        DatosAgregarAPedido.consulta_top_pedido(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_pedido, tipo)
                        DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)
                        DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                        tb_cantidad.Clear()
                        proveedores.Clear()
                        lb_cant.Text = "0"
                        DGV_pedido.Rows(0).Cells(0).Selected = True

                        pedido = DGV_pedido.SelectedRows(0).Cells(0).Value.ToString
                        frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                        frm.Enabled = True
                        Me.Visible = False

                    End If

                End If
            Else
                MsgBox("Debe introducir una cantidad", MsgBoxStyle.Critical, "Error!")
                tb_cantidad.Focus()
            End If

        End If

    End Sub

    Private Sub Frm_AgregarAPedido_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        If My.Settings.Empresa = 1 Then
            Me.Text = "C. Brwme: " & Me.Text
        ElseIf My.Settings.Empresa = 2 Then
            Me.Text = "AGSA: " & Me.Text
        ElseIf My.Settings.Empresa = 3 Then
            Me.Text = "Mil26: " & Me.Text
        ElseIf My.Settings.Empresa = 4 Then
            Me.Text = "D. Brwme: " & Me.Text
        End If

        If tipo = 0 Then
            Me.CancelButton = bt_eliminarCuarto
            ti_fabricas.Text = "Últimos 5 pedidos"
        Else
            Me.CancelButton = Button2
            ti_fabricas.Text = "Pedidos asociados"
        End If

        If Me.Visible Then

            If entro = False Then

                'Dim cont As Integer
                Dim p As String
                p = tb_proveedor.Text

                'For cont = 1 To proveedores.Count
                '    If tb_proveedor.Text = proveedores.Item(cont).ToString() Then
                '        esta = True
                '    End If
                'Next

                If esta = False Then
                    DatosAgregarAPedido.consulta_proveedores(Me.tb_proveedor, codigo, True)
                    tb_proveedor.Items.Add("NUEVO")
                    If tb_proveedor.Items.Count > 0 Then
                        tb_proveedor.SelectedIndex = 0
                        'tb_nuevo.Text = p
                    End If
                    If DGV_pedido.Rows.Count > 0 Then
                        'DGV_pedido.Rows(0).Cells(0).Selected = True
                        If DGV_pedido.RowCount > 0 Then
                            lb_cant.Text = "0"
                            If DGV_pedido.SelectedRows(0).Cells(0).Value.ToString <> "Nuevo" Then
                                DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
                            End If
                        End If
                    End If
                    DatosAgregarAPedido.consulta_moneda(lbl_moneda, CInt(tb_nuevo.Tag))
                    'tb_cantidad.Focus()
                    tb_codfab.Focus()
                End If

                If DGV_pedido.RowCount > 0 Then
                    lb_cant.Text = "0"
                    If DGV_pedido.SelectedRows(0).Cells(0).Value.ToString <> "Nuevo" Then
                        DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
                    End If
                End If

                DGV_pedido.Rows(0).Selected = True

                For cont2 As Integer = 0 To DGV_pedido.RowCount - 1
                    If DGV_pedido.Rows(cont2).Cells(0).Value.ToString = pedido Then
                        DGV_pedido.Rows(cont2).Selected = True
                    End If
                Next

                esta = False
                entro = True

                If tb_proveedor.Text <> "NUEVO" Then
                    Me.tb_cantidad.Select()
                    Me.tb_cantidad.Focus()
                Else
                    If tb_proveedor.Items.Count = 1 Then
                        tb_proveedor.SelectedIndex = 0
                    End If
                    tb_nuevo.Select()
                    tb_nuevo.Focus()
                End If

            End If

        End If

    End Sub

    Private Sub DGV_pedido_CellContentClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DGV_pedido.CellClick, DGV_pedido.KeyUp, DGV_pedido.KeyDown
        If DGV_pedido.RowCount > 0 Then
            If DGV_pedido.SelectedRows(0).Cells(0).Value.ToString <> "Nuevo" Then
                lb_cant.Text = "0"
                DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
            End If
        End If
    End Sub

    Private Sub tb_cantidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cantidad.KeyDown
        If e.KeyData = Keys.Enter Then
            bt_agregarCuarto_Click(sender, e)
        End If
    End Sub

    Private Sub tb_codfab_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_codfab.KeyDown
        If e.KeyData = Keys.Enter Then
            tb_cantidad.Focus()
        End If

    End Sub


    '------------------------------------------------------ COMBO PROVEEDOR ----------------------------'

    Private Sub tb_nuevo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tb_nuevo.MouseClick
        If lb_proveedor.Visible = False Then
            lb_proveedor.Visible = True
            Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & tb_nuevo.Text.Substring(0, tb_nuevo.Text.Length - 1) & "%'"
        End If
    End Sub

    Private Sub tb_nuevo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_nuevo.KeyDown

        If e.KeyData = Keys.Down Then

            If lb_proveedor.Visible = False Then
                Me.TblFabricaBindingSource.RemoveFilter()
                lb_proveedor.Visible = True
                lb_proveedor.SelectedValue = tb_nuevo.Text
            Else
                If lb_proveedor.Items.Count > 1 Then
                    lb_proveedor.Focus()
                    lb_proveedor.SelectedIndex = lb_proveedor.SelectedIndex + 1
                Else
                    tb_nuevo.SelectionStart = 0
                    tb_nuevo.SelectionLength = tb_nuevo.Text.Length
                    tb_nuevo.Focus()
                End If
            End If

        ElseIf e.KeyData = Keys.Up Then

            If lb_proveedor.Visible = True Then
                If lb_proveedor.Items.Count > 1 Then
                    lb_proveedor.Focus()
                    lb_proveedor.SelectedIndex = lb_proveedor.SelectedIndex - 1
                End If
            End If

        ElseIf e.KeyData = Keys.Enter And lb_proveedor.Visible Then

            lb_proveedor.Visible = False
            If lb_proveedor.Items.Count > 0 Then

                tb_nuevo.Text = lb_proveedor.SelectedItem(1).ToString
                tb_nuevo.Tag = lb_proveedor.SelectedItem(0).ToString

                If lb_proveedor.SelectedIndex <> -1 Then

                    DatosAgregarAPedido.consulta_top_pedido(tb_nuevo.Tag, DGV_pedido, tipo)
                    lbl_moneda.Text = ""
                    DatosAgregarAPedido.consulta_moneda(lbl_moneda, tb_nuevo.Tag)

                    If DGV_pedido.Rows.Count > 0 Then

                        DGV_pedido.Rows(0).Cells(0).Selected = True

                        If DGV_pedido.RowCount > 0 Then
                            lb_cant.Text = "0"
                            DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
                        End If

                    End If

                    DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)

                End If
                lb_proveedor.SelectedIndex = 0

            Else
                tb_nuevo.Text = ""
            End If

            tb_nuevo.SelectionStart = tb_nuevo.Text.Length

        ElseIf e.KeyData = Keys.Back Then

            If tb_nuevo.Text.Length <= 1 Or tb_nuevo.SelectedText <> "" Then
                Me.TblFabricaBindingSource.RemoveFilter()
            Else
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & tb_nuevo.Text.Substring(0, tb_nuevo.Text.Length - 1) & "%'"
            End If

        End If

    End Sub

    Private Sub tb_nuevo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_nuevo.KeyPress

        If Char.IsLetterOrDigit(e.KeyChar) Then

            If Me.tb_nuevo.SelectedText <> "" Then
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & e.KeyChar & "%'"
            Else
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & tb_nuevo.Text & e.KeyChar & "%'"
            End If

            If lb_proveedor.Items.Count = 0 Then
                e.Handled = True
                Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & tb_nuevo.Text & "%'"
            Else
                e.Handled = False
                lb_proveedor.Visible = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lb_proveedor.Visible = True
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub tb_nuevo_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_nuevo.GotFocus
        If tb_nuevo.Text = "- Selecciona -" Then
            tb_nuevo.Text = ""
            Me.TblFabricaBindingSource.Filter = "Nombre LIKE '%" & tb_nuevo.Text & "%'"
            lb_proveedor.Visible = True
        End If
    End Sub

    Public Sub lb_proveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_proveedor.KeyDown
        If e.KeyData = Keys.Up Then

            If lb_proveedor.SelectedIndex = 1 Then
                tb_nuevo.Focus()
            End If

        ElseIf e.KeyData = Keys.Enter Then

            lb_proveedor.Visible = False

            tb_nuevo.Text = lb_proveedor.SelectedItem(1).ToString
            tb_nuevo.Tag = lb_proveedor.SelectedItem(0).ToString

            If lb_proveedor.SelectedIndex <> -1 Then

                DatosAgregarAPedido.consulta_top_pedido(tb_nuevo.Tag, DGV_pedido, tipo)
                lbl_moneda.Text = ""
                DatosAgregarAPedido.consulta_moneda(lbl_moneda, tb_nuevo.Tag)

                If DGV_pedido.Rows.Count > 0 Then

                    DGV_pedido.Rows(0).Cells(0).Selected = True

                    If DGV_pedido.RowCount > 0 Then
                        lb_cant.Text = "0"
                        DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
                    End If

                End If

                DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)

            End If

            lb_proveedor.SelectedIndex = 0
            tb_nuevo.Focus()
            tb_nuevo.SelectionStart = tb_nuevo.Text.Length

        End If

    End Sub

    Private Sub lb_proveedor_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_proveedor.MouseClick

        lb_proveedor.Visible = False

        tb_nuevo.Text = lb_proveedor.SelectedItem(1).ToString
        tb_nuevo.Tag = lb_proveedor.SelectedItem(0).ToString

        If lb_proveedor.SelectedIndex <> -1 Then

            DatosAgregarAPedido.consulta_top_pedido(tb_nuevo.Tag, DGV_pedido, tipo)
            lbl_moneda.Text = ""
            DatosAgregarAPedido.consulta_moneda(lbl_moneda, tb_nuevo.Tag)

            If DGV_pedido.Rows.Count > 0 Then

                DGV_pedido.Rows(0).Cells(0).Selected = True

                If DGV_pedido.RowCount > 0 Then
                    lb_cant.Text = "0"
                    DatosAgregarAPedido.cantidadProducto(lb_cant, CInt(DGV_pedido.SelectedRows(0).Cells(0).Value), lb_codigo.Text)
                End If

            End If

            DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)

        End If

        lb_proveedor.SelectedIndex = 0
        tb_nuevo.Focus()
        tb_nuevo.SelectionStart = tb_nuevo.Text.Length

    End Sub

    '--------------fin combo

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_status.CheckedChanged
        If rb_status.Checked Then
            cb_filtroStatus.Enabled = True
            cb_filtroStatus.DroppedDown = True
        Else
            cb_filtroStatus.Enabled = False
            cb_filtroStatus.DroppedDown = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not frm Is Nothing Then
            frm.Enabled = True
        ElseIf Not frm2 Is Nothing Then
            frm2.Enabled = True
        End If

        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            If CodigoPedido.ToString.ToUpper <> DGV_pedido.SelectedRows(0).Cells(0).Value.ToString.ToUpper Then

                If (rb_status.Checked And cb_filtroStatus.Text <> "") Or rb_todos.Checked Or RadioButton1.Checked Then

                    If DGV_pedido.SelectedRows(0).Cells(0).Value.ToString <> "Nuevo" Then

                        '---------------------------------------------- Mover a un pedido existente -----------------------------------------'

                        If tb_proveedor.Text.ToUpper <> "NUEVO" Then

                            '------------------------------------------- Mover a un proveedor asociado ---------------------------------------'

                            If rb_todos.Checked Then

                                '------------------------- Mover Todo de un pedido a otro (Proveedor asociado) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 3, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 5, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 7, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 9, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 11, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")


                            ElseIf rb_status.Checked Then

                                '------------------------- Mover Status de un pedido a otro (Proveedor asociado) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 4, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 6, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 8, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 10, _
                                                                                tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, "")

                            Else

                                '------------------------- Mover producto de un pedido a otro (Proveedor asociado) -------------------------------'

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                        cb_filtroStatus.Text, 12, _
                                                        tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, lb_codigo.Text)

                            End If

                            tb_cantidad.Clear()
                            DatosAgregarAPedido.consulta_top_pedido(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_pedido, tipo)
                            DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)
                            DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                            tb_cantidad.Clear()
                            proveedores.Clear()
                            lb_cant.Text = "0"
                            DGV_pedido.Rows(0).Cells(0).Selected = True

                            If Not frm Is Nothing Then
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                            ElseIf Not frm2 Is Nothing Then

                                frm2.Enabled = True
                                Dim ped As Integer = DGV_pedido.SelectedRows(0).Cells(0).Value
                                DatosPedidosCompras.lv_PedidoCompra(frm2.DGV_Pedidos, "", 0, "", frm2.lbl_dolares.Text, frm2.lbl_euros.Text)

                                For i As Integer = 0 To frm2.DGV_Pedidos.RowCount - 1

                                    If frm2.DGV_Pedidos.Rows(i).Cells(0).Value.ToString = ped.ToString Then

                                        frm2.DGV_Pedidos.Rows(i).Selected = True
                                        frm2.DGV_Pedidos_CellClick(frm2.DGV_Pedidos, New EventArgs)

                                    End If

                                Next

                            End If

                            Me.Visible = False


                        Else

                            '------------------------------------------- Mover a un proveedor NUEVO ---------------------------------------'

                            If tb_codfab.Text = "" Then
                                tb_codfab.Text = " "
                            End If


                            If rb_todos.Checked Then

                                '------------------------- Mover Todo de un pedido a otro (Proveedor NUEVO) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 5, CInt(tb_nuevo.Tag), "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 7, CInt(tb_nuevo.Tag), "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 9, CInt(tb_nuevo.Tag), "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                    cb_filtroStatus.Text, 11, CInt(tb_nuevo.Tag), "")

                            ElseIf rb_status.Checked Then

                                '------------------------- Mover Status de un pedido a otro (Proveedor NUEVO) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 6, CInt(tb_nuevo.Tag), "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 8, CInt(tb_nuevo.Tag), "")

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                                                cb_filtroStatus.Text, 10, CInt(tb_nuevo.Tag), "")

                            Else

                                '------------------------- Mover Producto de un pedido a otro (Proveedor NUEVO) -------------------------------'

                                DatosAgregarAPedido.InsertaProductoFabrica(tb_nuevo.Tag, lb_codigo.Text, tb_codfab.Text)

                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(DGV_pedido.SelectedRows(0).Cells(0).Value, CodigoPedido, _
                                                    cb_filtroStatus.Text, 12, CInt(tb_nuevo.Tag), lb_codigo.Text)


                            End If

                            If Not frm Is Nothing Then
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                            ElseIf Not frm2 Is Nothing Then

                                frm2.Enabled = True
                                Dim ped As Integer = DGV_pedido.SelectedRows(0).Cells(0).Value
                                DatosPedidosCompras.lv_PedidoCompra(frm2.DGV_Pedidos, "", 0, "", frm2.lbl_dolares.Text, frm2.lbl_euros.Text)

                                For i As Integer = 0 To frm2.DGV_Pedidos.RowCount - 1

                                    If frm2.DGV_Pedidos.Rows(i).Cells(0).Value.ToString = ped.ToString Then

                                        frm2.DGV_Pedidos.Rows(i).Selected = True
                                        frm2.DGV_Pedidos_CellClick(frm2.DGV_Pedidos, New EventArgs)

                                    End If

                                Next

                            End If

                            Me.Visible = False


                        End If

                    Else

                        '---------------------------------------------- Mover a un pedido NUEVO -----------------------------------------'

                        If tb_nuevo.Visible = True Then

                            '------------------------------------------- Mover a un proveedor NUEVO ---------------------------------------'

                            Dim NuevoPedido As String = ""
                            'Insertar el pedido nuevo
                            DatosPedidosCompras.inserta_pedidoCompra(CInt(tb_nuevo.Tag), 0, 0, 0, 0, Today, "$", 0, "", Today, "Pedido creado por movimiento de productos")
                            'Buscar el último codigo de pedido
                            DatosPedidosCompras.consulta_UltimopedidoCompra(NuevoPedido)
                            'Mover BackOrder
                            If rb_todos.Checked Then
                                '------------------------- Mover Todo de un pedido a otro (Proveedor NUEVO) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 2, 0, "")
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 5, 0, "")
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 11, 0, "")
                            ElseIf rb_status.Checked Then
                                '------------------------- Mover Status de un pedido a otro (Proveedor NUEVO) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 1, 0, "")
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 6, 0, "")
                            Else
                                '------------------------- Mover Producto de un pedido a otro (Proveedor NUEVO) -------------------------------'
                                DatosAgregarAPedido.InsertaProductoFabrica(tb_nuevo.Tag, lb_codigo.Text, tb_codfab.Text)
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 12, 0, lb_codigo.Text)
                            End If

                            tb_cantidad.Clear()
                            If tb_proveedor.Text.ToUpper = "NUEVO" Then
                                tb_proveedor.SelectedIndex = 0
                            End If
                            DatosAgregarAPedido.consulta_top_pedido(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_pedido, tipo)
                            DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)
                            DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                            tb_cantidad.Clear()
                            proveedores.Clear()
                            lb_cant.Text = "0"
                            DGV_pedido.Rows(0).Cells(0).Selected = True

                            If Not frm Is Nothing Then
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                            ElseIf Not frm2 Is Nothing Then
                                frm2.Enabled = True
                                Dim ped As Integer = DGV_pedido.SelectedRows(0).Cells(0).Value
                                DatosPedidosCompras.lv_PedidoCompra(frm2.DGV_Pedidos, "", 0, "", frm2.lbl_dolares.Text, frm2.lbl_euros.Text)

                                For i As Integer = 0 To frm2.DGV_Pedidos.RowCount - 1

                                    If frm2.DGV_Pedidos.Rows(i).Cells(0).Value.ToString = ped.ToString Then

                                        frm2.DGV_Pedidos.Rows(i).Selected = True
                                        frm2.DGV_Pedidos_CellClick(frm2.DGV_Pedidos, New EventArgs)

                                    End If

                                Next
                            End If

                            Me.Visible = False

                        Else

                            Dim NuevoPedido As String = ""
                            'Insertar el pedido nuevo
                            DatosPedidosCompras.inserta_pedidoCompra(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, 0, 0, 0, 0, Today, "$", 0, "", Today, "Pedido creado por movimiento de productos")
                            'Buscar el último codigo de pedido
                            DatosPedidosCompras.consulta_UltimopedidoCompra(NuevoPedido)

                            If rb_todos.Checked Then
                                '------------------------- Mover Todo de un pedido a otro (Pedido NUEVO) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 2, 0, "")
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 5, 0, "")
                            ElseIf rb_status.Checked Then
                                '------------------------- Mover Status de un pedido a otro (Pedido NUEVO) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 1, 0, "")
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 6, 0, "")
                            Else
                                '------------------------- Mover Producto de un pedido a otro (Pedido NUEVO) -------------------------------'
                                DatosPedidosCompras.Mueve_ProductosPedidoCompra(CInt(NuevoPedido), CodigoPedido, cb_filtroStatus.Text, 12, 0, lb_codigo.Text)
                            End If

                            tb_cantidad.Clear()
                            DatosAgregarAPedido.consulta_top_pedido(tb_proveedor.Items.Item(Me.tb_proveedor.SelectedIndex).Code, DGV_pedido, tipo)
                            DGV_pedido.Rows.Add("Nuevo", Today.Date, Today.Date)
                            DGV_pedido.Rows(DGV_pedido.Rows.Count - 1).Selected = True
                            tb_cantidad.Clear()
                            proveedores.Clear()
                            lb_cant.Text = "0"
                            DGV_pedido.Rows(0).Cells(0).Selected = True

                            If Not frm Is Nothing Then
                                frm.DGV_Productos_CellContentClick(frm.DGV_Productos, New EventArgs)
                                frm.Enabled = True
                            ElseIf Not frm2 Is Nothing Then
                                frm2.Enabled = True
                                Dim ped As Integer = DGV_pedido.SelectedRows(0).Cells(0).Value
                                DatosPedidosCompras.lv_PedidoCompra(frm2.DGV_Pedidos, "", 0, "", frm2.lbl_dolares.Text, frm2.lbl_euros.Text)

                                For i As Integer = 0 To frm2.DGV_Pedidos.RowCount - 1

                                    If frm2.DGV_Pedidos.Rows(i).Cells(0).Value.ToString = ped.ToString Then

                                        frm2.DGV_Pedidos.Rows(i).Selected = True
                                        frm2.DGV_Pedidos_CellClick(frm2.DGV_Pedidos, New EventArgs)

                                    End If

                                Next

                            End If

                            Me.Visible = False

                        End If

                    End If

                Else

                    MsgBox("Debe seleccionar una opción de traspaso y sus respectivos parámetros", MsgBoxStyle.Critical, "SINPRO")

                End If

            Else

                MsgBox("No puede mover al mismo pedido", MsgBoxStyle.Exclamation, "SINPRO")

            End If

        Catch ex As Exception

            MsgBox("Error moviendo pedido", MsgBoxStyle.Critical, "SINPRO")

            If Not frm Is Nothing Then
                frm.Enabled = True
            ElseIf Not frm2 Is Nothing Then
                frm2.Enabled = True
            End If

            Me.Visible = False

        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If tb_nuevo.Visible And RadioButton1.Checked Then
            tb_codfab.Visible = True
            tb_codfab.Clear()
            lb_cod.Visible = True
        ElseIf RadioButton1.Checked = False Then
            tb_codfab.Visible = False
            tb_codfab.Clear()
            lb_cod.Visible = False
        End If
    End Sub

End Class