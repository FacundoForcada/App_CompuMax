Public Class PromocionDAO
    Public Sub llenarComboGrupo(cmb_prom_denom As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_prom_denom, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Promocion"), "prom_denom", "prom_codigo")
    End Sub

    Public Function getPromocion() As DataTable
        Dim sql As String = "SELECT p.prom_codigo, p.prom_denom, p.prom_desc, e.est_denom FROM Promocion p, Estado e WHERE p.est_codigo = e.est_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function validatePromocion(ByVal prom_denom) As Boolean
        Dim sql As String = "SELECT * FROM Promocion p WHERE p.prom_denom = '" + prom_denom + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count
    End Function

    Public Function insertPromocion(ByVal prom_denom As String, ByVal prom_desc As Decimal, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "INSERT promocion (prom_denom, prom_desc, est_codigo) VALUES ( "
        sql = sql + "'" + prom_denom + "', "
        sql = sql + "" + prom_desc.ToString + ", "
        sql = sql + "" + est_codigo.ToString + " )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updatePromocion(ByVal prom_codigo As Integer, ByVal prom_denom As String, ByVal prom_desc As Decimal, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "UPDATE promocion SET "
        sql = sql + "prom_denom = '" + prom_denom + "', "
        sql = sql + "prom_desc = " + prom_desc.ToString + ", "
        sql = sql + "est_codigo = " + est_codigo.ToString + " "
        sql = sql + "WHERE prom_codigo = " + prom_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function deletePromocion(ByVal prom_codigo As Integer) As Integer
        Dim sql As String = "UPDATE promocion SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE prom_codigo = " + prom_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function
End Class
