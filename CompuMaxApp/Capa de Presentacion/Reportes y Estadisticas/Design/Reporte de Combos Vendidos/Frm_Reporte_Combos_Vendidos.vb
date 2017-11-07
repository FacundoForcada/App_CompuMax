Public Class Frm_Reporte_Combos_Vendidos
    Dim bflag_grafico As Boolean = False
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim oComboServices As New ComboServices
        Dim oUserLog As Usuario = Frm_principal.getUsuarioLogeado()
        Dim rParams As Microsoft.Reporting.WinForms.ReportParameter() = New Microsoft.Reporting.WinForms.ReportParameter() {New Microsoft.Reporting.WinForms.ReportParameter("Desde", mTxt_desde.Text), New Microsoft.Reporting.WinForms.ReportParameter("Hasta", mTxt_hasta.Text), New Microsoft.Reporting.WinForms.ReportParameter("Top", txt_top.Text), New Microsoft.Reporting.WinForms.ReportParameter("User", oUserLog.usu_nombreCompleto), New Microsoft.Reporting.WinForms.ReportParameter("chk_grafico", bflag_grafico)}
        If IsDate(mTxt_desde.Text) And IsDate(mTxt_hasta.Text) And txt_top.Text <> String.Empty Then
            Me.ReporteCombosVendidosBindingSource.DataSource = oComboServices.obtenerReporteCombosVendidos(txt_top.Text, mTxt_desde.Text, mTxt_hasta.Text)
            rv_reporte_Combos_Vendidos.LocalReport.SetParameters(rParams)
            rv_reporte_Combos_Vendidos.RefreshReport()
        Else
            MessageBox.Show("Complete TODOS los campos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Frm_Combos_Vendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mTxt_desde.Text = Date.Today.AddDays(-30).ToString
        mTxt_hasta.Text = Date.Today.ToString
        txt_top.Text = "5"
    End Sub

    Private Sub mTxt_desde_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mTxt_desde.MaskInputRejected

    End Sub

    Private Sub chk_mostrar_grafico_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mostrar_grafico.CheckedChanged
        If chk_mostrar_grafico.Checked Then
            bflag_grafico = True
        Else
            bflag_grafico = False
        End If
    End Sub
End Class