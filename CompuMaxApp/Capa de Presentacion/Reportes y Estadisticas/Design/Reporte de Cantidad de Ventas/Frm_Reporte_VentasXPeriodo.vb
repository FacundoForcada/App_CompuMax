Public Class Frm_Reporte_VentasXPeriodo
    Dim bFlagGrafico As Boolean
    Dim bFlagHistograma As Boolean
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim oVentaServices As New VentaServices
        Dim oUserLog As Usuario = Frm_principal.getUsuarioLogeado()
        Dim rParams As Microsoft.Reporting.WinForms.ReportParameter() = New Microsoft.Reporting.WinForms.ReportParameter() {New Microsoft.Reporting.WinForms.ReportParameter("Desde", mTxt_desde.Text), New Microsoft.Reporting.WinForms.ReportParameter("Hasta", mTxt_hasta.Text), New Microsoft.Reporting.WinForms.ReportParameter("User", oUserLog.usu_nombreCompleto), New Microsoft.Reporting.WinForms.ReportParameter("User", oUserLog.usu_nombreCompleto), New Microsoft.Reporting.WinForms.ReportParameter("chk_grafico", bFlagGrafico), New Microsoft.Reporting.WinForms.ReportParameter("chk_histo", bFlagHistograma)}
        If IsDate(mTxt_desde.Text) And IsDate(mTxt_hasta.Text) Then
            Me.ReporteVentasXPeriodoBindingSource.DataSource = oVentaServices.obtenerReporteVentasXPeriodo(mTxt_desde.Text, mTxt_hasta.Text)
            rv_reporte_ventasXPeriodo.LocalReport.SetParameters(rParams)
            rv_reporte_ventasXPeriodo.RefreshReport()
        Else
            MessageBox.Show("Debe completar los campos Fecha Desde y Fecha Hasta con valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Frm_Reporte_VentasXPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTxt_desde.Text = Date.Today.AddDays(-360).ToString
        mTxt_hasta.Text = Date.Today.ToString
        chk_grafico.CheckState = CheckState.Checked
        chk_histograma.CheckState = CheckState.Checked
    End Sub

    Private Sub Chk_Grafico_CheckedChanged(sender As Object, e As EventArgs) Handles chk_grafico.CheckedChanged
        If chk_grafico.CheckState = CheckState.Checked Then
            bFlagGrafico = True
        Else
            bFlagGrafico = False
        End If
    End Sub

    Private Sub chk_histograma_CheckedChanged(sender As Object, e As EventArgs) Handles chk_histograma.CheckedChanged
        If chk_histograma.CheckState = CheckState.Checked Then
            bFlagHistograma = True
        Else
            bFlagHistograma = False
        End If
    End Sub
End Class