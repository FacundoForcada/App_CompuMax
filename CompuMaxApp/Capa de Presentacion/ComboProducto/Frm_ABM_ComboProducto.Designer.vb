<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABM_ComboProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABM_ComboProducto))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar_cmb = New System.Windows.Forms.Button()
        Me.btn_quitar_producto = New System.Windows.Forms.Button()
        Me.cmb_comofiltro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_combo_productos = New System.Windows.Forms.DataGridView()
        Me.com_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmp_cantprod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_cmb = New System.Windows.Forms.Label()
        Me.lbl_tittle_grp = New System.Windows.Forms.Label()
        Me.btn_agregar_producto = New System.Windows.Forms.Button()
        Me.btn_consultar_producto = New System.Windows.Forms.Button()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.prod_codigo_P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_denom_P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mar_denom_P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_combo_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_consultar_cmb)
        Me.GroupBox2.Controls.Add(Me.btn_quitar_producto)
        Me.GroupBox2.Controls.Add(Me.cmb_comofiltro)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgv_combo_productos)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 214)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Combos"
        '
        'btn_consultar_cmb
        '
        Me.btn_consultar_cmb.Location = New System.Drawing.Point(316, 19)
        Me.btn_consultar_cmb.Name = "btn_consultar_cmb"
        Me.btn_consultar_cmb.Size = New System.Drawing.Size(124, 23)
        Me.btn_consultar_cmb.TabIndex = 11
        Me.btn_consultar_cmb.Text = "Buscar"
        Me.btn_consultar_cmb.UseVisualStyleBackColor = True
        '
        'btn_quitar_producto
        '
        Me.btn_quitar_producto.Location = New System.Drawing.Point(365, 98)
        Me.btn_quitar_producto.Name = "btn_quitar_producto"
        Me.btn_quitar_producto.Size = New System.Drawing.Size(75, 39)
        Me.btn_quitar_producto.TabIndex = 11
        Me.btn_quitar_producto.Text = "Quitar Producto"
        Me.btn_quitar_producto.UseVisualStyleBackColor = True
        '
        'cmb_comofiltro
        '
        Me.cmb_comofiltro.FormattingEnabled = True
        Me.cmb_comofiltro.Location = New System.Drawing.Point(62, 21)
        Me.cmb_comofiltro.Name = "cmb_comofiltro"
        Me.cmb_comofiltro.Size = New System.Drawing.Size(206, 21)
        Me.cmb_comofiltro.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Combo:"
        '
        'dgv_combo_productos
        '
        Me.dgv_combo_productos.AllowUserToAddRows = False
        Me.dgv_combo_productos.AllowUserToDeleteRows = False
        Me.dgv_combo_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_combo_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.com_codigo, Me.prod_codigo, Me.prod_denom, Me.cmp_cantprod})
        Me.dgv_combo_productos.Location = New System.Drawing.Point(16, 53)
        Me.dgv_combo_productos.Name = "dgv_combo_productos"
        Me.dgv_combo_productos.ReadOnly = True
        Me.dgv_combo_productos.Size = New System.Drawing.Size(343, 148)
        Me.dgv_combo_productos.TabIndex = 0
        '
        'com_codigo
        '
        Me.com_codigo.HeaderText = "com_codigo"
        Me.com_codigo.Name = "com_codigo"
        Me.com_codigo.ReadOnly = True
        Me.com_codigo.Visible = False
        '
        'prod_codigo
        '
        Me.prod_codigo.HeaderText = "Cod. Producto"
        Me.prod_codigo.Name = "prod_codigo"
        Me.prod_codigo.ReadOnly = True
        '
        'prod_denom
        '
        Me.prod_denom.HeaderText = "Denominacion"
        Me.prod_denom.Name = "prod_denom"
        Me.prod_denom.ReadOnly = True
        '
        'cmp_cantprod
        '
        Me.cmp_cantprod.HeaderText = "Cant. Producto"
        Me.cmp_cantprod.Name = "cmp_cantprod"
        Me.cmp_cantprod.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_cmb)
        Me.GroupBox1.Controls.Add(Me.lbl_tittle_grp)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_producto)
        Me.GroupBox1.Controls.Add(Me.btn_consultar_producto)
        Me.GroupBox1.Controls.Add(Me.txt_producto)
        Me.GroupBox1.Controls.Add(Me.chk_todos)
        Me.GroupBox1.Controls.Add(Me.lbl_usuario)
        Me.GroupBox1.Controls.Add(Me.dgv_productos)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 214)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'lbl_cmb
        '
        Me.lbl_cmb.AutoSize = True
        Me.lbl_cmb.Location = New System.Drawing.Point(317, 176)
        Me.lbl_cmb.Name = "lbl_cmb"
        Me.lbl_cmb.Size = New System.Drawing.Size(16, 13)
        Me.lbl_cmb.TabIndex = 12
        Me.lbl_cmb.Text = "- -"
        '
        'lbl_tittle_grp
        '
        Me.lbl_tittle_grp.AutoSize = True
        Me.lbl_tittle_grp.Location = New System.Drawing.Point(317, 154)
        Me.lbl_tittle_grp.Name = "lbl_tittle_grp"
        Me.lbl_tittle_grp.Size = New System.Drawing.Size(123, 13)
        Me.lbl_tittle_grp.TabIndex = 11
        Me.lbl_tittle_grp.Text = " - Combo Seleccionado -"
        '
        'btn_agregar_producto
        '
        Me.btn_agregar_producto.Location = New System.Drawing.Point(320, 94)
        Me.btn_agregar_producto.Name = "btn_agregar_producto"
        Me.btn_agregar_producto.Size = New System.Drawing.Size(75, 39)
        Me.btn_agregar_producto.TabIndex = 10
        Me.btn_agregar_producto.Text = "Agregar a Combo"
        Me.btn_agregar_producto.UseVisualStyleBackColor = True
        '
        'btn_consultar_producto
        '
        Me.btn_consultar_producto.Location = New System.Drawing.Point(316, 27)
        Me.btn_consultar_producto.Name = "btn_consultar_producto"
        Me.btn_consultar_producto.Size = New System.Drawing.Size(124, 23)
        Me.btn_consultar_producto.TabIndex = 9
        Me.btn_consultar_producto.Text = "Buscar"
        Me.btn_consultar_producto.UseVisualStyleBackColor = True
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(72, 27)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(173, 20)
        Me.txt_producto.TabIndex = 8
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(254, 31)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 7
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(13, 32)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(56, 13)
        Me.lbl_usuario.TabIndex = 6
        Me.lbl_usuario.Text = "Producto: "
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.AllowUserToDeleteRows = False
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_codigo_P, Me.prod_denom_P, Me.mar_denom_P})
        Me.dgv_productos.Location = New System.Drawing.Point(16, 60)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.ReadOnly = True
        Me.dgv_productos.Size = New System.Drawing.Size(294, 136)
        Me.dgv_productos.TabIndex = 1
        '
        'prod_codigo_P
        '
        Me.prod_codigo_P.HeaderText = "prod_codigo"
        Me.prod_codigo_P.Name = "prod_codigo_P"
        Me.prod_codigo_P.ReadOnly = True
        Me.prod_codigo_P.Visible = False
        '
        'prod_denom_P
        '
        Me.prod_denom_P.HeaderText = "Producto"
        Me.prod_denom_P.Name = "prod_denom_P"
        Me.prod_denom_P.ReadOnly = True
        Me.prod_denom_P.Width = 125
        '
        'mar_denom_P
        '
        Me.mar_denom_P.HeaderText = "Marca"
        Me.mar_denom_P.Name = "mar_denom_P"
        Me.mar_denom_P.ReadOnly = True
        Me.mar_denom_P.Width = 125
        '
        'Frm_ABM_ComboProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 455)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABM_ComboProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de Productos a Combos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_combo_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_consultar_cmb As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_producto As System.Windows.Forms.Button
    Friend WithEvents cmb_comofiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_combo_productos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cmb As System.Windows.Forms.Label
    Friend WithEvents lbl_tittle_grp As System.Windows.Forms.Label
    Friend WithEvents btn_agregar_producto As System.Windows.Forms.Button
    Friend WithEvents btn_consultar_producto As System.Windows.Forms.Button
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents dgv_productos As System.Windows.Forms.DataGridView
    Friend WithEvents com_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmp_cantprod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_codigo_P As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_denom_P As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mar_denom_P As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
