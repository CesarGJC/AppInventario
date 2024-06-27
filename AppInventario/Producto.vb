Public Class Producto
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarCategoria(Bd1.Categorias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        Dim objPro As New CmpInventario.Producto
        objPro.ConsultarProducto(txtBuscarCliente.Text, Bd1.Productos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nuevoProducto.Show()
        Producto_Load(sender, e)
    End Sub

    Private Sub Producto_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Producto_Load(sender, e)
    End Sub
End Class