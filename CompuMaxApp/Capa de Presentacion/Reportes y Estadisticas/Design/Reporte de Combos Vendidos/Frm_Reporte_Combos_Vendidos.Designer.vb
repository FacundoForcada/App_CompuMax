<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Combos_Vendidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Combos_Vendidos))
        Me.ReporteCombosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ReporteCombosVendidos = New CompuMaxApp.DS_ReporteCombosVendidos()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.mTxt_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.mTxt_desde = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rv_reporte_Combos_Vendidos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_top = New System.Windows.Forms.TextBox()
        Me.chk_mostrar_grafico = New System.Windows.Forms.CheckBox()
        CType(Me.ReporteCombosVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ReporteCombosVendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteCombosVendidosBindingSource
        '
        Me.ReporteCombosVendidosBindingSource.DataMember = "ReporteCombosVendidos"
        Me.ReporteCombosVendidosBindingSource.DataSource = Me.DS_ReporteCombosVendidos
        '
        'DS_ReporteCombosVendidos
        '
        Me.DS_ReporteCombosVendidos.DataSetName = "DS_ReporteCombosVendidos"
        Me.DS_ReporteCombosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(601, 13)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(117, 23)
        Me.btn_generar.TabIndex = 12
        Me.btn_generar.Text = "Generar Reporte"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'mTxt_hasta
        '
        Me.mTxt_hasta.Location = New System.Drawing.Point(371, 14)
        Me.mTxt_hasta.Mask = "00/00/0000"
        Me.mTxt_hasta.Name = "mTxt_hasta"
        Me.mTxt_hasta.Size = New System.Drawing.Size(100, 20)
        Me.mTxt_hasta.TabIndex = 11
        Me.mTxt_hasta.ValidatingType = GetType(Date)
        '
        'mTxt_desde
        '
        Me.mTxt_desde.Location = New System.Drawing.Point(212, 14)
        Me.mTxt_desde.Mask = "00/00/0000"
        Me.mTxt_desde.Name = "mTxt_desde"
        Me.mTxt_desde.Size = New System.Drawing.Size(100, 20)
        Me.mTxt_desde.TabIndex = 10
        Me.mTxt_desde.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desde:"
        '
        'rv_reporte_Combos_Vendidos
        '
        ReportDataSource1.Name = "DS_CombosVendidos"
        ReportDataSource1.Value = Me.ReporteCombosVendidosBindingSource
        Me.rv_reporte_Combos_Vendidos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_reporte_Combos_Vendidos.LocalReport.ReportEmbeddedResource = "CompuMaxApp.rv_reporte_combos_vendidos.rdlc"
        Me.rv_reporte_Combos_Vendidos.Location = New System.Drawing.Point(1, 41)
        Me.rv_reporte_Combos_Vendidos.Name = "rv_reporte_Combos_Vendidos"
        Me.rv_reporte_Combos_Vendidos.Size = New System.Drawing.Size(972, 417)
        Me.rv_reporte_Combos_Vendidos.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Top:"
        '
        'txt_top
        '
        Me.txt_top.Location = New System.Drawing.Point(50, 14)
        Me.txt_top.Name = "txt_top"
        Me.txt_top.Size = New System.Drawing.Size(100, 20)
        Me.txt_top.TabIndex = 14
        '
        'chk_mostrar_grafico
        '
        Me.chk_mostrar_grafico.AutoSize = True
        Me.chk_mostrar_grafico.Location = New System.Drawing.Point(497, 18)
        Me.chk_mostrar_grafico.Name = "chk_mostrar_grafico"
        Me.chk_mostrar_grafico.Size = New System.Drawing.Size(98, 17)
        Me.chk_mostrar_grafico.TabIndex = 15
        Me.chk_mostrar_grafico.Text = "Mostrar Grafico"
        Me.chk_mostrar_grafico.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chk_mostrar_grafico.UseVisualStyleBackColor = True
        '
        'Frm_Reporte_Combos_Vendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(974, 458)
        Me.Controls.Add(Me.chk_mostrar_grafico)
        Me.Controls.Add(Me.txt_top)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.mTxt_hasta)
        Me.Controls.Add(Me.mTxt_desde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rv_reporte_Combos_Vendidos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Combos_Vendidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Combos Vendidos"
        CType(Me.ReporteCombosVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ReporteCombosVendidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents mTxt_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mTxt_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rv_reporte_Combos_Vendidos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_top As System.Windows.Forms.TextBox
    Friend WithEvents ReporteCombosVendidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_ReporteCombosVendidos As CompuMaxApp.DS_ReporteCombosVendidos
    Friend WithEvents chk_mostrar_grafico As System.Windows.Forms.CheckBox
End Class
