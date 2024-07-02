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
    Public Sub ConsultarXCategoria(Categoria As String, ds As BD.ProductosDataTable)
        Try
            Dim adap As New BDTableAdapters.ProductosTableAdapter
            adap.ConsultarXCategoria(ds, Categoria)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ConsultarProducto(producto As String, ds As BD.ProductosDataTable)
        Try
            Dim adap As New BDTableAdapters.ProductosTableAdapter
            adap.ConsultarProducto(ds, producto)
        Catch ex As Exception

        End Try
    End Sub

    Public Function AgregarProducto(nombre As String, descripcion As String, precioC As Decimal, CategoriaID As Integer, Proveedor As Integer)
        Try
            Dim Adap As New BDTableAdapters.ProductosTableAdapter

            Adap.AgregarProducto(nombre, descripcion, precioC, CategoriaID, Proveedor)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Public Sub Editar(nombre As String, precioC As String, Categoria As String)
    '    Try
    '        Dim adap As New BDTableAdapters.TProductoTableAdapter
    '        adap.EditarProducto(nombre, precioC, Categoria)
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Public Sub EliminarProducto(ProductoID As String)
        Try
            Dim adap As New BDTableAdapters.ProductosTableAdapter
            adap.EliminarProducto(ProductoID)
        Catch ex As Exception

        End Try
    End Sub
    'esto es de prueba
    'esto es una prueba x2
End Class
