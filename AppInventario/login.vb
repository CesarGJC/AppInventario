Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbinventarioDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        'Me.UsuarioTableAdapter.Fill(Me.DbinventarioDataSet.Usuario)
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        'If CmpInventario.BD.(CmpInventario.BD.UsuarioDataTable, TextBox1.Text, TextBox2.Text) Then
        '    Me.Hide()
        '    principal.Show()
        'Else
        '    MsgBox("usuario o contraseña no existe", vbOKOnly + vbInformation, "error")

        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        usuarios.Show()
    End Sub
End Class