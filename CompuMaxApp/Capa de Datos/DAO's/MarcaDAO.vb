Public Class MarcaDAO
    Public Sub llenarComboGrupo(cmb_marca As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_marca, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Marca"), "mar_denom", "mar_codigo")
    End Sub

    Public Function getMarcas() As DataTable
        Dim sql As String = "SELECT m.mar_codigo, m.mar_denom, e.est_denom FROM marca m, estado e WHERE m.est_codigo = e.est_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function validateMarca(ByVal mar_denom) As Boolean
        Dim sql As String = "SELECT * FROM marca m WHERE m.mar_denom = '" + mar_denom + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count
    End Function

    Public Function insertMarca(ByVal mar_denom As String, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "INSERT Marca (mar_denom, est_codigo) VALUES ( "
        sql = sql + "'" + mar_denom + "', "
        sql = sql + "" + est_codigo.ToString + " )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateMarca(ByVal mar_codigo As Integer, ByVal mar_denom As String, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Marca SET "
        sql = sql + "mar_denom = '" + mar_denom + "', "
        sql = sql + "est_codigo = " + est_codigo.ToString + " "
        sql = sql + "WHERE mar_codigo = " + mar_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function deleteMarca(ByVal mar_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Marca SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE mar_codigo = " + mar_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

End Class
