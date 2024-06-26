Public Class Cliente
    Public Sub BuscarCliente(cli As String, ds As BD.ClientesDataTable)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.BuscarCliente(ds, cli)
    End Sub

End Class
