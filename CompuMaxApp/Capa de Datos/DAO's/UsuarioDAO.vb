Public Class UsuarioDAO
    Public Function getUserByNamePass(ByVal nombre As String, ByVal password As String) As Usuario
        Dim sql As String = "SELECT u.*, g.grp_denom as grupo_usuario from Usuario u, Grupo g, GrupoUsuario gu "
        sql += "WHERE u.usu_codigo = gu.usu_codigo AND g.grp_codigo = gu.grp_codigo "
        sql += "AND u.usu_usuario = '" + nombre + "' AND u.usu_clave = '" + password + "'"
        Dim oTabla As DataTable
        Dim oUsuario As Usuario = Nothing

        oTabla = BDHelper.getDBHelper.ConsultaSQL(Sql)
        If oTabla.Rows.Count Then
            oUsuario = New Usuario
            oUsuario.usu_codigo = Convert.ToInt32(oTabla.Rows(0).Item("usu_codigo").ToString)
            oUsuario.usu_usuario = oTabla.Rows(0).Item("usu_usuario").ToString
            oUsuario.usu_clave = oTabla.Rows(0).Item("usu_clave").ToString
            oUsuario.usu_mail = oTabla.Rows(0).Item("usu_mail").ToString
            oUsuario.usu_nombreCompleto = oTabla.Rows(0).Item("usu_nmbcompleto").ToString
            oUsuario.estado = oTabla.Rows(0).Item("est_codigo").ToString
            oUsuario.grupo = oTabla.Rows(0).Item("grupo_usuario").ToString
        End If
        Return oUsuario
    End Function

    Public Function getNombreUsuarioAndGrupo(ByVal usuario As Usuario) As String
        Dim sRetorno As String
        sRetorno = " Usuario: " + usuario.usu_nombreCompleto + " | Grupo: " + usuario.grupo + "."
        Return sRetorno
    End Function

    Public Function insertUsuario(ByVal usu_usuario As String, usu_clave As String, usu_nombreCompleto As String, usu_mail As String, grupo As Integer) As Integer
        Dim sql As String = "INSERT Usuario (usu_usuario,usu_clave,usu_nmbcompleto,usu_mail,est_codigo) "
        sql = sql + "VALUES (  '" + usu_usuario + "'"
        sql = sql + ", '" + usu_clave + "'"
        sql = sql + ", '" + usu_nombreCompleto + "'"
        sql = sql + ", '" + usu_mail + "'"
        sql = sql + ", 1 )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateUsuario(ByVal usu_codigo As Integer, ByVal usu_usuario As String, usu_clave As String, usu_nombreCompleto As String, usu_mail As String, grupo As Integer) As Integer
        Dim sql As String = "UPDATE Usuario SET "
        sql = sql + "usu_usuario = '" + usu_usuario + "', "
        sql = sql + "usu_clave = '" + usu_clave + "', "
        sql = sql + "usu_nmbcompleto = '" + usu_nombreCompleto + "', "
        sql = sql + "usu_mail = '" + usu_mail + "' "
        sql = sql + "WHERE usu_codigo = " + usu_codigo.ToString
        If BDHelper.getDBHelper.EjecutarSQL(sql) > 0 Then
            Dim sqlgrupo As String = "UPDATE GrupoUsuario SET "
            sqlgrupo = sqlgrupo + "grp_codigo = " + grupo.ToString + " "
            sqlgrupo = sqlgrupo + "WHERE usu_codigo = " + usu_codigo.ToString + ""
            Return BDHelper.getDBHelper.EjecutarSQL(sqlgrupo)
        Else
            Return 0
        End If
    End Function

    Public Function deleteUsuario(ByVal usu_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Usuario SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE usu_codigo = " + usu_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function getUsuarios(ByVal usu_usuario As String, grupo As String, chkTodos As Integer) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT u.usu_codigo, u.usu_usuario, u.usu_nmbcompleto, u.usu_mail, g.grp_denom, u.est_codigo, u.usu_clave "
        sql = sql + "FROM usuario u, grupo g, grupousuario gu "
        sql = sql + "WHERE u.usu_codigo = gu.usu_codigo AND g.grp_codigo = gu.grp_codigo "
        If chkTodos = 0 Then
            If grupo = String.Empty Then
                sql = sql + "AND u.usu_usuario LIKE '%" + usu_usuario.ToString + "%'"
            Else
                sql = sql + "AND g.grp_denom = '" + grupo.ToString + "' AND u.usu_usuario LIKE '%" + usu_usuario.ToString + "%'"
            End If
        End If
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function
    Public Function getUsuYNombre(ByVal usu_usuario As String, ByVal chkTodos As Integer) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT u.usu_codigo, u.usu_usuario, u.usu_nmbcompleto"
        sql = sql + " FROM usuario u"
        sql = sql + " WHERE 1 = 1 "
        If chkTodos = 0 Then
            sql = sql + "AND u.usu_usuario LIKE '%" + usu_usuario.ToString + "%'"
        End If
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function

    Public Function validateUsuario(ByVal usu_usuario As String) As Boolean
        Dim sql As String = "SELECT * FROM Usuario u WHERE u.usu_usuario = '" + usu_usuario.ToString + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count > 0
    End Function
End Class
