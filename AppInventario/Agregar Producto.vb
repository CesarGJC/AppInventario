Public Class nuevoProducto

    Private Sub nuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarCategoria(Bd1.Categorias)
            Dim objPro1 As New CmpInventario.Producto
            objPro1.CargarProveedor(Bd1.Proveedores)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bntGuardar.Click
        Dim Categoria As Integer = cbCategoria.SelectedValue
        Dim Proveedor As Integer = cbProveedor.SelectedValue
        Dim objPro As New CmpInventario.Producto
        Try
            objPro.AgregarProducto(txtNombre.Text, txtDescripcion.Text, Decimal.Parse(txtPrecio.Text), txtMarca.Text, Categoria, Proveedor)
            MsgBox("Producto Registrado Correctamente")
            Dispose()

        Catch ex As Exception
            MsgBox("Datos vacios " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class