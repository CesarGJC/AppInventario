Public Class EditarProveedor
    Public ProveedorID As Integer
    Public Nombre As String
    Public Direccion As String
    Public Telefono As String
    Public Email As String
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim objPro As New CmpInventario.Proveedor
            objPro.EditarProveedor(txtProveedorID.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
            MsgBox("Proveedor Editado Correctamente", vbOKOnly, "Editar Proveedor")
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try
    End Sub

    Private Sub EditarProveedor_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            txtProveedorID.Text = ProveedorID
            txtNombre.Text = Nombre
            txtDireccion.Text = Direccion
            txtTelefono.Text = Telefono
            txtEmail.Text = Email
        Catch ex As Exception

        End Try
    End Sub
End Class