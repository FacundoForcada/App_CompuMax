<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Proveedor))
        Me.grb_filtros = New System.Windows.Forms.GroupBox()
        Me.btn_consultar_filtros = New System.Windows.Forms.Button()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.lbl_cuit = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.dgv_proveedores = New System.Windows.Forms.DataGridView()
        Me.prov_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prov_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prov_cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.txt_cuit = New System.Windows.Forms.TextBox()
        Me.grb_filtros.SuspendLayout()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_filtros
        '
        Me.grb_filtros.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.grb_filtros.Controls.Add(Me.txt_cuit)
        Me.grb_filtros.Controls.Add(Me.btn_consultar_filtros)
        Me.grb_filtros.Controls.Add(Me.chk_todos)
        Me.grb_filtros.Controls.Add(Me.txt_proveedor)
        Me.grb_filtros.Controls.Add(Me.lbl_cuit)
        Me.grb_filtros.Controls.Add(Me.lbl_proveedor)
        Me.grb_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grb_filtros.ForeColor = System.Drawing.Color.Black
        Me.grb_filtros.Location = New System.Drawing.Point(8, 12)
        Me.grb_filtros.Name = "grb_filtros"
        Me.grb_filtros.Size = New System.Drawing.Size(370, 124)
        Me.grb_filtros.TabIndex = 0
        Me.grb_filtros.TabStop = False
        Me.grb_filtros.Text = "Filtros"
        '
        'btn_consultar_filtros
        '
        Me.btn_consultar_filtros.Location = New System.Drawing.Point(274, 92)
        Me.btn_consultar_filtros.Name = "btn_consultar_filtros"
        Me.btn_consultar_filtros.Size = New System.Drawing.Size(81, 23)
        Me.btn_consultar_filtros.TabIndex = 5
        Me.btn_consultar_filtros.Text = "Consultar"
        Me.btn_consultar_filtros.UseVisualStyleBackColor = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(95, 96)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(67, 20)
        Me.chk_todos.TabIndex = 4
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(95, 21)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(260, 22)
        Me.txt_proveedor.TabIndex = 2
        '
        'lbl_cuit
        '
        Me.lbl_cuit.AutoSize = True
        Me.lbl_cuit.Location = New System.Drawing.Point(46, 57)
        Me.lbl_cuit.Name = "lbl_cuit"
        Me.lbl_cuit.Size = New System.Drawing.Size(42, 16)
        Me.lbl_cuit.TabIndex = 1
        Me.lbl_cuit.Text = "CUIT:"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_proveedor.Location = New System.Drawing.Point(10, 25)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(75, 16)
        Me.lbl_proveedor.TabIndex = 0
        Me.lbl_proveedor.Text = "Proveedor:"
        '
        'dgv_proveedores
        '
        Me.dgv_proveedores.AllowUserToAddRows = False
        Me.dgv_proveedores.AllowUserToDeleteRows = False
        Me.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prov_codigo, Me.prov_denom, Me.prov_cuit, Me.est_denom})
        Me.dgv_proveedores.Location = New System.Drawing.Point(8, 142)
        Me.dgv_proveedores.Name = "dgv_proveedores"
        Me.dgv_proveedores.ReadOnly = True
        Me.dgv_proveedores.Size = New System.Drawing.Size(369, 270)
        Me.dgv_proveedores.TabIndex = 1
        '
        'prov_codigo
        '
        Me.prov_codigo.HeaderText = "Codigo"
        Me.prov_codigo.Name = "prov_codigo"
        Me.prov_codigo.ReadOnly = True
        '
        'prov_denom
        '
        Me.prov_denom.HeaderText = "Proveedor"
        Me.prov_denom.Name = "prov_denom"
        Me.prov_denom.ReadOnly = True
        '
        'prov_cuit
        '
        Me.prov_cuit.HeaderText = "CUIT"
        Me.prov_cuit.Name = "prov_cuit"
        Me.prov_cuit.ReadOnly = True
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
        Me.btn_agregar.Location = New System.Drawing.Point(3, 3)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(59, 3)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 3
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.Location = New System.Drawing.Point(115, 3)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(316, 3)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_consultar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Location = New System.Drawing.Point(8, 418)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 56)
        Me.Panel1.TabIndex = 6
        '
        'btn_consultar
        '
        Me.btn_consultar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._consultar
        Me.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_consultar.Location = New System.Drawing.Point(171, 3)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(50, 50)
        Me.btn_consultar.TabIndex = 8
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(95, 54)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(100, 22)
        Me.txt_cuit.TabIndex = 6
        '
        'Frm_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 481)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_proveedores)
        Me.Controls.Add(Me.grb_filtros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.grb_filtros.ResumeLayout(False)
        Me.grb_filtros.PerformLayout()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cuit As System.Windows.Forms.Label
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents txt_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_consultar_filtros As System.Windows.Forms.Button
    Friend WithEvents dgv_proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents prov_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prov_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prov_cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cuit As System.Windows.Forms.TextBox
End Class
