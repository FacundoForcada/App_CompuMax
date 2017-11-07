Public Class Frm_ABMC_cliente
    Enum Opcion
        insert
        update
        delete
        consult
    End Enum

    Private _action As Opcion
    Private _row_selected As DataGridViewRow
    Private cli_codigo As String

    Public Sub seleccionar_cliente(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Sub Frm_ABMC_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oTipoDocumentoSer As New TipoDocumentoServices

        oTipoDocumentoSer.llenarComboGrupo(cmb_tipo_doc)

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Cliente"
                btn_aceptar.Text = "Agregar"
                habilitarCamposDeIngreso(True)
            Case Opcion.update
                mostrar_datos()
                Me.Text = "Modificar Cliente"
                btn_aceptar.Text = "Modificar"
                habilitarCamposDeIngreso(True)
            Case Opcion.delete
                Me.Text = "Eliminar Cliente"
                mostrar_datos()
                habilitarCamposDeIngreso(False)
                btn_aceptar.Text = "Eliminar"
            Case Opcion.consult
                Me.Text = "Datos del Cliente"
                mostrar_datos()
                habilitarCamposDeIngreso(False)
                btn_aceptar.Text = "Aceptar"

        End Select
    End Sub

    Private Sub habilitarCamposDeIngreso(ByRef flag As Boolean)
        txt_nombre.Enabled = flag
        txt_apellido.Enabled = flag
        txt_cuit.Enabled = flag
        txt_mail.Enabled = flag
        txt_nro_doc.Enabled = flag
        txt_telefono.Enabled = flag
        cmb_tipo_doc.Enabled = flag
    End Sub

    Friend Sub habilitar_creacion()
        btn_crear.Visible = True
        btn_aceptar.Visible = False
        btn_crear.Enabled = True
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            cli_codigo = _row_selected.Cells("cli_codigo").Value
            txt_nombre.Text = _row_selected.Cells("cli_nombre").Value
            txt_apellido.Text = _row_selected.Cells("cli_apellido").Value
            txt_cuit.Text = _row_selected.Cells("cli_cuit").Value
            cmb_tipo_doc.Text = _row_selected.Cells("tdc_denom").Value
            txt_nro_doc.Text = _row_selected.Cells("cli_numdoc").Value
            txt_telefono.Text = _row_selected.Cells("cli_telefono").Value
            txt_mail.Text = _row_selected.Cells("cli_mail").Value

        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oClienteSer As New ClienteServices

        Select Case _action
            Case Opcion.insert
                If validar_campos() Then
                    If oClienteSer.insertCliente(txt_nombre.Text, txt_apellido.Text, txt_cuit.Text, cmb_tipo_doc.SelectedValue.ToString, txt_nro_doc.Text.ToString, txt_telefono.Text, txt_mail.Text) Then
                        MessageBox.Show("Cliente insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("¡Error al insertar el Cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.update
                If validar_campos() Then
                    If oClienteSer.updateCliente(cli_codigo, txt_nombre.Text, txt_apellido.Text, txt_cuit.Text, cmb_tipo_doc.SelectedValue.ToString, txt_nro_doc.Text.ToString, txt_telefono.Text, txt_mail.Text) Then
                        MessageBox.Show("¡Cliente modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("¡Error al modificar el Cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar el cliente seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If oClienteSer.deleteCliente(cli_codigo) Then
                        MessageBox.Show("¡Cliente eliminado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
                End If
            Case Opcion.consult
                Me.Dispose()
        End Select
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        If txt_apellido.Text = String.Empty Then
            txt_apellido.BackColor = Color.Red
            txt_apellido.Focus()
            Return False
        Else
            txt_apellido.BackColor = Color.White
        End If

        If txt_nro_doc.Text = String.Empty Then
            txt_nro_doc.BackColor = Color.Red
            txt_nro_doc.Focus()
            Return False
        Else
            txt_nro_doc.BackColor = Color.White
        End If

        If cmb_tipo_doc.Text = String.Empty Then
            cmb_tipo_doc.BackColor = Color.Red
            cmb_tipo_doc.Focus()
            Return False
        Else
            cmb_tipo_doc.BackColor = Color.White
        End If

        Return True
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        Dim oClienteSer As New ClienteServices
        If validar_campos() Then
            If oClienteSer.insertCliente(txt_nombre.Text, txt_apellido.Text, txt_cuit.Text, cmb_tipo_doc.SelectedValue.ToString, txt_nro_doc.Text.ToString, txt_telefono.Text, txt_mail.Text) Then
                MessageBox.Show("Cliente insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Frm_Tr_Venta.setearDatosClienteNuevo(txt_nombre.Text, txt_apellido.Text, txt_cuit.Text, cmb_tipo_doc.Text, txt_nro_doc.Text.ToString, txt_telefono.Text, txt_mail.Text)
                Me.Dispose()
            Else
                MessageBox.Show("¡Error al insertar el Cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class