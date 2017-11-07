<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Productos_Vendidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Productos_Vendidos))
        Me.DSReporteProductosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ReporteProductosVendidos = New CompuMaxApp.DS_ReporteProductosVendidos()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.cmb_mar = New System.Windows.Forms.ComboBox()
        Me.cmb_cat = New System.Windows.Forms.ComboBox()
        Me.cmb_tpr = New System.Windows.Forms.ComboBox()
        Me.chk_all_mar = New System.Windows.Forms.CheckBox()
        Me.chk_all_cat = New System.Windows.Forms.CheckBox()
        Me.chk_all_tpr = New System.Windows.Forms.CheckBox()
        Me.grp_product_filter = New System.Windows.Forms.GroupBox()
        Me.txt_prod_hasta = New System.Windows.Forms.TextBox()
        Me.txt_prod_desde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rv_reporte_productos_vendidos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.chk_totalizado = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.mtxt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.chk_grafico = New System.Windows.Forms.CheckBox()
        CType(Me.DSReporteProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ReporteProductosVendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_product_filter.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSReporteProductosVendidosBindingSource
        '
        Me.DSReporteProductosVendidosBindingSource.DataSource = Me.DS_ReporteProductosVendidos
        Me.DSReporteProductosVendidosBindingSource.Position = 0
        '
        'DS_ReporteProductosVendidos
        '
        Me.DS_ReporteProductosVendidos.DataSetName = "DS_ReporteProductosVendidos"
        Me.DS_ReporteProductosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(853, 54)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 15
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'cmb_mar
        '
        Me.cmb_mar.FormattingEnabled = True
        Me.cmb_mar.Location = New System.Drawing.Point(679, 56)
        Me.cmb_mar.Name = "cmb_mar"
        Me.cmb_mar.Size = New System.Drawing.Size(161, 21)
        Me.cmb_mar.TabIndex = 14
        '
        'cmb_cat
        '
        Me.cmb_cat.FormattingEnabled = True
        Me.cmb_cat.Location = New System.Drawing.Point(507, 56)
        Me.cmb_cat.Name = "cmb_cat"
        Me.cmb_cat.Size = New System.Drawing.Size(161, 21)
        Me.cmb_cat.TabIndex = 13
        '
        'cmb_tpr
        '
        Me.cmb_tpr.FormattingEnabled = True
        Me.cmb_tpr.Location = New System.Drawing.Point(335, 56)
        Me.cmb_tpr.Name = "cmb_tpr"
        Me.cmb_tpr.Size = New System.Drawing.Size(161, 21)
        Me.cmb_tpr.TabIndex = 12
        '
        'chk_all_mar
        '
        Me.chk_all_mar.AutoSize = True
        Me.chk_all_mar.Location = New System.Drawing.Point(709, 33)
        Me.chk_all_mar.Name = "chk_all_mar"
        Me.chk_all_mar.Size = New System.Drawing.Size(110, 17)
        Me.chk_all_mar.TabIndex = 11
        Me.chk_all_mar.Text = "Todas las Marcas"
        Me.chk_all_mar.UseVisualStyleBackColor = True
        '
        'chk_all_cat
        '
        Me.chk_all_cat.AutoSize = True
        Me.chk_all_cat.Location = New System.Drawing.Point(526, 33)
        Me.chk_all_cat.Name = "chk_all_cat"
        Me.chk_all_cat.Size = New System.Drawing.Size(125, 17)
        Me.chk_all_cat.TabIndex = 10
        Me.chk_all_cat.Text = "Todas las Categorias"
        Me.chk_all_cat.UseVisualStyleBackColor = True
        '
        'chk_all_tpr
        '
        Me.chk_all_tpr.AutoSize = True
        Me.chk_all_tpr.Location = New System.Drawing.Point(335, 33)
        Me.chk_all_tpr.Name = "chk_all_tpr"
        Me.chk_all_tpr.Size = New System.Drawing.Size(162, 17)
        Me.chk_all_tpr.TabIndex = 9
        Me.chk_all_tpr.Text = "Todos los Tipos de Producto"
        Me.chk_all_tpr.UseVisualStyleBackColor = True
        '
        'grp_product_filter
        '
        Me.grp_product_filter.Controls.Add(Me.txt_prod_hasta)
        Me.grp_product_filter.Controls.Add(Me.txt_prod_desde)
        Me.grp_product_filter.Controls.Add(Me.Label2)
        Me.grp_product_filter.Controls.Add(Me.Label1)
        Me.grp_product_filter.Location = New System.Drawing.Point(12, 12)
        Me.grp_product_filter.Name = "grp_product_filter"
        Me.grp_product_filter.Size = New System.Drawing.Size(164, 76)
        Me.grp_product_filter.TabIndex = 8
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
        'rv_reporte_productos_vendidos
        '
        ReportDataSource1.Name = "DS_ReporteProductosVendidos"
        ReportDataSource1.Value = Me.DSReporteProductosVendidosBindingSource
        Me.rv_reporte_productos_vendidos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_reporte_productos_vendidos.LocalReport.ReportEmbeddedResource = "CompuMaxApp.rv_reporte_productos_vendidos.rdlc"
        Me.rv_reporte_productos_vendidos.Location = New System.Drawing.Point(-1, 94)
        Me.rv_reporte_productos_vendidos.Name = "rv_reporte_productos_vendidos"
        Me.rv_reporte_productos_vendidos.Size = New System.Drawing.Size(948, 597)
        Me.rv_reporte_productos_vendidos.TabIndex = 16
        '
        'chk_totalizado
        '
        Me.chk_totalizado.AutoSize = True
        Me.chk_totalizado.Location = New System.Drawing.Point(853, 31)
        Me.chk_totalizado.Name = "chk_totalizado"
        Me.chk_totalizado.Size = New System.Drawing.Size(66, 17)
        Me.chk_totalizado.TabIndex = 17
        Me.chk_totalizado.Text = "Totalizar"
        Me.chk_totalizado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hasta: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Desde: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.mtxt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 76)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'mtxt_fecha_hasta
        '
        Me.mtxt_fecha_hasta.Location = New System.Drawing.Point(58, 45)
        Me.mtxt_fecha_hasta.Mask = "00/00/0000"
        Me.mtxt_fecha_hasta.Name = "mtxt_fecha_hasta"
        Me.mtxt_fecha_hasta.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_fecha_hasta.TabIndex = 3
        Me.mtxt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'mtxt_fecha_desde
        '
        Me.mtxt_fecha_desde.Location = New System.Drawing.Point(58, 18)
        Me.mtxt_fecha_desde.Mask = "00/00/0000"
        Me.mtxt_fecha_desde.Name = "mtxt_fecha_desde"
        Me.mtxt_fecha_desde.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_fecha_desde.TabIndex = 2
        Me.mtxt_fecha_desde.ValidatingType = GetType(Date)
        '
        'chk_grafico
        '
        Me.chk_grafico.AutoSize = True
        Me.chk_grafico.Location = New System.Drawing.Point(853, 12)
        Me.chk_grafico.Name = "chk_grafico"
        Me.chk_grafico.Size = New System.Drawing.Size(98, 17)
        Me.chk_grafico.TabIndex = 18
        Me.chk_grafico.Text = "Mostrar Grafico"
        Me.chk_grafico.UseVisualStyleBackColor = True
        '
        'Frm_Reporte_Productos_Vendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(947, 692)
        Me.Controls.Add(Me.chk_grafico)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_totalizado)
        Me.Controls.Add(Me.rv_reporte_productos_vendidos)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.cmb_mar)
        Me.Controls.Add(Me.cmb_cat)
        Me.Controls.Add(Me.cmb_tpr)
        Me.Controls.Add(Me.chk_all_mar)
        Me.Controls.Add(Me.chk_all_cat)
        Me.Controls.Add(Me.chk_all_tpr)
        Me.Controls.Add(Me.grp_product_filter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Productos_Vendidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Productos Vendidos"
        CType(Me.DSReporteProductosVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ReporteProductosVendidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_product_filter.ResumeLayout(False)
        Me.grp_product_filter.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents cmb_mar As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cat As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tpr As System.Windows.Forms.ComboBox
    Friend WithEvents chk_all_mar As System.Windows.Forms.CheckBox
    Friend WithEvents chk_all_cat As System.Windows.Forms.CheckBox
    Friend WithEvents chk_all_tpr As System.Windows.Forms.CheckBox
    Friend WithEvents grp_product_filter As System.Windows.Forms.GroupBox
    Friend WithEvents txt_prod_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txt_prod_desde As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rv_reporte_productos_vendidos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents chk_totalizado As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mtxt_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxt_fecha_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DSReporteProductosVendidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_ReporteProductosVendidos As CompuMaxApp.DS_ReporteProductosVendidos
    Friend WithEvents chk_grafico As System.Windows.Forms.CheckBox
End Class
