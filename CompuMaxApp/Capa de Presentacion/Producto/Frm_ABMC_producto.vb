Public Class Frm_ABMC_producto
    Enum Opcion
        insert
        update
        delete
        consult
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_ABMC_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oMarcaServices As New MarcaServices
        Dim oTipoProdServices As New TipoProductoServices
        Dim oCategoriaServices As New CategoriaServices
        Dim oProductoServices As New ProductoServices
        oTipoProdServices.llenarComboGrupo(cmb_tipoProd)
        oMarcaServices.llenarComboGrupo(cmb_marca)
        oCategoriaServices.llenarComboGrupo(cmb_categoria)

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Producto"
                _row_selected = Nothing
                btn_aceptar.Text = "Agregar"
                lbl_prod_codigo.Visible = False
                txt_prod_codigo.Visible = False

            Case Opcion.update
                Me.Text = "Actualizar Producto"
                'Recuperar usuario seleccionado en la grilla 
                mostrar_datos()
                txt_denom.Enabled = True
                txt_numserie.Enabled = True
                txt_precio.Enabled = True
                cmb_marca.Enabled = True
                cmb_tipoProd.Enabled = True
                cmb_categoria.Enabled = True
                btn_aceptar.Text = "Actualizar"

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar Producto"
                txt_denom.Enabled = False
                txt_numserie.Enabled = False
                txt_precio.Enabled = False
                cmb_marca.Enabled = False
                cmb_tipoProd.Enabled = False
                cmb_categoria.Enabled = False
                btn_aceptar.Text = "Eliminar"

            Case Opcion.consult
                mostrar_datos()
                Me.Text = "Consultar Producto"
                txt_denom.Enabled = False
                txt_numserie.Enabled = False
                txt_precio.Enabled = False
                cmb_marca.Enabled = False
                cmb_tipoProd.Enabled = False
                cmb_categoria.Enabled = False
                btn_aceptar.Text = "Aceptar"
                btn_cancelar.Visible = False

        End Select
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_prod_codigo.Text = _row_selected.Cells("prod_codigo").Value
            txt_denom.Text = _row_selected.Cells("prod_denom").Value
            txt_precio.Text = _row_selected.Cells("prod_precio").Value
            txt_numserie.Text = _row_selected.Cells("prod_numserie").Value
            cmb_marca.Text = _row_selected.Cells("mar_denom").Value
            cmb_tipoProd.Text = _row_selected.Cells("tpr_denom").Value
            cmb_categoria.Text = _row_selected.Cells("cat_denom").Value
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub

    Public Sub seleccionar_producto(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_denom.Text = String.Empty Then
            txt_denom.BackColor = Color.Red
            txt_denom.Focus()
            Return False
        Else
            txt_denom.BackColor = Color.White
        End If

        If txt_numserie.Text = String.Empty Then
            txt_numserie.BackColor = Color.Red
            txt_numserie.Focus()
            Return False
        Else
            txt_numserie.BackColor = Color.White
        End If

        If cmb_marca.Text = String.Empty Then
            cmb_marca.BackColor = Color.Red
            cmb_marca.Focus()
            Return False
        Else
            cmb_marca.BackColor = Color.White
        End If

        If cmb_tipoProd.Text = String.Empty Then
            cmb_tipoProd.BackColor = Color.Red
            cmb_tipoProd.Focus()
            Return False
        Else
            cmb_tipoProd.BackColor = Color.White
        End If

        If cmb_categoria.Text = String.Empty Then
            cmb_categoria.BackColor = Color.Red
            cmb_categoria.Focus()
            Return False
        Else
            cmb_categoria.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_nombre() As Boolean
        Dim oProductoServices As New ProductoServices
        Return oProductoServices.validarNombreProducto(txt_denom.Text)
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim oProductoServices As New ProductoServices
        Dim nDevuelto As Integer

        Select Case _action
            Case Opcion.insert
                If existe_nombre() = False Then
                    If validar_campos() Then
                        nDevuelto = oProductoServices.productoInsert(txt_denom.Text, cmb_tipoProd.SelectedValue.ToString, cmb_marca.SelectedValue.ToString, txt_numserie.Text, txt_precio.Text, cmb_categoria.SelectedValue.ToString)
                        If nDevuelto > 0 Then
                            MessageBox.Show("Producto insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al Insertar el Producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Nombre de Producto encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    nDevuelto = oProductoServices.productoUpdate(txt_prod_codigo.Text, txt_denom.Text, cmb_tipoProd.SelectedValue.ToString, cmb_marca.SelectedValue.ToString, txt_numserie.Text, txt_precio.Text, cmb_categoria.SelectedValue.ToString)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Producto actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar el Producto seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    nDevuelto = oProductoServices.productoDelete(txt_prod_codigo.Text)
                    If nDevuelto > 0 Then
                        MessageBox.Show("Producto Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al deshabilitar el Producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.consult
                Me.Dispose()
        End Select
    End Sub

    Private Sub txt_numserie_TextChanged(sender As Object, e As EventArgs) Handles txt_numserie.TextChanged

    End Sub

    Private Sub cmb_tipoProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipoProd.SelectedIndexChanged

    End Sub
End Class