Public Class nuevoProducto

    Private Sub nuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objPro As New CmpInventario.Producto
        Try
            objPro.Crear(txtNombre.Text, txtPrecio.Text, txtCat.Text)
            MsgBox("Producto Registrado Correctamente")
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class