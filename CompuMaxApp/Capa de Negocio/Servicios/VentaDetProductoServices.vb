Public Class VentaDetProductoServices
    Private oVentaDetProductoDAO As VentaDetProductoDAO

    'Public Function getSqlVentaDetProd(ByVal ven_codigo As String, ByVal prod_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
    '    Return oVentaDetProductoDAO.getSqlVentaDetProd(ven_codigo, prod_codigo, ved_cantidad, ved_precio, prom_codigo)
    'End Function

    Public Function getSqlVentaDetProd(ByVal prod_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
        Return oVentaDetProductoDAO.getSqlVentaDetProd(prod_codigo, ved_cantidad, ved_precio, prom_codigo)
    End Function

    Public Sub New()
        oVentaDetProductoDAO = New VentaDetProductoDAO
    End Sub
End Class
