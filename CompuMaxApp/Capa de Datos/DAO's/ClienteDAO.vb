Public Class ClienteDAO
    Public Function getClientes(ByVal txt_nombre As String, ByVal txt_apellido As String, ByVal txt_nro_doc As String, ByVal cmb_tipo_doc As String, ByVal chkTodos As Integer) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT c.cli_codigo,c.cli_nombre, c.cli_apellido , c.cli_cuit, c.tdc_codigo, td.tdc_denom, c.cli_numdoc, c.cli_telefono, c.cli_mail, c.est_codigo "
        sql = sql + "FROM Cliente c, TipoDocumento td "
        sql = sql + "WHERE c.tdc_codigo = td.tdc_codigo AND c.est_codigo = 1 "
        If chkTodos = 0 Then
            If txt_nombre <> String.Empty Then
                sql = sql + "AND c.cli_nombre LIKE '%" + txt_nombre + "%' "
            End If
            If txt_apellido <> String.Empty Then
                sql = sql + "AND c.cli_apellido LIKE '%" + txt_apellido + "%' "
            End If
            If txt_nro_doc <> String.Empty Then
                sql = sql + "AND c.cli_numdoc = '" + txt_nro_doc + "' "
            End If
            If cmb_tipo_doc <> String.Empty Then
                sql = sql + "AND c.tdc_codigo = '" + cmb_tipo_doc + "' "
            End If
        End If
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function
    Public Function existeIdCliente(ByVal txt_codigo As String) As Boolean
        Dim sql As String = "Select c.cli_codigo From Cliente c Where cli_codigo = '" + txt_codigo + "' "
        Dim oTabla As DataTable = BDHelper.getDBHelper.ConsultaSQL(sql)
        If oTabla.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function insertCliente(ByVal cli_nombre As String, ByVal cli_apellido As String, ByVal cli_cuit As String, ByVal tdc_codigo As String, ByVal cli_numdoc As String, ByVal cli_telefono As String, ByVal cli_mail As String) As Boolean
        Dim sql As String = "INSERT cliente (cli_nombre,cli_apellido,cli_cuit,tdc_codigo,cli_numdoc,cli_telefono,cli_mail,est_codigo) "
        sql = sql + "VALUES ( "
        sql = sql + "'" + cli_nombre + "'"
        sql = sql + ", '" + cli_apellido + "'"
        sql = sql + ", " + cli_cuit + ""
        sql = sql + ", " + tdc_codigo + ""
        sql = sql + ", " + cli_numdoc + ""
        If cli_telefono <> String.Empty Then
            sql = sql + ", " + cli_telefono + ""
        Else
            sql = sql + ", NULL "
        End If
        If cli_mail <> String.Empty Then
            sql = sql + ", '" + cli_mail + "'"
        Else
            sql = sql + ", NULL "
        End If
        sql = sql + ", 1 )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
    End Function
    Public Function updateCliente(ByRef cli_codigo As String, ByVal cli_nombre As String, ByVal cli_apellido As String, ByVal cli_cuit As String, ByVal tdc_codigo As String, ByVal cli_numdoc As String, ByVal cli_telefono As String, ByVal cli_mail As String) As Boolean
        Dim sql As String = "UPDATE cliente SET "
        sql = sql + "cli_nombre = '" + cli_nombre + "'"
        sql = sql + ", cli_apellido = '" + cli_apellido + "'"
        sql = sql + ", cli_cuit = " + cli_cuit + ""
        sql = sql + ", tdc_codigo = " + tdc_codigo + ""
        sql = sql + ", cli_numdoc = " + cli_numdoc + ""
        sql = sql + ", cli_telefono = '" + cli_telefono + "'"
        sql = sql + ", cli_mail = '" + cli_mail + "'"
        sql = sql + " WHERE cli_codigo = " + cli_codigo
        Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
    End Function
    Public Function deleteCliente(ByVal cli_codigo As String) As Boolean
        Dim sql As String = "UPDATE Cliente SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE cli_codigo = " + cli_codigo
        Return BDHelper.getDBHelper.EjecutarSQL(sql) > 0
    End Function

    Public Function getClientesConProcAlmac(ByVal cod_desde As Integer, ByVal cod_hasta As Integer) As DataTable
        Dim sql As String = "ReporteClientes"
        sql += " '" + cod_desde.ToString + "','" + cod_hasta.ToString + "'"
        Return BDHelper.getDBHelper.EjecutarProcedimientoAlmacenado(sql)
    End Function

    Public Function getClientesReporte(ByVal cod_desde As Integer, ByVal cod_hasta As Integer, ByVal chk_inactivos As Integer) As DataTable
        Dim sWhereActivo As String
        If chk_inactivos = CheckState.Checked Then
            sWhereActivo = ""
        Else
            sWhereActivo = " AND c.est_codigo = 1"
        End If
        Dim sql As String = "select C.cli_codigo, C.cli_nombre, C.cli_apellido, TD.tdc_denom, C.cli_numdoc, C.cli_cuit, C.cli_telefono, C.cli_mail, E.est_denom "
        sql = sql + " from Cliente C, TipoDocumento TD, Estado E "
        sql = sql + " where C.tdc_codigo = TD.tdc_codigo AND C.est_codigo = E.est_codigo AND C.cli_codigo BETWEEN '" + cod_desde.ToString + "' AND '" + cod_hasta.ToString + "' " + sWhereActivo + " "
        sql = sql + " order by C.cli_codigo"
        Return BDHelper.getDBHelper.EjecutarProcedimientoAlmacenado(sql)
    End Function
    Public Function getFrecuenciaDeVentas() As DataTable
        Dim sql As String = "select V.cli_codigo,V.ven_fecha,COUNT(V.ven_codigo) As cantidad from Venta V, Cliente C where V.cli_codigo = C.cli_codigo group by V.cli_codigo,V.ven_fecha order by cli_codigo"
        Return BDHelper.getDBHelper.EjecutarProcedimientoAlmacenado(sql)
    End Function
End Class
