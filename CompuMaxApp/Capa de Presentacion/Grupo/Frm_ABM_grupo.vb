Public Class Frm_ABM_grupo
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABM_grupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oEstadoServices As New EstadoServices
        Dim oGrupoService As New GrupoServices

        oEstadoServices.llenarComboGrupo(cmb_estado)
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Grupo"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                txt_grp_codigo.Visible = False
                lbl_grp_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Grupo"
                mostrar_datos()
                txt_grp_denom.Enabled = True
                cmb_estado.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar Grupo"
                txt_grp_denom.Enabled = False
                cmb_estado.Enabled = False
                btn_aceptar.Text = "Eliminar"
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_grp_codigo.Text = _row_selected.Cells("grp_codigo").Value
            txt_grp_denom.Text = _row_selected.Cells("grp_denom").Value
            cmb_estado.Text = _row_selected.Cells("est_denom").Value
        End If
    End Sub

    Public Sub seleccionar_grupo(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_grp_denom.Text = String.Empty Then
            txt_grp_denom.BackColor = Color.Red
            txt_grp_denom.Focus()
            Return False
        Else
            txt_grp_denom.BackColor = Color.White
        End If

        If cmb_estado.Text = String.Empty Then
            cmb_estado.BackColor = Color.Red
            cmb_estado.Focus()
            Return False
        Else
            cmb_estado.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Dim oGrupoServices As New GrupoServices
        Return oGrupoServices.validarNombreGrupo(txt_grp_denom.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oGrupoServices As New GrupoServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oGrupoServices.grupoInsert(txt_grp_denom.Text, cmb_estado.SelectedValue.ToString)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Grupo insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar el Grupo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Grupo encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oGrupoServices.grupoUpdate(txt_grp_codigo.Text, txt_grp_denom.Text, cmb_estado.SelectedValue.ToString)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Grupo actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Grupo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar el Grupo seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oGrupoServices.grupoDelete(txt_grp_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Grupo Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al deshabilitar el Grupo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class