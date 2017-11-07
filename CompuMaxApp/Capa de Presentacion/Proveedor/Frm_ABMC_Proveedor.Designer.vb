<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABMC_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABMC_Proveedor))
        Me.lbl_prov_codigo = New System.Windows.Forms.Label()
        Me.lbl_prov_denom = New System.Windows.Forms.Label()
        Me.lbl_prov_cuit = New System.Windows.Forms.Label()
        Me.txt_prov_codigo = New System.Windows.Forms.TextBox()
        Me.txt_prov_denom = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_prov_cuit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_prov_codigo
        '
        Me.lbl_prov_codigo.AutoSize = True
        Me.lbl_prov_codigo.Location = New System.Drawing.Point(17, 18)
        Me.lbl_prov_codigo.Name = "lbl_prov_codigo"
        Me.lbl_prov_codigo.Size = New System.Drawing.Size(73, 13)
        Me.lbl_prov_codigo.TabIndex = 0
        Me.lbl_prov_codigo.Text = "ID Proveedor:"
        '
        'lbl_prov_denom
        '
        Me.lbl_prov_denom.AutoSize = True
        Me.lbl_prov_denom.Location = New System.Drawing.Point(17, 50)
        Me.lbl_prov_denom.Name = "lbl_prov_denom"
        Me.lbl_prov_denom.Size = New System.Drawing.Size(72, 13)
        Me.lbl_prov_denom.TabIndex = 1
        Me.lbl_prov_denom.Text = "Proveedor (*):"
        '
        'lbl_prov_cuit
        '
        Me.lbl_prov_cuit.AutoSize = True
        Me.lbl_prov_cuit.Location = New System.Drawing.Point(39, 84)
        Me.lbl_prov_cuit.Name = "lbl_prov_cuit"
        Me.lbl_prov_cuit.Size = New System.Drawing.Size(48, 13)
        Me.lbl_prov_cuit.TabIndex = 2
        Me.lbl_prov_cuit.Text = "CUIT (*):"
        '
        'txt_prov_codigo
        '
        Me.txt_prov_codigo.Enabled = False
        Me.txt_prov_codigo.Location = New System.Drawing.Point(96, 15)
        Me.txt_prov_codigo.Name = "txt_prov_codigo"
        Me.txt_prov_codigo.ReadOnly = True
        Me.txt_prov_codigo.Size = New System.Drawing.Size(50, 20)
        Me.txt_prov_codigo.TabIndex = 4
        '
        'txt_prov_denom
        '
        Me.txt_prov_denom.Location = New System.Drawing.Point(96, 46)
        Me.txt_prov_denom.Name = "txt_prov_denom"
        Me.txt_prov_denom.Size = New System.Drawing.Size(175, 20)
        Me.txt_prov_denom.TabIndex = 5
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(96, 125)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 8
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(196, 125)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_prov_cuit
        '
        Me.txt_prov_cuit.Location = New System.Drawing.Point(96, 81)
        Me.txt_prov_cuit.Name = "txt_prov_cuit"
        Me.txt_prov_cuit.Size = New System.Drawing.Size(175, 20)
        Me.txt_prov_cuit.TabIndex = 10
        '
        'Frm_ABMC_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(290, 161)
        Me.Controls.Add(Me.txt_prov_cuit)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_prov_denom)
        Me.Controls.Add(Me.txt_prov_codigo)
        Me.Controls.Add(Me.lbl_prov_cuit)
        Me.Controls.Add(Me.lbl_prov_denom)
        Me.Controls.Add(Me.lbl_prov_codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABMC_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_prov_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_prov_denom As System.Windows.Forms.Label
    Friend WithEvents lbl_prov_cuit As System.Windows.Forms.Label
    Friend WithEvents txt_prov_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_prov_denom As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_prov_cuit As System.Windows.Forms.TextBox
End Class
