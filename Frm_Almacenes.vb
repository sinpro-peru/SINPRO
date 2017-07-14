Public Class Frm_Almacenes

    Public OpcionToolBar As Integer = 0
    Dim empezo As Boolean = False
    Dim mover As Boolean = False
    Dim sel As Boolean = False
    Dim enter2 As Boolean = False
    Dim cargo As Boolean = False
    Dim bajar As Boolean = False
    Dim valor As Integer
    Dim aca As Boolean = False
    Dim w As Boolean
    Dim e As Boolean
    Dim seleccionar As Boolean = True
    Public user_l As String = ""

    Private Sub Frm_Almacenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Tbl_Tramo' Puede moverla o quitarla según sea necesario.
        Me.Tbl_TramoTableAdapter.Fill(Me.MELDataSet.Tbl_Tramo)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Tbl_Estante' Puede moverla o quitarla según sea necesario.
        Me.Tbl_EstanteTableAdapter.Fill(Me.MELDataSet.Tbl_Estante)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.Tbl_Cuarto' Puede moverla o quitarla según sea necesario.
        Me.Tbl_CuartoTableAdapter.Fill(Me.MELDataSet.Tbl_Cuarto)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consulta_ubicacion_productos' Puede moverla o quitarla según sea necesario.
        Me.Sp_consulta_ubicacion_productosTableAdapter.Fill(Me.MELDataSet.sp_consulta_ubicacion_productos)
        'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consulta_ubicacion_productos' Puede moverla o quitarla según sea necesario.
        Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)

        DGV_Cuartos.ClearSelection()
        DGV_Estantes.ClearSelection()
        DGV_Tramos.ClearSelection()
        DGV_Almacenes.ClearSelection()
        DGV_Catalogo.ClearSelection()
        tb_NombreCuarto.Enabled = False
        tb_NombreEstante.Enabled = False
        tb_NombreTramo.Enabled = False
        Me.empezo = True
        DomainUpDown2.SelectedIndex = 0
        cargo = True
        TabControlAlmace.SelectedIndex = 0
        Chk_Exist.Checked = True
        If w = False Then
            Me.bt_nuevo.Visible = False
            Me.bt_eliminar.Visible = False
            Me.bt_modificar.Visible = False
            Me.bt_reporte.Visible = False
        End If
        DGV_Catalogo.ClearSelection()
        tb_buscar.Focus()
    End Sub
    Public Sub permisos(ByVal w1 As Boolean, ByVal e1 As Boolean)
        w = w1
        e = e1
    End Sub

    Public Sub CrearWhere()

        Dim where As String = ""
        Dim y As String = ""

        If DGV_Almacenes.SelectedRows.Count > 0 Then
            where = "CodigoAlmacen = '" & DGV_Almacenes.SelectedRows(0).Cells(0).Value & "'"
            y = " AND "
        End If

        If DGV_Cuartos.SelectedRows.Count > 0 Then
            where = where + y + "CodigoCuarto = " & DGV_Cuartos.SelectedRows(0).Cells(1).Value
            y = " AND "
        End If

        If DGV_Estantes.SelectedRows.Count > 0 Then
            where = where + y + "CodigoEstante = " & DGV_Estantes.SelectedRows(0).Cells(1).Value
            y = " AND "
        End If

        If DGV_Tramos.SelectedRows.Count > 0 Then
            where = where + y + "CodigoTramo = " & DGV_Tramos.SelectedRows(0).Cells(1).Value
            y = " AND "
        End If

        If Chk_Exist.Checked Then
            where = where + y + "aqui > 0"
        End If

        If tb_buscar.Text <> "" Then
            If DomainUpDown2.SelectedIndex = 0 Then
                where = where + y + "CodigoProducto LIKE '%" & tb_buscar.Text & "%'"
            ElseIf DomainUpDown2.SelectedIndex = 1 Then
                where = where + y + "codigoF LIKE '%" & tb_buscar.Text & "%'"
            ElseIf DomainUpDown2.SelectedIndex = 2 Then
                where = where + y + "Nombre LIKE '%" & tb_buscar.Text & "%'"
            End If
        End If

        Me.SpconsultaubicacionproductosBindingSource.Filter = where
        DGV_Catalogo.ClearSelection()

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is Me.bt_salir Then

            DGV_UbicacionActual.DataSource = Nothing
            Me.Close()

        ElseIf e.Button Is Me.bt_nuevo Then
            OpcionToolBar = 0
            LimpiarDGVs()
            gb_cuartos.Enabled = False
            gb_estantes.Enabled = False
            gb_tramos.Enabled = False
            Activar_O_Desactivar_DGVs(True)
            Habilitar_o_Desabilitar_DGV_Almacen_y_Toolbar(False)
            Mostrar_O_Ocultar_Labels_Nuevo(True)
            Tb_NombreAlmacen.Enabled = True
            tb_direccionAlmacen.Enabled = True
            Tb_NombreAlmacen.Focus()
        ElseIf e.Button Is Me.bt_modificar Then
            If DGV_Almacenes.SelectedRows.Count > 0 Then
                OpcionToolBar = 1
                ToolBar1.Enabled = False
                DGV_Almacenes.Enabled = False
                Mostrar_O_Ocultar_Labels_Nuevo(True)
                Tb_NombreAlmacen.Enabled = True
                tb_direccionAlmacen.Enabled = True
                Tb_NombreAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(1).Value
                tb_direccionAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(2).Value
                Tb_NombreAlmacen.Focus()
                Tb_NombreAlmacen.SelectAll()
                bt_aceptar.Visible = True
                bt_cancelar.Visible = True
                bt_agregarCuarto.Enabled = True
                bt_agregarEstante.Enabled = True
                bt_AgregarTramo.Enabled = True
                bt_eliminarCuarto.Enabled = True
                bt_EliminarEstante.Enabled = True
                bt_EliminarTramo.Enabled = True
                bt_ModificarCuarto.Enabled = True
                bt_modificarEstante.Enabled = True
                bt_ModificarTramo.Enabled = True
                tb_NombreCuarto.Enabled = True
                tb_NombreEstante.Enabled = True
                tb_NombreTramo.Enabled = True
            Else
                MsgBox("Debe seleccionar un almacen a modificar", MsgBoxStyle.Exclamation, "SINPRO")
            End If
        ElseIf e.Button Is Me.bt_eliminar Then
            If DGV_Almacenes.SelectedRows.Count > 0 Then
                OpcionToolBar = 2
                If DatosAlmacenes.HayProcutos(DGV_Almacenes.SelectedRows(0).Cells(0).Value, 1) Then
                    MsgBox("No se puede eliminar el almacén, hay productos asociados", MsgBoxStyle.Critical)
                Else
                    Dim resp As Integer = MsgBox("Está seguro que desea eliminar el amlacen " & DGV_Almacenes.SelectedRows(0).Cells(1).Value & "?", MsgBoxStyle.YesNo, "Confirmación")
                    If resp = vbYes Then
                        DatosAlmacenes.Eliminar(DGV_Almacenes.SelectedRows(0).Cells(0).Value, 1)
                        Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)
                        DGV_Almacenes.Refresh()
                        LimpiarDGVs()
                    End If
                End If
            Else
                MsgBox("Debe seleccionar un almacen a eliminar", MsgBoxStyle.Exclamation, "SINPRO")
            End If
        ElseIf e.Button Is Me.bt_reporte Then
            OpcionToolBar = 3
            Dim frm As New R_traspaso
            frm.Show()
        End If
    End Sub

    Public Sub Llenar_DGVs_Almacen() Handles DGV_Almacenes.CellClick, DGV_Almacenes.KeyDown, DGV_Almacenes.KeyUp
        Try
            If TabControlAlmace.SelectedIndex = 0 Then
                Me.Tb_NombreAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(1).Value
                Me.tb_direccionAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(2).Value
                DGV_Estantes.Rows.Clear()
                DGV_Tramos.Rows.Clear()
                DatosAlmacenes.Llenar_DGV_por_id(DGV_Almacenes.SelectedRows(0).Cells(0).Value, DGV_Cuartos, 1)
                DGV_Cuartos.ClearSelection()
                DGV_Catalogo.ClearSelection()
                CrearWhere()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Llenar_DGVs_Cuarto() Handles DGV_Cuartos.CellClick, DGV_Cuartos.KeyDown, DGV_Cuartos.KeyUp
        Try
            If DGV_Cuartos.Rows.Count > 0 Then
                DGV_Tramos.Rows.Clear()
                DatosAlmacenes.Llenar_DGV_por_id(DGV_Cuartos.SelectedRows(0).Cells(1).Value, DGV_Estantes, 2)
                DGV_Estantes.ClearSelection()
                'Me.SpconsultaubicacionproductosBindingSource.Filter = "CodigoCuarto = " & DGV_Cuartos.SelectedRows(0).Cells(1).Value
                CrearWhere()
                DGV_Catalogo.ClearSelection()
                If OpcionToolBar = 1 And DGV_Cuartos.SelectedRows(0).Cells(0).Value <> "*" Then
                    tb_NombreCuarto.Text = DGV_Cuartos.SelectedRows(0).Cells(0).Value
                    tb_NombreTramo.Clear()
                    tb_NombreEstante.Clear()
                Else
                    tb_NombreCuarto.Clear()
                End If
            Else
                DGV_Cuartos.Rows.Clear()

            End If
        Catch ex As Exception
            LlenarLabelsTramo()
        End Try
    End Sub

    Public Sub Llenar_DGVs_Estantes() Handles DGV_Estantes.CellClick, DGV_Estantes.KeyDown, DGV_Estantes.KeyUp
        Try
            If DGV_Estantes.Rows.Count > 0 Then
                DatosAlmacenes.Llenar_DGV_por_id(DGV_Estantes.SelectedRows(0).Cells(1).Value, DGV_Tramos, 3)
                DGV_Tramos.ClearSelection()
                'Me.SpconsultaubicacionproductosBindingSource.Filter = "CodigoEstante = " & DGV_Estantes.SelectedRows(0).Cells(1).Value
                CrearWhere()
                DGV_Catalogo.ClearSelection()
                If OpcionToolBar = 1 And DGV_Estantes.SelectedRows(0).Cells(0).Value <> "*" Then
                    tb_NombreEstante.Text = DGV_Estantes.SelectedRows(0).Cells(0).Value
                    tb_NombreTramo.Clear()
                    tb_NombreCuarto.Clear()
                Else
                    tb_NombreEstante.Clear()
                End If
            Else
                DGV_Tramos.Rows.Clear()
            End If
            LlenarLabelsTramo()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LimpiarDGVs()
        DGV_Cuartos.Rows.Clear()
        DGV_Estantes.Rows.Clear()
        DGV_Tramos.Rows.Clear()
    End Sub

    Public Sub Mostrar_O_Ocultar_Labels_Nuevo(ByVal Opcion As Boolean)
        Tb_NombreAlmacen.Clear()
        tb_direccionAlmacen.Clear()
        Lbl_NombreAlmacen.Visible = Opcion
        Tb_NombreAlmacen.Visible = Opcion
        Lbl_DireccionAlmacen.Visible = Opcion
        tb_direccionAlmacen.Visible = Opcion
        bt_aceptar.Visible = Opcion
        bt_cancelar.Visible = Opcion

    End Sub

    Private Sub bt_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar.Click
        Tb_NombreAlmacen.Enabled = False
        tb_direccionAlmacen.Enabled = False
        bt_aceptar.Visible = False
        bt_cancelar.Visible = False
        bt_agregarCuarto.Enabled = False
        bt_agregarEstante.Enabled = False
        bt_AgregarTramo.Enabled = False
        bt_eliminarCuarto.Enabled = False
        bt_EliminarEstante.Enabled = False
        bt_EliminarTramo.Enabled = False
        bt_ModificarCuarto.Enabled = False
        bt_modificarEstante.Enabled = False
        bt_ModificarTramo.Enabled = False
        tb_NombreCuarto.Enabled = False
        tb_NombreEstante.Enabled = False
        tb_NombreTramo.Enabled = False
        ToolBar1.Enabled = True
        DGV_Almacenes.Enabled = True
        OpcionToolBar = 7
    End Sub

    Private Sub bt_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar.Click

        If Tb_NombreAlmacen.Text <> "" Or tb_direccionAlmacen.Text <> "" Then

            If OpcionToolBar = 0 Then

                If Buscar_Elemento_En_DGV(Tb_NombreAlmacen.Text, DGV_Almacenes, 1) Then

                    MsgBox("Ya existe un almacen con ese nombre", MsgBoxStyle.Critical)
                    Tb_NombreAlmacen.Focus()
                    Tb_NombreAlmacen.SelectAll()
                Else

                    DatosAlmacenes.InsertarAlmacen(Tb_NombreAlmacen.Text, tb_direccionAlmacen.Text)
                    Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)
                    Seleccionar_Elemento_En_DGV(Tb_NombreAlmacen.Text, DGV_Almacenes, 1)

                    Dim resp As Integer = MsgBox("Almacén agregado satisfactoriamente. Desea Agregar elementos?", MsgBoxStyle.YesNo)
                    bt_aceptar.Visible = False
                    bt_cancelar.Visible = False
                    Tb_NombreAlmacen.Enabled = False
                    tb_direccionAlmacen.Enabled = False

                    If resp = vbYes Then
                        gb_cuartos.Enabled = True
                        gb_estantes.Enabled = True
                        gb_tramos.Enabled = True
                        OpcionToolBar = 1
                        Tb_NombreAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(1).Value
                        tb_direccionAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(2).Value
                        tb_NombreCuarto.Focus()

                    Else
                        Llenar_DGVs_Almacen()
                    End If

                End If

            ElseIf OpcionToolBar = 1 Then

                DatosAlmacenes.Modificar(Tb_NombreAlmacen.Text, tb_direccionAlmacen.Text, DGV_Almacenes.SelectedRows(0).Cells(0).Value, 1)
                Me.Table_AlmacenTableAdapter.Fill(Me.MELDataSet.Table_Almacen)
                Seleccionar_Elemento_En_DGV(Tb_NombreAlmacen.Text, DGV_Almacenes, 1)
                Tb_NombreAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(0).Value
                tb_direccionAlmacen.Text = DGV_Almacenes.SelectedRows(0).Cells(1).Value
                bt_agregarCuarto.Enabled = False
                bt_agregarEstante.Enabled = False
                bt_AgregarTramo.Enabled = False
                bt_eliminarCuarto.Enabled = False
                bt_EliminarEstante.Enabled = False
                bt_EliminarTramo.Enabled = False
                bt_ModificarCuarto.Enabled = False
                bt_modificarEstante.Enabled = False
                bt_ModificarTramo.Enabled = False
                tb_NombreCuarto.Enabled = False
                tb_NombreEstante.Enabled = False
                tb_NombreTramo.Enabled = False
                ToolBar1.Enabled = True
                DGV_Almacenes.Enabled = True
                OpcionToolBar = 7
            End If
            Habilitar_o_Desabilitar_DGV_Almacen_y_Toolbar(True)
        Else
            MsgBox("Existe un campo obligatorio vacío", MsgBoxStyle.Critical)
        End If

    End Sub

    Public Sub Habilitar_o_Desabilitar_DGV_Almacen_y_Toolbar(ByVal Opcion As Boolean)
        ToolBar1.Enabled = Opcion
        DGV_Almacenes.Enabled = Opcion
        DGV_Tramos.Enabled = Opcion
    End Sub

    Private Sub bt_agregarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarCuarto.Click
        Try
            If tb_NombreCuarto.Text <> "" Then
                If Buscar_Elemento_En_DGV(tb_NombreCuarto.Text, DGV_Cuartos, 0) Then
                    MsgBox("Ya existe un cuarto con ese nombre", MsgBoxStyle.Critical)
                    tb_NombreCuarto.Focus()
                    tb_NombreCuarto.SelectAll()
                Else
                    DatosAlmacenes.Insertar(tb_NombreCuarto.Text, DGV_Almacenes.SelectedRows(0).Cells(0).Value, 1)
                    Llenar_DGVs_Almacen()
                    Seleccionar_Elemento_En_DGV(tb_NombreCuarto.Text, DGV_Cuartos, 0)
                    Llenar_DGVs_Cuarto()
                    DGV_Cuartos.Refresh()
                    tb_NombreCuarto.Clear()
                End If
            Else
                MsgBox("No se puede ingresar un cuarto sin nombre")
            End If
        Catch ex As Exception
            MsgBox("No se puede agregar un cuarto mientras no existan almacenes", MsgBoxStyle.Critical)
            tb_NombreCuarto.Clear()
        End Try
    End Sub

    Public Sub Seleccionar_Elemento_En_DGV(ByVal Nombre As String, ByVal DGV As DataGridView, ByVal Tipo As Integer)

        Try

            Dim Cont As Integer = 0
            Dim valor As Integer = 0

            For Cont = 0 To DGV.Rows.Count - 1

                If DGV.Rows(Cont).Cells(Tipo).Value.ToString = Nombre Then
                    valor = Cont
                End If

            Next

            DGV.Rows(valor).Selected = True

        Catch ex As Exception

            DGV.Select()

        End Try



    End Sub

    Private Sub bt_agregarEstante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregarEstante.Click

        Try

            Dim nombre As String = DGV_Cuartos.SelectedRows(0).Cells(0).Value

            If Not nombre = "*" Then

                If tb_NombreEstante.Text <> "" Then


                    If Buscar_Elemento_En_DGV(tb_NombreEstante.Text, DGV_Estantes, 0) Then

                        MsgBox("Ya existe un estante con ese nombre", MsgBoxStyle.Critical)
                        tb_NombreEstante.Focus()
                        tb_NombreEstante.SelectAll()

                    Else

                        DatosAlmacenes.Insertar(tb_NombreEstante.Text, DGV_Cuartos.SelectedRows(0).Cells(1).Value, 2)
                        Llenar_DGVs_Cuarto()
                        Seleccionar_Elemento_En_DGV(nombre, DGV_Cuartos, 0)
                        Seleccionar_Elemento_En_DGV(tb_NombreEstante.Text, DGV_Estantes, 0)
                        Llenar_DGVs_Estantes()
                        tb_NombreEstante.Clear()

                    End If

                Else

                    MsgBox("No se puede ingresar un estante sin nombre")

                End If

            Else

                MsgBox("No puede agregar estantes en este cuarto", MsgBoxStyle.Critical)
                tb_NombreEstante.Clear()
                tb_NombreEstante.Focus()

            End If


        Catch ex As Exception

            MsgBox("No se puede agregar un estante mientras no existan cuartos", MsgBoxStyle.Critical)
            tb_NombreEstante.Clear()

        End Try



    End Sub

    Private Sub bt_AgregarTramo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_AgregarTramo.Click

        Try

            Dim nombre As String = DGV_Estantes.SelectedRows(0).Cells(0).Value

            If Not nombre = "*" Then

                If tb_NombreTramo.Text <> "" Then




                    If Buscar_Elemento_En_DGV(tb_NombreTramo.Text, DGV_Tramos, 0) Then

                        MsgBox("Ya existe un tramo con ese nombre", MsgBoxStyle.Critical)
                        tb_NombreTramo.Focus()
                        tb_NombreTramo.SelectAll()

                    Else

                        DatosAlmacenes.Insertar(tb_NombreTramo.Text, DGV_Estantes.SelectedRows(0).Cells(1).Value, 3)
                        Llenar_DGVs_Estantes()
                        Seleccionar_Elemento_En_DGV(nombre, DGV_Estantes, 0)
                        Seleccionar_Elemento_En_DGV(tb_NombreTramo.Text, DGV_Tramos, 0)
                        tb_NombreTramo.Clear()

                    End If

                Else

                    MsgBox("No se puede ingresar un tramo sin nombre")

                End If
            Else

                MsgBox("No puede agregar tramos en este estante", MsgBoxStyle.Critical)
                tb_NombreTramo.Clear()
                tb_NombreTramo.Focus()

            End If


        Catch ex As Exception

            MsgBox("No se puede agregar un tramo mientras no existan estantes", MsgBoxStyle.Critical)
            tb_NombreTramo.Clear()

        End Try



    End Sub

    Public Sub Activar_O_Desactivar_GBs(ByVal Opcion As Boolean)

        gb_cuartos.Enabled = Opcion
        gb_estantes.Enabled = Opcion
        gb_tramos.Enabled = Opcion
        Chk_Exist.Checked = True

    End Sub

    Public Sub Activar_O_Desactivar_DGVs(ByVal Opcion As Boolean)

        DGV_Cuartos.Enabled = Opcion
        DGV_Estantes.Enabled = Opcion
        DGV_Tramos.Enabled = Opcion
        Chk_Exist.Checked = True
    End Sub


    Public Function Buscar_Elemento_En_DGV(ByVal Nombre As String, ByVal DGV As DataGridView, ByVal tipo As Integer) As Boolean

        Try

            Dim Cont As Integer = 0
            Dim retorno As Boolean = False

            For Cont = 0 To DGV.Rows.Count - 1

                If DGV.Rows(Cont).Cells(tipo).Value.ToString.ToUpper = Nombre.ToUpper Then
                    retorno = True
                End If

            Next

            Return retorno

        Catch ex As Exception


        End Try

    End Function


    Private Sub bt_ModificarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarCuarto.Click
        Try

            If DGV_Cuartos.SelectedRows(0).Cells(0).Value <> "*" Then

                If tb_NombreCuarto.Text <> "" Then

                    DatosAlmacenes.Modificar(tb_NombreCuarto.Text, "", DGV_Cuartos.SelectedRows(0).Cells(1).Value, 2)
                    tb_NombreCuarto.Clear()
                    Dim index As Integer = DGV_Cuartos.SelectedRows(0).Index
                    DatosAlmacenes.Llenar_DGV_por_id(DGV_Almacenes.SelectedRows(0).Cells(0).Value, DGV_Cuartos, 1)
                    DGV_Cuartos.Rows(index).Selected = True
                Else
                    MsgBox("Debe colocar un nombre", MsgBoxStyle.Critical)
                    tb_NombreCuarto.Focus()

                End If
            Else
                MsgBox("No se puede modificar este cuarto", MsgBoxStyle.Critical)
                tb_NombreCuarto.Clear()
            End If

        Catch ex As Exception

            MsgBox("La lista está vaciá", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub bt_modificarEstante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificarEstante.Click

        Try

            If Not DGV_Estantes.SelectedRows(0).Cells(0).Value = "*" Then


                If tb_NombreEstante.Text <> "" Then

                    DatosAlmacenes.Modificar(tb_NombreEstante.Text, "", DGV_Estantes.SelectedRows(0).Cells(1).Value, 3)
                    Llenar_DGVs_Cuarto()
                    Seleccionar_Elemento_En_DGV(tb_NombreEstante.Text, DGV_Estantes, 0)
                    tb_NombreEstante.Clear()

                Else

                    MsgBox("Debe colocar un nombre", MsgBoxStyle.Critical)
                    tb_NombreEstante.Focus()

                End If

            Else

                MsgBox("No se puede modificar este estante", MsgBoxStyle.Critical)
                tb_NombreEstante.Clear()

            End If


        Catch ex As Exception

            MsgBox("La lista está vaciá", MsgBoxStyle.Critical)

        End Try



    End Sub

    Private Sub bt_ModificarTramo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ModificarTramo.Click

        Try

            If Not DGV_Tramos.SelectedRows(0).Cells(0).Value = "*" Then


                If tb_NombreTramo.Text <> "" Then

                    DatosAlmacenes.Modificar(tb_NombreTramo.Text, "", DGV_Tramos.SelectedRows(0).Cells(1).Value, 4)
                    Llenar_DGVs_Estantes()
                    Seleccionar_Elemento_En_DGV(tb_NombreTramo.Text, DGV_Tramos, 0)
                    tb_NombreTramo.Clear()

                Else

                    MsgBox("Debe colocar un nombre", MsgBoxStyle.Critical)
                    tb_NombreTramo.Focus()

                End If
            Else

                MsgBox("No se puede modificar este tramo", MsgBoxStyle.Critical)
                tb_NombreTramo.Clear()

            End If



        Catch ex As Exception

            MsgBox("La lista está vaciá", MsgBoxStyle.Critical)

        End Try



    End Sub

    Private Sub bt_eliminarCuarto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminarCuarto.Click

        Try

            If Not DGV_Cuartos.SelectedRows(0).Cells(0).Value = "*" Then

                If DatosAlmacenes.HayProcutos(DGV_Cuartos.SelectedRows(0).Cells(1).Value, 2) Then

                    MsgBox("No se puede eliminar el cuarto, hay productos asociados", MsgBoxStyle.Critical)

                Else
                    DatosAlmacenes.Eliminar(DGV_Cuartos.SelectedRows(0).Cells(1).Value, 2)
                    Llenar_DGVs_Almacen()
                End If

            Else

                MsgBox("No se puede eliminar este cuarto", MsgBoxStyle.Critical)

            End If


        Catch ex As Exception

            MsgBox("La lista está vaciá", MsgBoxStyle.Critical)

        End Try



    End Sub

    Private Sub bt_EliminarEstante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_EliminarEstante.Click

        Try

            If Not DGV_Estantes.SelectedRows(0).Cells(0).Value = "*" Then

                If DatosAlmacenes.HayProcutos(DGV_Estantes.SelectedRows(0).Cells(1).Value, 3) Then

                    MsgBox("No se puede eliminar el estante, hay productos asociados", MsgBoxStyle.Critical)

                Else
                    DatosAlmacenes.Eliminar(DGV_Estantes.SelectedRows(0).Cells(1).Value, 3)
                    Llenar_DGVs_Cuarto()
                End If


            Else

                MsgBox("No se puede eliminar este estante", MsgBoxStyle.Critical)

            End If

        Catch ex As Exception

            MsgBox("La lista está vaciá", MsgBoxStyle.Critical)

        End Try



    End Sub


    Private Sub bt_EliminarTramo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_EliminarTramo.Click

        Try

            If Not DGV_Tramos.SelectedRows(0).Cells(0).Value = "*" Then

                If DatosAlmacenes.HayProcutos(DGV_Tramos.SelectedRows(0).Cells(1).Value, 4) Then

                    MsgBox("No se puede eliminar el tramo, hay productos asociados", MsgBoxStyle.Critical)

                Else

                    DatosAlmacenes.Eliminar(DGV_Tramos.SelectedRows(0).Cells(1).Value, 4)
                    Llenar_DGVs_Estantes()

                End If


            Else

                MsgBox("No se puede eliminar este tramo", MsgBoxStyle.Critical)

            End If

        Catch ex As Exception

            MsgBox("La lista está vaciá", MsgBoxStyle.Critical)

        End Try

    End Sub

    Public Sub LlenarLabelsTramo() Handles DGV_Tramos.CellClick, DGV_Tramos.KeyDown, DGV_Tramos.KeyUp
        Try
            Me.SpconsultaubicacionproductosBindingSource.Filter = "CodigoTramos = " & DGV_Tramos.SelectedRows(0).Cells(1).Value
        Catch ex As Exception

        Finally
        End Try

    End Sub

    Public Sub LlenarCatalogoPorTramo() Handles DGV_Tramos.CellClick, DGV_Tramos.KeyDown, DGV_Tramos.KeyUp
        Try
            'SpconsultaubicacionproductosBindingSource.Filter = "CodigoTramo =" & DGV_Tramos.SelectedRows(0).Cells(1).Value
            CrearWhere()
            DGV_Catalogo.ClearSelection()
            If OpcionToolBar = 1 And DGV_Tramos.SelectedRows(0).Cells(0).Value <> "*" Then
                tb_NombreTramo.Text = DGV_Tramos.SelectedRows(0).Cells(0).Value
                tb_NombreEstante.Clear()
                tb_NombreCuarto.Clear()
            Else
                tb_NombreTramo.Clear()
            End If
        Catch ex As Exception
            DGV_Catalogo.Rows.Clear()
        Finally
        End Try
    End Sub

    Public Sub BusquedaDinamica() Handles tb_buscar.TextChanged
        If Me.TabControlAlmace.SelectedIndex = 1 Then
            If DomainUpDown2.SelectedIndex = 0 Then
                SpconsultaubicacionproductosBindingSource.Filter = "CodigoProducto LIKE '%" & tb_buscar.Text & "%' and aqui > 0"
            ElseIf DomainUpDown2.SelectedIndex = 1 Then
                SpconsultaubicacionproductosBindingSource.Filter = "codigoF LIKE '%" & tb_buscar.Text & "%' and aqui > 0"
            ElseIf DomainUpDown2.SelectedIndex = 2 Then
                SpconsultaubicacionproductosBindingSource.Filter = "Nombre LIKE '%" & tb_buscar.Text & "%' and aqui > 0"
            End If
        ElseIf Me.TabControlAlmace.SelectedIndex = 0 Then
            'If DomainUpDown2.SelectedIndex = 0 Then
            CrearWhere()
            'If Chk_Exist.Checked Then
            '    SpconsultaubicacionproductosBindingSource.Filter = "CodigoProducto LIKE '%" & tb_buscar.Text & "%' and CantidadExistencia > 0"
            'Else
            '    SpconsultaubicacionproductosBindingSource.Filter = "CodigoProducto LIKE '%" & tb_buscar.Text & "%'"
            'End If
            'ElseIf DomainUpDown2.SelectedIndex = 1 Then
            '    If Chk_Exist.Checked Then
            '        SpconsultaubicacionproductosBindingSource.Filter = "codigoF LIKE '%" & tb_buscar.Text & "%' and CantidadExistencia > 0"
            '    Else
            '        SpconsultaubicacionproductosBindingSource.Filter = "codigoF LIKE '%" & tb_buscar.Text & "%'"
            '    End If
            'ElseIf DomainUpDown2.SelectedIndex = 2 Then
            '    If Chk_Exist.Checked Then
            '        SpconsultaubicacionproductosBindingSource.Filter = "Nombre LIKE '%" & tb_buscar.Text & "%' and CantidadExistencia > 0"
            '    Else
            '        SpconsultaubicacionproductosBindingSource.Filter = "Nombre LIKE '%" & tb_buscar.Text & "%'"
            '    End If
            'End If
        ElseIf TabControlAlmace.SelectedIndex = 2 Then
            If DomainUpDown2.SelectedIndex = 0 Then
                SpconsultaubicacionproductosBindingSource.Filter = "CodigoProducto LIKE '" & tb_buscar.Text & "%' and aqui > 0"
            ElseIf DomainUpDown2.SelectedIndex = 1 Then
                SpconsultaubicacionproductosBindingSource.Filter = "codigoF LIKE '%" & tb_buscar.Text & "%' and aqui > 0"
            ElseIf DomainUpDown2.SelectedIndex = 2 Then
                SpconsultaubicacionproductosBindingSource.Filter = "Nombre LIKE '%" & tb_buscar.Text & "%' and aqui > 0"
            End If
        End If


    End Sub

    Private Sub DGV_UbicacionActual_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_UbicacionActual.CellEndEdit
        If Not DGV_UbicacionActual.CurrentCell.Value Is Nothing Then
            If DGV_UbicacionActual.SelectedRows.Count > 0 Then
                If DGV_UbicacionActual.SelectedRows(0).Cells(0).Value <> "" Then
                    If CInt(DGV_UbicacionActual.SelectedRows(0).Cells(0).Value) > CInt(DGV_UbicacionActual.SelectedRows(0).Cells(7).Value) Then
                        MsgBox("No se puede mover un número mayor de productos de los que hay en este tramo", MsgBoxStyle.Critical, "Advetencia!")
                        DGV_UbicacionActual.SelectedRows(0).Cells(0).Value = ""
                    ElseIf DGV_UbicacionActual.SelectedRows(0).Cells(12).Value.ToString = (cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text) Then
                        MsgBox("No cambió la ubicación del producto", MsgBoxStyle.Critical, "Advetencia!")
                        DGV_UbicacionActual.SelectedRows(0).Cells(0).Value = ""
                    Else
                        Dim y As Integer = 0
                        Dim was As Boolean = False
                        While y < DGV_NuevaUbicacion.Rows.Count
                            If DGV_NuevaUbicacion.Rows(y).Cells(1).Value = DGV_UbicacionActual.SelectedRows(0).Cells(1).Value And DGV_NuevaUbicacion.Rows(y).Cells(7).Value = cb_tramo.SelectedValue Then
                                DGV_NuevaUbicacion.Rows(y).Cells(0).Value = CInt(DGV_NuevaUbicacion.Rows(y).Cells(0).Value) + CInt(DGV_UbicacionActual.SelectedRows(0).Cells(0).Value)
                                y = DGV_NuevaUbicacion.Rows.Count
                                was = True
                            End If
                            y = y + 1
                        End While
                        If Not was Then
                            DGV_NuevaUbicacion.Rows.Add(DGV_UbicacionActual.SelectedRows(0).Cells(0).Value, DGV_UbicacionActual.SelectedRows(0).Cells(1).Value, DGV_UbicacionActual.SelectedRows(0).Cells(2).Value, DGV_UbicacionActual.SelectedRows(0).Cells(3).Value, DGV_UbicacionActual.SelectedRows(0).Cells(4).Value, DGV_UbicacionActual.SelectedRows(0).Cells(5).Value, (cb_almacen.Text + "-" + cb_cuarto.Text + "-" + cb_estante.Text + "-" + cb_tramo.Text), cb_tramo.SelectedItem.item(0).ToString, DGV_UbicacionActual.SelectedRows(0).Cells(12).Value, DGV_UbicacionActual.SelectedRows(0).Cells(11).Value, CInt(DGV_UbicacionActual.SelectedRows(0).Cells(7).Value) - CInt(DGV_UbicacionActual.SelectedRows(0).Cells(0).Value))
                        End If
                        Dim ubicRow() As Data.DataRow
                        ubicRow = Me.MELDataSet.Tables("sp_consulta_ubicacion_productos").Select("CodigoProducto = '" & DGV_UbicacionActual.SelectedRows(0).Cells(1).Value & "' and CodigoTramo = '" & DGV_UbicacionActual.SelectedRows(0).Cells(11).Value & "'")
                        ubicRow(0)("aqui") = DGV_UbicacionActual.SelectedRows(0).Cells(7).Value - DGV_UbicacionActual.SelectedRows(0).Cells(0).Value
                        If DGV_UbicacionActual.SelectedRows.Count <> 0 Then
                            DGV_UbicacionActual.SelectedRows(0).Cells(0).Value = ""
                        End If
                        BusquedaDinamica()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub DGV_NuevaUbicacion_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DGV_NuevaUbicacion.UserDeletingRow
        If DGV_NuevaUbicacion.Rows.Count <> 0 Then
            Dim ubicRow() As Data.DataRow
            ubicRow = Me.MELDataSet.Tables("sp_consulta_ubicacion_productos").Select("CodigoProducto = '" & e.Row.Cells(1).Value & "' and CodigoTramo = '" & e.Row.Cells(9).Value & "'")
            ubicRow(0)("aqui") = ubicRow(0)("aqui") + e.Row.Cells(0).Value
        End If
    End Sub

    Private Sub bt_aceptar_tab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aceptar_tab1.Click

        Dim cont As Integer = 0

        If Me.DGV_NuevaUbicacion.RowCount > 0 Then

            'Creo un ajuste de inventario
            'Dim Id As Integer = DatosInventario.ProximoAjuste()
            'DatosInventario.Inserta_Ajuste(Today, user_l, "Ajuste de almacen")

            For cont = 0 To DGV_NuevaUbicacion.RowCount - 1

                Dim ubicRow() As Data.DataRow
                Dim cantfinal As Integer = 0
                ubicRow = Me.MELDataSet.Tables("sp_consulta_ubicacion_productos").Select("CodigoProducto = '" & DGV_NuevaUbicacion.Rows(cont).Cells(1).Value & "' and CodigoTramo = '" & DGV_NuevaUbicacion.Rows(cont).Cells(9).Value & "'")
                cantfinal = ubicRow(0)("aqui")

                DatosAlmacenes.InsertarNuevaUbicacion(DGV_NuevaUbicacion.Rows(cont).Cells(1).Value.ToString, Me.DGV_NuevaUbicacion.Rows(cont).Cells(9).Value.ToString, CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(7).Value), CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(0).Value), cantfinal)

                DatosAlmacenes.Inserta_Traspaso(CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(9).Value), CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(7).Value), Me.DGV_NuevaUbicacion.Rows(cont).Cells(1).Value.ToString, CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(0).Value), user_l)

                'Registro cuando saco la mercancía del tramo viejo
                'DatosAjustes.InsertaProductoAjuste_Almacen(Id, Me.DGV_NuevaUbicacion.Rows(cont).Cells(1).Value.ToString, CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(0).Value * -1), "Movimiento de mercancía", CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(9).Value))

                'Registro cuando meto la mercancía en el tramo nuevo
                'DatosAjustes.InsertaProductoAjuste_Almacen(Id, Me.DGV_NuevaUbicacion.Rows(cont).Cells(1).Value.ToString, CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(0).Value), "Movimiento de mercancía", CInt(Me.DGV_NuevaUbicacion.Rows(cont).Cells(7).Value))

            Next
            DGV_NuevaUbicacion.Rows.Clear()

            DatosAlmacenes.Elimina_Ubicaciones_Vacias()

            MsgBox("La nueva ubicación de los productos, ha sido asignada", MsgBoxStyle.Information)
            tb_buscar.Clear()
            Me.Sp_consulta_ubicacion_productosTableAdapter.Fill(Me.MELDataSet.sp_consulta_ubicacion_productos)
        Else
            MsgBox("No se han asignado nuevas ubicaciones", MsgBoxStyle.Critical, "Advetencia!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancelar_tab1.Click
        DGV_NuevaUbicacion.Rows.Clear()
    End Sub


    Private Sub cb_aceptar_D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_aceptar_D.Click

        If DGV_ProductoActual.RowCount > 0 Then

            Dim i As Integer = 0

            'Creo un ajuste de inventario
            'Dim Id As Integer = DatosInventario.ProximoAjuste()
            'DatosInventario.Inserta_Ajuste(Today, user_l, "Ajuste de almacen")

            While i < DGV_ProductoActual.RowCount
                DatosAlmacenes.InsertarNuevaUbicacion(DGV_ProductoActual.Rows(i).Cells(0).Value.ToString, DGV_ProductoActual.Rows(i).Cells(10).Value.ToString, cb_tramoH.SelectedItem.item(0).ToString, CInt(DGV_ProductoActual.Rows(i).Cells(6).Value), 0)

                DatosAlmacenes.Inserta_Traspaso(DGV_ProductoActual.Rows(i).Cells(10).Value, cb_tramoH.SelectedItem.item(0).ToString, DGV_ProductoActual.Rows(i).Cells(0).Value, DGV_ProductoActual.Rows(i).Cells(6).Value, user_l)

                'Registro cuando saco la mercancía del tramo viejo
                'DatosAjustes.InsertaProductoAjuste_Almacen(Id, Me.DGV_ProductoActual.Rows(i).Cells(0).Value.ToString, CInt(Me.DGV_ProductoActual.Rows(i).Cells(6).Value * -1), "Movimiento de mercancía", CInt(Me.DGV_ProductoActual.Rows(i).Cells(10).Value))

                'Registro cuando meto la mercancía en el tramo nuevo
                'DatosAjustes.InsertaProductoAjuste_Almacen(Id, Me.DGV_ProductoActual.Rows(i).Cells(0).Value.ToString, CInt(Me.DGV_ProductoActual.Rows(i).Cells(6).Value), "Movimiento de mercancía", CInt(cb_tramoH.SelectedItem.item(0).ToString))

                i = i + 1
            End While

            DatosAlmacenes.Elimina_Ubicaciones_Vacias()

            MsgBox("Los productos han sido movidos exitosamente", MsgBoxStyle.Information, "SINPRO")
            Me.Sp_consulta_ubicacion_productosTableAdapter.Fill(Me.MELDataSet.sp_consulta_ubicacion_productos)
            BusquedaDinamica()

        Else

            MsgBox("La ubicación no posee productos asociados", MsgBoxStyle.Exclamation, "SINPRO")

        End If

    End Sub

    Private Sub TabControlAlmace_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlAlmace.SelectedIndexChanged
        If TabControlAlmace.SelectedIndex = 2 Then
            mover = True
            tb_buscar.Enabled = False
            DGV_Almacenes.ClearSelection()
            DGV_Almacenes.Enabled = False
            cb_almacenD_SelectedIndexChanged(cb_almacenD, New System.EventArgs)
            cb_almacenH_SelectedIndexChanged(cb_almacenH, New System.EventArgs)
            Me.SpconsultaubicacionproductosBindingSource.RemoveFilter()
        ElseIf TabControlAlmace.SelectedIndex = 0 Then
            DGV_Almacenes.Rows(0).Cells(1).Selected = True
            tb_buscar.Enabled = True
            DGV_Almacenes.Enabled = True
            Me.SpconsultaubicacionproductosBindingSource.RemoveFilter()
            mover = False
        ElseIf TabControlAlmace.SelectedIndex = 1 Then
            DGV_Almacenes.ClearSelection()
            DGV_Almacenes.Enabled = False
            'TODO: esta línea de código carga datos en la tabla 'MELDataSet.sp_consulta_ubicacion_productos' Puede moverla o quitarla según sea necesario.
            Me.Sp_consulta_ubicacion_productosTableAdapter.Fill(Me.MELDataSet.sp_consulta_ubicacion_productos)

            TblCuartoBindingSource.Filter = "CodigoAlmacen = " & cb_almacen.SelectedItem.item(0)
            TblEstanteBindingSource.Filter = "CodigoCuarto = " & cb_cuarto.SelectedItem.item(0)
            TblTramoBindingSource.Filter = "CodigoEstante = " & cb_estante.SelectedItem.item(0)

        End If
    End Sub
    

    Private Sub tb_buscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_buscar.KeyDown
        If TabControlAlmace.SelectedIndex = 1 Then
            If e.KeyData = Keys.Enter And DGV_UbicacionActual.RowCount <> 0 Then
                DGV_UbicacionActual.CurrentCell = DGV_UbicacionActual.Item(0, 0)
                DGV_UbicacionActual.Rows(0).Cells(0).Selected = True
                DGV_UbicacionActual.BeginEdit(True)
            End If
        End If
    End Sub


    Private Sub DGV_UbicacionActual_row2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_UbicacionActual.EditingControlShowing
        If Me.empezo = True Then
            If Not Me.tb_buscar.Focused Then
                If DGV_UbicacionActual.Rows.Count > 1 Then
                    DGV_UbicacionActual.BeginEdit(True)
                End If
            End If
        End If
    End Sub


    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_UbicacionActual.CellClick
        Try
            DGV_UbicacionActual.CurrentCell = DGV_UbicacionActual(0, e.RowIndex)
            DGV_UbicacionActual.BeginEdit(True)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub DGV_row(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_UbicacionActual.SelectionChanged
        If Me.empezo = True Then
            If Not Me.tb_buscar.Focused Then
                If DGV_UbicacionActual.Rows.Count > 1 Then
                    DGV_UbicacionActual.BeginEdit(True)
                ElseIf DGV_UbicacionActual.Rows.Count = 1 Then
                    DGV_UbicacionActual.Rows(0).Cells(0).Selected = True
                    DGV_UbicacionActual.BeginEdit(True)
                ElseIf DGV_UbicacionActual.Rows.Count = 0 Then
                    tb_buscar.Focus()
                    tb_buscar.SelectAll()
                End If
            End If
        End If
    End Sub


    Private Sub CellKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) OrElse e.KeyChar = Chr(Keys.Delete) OrElse Char.IsControl(e.KeyChar)) And (Not e.KeyChar = "."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_UbicacionActual.EditingControlShowing
        If Me.DGV_UbicacionActual.CurrentCell.ColumnIndex = 0 Then
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                RemoveHandler txt.KeyPress, AddressOf CellKeyPress
                AddHandler txt.KeyPress, AddressOf CellKeyPress
            End If
        End If
    End Sub


    Private Sub DomainUpDown2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainUpDown2.SelectedIndexChanged
        DomainUpDown2.ResetText()
    End Sub

    Private Sub Chk_Exist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Exist.CheckedChanged
        'BusquedaDinamica()
        CrearWhere()
    End Sub
    '---- COMBOS DESDE

    Private Sub cb_almacenD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacenD.SelectedIndexChanged
        Try

            If cb_almacenD.Text <> "" And TabControlAlmace.SelectedIndex = 2 Then
                TblCuartoBindingSource.Filter = "CodigoAlmacen = " & cb_almacenD.SelectedItem.item(0)
                TblEstanteBindingSource.Filter = "CodigoCuarto = " & cb_cuartoD.SelectedItem.item(0)
                TblTramoBindingSource.Filter = "CodigoEstante = " & cb_estanteD.SelectedItem.item(0)
                SpconsultaubicacionproductosBindingSource.Filter = "CodigoAlmacen = '" & cb_almacenD.SelectedItem.item(0).ToString + "' and CodigoCuarto = '" + cb_cuartoD.SelectedItem.item(0).ToString + "' and CodigoEstante = '" + cb_estanteD.SelectedItem.item(0).ToString + "' and CodigoTramo = " + cb_tramoD.SelectedItem.item(0).ToString
            End If

        Catch ex As Exception



        End Try

    End Sub

    Private Sub cb_cuartoD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuartoD.SelectedIndexChanged

        Try

            If cb_cuartoD.Text <> "" And TabControlAlmace.SelectedIndex = 2 Then
                TblEstanteBindingSource.Filter = "CodigoCuarto = " & cb_cuartoD.SelectedItem.item(0)
                TblTramoBindingSource.Filter = "CodigoEstante = " & cb_estanteD.SelectedItem.item(0)
                SpconsultaubicacionproductosBindingSource.Filter = "CodigoAlmacen = '" & cb_almacenD.SelectedItem.item(0).ToString + "' and CodigoCuarto = '" + cb_cuartoD.SelectedItem.item(0).ToString + "' and CodigoEstante = '" + cb_estanteD.SelectedItem.item(0).ToString + "' and CodigoTramo = " + cb_tramoD.SelectedItem.item(0).ToString
            End If

        Catch ex As Exception



        End Try

    End Sub

    Private Sub cb_estanteD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estanteD.SelectedIndexChanged

        Try

            If cb_estanteD.Text <> "" And TabControlAlmace.SelectedIndex = 2 Then
                TblTramoBindingSource.Filter = "CodigoEstante = " & cb_estanteD.SelectedItem.item(0)
                SpconsultaubicacionproductosBindingSource.Filter = "CodigoAlmacen = '" & cb_almacenD.SelectedItem.item(0).ToString + "' and CodigoCuarto = '" + cb_cuartoD.SelectedItem.item(0).ToString + "' and CodigoEstante = '" + cb_estanteD.SelectedItem.item(0).ToString + "' and CodigoTramo = " + cb_tramoD.SelectedItem.item(0).ToString
            End If

        Catch ex As Exception



        End Try

    End Sub

    Private Sub cb_tramoD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tramoD.SelectedIndexChanged

        Try

            If cb_tramoD.Text <> "" And TabControlAlmace.SelectedIndex = 2 Then
                SpconsultaubicacionproductosBindingSource.Filter = "CodigoAlmacen = '" & cb_almacenD.SelectedItem.item(0).ToString + "' and CodigoCuarto = '" + cb_cuartoD.SelectedItem.item(0).ToString + "' and CodigoEstante = '" + cb_estanteD.SelectedItem.item(0).ToString + "' and CodigoTramo = " + cb_tramoD.SelectedItem.item(0).ToString
            End If

        Catch ex As Exception



        End Try

    End Sub
    '---- FIN COMBOS DESDE

    '---- COMBOS HASTA
    Private Sub cb_almacenH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacenH.SelectedIndexChanged

        Try

            If cb_almacenH.Text <> "" And TabControlAlmace.SelectedIndex = 2 Then
                TblCuartoBindingSource1.Filter = "CodigoAlmacen = " & cb_almacenH.SelectedItem.item(0)
                TblEstanteBindingSource1.Filter = "CodigoCuarto = " & cb_cuartoH.SelectedItem.item(0)
                TblTramoBindingSource1.Filter = "CodigoEstante = " & cb_estanteH.SelectedItem.item(0)
            End If
        Catch ex As Exception



        End Try

    End Sub

    Private Sub cb_cuartoH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuartoH.SelectedIndexChanged
        Try
            If cb_cuartoH.Text <> "" And TabControlAlmace.SelectedIndex = 2 Then
                TblEstanteBindingSource1.Filter = "CodigoCuarto = " & cb_cuartoH.SelectedItem.item(0)
                TblTramoBindingSource1.Filter = "CodigoEstante = " & cb_estanteH.SelectedItem.item(0)
            End If
        Catch ex As Exception



        End Try
    End Sub

    Private Sub cb_estanteH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estanteH.SelectedIndexChanged
        Try
            If cb_estanteH.Text <> "" And TabControlAlmace.SelectedIndex = 2 Then
                TblTramoBindingSource1.Filter = "CodigoEstante = " & cb_estanteH.SelectedItem.item(0)
            End If
        Catch ex As Exception



        End Try
    End Sub

    '---- FIN COMBOS HASTA


    '---- COMBOS TABINDEX 1
    Private Sub cb_almacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_almacen.SelectedIndexChanged
        Try
            If cb_almacen.Text <> "" And TabControlAlmace.SelectedIndex = 1 Then
                TblCuartoBindingSource.Filter = "CodigoAlmacen = " & cb_almacen.SelectedItem.item(0)
                TblEstanteBindingSource.Filter = "CodigoCuarto = " & cb_cuarto.SelectedItem.item(0)
                TblTramoBindingSource.Filter = "CodigoEstante = " & cb_estante.SelectedItem.item(0)
            End If
        Catch ex As Exception



        End Try
    End Sub

    Private Sub cb_cuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuarto.SelectedIndexChanged
        Try
            If cb_cuarto.Text <> "" And TabControlAlmace.SelectedIndex = 1 Then
                TblEstanteBindingSource.Filter = "CodigoCuarto = " & cb_cuarto.SelectedItem.item(0)
                TblTramoBindingSource.Filter = "CodigoEstante = " & cb_estante.SelectedItem.item(0)
            End If
        Catch ex As Exception



        End Try
    End Sub

    Private Sub cb_estante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_estante.SelectedIndexChanged
        Try
            If cb_estante.Text <> "" And TabControlAlmace.SelectedIndex = 1 Then
                TblTramoBindingSource.Filter = "CodigoEstante = " & cb_estante.SelectedItem.item(0)
            End If
        Catch ex As Exception



        End Try
    End Sub

    Private Sub DGV_UbicacionActual_row2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_UbicacionActual.EditingControlShowing

    End Sub

    Private Sub Reubicación_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reubicación.Click

    End Sub
End Class
