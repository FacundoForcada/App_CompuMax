Public Class GrupoUsuarioDAO
    Public Function obtenerUsuariosXGrupo(ByVal grp_codigo As String) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT gu.grp_codigo, gu.usu_codigo, gu.est_codigo , u.usu_usuario, u.usu_nmbcompleto "
        sql = sql + "FROM GrupoUsuario gu, usuario u "
        sql = sql + "WHERE gu.usu_codigo = u.usu_codigo AND gu.est_codigo = 1 AND gu.grp_codigo = " + grp_codigo
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function
    Public Function insertGrupoUsuario(ByVal grp_codigo As String, ByVal usu_codigo As String) As Boolean
        If deleteGrupoUsuarioFisico(usu_codigo) Then
            Dim sql As String = "INSERT GrupoUsuario (grp_codigo,usu_codigo,est_codigo) "
            sql = sql + "VALUES ( "
            sql = sql + "" + grp_codigo + ", "
            sql = sql + "" + usu_codigo + ", "
            sql = sql + "1)"
            Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
        Else
            Return False
        End If
    End Function
    Private Function deleteGrupoUsuarioFisico(ByVal usu_codigo As String) As Boolean
        Dim sql As String = "DELETE FROM GrupoUsuario "
        sql = sql + "WHERE usu_codigo = " + usu_codigo
        Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
    End Function
    Public Function deleteGrupoUsuario(ByVal usu_codigo As String) As Boolean
        Dim sql As String = "Update GrupoUsuario SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE usu_codigo = " + usu_codigo
        Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
       
    End Function

End Class
