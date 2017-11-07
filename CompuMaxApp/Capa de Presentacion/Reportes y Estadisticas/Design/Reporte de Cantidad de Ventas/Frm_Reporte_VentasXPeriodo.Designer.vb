<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_VentasXPeriodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_VentasXPeriodo))
        Me.ReporteVentasXPeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ReporteVentasXPeriodo = New CompuMaxApp.DS_ReporteVentasXPeriodo()
        Me.rv_reporte_ventasXPeriodo = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mTxt_desde = New System.Windows.Forms.MaskedTextBox()
        Me.mTxt_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.chk_grafico = New System.Windows.Forms.CheckBox()
        Me.chk_histograma = New System.Windows.Forms.CheckBox()
        CType(Me.ReporteVentasXPeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ReporteVentasXPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteVentasXPeriodoBindingSource
        '
        Me.ReporteVentasXPeriodoBindingSource.DataMember = "ReporteVentasXPeriodo"
        Me.ReporteVentasXPeriodoBindingSource.DataSource = Me.DS_ReporteVentasXPeriodo
        '
        'DS_ReporteVentasXPeriodo
        '
        Me.DS_ReporteVentasXPeriodo.DataSetName = "DS_ReporteVentasXPeriodo"
        Me.DS_ReporteVentasXPeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv_reporte_ventasXPeriodo
        '
        ReportDataSource1.Name = "DS_REPORTEVENTASXPERIODO"
        ReportDataSource1.Value = Me.ReporteVentasXPeriodoBindingSource
        Me.rv_reporte_ventasXPeriodo.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_reporte_ventasXPeriodo.LocalReport.ReportEmbeddedResource = "CompuMaxApp.rv_reporte_ventasXPeriodo.rdlc"
        Me.rv_reporte_ventasXPeriodo.Location = New System.Drawing.Point(0, 40)
        Me.rv_reporte_ventasXPeriodo.Name = "rv_reporte_ventasXPeriodo"
        Me.rv_reporte_ventasXPeriodo.Size = New System.Drawing.Size(925, 544)
        Me.rv_reporte_ventasXPeriodo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'mTxt_desde
        '
        Me.mTxt_desde.Location = New System.Drawing.Point(63, 12)
        Me.mTxt_desde.Mask = "00/00/0000"
        Me.mTxt_desde.Name = "mTxt_desde"
        Me.mTxt_desde.Size = New System.Drawing.Size(100, 20)
        Me.mTxt_desde.TabIndex = 3
        Me.mTxt_desde.ValidatingType = GetType(Date)
        '
        'mTxt_hasta
        '
        Me.mTxt_hasta.Location = New System.Drawing.Point(221, 13)
        Me.mTxt_hasta.Mask = "00/00/0000"
        Me.mTxt_hasta.Name = "mTxt_hasta"
        Me.mTxt_hasta.Size = New System.Drawing.Size(100, 20)
        Me.mTxt_hasta.TabIndex = 4
        Me.mTxt_hasta.ValidatingType = GetType(Date)
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(639, 10)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(117, 23)
        Me.btn_generar.TabIndex = 6
        Me.btn_generar.Text = "Generar Reporte"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'chk_grafico
        '
        Me.chk_grafico.AutoSize = True
        Me.chk_grafico.Location = New System.Drawing.Point(345, 14)
        Me.chk_grafico.Name = "chk_grafico"
        Me.chk_grafico.Size = New System.Drawing.Size(141, 17)
        Me.chk_grafico.TabIndex = 19
        Me.chk_grafico.Text = "Grafico Ventas X Cliente"
        Me.chk_grafico.UseVisualStyleBackColor = True
        '
        'chk_histograma
        '
        Me.chk_histograma.AutoSize = True
        Me.chk_histograma.Location = New System.Drawing.Point(492, 15)
        Me.chk_histograma.Name = "chk_histograma"
        Me.chk_histograma.Size = New System.Drawing.Size(130, 17)
        Me.chk_histograma.TabIndex = 20
        Me.chk_histograma.Text = "Histograma de Ventas"
        Me.chk_histograma.UseVisualStyleBackColor = True
        '
        'Frm_Reporte_VentasXPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(927, 586)
        Me.Controls.Add(Me.chk_histograma)
        Me.Controls.Add(Me.chk_grafico)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.mTxt_hasta)
        Me.Controls.Add(Me.mTxt_desde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rv_reporte_ventasXPeriodo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_VentasXPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Ventas Por Periodo"
        CType(Me.ReporteVentasXPeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ReporteVentasXPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rv_reporte_ventasXPeriodo As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteVentasXPeriodoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_ReporteVentasXPeriodo As CompuMaxApp.DS_ReporteVentasXPeriodo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mTxt_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mTxt_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents chk_grafico As System.Windows.Forms.CheckBox
    Friend WithEvents chk_histograma As System.Windows.Forms.CheckBox
End Class
