Public Class Frm_GrupoUsuario
    Private Sub btn_consultar_grp_Click(sender As Object, e As EventArgs) Handles btn_consultar_grp.Click
        If cmb_grupo.Text <> String.Empty Then
            mostrarGroupUsuario()
        Else
            MessageBox.Show("Debe seleccionar un grupo primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub mostrarGroupUsuario()
        Dim oGrupoUsuarioSer As New GrupoUsuarioServices
        Dim oTabla As DataTable
        mostrarTextoGrupoSeleccionado(cmb_grupo.Text)
        oTabla = oGrupoUsuarioSer.obtenerUsuariosXGrupo(cmb_grupo.SelectedValue().ToString)
        llenar_grid_grpusu(oTabla)

    End Sub
    Private Sub llenar_grid_grpusu(ByVal source As DataTable)
        dgv_grupo_usuario.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_grupo_usuario.Rows.Add(New String() {row.Item("grp_codigo").ToString, row.Item("usu_codigo").ToString, row.Item("est_codigo").ToString, row.Item("usu_usuario").ToString, row.Item("usu_nmbcompleto").ToString})
        Next
    End Sub

    Private Sub Frm_Grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oGrupo As New GrupoServices
        oGrupo.llenarComboGrupoSoloActivos(cmb_grupo)
        btn_agregar_usu.Enabled = False
        btn_quitar_usu.Enabled = False
        lbl_tittle_grp.Visible = False
        lbl_grp.Visible = False
        btn_consultar_grp.Enabled = True

    End Sub

    Private Sub dgv_grupo_usuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_grupo_usuario.CellContentClick
        btn_quitar_usu.Enabled = True
    End Sub

    Private Sub mostrarTextoGrupoSeleccionado(ByVal texto As String)
        lbl_tittle_grp.Visible = True
        lbl_grp.Visible = True
        lbl_grp.Text = texto
    End Sub


    Private Sub btn_consultar_usu_Click(sender As Object, e As EventArgs) Handles btn_consultar_usu.Click
        Dim oUsuarioServ As New UsuarioServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable
        Dim nStateChk As Integer

        If chk_todos.CheckState = CheckState.Checked Then
            nStateChk = 1
        Else
            nStateChk = 0
        End If


        If chk_todos.CheckState = CheckState.Checked Then
            bflag_filtros = True
            nStateChk = 1
        Else
            nStateChk = 0
            If txt_usuario.Text = String.Empty Then
                bflag_filtros = False
            End If
        End If

        If bflag_filtros Then
            oTabla = oUsuarioServ.obtenerUsuYnombre(txt_usuario.Text, nStateChk)
            Me.llenar_grid_usu(oTabla)

        Else
            MessageBox.Show("Debe ingresar al menos un criterio de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub llenar_grid_usu(ByVal source As DataTable)
        dgv_usuarios.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_usuarios.Rows.Add(New String() {row.Item("usu_codigo").ToString, row.Item("usu_usuario").ToString, row.Item("usu_nmbcompleto").ToString})
        Next
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_usuario.Enabled = False
        Else
            txt_usuario.Enabled = True
        End If
    End Sub

    Private Sub btn_agregar_usu_Click(sender As Object, e As EventArgs) Handles btn_agregar_usu.Click
        Dim oGrupoUsuarioSer As New GrupoUsuarioServices
        Dim row_selected As DataGridViewRow
        row_selected = dgv_usuarios.CurrentRow
        If cmb_grupo.Text <> String.Empty Then
            oGrupoUsuarioSer.agregarUsuario(cmb_grupo.SelectedValue().ToString, row_selected.Cells("usu_codigo_U").Value)
        Else
            MessageBox.Show("Debe seleccionar un grupo en la parte de arriba", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        btn_consultar_grp_Click(sender, e)

    End Sub

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        btn_agregar_usu.Enabled = True
    End Sub

    Private Sub btn_quitar_usu_Click(sender As Object, e As EventArgs) Handles btn_quitar_usu.Click
        Dim oGrupoUsuarioSer As New GrupoUsuarioServices
        Dim row_selected As DataGridViewRow
        row_selected = dgv_grupo_usuario.CurrentRow
        If row_selected.Cells.Count > 0 Then
            oGrupoUsuarioSer.quitarUsuario(row_selected.Cells("usu_codigo").Value)
        Else
            MessageBox.Show("Debe seleccionar un usuario a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        btn_consultar_grp_Click(sender, e)
    End Sub

    Private Sub cmb_grupo_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_grupo.MouseClick
        If cmb_grupo.Text <> String.Empty Then
            mostrarGroupUsuario()
        End If
    End Sub

End Class