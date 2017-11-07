Public Class VentaServices
    Private oVentaDAO As VentaDAO

    Public Sub New()
        oVentaDAO = New VentaDAO
    End Sub

    Public Function realizarVenta(ByVal cli_codigo As String, ByVal fecha As String, ByVal dgv_combos_listado As DataGridView, ByVal dgv_productos As DataGridView) As Integer
        Dim oVentaDetCombServices As New VentaDetComboServices
        Dim oVentaDetProdServices As New VentaDetProductoServices
        fecha = DateTime.Now.ToString("dd/MM/yyyy")
        Dim sqlCabeceraVenta = getSqlVenta(cli_codigo, DateTime.Now.ToString("dd/MM/yyyy"))
        'Dim ven_codigo As String = getCodigoProximaVenta()
        Dim sqlDetalleCombo As String = ""
        If dgv_combos_listado.Rows.Count <> 0 Then
            For Each row As DataGridViewRow In dgv_combos_listado.Rows
                'sqlDetalleCombo = sqlDetalleCombo + oVentaDetCombServices.getSqlVentaDetComb(ven_codigo, row.Cells("combo_codigo").Value, row.Cells("com_cantidad").Value, row.Cells("com_precio").Value, row.Cells("com_prom_codigo").Value)
                sqlDetalleCombo = sqlDetalleCombo + oVentaDetCombServices.getSqlVentaDetComb(row.Cells("combo_codigo").Value, row.Cells("com_cantidad").Value, row.Cells("com_subtotal").Value, row.Cells("com_prom_codigo").Value)
            Next
        End If
        Dim sqlDetalleProducto As String = ""
        If dgv_productos.Rows.Count <> 0 Then
            For Each row As DataGridViewRow In dgv_productos.Rows
                'sqlDetalleProducto = sqlDetalleProducto + oVentaDetProdServices.getSqlVentaDetProd(ven_codigo, row.Cells("prod_codigo").Value, row.Cells("ved_cantidad").Value, row.Cells("ved_precio").Value, row.Cells("prom_codigo").Value)
                sqlDetalleProducto = sqlDetalleProducto + oVentaDetProdServices.getSqlVentaDetProd(row.Cells("prod_codigo").Value, row.Cells("ved_cantidad").Value, row.Cells("subtotal").Value, row.Cells("prom_codigo").Value)
            Next
        End If

        Dim sql As String = sqlCabeceraVenta + sqlDetalleCombo + sqlDetalleProducto
        Dim nRetorno As Integer = transactVenta(sql)
        Return nRetorno
    End Function

    Public Function getSqlVenta(ByVal cli_codigo As String, ByVal fecha As DateTime) As String
        Return oVentaDAO.getSqlVenta(cli_codigo, fecha)
    End Function

    Public Function transactVenta(ByVal sql) As Integer
        Return oVentaDAO.transactVenta(sql)
    End Function

    'Public Function getCodigoProximaVenta() As String
    '    Return oVentaDAO.getLastID().ToString
    'End Function
    Public Function obtenerReporteVentasXPeriodo(ByVal per_desde As String, ByVal per_hasta As String) As DataTable
        Return oVentaDAO.getReporteVentasXPeriodo(per_desde, per_hasta)
    End Function

    Public Function getInsertedVenta() As Integer
        Return oVentaDAO.getInsertedVenta()
    End Function
End Class
