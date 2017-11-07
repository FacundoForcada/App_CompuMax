<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ABM_Promocion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ABM_Promocion))
        Me.lbl_prom_codigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_prom_codigo = New System.Windows.Forms.TextBox()
        Me.txt_prom_desc = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_prom_denom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_prom_codigo
        '
        Me.lbl_prom_codigo.AutoSize = True
        Me.lbl_prom_codigo.Location = New System.Drawing.Point(12, 22)
        Me.lbl_prom_codigo.Name = "lbl_prom_codigo"
        Me.lbl_prom_codigo.Size = New System.Drawing.Size(96, 13)
        Me.lbl_prom_codigo.TabIndex = 0
        Me.lbl_prom_codigo.Text = "Codigo Promocion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Promocion (*):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento (*):"
        '
        'txt_prom_codigo
        '
        Me.txt_prom_codigo.Enabled = False
        Me.txt_prom_codigo.Location = New System.Drawing.Point(116, 19)
        Me.txt_prom_codigo.Name = "txt_prom_codigo"
        Me.txt_prom_codigo.ReadOnly = True
        Me.txt_prom_codigo.Size = New System.Drawing.Size(42, 20)
        Me.txt_prom_codigo.TabIndex = 4
        '
        'txt_prom_desc
        '
        Me.txt_prom_desc.Location = New System.Drawing.Point(116, 75)
        Me.txt_prom_desc.Name = "txt_prom_desc"
        Me.txt_prom_desc.Size = New System.Drawing.Size(156, 20)
        Me.txt_prom_desc.TabIndex = 5
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(51, 143)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 8
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(197, 143)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_prom_denom
        '
        Me.txt_prom_denom.Location = New System.Drawing.Point(116, 47)
        Me.txt_prom_denom.Name = "txt_prom_denom"
        Me.txt_prom_denom.Size = New System.Drawing.Size(156, 20)
        Me.txt_prom_denom.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Estado (*):"
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(116, 103)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(156, 21)
        Me.cmb_estado.TabIndex = 12
        '
        'Frm_ABM_Promocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(305, 178)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_prom_denom)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_prom_desc)
        Me.Controls.Add(Me.txt_prom_codigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_prom_codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ABM_Promocion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Promociones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_prom_codigo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_prom_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_prom_desc As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_prom_denom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
End Class
