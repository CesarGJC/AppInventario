Public Class Clientes
    Dim Carnet1 As String
    Dim Nombre1 As String
    Dim Apellido1 As String
    Dim Direccion1 As String
    Dim Telefono1 As String
    Dim Email1 As String

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjCli As New CmpInventario.Cliente
            ObjCli.CargarCliente(Bd1.Clientes)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarCliente_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        Try
            Dim ObjCli As New CmpInventario.Cliente
            ObjCli.BuscarCliente(txtBuscarCliente.Text, Bd1.Clientes)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim Ci As String
        Ci = dgvClientes.Item("CIDataGridViewTextBoxColumn", dgvClientes.CurrentRow.Index).Value
        Dim Objcli As New CmpInventario.Cliente
        Try
            Try
                If MsgBox("Desea Eliminar Cliente?", vbYesNo, "ELiminar Cliente") = MsgBoxResult.Yes Then
                    Objcli.EliminarCliente(Ci)
                    MsgBox("Eliminado Correctamente")
                End If
            Catch ex As Exception
                MsgBox("Ocurrió un error: " & ex.Message)
            End Try


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            NuevoCliente.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim ObjCli As New CmpInventario.Cliente
            ObjCli.CargarCliente(Bd1.Clientes)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Dim f As New EditarCliente
        Carnet1 = dgvClientes.Item("CIDataGridViewTextBoxColumn", dgvClientes.CurrentRow.Index).Value
        Nombre1 = dgvClientes.Item("NombreDataGridViewTextBoxColumn", dgvClientes.CurrentRow.Index).Value
        Apellido1 = dgvClientes.Item("ApellidoDataGridViewTextBoxColumn", dgvClientes.CurrentRow.Index).Value
        Direccion1 = dgvClientes.Item("DireccionDataGridViewTextBoxColumn", dgvClientes.CurrentRow.Index).Value
        Telefono1 = dgvClientes.Item("TelefonoDataGridViewTextBoxColumn", dgvClientes.CurrentRow.Index).Value
        Email1 = dgvClientes.Item("EmailDataGridViewTextBoxColumn", dgvClientes.CurrentRow.Index).Value
        Try
            f.Ci1 = Carnet1
            f.Nombre1 = Nombre1
            f.Apellido1 = Apellido1
            f.Direccion1 = Direccion1
            f.Telefono1 = Telefono1
            f.Email1 = Email1
            f.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Reporte.ShowDialog()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteCliente.ShowDialog()
    End Sub
End Class