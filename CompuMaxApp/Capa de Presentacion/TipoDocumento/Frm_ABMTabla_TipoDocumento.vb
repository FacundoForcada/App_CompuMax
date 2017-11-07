Public Class Frm_ABMTabla_TipoDocumento

    Private Sub Frm_ABMTabla_TipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        Dim oTipoDocumentoServices As New TipoDocumentoServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable

        oTabla = oTipoDocumentoServices.obtenerTipoDocumentos()
        Me.llenar_grid(oTabla)
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_tipoDoc.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_tipoDoc.Rows.Add(New String() {row.Item("tdc_codigo").ToString, row.Item("tdc_denom").ToString})
        Next
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABM_tipoDocumento.ShowDialog()
        Frm_ABMTabla_TipoDocumento_Load(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABM_tipoDocumento.seleccionar_tipoDocumento(Frm_ABM_tipoProducto.Opcion.update, dgv_tipoDoc.CurrentRow)
        Frm_ABM_tipoDocumento.ShowDialog()
        Frm_ABMTabla_TipoDocumento_Load(sender, e)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
            Frm_principal.Show()
        End If
    End Sub

    Private Sub dgv_tipoDoc_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_tipoDoc.CellContentClick
        btn_editar.Enabled = True
    End Sub

End Class