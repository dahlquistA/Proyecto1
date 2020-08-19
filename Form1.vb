Public Class Formulario1
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        TMensaje.Text = TApellido.Text & ", " & TNombre.Text
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TMensaje.Clear()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End

    End Sub




    Private Sub Formulario1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Control + Keys.S Then
            End
        End If


    End Sub
End Class
