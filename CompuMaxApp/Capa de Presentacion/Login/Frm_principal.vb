Public Class Frm_principal
    Private userLog As Usuario
    Private Sub Frm_Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Seguro que desea salir de la aplicación?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
            End
        Else
            'La propiedad e.Cancel permite cancelar el evento recibido.
            e.Cancel = True
        End If
    End Sub

    Private Sub Frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Al cargar el formulario principal cargamos y mostramos el formulario: Frm_login en forma MODAL.
        MenuStrip1.Visible = False
        Login.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub actualizarUsuarioLogueado(ByVal user As Usuario)
        Dim oUsuarioService As New UsuarioServices
        Me.Text = Me.Text + oUsuarioService.obtenerNombreYGrupoUsuario(user)
        MenuStrip1.Visible = True
        userLog = user
    End Sub
    Public Function getUsuarioLogeado() As Usuario
        Return userLog
    End Function

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Frm_Producto.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Frm_Usuario.Show()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        Frm_ABMTabla_Marca.Show()
    End Sub

    Private Sub TipoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoProductoToolStripMenuItem.Click
        Frm_ABMTabla_TipoProducto.Show()
    End Sub

    Private Sub TipoDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDocumentoToolStripMenuItem.Click
        Frm_ABMTabla_TipoDocumento.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Frm_AMBTabla_Categoria.Show()
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoToolStripMenuItem.Click
        Frm_ABMTabla_Grupo.Show()
    End Sub

    Private Sub ComboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboToolStripMenuItem.Click
        Frm_ABMTabla_Combo.Show()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        Frm_Proveedor.Show()
    End Sub

    Private Sub SoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteToolStripMenuItem.Click

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Frm_Cliente.Show()
    End Sub

    Private Sub GrupoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoUsuarioToolStripMenuItem.Click
        Frm_GrupoUsuario.Show()
    End Sub

    Private Sub ComboProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboProductoToolStripMenuItem.Click
        Frm_ABM_ComboProducto.Show()
    End Sub

    Private Sub DescuentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentoToolStripMenuItem.Click
        Frm_ABMTabla_Promocion.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        Frm_Tr_Venta.Show()
    End Sub

    Private Sub StockProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockProductoToolStripMenuItem.Click
        Frm_stock.Show()
    End Sub

    Private Sub ReporteDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeClientesToolStripMenuItem.Click
        Frm_Reporte_Clientes.Show()
    End Sub

    Private Sub ReoirteDeVentasXPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReoirteDeVentasXPeriodoToolStripMenuItem.Click
        Frm_Reporte_VentasXPeriodo.Show()
    End Sub

    Private Sub ReporteDeCombosVendidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCombosVendidoToolStripMenuItem.Click
        Frm_Reporte_Combos_Vendidos.Show()
    End Sub

    Private Sub ReporteDeProductosVendidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProductosVendidoToolStripMenuItem.Click
        Frm_Reporte_Productos_Vendidos.Show()
    End Sub

    Private Sub ReporteDeStockDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeStockDeProductosToolStripMenuItem.Click
        Frm_Reporte_Stock_Productos.Show()
    End Sub

    Private Sub ReporteDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProveedoresToolStripMenuItem.Click
        Frm_Reporte_Proveedores.Show()
    End Sub

End Class