Public Class Frm_ABMC_Proveedor
    Enum Opcion
        insert
        update
        delete
        consult
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABMC_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oProveedorServices As New ProveedorServices

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Proveedor"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                lbl_prov_codigo.Visible = False
                txt_prov_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Proveedor"
                mostrar_datos()
                txt_prov_denom.Enabled = True
                txt_prov_cuit.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar Proveedor"
                txt_prov_denom.Enabled = False
                txt_prov_cuit.Enabled = False
                btn_aceptar.Text = "Eliminar"

            Case Opcion.consult
                mostrar_datos()
                Me.Text = "Consultar Proveedor"
                txt_prov_denom.Enabled = False
                txt_prov_cuit.Enabled = False
                btn_aceptar.Text = "Aceptar"
                btn_cancelar.Visible = False
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_prov_codigo.Text = _row_selected.Cells("prov_codigo").Value
            txt_prov_denom.Text = _row_selected.Cells("prov_denom").Value
            txt_prov_cuit.Text = _row_selected.Cells("prov_cuit").Value
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub

    Public Sub seleccionar_proveedor(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        If txt_prov_denom.Text = String.Empty Then
            txt_prov_denom.BackColor = Color.Red
            txt_prov_denom.Focus()
            Return False
        Else
            txt_prov_denom.BackColor = Color.White
        End If

        If txt_prov_cuit.Text = String.Empty Then
            txt_prov_cuit.BackColor = Color.Red
            txt_prov_cuit.Focus()
            Return False
        Else
            txt_prov_cuit.BackColor = Color.White
        End If
        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Dim oProveedorServices As New ProveedorServices
        Return oProveedorServices.validarNombreProveedor(txt_prov_denom.Text)
    End Function

    Private Function existe_cuit() As Boolean
        Dim oProveedorServices As New ProveedorServices
        Return oProveedorServices.validarCUITProveedor(txt_prov_cuit.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oProveedorServices As New ProveedorServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False And existe_cuit() = False Then
                    If validar_campos() Then
                        nDevuelto = oProveedorServices.insertProveedor(txt_prov_denom.Text, txt_prov_cuit.Text)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Proveedor insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar el Proveedor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    If existe_nombre() = True Then
                        MessageBox.Show("Nombre de Proveedor encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("ÇUIT de Proveedor encontrado!. Ingrese un CUIT diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oProveedorServices.updateProveedor(txt_prov_codigo.Text, txt_prov_denom.Text, txt_prov_cuit.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Proveedor actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Proveedor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar el Proveedor seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oProveedorServices.deleteProveedor(txt_prov_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Proveedor Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al deshabilitar el Proveedor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.consult
                Me.Dispose()
        End Select
    End Sub

End Class