Public Class Frm_ABMTabla_Grupo

    Private Sub Frm_ABMTabla_Grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        Dim oGrupoServices As New GrupoServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable

        oTabla = oGrupoServices.obtenerGrupos()
        Me.llenar_grid(oTabla)
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_grupos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_grupos.Rows.Add(New String() {row.Item("grp_codigo").ToString, row.Item("grp_denom").ToString, row.Item("est_denom").ToString})
        Next
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABM_grupo.ShowDialog()
        Frm_ABMTabla_Grupo_Load(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABM_grupo.seleccionar_grupo(Frm_ABM_grupo.Opcion.update, dgv_grupos.CurrentRow)
        Frm_ABM_grupo.ShowDialog()
        Frm_ABMTabla_Grupo_Load(sender, e)
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Frm_ABM_grupo.seleccionar_grupo(Frm_ABM_grupo.Opcion.delete, dgv_grupos.CurrentRow)
        Frm_ABM_grupo.ShowDialog()
        Frm_ABMTabla_Grupo_Load(sender, e)
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

    Private Sub dgv_grupos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_grupos.CellContentClick
        btn_editar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

End Class