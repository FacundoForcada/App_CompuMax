<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABMC_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABMC_usuario))
        Me.lbl_usu_codigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_usu_codigo = New System.Windows.Forms.TextBox()
        Me.txt_usu_usuario = New System.Windows.Forms.TextBox()
        Me.txt_usu_nmbcompleto = New System.Windows.Forms.TextBox()
        Me.txt_usu_clave = New System.Windows.Forms.TextBox()
        Me.txt_usu_clave_rep = New System.Windows.Forms.TextBox()
        Me.txt_usu_mail = New System.Windows.Forms.TextBox()
        Me.cmb_grupo = New System.Windows.Forms.ComboBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_usu_codigo
        '
        Me.lbl_usu_codigo.AutoSize = True
        Me.lbl_usu_codigo.Location = New System.Drawing.Point(68, 14)
        Me.lbl_usu_codigo.Name = "lbl_usu_codigo"
        Me.lbl_usu_codigo.Size = New System.Drawing.Size(60, 13)
        Me.lbl_usu_codigo.TabIndex = 0
        Me.lbl_usu_codigo.Text = "ID Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario (*):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Completo (*):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cotraseña (*):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Repetir Cotraseña (*):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mail:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Grupo (*):"
        '
        'txt_usu_codigo
        '
        Me.txt_usu_codigo.Enabled = False
        Me.txt_usu_codigo.Location = New System.Drawing.Point(133, 11)
        Me.txt_usu_codigo.Name = "txt_usu_codigo"
        Me.txt_usu_codigo.ReadOnly = True
        Me.txt_usu_codigo.Size = New System.Drawing.Size(50, 20)
        Me.txt_usu_codigo.TabIndex = 7
        '
        'txt_usu_usuario
        '
        Me.txt_usu_usuario.Location = New System.Drawing.Point(133, 43)
        Me.txt_usu_usuario.Name = "txt_usu_usuario"
        Me.txt_usu_usuario.Size = New System.Drawing.Size(175, 20)
        Me.txt_usu_usuario.TabIndex = 8
        '
        'txt_usu_nmbcompleto
        '
        Me.txt_usu_nmbcompleto.Location = New System.Drawing.Point(133, 73)
        Me.txt_usu_nmbcompleto.Name = "txt_usu_nmbcompleto"
        Me.txt_usu_nmbcompleto.Size = New System.Drawing.Size(175, 20)
        Me.txt_usu_nmbcompleto.TabIndex = 9
        '
        'txt_usu_clave
        '
        Me.txt_usu_clave.Location = New System.Drawing.Point(133, 104)
        Me.txt_usu_clave.Name = "txt_usu_clave"
        Me.txt_usu_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_usu_clave.Size = New System.Drawing.Size(175, 20)
        Me.txt_usu_clave.TabIndex = 10
        '
        'txt_usu_clave_rep
        '
        Me.txt_usu_clave_rep.Location = New System.Drawing.Point(133, 135)
        Me.txt_usu_clave_rep.Name = "txt_usu_clave_rep"
        Me.txt_usu_clave_rep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_usu_clave_rep.Size = New System.Drawing.Size(175, 20)
        Me.txt_usu_clave_rep.TabIndex = 11
        '
        'txt_usu_mail
        '
        Me.txt_usu_mail.Location = New System.Drawing.Point(133, 166)
        Me.txt_usu_mail.Name = "txt_usu_mail"
        Me.txt_usu_mail.Size = New System.Drawing.Size(175, 20)
        Me.txt_usu_mail.TabIndex = 12
        '
        'cmb_grupo
        '
        Me.cmb_grupo.FormattingEnabled = True
        Me.cmb_grupo.Location = New System.Drawing.Point(133, 198)
        Me.cmb_grupo.Name = "cmb_grupo"
        Me.cmb_grupo.Size = New System.Drawing.Size(175, 21)
        Me.cmb_grupo.TabIndex = 13
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(133, 234)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 14
        Me.btn_aceptar.Text = "Agregar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(233, 234)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 15
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Frm_ABMC_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 269)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cmb_grupo)
        Me.Controls.Add(Me.txt_usu_mail)
        Me.Controls.Add(Me.txt_usu_clave_rep)
        Me.Controls.Add(Me.txt_usu_clave)
        Me.Controls.Add(Me.txt_usu_nmbcompleto)
        Me.Controls.Add(Me.txt_usu_usuario)
        Me.Controls.Add(Me.txt_usu_codigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_usu_codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABMC_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usu_codigo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_usu_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_usu_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_usu_nmbcompleto As System.Windows.Forms.TextBox
    Friend WithEvents txt_usu_clave As System.Windows.Forms.TextBox
    Friend WithEvents txt_usu_clave_rep As System.Windows.Forms.TextBox
    Friend WithEvents txt_usu_mail As System.Windows.Forms.TextBox
    Friend WithEvents cmb_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
