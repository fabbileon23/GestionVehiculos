Imports ProyectoEntidades
Imports ProyectoLogica
Public Class FrmLogin

    Private Crendencial As New Usuarios()
    Private AccesoLogica As New UsuarioLogica()
    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        Crendencial.username = txtusuario.Text
        Crendencial.password = txtcontrasena.Text

        Dim reply As Reply = AccesoLogica.ObtenerUsuario(Crendencial)

        If reply.Success Then


            Avisos.lblmensaje.Text = "Inicio de sesión exitoso."
            Avisos.ShowDialog()
            FrmMenuPrincipal.ShowDialog()
            Me.Hide()

        Else
            Avisos.lblmensaje.Text = "Error, usuario o la contraseña son incorrectos."
            Avisos.ShowDialog()

        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
