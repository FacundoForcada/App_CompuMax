<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GrupoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GrupoUsuario))
        Me.dgv_grupo_usuario = New System.Windows.Forms.DataGridView()
        Me.grp_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_nmbcompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.usu_codigo_U = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_usuario_U = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_nmbcompleto_U = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_grp = New System.Windows.Forms.Label()
        Me.lbl_tittle_grp = New System.Windows.Forms.Label()
        Me.btn_agregar_usu = New System.Windows.Forms.Button()
        Me.btn_consultar_usu = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar_grp = New System.Windows.Forms.Button()
        Me.btn_quitar_usu = New System.Windows.Forms.Button()
        Me.cmb_grupo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_grupo_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_grupo_usuario
        '
        Me.dgv_grupo_usuario.AllowUserToAddRows = False
        Me.dgv_grupo_usuario.AllowUserToDeleteRows = False
        Me.dgv_grupo_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_grupo_usuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grp_codigo, Me.usu_codigo, Me.est_codigo, Me.usu_usuario, Me.usu_nmbcompleto})
        Me.dgv_grupo_usuario.Location = New System.Drawing.Point(18, 58)
        Me.dgv_grupo_usuario.Name = "dgv_grupo_usuario"
        Me.dgv_grupo_usuario.ReadOnly = True
        Me.dgv_grupo_usuario.Size = New System.Drawing.Size(329, 141)
        Me.dgv_grupo_usuario.TabIndex = 0
        '
        'grp_codigo
        '
        Me.grp_codigo.HeaderText = "grp_codigo"
        Me.grp_codigo.Name = "grp_codigo"
        Me.grp_codigo.ReadOnly = True
        Me.grp_codigo.Visible = False
        '
        'usu_codigo
        '
        Me.usu_codigo.HeaderText = "usu_codigo"
        Me.usu_codigo.Name = "usu_codigo"
        Me.usu_codigo.ReadOnly = True
        Me.usu_codigo.Visible = False
        '
        'est_codigo
        '
        Me.est_codigo.HeaderText = "est_codigo"
        Me.est_codigo.Name = "est_codigo"
        Me.est_codigo.ReadOnly = True
        Me.est_codigo.Visible = False
        '
        'usu_usuario
        '
        Me.usu_usuario.HeaderText = "Usuario"
        Me.usu_usuario.Name = "usu_usuario"
        Me.usu_usuario.ReadOnly = True
        Me.usu_usuario.Width = 130
        '
        'usu_nmbcompleto
        '
        Me.usu_nmbcompleto.HeaderText = "Nombre "
        Me.usu_nmbcompleto.Name = "usu_nmbcompleto"
        Me.usu_nmbcompleto.ReadOnly = True
        Me.usu_nmbcompleto.Width = 155
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToDeleteRows = False
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usu_codigo_U, Me.usu_usuario_U, Me.usu_nmbcompleto_U})
        Me.dgv_usuarios.Location = New System.Drawing.Point(18, 60)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.ReadOnly = True
        Me.dgv_usuarios.Size = New System.Drawing.Size(289, 148)
        Me.dgv_usuarios.TabIndex = 1
        '
        'usu_codigo_U
        '
        Me.usu_codigo_U.HeaderText = "usu_codigo"
        Me.usu_codigo_U.Name = "usu_codigo_U"
        Me.usu_codigo_U.ReadOnly = True
        Me.usu_codigo_U.Visible = False
        '
        'usu_usuario_U
        '
        Me.usu_usuario_U.HeaderText = "Usuario"
        Me.usu_usuario_U.Name = "usu_usuario_U"
        Me.usu_usuario_U.ReadOnly = True
        Me.usu_usuario_U.Width = 110
        '
        'usu_nmbcompleto_U
        '
        Me.usu_nmbcompleto_U.HeaderText = "Nombre "
        Me.usu_nmbcompleto_U.Name = "usu_nmbcompleto_U"
        Me.usu_nmbcompleto_U.ReadOnly = True
        Me.usu_nmbcompleto_U.Width = 135
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_grp)
        Me.GroupBox1.Controls.Add(Me.lbl_tittle_grp)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_usu)
        Me.GroupBox1.Controls.Add(Me.btn_consultar_usu)
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.chk_todos)
        Me.GroupBox1.Controls.Add(Me.lbl_usuario)
        Me.GroupBox1.Controls.Add(Me.dgv_usuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 223)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'lbl_grp
        '
        Me.lbl_grp.AutoSize = True
        Me.lbl_grp.Location = New System.Drawing.Point(316, 176)
        Me.lbl_grp.Name = "lbl_grp"
        Me.lbl_grp.Size = New System.Drawing.Size(16, 13)
        Me.lbl_grp.TabIndex = 12
        Me.lbl_grp.Text = "- -"
        '
        'lbl_tittle_grp
        '
        Me.lbl_tittle_grp.AutoSize = True
        Me.lbl_tittle_grp.Location = New System.Drawing.Point(316, 163)
        Me.lbl_tittle_grp.Name = "lbl_tittle_grp"
        Me.lbl_tittle_grp.Size = New System.Drawing.Size(119, 13)
        Me.lbl_tittle_grp.TabIndex = 11
        Me.lbl_tittle_grp.Text = " - Grupo Seleccionado -"
        '
        'btn_agregar_usu
        '
        Me.btn_agregar_usu.Location = New System.Drawing.Point(319, 93)
        Me.btn_agregar_usu.Name = "btn_agregar_usu"
        Me.btn_agregar_usu.Size = New System.Drawing.Size(75, 39)
        Me.btn_agregar_usu.TabIndex = 10
        Me.btn_agregar_usu.Text = "Agregar a Grupo"
        Me.btn_agregar_usu.UseVisualStyleBackColor = True
        '
        'btn_consultar_usu
        '
        Me.btn_consultar_usu.Location = New System.Drawing.Point(311, 23)
        Me.btn_consultar_usu.Name = "btn_consultar_usu"
        Me.btn_consultar_usu.Size = New System.Drawing.Size(124, 23)
        Me.btn_consultar_usu.TabIndex = 9
        Me.btn_consultar_usu.Text = "Buscar"
        Me.btn_consultar_usu.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(70, 25)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(173, 20)
        Me.txt_usuario.TabIndex = 8
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(251, 27)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 7
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(15, 28)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(49, 13)
        Me.lbl_usuario.TabIndex = 6
        Me.lbl_usuario.Text = "Usuario: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_consultar_grp)
        Me.GroupBox2.Controls.Add(Me.btn_quitar_usu)
        Me.GroupBox2.Controls.Add(Me.cmb_grupo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgv_grupo_usuario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 214)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grupos de usuarios"
        '
        'btn_consultar_grp
        '
        Me.btn_consultar_grp.Location = New System.Drawing.Point(311, 20)
        Me.btn_consultar_grp.Name = "btn_consultar_grp"
        Me.btn_consultar_grp.Size = New System.Drawing.Size(124, 23)
        Me.btn_consultar_grp.TabIndex = 11
        Me.btn_consultar_grp.Text = "Buscar"
        Me.btn_consultar_grp.UseVisualStyleBackColor = True
        '
        'btn_quitar_usu
        '
        Me.btn_quitar_usu.Location = New System.Drawing.Point(360, 98)
        Me.btn_quitar_usu.Name = "btn_quitar_usu"
        Me.btn_quitar_usu.Size = New System.Drawing.Size(75, 39)
        Me.btn_quitar_usu.TabIndex = 11
        Me.btn_quitar_usu.Text = "Quitar Usuario"
        Me.btn_quitar_usu.UseVisualStyleBackColor = True
        '
        'cmb_grupo
        '
        Me.cmb_grupo.FormattingEnabled = True
        Me.cmb_grupo.Location = New System.Drawing.Point(60, 22)
        Me.cmb_grupo.Name = "cmb_grupo"
        Me.cmb_grupo.Size = New System.Drawing.Size(206, 21)
        Me.cmb_grupo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Grupo:"
        '
        'Frm_GrupoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 462)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_GrupoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de Usuarios a Grupos"
        CType(Me.dgv_grupo_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_grupo_usuario As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregar_usu As System.Windows.Forms.Button
    Friend WithEvents btn_consultar_usu As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents cmb_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_quitar_usu As System.Windows.Forms.Button
    Friend WithEvents btn_consultar_grp As System.Windows.Forms.Button
    Friend WithEvents lbl_grp As System.Windows.Forms.Label
    Friend WithEvents lbl_tittle_grp As System.Windows.Forms.Label
    Friend WithEvents grp_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_nmbcompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_codigo_U As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_usuario_U As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_nmbcompleto_U As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
