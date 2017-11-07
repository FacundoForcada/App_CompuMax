Public Class Frm_ABMC_usuario
    Enum Opcion
        insert
        update
        delete
        consult
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABMC_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oGrupoServices As New GrupoServices
        Dim oUsuarioService As New UsuarioServices

        oGrupoServices.llenarComboGrupo(cmb_grupo)
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Usuario"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                lbl_usu_codigo.Visible = False
                txt_usu_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Usuario"
                'Recuperar usuario seleccionado en la grilla 
                mostrar_datos()
                txt_usu_usuario.Enabled = True
                txt_usu_nmbcompleto.Enabled = True
                txt_usu_clave.Enabled = True
                txt_usu_clave_rep.Enabled = True
                txt_usu_mail.Enabled = True
                cmb_grupo.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar Usuario"
                txt_usu_usuario.Enabled = False
                txt_usu_nmbcompleto.Enabled = False
                txt_usu_clave.Enabled = False
                txt_usu_clave_rep.Enabled = False
                txt_usu_mail.Enabled = False
                cmb_grupo.Enabled = False
                btn_aceptar.Text = "Eliminar"

            Case Opcion.consult
                mostrar_datos()
                Me.Text = "Consultar Usuario"
                txt_usu_usuario.Enabled = False
                txt_usu_nmbcompleto.Enabled = False
                txt_usu_clave.Enabled = False
                txt_usu_clave_rep.Enabled = False
                txt_usu_mail.Enabled = False
                cmb_grupo.Enabled = False
                btn_aceptar.Text = "Aceptar"
                btn_cancelar.Visible = False

        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_usu_codigo.Text = _row_selected.Cells("usu_codigo").Value
            txt_usu_usuario.Text = _row_selected.Cells("usu_usuario").Value
            txt_usu_nmbcompleto.Text = _row_selected.Cells("usu_nmbcompleto").Value
            txt_usu_clave.Text = _row_selected.Cells("usu_clave").Value
            txt_usu_clave_rep.Text = txt_usu_clave.Text
            cmb_grupo.Text = _row_selected.Cells("grp_denom").Value
            txt_usu_mail.Text = _row_selected.Cells("usu_mail").Value
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oUsuarioService As New UsuarioServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oUsuarioService.usuarioInsert(txt_usu_usuario.Text, txt_usu_clave.Text, txt_usu_nmbcompleto.Text, txt_usu_mail.Text, cmb_grupo.SelectedValue.ToString)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oUsuarioService.usuarioUpdate(txt_usu_codigo.Text, txt_usu_usuario.Text, txt_usu_clave.Text, txt_usu_nmbcompleto.Text, txt_usu_mail.Text, cmb_grupo.SelectedValue.ToString)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oUsuarioService.usuarioDelete(txt_usu_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Usuario Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al deshabilitar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.consult
                Me.Dispose()
        End Select
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub

    Public Sub seleccionar_usuario(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_usu_usuario.Text = String.Empty Then
            txt_usu_usuario.BackColor = Color.Red
            txt_usu_usuario.Focus()
            Return False
        Else
            txt_usu_usuario.BackColor = Color.White
        End If

        If txt_usu_nmbcompleto.Text = String.Empty Then
            txt_usu_nmbcompleto.BackColor = Color.Red
            txt_usu_nmbcompleto.Focus()
            Return False
        Else
            txt_usu_nmbcompleto.BackColor = Color.White
        End If

        If txt_usu_clave.Text = String.Empty Then
            txt_usu_clave.BackColor = Color.Red
            txt_usu_clave.Focus()
            Return False
        Else
            txt_usu_clave.BackColor = Color.White
        End If

        If txt_usu_clave_rep.Text = String.Empty Then
            txt_usu_clave_rep.BackColor = Color.Red
            txt_usu_clave_rep.Focus()
            Return False
        Else
            txt_usu_clave_rep.BackColor = Color.White
        End If

        If cmb_grupo.Text = String.Empty Then
            cmb_grupo.BackColor = Color.Red
            cmb_grupo.Focus()
            Return False
        Else
            cmb_grupo.BackColor = Color.White
        End If

        If txt_usu_clave_rep.Text <> txt_usu_clave.Text Then
            txt_usu_clave_rep.BackColor = Color.Red
            txt_usu_clave.BackColor = Color.Red
            txt_usu_clave_rep.Focus()
            Return False
        Else
            txt_usu_clave_rep.BackColor = Color.White
            txt_usu_clave.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Dim oUsuarioServ As New UsuarioServices
        Return oUsuarioServ.validarNombreUsuario(txt_usu_usuario.Text)
    End Function

End Class