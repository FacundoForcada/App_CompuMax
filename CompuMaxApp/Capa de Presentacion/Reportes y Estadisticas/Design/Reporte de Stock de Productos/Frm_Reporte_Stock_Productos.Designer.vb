<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Stock_Productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Stock_Productos))
        Me.DSReporteStockProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ReporteStockProductos = New CompuMaxApp.DS_ReporteStockProductos()
        Me.grp_product_filter = New System.Windows.Forms.GroupBox()
        Me.txt_prod_hasta = New System.Windows.Forms.TextBox()
        Me.txt_prod_desde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_all_tpr = New System.Windows.Forms.CheckBox()
        Me.chk_all_cat = New System.Windows.Forms.CheckBox()
        Me.chk_all_mar = New System.Windows.Forms.CheckBox()
        Me.cmb_tpr = New System.Windows.Forms.ComboBox()
        Me.cmb_cat = New System.Windows.Forms.ComboBox()
        Me.cmb_mar = New System.Windows.Forms.ComboBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rv_reporte_stock_productos = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DSReporteStockProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ReporteStockProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_product_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSReporteStockProductosBindingSource
        '
        Me.DSReporteStockProductosBindingSource.DataSource = Me.DS_ReporteStockProductos
        Me.DSReporteStockProductosBindingSource.Position = 0
        '
        'DS_ReporteStockProductos
        '
        Me.DS_ReporteStockProductos.DataSetName = "DS_ReporteStockProductos"
        Me.DS_ReporteStockProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grp_product_filter
        '
        Me.grp_product_filter.Controls.Add(Me.txt_prod_hasta)
        Me.grp_product_filter.Controls.Add(Me.txt_prod_desde)
        Me.grp_product_filter.Controls.Add(Me.Label2)
        Me.grp_product_filter.Controls.Add(Me.Label1)
        Me.grp_product_filter.Location = New System.Drawing.Point(12, 9)
        Me.grp_product_filter.Name = "grp_product_filter"
        Me.grp_product_filter.Size = New System.Drawing.Size(164, 76)
        Me.grp_product_filter.TabIndex = 0
        Me.grp_product_filter.TabStop = False
        Me.grp_product_filter.Text = "Productos"
        '
        'txt_prod_hasta
        '
        Me.txt_prod_hasta.Location = New System.Drawing.Point(65, 45)
        Me.txt_prod_hasta.Name = "txt_prod_hasta"
        Me.txt_prod_hasta.Size = New System.Drawing.Size(90, 20)
        Me.txt_prod_hasta.TabIndex = 3
        '
        'txt_prod_desde
        '
        Me.txt_prod_desde.Location = New System.Drawing.Point(65, 18)
        Me.txt_prod_desde.Name = "txt_prod_desde"
        Me.txt_prod_desde.Size = New System.Drawing.Size(90, 20)
        Me.txt_prod_desde.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde: "
        '
        'chk_all_tpr
        '
        Me.chk_all_tpr.AutoSize = True
        Me.chk_all_tpr.Location = New System.Drawing.Point(196, 25)
        Me.chk_all_tpr.Name = "chk_all_tpr"
        Me.chk_all_tpr.Size = New System.Drawing.Size(162, 17)
        Me.chk_all_tpr.TabIndex = 1
        Me.chk_all_tpr.Text = "Todos los Tipos de Producto"
        Me.chk_all_tpr.UseVisualStyleBackColor = True
        '
        'chk_all_cat
        '
        Me.chk_all_cat.AutoSize = True
        Me.chk_all_cat.Location = New System.Drawing.Point(405, 25)
        Me.chk_all_cat.Name = "chk_all_cat"
        Me.chk_all_cat.Size = New System.Drawing.Size(125, 17)
        Me.chk_all_cat.TabIndex = 2
        Me.chk_all_cat.Text = "Todas las Categorias"
        Me.chk_all_cat.UseVisualStyleBackColor = True
        '
        'chk_all_mar
        '
        Me.chk_all_mar.AutoSize = True
        Me.chk_all_mar.Location = New System.Drawing.Point(603, 25)
        Me.chk_all_mar.Name = "chk_all_mar"
        Me.chk_all_mar.Size = New System.Drawing.Size(110, 17)
        Me.chk_all_mar.TabIndex = 3
        Me.chk_all_mar.Text = "Todas las Marcas"
        Me.chk_all_mar.UseVisualStyleBackColor = True
        '
        'cmb_tpr
        '
        Me.cmb_tpr.FormattingEnabled = True
        Me.cmb_tpr.Location = New System.Drawing.Point(196, 48)
        Me.cmb_tpr.Name = "cmb_tpr"
        Me.cmb_tpr.Size = New System.Drawing.Size(161, 21)
        Me.cmb_tpr.TabIndex = 4
        '
        'cmb_cat
        '
        Me.cmb_cat.FormattingEnabled = True
        Me.cmb_cat.Location = New System.Drawing.Point(386, 48)
        Me.cmb_cat.Name = "cmb_cat"
        Me.cmb_cat.Size = New System.Drawing.Size(161, 21)
        Me.cmb_cat.TabIndex = 5
        '
        'cmb_mar
        '
        Me.cmb_mar.FormattingEnabled = True
        Me.cmb_mar.Location = New System.Drawing.Point(573, 48)
        Me.cmb_mar.Name = "cmb_mar"
        Me.cmb_mar.Size = New System.Drawing.Size(161, 21)
        Me.cmb_mar.TabIndex = 6
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(766, 35)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 7
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'rv_reporte_stock_productos
        '
        ReportDataSource1.Name = "DS_ReporteStockProductos"
        ReportDataSource1.Value = Me.DSReporteStockProductosBindingSource
        Me.rv_reporte_stock_productos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_reporte_stock_productos.LocalReport.ReportEmbeddedResource = "CompuMaxApp.rv_reporte_stock_productos.rdlc"
        Me.rv_reporte_stock_productos.Location = New System.Drawing.Point(1, 94)
        Me.rv_reporte_stock_productos.Name = "rv_reporte_stock_productos"
        Me.rv_reporte_stock_productos.Size = New System.Drawing.Size(904, 387)
        Me.rv_reporte_stock_productos.TabIndex = 8
        '
        'Frm_Reporte_Stock_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(905, 483)
        Me.Controls.Add(Me.rv_reporte_stock_productos)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.cmb_mar)
        Me.Controls.Add(Me.cmb_cat)
        Me.Controls.Add(Me.cmb_tpr)
        Me.Controls.Add(Me.chk_all_mar)
        Me.Controls.Add(Me.chk_all_cat)
        Me.Controls.Add(Me.chk_all_tpr)
        Me.Controls.Add(Me.grp_product_filter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Stock_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Stock de Productos"
        CType(Me.DSReporteStockProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ReporteStockProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_product_filter.ResumeLayout(False)
        Me.grp_product_filter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_product_filter As System.Windows.Forms.GroupBox
    Friend WithEvents txt_prod_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txt_prod_desde As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_all_tpr As System.Windows.Forms.CheckBox
    Friend WithEvents chk_all_cat As System.Windows.Forms.CheckBox
    Friend WithEvents chk_all_mar As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_tpr As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cat As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_mar As System.Windows.Forms.ComboBox
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents rv_reporte_stock_productos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DSReporteStockProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_ReporteStockProductos As CompuMaxApp.DS_ReporteStockProductos
End Class
