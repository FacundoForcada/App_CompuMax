Public Class Frm_ABMTabla_Marca

    Private Sub Frm_ABMTabla_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        Dim oMarcaServices As New MarcaServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable

        oTabla = oMarcaServices.obtenerMarcas()
        Me.llenar_grid(oTabla)
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_marcas.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_marcas.Rows.Add(New String() {row.Item("mar_codigo").ToString, row.Item("mar_denom").ToString, row.Item("est_denom").ToString})
        Next
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABM_marca.ShowDialog()
        Frm_ABMTabla_Marca_Load(sender, e)
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

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABM_marca.seleccionar_marca(Frm_ABM_marca.Opcion.update, dgv_marcas.CurrentRow)
        Frm_ABM_marca.ShowDialog()
        Frm_ABMTabla_Marca_Load(sender, e)
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Frm_ABM_marca.seleccionar_marca(Frm_ABM_marca.Opcion.delete, dgv_marcas.CurrentRow)
        Frm_ABM_marca.ShowDialog()
        Frm_ABMTabla_Marca_Load(sender, e)
    End Sub

    Private Sub dgv_marcas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_marcas.CellContentClick
        btn_editar.Enabled = True
        btn_borrar.Enabled = True
    End Sub
End Class