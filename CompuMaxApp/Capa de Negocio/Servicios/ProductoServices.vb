Public Class ProductoServices
    Private oProductoDAO As ProductoDAO

    Public Sub New()
        oProductoDAO = New ProductoDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_productos As ComboBox, ByVal categoria As String, ByVal tipoprod As String, ByVal marca As String)
        oProductoDAO.llenarComboGrupo(cmb_productos, categoria, tipoprod, marca)
    End Sub

    Public Function productoInsert(ByVal prod_denom As String, ByVal tipoProd As Integer, ByVal marca As Integer, ByVal prod_numserie As String, ByVal prod_precio As Double, ByVal categoria As Integer) As Integer
        Return oProductoDAO.insertProducto(prod_denom, tipoProd, marca, prod_numserie, prod_precio, categoria)
    End Function

    Public Function productoUpdate(ByVal prod_codigo As Integer, ByVal prod_denom As String, ByVal tipoProd As Integer, ByVal marca As Integer, ByVal prod_numserie As String, ByVal prod_precio As Double, ByVal categoria As Integer) As Integer
        Return oProductoDAO.updateProducto(prod_codigo, prod_denom, tipoProd, marca, prod_numserie, prod_precio, categoria)
    End Function

    Public Function productoDelete(ByVal prod_codigo As Integer) As Integer
        Return oProductoDAO.deleteProducto(prod_codigo)
    End Function

    Public Function obtenerProductos(ByVal prod_denom As String, ByVal tipoProd As String, ByVal marca As String, ByVal categoria As String, ByVal checkTodos As Integer) As DataTable
        Return oProductoDAO.getProductos(prod_denom, tipoProd, marca, categoria, checkTodos)
    End Function

    Public Function obtenerProductosFiltro(ByVal prod_denom As String, ByVal tipoProd As String, ByVal marca As String, ByVal categoria As String, ByVal cantidad As String, ByVal prom_codigo As String) As DataTable
        Return oProductoDAO.getProductosFiltered(prod_denom, tipoProd, marca, categoria, cantidad, prom_codigo)
    End Function

    Public Function validarNombreProducto(ByVal prod_denom As String) As Boolean
        Return oProductoDAO.validateProducto(prod_denom)
    End Function

    Public Function obtenerProductoYMarca(ByVal combo_codigo As String, ByVal prod_denom As String, ByVal chktodos As Integer) As DataTable
        Return oProductoDAO.getProductoYMarca(combo_codigo, prod_denom, chktodos)
    End Function

    Public Function obtenerReporteProductosVendidos(ByVal prod_desde As Integer, ByVal prod_hasta As Integer, ByVal ven_fecha_desde As String, ByVal ven_fecha_hasta As String, ByVal tpr_codigo As Integer, ByVal cat_codigo As Integer, ByVal mar_codigo As Integer, ByVal all_tpr As Integer, ByVal all_cat As Integer, ByVal all_mar As Integer) As DataTable
        Return oProductoDAO.getReporteProductosVendidos(prod_desde, prod_hasta, ven_fecha_desde, ven_fecha_hasta, tpr_codigo, cat_codigo, mar_codigo, all_tpr, all_cat, all_mar)
    End Function

    Public Function obtenerReporteProductosVendidosAgrupado(ByVal prod_desde As Integer, ByVal prod_hasta As Integer, ByVal ven_fecha_desde As String, ByVal ven_fecha_hasta As String, ByVal tpr_codigo As Integer, ByVal cat_codigo As Integer, ByVal mar_codigo As Integer, ByVal all_tpr As Integer, ByVal all_cat As Integer, ByVal all_mar As Integer) As DataTable
        Return oProductoDAO.getReporteProductosVendidosAgrupado(prod_desde, prod_hasta, ven_fecha_desde, ven_fecha_hasta, tpr_codigo, cat_codigo, mar_codigo, all_tpr, all_cat, all_mar)
    End Function

End Class
