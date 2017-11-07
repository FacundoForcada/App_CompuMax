Public Class ProveedorDAO
    Public Function getProveedores(ByVal prov_denom As String, prov_cuit As Long, chkTodos As Integer) As DataTable
        Dim oTabla As DataTable = Nothing
        Dim sql As String = "SELECT p.prov_codigo, p.prov_denom, p.prov_cuit, e.est_denom"
        sql = sql + " FROM Proveedor p JOIN Estado e ON e.est_codigo = p.est_codigo"
        If chkTodos = 0 Then
            If prov_cuit = 0 And Not prov_denom = String.Empty Then
                sql = sql + " AND p.prov_denom LIKE '%" + prov_denom.ToString + "%'"
            Else
                If Not prov_cuit = 0 And prov_denom = String.Empty Then
                    sql = sql + " AND p.prov_cuit = " + prov_cuit.ToString + ""
                Else
                    sql = sql + " AND p.prov_cuit = " + prov_cuit.ToString + " AND p.prov_denom LIKE '%" + prov_denom.ToString + "%'"
                End If
            End If
        End If
        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        Return oTabla
    End Function

    Public Function getReporteProveedores(ByVal cod_desde As String, cod_hasta As String, chk_inactivos As Integer) As DataTable
        Dim sWhereEstado As String
        If chk_inactivos = CheckState.Checked Then
            sWhereEstado = ""
        Else
            sWhereEstado = " AND p.est_codigo = 1 "
        End If
        Dim sql As String = "select P.prov_codigo, P.prov_denom, P.prov_cuit, E.est_denom "
        sql = sql + " from Proveedor P, Estado E "
        sql = sql + " where P.est_codigo = E.est_codigo "
        sql = sql + sWhereEstado + " "
        sql = sql + " order by P.prov_codigo"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function

    Public Function insertProveedor(ByVal prov_denom As String, ByVal prov_cuit As Long) As Integer
        Dim sql As String = "INSERT Proveedor (prov_denom,prov_cuit,est_codigo) "
        sql = sql + "VALUES ( '" + prov_denom + "'"
        sql = sql + ", " + prov_cuit.ToString + ""
        sql = sql + ", 1 )"
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function updateProveedor(ByVal prov_codigo As Integer, ByVal prov_denom As String, ByVal prov_cuit As Long) As Integer
        Dim sql As String = "UPDATE Proveedor SET "
        sql = sql + "prov_denom = '" + prov_denom + "', "
        sql = sql + "prov_cuit = " + prov_cuit.ToString + ""
        sql = sql + "WHERE prov_codigo = " + prov_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function deleteProveedor(ByVal prov_codigo As Integer) As Integer
        Dim sql As String = "UPDATE Proveedor SET "
        sql = sql + "est_codigo = 2 "
        sql = sql + "WHERE prov_codigo = " + prov_codigo.ToString + ""
        Return BDHelper.getDBHelper.EjecutarSQL(sql)
    End Function

    Public Function validateProveedor(ByVal prov_denom As String) As Boolean
        Dim sql As String = "SELECT * FROM Proveedor p WHERE p.prov_denom = '" + prov_denom.ToString + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count > 0
    End Function

    Public Function validateCUITProveedor(ByVal prov_cuit As Long) As Boolean
        Dim sql As String = "SELECT * FROM Proveedor p WHERE p.prov_cuit = " + prov_cuit.ToString + ""
        Return BDHelper.getDBHelper.ConsultaSQL(sql).Rows.Count > 0
    End Function

End Class
