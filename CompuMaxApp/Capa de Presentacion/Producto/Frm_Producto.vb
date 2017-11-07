Public Class Frm_Producto

    Private Sub Frm_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oTipoProdServices As New TipoProductoServices
        oTipoProdServices.llenarComboGrupo(cmb_tipoProd)
        Dim oMarcaServices As New MarcaServices
        oMarcaServices.llenarComboGrupo(cmb_marca)
        Dim oCategoriaServices As New CategoriaServices
        oCategoriaServices.llenarComboGrupo(cmb_categoria)
        btn_editar.Enabled = False
        btn_consultar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_denom.Enabled = False
            cmb_tipoProd.Enabled = False
            cmb_marca.Enabled = False
            cmb_categoria.Enabled = False
        Else
            txt_denom.Enabled = True
            cmb_tipoProd.Enabled = True
            cmb_marca.Enabled = True
            cmb_categoria.Enabled = True
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
            Frm_principal.Show()
        End If
    End Sub

    Private Sub btn_consultar_filtros_Click(sender As Object, e As EventArgs) Handles btn_consultar_filtros.Click
        btn_editar.Enabled = False
        btn_consultar.Enabled = False
        btn_eliminar.Enabled = False
        Dim oProductoServ As New ProductoServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable
        Dim nStateChk As Integer

        If chk_todos.CheckState = CheckState.Checked Then
            bflag_filtros = True
            nStateChk = 1
        Else
            nStateChk = 0
            If txt_denom.Text = String.Empty And cmb_categoria.Text = String.Empty And cmb_marca.Text = String.Empty And cmb_tipoProd.Text = String.Empty Then
                bflag_filtros = False
            Else
                bflag_filtros = True
            End If
        End If

        If bflag_filtros Then
            oTabla = oProductoServ.obtenerProductos(txt_denom.Text, cmb_tipoProd.Text, cmb_marca.Text, cmb_categoria.Text, nStateChk)
            Me.llenar_grid(oTabla)
        Else
            MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_productos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_productos.Rows.Add(New String() {row.Item("prod_codigo").ToString, row.Item("prod_denom").ToString, row.Item("tpr_denom").ToString, row.Item("mar_denom").ToString, row.Item("prod_numserie").ToString, row.Item("prod_precio").ToString, row.Item("est_codigo").ToString, row.Item("cat_denom").ToString})
        Next
    End Sub

    Private Sub dgv_productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick
        btn_editar.Enabled = True
        btn_consultar.Enabled = True
        btn_eliminar.Enabled = True
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABMC_producto.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABMC_producto.seleccionar_producto(Frm_ABMC_producto.Opcion.update, dgv_productos.CurrentRow)
        Frm_ABMC_producto.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Frm_ABMC_producto.seleccionar_producto(Frm_ABMC_producto.Opcion.delete, dgv_productos.CurrentRow)
        Frm_ABMC_producto.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Frm_ABMC_producto.seleccionar_producto(Frm_ABMC_producto.Opcion.consult, dgv_productos.CurrentRow)
        Frm_ABMC_producto.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub
End Class