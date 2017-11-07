Imports Microsoft.Reporting.WinForms
Public Class Frm_Reporte_Proveedores

    Private Sub Frm_Reporte_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_component()
        txt_cod_desde.Text = "0"
        txt_cod_hasta.Text = "9999"
    End Sub
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim oProveedoresServices As New ProveedorServices
        Dim oUserLog As Usuario = Frm_principal.getUsuarioLogeado()
        Dim rParams As Microsoft.Reporting.WinForms.ReportParameter() = New Microsoft.Reporting.WinForms.ReportParameter() {New Microsoft.Reporting.WinForms.ReportParameter("cod_desde", txt_cod_desde.Text), New Microsoft.Reporting.WinForms.ReportParameter("cod_hasta", txt_cod_hasta.Text), New Microsoft.Reporting.WinForms.ReportParameter("User", oUserLog.usu_nombreCompleto)}
        If txt_cod_desde.Text <> String.Empty And txt_cod_hasta.Text <> String.Empty Then
            'If chk_no_activos.CheckState = CheckState.Checked Then
            'Me.ReporteProveedoresBindingSource.DataSource = Me.ReporteProveedoresTableAdapter.GetData(txt_cod_desde.Text, txt_cod_hasta.Text)
            'Else
            'Me.ReporteProveedoresBindingSource.DataSource = Me.ReporteProveedoresTableAdapter.GetDataBy(txt_cod_desde.Text, txt_cod_hasta.Text)
            'End If
            Me.ReporteProveedoresBindingSource.DataSource = oProveedoresServices.obtenerReporteProveedores(txt_cod_desde.Text, txt_cod_hasta.Text, chk_no_activos.CheckState)
            rv_reporte_proveedores.LocalReport.SetParameters(rParams)
            rv_reporte_proveedores.RefreshReport()
        Else
            MessageBox.Show("Debe completar los campos Codigo Desde y Codigo Hasta con valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_component()
        End If
    End Sub
    Private Sub clear_component()
        txt_cod_desde.Clear()
        txt_cod_hasta.Clear()
        Me.rv_reporte_proveedores.Clear()
    End Sub
End Class