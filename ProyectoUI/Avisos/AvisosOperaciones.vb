Public Class AvisosOperaciones
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Variable.autorizacion = True
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Variable.autorizacion = False
        Me.Close()
    End Sub
End Class