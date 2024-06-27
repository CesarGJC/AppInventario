Public Class Cliente
    Public Sub BuscarCliente(cli As String, ds As BD.ClientesDataTable)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.BuscarCliente(ds, cli)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub AgregarCliente(ci As String, nombre As String, ape As String, tel As String, ds As BD.ClientesDataTable)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.AgregarCliente(ci, nombre, ape, tel)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub EditarCliente(ci As String, nombre As String, ape As String, tel As String, ds As BD.ClientesDataTable)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.EditarCliente(ci, nombre, ape, tel)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub EliminarCliente(ci As String)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.EliminarCliente(ci)
        Catch ex As Exception

        End Try

    End Sub
End Class
