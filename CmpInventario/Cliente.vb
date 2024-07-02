Public Class Cliente
    Public Sub BuscarCliente(cli As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.BuscarClienteX(ds, cli)
    End Sub
    Public Sub AgregarCliente(ci As String, nombre As String, ape As String, direccion As String, tel As String, email As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.Insert(ci, nombre, ape, direccion, tel, email)
    End Sub

    Public Sub EditarCliente(ci As String, nombre As String, ape As String, direccion As String, tel As String, email As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.EditarCliente(ci, nombre, ape, direccion, tel, email)
    End Sub

    Public Sub CargarCliente(cliente As BD.ClientesDataTable)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.Fill(cliente)
        Catch ex As Exception

        End Try
    End Sub
End Class
