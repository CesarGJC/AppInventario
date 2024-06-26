Public Class Cliente
    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        Try
            Dim ObjCli As New CmpInventario.Cliente
            ObjCli.BuscarCliente(txtBuscarCliente.Text, Bd1.Clientes)
        Catch ex As Exception

        End Try
    End Sub
End Class