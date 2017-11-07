Public Class VentaDetComboDAO
    'Public Function getSqlVentaDetComb(ByVal ven_codigo As String, ByVal com_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
    '    Dim sql As String = "INSERT INTO VentaDetCombo (ven_codigo, com_codigo,ved_cantidad,ved_precio,prom_codigo) VALUES ( " + ven_codigo + ", " + com_codigo + ", " + ved_cantidad + ", '" + ved_precio + "' ," + prom_codigo + ") ;"
    '    Return sql
    'End Function

    Public Function getSqlVentaDetComb(ByVal com_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
        Dim sql As String = "INSERT INTO VentaDetCombo (ven_codigo, com_codigo,ved_cantidad,ved_precio,prom_codigo) VALUES ( @lastidentity , " + com_codigo + ", " + ved_cantidad + ", " + ved_precio + " ," + prom_codigo + "); "
        Return sql
    End Function
End Class