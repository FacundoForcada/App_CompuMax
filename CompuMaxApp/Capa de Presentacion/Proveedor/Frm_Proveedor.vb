Public Class Frm_Proveedor

    Private Sub Frm_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_consultar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_proveedor.Enabled = False
            txt_cuit.Enabled = False
        Else
            txt_proveedor.Enabled = True
            txt_cuit.Enabled = True
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
        Dim oProveedorServ As New ProveedorServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable
        Dim nStateChk As Integer

        If chk_todos.CheckState = CheckState.Checked Then
            bflag_filtros = True
            nStateChk = 1
        Else
            nStateChk = 0
            If txt_proveedor.Text = String.Empty And txt_cuit.Text = String.Empty Then
                bflag_filtros = False
            Else
                bflag_filtros = True
            End If
        End If

        If bflag_filtros Then
            oTabla = oProveedorServ.obtenerProveedor(txt_proveedor.Text, Val(txt_cuit.Text), nStateChk)
            Me.llenar_grid(oTabla)
        Else
            MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_proveedores.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_proveedores.Rows.Add(New String() {row.Item("prov_codigo").ToString, row.Item("prov_denom").ToString, row.Item("prov_cuit").ToString, row.Item("est_denom").ToString})
        Next
    End Sub

    Private Sub dgv_proveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_proveedores.CellContentClick
        btn_editar.Enabled = True
        btn_consultar.Enabled = True
        btn_eliminar.Enabled = True
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABMC_Proveedor.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABMC_Proveedor.seleccionar_proveedor(Frm_ABMC_Proveedor.Opcion.update, dgv_proveedores.CurrentRow)
        Frm_ABMC_Proveedor.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Frm_ABMC_Proveedor.seleccionar_proveedor(Frm_ABMC_Proveedor.Opcion.delete, dgv_proveedores.CurrentRow)
        Frm_ABMC_Proveedor.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Frm_ABMC_Proveedor.seleccionar_proveedor(Frm_ABMC_Proveedor.Opcion.consult, dgv_proveedores.CurrentRow)
        Frm_ABMC_Proveedor.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub
End Class