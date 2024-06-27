Public Class Cliente
    Public Sub BuscarCliente(cli As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.BuscarCliente(ds, cli)
    End Sub
    Public Sub AgregarCliente(ci As String, nombre As String, ape As String, tel As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.AgregarCliente(ci, nombre, ape, tel)
    End Sub

    Public Sub EditarCliente(ci As String, nombre As String, ape As String, tel As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.EditarCliente(ci, nombre, ape, tel)

    End Sub
End Class
