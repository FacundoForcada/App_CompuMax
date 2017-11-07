Public Class Frm_ABM_tipoDocumento
    Enum Opcion
        insert
        update
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABM_tipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nNuevoID As Integer = 0
        Dim oTipoDocumentoServices As New TipoDocumentoServices
        nNuevoID = oTipoDocumentoServices.getLastTipoDocumentoID()
        If nNuevoID = 0 Then
            nNuevoID = 0
        Else
            nNuevoID = nNuevoID + 1
        End If

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Tipo de Documento"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                txt_tdc_codigo.Text = nNuevoID

            Case Opcion.update
                Me.Text = "Actualizar Tipo de Documento"
                mostrar_datos()
                txt_tdc_denom.Enabled = True
                btn_aceptar.Text = "Actualizar"
        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_tdc_codigo.Text = _row_selected.Cells("tdc_codigo").Value
            txt_tdc_denom.Text = _row_selected.Cells("tdc_denom").Value
        End If
    End Sub

    Public Sub seleccionar_tipoDocumento(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_tdc_denom.Text = String.Empty Then
            txt_tdc_denom.BackColor = Color.Red
            txt_tdc_denom.Focus()
            Return False
        Else
            txt_tdc_denom.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Dim oTipoDocumentoServices As New TipoDocumentoServices
        Return oTipoDocumentoServices.validarNombreTipoDocumento(txt_tdc_denom.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oTipoDocumentoServices As New TipoDocumentoServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oTipoDocumentoServices.tipoDocumentoInsert(txt_tdc_codigo.Text, txt_tdc_denom.Text)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Tipo de Documento insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar el Tipo de Documento!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Tipo de Documento encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oTipoDocumentoServices.tipoDocumentoUpdate(txt_tdc_codigo.Text, txt_tdc_denom.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Tipo de Documento actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Tipo de Documento!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class