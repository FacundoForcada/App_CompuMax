Public Class VentaDetProductoDAO
    'Public Function getSqlVentaDetProd(ByVal ven_codigo As String, ByVal prod_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
    '    Dim sql As String = "INSERT INTO VentaDetProd (ven_codigo, prod_codigo,ved_cantidad,ved_precio,prom_codigo) VALUES( " + ven_codigo + ", " + prod_codigo + ", " + ved_cantidad + ", '" + ved_precio + "'," + prom_codigo + ") ;"
    '    Return sql
    'End Function

    Public Function getSqlVentaDetProd(ByVal prod_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
        Dim sql As String = "INSERT INTO VentaDetProd (ven_codigo, prod_codigo,ved_cantidad,ved_precio,prom_codigo) VALUES( @lastidentity , " + prod_codigo + ", " + ved_cantidad + ", " + ved_precio + "," + prom_codigo + "); "
        Return sql
    End Function
End Class
