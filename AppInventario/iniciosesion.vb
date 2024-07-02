Public Class iniciosesion
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click

        Try
            Dim objusu As New CmpInventario.Cliente
            objusu.Login(TextBox1.Text, TextBox2.Text, Bd1.Usuario)
            Me.Hide()
            principal.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        usuarios.Show()
    End Sub
End Class