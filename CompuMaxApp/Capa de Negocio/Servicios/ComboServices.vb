Public Class ComboServices
    Private oComboDAO As ComboDAO

    Public Sub New()
        oComboDAO = New ComboDAO
    End Sub

    Public Function obtenerReporteCombosVendidos(ByVal top As String, ByVal per_desde As String, ByVal per_hasta As String) As DataTable
        Return oComboDAO.getReporteCombosVendidos(top, per_desde, per_hasta)
    End Function

    Public Sub llenarComboFiltroCat(ByVal cmb_combo As ComboBox, ByVal categoria As String)
        oComboDAO.llenarComboFiltroCat(cmb_combo, categoria)
    End Sub

    Public Sub llenarComboGrupoCompleto(ByVal cmb_combo As ComboBox)
        oComboDAO.llenarComboGrupoCompleto(cmb_combo)
    End Sub

    Public Function obtenerCombos() As DataTable
        Return oComboDAO.getCombos()
    End Function

    Public Function obtenerComboFiltro(ByVal com_denom As String, ByVal categoria As String, ByVal cantidad As String, ByVal com_prom_codigo As String) As DataTable
        Return oComboDAO.getCombosFiltros(com_denom, categoria, cantidad, com_prom_codigo)
    End Function

    Public Function validarNombreCombo(ByVal com_denom As String) As Boolean
        Return oComboDAO.validateCombo(com_denom)
    End Function

    Public Function comboInsert(ByVal com_denom As String, cat_codigo As Integer, est_codigo As Integer, com_precio As Double) As Integer
        Return oComboDAO.insertCombo(com_denom, cat_codigo, est_codigo, com_precio)
    End Function

    Public Function comboUpdate(ByVal com_codigo As Integer, ByVal com_denom As String, cat_codigo As Integer, est_codigo As Integer, ByVal com_precio As Double) As Integer
        Return oComboDAO.updateCombo(com_codigo, com_denom, cat_codigo, est_codigo, com_precio)
    End Function

    Public Function comboDelete(ByVal com_codigo As Integer) As Integer
        Return oComboDAO.deleteCombo(com_codigo)
    End Function

End Class
