Public Class MarcaServices
    Private oMarcaDAO As MarcaDAO

    Public Sub New()
        oMarcaDAO = New MarcaDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_marca As ComboBox)
        oMarcaDAO.llenarComboGrupo(cmb_marca)
    End Sub

    Public Function obtenerMarcas() As DataTable
        Return oMarcaDAO.getMarcas()
    End Function

    Public Function validarNombreMarca(ByVal mar_denom As String) As Boolean
        Return oMarcaDAO.validateMarca(mar_denom)
    End Function

    Public Function marcaInsert(ByVal mar_denom As String, est_codigo As Integer) As Integer
        Return oMarcaDAO.insertMarca(mar_denom, est_codigo)
    End Function

    Public Function marcaUpdate(ByVal mar_codigo As Integer, ByVal mar_denom As String, est_codigo As Integer) As Integer
        Return oMarcaDAO.updateMarca(mar_codigo, mar_denom, est_codigo)
    End Function

    Public Function marcaDelete(ByVal mar_codigo As Integer) As Integer
        Return oMarcaDAO.deleteMarca(mar_codigo)
    End Function
End Class
