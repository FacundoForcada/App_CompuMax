<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AgregarCantProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AgregarCantProd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cantProd = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad: "
        '
        'txt_cantProd
        '
        Me.txt_cantProd.Location = New System.Drawing.Point(108, 21)
        Me.txt_cantProd.Name = "txt_cantProd"
        Me.txt_cantProd.Size = New System.Drawing.Size(131, 20)
        Me.txt_cantProd.TabIndex = 1
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(50, 58)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(164, 58)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Frm_AgregarCantProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 98)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_cantProd)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_AgregarCantProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingrese Cantidad de Producto..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cantProd As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
