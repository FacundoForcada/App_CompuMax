Public Class Frm_ABMTabla_Promocion

    Private Sub Frm_AMBTabla_Promocion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        Dim oPromocionServices As New PromocionServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable

        oTabla = oPromocionServices.obtenerPromocion()
        Me.llenar_grid(oTabla)
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_promociones.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_promociones.Rows.Add(New String() {row.Item("prom_codigo").ToString, row.Item("prom_denom").ToString, row.Item("prom_desc").ToString, row.Item("est_denom").ToString})
        Next
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABM_Promocion.ShowDialog()
        Frm_AMBTabla_Promocion_Load(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABM_Promocion.seleccionar_descuento(Frm_ABM_Promocion.Opcion.update, dgv_promociones.CurrentRow)
        Frm_ABM_Promocion.ShowDialog()
        Frm_AMBTabla_Promocion_Load(sender, e)
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Frm_ABM_Promocion.seleccionar_descuento(Frm_ABM_Promocion.Opcion.delete, dgv_promociones.CurrentRow)
        Frm_ABM_Promocion.ShowDialog()
        Frm_AMBTabla_Promocion_Load(sender, e)
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

    Private Sub dgv_promociones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_promociones.CellContentClick
        btn_editar.Enabled = True
        btn_borrar.Enabled = True
    End Sub
End Class