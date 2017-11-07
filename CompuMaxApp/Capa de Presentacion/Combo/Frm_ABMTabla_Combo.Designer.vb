<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABMTabla_Combo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABMTabla_Combo))
        Me.dgv_combos = New System.Windows.Forms.DataGridView()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.com_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_combos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_combos
        '
        Me.dgv_combos.AllowUserToAddRows = False
        Me.dgv_combos.AllowUserToDeleteRows = False
        Me.dgv_combos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_combos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.com_codigo, Me.com_denom, Me.cat_denom, Me.est_denom, Me.com_precio})
        Me.dgv_combos.Location = New System.Drawing.Point(7, 8)
        Me.dgv_combos.Name = "dgv_combos"
        Me.dgv_combos.ReadOnly = True
        Me.dgv_combos.Size = New System.Drawing.Size(369, 379)
        Me.dgv_combos.TabIndex = 0
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_borrar.Location = New System.Drawing.Point(119, 393)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(50, 50)
        Me.btn_borrar.TabIndex = 8
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(63, 393)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 7
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(326, 393)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._agregar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.Location = New System.Drawing.Point(7, 393)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'com_codigo
        '
        Me.com_codigo.HeaderText = "Codigo Combo"
        Me.com_codigo.Name = "com_codigo"
        Me.com_codigo.ReadOnly = True
        Me.com_codigo.Width = 75
        '
        'com_denom
        '
        Me.com_denom.HeaderText = "Denominacion"
        Me.com_denom.Name = "com_denom"
        Me.com_denom.ReadOnly = True
        Me.com_denom.Width = 150
        '
        'cat_denom
        '
        Me.cat_denom.HeaderText = "Denominacion"
        Me.cat_denom.Name = "cat_denom"
        Me.cat_denom.ReadOnly = True
        '
        'est_denom
        '
        Me.est_denom.HeaderText = "Estado"
        Me.est_denom.Name = "est_denom"
        Me.est_denom.ReadOnly = True
        '
        'com_precio
        '
        Me.com_precio.HeaderText = "Precio"
        Me.com_precio.Name = "com_precio"
        Me.com_precio.ReadOnly = True
        '
        'Frm_ABMTabla_Combo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(383, 451)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_combos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABMTabla_Combo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combos"
        CType(Me.dgv_combos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_combos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents com_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
