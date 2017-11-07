<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABMTabla_Promocion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABMTabla_Promocion))
        Me.dgv_promociones = New System.Windows.Forms.DataGridView()
        Me.prom_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prom_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prom_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.dgv_promociones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_promociones
        '
        Me.dgv_promociones.AllowUserToAddRows = False
        Me.dgv_promociones.AllowUserToDeleteRows = False
        Me.dgv_promociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_promociones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prom_codigo, Me.prom_denom, Me.prom_desc, Me.est_denom})
        Me.dgv_promociones.Location = New System.Drawing.Point(7, 12)
        Me.dgv_promociones.Name = "dgv_promociones"
        Me.dgv_promociones.ReadOnly = True
        Me.dgv_promociones.Size = New System.Drawing.Size(343, 371)
        Me.dgv_promociones.TabIndex = 0
        '
        'prom_codigo
        '
        Me.prom_codigo.HeaderText = "prom_codigo"
        Me.prom_codigo.Name = "prom_codigo"
        Me.prom_codigo.ReadOnly = True
        Me.prom_codigo.Visible = False
        '
        'prom_denom
        '
        Me.prom_denom.HeaderText = "Promocion"
        Me.prom_denom.Name = "prom_denom"
        Me.prom_denom.ReadOnly = True
        '
        'prom_desc
        '
        Me.prom_desc.HeaderText = "Descuento"
        Me.prom_desc.Name = "prom_desc"
        Me.prom_desc.ReadOnly = True
        '
        'est_denom
        '
        Me.est_denom.HeaderText = "Estado"
        Me.est_denom.Name = "est_denom"
        Me.est_denom.ReadOnly = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._agregar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.Location = New System.Drawing.Point(7, 389)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(63, 389)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 2
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_borrar.Location = New System.Drawing.Point(119, 389)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(50, 50)
        Me.btn_borrar.TabIndex = 3
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(300, 389)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Frm_ABMTabla_Promocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 444)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_promociones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABMTabla_Promocion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promociones"
        CType(Me.dgv_promociones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_promociones As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents prom_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prom_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prom_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est_denom As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
