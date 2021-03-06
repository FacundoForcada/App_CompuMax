﻿Public Class Login
    Private flagSalir As Boolean = True
    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim oUsuarioService As New UsuarioServices
        Dim oUsuario As Usuario = Nothing

        'Validamos que las cajas no esten vacías
        If txt_password.Text = String.Empty Or txt_usuario.Text = String.Empty Then
            MessageBox.Show("Olvidó ingresar usuario y/o password", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            oUsuario = oUsuarioService.validarUsuario(txt_usuario.Text, txt_password.Text)
            If Not IsNothing(oUsuario) Then
                Frm_Principal.actualizarUsuarioLogueado(oUsuario)
                flagSalir = False
                Me.Close()
            Else
                MessageBox.Show("Usuario y/o password incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Limpiamos las cajas de texto y dejamos el cursor sobre el control: txt_usuario.
                txt_password.Text = String.Empty
                txt_usuario.Text = String.Empty
                txt_usuario.Focus()
            End If
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'End finaliza la ejecución de la app.
        End
    End Sub

    'El evento: FormClosing se dispara justo cuando hacemos click en la cruz roja de la parte superior del formulario.
    Private Sub Frm_login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'La función MsgBox() retorna un valor entero que indica el botón seleccionado por el usuario cuando se pide confirmación de cierre. 1 Representa
        'el valor positivo de la confirmación, cualquier otro valor cancela la acción.
        'MsgBox parametros: 
        '1-Texto a mostrar en el cuerpo principal de la ventana
        '2-Estilo de la ventana de dialogo: MsgBoxStyle permite seleccionar tanto ICONO como botones a dibujar
        '3-Título de la ventana

        'Chequeamos el estado de: flagSalir para determinar si el evento closing de la ventana se dió por decisión del 
        'usuario o porque se logueo exitosamente y la app cerró la ventana mediante el metodo close()
        If flagSalir Then
            If MsgBox("Seguro que desea salir de la aplicación?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
                End
            Else
                'La propiedad e.Cancel permite cancelar el evento recibido.
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class