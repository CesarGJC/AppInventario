Public Class Producto
    Public Sub CargarProducto(producto As BD.ProductoTADataTable)
        Try
            Dim adap As New BDTableAdapters.ProductoTATableAdapter
            adap.Fill(producto)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub CargarCategoria(categoria As BD.CategoriasDataTable)
        Try
            Dim adap As New BDTableAdapters.CategoriasTableAdapter
            adap.Fill(categoria)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub CargarProveedor(Proveedor As BD.ProveedoresDataTable)
        Try
            Dim adap As New BDTableAdapters.ProveedoresTableAdapter
            adap.Fill(Proveedor)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ConsultarPorCategoria(Categoria As String, ds As BD.ProductoTADataTable)
        Try
            Dim adap As New BDTableAdapters.ProductoTATableAdapter
            adap.ConsultarPorCategoria(ds, Categoria)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ConsultarProducto(producto As String, ds As BD.ProductoTADataTable)
        Try
            Dim adap As New BDTableAdapters.ProductoTATableAdapter
            adap.ConsultarProducto(ds, producto)
        Catch ex As Exception

        End Try
    End Sub

    Public Function AgregarProducto(nombre As String, descripcion As String, precioC As Decimal, Marca As String, CategoriaID As Integer, Proveedor As Integer)
        Try
            Dim Adap As New BDTableAdapters.ProductosTableAdapter

            Adap.AgregarProducto(nombre, descripcion, precioC, Marca, CategoriaID, Proveedor)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub EliminarProducto(ProductoID As String)
        Try
            Dim adap As New BDTableAdapters.ProductosTableAdapter
            adap.EliminarProducto(ProductoID)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub EditarProducto(ProductoID As Integer, Nombre As String, Precio As Decimal, Descripcion As String, Marca As String)
        Try
            Dim adap As New BDTableAdapters.ProductosTableAdapter
            adap.EditarProducto(Nombre, Descripcion, Precio, Marca, ProductoID)
        Catch ex As Exception

        End Try
    End Sub
End Class
