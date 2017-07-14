Partial Class MELDataSet

    Partial Class Tbl_VendedorDataTable

        Private Sub Tbl_VendedorDataTable_Tbl_VendedorRowChanging(ByVal sender As System.Object, ByVal e As Tbl_VendedorRowChangeEvent) Handles Me.Tbl_VendedorRowChanging

        End Sub

    End Class

    Partial Class sp_consultaRecibos2DataTable

        Private Sub sp_consultaRecibos2DataTable_sp_consultaRecibos2RowChanging(ByVal sender As System.Object, ByVal e As sp_consultaRecibos2RowChangeEvent) Handles Me.sp_consultaRecibos2RowChanging

        End Sub

    End Class

    Partial Class sp_consulta_ubicacion_productosDataTable

        Private Sub sp_consulta_ubicacion_productosDataTable_sp_consulta_ubicacion_productosRowChanging(ByVal sender As System.Object, ByVal e As sp_consulta_ubicacion_productosRowChangeEvent) Handles Me.sp_consulta_ubicacion_productosRowChanging

        End Sub

    End Class

    Partial Class sp_consultaDiferenciasInventarioDataTable

        Private Sub sp_consultaDiferenciasInventarioDataTable_sp_consultaDiferenciasInventarioRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaDiferenciasInventarioRowChangeEvent) Handles Me.sp_consultaDiferenciasInventarioRowChanging

        End Sub

    End Class

    Partial Class sp_consultaFactVentasDataTable

        Private Sub sp_consultaFactVentasDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NumeroFacturaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class sp_consultaNotasCreditoDataTable

        Private Sub sp_consultaNotasCreditoDataTable_sp_consultaNotasCreditoRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaNotasCreditoRowChangeEvent) Handles Me.sp_consultaNotasCreditoRowChanging

        End Sub

        Private Sub sp_consultaNotasCreditoDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NroControlColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class sp_consultaProductosInvetarioDataTable

        Private Sub sp_consultaProductosInvetarioDataTable_sp_consultaProductosInvetarioRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaProductosInvetarioRowChangeEvent) Handles Me.sp_consultaProductosInvetarioRowChanging

        End Sub

    End Class

    Partial Class sp_ConsultaProductosAjusteInvDataTable

        Private Sub sp_ConsultaProductosAjusteInvDataTable_sp_ConsultaProductosAjusteInvRowChanging(ByVal sender As System.Object, ByVal e As sp_ConsultaProductosAjusteInvRowChangeEvent) Handles Me.sp_ConsultaProductosAjusteInvRowChanging

        End Sub

    End Class

    Partial Class sp_consultaProductosParaInventarioDataTable

    End Class

    Partial Class Table_indice_ModelosDataTable

    End Class

    Partial Class Table_Catalogo_Productos_FotosDataTable


    End Class

    Partial Class sp_infoGeneralComprasDataTable

        Private Sub sp_infoGeneralComprasDataTable_sp_infoGeneralComprasRowChanging(ByVal sender As System.Object, ByVal e As sp_infoGeneralComprasRowChangeEvent) Handles Me.sp_infoGeneralComprasRowChanging

        End Sub

    End Class

    Partial Class sp_consultaNCPendientesDataTable

        Private Sub sp_consultaNCPendientesDataTable_sp_consultaNCPendientesRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaNCPendientesRowChangeEvent) Handles Me.sp_consultaNCPendientesRowChanging

        End Sub

    End Class

    Partial Class Table_DetallesComisionPagadaDataTable

    End Class

    Partial Class sp_consulta_Productos_PedidoClienteDataTable

        Private Sub sp_consulta_Productos_PedidoClienteDataTable_sp_consulta_Productos_PedidoClienteRowChanging(ByVal sender As System.Object, ByVal e As sp_consulta_Productos_PedidoClienteRowChangeEvent) Handles Me.sp_consulta_Productos_PedidoClienteRowChanging

        End Sub

    End Class

    Partial Class sp_consultaFactNoAjustadasDataTable

    End Class

    Partial Class sp_infoGeneralDataTable

        Private Sub sp_infoGeneralDataTable_sp_infoGeneralRowChanging(ByVal sender As System.Object, ByVal e As sp_infoGeneralRowChangeEvent) Handles Me.sp_infoGeneralRowChanging

        End Sub

        Private Sub sp_infoGeneralDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging

        End Sub

    End Class

    Partial Class sp_consulta_Listado_AlfabeticoDataTable

        Private Sub sp_consulta_Listado_AlfabeticoDataTable_sp_consulta_Listado_AlfabeticoRowChanging(ByVal sender As System.Object, ByVal e As sp_consulta_Listado_AlfabeticoRowChangeEvent) Handles Me.sp_consulta_Listado_AlfabeticoRowChanging

        End Sub

    End Class

    Partial Class sp_consultaproductosNC_rdlcDataTable

        Private Sub sp_consultaproductosNC_rdlcDataTable_sp_consultaproductosNC_rdlcRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaproductosNC_rdlcRowChangeEvent) Handles Me.sp_consultaproductosNC_rdlcRowChanging

        End Sub

    End Class

    Partial Class sp_consultaProductoDataTable

        Private Sub sp_consultaProductoDataTable_sp_consultaProductoRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaProductoRowChangeEvent) Handles Me.sp_consultaProductoRowChanging

        End Sub

    End Class

    Partial Class sp_consultaLogoDataTable

    End Class

    Partial Class sp_R_traspasosDataTable

        Private Sub sp_R_traspasosDataTable_sp_R_traspasosRowChanging(ByVal sender As System.Object, ByVal e As sp_R_traspasosRowChangeEvent) Handles Me.sp_R_traspasosRowChanging

        End Sub

    End Class

    Partial Class sp_R_ChequesDevDataTable

        Private Sub sp_R_ChequesDevDataTable_sp_R_ChequesDevRowChanging(ByVal sender As System.Object, ByVal e As sp_R_ChequesDevRowChangeEvent) Handles Me.sp_R_ChequesDevRowChanging
        End Sub

    End Class

    Partial Class sp_consultaPedido_Producto_ClienteDataTable

        Private Sub sp_consultaPedido_Producto_ClienteDataTable_sp_consultaPedido_Producto_ClienteRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaPedido_Producto_ClienteRowChangeEvent) Handles Me.sp_consultaPedido_Producto_ClienteRowChanging

        End Sub

    End Class

    Partial Class Table_Productos_VariacionDataTable

    End Class

    Partial Class Table_Productos_NacionalizadosDataTable


        Private Sub Table_Productos_NacionalizadosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CodigoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class Table_Cargar_CompraDataTable

        Private Sub Table_Cargar_CompraDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CantidadColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class sp_consultaPedidoClienteDataTable

        Private Sub sp_consultaPedidoClienteDataTable_sp_consultaPedidoClienteRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaPedidoClienteRowChangeEvent) Handles Me.sp_consultaPedidoClienteRowChanging

        End Sub

    End Class

    Partial Class Table_Analisis_CobranzaDataTable



        Private Sub Table_Analisis_CobranzaDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RazonColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class sp_consultaProducto_GranSelectDataTable

        Private Sub sp_consultaProducto_GranSelectDataTable_sp_consultaProducto_GranSelectRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaProducto_GranSelectRowChangeEvent) Handles Me.sp_consultaProducto_GranSelectRowChanging

        End Sub

    End Class

    Partial Class sp_consultaMarcaDataTable

        Private Sub sp_consultaMarcaDataTable_sp_consultaMarcaRowChanging(ByVal sender As System.Object, ByVal e As sp_consultaMarcaRowChangeEvent) Handles Me.sp_consultaMarcaRowChanging

        End Sub

    End Class

    Partial Class Table_GuiaBultosDataTable

    End Class

    Partial Class Table_GuiaDesglosadaDataTable

    End Class

End Class



Namespace MELDataSetTableAdapters
    
    Partial Public Class sp_consultaPedido_Producto_ClienteTableAdapter
    End Class
End Namespace

Namespace MELDataSetTableAdapters
    
    Partial Public Class sp_R_traspasosTableAdapter
    End Class
End Namespace

Namespace MELDataSetTableAdapters
    
    Partial Public Class sp_consultaProductosCodArancelariosTableAdapter
    End Class
End Namespace

Namespace MELDataSetTableAdapters
    
    Partial Public Class sp_lvclienteTableAdapter
    End Class
End Namespace

Namespace MELDataSetTableAdapters
    
    Partial Public Class sp_consultaFacturasPagadasTableAdapter
    End Class
End Namespace

Namespace MELDataSetTableAdapters
    
    Partial Public Class Tbl_VendedorTableAdapter
    End Class
End Namespace
