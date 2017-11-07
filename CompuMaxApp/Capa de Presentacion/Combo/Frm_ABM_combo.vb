Public Class Frm_ABM_combo
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABM_combo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oEstadoServices As New EstadoServices
        Dim oCategoriaServices As New CategoriaServices
        Dim oComboService As New ComboServices

        oEstadoServices.llenarComboGrupo(cmb_estado)
        oCategoriaServices.llenarComboGrupo(cmb_categoria)
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Combo"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                lbl_com_codigo.Visible = False
                txt_com_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Combo"
                mostrar_datos()
                txt_com_denom.Enabled = True
                cmb_estado.Enabled = True
                cmb_categoria.Enabled = True
                txt_com_precio.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar Combo"
                txt_com_denom.Enabled = False
                cmb_estado.Enabled = False
                cmb_categoria.Enabled = False
                txt_com_precio.Enabled = False
                btn_aceptar.Text = "Eliminar"
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_com_codigo.Text = _row_selected.Cells("com_codigo").Value
            txt_com_denom.Text = _row_selected.Cells("com_denom").Value
            cmb_categoria.Text = _row_selected.Cells("cat_denom").Value
            cmb_estado.Text = _row_selected.Cells("est_denom").Value
            txt_com_precio.Text = _row_selected.Cells("com_precio").Value
        End If
    End Sub

    Public Sub seleccionar_combo(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function existe_nombre() As Boolean
        Dim oComboServices As New ComboServices
        Return oComboServices.validarNombreCombo(txt_com_denom.Text)
    End Function

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_com_denom.Text = String.Empty Then
            txt_com_denom.BackColor = Color.Red
            txt_com_denom.Focus()
            Return False
        Else
            txt_com_denom.BackColor = Color.White
        End If

        If cmb_categoria.Text = String.Empty Then
            cmb_categoria.BackColor = Color.Red
            cmb_categoria.Focus()
            Return False
        Else
            cmb_categoria.BackColor = Color.White
        End If

        If cmb_estado.Text = String.Empty Then
            cmb_estado.BackColor = Color.Red
            cmb_estado.Focus()
            Return False
        Else
            cmb_estado.BackColor = Color.White
        End If

        If txt_com_precio.Text = String.Empty Then
            txt_com_precio.BackColor = Color.Red
            txt_com_precio.Focus()
            Return False
        Else
            txt_com_precio.BackColor = Color.White
        End If
        Return True
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oComboServices As New ComboServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oComboServices.comboInsert(txt_com_denom.Text, cmb_categoria.SelectedValue.ToString, cmb_estado.SelectedValue.ToString, txt_com_precio.Text)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Combo insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar el Combo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Combo encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oComboServices.comboUpdate(txt_com_codigo.Text, txt_com_denom.Text, cmb_categoria.SelectedValue.ToString, cmb_estado.SelectedValue.ToString, txt_com_precio.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Combo actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Combo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar el Combo seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oComboServices.comboDelete(txt_com_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Combo Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al deshabilitar el Combo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class