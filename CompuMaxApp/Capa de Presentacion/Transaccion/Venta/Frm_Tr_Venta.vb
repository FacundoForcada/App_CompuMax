Public Class Frm_Tr_Venta

    Dim _selected_row As DataGridViewRow

    Private Sub Frm_Tr_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oTipoProdServices As New TipoProductoServices
        oTipoProdServices.llenarComboGrupo(cmb_tipoprod)
        Dim oMarcaServices As New MarcaServices
        oMarcaServices.llenarComboGrupo(cmb_marca)
        Dim oCategoriaServices As New CategoriaServices
        oCategoriaServices.llenarComboGrupo(cmb_categoria)
        Dim oPromocionServices As New PromocionServices
        oPromocionServices.llenarComboGrupo(cmb_prom_denom)

        btn_editar.Enabled = False
        btn_eliminar.Enabled = False
        btn_agregar_prod.Visible = False
        txt_subtotal_combo.Text = "0"
        txt_subtotal_combo.Enabled = False
        txt_subtotal_prod.Text = "0"
        txt_subtotal_prod.Enabled = False
        txt_totalgral.Text = "0"
        txt_totalgral.Enabled = False
        chk_productos.CheckState = CheckState.Checked
        chk_combos.CheckState = CheckState.Unchecked
        Me.llenar_combo_NombreProducto()
        mtxt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm")
    End Sub

    Private Sub btn_buscar_cliente_Click(sender As Object, e As EventArgs) Handles btn_buscar_cliente.Click
        Frm_Cliente.habilitar_botones_C_Cliente()
        Frm_Cliente.ShowDialog()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABMC_cliente.habilitar_creacion()
        Frm_ABMC_cliente.ShowDialog()
    End Sub

    Private Sub btn_agregar_prod_Click(sender As Object, e As EventArgs) Handles btn_agregar_prod.Click
        If validarCampos() Then
            Dim bFlag As Boolean = False
            If chk_productos.CheckState = CheckState.Checked Then
                For Each row As DataGridViewRow In dgv_productos.Rows
                    If row.Cells("prod_denom").Value = cmb_prod_denom.Text Then
                        bFlag = True
                    End If
                Next
                If bFlag = False Then
                    Me.agregar_Productos()
                Else
                    MessageBox.Show("El producto ya fue ingresado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                For Each row As DataGridViewRow In dgv_combos_listado.Rows
                    If row.Cells("combo_denom").Value = cmb_prod_denom.Text Then
                        bFlag = True
                    End If
                Next
                If bFlag = False Then
                    Me.agregar_Combos()
                Else
                    MessageBox.Show("El combo ya fue ingresado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Me.clear_filtros()
            calcularTotales()
        End If
    End Sub
    Private Function validarCampos() As Boolean
        Dim flag As Boolean = True
        If txt_cant.Text = String.Empty Then
            flag = False
            txt_cant.BackColor = Color.Red
        End If
        If cmb_prom_denom.Text = String.Empty Then
            flag = False
            cmb_prom_denom.BackColor = Color.Red
        End If
        Return flag
    End Function
    Private Sub agregar_Productos()
        Dim oProducto As New ProductoServices
        Dim source As DataTable = oProducto.obtenerProductosFiltro(cmb_prod_denom.Text, cmb_tipoprod.Text, cmb_marca.Text, cmb_categoria.Text, txt_cant.Text, cmb_prom_denom.SelectedValue)
        For Each row As DataRow In source.Rows
            dgv_productos.Rows.Add(New String() {row.Item("prod_codigo").ToString, row.Item("prod_denom").ToString, row.Item("tpr_codigo").ToString, row.Item("tpr_denom").ToString, row.Item("cat_codigo").ToString, row.Item("cat_denom").ToString, row.Item("mar_codigo").ToString, row.Item("mar_denom").ToString, row.Item("prod_numserie").ToString, row.Item("ved_cantidad").ToString, row.Item("prod_precio").ToString, row.Item("prod_prom_codigo").ToString, row.Item("prod_prom_denom").ToString, row.Item("prod_prom_desc").ToString, row.Item("subtotal").ToString})
        Next
    End Sub

    Private Sub agregar_Combos()
        Dim oComboServices As New ComboServices
        ' Dim oComboProductoServices As New ComboProductoServices
        Dim sourceCombo As DataTable = oComboServices.obtenerComboFiltro(cmb_prod_denom.Text, cmb_categoria.Text, txt_cant.Text, cmb_prom_denom.SelectedValue)
        'Dim sourceDetalle As DataTable = oComboProductoServices.obtenerProductosXComboFiltro(cmb_prod_denom.Text, cmb_categoria.Text, txt_cant.Text)
        'For Each row As DataRow In sourceDetalle.Rows
        'dgv_combos.Rows.Add(New String() {row.Item("com_com_codigo").ToString, row.Item("com_com_denom").ToString, row.Item("com_prod_codigo").ToString, row.Item("com_prod_denom").ToString, row.Item("com_tpr_codigo").ToString, row.Item("com_tpr_denom").ToString, row.Item("com_cat_codigo").ToString, row.Item("com_cat_denom").ToString, row.Item("com_mar_codigo").ToString, row.Item("com_mar_denom").ToString, row.Item("com_prod_numserie").ToString, row.Item("com_prod_cantidad").ToString})
        'Next
        For Each row As DataRow In sourceCombo.Rows
            'Dim as2 As String = row.Item("com_descuento").ToString
            'Dim as3 As String = row.Item("combo_denom").ToString
            'com_prom_codigo,com_prom_denom,com_prom_desc
            dgv_combos_listado.Rows.Add(New String() {row.Item("combo_codigo").ToString, row.Item("combo_denom").ToString, row.Item("com_categoria_codigo").ToString, row.Item("com_categoria_denom").ToString, row.Item("com_cantidad").ToString, row.Item("com_precio").ToString, row.Item("com_prom_codigo").ToString, row.Item("com_prom_denom").ToString, row.Item("com_prom_desc").ToString, row.Item("com_subtotal").ToString})
        Next
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If Me.cargoCliente() = False Then
            MessageBox.Show("Debe cargar el Cliente de la Venta!", "¡Vuelva a intentarlo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If dgv_combos_listado.Rows.Count = 0 And dgv_productos.Rows.Count = 0 Then
            MessageBox.Show("Debe cargar Productos o Combos a la venta!", "¡Vuelva a intentarlo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim oVentaServices As New VentaServices
        Dim nResultado As Integer = oVentaServices.realizarVenta(txt_cli_codigo.Text, mtxt_fecha.Text, dgv_combos_listado, dgv_productos)
        If nResultado = dgv_combos_listado.Rows.Count + dgv_productos.Rows.Count + 1 Then
            txt_nro_factura.Text = oVentaServices.getInsertedVenta()
            MessageBox.Show("Venta Numero: " + txt_nro_factura.Text + " " + vbNewLine + "Fecha: " + mtxt_fecha.Text + ". ", "¡Venta cargada con exito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al realizar la venta", "¡Algo salio mal, vuelva a intentarlo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.clear_Variables()
        Me.Close()
    End Sub

    Private Function cargoCliente() As Boolean
        If txt_cli_numdoc.Text <> String.Empty Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub clear_Variables()
        dgv_combos.Rows.Clear()
        dgv_combos_listado.Rows.Clear()
        dgv_productos.Rows.Clear()
        txt_subtotal_combo.Text = String.Empty
        txt_subtotal_prod.Text = String.Empty
        txt_totalgral.Text = String.Empty
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'Confirmación de salida.
        If MessageBox.Show("¿Seguro que desea salir? Se perderan los datos guardados de la Venta", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
            Frm_principal.Show()
        End If
    End Sub

    Private Sub chk_productos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_productos.CheckedChanged
        If chk_productos.CheckState = CheckState.Checked Then
            chk_combos.CheckState = CheckState.Unchecked
            cmb_categoria.Enabled = True
            cmb_prod_denom.Enabled = True
            cmb_marca.Enabled = True
            cmb_tipoprod.Enabled = True
            cmb_prod_denom.Enabled = True
            TabControl1.SelectTab(0)
        Else
            chk_combos.CheckState = CheckState.Checked
            TabControl1.SelectTab(1)
        End If
        Me.clear_filtros()
    End Sub

    Private Sub chk_combos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_combos.CheckedChanged
        If chk_combos.CheckState = CheckState.Checked Then
            chk_productos.CheckState = CheckState.Unchecked
            cmb_categoria.Enabled = True
            cmb_prod_denom.Enabled = True
            cmb_prom_denom.Enabled = True
            cmb_marca.Enabled = False
            cmb_tipoprod.Enabled = False
            TabControl1.SelectTab(1)
        Else
            chk_productos.CheckState = CheckState.Checked
            TabControl1.SelectTab(0)
        End If
        Me.clear_filtros()
        Me.llenar_combo_NombreProducto()
    End Sub

    Private Sub llenar_combo_NombreProducto()
        Dim oProductoServices As New ProductoServices
        Dim oComboServices As New ComboServices
        If chk_productos.CheckState = CheckState.Checked Then
            oProductoServices.llenarComboGrupo(cmb_prod_denom, cmb_categoria.Text, cmb_tipoprod.Text, cmb_marca.Text)
        Else
            oComboServices.llenarComboFiltroCat(cmb_prod_denom, cmb_categoria.Text)
        End If
    End Sub

    Private Sub clear_filtros()
        cmb_categoria.Text = ""
        cmb_marca.Text = ""
        cmb_tipoprod.Text = ""
        cmb_prod_denom.Text = ""
        cmb_prom_denom.Text = ""
        txt_cant.Text = ""
    End Sub

    Private Sub cmb_marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_marca.SelectedIndexChanged
        Me.llenar_combo_NombreProducto()
    End Sub

    Private Sub cmb_tipoprod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipoprod.SelectedIndexChanged
        Me.llenar_combo_NombreProducto()
    End Sub

    Private Sub cmb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_categoria.SelectedIndexChanged
        Me.llenar_combo_NombreProducto()
    End Sub

    Private Sub cmb_prod_denom_TextChanged(sender As Object, e As EventArgs) Handles cmb_prod_denom.TextChanged
        If cmb_prod_denom.Text = String.Empty Or cmb_prod_denom.Text = "" Then
            btn_agregar_prod.Visible = False
        Else
            btn_agregar_prod.Visible = True
        End If
    End Sub
    Private Sub calcularTotales()
        calcularSubTotalCombo()
        calcularSubTotalProd()
        Dim total As Single = Single.Parse(txt_subtotal_combo.Text) + Single.Parse(txt_subtotal_prod.Text)
        txt_totalgral.Text = total.ToString
    End Sub
    Private Sub calcularSubTotalCombo()

        If dgv_combos_listado.Rows.Count > 0 Then
            Dim subtotal_combo As Single = 0
            For Each row As DataGridViewRow In dgv_combos_listado.Rows
                subtotal_combo += row.Cells("com_subtotal").Value
            Next
            txt_subtotal_combo.Text = subtotal_combo.ToString
        Else
            txt_subtotal_combo.Text = 0
        End If
    End Sub
    Private Sub calcularSubTotalProd()

        If dgv_productos.Rows.Count > 0 Then
            Dim subtotal_prod As Single = 0
            For Each row As DataGridViewRow In dgv_productos.Rows
                subtotal_prod += row.Cells("subtotal").Value
            Next
            txt_subtotal_prod.Text = subtotal_prod.ToString
        Else
            txt_subtotal_prod.Text = 0
        End If
    End Sub
    Private Sub habilitar_btn_confirmar()
        If (txt_subtotal_combo.Text <> String.Empty Or txt_subtotal_prod.Text <> String.Empty) And (txt_totalgral.Text <> String.Empty Or txt_totalgral.Text <> 0) Then
            btn_confirmar.Enabled = True
        Else
            If txt_totalgral.Text <> String.Empty Or txt_totalgral.Text <> 0 Then
                btn_confirmar.Enabled = True
            Else
                btn_confirmar.Enabled = False
            End If
        End If
    End Sub

    Friend Sub setearDatosCliente(ByVal row_selected As DataGridViewRow)
        If Not IsNothing(row_selected) Then
            txt_cli_codigo.Text = row_selected.Cells("cli_codigo").Value
            txt_cli_nombre.Text = row_selected.Cells("cli_nombre").Value
            txt_cli_apellido.Text = row_selected.Cells("cli_apellido").Value
            txt_cli_numdoc.Text = row_selected.Cells("cli_numdoc").Value
            txt_cli_telefono.Text = row_selected.Cells("cli_telefono").Value
            txt_cli_cuit.Text = row_selected.Cells("cli_cuit").Value
            txt_tdc_denom.Text = row_selected.Cells("tdc_denom").Value
            txt_cli_mail.Text = row_selected.Cells("cli_mail").Value
        End If
    End Sub

    Friend Sub setearDatosClienteNuevo(ByVal nombre As String, ByVal apellido As String, ByVal cuit As String, ByVal TipoDoc As String, ByVal NroDoc As String, ByVal telefono As String, ByVal mail As String)
        txt_cli_nombre.Text = nombre.ToString
        txt_cli_apellido.Text = apellido.ToString
        txt_cli_numdoc.Text = NroDoc.ToString
        txt_cli_telefono.Text = telefono.ToString
        txt_cli_cuit.Text = cuit.ToString
        txt_tdc_denom.Text = TipoDoc.ToString
        txt_cli_mail.Text = mail.ToString
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If TabControl1.SelectedTab().Text = "Productos" Then
            If dgv_productos.SelectedCells.Count <> 0 Then
                cmb_categoria.Text = dgv_productos.CurrentRow.Cells.Item("cat_denom").Value
                cmb_tipoprod.Text = dgv_productos.CurrentRow.Cells.Item("tpr_denom").Value
                cmb_marca.Text = dgv_productos.CurrentRow.Cells.Item("mar_denom").Value
                cmb_prod_denom.Text = dgv_productos.CurrentRow.Cells.Item("prod_denom").Value
                txt_cant.Text = dgv_productos.CurrentRow.Cells.Item("ved_cantidad").Value
                cmb_prom_denom.Text = dgv_productos.CurrentRow.Cells.Item("prom_denom").Value
                dgv_productos.Rows.Remove(dgv_productos.CurrentRow)
            Else
                Return
            End If
        End If
        If TabControl1.SelectedTab().Text = "Combos" Then
            If dgv_combos_listado.SelectedCells.Count <> 0 Then
                cmb_categoria.Text = dgv_combos_listado.CurrentRow.Cells("com_categoria_denom").Value
                cmb_prod_denom.Text = dgv_combos_listado.CurrentRow.Cells("combo_denom").Value
                txt_cant.Text = dgv_combos_listado.CurrentRow.Cells("com_cantidad").Value
                cmb_prom_denom.Text = dgv_combos_listado.CurrentRow.Cells("com_prom_denom").Value
                dgv_combos_listado.Rows.Remove(dgv_combos_listado.CurrentRow)
                dgv_combos.Rows.Clear()
                ' For Each row As DataGridViewRow In dgv_combos.Rows
                'If (row.Cells.Item("com_com_denom").Value = cmb_prod_denom.Text) Then
                'dgv_combos.Rows.Remove(row)
                '  End If
                '   Next
            Else
                Return
            End If
        End If
        calcularTotales()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If TabControl1.SelectedTab().Text = "Productos" Then
            dgv_productos.Rows.Remove(dgv_productos.CurrentRow)
        End If
        If TabControl1.SelectedTab().Text = "Combos" Then
            dgv_combos_listado.Rows.Remove(dgv_combos_listado.CurrentRow)
            dgv_combos.Rows.Clear()
        End If
        calcularTotales()
    End Sub

    Private Sub dgv_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellClick
        btn_editar.Enabled = True
        btn_eliminar.Enabled = True
    End Sub

    Private Sub dgv_combos_listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_combos_listado.CellClick
        btn_editar.Enabled = True
        btn_eliminar.Enabled = True
        mostrar_detalle_combo()
    End Sub

    Private Sub dgv_combos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_combos.CellClick
        btn_editar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub mostrar_detalle_combo()
        dgv_combos.Rows.Clear()
        Dim oComboProductoServices As New ComboProductoServices
        Dim sourceDetalle As DataTable = oComboProductoServices.obtenerProductosXComboFiltro(dgv_combos_listado.CurrentRow.Cells("combo_denom").Value, dgv_combos_listado.CurrentRow.Cells("com_categoria_denom").Value, dgv_combos_listado.CurrentRow.Cells("com_cantidad").Value)
        For Each row As DataRow In sourceDetalle.Rows
            dgv_combos.Rows.Add(New String() {row.Item("com_com_codigo").ToString, row.Item("com_com_denom").ToString, row.Item("com_prod_codigo").ToString, row.Item("com_prod_denom").ToString, row.Item("com_tpr_codigo").ToString, row.Item("com_tpr_denom").ToString, row.Item("com_cat_codigo").ToString, row.Item("com_cat_denom").ToString, row.Item("com_mar_codigo").ToString, row.Item("com_mar_denom").ToString, row.Item("com_prod_numserie").ToString, row.Item("com_prod_cantidad").ToString})
        Next
    End Sub

    Private Sub txt_cant_TextChanged(sender As Object, e As EventArgs) Handles txt_cant.TextChanged
        txt_cant.BackColor = Color.White
    End Sub

    Private Sub cmb_prom_denom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prom_denom.SelectedIndexChanged
        cmb_prom_denom.BackColor = Color.White
    End Sub

End Class