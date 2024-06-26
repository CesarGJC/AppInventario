Public Class Producto
    Public Sub CargarCategoria(Producto As BD.TProductoDataTable)
        Try
            Dim adap As New BDTableAdapters.TProductoTableAdapter
            adap.Fill(Producto)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ConsultarXCategoria(Categoria As String, ds As BD.TProductoDataTable)
        Try
            Dim adap As New BDTableAdapters.TProductoTableAdapter
            adap.ConsultarXCategoria(ds, Categoria)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ConsultarProducto(producto As String, ds As BD.TProductoDataTable)
        Try
            Dim adap As New BDTableAdapters.TProductoTableAdapter
            adap.ConsultarProducto(ds, producto)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Crear(nombre As String, precioC As String, Categoria As String)
        Try
            Dim Adap As New BDTableAdapters.TProductoTableAdapter

            Adap.InsertQuery(nombre, precioC, Categoria)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub Editar(nombre As String, precioC As String, Categoria As String)
        Try
            Dim adap As New BDTableAdapters.TProductoTableAdapter
            adap.Editar(nombre, precioC, Categoria)
        Catch ex As Exception

        End Try
    End Sub
    'esto es de prueba
End Class
