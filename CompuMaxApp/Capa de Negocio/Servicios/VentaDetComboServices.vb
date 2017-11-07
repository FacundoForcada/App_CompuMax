Public Class VentaDetComboServices
    Private oVentaDetComboDAO As VentaDetComboDAO

    'Public Function getSqlVentaDetComb(ByVal ven_codigo As String, ByVal com_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
    '    Return oVentaDetComboDAO.getSqlVentaDetComb(ven_codigo, com_codigo, ved_cantidad, ved_precio, prom_codigo)
    'End Function

    Public Function getSqlVentaDetComb(ByVal com_codigo As String, ByVal ved_cantidad As String, ByVal ved_precio As String, ByVal prom_codigo As String) As String
        Return oVentaDetComboDAO.getSqlVentaDetComb(com_codigo, ved_cantidad, ved_precio, prom_codigo)
    End Function

    Public Sub New()
        oVentaDetComboDAO = New VentaDetComboDAO
    End Sub
End Class
