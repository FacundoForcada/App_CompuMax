Public Class ProveedorServices
    Private oProveedorDAO As ProveedorDAO

    Public Sub New()
        oProveedorDAO = New ProveedorDAO
    End Sub

    Public Function insertProveedor(ByVal prov_denom As String, ByVal prov_cuit As Long) As Integer
        Return oProveedorDAO.insertProveedor(prov_denom, prov_cuit)
    End Function

    Public Function updateProveedor(ByVal prov_codigo As Integer, ByVal prov_denom As String, ByVal prov_cuit As Long) As Integer
        Return oProveedorDAO.updateProveedor(prov_codigo, prov_denom, prov_cuit)
    End Function

    Public Function deleteProveedor(ByVal prov_codigo As Integer) As Integer
        Return oProveedorDAO.deleteProveedor(prov_codigo)
    End Function

    Public Function obtenerProveedor(ByVal prov_denom As String, ByVal prov_cuit As Long, ByVal checkTodos As Integer) As DataTable
        Return oProveedorDAO.getProveedores(prov_denom, prov_cuit, checkTodos)
    End Function

    Public Function validarNombreProveedor(ByVal prov_denom As String) As Boolean
        Return oProveedorDAO.validateProveedor(prov_denom)
    End Function

    Public Function validarCUITProveedor(ByVal prov_cuit As Long) As Boolean
        Return oProveedorDAO.validateCUITProveedor(prov_cuit)
    End Function

    Public Function obtenerReporteProveedores(ByVal cod_desde As String, ByVal cod_hasta As String, ByVal chk_inactivos As Integer) As DataTable
        Return oProveedorDAO.getReporteProveedores(cod_desde, cod_hasta, chk_inactivos)
    End Function

End Class
