Public Class ClienteServices
    Private oClienteDAO As New ClienteDAO
    Public Function obtenerClientes(ByVal txt_nombre As String, ByVal txt_apellido As String, ByVal txt_nro_doc As String, ByVal cmb_tipo_doc As String, ByVal nStateChk As Integer) As DataTable
        Return oClienteDAO.getClientes(txt_nombre, txt_apellido, txt_nro_doc, cmb_tipo_doc, nStateChk)
    End Function
    Public Function validarIdCliente(ByVal txt_codigo As String) As Boolean
        Return oClienteDAO.existeIdCliente(txt_codigo)
    End Function
    Public Function insertCliente(ByVal cli_nombre As String, ByVal cli_apellido As String, ByVal cli_cuit As String, ByVal tdc_codigo As String, ByVal cli_numdoc As String, ByVal cli_telefono As String, ByVal cli_mail As String) As Boolean
        Return oClienteDAO.insertCliente(cli_nombre, cli_apellido, cli_cuit, tdc_codigo, cli_numdoc, cli_telefono, cli_mail)
    End Function
    Public Function updateCliente(ByVal cli_codigo As String, ByVal cli_nombre As String, ByVal cli_apellido As String, ByVal cli_cuit As String, ByVal tdc_codigo As String, ByVal cli_numdoc As String, ByVal cli_telefono As String, ByVal cli_mail As String) As Boolean
        Return oClienteDAO.updateCliente(cli_codigo, cli_nombre, cli_apellido, cli_cuit, tdc_codigo, cli_numdoc, cli_telefono, cli_mail)
    End Function
    Public Function deleteCliente(ByVal cli_codigo As String) As Boolean
        Return oClienteDAO.deleteCliente(cli_codigo)
    End Function

    Public Function obtenerReporteClientes(ByVal cod_desde As Integer, cod_hasta As Integer) As DataTable
        Return oClienteDAO.getClientesConProcAlmac(cod_desde, cod_hasta)
    End Function

    Public Function obtenerFrecuenciaDeVentas() As DataTable
        Return oClienteDAO.getFrecuenciaDeVentas()
    End Function

    Public Function obtenerReporteClientesSinPA(ByVal cod_desde As Integer, cod_hasta As Integer, chk_inactivos As Integer) As DataTable
        Return oClienteDAO.getClientesReporte(cod_desde, cod_hasta, chk_inactivos)
    End Function

End Class
