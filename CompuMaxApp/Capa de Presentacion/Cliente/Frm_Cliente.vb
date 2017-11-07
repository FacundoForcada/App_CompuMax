Public Class Frm_Cliente

    Private Sub Frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oTipoDocumento As New TipoDocumentoServices
        oTipoDocumento.llenarComboGrupo(cmb_tipo_doc)
        btn_editar.Enabled = False
        btn_consultar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Friend Sub habilitar_botones_C_Cliente()
        btn_aceptar.Visible = True
        btn_editar.Visible = True
        btn_eliminar.Visible = False
        btn_consultar.Visible = False
        btn_aceptar.Enabled = False
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_clientes.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_clientes.Rows.Add(New String() {row.Item("cli_codigo").ToString, row.Item("cli_nombre").ToString, row.Item("cli_apellido").ToString, row.Item("cli_cuit").ToString, row.Item("tdc_codigo").ToString, row.Item("tdc_denom").ToString, row.Item("cli_numdoc").ToString, row.Item("cli_telefono").ToString, row.Item("cli_mail").ToString, row.Item("est_codigo").ToString})
        Next
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_nombre.Enabled = False
            txt_apellido.Enabled = False
            txt_nro_doc.Enabled = False
            cmb_tipo_doc.Enabled = False
        Else
            txt_nombre.Enabled = True
            txt_apellido.Enabled = True
            txt_nro_doc.Enabled = True
            cmb_tipo_doc.Enabled = True
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABMC_cliente.seleccionar_cliente(Frm_ABMC_cliente.Opcion.insert, Nothing)
        Frm_ABMC_cliente.ShowDialog()
    End Sub
    Private Sub btn_consultar_filtros_Click(sender As Object, e As EventArgs) Handles btn_consultar_filtros.Click
        btn_editar.Enabled = False
        btn_consultar.Enabled = False
        btn_eliminar.Enabled = False
        btn_aceptar.Enabled = False
        Dim oClienteServ As New ClienteServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable
        Dim nStateChk As Integer

        If chk_todos.CheckState = CheckState.Checked Then
            bflag_filtros = True
            nStateChk = 1
        Else
            nStateChk = 0
            If txt_nombre.Text = String.Empty And txt_apellido.Text = String.Empty And txt_nro_doc.Text = String.Empty And cmb_tipo_doc.Text = String.Empty Then
                bflag_filtros = False
            Else
                bflag_filtros = True
            End If
        End If

        If bflag_filtros Then
            oTabla = oClienteServ.obtenerClientes(txt_nombre.Text, txt_apellido.Text, txt_nro_doc.Text, cmb_tipo_doc.SelectedValue(), nStateChk)
            Me.llenar_grid(oTabla)
        Else
            MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub dgv_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        btn_editar.Enabled = True
        btn_eliminar.Enabled = True
        btn_consultar.Enabled = True
        btn_aceptar.Enabled = True
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABMC_cliente.seleccionar_cliente(Frm_ABMC_cliente.Opcion.update, dgv_clientes.CurrentRow)
        Frm_ABMC_cliente.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Frm_ABMC_cliente.seleccionar_cliente(Frm_ABMC_cliente.Opcion.delete, dgv_clientes.CurrentRow)
        Frm_ABMC_cliente.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Frm_ABMC_cliente.seleccionar_cliente(Frm_ABMC_cliente.Opcion.consult, dgv_clientes.CurrentRow)
        Frm_ABMC_cliente.ShowDialog()
        btn_consultar_filtros_Click(sender, e)
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Frm_Tr_Venta.setearDatosCliente(dgv_clientes.CurrentRow())
        Me.Close()
    End Sub
End Class