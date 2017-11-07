Public Class TipoDocumentoDAO
    Public Sub llenarComboGrupo(cmb_tipoDoc As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_tipoDoc, BDHelper.getDBHelper.ConsultaSQL("SELECT * From TipoDocumento"), "tdc_denom", "tdc_codigo")
    End Sub

    Public Function getTipoDocumentos() As DataTable
        Dim sql As String = "SELECT td.tdc_codigo, td.tdc_denom FROM TipoDocumento td"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function validateTipoDocumento(ByVal tdc_denom) As Boolean
        Dim sql As String = "SELECT * FROM TipoDocumento td WHERE td.tdc_denom = '" + tdc_denom + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count
    End Function

    Public Function getLastID() As Integer
        Dim sql As String = "SELECT MAX(td.tdc_codigo) FROM TipoDocumento td"
        Dim valor = BDHelper.getDBHelper.ConsultaSQL(sql).Rows(0).Item(0)
        If valor Is DBNull.Value Then
            Return 0
        Else
            Return valor
        End If
    End Function

    Public Function insertTipoDocumento(ByVal tdc_codigo As Integer, ByVal tdc_denom As String) As Integer
        Dim sql As String = "INSERT TipoDocumento (tdc_codigo, tdc_denom) VALUES ( "
        sql = sql + "" + tdc_codigo.ToString + ", "
        sql = sql + "'" + tdc_denom + "' )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateTipoDocumento(ByVal tdc_codigo As Integer, ByVal tdc_denom As String) As Integer
        Dim sql As String = "UPDATE TipoDocumento SET "
        sql = sql + "tdc_denom = '" + tdc_denom + "' "
        sql = sql + "WHERE tdc_codigo = " + tdc_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function
End Class
