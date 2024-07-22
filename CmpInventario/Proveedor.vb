Public Class Proveedor
    Public Sub CargarProveedores(proveedor As BD.ProveedoresDataTable)
        Dim adap As New BDTableAdapters.ProveedoresTableAdapter
        adap.Fill(proveedor)
    End Sub
    Public Sub AgregarProveedor(Nombre As String, Direccion As String, Telefono As String, Email As String)
        Dim adap As New BDTableAdapters.ProveedoresTableAdapter
        adap.AgregarProveedor(Nombre, Direccion, Telefono, Email)
    End Sub
    Public Sub ConsultarProveedor(Proveedor As String, ds As BD.ProveedoresDataTable)
        Dim adap As New BDTableAdapters.ProveedoresTableAdapter
        adap.BuscarProveedor(ds, Proveedor)
    End Sub
    Public Sub EditarProveedor(ProvedorID As Integer, Nombre As String, Direccion As String, Telefono As String, Email As String)
        Dim adap As New BDTableAdapters.ProveedoresTableAdapter
        adap.EditarProveedor(Nombre, Direccion, Telefono, Email, ProvedorID)
    End Sub
    Public Sub EliminarProveedor(ProveedorID As String)
        Dim adap As New BDTableAdapters.ProveedoresTableAdapter
        adap.EliminarProveedor(ProveedorID)
    End Sub
End Class
