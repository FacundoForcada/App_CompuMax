<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Clientes))
        Me.ReporteClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ReporteClientes = New CompuMaxApp.DS_ReporteClientes()
        Me.rv_reporte_clientes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_cod_desde = New System.Windows.Forms.TextBox()
        Me.txt_cod_hasta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.ReporteClientesTableAdapter = New CompuMaxApp.DS_ReporteClientesTableAdapters.ReporteClientesTableAdapter()
        Me.chk_no_activos = New System.Windows.Forms.CheckBox()
        CType(Me.ReporteClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ReporteClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteClientesBindingSource
        '
        Me.ReporteClientesBindingSource.DataMember = "ReporteClientes"
        Me.ReporteClientesBindingSource.DataSource = Me.DS_ReporteClientes
        '
        'DS_ReporteClientes
        '
        Me.DS_ReporteClientes.DataSetName = "DS_ReporteClientes"
        Me.DS_ReporteClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv_reporte_clientes
        '
        ReportDataSource1.Name = "DS1"
        ReportDataSource1.Value = Me.ReporteClientesBindingSource
        Me.rv_reporte_clientes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_reporte_clientes.LocalReport.ReportEmbeddedResource = "CompuMaxApp.rv_reporte_clientes.rdlc"
        Me.rv_reporte_clientes.Location = New System.Drawing.Point(2, 38)
        Me.rv_reporte_clientes.Name = "rv_reporte_clientes"
        Me.rv_reporte_clientes.Size = New System.Drawing.Size(1031, 530)
        Me.rv_reporte_clientes.TabIndex = 0
        '
        'txt_cod_desde
        '
        Me.txt_cod_desde.Location = New System.Drawing.Point(91, 12)
        Me.txt_cod_desde.Name = "txt_cod_desde"
        Me.txt_cod_desde.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_desde.TabIndex = 1
        '
        'txt_cod_hasta
        '
        Me.txt_cod_hasta.Location = New System.Drawing.Point(288, 12)
        Me.txt_cod_hasta.Name = "txt_cod_hasta"
        Me.txt_cod_hasta.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_hasta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo Hasta:"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(609, 10)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 5
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'ReporteClientesTableAdapter
        '
        Me.ReporteClientesTableAdapter.ClearBeforeFill = True
        '
        'chk_no_activos
        '
        Me.chk_no_activos.AutoSize = True
        Me.chk_no_activos.Location = New System.Drawing.Point(447, 14)
        Me.chk_no_activos.Name = "chk_no_activos"
        Me.chk_no_activos.Size = New System.Drawing.Size(106, 17)
        Me.chk_no_activos.TabIndex = 6
        Me.chk_no_activos.Text = "Incluir no activos"
        Me.chk_no_activos.UseVisualStyleBackColor = True
        '
        'Frm_Reporte_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1035, 569)
        Me.Controls.Add(Me.chk_no_activos)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cod_hasta)
        Me.Controls.Add(Me.txt_cod_desde)
        Me.Controls.Add(Me.rv_reporte_clientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Reporte_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Clientes"
        CType(Me.ReporteClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ReporteClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rv_reporte_clientes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt_cod_desde As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_hasta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents ReporteClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_ReporteClientes As CompuMaxApp.DS_ReporteClientes
    Friend WithEvents ReporteClientesTableAdapter As CompuMaxApp.DS_ReporteClientesTableAdapters.ReporteClientesTableAdapter
    Friend WithEvents chk_no_activos As System.Windows.Forms.CheckBox
End Class
