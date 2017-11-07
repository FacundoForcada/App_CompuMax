<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Proveedores
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Proveedores))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_hasta = New System.Windows.Forms.TextBox()
        Me.txt_cod_desde = New System.Windows.Forms.TextBox()
        Me.chk_no_activos = New System.Windows.Forms.CheckBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rv_reporte_proveedores = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_ReporteProveedores = New CompuMaxApp.DS_ReporteProveedores()
        Me.ReporteProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteProveedoresTableAdapter = New CompuMaxApp.DS_ReporteProveedoresTableAdapters.ReporteProveedoresTableAdapter()
        CType(Me.DS_ReporteProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Codigo Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Codigo Desde:"
        '
        'txt_cod_hasta
        '
        Me.txt_cod_hasta.Location = New System.Drawing.Point(292, 12)
        Me.txt_cod_hasta.Name = "txt_cod_hasta"
        Me.txt_cod_hasta.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_hasta.TabIndex = 6
        '
        'txt_cod_desde
        '
        Me.txt_cod_desde.Location = New System.Drawing.Point(95, 12)
        Me.txt_cod_desde.Name = "txt_cod_desde"
        Me.txt_cod_desde.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_desde.TabIndex = 5
        '
        'chk_no_activos
        '
        Me.chk_no_activos.AutoSize = True
        Me.chk_no_activos.Location = New System.Drawing.Point(412, 14)
        Me.chk_no_activos.Name = "chk_no_activos"
        Me.chk_no_activos.Size = New System.Drawing.Size(106, 17)
        Me.chk_no_activos.TabIndex = 10
        Me.chk_no_activos.Text = "Incluir no activos"
        Me.chk_no_activos.UseVisualStyleBackColor = True
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(574, 10)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 9
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'rv_reporte_proveedores
        '
        ReportDataSource1.Name = "DS"
        ReportDataSource1.Value = Me.ReporteProveedoresBindingSource
        Me.rv_reporte_proveedores.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_reporte_proveedores.LocalReport.ReportEmbeddedResource = "CompuMaxApp.rv_reporte_proveedores.rdlc"
        Me.rv_reporte_proveedores.Location = New System.Drawing.Point(-1, 45)
        Me.rv_reporte_proveedores.Name = "rv_reporte_proveedores"
        Me.rv_reporte_proveedores.Size = New System.Drawing.Size(708, 486)
        Me.rv_reporte_proveedores.TabIndex = 11
        '
        'DS_ReporteProveedores
        '
        Me.DS_ReporteProveedores.DataSetName = "DS_ReporteProveedores"
        Me.DS_ReporteProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteProveedoresBindingSource
        '
        Me.ReporteProveedoresBindingSource.DataMember = "ReporteProveedores"
        Me.ReporteProveedoresBindingSource.DataSource = Me.DS_ReporteProveedores
        '
        'ReporteProveedoresTableAdapter
        '
        Me.ReporteProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Frm_Reporte_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(709, 533)
        Me.Controls.Add(Me.rv_reporte_proveedores)
        Me.Controls.Add(Me.chk_no_activos)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cod_hasta)
        Me.Controls.Add(Me.txt_cod_desde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Proveedores"
        CType(Me.DS_ReporteProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_desde As System.Windows.Forms.TextBox
    Friend WithEvents chk_no_activos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents rv_reporte_proveedores As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_ReporteProveedores As CompuMaxApp.DS_ReporteProveedores
    Friend WithEvents ReporteProveedoresTableAdapter As CompuMaxApp.DS_ReporteProveedoresTableAdapters.ReporteProveedoresTableAdapter
End Class
