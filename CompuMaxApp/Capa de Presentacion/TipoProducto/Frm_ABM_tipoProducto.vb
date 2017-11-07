Public Class Frm_ABM_tipoProducto
    Enum Opcion
        insert
        update
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABM_tipoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oTipoProductoServices As New TipoProductoServices

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Tipo de Producto"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                lbl_tpr_codigo.Visible = False
                txt_tpr_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Tipo de Producto"
                mostrar_datos()
                txt_tpr_denom.Enabled = True
                btn_aceptar.Text = "Actualizar"
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_tpr_codigo.Text = _row_selected.Cells("tpr_codigo").Value
            txt_tpr_denom.Text = _row_selected.Cells("tpr_denom").Value
        End If
    End Sub

    Public Sub seleccionar_tipoProducto(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_tpr_denom.Text = String.Empty Then
            txt_tpr_denom.BackColor = Color.Red
            txt_tpr_denom.Focus()
            Return False
        Else
            txt_tpr_denom.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Dim oTipoProductoServices As New TipoProductoServices
        Return oTipoProductoServices.validarNombreTipoProducto(txt_tpr_denom.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oTipoProductoServices As New TipoProductoServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oTipoProductoServices.tipoProductoInsert(txt_tpr_denom.Text)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Tipo de Producto insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar el Tipo de Producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Tipo de Producto encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oTipoProductoServices.tipoProductoUpdate(txt_tpr_codigo.Text, txt_tpr_denom.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Tipo de Producto actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Tipo de Producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class