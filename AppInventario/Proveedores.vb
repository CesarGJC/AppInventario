Public Class Proveedores
    Dim ProveedorID1 As Integer
    Dim Nombre1 As String
    Dim Direccion1 As String
    Dim Telefono1 As String
    Dim Email1 As String
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjPro As New CmpInventario.Proveedor
            ObjPro.CargarProveedores(Bd1.Proveedores)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProveedor.TextChanged
        Try
            Dim ObjPro As New CmpInventario.Proveedor
            ObjPro.ConsultarProveedor(txtBuscarProveedor.Text, Bd1.Proveedores)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim ObjPro As New CmpInventario.Proveedor
            ObjPro.CargarProveedores(Bd1.Proveedores)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim ProveedorID As String
        ProveedorID = dgvProveedores.Item("ProveedorID", dgvProveedores.CurrentRow.Index).Value
        Dim ObjPro As New CmpInventario.Proveedor
        Try
            Try
                If MsgBox("Desea Eliminar Proveedor?", vbYesNo, "ELiminar Proveedor") = MsgBoxResult.Yes Then
                    ObjPro.EliminarProveedor(ProveedorID)
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
            NuevoProveedor.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Dim f As New EditarProveedor
        ProveedorID1 = dgvProveedores.Item("ProveedorID", dgvProveedores.CurrentRow.Index).Value
        Nombre1 = dgvProveedores.Item("NombreDataGridViewTextBoxColumn", dgvProveedores.CurrentRow.Index).Value
        Direccion1 = dgvProveedores.Item("DireccionDataGridViewTextBoxColumn", dgvProveedores.CurrentRow.Index).Value
        Telefono1 = dgvProveedores.Item("TelefonoDataGridViewTextBoxColumn", dgvProveedores.CurrentRow.Index).Value
        Email1 = dgvProveedores.Item("EmailDataGridViewTextBoxColumn", dgvProveedores.CurrentRow.Index).Value
        Try
            f.ProveedorID = ProveedorID1
            f.Nombre = Nombre1
            f.Direccion = Direccion1
            f.Telefono = Telefono1
            f.Email = Email1
            f.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteProveedores.ShowDialog()
    End Sub
End Class