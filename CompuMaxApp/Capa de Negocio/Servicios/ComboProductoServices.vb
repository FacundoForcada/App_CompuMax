Public Class ComboProductoServices
    Dim oComboProductoDAO As New ComboProductoDAO
    Public Function obtenerProductosXCombo(ByVal combo_denom As String) As DataTable
        Return oComboProductoDAO.obtenerProductosXCombo(combo_denom)
    End Function

    Public Function obtenerProductosXComboFiltro(ByVal combo_denom As String, ByVal categoria As String, ByVal cantidad As String) As DataTable
        Return oComboProductoDAO.obtenerProductosXComboFiltered(combo_denom, categoria, cantidad)
    End Function

    Public Function agregarProducto(ByVal com_codigo As String, ByVal prod_codigo As String, ByVal cmp_cantprod As Integer) As Boolean
        Return oComboProductoDAO.insertComboProducto(com_codigo, prod_codigo, cmp_cantprod)
    End Function

    Public Function quitarProducto(ByVal prod_codigo As Integer, ByVal com_codigo As Integer) As Boolean
        Return oComboProductoDAO.deleteComboProducto(prod_codigo, com_codigo)
    End Function

End Class
