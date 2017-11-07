Public Class StockProductoServices
    Private oStockProductoDAO As StockProductoDAO

    Public Function getAllProductos() As DataTable
        Return oStockProductoDAO.getAllProductos()
    End Function
    Public Sub New()
        oStockProductoDAO = New StockProductoDAO
    End Sub

    Public Function obtenerReporteClientes(ByVal prod_desde As Integer, ByVal prod_hasta As Integer, ByVal tpr_codigo As Integer, ByVal cat_codigo As Integer, ByVal mar_codigo As Integer, ByVal all_tpr As Integer, ByVal all_cat As Integer, ByVal all_mar As Integer) As DataTable
        Return oStockProductoDAO.getReporteClientes(prod_desde, prod_hasta, tpr_codigo, cat_codigo, mar_codigo, all_tpr, all_cat, all_mar)
    End Function

End Class
