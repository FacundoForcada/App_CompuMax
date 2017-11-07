<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescuentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReoirteDeVentasXPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCombosVendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProductosVendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeStockDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoporteToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(780, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriaToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.ComboToolStripMenuItem, Me.ComboProductoToolStripMenuItem, Me.DescuentoToolStripMenuItem, Me.GrupoToolStripMenuItem, Me.GrupoProcesoToolStripMenuItem, Me.GrupoUsuarioToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.StockProductoToolStripMenuItem, Me.TipoDocumentoToolStripMenuItem, Me.TipoProductoToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SoporteToolStripMenuItem.Text = "Soporte"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CategoriaToolStripMenuItem.Text = "< Categoria >"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ClienteToolStripMenuItem.Text = "< Cliente >"
        '
        'ComboToolStripMenuItem
        '
        Me.ComboToolStripMenuItem.Name = "ComboToolStripMenuItem"
        Me.ComboToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ComboToolStripMenuItem.Text = "< Combo >"
        '
        'ComboProductoToolStripMenuItem
        '
        Me.ComboProductoToolStripMenuItem.Name = "ComboProductoToolStripMenuItem"
        Me.ComboProductoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ComboProductoToolStripMenuItem.Text = "< Combo Producto >"
        '
        'DescuentoToolStripMenuItem
        '
        Me.DescuentoToolStripMenuItem.Name = "DescuentoToolStripMenuItem"
        Me.DescuentoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DescuentoToolStripMenuItem.Text = "< Promocion >"
        '
        'GrupoToolStripMenuItem
        '
        Me.GrupoToolStripMenuItem.Name = "GrupoToolStripMenuItem"
        Me.GrupoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GrupoToolStripMenuItem.Text = "< Grupo >"
        '
        'GrupoProcesoToolStripMenuItem
        '
        Me.GrupoProcesoToolStripMenuItem.Enabled = False
        Me.GrupoProcesoToolStripMenuItem.Name = "GrupoProcesoToolStripMenuItem"
        Me.GrupoProcesoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GrupoProcesoToolStripMenuItem.Text = "Grupo Proceso"
        '
        'GrupoUsuarioToolStripMenuItem
        '
        Me.GrupoUsuarioToolStripMenuItem.Name = "GrupoUsuarioToolStripMenuItem"
        Me.GrupoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GrupoUsuarioToolStripMenuItem.Text = "<Grupo Usuario>"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MarcaToolStripMenuItem.Text = "< Marca >"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ProductoToolStripMenuItem.Text = "< Producto >"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ProveedorToolStripMenuItem.Text = "< Proveedor >"
        '
        'StockProductoToolStripMenuItem
        '
        Me.StockProductoToolStripMenuItem.Name = "StockProductoToolStripMenuItem"
        Me.StockProductoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.StockProductoToolStripMenuItem.Text = "< Stock Producto >"
        '
        'TipoDocumentoToolStripMenuItem
        '
        Me.TipoDocumentoToolStripMenuItem.Name = "TipoDocumentoToolStripMenuItem"
        Me.TipoDocumentoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TipoDocumentoToolStripMenuItem.Text = "< Tipo Documento >"
        '
        'TipoProductoToolStripMenuItem
        '
        Me.TipoProductoToolStripMenuItem.Name = "TipoProductoToolStripMenuItem"
        Me.TipoProductoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TipoProductoToolStripMenuItem.Text = "< Tipo Producto >"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UsuarioToolStripMenuItem.Text = "< Usuario >"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeClientesToolStripMenuItem, Me.ReoirteDeVentasXPeriodoToolStripMenuItem, Me.ReporteDeCombosVendidoToolStripMenuItem, Me.ReporteDeProductosVendidoToolStripMenuItem, Me.ReporteDeProveedoresToolStripMenuItem, Me.ReporteDeStockDeProductosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeClientesToolStripMenuItem
        '
        Me.ReporteDeClientesToolStripMenuItem.Name = "ReporteDeClientesToolStripMenuItem"
        Me.ReporteDeClientesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes"
        '
        'ReoirteDeVentasXPeriodoToolStripMenuItem
        '
        Me.ReoirteDeVentasXPeriodoToolStripMenuItem.Name = "ReoirteDeVentasXPeriodoToolStripMenuItem"
        Me.ReoirteDeVentasXPeriodoToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReoirteDeVentasXPeriodoToolStripMenuItem.Text = "Reporte de Ventas X Periodo"
        '
        'ReporteDeCombosVendidoToolStripMenuItem
        '
        Me.ReporteDeCombosVendidoToolStripMenuItem.Name = "ReporteDeCombosVendidoToolStripMenuItem"
        Me.ReporteDeCombosVendidoToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReporteDeCombosVendidoToolStripMenuItem.Text = "Reporte de Combos Vendidos"
        '
        'ReporteDeProductosVendidoToolStripMenuItem
        '
        Me.ReporteDeProductosVendidoToolStripMenuItem.Name = "ReporteDeProductosVendidoToolStripMenuItem"
        Me.ReporteDeProductosVendidoToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReporteDeProductosVendidoToolStripMenuItem.Text = "Reporte de Productos Vendidos"
        '
        'ReporteDeProveedoresToolStripMenuItem
        '
        Me.ReporteDeProveedoresToolStripMenuItem.Name = "ReporteDeProveedoresToolStripMenuItem"
        Me.ReporteDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReporteDeProveedoresToolStripMenuItem.Text = "Reporte de Proveedores"
        '
        'ReporteDeStockDeProductosToolStripMenuItem
        '
        Me.ReporteDeStockDeProductosToolStripMenuItem.Name = "ReporteDeStockDeProductosToolStripMenuItem"
        Me.ReporteDeStockDeProductosToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReporteDeStockDeProductosToolStripMenuItem.Text = "Reporte de Stock de Productos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.CompuMaxPNG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(780, 463)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compu Max App - v.2.5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoProcesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDocumentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescuentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReoirteDeVentasXPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeCombosVendidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeProductosVendidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeStockDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
