Public Class Frm_ABMTabla_Combo

    Private Sub Frm_ABMTabla_Combo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        Dim oComboServices As New ComboServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable

        oTabla = oComboServices.obtenerCombos()
        Me.llenar_grid(oTabla)
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_combos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_combos.Rows.Add(New String() {row.Item("com_codigo").ToString, row.Item("com_denom").ToString, row.Item("cat_denom").ToString, row.Item("est_denom").ToString, row.Item("com_precio").ToString})
        Next
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABM_combo.ShowDialog()
        Frm_ABMTabla_Combo_Load(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABM_combo.seleccionar_combo(Frm_ABM_combo.Opcion.update, dgv_combos.CurrentRow)
        Frm_ABM_combo.ShowDialog()
        Frm_ABMTabla_Combo_Load(sender, e)
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Frm_ABM_combo.seleccionar_combo(Frm_ABM_combo.Opcion.delete, dgv_combos.CurrentRow)
        Frm_ABM_combo.ShowDialog()
        Frm_ABMTabla_Combo_Load(sender, e)
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

    Private Sub dgv_combos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_combos.CellContentClick
        btn_editar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

End Class