Public Class UsuarioServices
    Private oUsuarioDao As UsuarioDAO

    Public Sub New()
        oUsuarioDao = New UsuarioDao
    End Sub

    Public Function validarUsuario(ByVal nombre As String, ByVal password As String) As Usuario
        Return oUsuarioDao.getUserByNamePass(nombre, password)
    End Function
    Public Function obtenerUsuYnombre(ByRef usu_usuario As String, ByVal checkTodos As Integer) As DataTable
        Return oUsuarioDao.getUsuYNombre(usu_usuario, checkTodos)
    End Function
    Public Function obtenerNombreYGrupoUsuario(ByVal usuario As Usuario) As String
        Return oUsuarioDao.getNombreUsuarioAndGrupo(usuario)
    End Function

    Public Function usuarioInsert(ByVal usu_usuario As String, usu_clave As String, usu_nombreCompleto As String, usu_mail As String, grupo As Integer) As Integer
        Return oUsuarioDao.insertUsuario(usu_usuario, usu_clave, usu_nombreCompleto, usu_mail, grupo)
    End Function

    Public Function usuarioUpdate(ByVal usu_codigo As Integer, ByVal usu_usuario As String, usu_clave As String, usu_nombreCompleto As String, usu_mail As String, grupo As Integer) As Integer
        Return oUsuarioDao.updateUsuario(usu_codigo, usu_usuario, usu_clave, usu_nombreCompleto, usu_mail, grupo)
    End Function

    Public Function usuarioDelete(ByVal usu_codigo As Integer) As Integer
        Return oUsuarioDao.deleteUsuario(usu_codigo)
    End Function

    Public Function obtenerUsuarios(ByVal usu_usuario As String, grupo As String, checkTodos As Integer) As DataTable
        Return oUsuarioDao.getUsuarios(usu_usuario, grupo, checkTodos)
    End Function

    Public Function validarNombreUsuario(ByVal usu_usuario As String) As Boolean
        Return oUsuarioDao.validateUsuario(usu_usuario)
    End Function
End Class
