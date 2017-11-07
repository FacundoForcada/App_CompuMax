<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABM_combo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABM_combo))
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_com_denom = New System.Windows.Forms.TextBox()
        Me.txt_com_codigo = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_com_codigo = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_com_precio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(112, 117)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(204, 21)
        Me.cmb_estado.TabIndex = 15
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(241, 185)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_com_denom
        '
        Me.txt_com_denom.Location = New System.Drawing.Point(112, 48)
        Me.txt_com_denom.Name = "txt_com_denom"
        Me.txt_com_denom.Size = New System.Drawing.Size(204, 20)
        Me.txt_com_denom.TabIndex = 13
        '
        'txt_com_codigo
        '
        Me.txt_com_codigo.Enabled = False
        Me.txt_com_codigo.Location = New System.Drawing.Point(112, 17)
        Me.txt_com_codigo.Name = "txt_com_codigo"
        Me.txt_com_codigo.ReadOnly = True
        Me.txt_com_codigo.Size = New System.Drawing.Size(78, 20)
        Me.txt_com_codigo.TabIndex = 12
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(112, 185)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 11
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Estado (*):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Denominacion (*):"
        '
        'lbl_com_codigo
        '
        Me.lbl_com_codigo.AutoSize = True
        Me.lbl_com_codigo.Location = New System.Drawing.Point(12, 20)
        Me.lbl_com_codigo.Name = "lbl_com_codigo"
        Me.lbl_com_codigo.Size = New System.Drawing.Size(94, 13)
        Me.lbl_com_codigo.TabIndex = 8
        Me.lbl_com_codigo.Text = "Codigo de Combo:"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(112, 81)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(204, 21)
        Me.cmb_categoria.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Categoria (*):"
        '
        'txt_com_precio
        '
        Me.txt_com_precio.Location = New System.Drawing.Point(112, 151)
        Me.txt_com_precio.Name = "txt_com_precio"
        Me.txt_com_precio.Size = New System.Drawing.Size(78, 20)
        Me.txt_com_precio.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Precio(*):"
        '
        'Frm_ABM_combo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(329, 220)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_com_precio)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_com_denom)
        Me.Controls.Add(Me.txt_com_codigo)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_com_codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABM_combo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Combo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_com_denom As System.Windows.Forms.TextBox
    Friend WithEvents txt_com_codigo As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_com_codigo As System.Windows.Forms.Label
    Friend WithEvents cmb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_com_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
