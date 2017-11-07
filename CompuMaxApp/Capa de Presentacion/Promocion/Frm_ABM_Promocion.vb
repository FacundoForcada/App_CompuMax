Public Class Frm_ABM_Promocion
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABM_Descuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oEstadoServices As New EstadoServices
        Dim oPromocionService As New PromocionServices

        oEstadoServices.llenarComboGrupo(cmb_estado)
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nueva Promocion"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                lbl_prom_codigo.Visible = False
                txt_prom_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Promocion"
                mostrar_datos()
                txt_prom_denom.Enabled = True
                txt_prom_denom.Enabled = True
                cmb_estado.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                Me.Text = "Deshabilitar Promocion"
                mostrar_datos()
                txt_prom_denom.Enabled = False
                txt_prom_desc.Enabled = False
                cmb_estado.Enabled = False
                btn_aceptar.Text = "Eliminar"
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_prom_codigo.Text = _row_selected.Cells("prom_codigo").Value
            txt_prom_denom.Text = _row_selected.Cells("prom_denom").Value
            txt_prom_desc.Text = _row_selected.Cells("prom_desc").Value
            cmb_estado.Text = _row_selected.Cells("est_denom").Value
        End If
    End Sub

    Public Sub seleccionar_descuento(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_prom_denom.Text = String.Empty Then
            txt_prom_denom.BackColor = Color.Red
            txt_prom_denom.Focus()
            Return False
        Else
            txt_prom_denom.BackColor = Color.White
        End If

        If txt_prom_desc.Text = String.Empty Then
            txt_prom_desc.BackColor = Color.Red
            txt_prom_desc.Focus()
            Return False
        Else
            txt_prom_desc.BackColor = Color.White
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
        Dim oPromocionServices As New PromocionServices
        Return oPromocionServices.validarNombrePromocion(txt_prom_denom.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oPromocionServices As New PromocionServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oPromocionServices.promocionInsert(txt_prom_denom.Text, Val(txt_prom_desc.Text), cmb_estado.SelectedValue.ToString)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Promocion insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar la Promocion!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Promocion encontrada!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oPromocionServices.promocionUpdate(txt_prom_codigo.Text, txt_prom_denom.Text, Val(txt_prom_desc.Text), cmb_estado.SelectedValue.ToString)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Promocion actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Descuento!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar el Descuento seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oPromocionServices.promocionDelete(txt_prom_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Promocion Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al deshabilitar la Promocion!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class