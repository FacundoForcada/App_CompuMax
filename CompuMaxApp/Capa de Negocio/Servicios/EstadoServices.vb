Public Class EstadoServices
    Private oEstadoDAO As EstadoDAO

    Public Sub New()
        oEstadoDAO = New EstadoDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_estado As ComboBox)
        oEstadoDAO.llenarComboGrupo(cmb_estado)
    End Sub
End Class
