Public Class StockProductoDAO

    Public Function getAllProductos() As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT s.prod_codigo As prod_codigo, p.prod_denom As prod_denom, s.stp_cantactual As stp_cantactual, s.stp_cantminima As stp_cantminima"
        sql = sql + " FROM stockProducto s, producto p WHERE s.prod_codigo = p.prod_codigo"
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function

    Public Function getReporteClientes(ByVal prod_desde As Integer, ByVal prod_hasta As Integer, ByVal tpr_codigo As Integer, ByVal cat_codigo As Integer, ByVal mar_codigo As Integer, ByVal all_tpr As Integer, ByVal all_cat As Integer, ByVal all_mar As Integer) As DataTable
        Dim WhereTpr As String
        Dim WhereCat As String
        Dim WhereMar As String
        If all_tpr = 0 Then
            WhereTpr = " AND p.tpr_codigo = '" & tpr_codigo & "'"
        Else
            WhereTpr = ""
        End If
        If all_cat = 0 Then
            WhereCat = " AND p.cat_codigo = '" & cat_codigo & "'"
        Else
            WhereCat = ""
        End If
        If all_mar = "0" Then
            WhereMar = " AND p.mar_codigo = '" & mar_codigo & "'"
        Else
            WhereMar = ""
        End If


        Dim sql As String = "SELECT sp.prod_codigo, p.prod_denom, p.prod_numserie, tp.tpr_denom, c.cat_denom, m.mar_denom, stp_cantactual, stp_cantminima "
        sql = sql + "from StockProducto sp, Producto p, TipoProducto tp, Categoria c, Marca m "
        sql = sql + "where sp.prod_codigo = p.prod_codigo "
        sql = sql + "AND p.tpr_codigo = tp.tpr_codigo AND p.cat_codigo = c.cat_codigo AND p.mar_codigo = m.mar_codigo "
        sql = sql + "AND sp.prod_codigo BETWEEN '" & prod_desde.ToString & "' AND '" & prod_hasta.ToString & "' "
        sql = sql + "" & WhereTpr & "" & WhereCat & "" & WhereMar & " "
        sql = sql + "Order by sp.prod_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

End Class
