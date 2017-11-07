<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar_filtros = New System.Windows.Forms.Button()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.txt_nro_doc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.cli_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cli_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cli_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cli_cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdc_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdc_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cli_numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cli_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cli_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_consultar_filtros)
        Me.GroupBox1.Controls.Add(Me.chk_todos)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_doc)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 151)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'btn_consultar_filtros
        '
        Me.btn_consultar_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar_filtros.Location = New System.Drawing.Point(300, 115)
        Me.btn_consultar_filtros.Name = "btn_consultar_filtros"
        Me.btn_consultar_filtros.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar_filtros.TabIndex = 66
        Me.btn_consultar_filtros.Text = "Consultar"
        Me.btn_consultar_filtros.UseVisualStyleBackColor = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(93, 119)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 65
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(309, 79)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(65, 21)
        Me.cmb_tipo_doc.TabIndex = 61
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Location = New System.Drawing.Point(92, 79)
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(153, 20)
        Me.txt_nro_doc.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Apellido(*):"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(93, 52)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(282, 20)
        Me.txt_apellido.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Tipo Doc.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Nro. Doc.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Nombre(*):"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(93, 23)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(281, 20)
        Me.txt_nombre.TabIndex = 57
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_clientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 238)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cli_codigo, Me.cli_nombre, Me.cli_apellido, Me.cli_cuit, Me.tdc_codigo, Me.tdc_denom, Me.cli_numdoc, Me.cli_telefono, Me.cli_mail, Me.est_codigo})
        Me.dgv_clientes.Location = New System.Drawing.Point(11, 19)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.Size = New System.Drawing.Size(370, 210)
        Me.dgv_clientes.TabIndex = 50
        '
        'cli_codigo
        '
        Me.cli_codigo.HeaderText = "cli_codigo"
        Me.cli_codigo.Name = "cli_codigo"
        Me.cli_codigo.ReadOnly = True
        Me.cli_codigo.Visible = False
        '
        'cli_nombre
        '
        Me.cli_nombre.HeaderText = "Nombre"
        Me.cli_nombre.Name = "cli_nombre"
        Me.cli_nombre.ReadOnly = True
        '
        'cli_apellido
        '
        Me.cli_apellido.HeaderText = "Apellido"
        Me.cli_apellido.Name = "cli_apellido"
        Me.cli_apellido.ReadOnly = True
        '
        'cli_cuit
        '
        Me.cli_cuit.HeaderText = "Cuit"
        Me.cli_cuit.Name = "cli_cuit"
        Me.cli_cuit.ReadOnly = True
        '
        'tdc_codigo
        '
        Me.tdc_codigo.HeaderText = "tdc_codigo"
        Me.tdc_codigo.Name = "tdc_codigo"
        Me.tdc_codigo.ReadOnly = True
        Me.tdc_codigo.Visible = False
        '
        'tdc_denom
        '
        Me.tdc_denom.HeaderText = "Tipo Doc"
        Me.tdc_denom.Name = "tdc_denom"
        Me.tdc_denom.ReadOnly = True
        '
        'cli_numdoc
        '
        Me.cli_numdoc.HeaderText = "Nro Doc"
        Me.cli_numdoc.Name = "cli_numdoc"
        Me.cli_numdoc.ReadOnly = True
        '
        'cli_telefono
        '
        Me.cli_telefono.HeaderText = "Telefono"
        Me.cli_telefono.Name = "cli_telefono"
        Me.cli_telefono.ReadOnly = True
        '
        'cli_mail
        '
        Me.cli_mail.HeaderText = "Mail"
        Me.cli_mail.Name = "cli_mail"
        Me.cli_mail.ReadOnly = True
        '
        'est_codigo
        '
        Me.est_codigo.HeaderText = "est_codigo"
        Me.est_codigo.Name = "est_codigo"
        Me.est_codigo.ReadOnly = True
        Me.est_codigo.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_aceptar)
        Me.GroupBox3.Controls.Add(Me.btn_salir)
        Me.GroupBox3.Controls.Add(Me.btn_consultar)
        Me.GroupBox3.Controls.Add(Me.btn_eliminar)
        Me.GroupBox3.Controls.Add(Me.btn_editar)
        Me.GroupBox3.Controls.Add(Me.btn_agregar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 405)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 80)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._aceptar
        Me.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_aceptar.Location = New System.Drawing.Point(275, 19)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(50, 50)
        Me.btn_aceptar.TabIndex = 60
        Me.btn_aceptar.UseVisualStyleBackColor = True
        Me.btn_aceptar.Visible = False
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(331, 19)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 59
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._consultar
        Me.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_consultar.Location = New System.Drawing.Point(179, 19)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(50, 50)
        Me.btn_consultar.TabIndex = 58
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.Location = New System.Drawing.Point(123, 19)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.TabIndex = 57
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(67, 19)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 56
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._agregar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.Location = New System.Drawing.Point(11, 19)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(50, 50)
        Me.btn_agregar.TabIndex = 55
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Frm_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 497)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nro_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_consultar_filtros As System.Windows.Forms.Button
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents cli_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cli_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cli_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cli_cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdc_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdc_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cli_numdoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cli_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cli_mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
End Class
