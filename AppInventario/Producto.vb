Public Class Producto
    Public Sub ActualizarDGV()
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
            Dim ObjPro1 As New CmpInventario.Producto
            ObjPro1.CargarCategoria(Bd1.Categorias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.ConsultarProducto(txtBuscarCliente.Text, Bd1.ProductoTA)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            nuevoProducto.Show()
            ActualizarDGV()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim ObjPro As New CmpInventario.Producto
        Dim ProductoID
        ProductoID = dgvProducto.Item("ProductoID", dgvProducto.CurrentRow.Index).Value
        Try
            If MsgBox("Desea Eliminar Producto", vbYesNo, "ELiminar Producto") = MsgBoxResult.Yes Then
                ObjPro.EliminarProducto(ProductoID)
                MsgBox("Eliminado Correctamente")
                ActualizarDGV()
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error: " & ex.Message)
        End Try

    End Sub
    Private Sub cbCategoria_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedValueChanged
        Try
            Dim Categoria = cbCategoria.SelectedValue
            Dim ObjPro As New CmpInventario.Producto
            ObjPro.ConsultarPorCategoria(Categoria, Bd1.ProductoTA)
        Catch ex As Exception

        End Try
    End Sub
End Class