Public Class TipoProductoServices
    Private oTipoProdDAO As TipoProductoDAO

    Public Sub New()
        oTipoProdDAO = New TipoProductoDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_tipoProd As ComboBox)
        oTipoProdDAO.llenarComboGrupo(cmb_tipoProd)
    End Sub

    Public Function obtenerTipoProductos() As DataTable
        Return oTipoProdDAO.getTipoProductos()
    End Function

    Public Function validarNombreTipoProducto(ByVal tpr_denom As String) As Boolean
        Return oTipoProdDAO.validateTipoProducto(tpr_denom)
    End Function

    Public Function tipoProductoInsert(ByVal tpr_denom As String) As Integer
        Return oTipoProdDAO.insertTipoProducto(tpr_denom)
    End Function

    Public Function tipoProductoUpdate(ByVal tpr_codigo As Integer, ByVal tpr_denom As String) As Integer
        Return oTipoProdDAO.updateTipoProducto(tpr_codigo, tpr_denom)
    End Function

End Class
