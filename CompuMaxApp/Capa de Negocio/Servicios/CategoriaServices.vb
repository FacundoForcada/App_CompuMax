Public Class CategoriaServices
    Private oCategoriaDAO As CategoriaDAO

    Public Sub New()
        oCategoriaDAO = New CategoriaDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_categoria As ComboBox)
        oCategoriaDAO.llenarComboGrupo(cmb_categoria)
    End Sub

    Public Function obtenerCategorias() As DataTable
        Return oCategoriaDAO.getCategorias()
    End Function

    Public Function validarNombreCategoria(ByVal cat_denom As String) As Boolean
        Return oCategoriaDAO.validateCategoria(cat_denom)
    End Function

    Public Function categoriaInsert(ByVal cat_denom As String, est_codigo As Integer) As Integer
        Return oCategoriaDAO.insertCategoria(cat_denom, est_codigo)
    End Function

    Public Function categoriaUpdate(ByVal cat_codigo As Integer, ByVal cat_denom As String, est_codigo As Integer) As Integer
        Return oCategoriaDAO.updateCategoria(cat_codigo, cat_denom, est_codigo)
    End Function

    Public Function categoriaDelete(ByVal cat_codigo As Integer) As Integer
        Return oCategoriaDAO.deleteCategoria(cat_codigo)
    End Function
End Class
