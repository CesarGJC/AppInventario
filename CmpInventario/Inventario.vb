Public Class Inventario
    Public Sub AgregarInventario(ProductoID As Integer, Cantidad As Integer, Date1 As String)
        Dim adap As New BDTableAdapters.InventarioTableAdapter
        adap.AgregarInventario(ProductoID, Cantidad, Date1)
    End Sub
End Class
