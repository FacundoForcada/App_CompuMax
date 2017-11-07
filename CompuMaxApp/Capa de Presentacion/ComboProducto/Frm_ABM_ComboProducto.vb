Public Class Frm_ABM_ComboProducto
    Dim nCantProd As Integer

    Private Sub btn_consultar_cmb_Click(sender As Object, e As EventArgs) Handles btn_consultar_cmb.Click
        If cmb_comofiltro.Text <> String.Empty Then
            mostrarComboProducto()
        Else
            MessageBox.Show("Debe seleccionar un Combo primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub mostrarComboProducto()
        Dim oComboProductoServices As New ComboProductoServices
        Dim oTabla As DataTable
        mostrarTextoComboSeleccionado(cmb_comofiltro.Text)
        oTabla = oComboProductoServices.obtenerProductosXCombo(cmb_comofiltro.Text)
        llenar_grid_cmbprod(oTabla)

    End Sub

    Private Sub llenar_grid_cmbprod(ByVal source As DataTable)
        dgv_combo_productos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_combo_productos.Rows.Add(New String() {row.Item("com_codigo").ToString, row.Item("prod_codigo").ToString, row.Item("prod_denom").ToString, row.Item("cmp_cantprod").ToString})
        Next
    End Sub

    Private Sub Frm_ABM_ComboProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oComboServices As New ComboServices
        oComboServices.llenarComboGrupoCompleto(cmb_comofiltro)
        btn_agregar_producto.Enabled = False
        btn_quitar_producto.Enabled = False
        lbl_tittle_grp.Visible = False
        lbl_cmb.Visible = False
        btn_consultar_cmb.Enabled = True
    End Sub

    Private Sub dgv_combo_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_combo_productos.CellContentClick
        btn_quitar_producto.Enabled = True
    End Sub

    Private Sub mostrarTextoComboSeleccionado(ByVal texto As String)
        lbl_tittle_grp.Visible = True
        lbl_cmb.Visible = True
        lbl_cmb.Text = texto
    End Sub

    Private Sub btn_consultar_producto_Click(sender As Object, e As EventArgs) Handles btn_consultar_producto.Click
        Dim oProductoServ As New ProductoServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable
        Dim nStateChk As Integer

        If chk_todos.CheckState = CheckState.Checked Then
            nStateChk = 1
        Else
            nStateChk = 0
        End If


        If chk_todos.CheckState = CheckState.Checked Then
            bflag_filtros = True
            nStateChk = 1
        Else
            nStateChk = 0
            If txt_producto.Text = String.Empty Then
                bflag_filtros = False
            End If
        End If

        If bflag_filtros Then
            oTabla = oProductoServ.obtenerProductoYMarca(cmb_comofiltro.SelectedValue.ToString, txt_producto.Text, nStateChk)
            Me.llenar_grid_producto(oTabla)

        Else
            MessageBox.Show("Debe ingresar al menos un criterio de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub llenar_grid_producto(ByVal source As DataTable)
        dgv_productos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_productos.Rows.Add(New String() {row.Item("prod_codigo").ToString, row.Item("prod_denom").ToString, row.Item("mar_denom").ToString})
        Next
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_producto.Enabled = False
        Else
            txt_producto.Enabled = True
        End If
    End Sub

    Private Sub btn_agregar_producto_Click(sender As Object, e As EventArgs) Handles btn_agregar_producto.Click
        Dim oComboProductoSer As New ComboProductoServices
        Dim row_selected As DataGridViewRow
        row_selected = dgv_productos.CurrentRow
        If cmb_comofiltro.Text <> String.Empty Then
            Frm_AgregarCantProd.ShowDialog()
            oComboProductoSer.agregarProducto(cmb_comofiltro.SelectedValue().ToString, row_selected.Cells("prod_codigo_P").Value, nCantProd)
        Else
            MessageBox.Show("Debe seleccionar un Combo en la parte de arriba", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        btn_consultar_cmb_Click(sender, e)
    End Sub

    Public Sub asignar_cantidad(ByVal cantidad As Integer)
        nCantProd = cantidad
    End Sub

    Private Sub dgv_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick
        btn_agregar_producto.Enabled = True
    End Sub

    Private Sub btn_quitar_producto_Click(sender As Object, e As EventArgs) Handles btn_quitar_producto.Click
        Dim oComboProductoSer As New ComboProductoServices
        Dim row_selected As DataGridViewRow
        row_selected = dgv_combo_productos.CurrentRow
        If row_selected.Cells.Count > 0 Then
            oComboProductoSer.quitarProducto(row_selected.Cells("prod_codigo").Value, row_selected.Cells("com_codigo").Value)
        Else
            MessageBox.Show("Debe seleccionar un Producto a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        btn_consultar_cmb_Click(sender, e)
    End Sub

    Private Sub cmb_comofiltro_MouseClick(sender As Object, e As EventArgs) Handles cmb_comofiltro.MouseClick
        If cmb_comofiltro.Text <> String.Empty Then
            mostrarComboProducto()
        End If
    End Sub
End Class