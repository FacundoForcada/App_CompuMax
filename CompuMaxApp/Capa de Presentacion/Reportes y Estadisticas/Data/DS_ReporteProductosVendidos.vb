Partial Class DS_ReporteProductosVendidos
    Partial Class ReporteProductosVendidosDataTable

        Private Sub ReporteProductosVendidosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ved_cantidadColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class


End Class
