Public Class Frm_ABMTabla_TipoProducto

    Private Sub Frm_ABMTabla_TipoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        Dim oTipoProductoServices As New TipoProductoServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable

        oTabla = oTipoProductoServices.obtenerTipoProductos()
        Me.llenar_grid(oTabla)
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_tipoProd.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_tipoProd.Rows.Add(New String() {row.Item("tpr_codigo").ToString, row.Item("tpr_denom").ToString})
        Next
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

    Private Sub dgv_tipoProd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_tipoProd.CellContentClick
        btn_editar.Enabled = True
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABM_tipoProducto.seleccionar_tipoProducto(Frm_ABM_tipoProducto.Opcion.update, dgv_tipoProd.CurrentRow)
        Frm_ABM_tipoProducto.ShowDialog()
        Frm_ABMTabla_TipoProducto_Load(sender, e)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABM_tipoProducto.ShowDialog()
        Frm_ABMTabla_TipoProducto_Load(sender, e)
    End Sub
End Class