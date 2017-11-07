Public Class Frm_ABM_categoria
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABM_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oEstadoServices As New EstadoServices
        Dim oCategoriaService As New CategoriaServices

        oEstadoServices.llenarComboGrupo(cmb_estado)
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nueva Categoria"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                txt_cat_codigo.Visible = False
                lbl_cat_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Categoria"
                mostrar_datos()
                txt_cat_denom.Enabled = True
                cmb_estado.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar Categoria"
                txt_cat_denom.Enabled = False
                cmb_estado.Enabled = False
                btn_aceptar.Text = "Eliminar"
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_cat_codigo.Text = _row_selected.Cells("cat_codigo").Value
            txt_cat_denom.Text = _row_selected.Cells("cat_denom").Value
            cmb_estado.Text = _row_selected.Cells("est_denom").Value
        End If
    End Sub

    Public Sub seleccionar_categoria(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_cat_denom.Text = String.Empty Then
            txt_cat_denom.BackColor = Color.Red
            txt_cat_denom.Focus()
            Return False
        Else
            txt_cat_denom.BackColor = Color.White
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
        Dim oCategoriaServices As New CategoriaServices
        Return oCategoriaServices.validarNombreCategoria(txt_cat_denom.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oCategoriaServices As New CategoriaServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oCategoriaServices.categoriaInsert(txt_cat_denom.Text, cmb_estado.SelectedValue.ToString)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Categoria insertada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        Else
                            MessageBox.Show("Error al Insertar la Categoria!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Categoria encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oCategoriaServices.categoriaUpdate(txt_cat_codigo.Text, txt_cat_denom.Text, cmb_estado.SelectedValue.ToString)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Categoria actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Error al actualizar la Categoria!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar la Categoria seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oCategoriaServices.categoriaDelete(txt_cat_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Categoria Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Error al deshabilitar la Categoria!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class