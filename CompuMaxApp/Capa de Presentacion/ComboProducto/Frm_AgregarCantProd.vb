Public Class Frm_AgregarCantProd

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If txt_cantProd.Text = String.Empty Then
            MessageBox.Show("Debe cargar una cantidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_cantProd.Focus()
            Return
        Else
            Frm_ABM_ComboProducto.asignar_cantidad(Val(txt_cantProd.Text))
            Me.Dispose()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Frm_ABM_ComboProducto.asignar_cantidad(0)
        Me.Dispose()
    End Sub

    Private Sub Frm_AgregarCantProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class