Partial Class MELDataSet2
    Partial Class Table_GuiaDesglosadaDataTable

        Private Sub Table_GuiaDesglosadaDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RifColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
