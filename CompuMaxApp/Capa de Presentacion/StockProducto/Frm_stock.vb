Public Class Frm_stock

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oStockProductoService As New StockProductoServices
        llenar_grid(oStockProductoService.getAllProductos())
    End Sub
    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_stock_producto.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_stock_producto.Rows.Add(New String() {row.Item("prod_codigo").ToString, row.Item("prod_denom").ToString, row.Item("stp_cantactual").ToString, row.Item("stp_cantminima").ToString})
        Next
    End Sub
End Class