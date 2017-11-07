Public Class Frm_Reporte_Productos_Vendidos
    Dim tpr_all As Integer
    Dim cat_all As Integer
    Dim mar_all As Integer
    Dim tpr_codigo As Integer
    Dim tpr_denom As String
    Dim cat_codigo As Integer
    Dim cat_denom As String
    Dim mar_codigo As Integer
    Dim mar_denom As String
    Dim totalizado As Integer
    Dim bFlagGrafico As Boolean

    Private Sub Frm_Reporte_Productos_Vendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.ReportViewer1.RefreshReport()
        txt_prod_desde.Text = "0"
        txt_prod_hasta.Text = "9999"
        mtxt_fecha_desde.Text = Convert.ToDateTime(DateTime.Today().AddDays(-30).ToString)
        mtxt_fecha_hasta.Text = Convert.ToDateTime(DateTime.Today().ToString)
        chk_all_tpr.CheckState = CheckState.Checked
        chk_all_mar.CheckState = CheckState.Checked
        chk_all_cat.CheckState = CheckState.Checked
        chk_grafico.CheckState = CheckState.Checked
        chk_totalizado.CheckState = CheckState.Unchecked
        Me.cargar_combos()
    End Sub
    Private Sub cargar_combos()
        Dim oTipoProdServices As New TipoProductoServices
        oTipoProdServices.llenarComboGrupo(cmb_tpr)
        Dim oMarcaServices As New MarcaServices
        oMarcaServices.llenarComboGrupo(cmb_mar)
        Dim oCategoriaServices As New CategoriaServices
        oCategoriaServices.llenarComboGrupo(cmb_cat)
    End Sub
    Public Sub get_filtros()
        If chk_all_tpr.CheckState = CheckState.Checked Then
            tpr_all = "1"
            tpr_denom = ""
            tpr_codigo = "0"
        Else
            tpr_all = "0"
            tpr_denom = cmb_tpr.Text
            tpr_codigo = cmb_tpr.SelectedValue
        End If
        If chk_all_cat.CheckState = CheckState.Checked Then
            cat_all = "1"
            cat_denom = ""
            cat_codigo = "0"
        Else
            cat_all = "0"
            cat_denom = cmb_cat.Text
            cat_codigo = cmb_cat.SelectedValue
        End If
        If chk_all_mar.CheckState = CheckState.Checked Then
            mar_all = "1"
            mar_denom = ""
            mar_codigo = "0"
        Else
            mar_all = "0"
            mar_denom = cmb_mar.Text
            mar_codigo = cmb_mar.SelectedValue
        End If
        If chk_totalizado.CheckState = CheckState.Checked Then
            totalizado = 1
        Else
            totalizado = 0
        End If
    End Sub

    Private Sub chk_all_tpr_CheckedChanged(sender As Object, e As EventArgs) Handles chk_all_tpr.CheckedChanged
        If chk_all_tpr.CheckState = CheckState.Checked Then
            cmb_tpr.Text = String.Empty
            cmb_tpr.Enabled = False
        Else
            cmb_tpr.Enabled = True
        End If
    End Sub

    Private Sub chk_all_cat_CheckedChanged(sender As Object, e As EventArgs) Handles chk_all_cat.CheckedChanged
        If chk_all_cat.CheckState = CheckState.Checked Then
            cmb_cat.Text = String.Empty
            cmb_cat.Enabled = False
        Else
            cmb_cat.Enabled = True
        End If
    End Sub

    Private Sub chk_all_mar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_all_mar.CheckedChanged
        If chk_all_mar.CheckState = CheckState.Checked Then
            cmb_mar.Text = String.Empty
            cmb_mar.Enabled = False
        Else
            cmb_mar.Enabled = True
        End If
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim OReporteVentaProductos As New ProductoServices
        Me.get_filtros()
        Dim oUserLog As Usuario = Frm_principal.getUsuarioLogeado()
        Dim rParams As Microsoft.Reporting.WinForms.ReportParameter() = New Microsoft.Reporting.WinForms.ReportParameter() {New Microsoft.Reporting.WinForms.ReportParameter("prod_desde", txt_prod_desde.Text), New Microsoft.Reporting.WinForms.ReportParameter("prod_hasta", txt_prod_hasta.Text), New Microsoft.Reporting.WinForms.ReportParameter("tpr_denom", tpr_denom), New Microsoft.Reporting.WinForms.ReportParameter("cat_denom", cat_denom), New Microsoft.Reporting.WinForms.ReportParameter("mar_denom", mar_denom), New Microsoft.Reporting.WinForms.ReportParameter("all_tpr", tpr_all), New Microsoft.Reporting.WinForms.ReportParameter("all_cat", cat_all), New Microsoft.Reporting.WinForms.ReportParameter("all_mar", mar_all), New Microsoft.Reporting.WinForms.ReportParameter("chk_totalizado", totalizado), New Microsoft.Reporting.WinForms.ReportParameter("User", oUserLog.usu_nombreCompleto), New Microsoft.Reporting.WinForms.ReportParameter("chk_grafico", bFlagGrafico)}
        If txt_prod_desde.Text <> String.Empty And txt_prod_hasta.Text <> String.Empty Then
            If IsDate(mtxt_fecha_desde.Text) And IsDate(mtxt_fecha_hasta.Text) Then
                If totalizado = 1 Then
                    Me.DSReporteProductosVendidosBindingSource.DataSource = OReporteVentaProductos.obtenerReporteProductosVendidosAgrupado(txt_prod_desde.Text, txt_prod_hasta.Text, mtxt_fecha_desde.Text, mtxt_fecha_hasta.Text, tpr_codigo, cat_codigo, mar_codigo, tpr_all, cat_all, mar_all)
                Else
                    Me.DSReporteProductosVendidosBindingSource.DataSource = OReporteVentaProductos.obtenerReporteProductosVendidos(txt_prod_desde.Text, txt_prod_hasta.Text, mtxt_fecha_desde.Text, mtxt_fecha_hasta.Text, tpr_codigo, cat_codigo, mar_codigo, tpr_all, cat_all, mar_all)
                End If
                rv_reporte_productos_vendidos.LocalReport.SetParameters(rParams)
                rv_reporte_productos_vendidos.RefreshReport()
            Else
                MessageBox.Show("Debe completar los campos Fecha Desde y Fecha Hasta con valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe completar los campos Producto Desde y Producto Hasta con valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Chk_Grafico_CheckedChanged(sender As Object, e As EventArgs) Handles chk_grafico.CheckedChanged
        If chk_grafico.CheckState = CheckState.Checked Then
            bFlagGrafico = True
        Else
            bFlagGrafico = False
        End If
    End Sub
End Class