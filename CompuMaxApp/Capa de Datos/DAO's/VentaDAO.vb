Public Class VentaDAO
    Public Function getSqlVenta(ByVal cli_codigo As String, ByVal fecha As DateTime) As String
        Dim sql As String = "INSERT INTO Venta (ven_fecha, cli_codigo, ven_factor) VALUES ( convert(datetime, '" + fecha + "', 103) , " + cli_codigo + ", 1 ); "
        sql += "Declare @lastidentity as int; set @lastidentity = @@IDENTITY; "
        Return sql
    End Function

    'Public Function getLastID() As Integer
    '    Dim sql As String = "SELECT MAX(ven.ven_codigo) FROM venta ven"
    '    Dim valor = BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0).Item(0)
    '    If valor Is DBNull.Value Then
    '        Return 0
    '    Else
    '        Return valor + 1
    '    End If
    'End Function

    Public Function transactVenta(ByVal sql As String) As Integer
        Return BDHelper.getDBHelper.EjecutarTransaccionSQL(sql)
    End Function
    Public Function getReporteVentasXPeriodo(ByVal per_desde As String, ByVal per_hasta As String) As DataTable
        Dim sql As String = "Select V.ven_codigo, V.ven_fecha, C.cli_codigo, C.cli_nombre, C.cli_apellido, (ISNULL(SUM(VDC.ved_precio),0)+ ISNULL(SUM(VDP.ved_precio),0)) As ven_precio" & _
                            " From Cliente C, Venta V FULL OUTER JOIN VentaDetCombo VDC ON V.ven_codigo = VDC.ven_codigo" & _
                            " FULL OUTER JOIN VentaDetProd VDP ON V.ven_codigo = VDP.ven_codigo" & _
                            " Where ven_fecha >= '" + per_desde + "' AND ven_fecha <= '" + per_hasta + "' AND V.cli_codigo = C.cli_codigo" & _
                            " Group By V.ven_codigo, V.ven_fecha, C.cli_codigo, C.cli_nombre, C.cli_apellido"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    'Public Function getReporteVentasXPeriodo(ByVal per_desde As String, ByVal per_hasta As String) As DataTable
    '    Dim sql As String = "Select V.ven_codigo, V.ven_fecha, V.cli_codigo,(ISNULL(SUM(VDC.ved_precio),0)+ ISNULL(SUM(VDP.ved_precio),0)) As ven_precio" & _
    '                        " From Venta V FULL OUTER JOIN VentaDetCombo VDC ON V.ven_codigo = VDC.ven_codigo" & _
    '                        " FULL OUTER JOIN VentaDetProd VDP ON V.ven_codigo = VDP.ven_codigo" & _
    '                        " Where ven_fecha >= FORMAT('" + per_desde + "',  AS DATE) AND ven_fecha <= CAST('" + per_hasta + "' AS DATE)" & _
    '                        " Group By V.ven_codigo, V.ven_fecha, V.cli_codigo"
    '    Return BDHelper.getDBHelper.ConsultaSQL(sql)
    'End Function

    Public Function getInsertedVenta() As Integer
        Dim sql As String = "SELECT MAX(ven_codigo) FROM Venta"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0).Item(0)
    End Function

End Class
