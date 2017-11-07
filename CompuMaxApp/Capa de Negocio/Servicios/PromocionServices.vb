Public Class PromocionServices
    Private oPromocionDAO As PromocionDAO

    Public Sub New()
        oPromocionDAO = New PromocionDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_prom_denom As ComboBox)
        oPromocionDAO.llenarComboGrupo(cmb_prom_denom)
    End Sub

    Public Function obtenerPromocion() As DataTable
        Return oPromocionDAO.getPromocion()
    End Function

    Public Function validarNombrePromocion(ByVal prom_denom As String) As Boolean
        Return oPromocionDAO.validatePromocion(prom_denom)
    End Function

    Public Function promocionInsert(ByVal prom_denom As String, ByVal prom_desc As Decimal, est_codigo As Integer) As Integer
        Return oPromocionDAO.insertPromocion(prom_denom, prom_desc, est_codigo)
    End Function

    Public Function promocionUpdate(ByVal prom_codigo As Integer, ByVal prom_denom As String, ByVal prom_desc As Decimal, est_codigo As Integer) As Integer
        Return oPromocionDAO.updatePromocion(prom_codigo, prom_denom, prom_desc, est_codigo)
    End Function

    Public Function promocionDelete(ByVal prom_codigo As Integer) As Integer
        Return oPromocionDAO.deletePromocion(prom_codigo)
    End Function
End Class
