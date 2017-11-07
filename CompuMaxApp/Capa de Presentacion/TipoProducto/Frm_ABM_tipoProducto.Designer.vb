<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABM_tipoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABM_tipoProducto))
        Me.txt_tpr_denom = New System.Windows.Forms.TextBox()
        Me.txt_tpr_codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_tpr_codigo = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_tpr_denom
        '
        Me.txt_tpr_denom.Location = New System.Drawing.Point(146, 48)
        Me.txt_tpr_denom.Name = "txt_tpr_denom"
        Me.txt_tpr_denom.Size = New System.Drawing.Size(210, 20)
        Me.txt_tpr_denom.TabIndex = 9
        '
        'txt_tpr_codigo
        '
        Me.txt_tpr_codigo.Enabled = False
        Me.txt_tpr_codigo.Location = New System.Drawing.Point(146, 17)
        Me.txt_tpr_codigo.Name = "txt_tpr_codigo"
        Me.txt_tpr_codigo.ReadOnly = True
        Me.txt_tpr_codigo.Size = New System.Drawing.Size(78, 20)
        Me.txt_tpr_codigo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Denominacion (*):"
        '
        'lbl_tpr_codigo
        '
        Me.lbl_tpr_codigo.AutoSize = True
        Me.lbl_tpr_codigo.Location = New System.Drawing.Point(12, 20)
        Me.lbl_tpr_codigo.Name = "lbl_tpr_codigo"
        Me.lbl_tpr_codigo.Size = New System.Drawing.Size(128, 13)
        Me.lbl_tpr_codigo.TabIndex = 6
        Me.lbl_tpr_codigo.Text = "Codigo de Tipo Producto:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(281, 79)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(146, 79)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 10
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Frm_ABM_tipoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(366, 112)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_tpr_denom)
        Me.Controls.Add(Me.txt_tpr_codigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_tpr_codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABM_tipoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Tipo de Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_tpr_denom As System.Windows.Forms.TextBox
    Friend WithEvents txt_tpr_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_tpr_codigo As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
End Class
