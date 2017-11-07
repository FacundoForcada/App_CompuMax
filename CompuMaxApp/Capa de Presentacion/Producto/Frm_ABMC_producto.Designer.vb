<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABMC_producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABMC_producto))
        Me.lbl_prod_codigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_prod_codigo = New System.Windows.Forms.TextBox()
        Me.txt_denom = New System.Windows.Forms.TextBox()
        Me.txt_numserie = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.cmb_tipoProd = New System.Windows.Forms.ComboBox()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_prod_codigo
        '
        Me.lbl_prod_codigo.AutoSize = True
        Me.lbl_prod_codigo.Location = New System.Drawing.Point(53, 17)
        Me.lbl_prod_codigo.Name = "lbl_prod_codigo"
        Me.lbl_prod_codigo.Size = New System.Drawing.Size(67, 13)
        Me.lbl_prod_codigo.TabIndex = 0
        Me.lbl_prod_codigo.Text = "ID Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre (*):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Producto (*):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Marca (*):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Numero de Serie (*):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio:"
        '
        'txt_prod_codigo
        '
        Me.txt_prod_codigo.Enabled = False
        Me.txt_prod_codigo.Location = New System.Drawing.Point(126, 14)
        Me.txt_prod_codigo.Name = "txt_prod_codigo"
        Me.txt_prod_codigo.ReadOnly = True
        Me.txt_prod_codigo.Size = New System.Drawing.Size(87, 20)
        Me.txt_prod_codigo.TabIndex = 6
        '
        'txt_denom
        '
        Me.txt_denom.Location = New System.Drawing.Point(126, 46)
        Me.txt_denom.Name = "txt_denom"
        Me.txt_denom.Size = New System.Drawing.Size(177, 20)
        Me.txt_denom.TabIndex = 7
        '
        'txt_numserie
        '
        Me.txt_numserie.Location = New System.Drawing.Point(126, 170)
        Me.txt_numserie.Name = "txt_numserie"
        Me.txt_numserie.Size = New System.Drawing.Size(177, 20)
        Me.txt_numserie.TabIndex = 8
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(126, 201)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(87, 20)
        Me.txt_precio.TabIndex = 9
        '
        'cmb_tipoProd
        '
        Me.cmb_tipoProd.FormattingEnabled = True
        Me.cmb_tipoProd.Location = New System.Drawing.Point(126, 76)
        Me.cmb_tipoProd.Name = "cmb_tipoProd"
        Me.cmb_tipoProd.Size = New System.Drawing.Size(177, 21)
        Me.cmb_tipoProd.TabIndex = 10
        '
        'cmb_marca
        '
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(126, 107)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(177, 21)
        Me.cmb_marca.TabIndex = 11
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(126, 236)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 12
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(228, 236)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmb_categoria
        '
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(126, 138)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(177, 21)
        Me.cmb_categoria.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Categoria (*):"
        '
        'Frm_ABMC_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 274)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cmb_marca)
        Me.Controls.Add(Me.cmb_tipoProd)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_numserie)
        Me.Controls.Add(Me.txt_denom)
        Me.Controls.Add(Me.txt_prod_codigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_prod_codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABMC_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_prod_codigo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_prod_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_denom As System.Windows.Forms.TextBox
    Friend WithEvents txt_numserie As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
