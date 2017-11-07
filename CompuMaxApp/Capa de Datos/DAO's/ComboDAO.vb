Public Class ComboDAO
    Public Sub llenarComboFiltroCat(ByVal cmb_combos As ComboBox, ByVal categoria As String)
        If categoria = String.Empty Then
            BDHelper.getDBHelper.llenarCombo(cmb_combos, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Combo c "), "com_denom", "com_codigo")
        Else
            BDHelper.getDBHelper.llenarCombo(cmb_combos, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Combo c LEFT JOIN Categoria ca ON c.cat_codigo = ca.cat_codigo WHERE ca.cat_denom = '" + categoria + "'"), "com_denom", "com_codigo")
        End If
    End Sub

    Public Sub llenarComboGrupoCompleto(cmb_combos As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_combos, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Combo c "), "com_denom", "com_codigo")
    End Sub
    Public Function getReporteCombosVendidos(ByVal top As String, ByVal per_desde As String, ByVal per_hasta As String) As DataTable
        Dim sql As String = "Select top " + top + " c.com_denom,c.com_precio,v.ven_fecha,sum(vc.ved_cantidad) As cant_ven" & _
                            " From VentaDetCombo vc JOIN Combo c ON vc.com_codigo = c.com_codigo" & _
                            " JOIN Venta v ON v.ven_codigo = vc.ven_codigo " & _
                            " Where ven_fecha >= '" + per_desde + "' AND ven_fecha <= '" + per_hasta + "'" & _
                            " Group by c.com_denom,c.com_precio,v.ven_fecha" & _
                            " Order by sum(vc.ved_cantidad) DESC"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function
    Public Function getCombos() As DataTable
        Dim sql As String = "SELECT c.com_codigo, c.com_denom, ca.cat_denom, e.est_denom, c.com_precio FROM Combo c, estado e, categoria ca WHERE c.est_codigo = e.est_codigo AND c.cat_codigo = ca.cat_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 'com_prom_codigo,com_prom_denom,com_prom_desc
    Public Function getCombosFiltros(ByVal com_denom As String, ByVal categoria As String, ByVal cantidad As String, ByVal prom_codigo As String) As DataTable
        Dim sql As String = "SELECT c.com_codigo as combo_codigo, c.com_denom as combo_denom, c.cat_codigo as com_categoria_codigo, ca.cat_denom as com_categoria_denom, '" + cantidad + "' as com_cantidad, c.com_precio as com_precio, '" + prom_codigo + "' as com_prom_codigo, p.prom_denom As com_prom_denom, p.prom_desc as com_prom_desc, ((c.com_precio-(((c.com_precio)*(p.prom_desc))/100))*('" + cantidad + "')) as com_subtotal "
        sql = sql + "FROM Combo c, Categoria ca, Promocion p WHERE c.cat_codigo = ca.cat_codigo AND c.com_denom = '" + com_denom + "' AND p.prom_codigo = " + prom_codigo
        If categoria <> String.Empty Then
            sql = sql + " AND ca.cat_denom = '" + categoria + "' "
        End If
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function validateCombo(ByVal com_denom) As Boolean
        Dim sql As String = "SELECT * FROM Combo c WHERE c.com_denom = '" + com_denom + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count
    End Function

    Public Function insertCombo(ByVal com_denom As String, ByVal cat_codigo As Integer, ByVal est_codigo As Integer, ByVal com_precio As Double) As Integer
        Dim sql As String = "INSERT Combo (com_denom, cat_codigo, est_codigo, com_precio) VALUES ( "
        sql = sql + "'" + com_denom + "', "
        sql = sql + "" + cat_codigo.ToString + ", "
        sql = sql + "" + est_codigo.ToString + ", "
        sql = sql + "" + com_precio.ToString + " )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateCombo(ByVal com_codigo As Integer, ByVal com_denom As String, ByVal cat_codigo As Integer, ByVal est_codigo As Integer, com_precio As Double) As Integer
        Dim sql As String = "UPDATE Combo SET "
        sql = sql + "com_denom = '" + com_denom + "', "
        sql = sql + "cat_codigo = " + cat_codigo.ToString + ", "
        sql = sql + "est_codigo = " + est_codigo.ToString + ", "
        sql = sql + "com_precio = " + com_precio.ToString + " "
        sql = sql + "WHERE com_codigo = " + com_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function deleteCombo(ByVal com_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Combo SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE com_codigo = " + com_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

End Class
