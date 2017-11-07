Public Class GrupoDAO
    Public Sub llenarComboGrupo(cmb_grupo As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_grupo, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Grupo WHERE grp_codigo <> 0"), "grp_denom", "grp_codigo")
    End Sub
    Public Sub llenarComboGrupoSoloActivos(cmb_grupo As ComboBox)
        BDHelper.getDBHelper.llenarCombo(cmb_grupo, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Grupo WHERE grp_codigo <> 0 AND est_codigo <> 2"), "grp_denom", "grp_codigo")
    End Sub

    Public Function getGrupos() As DataTable
        Dim sql As String = "SELECT g.grp_codigo, g.grp_denom, e.est_denom FROM Grupo g, estado e WHERE g.est_codigo = e.est_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function validateGrupo(ByVal grp_denom) As Boolean
        Dim sql As String = "SELECT * FROM Grupo g WHERE g.grp_denom = '" + grp_denom + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count
    End Function

    Public Function insertGrupo(ByVal grp_denom As String, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "INSERT Grupo (grp_denom, est_codigo) VALUES ( "
        sql = sql + "'" + grp_denom + "', "
        sql = sql + "" + est_codigo.ToString + " )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateGrupo(ByVal grp_codigo As Integer, ByVal grp_denom As String, ByVal est_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Grupo SET "
        sql = sql + "grp_denom = '" + grp_denom + "', "
        sql = sql + "est_codigo = " + est_codigo.ToString + " "
        sql = sql + "WHERE grp_codigo = " + grp_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function deleteGrupo(ByVal grp_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Grupo SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE grp_codigo = " + grp_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function
End Class
