Public Class ProductoDAO
    Public Function insertProducto(ByVal prod_denom As String, ByVal tipoProd As Integer, ByVal marca As Integer, ByVal prod_numserie As String, ByVal prod_precio As Double, ByVal categoria As Integer) As Integer
        Dim sql As String = "INSERT Producto (prod_denom,tpr_codigo,mar_codigo,cat_codigo,prod_numserie,prod_precio,est_codigo) "
        sql = sql + "VALUES ( '" + prod_denom + "'"
        sql = sql + ", " + tipoProd.ToString + ""
        sql = sql + ", " + marca.ToString + ""
        sql = sql + ", " + categoria.ToString + ""
        sql = sql + ", '" + prod_numserie + "'"
        sql = sql + ", " + prod_precio.ToString + ""
        sql = sql + ", 1 )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateProducto(ByVal prod_codigo As Integer, ByVal prod_denom As String, ByVal tipoProd As Integer, ByVal marca As Integer, ByVal prod_numserie As String, ByVal prod_precio As Double, ByVal categoria As Integer) As Integer
        Dim sql As String = "UPDATE Producto SET "
        sql = sql + "prod_denom = '" + prod_denom + "', "
        sql = sql + "tpr_codigo = " + tipoProd.ToString + ", "
        sql = sql + "mar_codigo = " + marca.ToString + ", "
        sql = sql + "cat_codigo = " + categoria.ToString + ", "
        sql = sql + "prod_numserie = '" + prod_numserie + "', "
        sql = sql + "prod_precio = " + prod_precio.ToString + " "
        sql = sql + "WHERE prod_codigo = " + prod_codigo.ToString
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function deleteProducto(ByVal prod_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Producto SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE prod_codigo = " + prod_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function getProductos(ByVal prod_denom As String, ByVal tipoProd As String, ByVal marca As String, ByVal categoria As String, ByVal chkTodos As Integer) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT p.prod_codigo, p.prod_denom, tp.tpr_denom, m.mar_denom, p.prod_numserie, p.prod_precio, p.est_codigo, Null, c.cat_denom "
        sql = sql + "FROM producto p, tipoproducto tp, marca m, categoria c "
        sql = sql + "WHERE p.tpr_codigo = tp.tpr_codigo AND p.mar_codigo = m.mar_codigo AND p.cat_codigo = c.cat_codigo "
        If chkTodos = 0 Then
            If tipoProd <> String.Empty Then
                sql = sql + "AND tp.tpr_denom = '" + tipoProd.ToString + "' "
            End If
            If marca <> String.Empty Then
                sql = sql + "AND m.mar_denom = '" + marca.ToString + "' "
            End If
            If categoria <> String.Empty Then
                sql = sql + "AND c.cat_denom = '" + categoria.ToString + "' "
            End If
            sql = sql + "AND p.prod_denom LIKE '%" + prod_denom.ToString + "%' "
        End If
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function

    Public Function getProductosFiltered(ByVal prod_denom As String, ByVal tipoProd As String, ByVal marca As String, ByVal categoria As String, ByVal cantidad As String, ByVal prom_codigo As String) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT p.prod_codigo, p.prod_denom, p.tpr_codigo, tp.tpr_denom, p.cat_codigo, c.cat_denom, p.mar_codigo, m.mar_denom, p.prod_numserie, '" + cantidad + "' as ved_cantidad, p.prod_precio, '" + prom_codigo + "' as prod_prom_codigo, pr.prom_denom As prod_prom_denom, pr.prom_desc as prod_prom_desc, ((p.prod_precio-(((p.prod_precio)*(pr.prom_desc))/100))*('" + cantidad + "')) as subtotal "
        sql = sql + "FROM producto p, tipoproducto tp, marca m, categoria c, promocion pr "
        sql = sql + "WHERE p.tpr_codigo = tp.tpr_codigo AND p.mar_codigo = m.mar_codigo AND p.cat_codigo = c.cat_codigo "
        If tipoProd <> String.Empty Then
            sql = sql + "AND tp.tpr_denom = '" + tipoProd.ToString + "' "
        End If
        If marca <> String.Empty Then
            sql = sql + "AND m.mar_denom = '" + marca.ToString + "' "
        End If
        If categoria <> String.Empty Then
            sql = sql + "AND c.cat_denom = '" + categoria.ToString + "' "
        End If
        If prom_codigo <> String.Empty Then
            sql = sql + "AND pr.prom_codigo = '" + prom_codigo + "' "
        End If
        sql = sql + "AND p.prod_denom = '" + prod_denom.ToString + "' "
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function

    Public Function validateProducto(ByVal prod_denom As String) As Boolean
        Dim sql As String = "SELECT * FROM Producto p WHERE p.prod_denom = '" + prod_denom.ToString + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count > 0
    End Function

    Public Function getProductoYMarca(ByVal combo_codigo As String, ByVal prod_denom As String, chktodos As Integer) As DataTable
        Dim sql As String = "SELECT p.prod_codigo, p.prod_denom, m.mar_denom FROM Producto p, Marca m, ComboProducto cp "
        sql = sql + "WHERE p.mar_codigo = m.mar_codigo AND p.prod_codigo = cp.prod_codigo AND cp.prod_codigo != " + combo_codigo + " "
        If chktodos = 0 Then
            sql = sql + "AND p.prod_denom = '" + prod_denom + "' "
        End If
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Sub llenarComboGrupo(cmb_productos As ComboBox, ByVal categoria As String, ByVal tipoprod As String, ByVal marca As String)
        Dim sql As String = "SELECT p.prod_codigo, p.prod_denom FROM Producto p"
        Dim sqlWhere As String = " WHERE "
        Dim sqlAndSent As String = " AND "
        Dim bContieneWhere As Boolean = False
        If categoria <> String.Empty Then
            sql = sql + ", Categoria c"
            bContieneWhere = True
            If sqlWhere = " WHERE " Then
                sqlWhere = sqlWhere + "p.cat_codigo = c.cat_codigo AND c.cat_denom = '" + categoria.ToString + "'"
            Else
                sqlWhere = sqlWhere + sqlAndSent + "p.cat_codigo = c.cat_codigo AND c.cat_denom = '" + categoria.ToString + "'"
            End If
        End If

        If tipoprod <> String.Empty Then
            sql = sql + ", TipoProducto tp"
            bContieneWhere = True
            If sqlWhere = " WHERE " Then
                sqlWhere = sqlWhere + "p.tpr_codigo = tp.tpr_codigo AND tp.tpr_denom = '" + tipoprod.ToString + "'"
            Else
                sqlWhere = sqlWhere + sqlAndSent + "p.tpr_codigo = tp.tpr_codigo AND tp.tpr_denom = '" + tipoprod.ToString + "'"
            End If
        End If

        If marca <> String.Empty Then
            sql = sql + ", Marca m"
            bContieneWhere = True
            If sqlWhere = " WHERE " Then
                sqlWhere = sqlWhere + "p.mar_codigo = m.mar_codigo AND m.mar_denom = '" + marca.ToString + "'"
            Else
                sqlWhere = sqlWhere + sqlAndSent + "p.mar_codigo = m.mar_codigo AND m.mar_denom = '" + marca.ToString + "'"
            End If
        End If

        If bContieneWhere Then
            sql = sql + sqlWhere
        End If

        BDHelper.getDBHelper.llenarCombo(cmb_productos, BDHelper.getDBHelper.ConsultaSQL(sql), "prod_denom", "prod_codigo")
    End Sub

    Public Function getReporteProductosVendidos(ByVal prod_desde As Integer, ByVal prod_hasta As Integer, ByVal ven_fecha_desde As String, ByVal ven_fecha_hasta As String, ByVal tpr_codigo As Integer, ByVal cat_codigo As Integer, ByVal mar_codigo As Integer, ByVal all_tpr As Integer, ByVal all_cat As Integer, ByVal all_mar As Integer) As DataTable
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

        Dim sql As String = "SELECT vdp.prod_codigo, p.prod_denom, tp.tpr_denom, c.cat_denom, m.mar_denom, v.ven_fecha, vdp.ved_cantidad "
        sql = sql + "from Venta v, VentaDetProd vdp, Producto p, TipoProducto tp, Categoria c, Marca m "
        sql = sql + "where v.ven_codigo = vdp.ven_codigo AND vdp.prod_codigo = p.prod_codigo "
        sql = sql + "AND p.tpr_codigo = tp.tpr_codigo AND p.cat_codigo = c.cat_codigo AND p.mar_codigo = m.mar_codigo "
        sql = sql + "AND v.ven_fecha >= '" + ven_fecha_desde + "' AND v.ven_fecha <= '" + ven_fecha_hasta + "' "
        sql = sql + "AND vdp.prod_codigo BETWEEN '" & prod_desde.ToString & "' AND '" & prod_hasta.ToString & "' "
        sql = sql + "" & WhereTpr & "" & WhereCat & "" & WhereMar & " "
        sql = sql + "Order by vdp.prod_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function getReporteProductosVendidosAgrupado(ByVal prod_desde As Integer, ByVal prod_hasta As Integer, ByVal ven_fecha_desde As String, ByVal ven_fecha_hasta As String, ByVal tpr_codigo As Integer, ByVal cat_codigo As Integer, ByVal mar_codigo As Integer, ByVal all_tpr As Integer, ByVal all_cat As Integer, ByVal all_mar As Integer) As DataTable
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

        Dim sql As String = "SELECT vdp.prod_codigo, p.prod_denom, tp.tpr_denom, c.cat_denom, m.mar_denom, '' As ven_fecha, SUM(vdp.ved_cantidad) as ved_cantidad "
        sql = sql + "from Venta v, VentaDetProd vdp, Producto p, TipoProducto tp, Categoria c, Marca m "
        sql = sql + "where v.ven_codigo = vdp.ven_codigo AND vdp.prod_codigo = p.prod_codigo "
        sql = sql + "AND p.tpr_codigo = tp.tpr_codigo AND p.cat_codigo = c.cat_codigo AND p.mar_codigo = m.mar_codigo "
        sql = sql + "AND v.ven_fecha >= '" + ven_fecha_desde + "' AND v.ven_fecha <= '" + ven_fecha_hasta + "' "
        sql = sql + "AND vdp.prod_codigo BETWEEN '" & prod_desde.ToString & "' AND '" & prod_hasta.ToString & "' "
        sql = sql + "" & WhereTpr & "" & WhereCat & "" & WhereMar & " "
        sql = sql + "GROUP BY vdp.prod_codigo, p.prod_denom, tp.tpr_denom, c.cat_denom, m.mar_denom "
        sql = sql + "Order by vdp.prod_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

End Class
