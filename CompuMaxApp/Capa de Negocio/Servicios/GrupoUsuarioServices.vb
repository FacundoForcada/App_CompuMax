Public Class GrupoUsuarioServices
    Dim oGrupoUsuarioDAO As New GrupoUsuarioDAO
    Public Function obtenerUsuariosXGrupo(ByVal grp_codigo As String) As DataTable
        Return oGrupoUsuarioDAO.obtenerUsuariosXGrupo(grp_codigo)
    End Function

    Public Function agregarUsuario(ByVal grp_codigo As String, ByVal usu_codigo As String) As Boolean
        Return oGrupoUsuarioDAO.insertGrupoUsuario(grp_codigo, usu_codigo)
    End Function

    Public Function quitarUsuario(ByVal usu_codigo As String) As Boolean
        Return oGrupoUsuarioDAO.deleteGrupoUsuario(usu_codigo)
    End Function




End Class
