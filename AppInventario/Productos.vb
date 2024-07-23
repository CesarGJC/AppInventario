Public Class Productos
    Dim ProductoID1 As Integer
    Dim Nombre As String
    Dim Precio As Decimal
    Dim Descripcion As String
    Dim Marca1 As String

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
            Dim ObjPro1 As New CmpInventario.Producto
            ObjPro1.CargarCategoria(Bd1.Categorias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.ConsultarProducto(txtBuscarProducto.Text, Bd1.ProductoTA)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            nuevoProducto.ShowDialog()
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
    Public Sub Recargarfrm()
        Dim objPro As New CmpInventario.Producto
        objPro.CargarProducto(Bd1.ProductoTA)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim objPro As New CmpInventario.Producto
        objPro.CargarProducto(Bd1.ProductoTA)
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Dim f As New EditarProducto
        ProductoID1 = dgvProducto.Item("ProductoID", dgvProducto.CurrentRow.Index).Value
        Nombre = dgvProducto.Item("DataGridViewTextBoxColumn1", dgvProducto.CurrentRow.Index).Value
        Precio = dgvProducto.Item("PrecioDataGridViewTextBoxColumn", dgvProducto.CurrentRow.Index).Value
        Descripcion = dgvProducto.Item("DescripcionDataGridViewTextBoxColumn", dgvProducto.CurrentRow.Index).Value
        Marca1 = dgvProducto.Item("Marca", dgvProducto.CurrentRow.Index).Value
        Try
            f.ProductoID1 = ProductoID1
            f.Nombre = Nombre
            f.Precio = Precio
            f.Descripcion = Descripcion
            f.Marca = Marca1
            f.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged

    End Sub
End Class