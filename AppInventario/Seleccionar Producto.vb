Public Class Seleccionar_Producto
    Dim ProductoID1 As Integer
    Dim Nombre As String
    Dim Proveedor1 As String

    Private Sub Seleccionar_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
            Dim ObjPro1 As New CmpInventario.Producto
            ObjPro1.CargarCategoria(Bd1.Categorias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.ConsultarProducto(txtBuscarProducto.Text, Bd1.ProductoTA)
        Catch ex As Exception

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
    Public Sub MostrarProducto(f As Compras)
        Try
            f.ProductoID = ProductoID1
            f.Proveedor = Proveedor1
            f.Nombre = Nombre
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvProducto_DoubleClick(sender As Object, e As EventArgs) Handles dgvProducto.DoubleClick
        Try
            ProductoID1 = dgvProducto.Item("ProductoID", dgvProducto.CurrentRow.Index).Value
            Proveedor1 = dgvProducto.Item("Proveedor", dgvProducto.CurrentRow.Index).Value
            Nombre = dgvProducto.Item("NombreDataGridViewTextBoxColumn", dgvProducto.CurrentRow.Index).Value
            MostrarProducto(Compras)
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Seleccionar_Producto_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
        Catch ex As Exception

        End Try
    End Sub
End Class