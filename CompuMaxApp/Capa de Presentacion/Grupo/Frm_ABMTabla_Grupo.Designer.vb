<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABMTabla_Grupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABMTabla_Grupo))
        Me.dgv_grupos = New System.Windows.Forms.DataGridView()
        Me.grp_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        CType(Me.dgv_grupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_grupos
        '
        Me.dgv_grupos.AllowUserToAddRows = False
        Me.dgv_grupos.AllowUserToDeleteRows = False
        Me.dgv_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_grupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grp_codigo, Me.grp_denom, Me.est_denom})
        Me.dgv_grupos.Location = New System.Drawing.Point(7, 8)
        Me.dgv_grupos.Name = "dgv_grupos"
        Me.dgv_grupos.ReadOnly = True
        Me.dgv_grupos.Size = New System.Drawing.Size(369, 379)
        Me.dgv_grupos.TabIndex = 0
        '
        'grp_codigo
        '
        Me.grp_codigo.HeaderText = "Codigo Grupo"
        Me.grp_codigo.Name = "grp_codigo"
        Me.grp_codigo.ReadOnly = True
        Me.grp_codigo.Width = 75
        '
        'grp_denom
        '
        Me.grp_denom.HeaderText = "Denominacion"
        Me.grp_denom.Name = "grp_denom"
        Me.grp_denom.ReadOnly = True
        Me.grp_denom.Width = 150
        '
        'est_denom
        '
        Me.est_denom.HeaderText = "Estado"
        Me.est_denom.Name = "est_denom"
        Me.est_denom.ReadOnly = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_borrar.Location = New System.Drawing.Point(119, 393)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(50, 50)
        Me.btn_borrar.TabIndex = 12
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(63, 393)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 11
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(326, 393)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 10
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._agregar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.Location = New System.Drawing.Point(7, 393)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Frm_ABMTabla_Grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(383, 451)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_grupos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABMTabla_Grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos"
        CType(Me.dgv_grupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_grupos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents grp_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grp_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est_denom As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
