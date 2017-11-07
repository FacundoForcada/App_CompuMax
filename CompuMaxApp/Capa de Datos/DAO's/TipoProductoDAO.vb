Public Class TipoProductoDAO
    Public Sub llenarComboGrupo(cmb_tipoProd As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_tipoProd, BDHelper.getDBHelper.ConsultaSQL("SELECT * From TipoProducto"), "tpr_denom", "tpr_codigo")
    End Sub

    Public Function getTipoProductos() As DataTable
        Dim sql As String = "SELECT tp.tpr_codigo, tp.tpr_denom FROM TipoProducto tp"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function validateTipoProducto(ByVal tpr_denom) As Boolean
        Dim sql As String = "SELECT * FROM TipoProducto tp WHERE tp.tpr_denom = '" + tpr_denom + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count
    End Function

    Public Function insertTipoProducto(ByVal tpr_denom As String) As Integer
        Dim sql As String = "INSERT TipoProducto (tpr_denom) VALUES ( "
        sql = sql + "'" + tpr_denom + "' )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateTipoProducto(ByVal tpr_codigo As Integer, ByVal tpr_denom As String) As Integer
        Dim sql As String = "UPDATE TipoProducto SET "
        sql = sql + "tpr_denom = '" + tpr_denom + "' "
        sql = sql + "WHERE tpr_codigo = " + tpr_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

End Class
