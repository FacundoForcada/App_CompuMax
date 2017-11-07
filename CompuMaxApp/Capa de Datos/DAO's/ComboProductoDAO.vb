Public Class ComboProductoDAO

    Public Function obtenerProductosXCombo(ByVal combo_denom As String) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT cp.com_codigo, cp.prod_codigo, p.prod_denom, cp.cmp_cantprod "
        sql = sql + "FROM ComboProducto cp, Producto p, Combo c "
        sql = sql + "WHERE cp.prod_codigo = p.prod_codigo AND cp.com_codigo = c.com_codigo AND c.com_denom = '" + combo_denom.ToString + "' "
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function

    Public Function obtenerProductosXComboFiltered(ByVal combo_denom As String, ByVal categoria As String, ByVal cantidad As String) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT cp.com_codigo as com_com_codigo, c.com_denom as com_com_denom, cp.prod_codigo as com_prod_codigo, p.prod_denom as com_prod_denom, p.tpr_codigo as com_tpr_codigo, tp.tpr_denom as com_tpr_denom, p.cat_codigo as com_cat_codigo, ca.cat_denom as com_cat_denom, p.mar_codigo as com_mar_codigo, m.mar_denom as com_mar_denom, p.prod_numserie as com_prod_numserie, ((cp.cmp_cantprod)*('" + cantidad + "')) as com_prod_cantidad "
        sql = sql + "FROM ComboProducto cp, Producto p, Combo c, Categoria ca, TipoProducto tp, Marca m "
        sql = sql + "WHERE cp.prod_codigo = p.prod_codigo AND cp.com_codigo = c.com_codigo "
        sql = sql + "AND c.cat_codigo = ca.cat_codigo AND p.tpr_codigo = tp.tpr_codigo "
        sql = sql + "AND p.mar_codigo = m.mar_codigo "
        sql = sql + "AND c.com_denom = '" + combo_denom.ToString + "' "
        If categoria <> String.Empty Then
            sql = sql + " AND ca.cat_denom = '" + categoria + "' "
        End If
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function

    Public Function insertComboProducto(ByVal com_codigo As Integer, ByVal prod_codigo As Integer, ByVal cmp_cantprod As Integer) As Boolean
        Dim sql As String = "INSERT ComboProducto (com_codigo,prod_codigo,cmp_cantprod) "
        sql = sql + "VALUES ( "
        sql = sql + "" + com_codigo.ToString + ", "
        sql = sql + "" + prod_codigo.ToString + ", "
        sql = sql + "" + cmp_cantprod.ToString + " )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
    End Function

    Public Function deleteComboProducto(ByVal prod_codigo As Integer, ByVal com_codigo As Integer) As Boolean
        Dim sql As String = "DELETE FROM ComboProducto "
        sql = sql + "WHERE prod_codigo = " + prod_codigo.ToString + " AND com_codigo = " + com_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
    End Function

End Class
