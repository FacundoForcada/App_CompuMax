Public Class GrupoServices
    Private oGrupoDao As GrupoDAO

    Public Sub New()
        oGrupoDao = New GrupoDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_grupo As ComboBox)
        oGrupoDao.llenarComboGrupo(cmb_grupo)
    End Sub
    Public Sub llenarComboGrupoSoloActivos(ByVal cmb_grupo As ComboBox)
        oGrupoDao.llenarComboGrupo(cmb_grupo)
    End Sub

    Public Function obtenerGrupos() As DataTable
        Return oGrupoDao.getGrupos()
    End Function

    Public Function validarNombreGrupo(ByVal grp_denom As String) As Boolean
        Return oGrupoDao.validateGrupo(grp_denom)
    End Function

    Public Function grupoInsert(ByVal grp_denom As String, est_codigo As Integer) As Integer
        Return oGrupoDao.insertGrupo(grp_denom, est_codigo)
    End Function

    Public Function grupoUpdate(ByVal grp_codigo As Integer, ByVal grp_denom As String, est_codigo As Integer) As Integer
        Return oGrupoDao.updateGrupo(grp_codigo, grp_denom, est_codigo)
    End Function

    Public Function grupoDelete(ByVal grp_codigo As Integer) As Integer
        Return oGrupoDao.deleteGrupo(grp_codigo)
    End Function

End Class
