<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Usuario))
        Me.pnl_filtros = New System.Windows.Forms.Panel()
        Me.grb_filtros = New System.Windows.Forms.GroupBox()
        Me.btn_consultar_filtros = New System.Windows.Forms.Button()
        Me.cmb_grupo = New System.Windows.Forms.ComboBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.lbl_grupo = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.pnl_tabla = New System.Windows.Forms.Panel()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.usu_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_nmbCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usu_clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_filtros.SuspendLayout()
        Me.grb_filtros.SuspendLayout()
        Me.pnl_tabla.SuspendLayout()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_filtros
        '
        Me.pnl_filtros.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.pnl_filtros.Controls.Add(Me.grb_filtros)
        Me.pnl_filtros.Location = New System.Drawing.Point(6, 6)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(383, 128)
        Me.pnl_filtros.TabIndex = 0
        '
        'grb_filtros
        '
        Me.grb_filtros.Controls.Add(Me.btn_consultar_filtros)
        Me.grb_filtros.Controls.Add(Me.cmb_grupo)
        Me.grb_filtros.Controls.Add(Me.txt_usuario)
        Me.grb_filtros.Controls.Add(Me.chk_todos)
        Me.grb_filtros.Controls.Add(Me.lbl_grupo)
        Me.grb_filtros.Controls.Add(Me.lbl_usuario)
        Me.grb_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_filtros.ForeColor = System.Drawing.Color.Black
        Me.grb_filtros.Location = New System.Drawing.Point(6, 3)
        Me.grb_filtros.Name = "grb_filtros"
        Me.grb_filtros.Size = New System.Drawing.Size(369, 117)
        Me.grb_filtros.TabIndex = 1
        Me.grb_filtros.TabStop = False
        Me.grb_filtros.Text = "Filtros"
        '
        'btn_consultar_filtros
        '
        Me.btn_consultar_filtros.Location = New System.Drawing.Point(267, 87)
        Me.btn_consultar_filtros.Name = "btn_consultar_filtros"
        Me.btn_consultar_filtros.Size = New System.Drawing.Size(81, 23)
        Me.btn_consultar_filtros.TabIndex = 5
        Me.btn_consultar_filtros.Text = "Consultar"
        Me.btn_consultar_filtros.UseVisualStyleBackColor = True
        '
        'cmb_grupo
        '
        Me.cmb_grupo.FormattingEnabled = True
        Me.cmb_grupo.Location = New System.Drawing.Point(87, 55)
        Me.cmb_grupo.Name = "cmb_grupo"
        Me.cmb_grupo.Size = New System.Drawing.Size(261, 24)
        Me.cmb_grupo.TabIndex = 4
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(87, 22)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(261, 22)
        Me.txt_usuario.TabIndex = 3
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(87, 91)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(67, 20)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'lbl_grupo
        '
        Me.lbl_grupo.AutoSize = True
        Me.lbl_grupo.Location = New System.Drawing.Point(30, 58)
        Me.lbl_grupo.Name = "lbl_grupo"
        Me.lbl_grupo.Size = New System.Drawing.Size(48, 16)
        Me.lbl_grupo.TabIndex = 1
        Me.lbl_grupo.Text = "Grupo:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(16, 25)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(61, 16)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario: "
        '
        'pnl_tabla
        '
        Me.pnl_tabla.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.pnl_tabla.Controls.Add(Me.dgv_usuarios)
        Me.pnl_tabla.Location = New System.Drawing.Point(6, 140)
        Me.pnl_tabla.Name = "pnl_tabla"
        Me.pnl_tabla.Size = New System.Drawing.Size(383, 241)
        Me.pnl_tabla.TabIndex = 2
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToDeleteRows = False
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usu_codigo, Me.usu_usuario, Me.usu_nmbCompleto, Me.usu_mail, Me.grp_denom, Me.estado, Me.usu_clave})
        Me.dgv_usuarios.Location = New System.Drawing.Point(6, 6)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.ReadOnly = True
        Me.dgv_usuarios.Size = New System.Drawing.Size(369, 229)
        Me.dgv_usuarios.TabIndex = 0
        '
        'usu_codigo
        '
        Me.usu_codigo.HeaderText = "usu_codigo"
        Me.usu_codigo.Name = "usu_codigo"
        Me.usu_codigo.ReadOnly = True
        Me.usu_codigo.Visible = False
        Me.usu_codigo.Width = 50
        '
        'usu_usuario
        '
        Me.usu_usuario.HeaderText = "Usuario"
        Me.usu_usuario.Name = "usu_usuario"
        Me.usu_usuario.ReadOnly = True
        Me.usu_usuario.Width = 75
        '
        'usu_nmbCompleto
        '
        Me.usu_nmbCompleto.HeaderText = "Nombre Completo"
        Me.usu_nmbCompleto.Name = "usu_nmbCompleto"
        Me.usu_nmbCompleto.ReadOnly = True
        Me.usu_nmbCompleto.Width = 150
        '
        'usu_mail
        '
        Me.usu_mail.HeaderText = "Mail"
        Me.usu_mail.Name = "usu_mail"
        Me.usu_mail.ReadOnly = True
        Me.usu_mail.Width = 150
        '
        'grp_denom
        '
        Me.grp_denom.HeaderText = "Grupo"
        Me.grp_denom.Name = "grp_denom"
        Me.grp_denom.ReadOnly = True
        Me.grp_denom.Width = 125
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        '
        'usu_clave
        '
        Me.usu_clave.HeaderText = "usu_clave"
        Me.usu_clave.Name = "usu_clave"
        Me.usu_clave.ReadOnly = True
        Me.usu_clave.Visible = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._agregar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.Location = New System.Drawing.Point(6, 5)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(62, 5)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 4
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.Location = New System.Drawing.Point(118, 6)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.TabIndex = 5
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(325, 5)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._consultar
        Me.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_consultar.Location = New System.Drawing.Point(174, 6)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(50, 50)
        Me.btn_consultar.TabIndex = 7
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_consultar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Location = New System.Drawing.Point(6, 386)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 59)
        Me.Panel1.TabIndex = 8
        '
        'Frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 449)
        Me.Controls.Add(Me.pnl_tabla)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.pnl_filtros.ResumeLayout(False)
        Me.grb_filtros.ResumeLayout(False)
        Me.grb_filtros.PerformLayout()
        Me.pnl_tabla.ResumeLayout(False)
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_filtros As System.Windows.Forms.Panel
    Friend WithEvents grb_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_grupo As System.Windows.Forms.Label
    Friend WithEvents pnl_tabla As System.Windows.Forms.Panel
    Friend WithEvents dgv_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents usu_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_nmbCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grp_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usu_clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_consultar_filtros As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
End Class
