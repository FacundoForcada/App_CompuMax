Public Class TipoDocumentoServices
    Private oTipoDocumentoDAO As TipoDocumentoDAO

    Public Sub New()
        oTipoDocumentoDAO = New TipoDocumentoDAO
    End Sub

    Public Sub llenarComboGrupo(ByVal cmb_tipoDoc As ComboBox)
        oTipoDocumentoDAO.llenarComboGrupo(cmb_tipoDoc)
    End Sub

    Public Function obtenerTipoDocumentos() As DataTable
        Return oTipoDocumentoDAO.getTipoDocumentos()
    End Function

    Public Function validarNombreTipoDocumento(ByVal tdc_denom As String) As Boolean
        Return oTipoDocumentoDAO.validateTipoDocumento(tdc_denom)
    End Function

    Public Function getLastTipoDocumentoID() As Integer
        Return oTipoDocumentoDAO.getLastID()
    End Function

    Public Function tipoDocumentoInsert(ByVal tdc_codigo As Integer, ByVal tdc_denom As String) As Integer
        Return oTipoDocumentoDAO.insertTipoDocumento(tdc_codigo, tdc_denom)
    End Function

    Public Function tipoDocumentoUpdate(ByVal tdc_codigo As Integer, ByVal tdc_denom As String) As Integer
        Return oTipoDocumentoDAO.updateTipoDocumento(tdc_codigo, tdc_denom)
    End Function
End Class
