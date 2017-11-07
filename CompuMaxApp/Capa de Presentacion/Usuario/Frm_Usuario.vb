Public Class Frm_Usuario

    Private Sub Frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oGrupoServices As New GrupoServices
        oGrupoServices.llenarComboGrupo(cmb_grupo)
        btn_editar.Enabled = False
        btn_consultar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_usuario.Enabled = False
            cmb_grupo.Enabled = False
        Else
            txt_usuario.Enabled = True
            cmb_grupo.Enabled = True
        End If
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

    Private Sub btn_consultar_filtros_Click(sender As Object, e As EventArgs) Handles btn_consultar_filtros.Click
        btn_editar.Enabled = False
        btn_consultar.Enabled = False
        btn_eliminar.Enabled = False
        Dim oUsuarioServ As New UsuarioServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable
        Dim nStateChk As Integer

        If chk_todos.CheckState = CheckState.Checked Then
            bflag_filtros = True
            nStateChk = 1
        Else
            nStateChk = 0
            If txt_usuario.Text = String.Empty And cmb_grupo.Text = String.Empty Then
                bflag_filtros = False
            Else
                bflag_filtros = True
            End If
        End If

        If bflag_filtros Then
            oTabla = oUsuarioServ.obtenerUsuarios(txt_usuario.Text, cmb_grupo.Text, nStateChk)
            Me.llenar_grid(oTabla)
        Else
            MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_usuarios.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_usuarios.Rows.Add(New String() {row.Item("usu_codigo").ToString, row.Item("usu_usuario").ToString, row.Item("usu_nmbcompleto").ToString, row.Item("usu_mail").ToString, row.Item("grp_denom").ToString, row.Item("est_codigo").ToString, row.Item("usu_clave").ToString})
        Next
    End Sub

    Private Sub dgv_usuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        btn_editar.Enabled = True
        btn_consultar.Enabled = True
        btn_eliminar.Enabled = True
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABMC_usuario.ShowDialog()
        'btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABMC_usuario.seleccionar_usuario(Frm_ABMC_usuario.Opcion.update, dgv_usuarios.CurrentRow)
        Frm_ABMC_usuario.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Frm_ABMC_usuario.seleccionar_usuario(Frm_ABMC_usuario.Opcion.delete, dgv_usuarios.CurrentRow)
        Frm_ABMC_usuario.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Frm_ABMC_usuario.seleccionar_usuario(Frm_ABMC_usuario.Opcion.consult, dgv_usuarios.CurrentRow)
        Frm_ABMC_usuario.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub
    Private Sub lbl_usuario_Click(sender As Object, e As EventArgs) Handles lbl_usuario.Click

    End Sub

    Private Sub pnl_filtros_Paint(sender As Object, e As PaintEventArgs) Handles pnl_filtros.Paint

    End Sub
End Class