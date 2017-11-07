Public Class Frm_ABM_marca
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABM_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oEstadoServices As New EstadoServices
        Dim oMarcaService As New MarcaServices

        oEstadoServices.llenarComboGrupo(cmb_estado)
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nueva Marca"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                lbl_mar_codigo.Visible = False
                txt_mar_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Marca"
                mostrar_datos()
                txt_mar_denom.Enabled = True
                cmb_estado.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar Marca"
                txt_mar_denom.Enabled = False
                cmb_estado.Enabled = False
                btn_aceptar.Text = "Eliminar"
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_mar_codigo.Text = _row_selected.Cells("mar_codigo").Value
            txt_mar_denom.Text = _row_selected.Cells("mar_denom").Value
            cmb_estado.Text = _row_selected.Cells("estado").Value
        End If
    End Sub

    Public Sub seleccionar_marca(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_mar_denom.Text = String.Empty Then
            txt_mar_denom.BackColor = Color.Red
            txt_mar_denom.Focus()
            Return False
        Else
            txt_mar_denom.BackColor = Color.White
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
        Dim oMarcaServices As New MarcaServices
        Return oMarcaServices.validarNombreMarca(txt_mar_denom.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oMarcaServices As New MarcaServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oMarcaServices.marcaInsert(txt_mar_denom.Text, cmb_estado.SelectedValue.ToString)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Marca insertada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar la Marca!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Marca encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oMarcaServices.marcaUpdate(txt_mar_codigo.Text, txt_mar_denom.Text, cmb_estado.SelectedValue.ToString)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Marca actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar la Marca!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar la Marca seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oMarcaServices.marcaDelete(txt_mar_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Marca Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al deshabilitar la Marca!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class