<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tr_Venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Tr_Venta))
        Me.lbl_nro_factura = New System.Windows.Forms.Label()
        Me.txt_nro_factura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.grp_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_cli_mail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_cli_cuit = New System.Windows.Forms.TextBox()
        Me.txt_cli_telefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cli_numdoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tdc_denom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cli_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_cli_apellido = New System.Windows.Forms.Label()
        Me.txt_cli_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_cli_nombre = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_buscar_cliente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_prom_denom = New System.Windows.Forms.ComboBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.chk_combos = New System.Windows.Forms.CheckBox()
        Me.chk_productos = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_totalgral = New System.Windows.Forms.TextBox()
        Me.txt_subtotal_combo = New System.Windows.Forms.TextBox()
        Me.txt_subtotal_prod = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.prod_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpr_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpr_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mar_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mar_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_numserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ved_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ved_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prom_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prom_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prom_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_combos_listado = New System.Windows.Forms.DataGridView()
        Me.combo_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.combo_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_categoria_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_categoria_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_prom_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_prom_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_prom_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_combos = New System.Windows.Forms.DataGridView()
        Me.com_com_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_com_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_prod_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_prod_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_tpr_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_tpr_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_cat_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_cat_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_mar_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_mar_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_prod_numserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com_prod_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar_prod = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_prod_denom = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_tipoprod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_cli_codigo = New System.Windows.Forms.TextBox()
        Me.grp_cliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_combos_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_combos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nro_factura
        '
        Me.lbl_nro_factura.AutoSize = True
        Me.lbl_nro_factura.Location = New System.Drawing.Point(16, 15)
        Me.lbl_nro_factura.Name = "lbl_nro_factura"
        Me.lbl_nro_factura.Size = New System.Drawing.Size(81, 13)
        Me.lbl_nro_factura.TabIndex = 0
        Me.lbl_nro_factura.Text = "Nro de Factura:"
        '
        'txt_nro_factura
        '
        Me.txt_nro_factura.Enabled = False
        Me.txt_nro_factura.Location = New System.Drawing.Point(103, 12)
        Me.txt_nro_factura.Name = "txt_nro_factura"
        Me.txt_nro_factura.ReadOnly = True
        Me.txt_nro_factura.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_factura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha:"
        '
        'mtxt_fecha
        '
        Me.mtxt_fecha.Enabled = False
        Me.mtxt_fecha.Location = New System.Drawing.Point(273, 12)
        Me.mtxt_fecha.Mask = "00/00/0000 00:00"
        Me.mtxt_fecha.Name = "mtxt_fecha"
        Me.mtxt_fecha.ReadOnly = True
        Me.mtxt_fecha.Size = New System.Drawing.Size(109, 20)
        Me.mtxt_fecha.TabIndex = 3
        Me.mtxt_fecha.ValidatingType = GetType(Date)
        '
        'grp_cliente
        '
        Me.grp_cliente.Controls.Add(Me.txt_cli_codigo)
        Me.grp_cliente.Controls.Add(Me.txt_cli_mail)
        Me.grp_cliente.Controls.Add(Me.Label16)
        Me.grp_cliente.Controls.Add(Me.txt_cli_cuit)
        Me.grp_cliente.Controls.Add(Me.txt_cli_telefono)
        Me.grp_cliente.Controls.Add(Me.Label5)
        Me.grp_cliente.Controls.Add(Me.txt_cli_numdoc)
        Me.grp_cliente.Controls.Add(Me.Label4)
        Me.grp_cliente.Controls.Add(Me.txt_tdc_denom)
        Me.grp_cliente.Controls.Add(Me.Label3)
        Me.grp_cliente.Controls.Add(Me.Label2)
        Me.grp_cliente.Controls.Add(Me.txt_cli_apellido)
        Me.grp_cliente.Controls.Add(Me.lbl_cli_apellido)
        Me.grp_cliente.Controls.Add(Me.txt_cli_nombre)
        Me.grp_cliente.Controls.Add(Me.lbl_cli_nombre)
        Me.grp_cliente.Controls.Add(Me.btn_agregar)
        Me.grp_cliente.Controls.Add(Me.btn_buscar_cliente)
        Me.grp_cliente.Location = New System.Drawing.Point(15, 44)
        Me.grp_cliente.Name = "grp_cliente"
        Me.grp_cliente.Size = New System.Drawing.Size(838, 121)
        Me.grp_cliente.TabIndex = 4
        Me.grp_cliente.TabStop = False
        Me.grp_cliente.Text = "Cliente"
        '
        'txt_cli_mail
        '
        Me.txt_cli_mail.Enabled = False
        Me.txt_cli_mail.Location = New System.Drawing.Point(572, 83)
        Me.txt_cli_mail.MaxLength = 11
        Me.txt_cli_mail.Name = "txt_cli_mail"
        Me.txt_cli_mail.ReadOnly = True
        Me.txt_cli_mail.Size = New System.Drawing.Size(249, 20)
        Me.txt_cli_mail.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(528, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Mail: "
        '
        'txt_cli_cuit
        '
        Me.txt_cli_cuit.Enabled = False
        Me.txt_cli_cuit.Location = New System.Drawing.Point(572, 52)
        Me.txt_cli_cuit.MaxLength = 11
        Me.txt_cli_cuit.Name = "txt_cli_cuit"
        Me.txt_cli_cuit.ReadOnly = True
        Me.txt_cli_cuit.Size = New System.Drawing.Size(125, 20)
        Me.txt_cli_cuit.TabIndex = 15
        '
        'txt_cli_telefono
        '
        Me.txt_cli_telefono.Enabled = False
        Me.txt_cli_telefono.Location = New System.Drawing.Point(391, 83)
        Me.txt_cli_telefono.Name = "txt_cli_telefono"
        Me.txt_cli_telefono.ReadOnly = True
        Me.txt_cli_telefono.Size = New System.Drawing.Size(122, 20)
        Me.txt_cli_telefono.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Telefono:"
        '
        'txt_cli_numdoc
        '
        Me.txt_cli_numdoc.Enabled = False
        Me.txt_cli_numdoc.Location = New System.Drawing.Point(197, 83)
        Me.txt_cli_numdoc.Name = "txt_cli_numdoc"
        Me.txt_cli_numdoc.ReadOnly = True
        Me.txt_cli_numdoc.Size = New System.Drawing.Size(122, 20)
        Me.txt_cli_numdoc.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nro Dto:"
        '
        'txt_tdc_denom
        '
        Me.txt_tdc_denom.Enabled = False
        Me.txt_tdc_denom.Location = New System.Drawing.Point(72, 83)
        Me.txt_tdc_denom.Name = "txt_tdc_denom"
        Me.txt_tdc_denom.ReadOnly = True
        Me.txt_tdc_denom.Size = New System.Drawing.Size(55, 20)
        Me.txt_tdc_denom.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo Dto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(528, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CUIT: "
        '
        'txt_cli_apellido
        '
        Me.txt_cli_apellido.Enabled = False
        Me.txt_cli_apellido.Location = New System.Drawing.Point(325, 52)
        Me.txt_cli_apellido.Name = "txt_cli_apellido"
        Me.txt_cli_apellido.ReadOnly = True
        Me.txt_cli_apellido.Size = New System.Drawing.Size(188, 20)
        Me.txt_cli_apellido.TabIndex = 7
        '
        'lbl_cli_apellido
        '
        Me.lbl_cli_apellido.AutoSize = True
        Me.lbl_cli_apellido.Location = New System.Drawing.Point(269, 55)
        Me.lbl_cli_apellido.Name = "lbl_cli_apellido"
        Me.lbl_cli_apellido.Size = New System.Drawing.Size(50, 13)
        Me.lbl_cli_apellido.TabIndex = 6
        Me.lbl_cli_apellido.Text = "Apellido: "
        '
        'txt_cli_nombre
        '
        Me.txt_cli_nombre.Enabled = False
        Me.txt_cli_nombre.Location = New System.Drawing.Point(71, 52)
        Me.txt_cli_nombre.Name = "txt_cli_nombre"
        Me.txt_cli_nombre.ReadOnly = True
        Me.txt_cli_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_cli_nombre.TabIndex = 5
        '
        'lbl_cli_nombre
        '
        Me.lbl_cli_nombre.AutoSize = True
        Me.lbl_cli_nombre.Location = New System.Drawing.Point(15, 55)
        Me.lbl_cli_nombre.Name = "lbl_cli_nombre"
        Me.lbl_cli_nombre.Size = New System.Drawing.Size(50, 13)
        Me.lbl_cli_nombre.TabIndex = 2
        Me.lbl_cli_nombre.Text = "Nombre: "
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(99, 19)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(98, 23)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Nuevo Cliente"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_buscar_cliente
        '
        Me.btn_buscar_cliente.Location = New System.Drawing.Point(18, 19)
        Me.btn_buscar_cliente.Name = "btn_buscar_cliente"
        Me.btn_buscar_cliente.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar_cliente.TabIndex = 0
        Me.btn_buscar_cliente.Text = "Buscar"
        Me.btn_buscar_cliente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cmb_prom_denom)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_editar)
        Me.GroupBox1.Controls.Add(Me.chk_combos)
        Me.GroupBox1.Controls.Add(Me.chk_productos)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_totalgral)
        Me.GroupBox1.Controls.Add(Me.txt_subtotal_combo)
        Me.GroupBox1.Controls.Add(Me.txt_subtotal_prod)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_prod)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_cant)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmb_prod_denom)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb_tipoprod)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_marca)
        Me.GroupBox1.Controls.Add(Me.lbl_categoria)
        Me.GroupBox1.Controls.Add(Me.cmb_categoria)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1137, 502)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Venta"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(979, 472)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 17)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(979, 446)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 17)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(978, 423)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 17)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "$"
        '
        'cmb_prom_denom
        '
        Me.cmb_prom_denom.FormattingEnabled = True
        Me.cmb_prom_denom.Location = New System.Drawing.Point(738, 29)
        Me.cmb_prom_denom.Name = "cmb_prom_denom"
        Me.cmb_prom_denom.Size = New System.Drawing.Size(163, 21)
        Me.cmb_prom_denom.TabIndex = 43
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.eliminar
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.Location = New System.Drawing.Point(1076, 191)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(50, 50)
        Me.btn_eliminar.TabIndex = 42
        Me.btn_eliminar.Text = "  "
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.editar
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Location = New System.Drawing.Point(1076, 135)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(50, 50)
        Me.btn_editar.TabIndex = 41
        Me.btn_editar.Text = "  "
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'chk_combos
        '
        Me.chk_combos.AutoSize = True
        Me.chk_combos.Location = New System.Drawing.Point(16, 58)
        Me.chk_combos.Name = "chk_combos"
        Me.chk_combos.Size = New System.Drawing.Size(64, 17)
        Me.chk_combos.TabIndex = 40
        Me.chk_combos.Text = "Combos"
        Me.chk_combos.UseVisualStyleBackColor = True
        '
        'chk_productos
        '
        Me.chk_productos.AutoSize = True
        Me.chk_productos.Location = New System.Drawing.Point(16, 32)
        Me.chk_productos.Name = "chk_productos"
        Me.chk_productos.Size = New System.Drawing.Size(74, 17)
        Me.chk_productos.TabIndex = 39
        Me.chk_productos.Text = "Productos"
        Me.chk_productos.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(778, 474)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "(Cancelar)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(662, 474)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "(Confirmar)"
        '
        'txt_totalgral
        '
        Me.txt_totalgral.Location = New System.Drawing.Point(995, 470)
        Me.txt_totalgral.Name = "txt_totalgral"
        Me.txt_totalgral.ReadOnly = True
        Me.txt_totalgral.Size = New System.Drawing.Size(78, 20)
        Me.txt_totalgral.TabIndex = 36
        '
        'txt_subtotal_combo
        '
        Me.txt_subtotal_combo.Location = New System.Drawing.Point(995, 445)
        Me.txt_subtotal_combo.Name = "txt_subtotal_combo"
        Me.txt_subtotal_combo.ReadOnly = True
        Me.txt_subtotal_combo.Size = New System.Drawing.Size(78, 20)
        Me.txt_subtotal_combo.TabIndex = 35
        '
        'txt_subtotal_prod
        '
        Me.txt_subtotal_prod.Location = New System.Drawing.Point(995, 421)
        Me.txt_subtotal_prod.Name = "txt_subtotal_prod"
        Me.txt_subtotal_prod.ReadOnly = True
        Me.txt_subtotal_prod.Size = New System.Drawing.Size(78, 20)
        Me.txt_subtotal_prod.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(902, 474)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Total General:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(887, 449)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "SubTotal Combo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(877, 425)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "SubTotal Producto:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._cancelar
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Location = New System.Drawing.Point(754, 424)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 50)
        Me.btn_cancelar.TabIndex = 30
        Me.btn_cancelar.Text = "  "
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._aceptar
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_confirmar.Location = New System.Drawing.Point(639, 424)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(100, 50)
        Me.btn_confirmar.TabIndex = 29
        Me.btn_confirmar.Text = "  "
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1064, 326)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_productos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1056, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.AllowUserToDeleteRows = False
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_codigo, Me.prod_denom, Me.tpr_codigo, Me.tpr_denom, Me.cat_codigo, Me.cat_denom, Me.mar_codigo, Me.mar_denom, Me.prod_numserie, Me.ved_cantidad, Me.ved_precio, Me.prom_codigo, Me.prom_denom, Me.prom_desc, Me.subtotal})
        Me.dgv_productos.Location = New System.Drawing.Point(6, 6)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.ReadOnly = True
        Me.dgv_productos.Size = New System.Drawing.Size(1044, 288)
        Me.dgv_productos.TabIndex = 27
        '
        'prod_codigo
        '
        Me.prod_codigo.HeaderText = "prod_codigo"
        Me.prod_codigo.Name = "prod_codigo"
        Me.prod_codigo.ReadOnly = True
        Me.prod_codigo.Visible = False
        '
        'prod_denom
        '
        Me.prod_denom.HeaderText = "Producto"
        Me.prod_denom.Name = "prod_denom"
        Me.prod_denom.ReadOnly = True
        Me.prod_denom.Width = 190
        '
        'tpr_codigo
        '
        Me.tpr_codigo.HeaderText = "tpr_codigo"
        Me.tpr_codigo.Name = "tpr_codigo"
        Me.tpr_codigo.ReadOnly = True
        Me.tpr_codigo.Visible = False
        '
        'tpr_denom
        '
        Me.tpr_denom.HeaderText = "Tipo Producto"
        Me.tpr_denom.Name = "tpr_denom"
        Me.tpr_denom.ReadOnly = True
        '
        'cat_codigo
        '
        Me.cat_codigo.HeaderText = "cat_codigo"
        Me.cat_codigo.Name = "cat_codigo"
        Me.cat_codigo.ReadOnly = True
        Me.cat_codigo.Visible = False
        '
        'cat_denom
        '
        Me.cat_denom.HeaderText = "Categoria"
        Me.cat_denom.Name = "cat_denom"
        Me.cat_denom.ReadOnly = True
        '
        'mar_codigo
        '
        Me.mar_codigo.HeaderText = "mar_codigo"
        Me.mar_codigo.Name = "mar_codigo"
        Me.mar_codigo.ReadOnly = True
        Me.mar_codigo.Visible = False
        '
        'mar_denom
        '
        Me.mar_denom.HeaderText = "Marca"
        Me.mar_denom.Name = "mar_denom"
        Me.mar_denom.ReadOnly = True
        '
        'prod_numserie
        '
        Me.prod_numserie.HeaderText = "Num. Serie"
        Me.prod_numserie.Name = "prod_numserie"
        Me.prod_numserie.ReadOnly = True
        '
        'ved_cantidad
        '
        Me.ved_cantidad.HeaderText = "Cantidad"
        Me.ved_cantidad.Name = "ved_cantidad"
        Me.ved_cantidad.ReadOnly = True
        '
        'ved_precio
        '
        Me.ved_precio.HeaderText = "Precio Producto"
        Me.ved_precio.Name = "ved_precio"
        Me.ved_precio.ReadOnly = True
        Me.ved_precio.Width = 110
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
        Me.prom_desc.HeaderText = "Porcentaje Descuento"
        Me.prom_desc.Name = "prom_desc"
        Me.prom_desc.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_combos_listado)
        Me.TabPage2.Controls.Add(Me.dgv_combos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1056, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Combos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_combos_listado
        '
        Me.dgv_combos_listado.AllowUserToAddRows = False
        Me.dgv_combos_listado.AllowUserToDeleteRows = False
        Me.dgv_combos_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_combos_listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.combo_codigo, Me.combo_denom, Me.com_categoria_codigo, Me.com_categoria_denom, Me.com_cantidad, Me.com_precio, Me.com_prom_codigo, Me.com_prom_denom, Me.com_prom_desc, Me.com_subtotal})
        Me.dgv_combos_listado.Location = New System.Drawing.Point(8, 6)
        Me.dgv_combos_listado.Name = "dgv_combos_listado"
        Me.dgv_combos_listado.ReadOnly = True
        Me.dgv_combos_listado.Size = New System.Drawing.Size(518, 288)
        Me.dgv_combos_listado.TabIndex = 1
        '
        'combo_codigo
        '
        Me.combo_codigo.HeaderText = "combo_codigo"
        Me.combo_codigo.Name = "combo_codigo"
        Me.combo_codigo.ReadOnly = True
        Me.combo_codigo.Visible = False
        '
        'combo_denom
        '
        Me.combo_denom.HeaderText = "Combo"
        Me.combo_denom.Name = "combo_denom"
        Me.combo_denom.ReadOnly = True
        '
        'com_categoria_codigo
        '
        Me.com_categoria_codigo.HeaderText = "com_categoria_codigo"
        Me.com_categoria_codigo.Name = "com_categoria_codigo"
        Me.com_categoria_codigo.ReadOnly = True
        Me.com_categoria_codigo.Visible = False
        '
        'com_categoria_denom
        '
        Me.com_categoria_denom.HeaderText = "com_categoria_denom"
        Me.com_categoria_denom.Name = "com_categoria_denom"
        Me.com_categoria_denom.ReadOnly = True
        Me.com_categoria_denom.Visible = False
        '
        'com_cantidad
        '
        Me.com_cantidad.HeaderText = "Cantidad"
        Me.com_cantidad.Name = "com_cantidad"
        Me.com_cantidad.ReadOnly = True
        Me.com_cantidad.Width = 55
        '
        'com_precio
        '
        Me.com_precio.HeaderText = "Precio Combo"
        Me.com_precio.Name = "com_precio"
        Me.com_precio.ReadOnly = True
        '
        'com_prom_codigo
        '
        Me.com_prom_codigo.HeaderText = "com_prom_codigo"
        Me.com_prom_codigo.Name = "com_prom_codigo"
        Me.com_prom_codigo.ReadOnly = True
        Me.com_prom_codigo.Visible = False
        '
        'com_prom_denom
        '
        Me.com_prom_denom.HeaderText = "Promocion"
        Me.com_prom_denom.Name = "com_prom_denom"
        Me.com_prom_denom.ReadOnly = True
        Me.com_prom_denom.Width = 65
        '
        'com_prom_desc
        '
        Me.com_prom_desc.HeaderText = "Porcentaje Descuento"
        Me.com_prom_desc.Name = "com_prom_desc"
        Me.com_prom_desc.ReadOnly = True
        '
        'com_subtotal
        '
        Me.com_subtotal.HeaderText = "Subtotal"
        Me.com_subtotal.Name = "com_subtotal"
        Me.com_subtotal.ReadOnly = True
        Me.com_subtotal.Width = 63
        '
        'dgv_combos
        '
        Me.dgv_combos.AllowUserToAddRows = False
        Me.dgv_combos.AllowUserToDeleteRows = False
        Me.dgv_combos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_combos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.com_com_codigo, Me.com_com_denom, Me.com_prod_codigo, Me.com_prod_denom, Me.com_tpr_codigo, Me.com_tpr_denom, Me.com_cat_codigo, Me.com_cat_denom, Me.com_mar_codigo, Me.com_mar_denom, Me.com_prod_numserie, Me.com_prod_cantidad})
        Me.dgv_combos.Location = New System.Drawing.Point(532, 6)
        Me.dgv_combos.Name = "dgv_combos"
        Me.dgv_combos.ReadOnly = True
        Me.dgv_combos.Size = New System.Drawing.Size(518, 288)
        Me.dgv_combos.TabIndex = 0
        '
        'com_com_codigo
        '
        Me.com_com_codigo.HeaderText = "com_com_codigo"
        Me.com_com_codigo.Name = "com_com_codigo"
        Me.com_com_codigo.ReadOnly = True
        Me.com_com_codigo.Visible = False
        '
        'com_com_denom
        '
        Me.com_com_denom.HeaderText = "com_com_denom"
        Me.com_com_denom.Name = "com_com_denom"
        Me.com_com_denom.ReadOnly = True
        Me.com_com_denom.Visible = False
        '
        'com_prod_codigo
        '
        Me.com_prod_codigo.HeaderText = "com_prod_codigo"
        Me.com_prod_codigo.Name = "com_prod_codigo"
        Me.com_prod_codigo.ReadOnly = True
        Me.com_prod_codigo.Visible = False
        '
        'com_prod_denom
        '
        Me.com_prod_denom.HeaderText = "Producto"
        Me.com_prod_denom.Name = "com_prod_denom"
        Me.com_prod_denom.ReadOnly = True
        '
        'com_tpr_codigo
        '
        Me.com_tpr_codigo.HeaderText = "com_tpr_codigo"
        Me.com_tpr_codigo.Name = "com_tpr_codigo"
        Me.com_tpr_codigo.ReadOnly = True
        Me.com_tpr_codigo.Visible = False
        '
        'com_tpr_denom
        '
        Me.com_tpr_denom.HeaderText = "Tipo Producto"
        Me.com_tpr_denom.Name = "com_tpr_denom"
        Me.com_tpr_denom.ReadOnly = True
        '
        'com_cat_codigo
        '
        Me.com_cat_codigo.HeaderText = "com_cat_codigo"
        Me.com_cat_codigo.Name = "com_cat_codigo"
        Me.com_cat_codigo.ReadOnly = True
        Me.com_cat_codigo.Visible = False
        '
        'com_cat_denom
        '
        Me.com_cat_denom.HeaderText = "Categoria"
        Me.com_cat_denom.Name = "com_cat_denom"
        Me.com_cat_denom.ReadOnly = True
        '
        'com_mar_codigo
        '
        Me.com_mar_codigo.HeaderText = "com_mar_codigo"
        Me.com_mar_codigo.Name = "com_mar_codigo"
        Me.com_mar_codigo.ReadOnly = True
        Me.com_mar_codigo.Visible = False
        '
        'com_mar_denom
        '
        Me.com_mar_denom.HeaderText = "Marca"
        Me.com_mar_denom.Name = "com_mar_denom"
        Me.com_mar_denom.ReadOnly = True
        '
        'com_prod_numserie
        '
        Me.com_prod_numserie.HeaderText = "Num. Serie"
        Me.com_prod_numserie.Name = "com_prod_numserie"
        Me.com_prod_numserie.ReadOnly = True
        '
        'com_prod_cantidad
        '
        Me.com_prod_cantidad.HeaderText = "Cantidad"
        Me.com_prod_cantidad.Name = "com_prod_cantidad"
        Me.com_prod_cantidad.ReadOnly = True
        Me.com_prod_cantidad.Width = 65
        '
        'btn_agregar_prod
        '
        Me.btn_agregar_prod.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._agregar
        Me.btn_agregar_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_prod.Location = New System.Drawing.Point(936, 32)
        Me.btn_agregar_prod.Name = "btn_agregar_prod"
        Me.btn_agregar_prod.Size = New System.Drawing.Size(42, 40)
        Me.btn_agregar_prod.TabIndex = 26
        Me.btn_agregar_prod.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(666, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Cantidad:"
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(738, 56)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.Size = New System.Drawing.Size(163, 20)
        Me.txt_cant.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(666, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Promocion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Nombre:"
        '
        'cmb_prod_denom
        '
        Me.cmb_prod_denom.FormattingEnabled = True
        Me.cmb_prod_denom.Location = New System.Drawing.Point(460, 56)
        Me.cmb_prod_denom.Name = "cmb_prod_denom"
        Me.cmb_prod_denom.Size = New System.Drawing.Size(188, 21)
        Me.cmb_prod_denom.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(399, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Tipo Prod.:"
        '
        'cmb_tipoprod
        '
        Me.cmb_tipoprod.FormattingEnabled = True
        Me.cmb_tipoprod.Location = New System.Drawing.Point(460, 29)
        Me.cmb_tipoprod.Name = "cmb_tipoprod"
        Me.cmb_tipoprod.Size = New System.Drawing.Size(188, 21)
        Me.cmb_tipoprod.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Marca:"
        '
        'cmb_marca
        '
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(197, 29)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(188, 21)
        Me.cmb_marca.TabIndex = 16
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Location = New System.Drawing.Point(136, 59)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(55, 13)
        Me.lbl_categoria.TabIndex = 15
        Me.lbl_categoria.Text = "Categoria:"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(197, 56)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(188, 21)
        Me.cmb_categoria.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources.CompuMaxPNG
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(989, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 160)
        Me.Panel1.TabIndex = 6
        '
        'txt_cli_codigo
        '
        Me.txt_cli_codigo.Enabled = False
        Me.txt_cli_codigo.Location = New System.Drawing.Point(215, 20)
        Me.txt_cli_codigo.Name = "txt_cli_codigo"
        Me.txt_cli_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_cli_codigo.TabIndex = 18
        Me.txt_cli_codigo.Visible = False
        '
        'Frm_Tr_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 690)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_cliente)
        Me.Controls.Add(Me.mtxt_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nro_factura)
        Me.Controls.Add(Me.lbl_nro_factura)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Name = "Frm_Tr_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de Productos"
        Me.grp_cliente.ResumeLayout(False)
        Me.grp_cliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_combos_listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_combos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nro_factura As System.Windows.Forms.Label
    Friend WithEvents txt_nro_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grp_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cli_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cli_numdoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_tdc_denom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cli_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cli_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_cli_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cli_nombre As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_cliente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_categoria As System.Windows.Forms.Label
    Friend WithEvents cmb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_prod_denom As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoprod As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_cant As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_productos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_agregar_prod As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents dgv_combos As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_totalgral As System.Windows.Forms.TextBox
    Friend WithEvents txt_subtotal_combo As System.Windows.Forms.TextBox
    Friend WithEvents txt_subtotal_prod As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chk_combos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_productos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cli_cuit As System.Windows.Forms.TextBox
    Friend WithEvents txt_cli_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents dgv_combos_listado As System.Windows.Forms.DataGridView
    Friend WithEvents com_com_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_com_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_prod_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_prod_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_tpr_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_tpr_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_cat_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_cat_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_mar_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_mar_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_prod_numserie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_prod_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_prom_denom As System.Windows.Forms.ComboBox
    Friend WithEvents combo_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents combo_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_categoria_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_categoria_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_prom_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_prom_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_prom_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpr_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpr_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mar_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mar_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_numserie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ved_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ved_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prom_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prom_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prom_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_cli_codigo As System.Windows.Forms.TextBox
End Class
