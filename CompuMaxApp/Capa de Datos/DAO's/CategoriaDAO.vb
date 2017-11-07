Public Class CategoriaDAO
    Public Sub llenarComboGrupo(cmb_categoria As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_categoria, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Categoria"), "cat_denom", "cat_codigo")
    End Sub

    Public Function getCategorias() As DataTable
        Dim sql As String = "SELECT c.cat_codigo, c.cat_denom, e.est_denom FROM Categoria c, estado e WHERE c.est_codigo = e.est_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function validateCategoria(ByVal cat_denom) As Boolean
        Dim sql As String = "SELECT * FROM categoria c WHERE c.cat_denom = '" + cat_denom + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count
    End Function

    Public Function insertCategoria(ByVal cat_denom As String, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "INSERT categoria (cat_denom, est_codigo) VALUES ( "
        sql = sql + "'" + cat_denom + "', "
        sql = sql + "" + est_codigo.ToString + " )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateCategoria(ByVal cat_codigo As Integer, ByVal cat_denom As String, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "UPDATE categoria SET "
        sql = sql + "cat_denom = '" + cat_denom + "', "
        sql = sql + "est_codigo = " + est_codigo.ToString + " "
        sql = sql + "WHERE cat_codigo = " + cat_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function deleteCategoria(ByVal cat_codigo As Integer) As Integer
        Dim sql As String = "UPDATE categoria SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE cat_codigo = " + cat_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

End Class
