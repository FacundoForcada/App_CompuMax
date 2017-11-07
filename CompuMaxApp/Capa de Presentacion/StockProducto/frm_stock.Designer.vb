<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_stock))
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.dgv_stock_producto = New System.Windows.Forms.DataGridView()
        Me.prod_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_denom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stp_cantactual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stp_cantminima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_stock_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.CompuMaxApp.My.Resources.Resources._salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(305, 331)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 50)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'dgv_stock_producto
        '
        Me.dgv_stock_producto.AllowUserToAddRows = False
        Me.dgv_stock_producto.AllowUserToDeleteRows = False
        Me.dgv_stock_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stock_producto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_codigo, Me.prod_denom, Me.stp_cantactual, Me.stp_cantminima})
        Me.dgv_stock_producto.Location = New System.Drawing.Point(12, 12)
        Me.dgv_stock_producto.Name = "dgv_stock_producto"
        Me.dgv_stock_producto.ReadOnly = True
        Me.dgv_stock_producto.Size = New System.Drawing.Size(343, 313)
        Me.dgv_stock_producto.TabIndex = 6
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
        '
        'stp_cantactual
        '
        Me.stp_cantactual.HeaderText = "Cantidad Actual"
        Me.stp_cantactual.Name = "stp_cantactual"
        Me.stp_cantactual.ReadOnly = True
        '
        'stp_cantminima
        '
        Me.stp_cantminima.HeaderText = "Cantidad Minima"
        Me.stp_cantminima.Name = "stp_cantminima"
        Me.stp_cantminima.ReadOnly = True
        '
        'Frm_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 394)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_stock_producto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_stock"
        Me.Text = "Stock"
        CType(Me.dgv_stock_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents dgv_stock_producto As System.Windows.Forms.DataGridView
    Friend WithEvents prod_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_denom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stp_cantactual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stp_cantminima As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
