<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Producto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_consultar_filtros = New System.Windows.Forms.Button()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.cmb_tipoProd = New System.Windows.Forms.ComboBox()
        Me.txt_denom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.prod_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpr_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mar_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_numserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 183)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmb_categoria)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_consultar_filtros)
        Me.GroupBox1.Controls.Add(Me.chk_todos)
        Me.GroupBox1.Controls.Add(Me.cmb_marca)
        Me.GroupBox1.Controls.Add(Me.cmb_tipoProd)
        Me.GroupBox1.Controls.Add(Me.txt_denom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 172)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(119, 102)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(241, 24)
        Me.cmb_categoria.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Categoria:"
        '
        'btn_consultar_filtros
        '
        Me.btn_consultar_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar_filtros.Location = New System.Drawing.Point(285, 137)
        Me.btn_consultar_filtros.Name = "btn_consultar_filtros"
        Me.btn_consultar_filtros.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar_filtros.TabIndex = 8
        Me.btn_consultar_filtros.Text = "Consultar"
        Me.btn_consultar_filtros.UseVisualStyleBackColor = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(119, 140)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(67, 20)
        Me.chk_todos.TabIndex = 7
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'cmb_marca
        '
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(119, 73)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(241, 24)
        Me.cmb_marca.TabIndex = 5
        '
        'cmb_tipoProd
        '
        Me.cmb_tipoProd.FormattingEnabled = True
        Me.cmb_tipoProd.Location = New System.Drawing.Point(119, 45)
        Me.cmb_tipoProd.Name = "cmb_tipoProd"
        Me.cmb_tipoProd.Size = New System.Drawing.Size(241, 24)
        Me.cmb_tipoProd.TabIndex = 4
        '
        'txt_denom
        '
        Me.txt_denom.Location = New System.Drawing.Point(119, 17)
        Me.txt_denom.Name = "txt_denom"
        Me.txt_denom.Size = New System.Drawing.Size(241, 22)
        Me.txt_denom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel2.Controls.Add(Me.dgv_productos)
        Me.Panel2.Location = New System.Drawing.Point(6, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 232)
        Me.Panel2.TabIndex = 1
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.AllowUserToDeleteRows = False
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_codigo, Me.prod_denom, Me.tpr_denom, Me.mar_denom, Me.prod_numserie, Me.prod_precio, Me.est_codigo, Me.cat_denom})
        Me.dgv_productos.Location = New System.Drawing.Point(6, 3)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.ReadOnly = True
        Me.dgv_productos.Size = New System.Drawing.Size(367, 226)
        Me.dgv_productos.TabIndex = 0
        '
        'prod_codigo
        '
        Me.prod_codigo.HeaderText = "prod_codigo"
        Me.prod_codigo.Name = "prod_codigo"
        Me.prod_codigo.ReadOnly = True
        Me.prod_codigo.Visible = False
        Me.prod_codigo.Width = 50
        '
        'prod_denom
        '
        Me.prod_denom.HeaderText = "Producto"
        Me.prod_denom.Name = "prod_denom"
        Me.prod_denom.ReadOnly = True
        '
        'tpr_denom
        '
        Me.tpr_denom.HeaderText = "Tipo Producto"
        Me.tpr_denom.Name = "tpr_denom"
        Me.tpr_denom.ReadOnly = True
        Me.tpr_denom.Width = 75
        '
        'mar_denom
        '
        Me.mar_denom.HeaderText = "Marca"
        Me.mar_denom.Name = "mar_denom"
        Me.mar_denom.ReadOnly = True
        '
        'prod_numserie
        '
        Me.prod_numserie.HeaderText = "Numero de Serie"
        Me.prod_numserie.Name = "prod_numserie"
        Me.prod_numserie.ReadOnly = True
        '
        'prod_precio
        '
        Me.prod_precio.HeaderText = "Precio"
        Me.prod_precio.Name = "prod_precio"
        Me.prod_precio.ReadOnly = True
        Me.prod_precio.Width = 50
        '
        'est_codigo
        '
        Me.est_codigo.HeaderText = "estado"
        Me.est_codigo.Name = "est_codigo"
        Me.est_codigo.ReadOnly = True
        Me.est_codigo.Visible = False
        '
        'cat_denom
        '
        Me.cat_denom.HeaderText = "Categoria"
        Me.cat_denom.Name = "cat_denom"
        Me.cat_denom.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_salir)
        Me.Panel3.Controls.Add(Me.btn_consultar)
        Me.Panel3.Controls.Add(Me.btn_eliminar)
        Me.Panel3.Controls.Add(Me.btn_editar)
        Me.Panel3.Controls.Add(Me.btn_agregar)
        Me.Panel3.Location = New System.Drawing.Point(6, 427)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(382, 56)
        Me.Panel3.TabIndex = 2
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(325, 3)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._consultar
        Me.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_consultar.Location = New System.Drawing.Point(174, 3)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(50, 50)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.Location = New System.Drawing.Point(118, 3)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(62, 3)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._agregar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.Location = New System.Drawing.Point(6, 3)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Frm_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 487)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents txt_denom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv_productos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_consultar_filtros As System.Windows.Forms.Button
    Friend WithEvents cmb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents prod_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpr_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mar_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_numserie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat_denom As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
