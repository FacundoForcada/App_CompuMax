Public Class Frm_AMBTabla_Categoria

    Private Sub Frm_AMBTabla_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        Dim oCategoriaServices As New CategoriaServices
        Dim bflag_filtros As Boolean = False
        Dim oTabla As DataTable

        oTabla = oCategoriaServices.obtenerCategorias()
        Me.llenar_grid(oTabla)
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_categorias.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_categorias.Rows.Add(New String() {row.Item("cat_codigo").ToString, row.Item("cat_denom").ToString, row.Item("est_denom").ToString})
        Next
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Frm_ABM_categoria.ShowDialog()
        Frm_AMBTabla_Categoria_Load(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_ABM_categoria.seleccionar_categoria(Frm_ABM_categoria.Opcion.update, dgv_categorias.CurrentRow)
        Frm_ABM_categoria.ShowDialog()
        Frm_AMBTabla_Categoria_Load(sender, e)
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Frm_ABM_categoria.seleccionar_categoria(Frm_ABM_categoria.Opcion.delete, dgv_categorias.CurrentRow)
        Frm_ABM_categoria.ShowDialog()
        Frm_AMBTabla_Categoria_Load(sender, e)
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

    Private Sub dgv_categorias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_categorias.CellContentClick
        btn_editar.Enabled = True
        btn_borrar.Enabled = True
    End Sub
End Class