Public Class Cliente
    Public Sub BuscarCliente(cli As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.BuscarClienteX(ds, cli)
    End Sub
    Public Sub AgregarCliente(ci As String, nombre As String, ape As String, direccion As String, tel As String, email As String)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.Insert(ci, nombre, ape, direccion, tel, email)
    End Sub
    Public Sub EliminarCliente(Cli As String)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.EliminarCliente(Cli)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub EditarCliente(ci As String, nombre As String, ape As String, direccion As String, tel As String, email As String)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.EditarCliente(nombre, ape, direccion, tel, email, ci)
    End Sub
    Public Sub CargarCliente(cliente As BD.ClientesDataTable)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.Fill(cliente)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Login(Usuario As String, contrasena As String, ds As BD.UsuarioDataTable)
        Dim adap As New BDTableAdapters.UsuarioTableAdapter
        adap.login(ds, Usuario, contrasena)
    End Sub
End Class
