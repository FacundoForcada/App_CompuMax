<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABM_grupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABM_grupo))
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_grp_denom = New System.Windows.Forms.TextBox()
        Me.txt_grp_codigo = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_grp_codigo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(116, 83)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(216, 21)
        Me.cmb_estado.TabIndex = 23
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(257, 119)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 22
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_grp_denom
        '
        Me.txt_grp_denom.Location = New System.Drawing.Point(116, 50)
        Me.txt_grp_denom.Name = "txt_grp_denom"
        Me.txt_grp_denom.Size = New System.Drawing.Size(216, 20)
        Me.txt_grp_denom.TabIndex = 21
        '
        'txt_grp_codigo
        '
        Me.txt_grp_codigo.Enabled = False
        Me.txt_grp_codigo.Location = New System.Drawing.Point(116, 19)
        Me.txt_grp_codigo.Name = "txt_grp_codigo"
        Me.txt_grp_codigo.ReadOnly = True
        Me.txt_grp_codigo.Size = New System.Drawing.Size(90, 20)
        Me.txt_grp_codigo.TabIndex = 20
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(116, 119)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 19
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Estado (*):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Denominacion (*):"
        '
        'lbl_grp_codigo
        '
        Me.lbl_grp_codigo.AutoSize = True
        Me.lbl_grp_codigo.Location = New System.Drawing.Point(23, 22)
        Me.lbl_grp_codigo.Name = "lbl_grp_codigo"
        Me.lbl_grp_codigo.Size = New System.Drawing.Size(87, 13)
        Me.lbl_grp_codigo.TabIndex = 16
        Me.lbl_grp_codigo.Text = "Codigo de Gupo:"
        '
        'Frm_ABM_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(349, 160)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_grp_denom)
        Me.Controls.Add(Me.txt_grp_codigo)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_grp_codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABM_grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Grupo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_grp_denom As System.Windows.Forms.TextBox
    Friend WithEvents txt_grp_codigo As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_grp_codigo As System.Windows.Forms.Label
End Class
