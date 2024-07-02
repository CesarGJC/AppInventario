Public Class EditarCliente
    Public Ci1 As String
    Public Nombre1 As String
    Public Apellido1 As String
    Public Direccion1 As String
    Public Telefono1 As String
    Public Email1 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ObjCli As New CmpInventario.Cliente
            If ValidarFrm() Then
                ObjCli.EditarCliente(txtCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                MsgBox("Cliente Editado Correctamente")
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Datos vacios " & ex.Message)
        End Try
    End Sub

    Private Sub EditarCliente_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            txtCi.Text = Ci1
            txtNombre.Text = Nombre1
            txtApellido.Text = Apellido1
            txtDireccion.Text = Direccion1
            txtTelefono.Text = Telefono1
            txtEmail.Text = Email1
        Catch ex As Exception

        End Try
    End Sub
    Private Function ValidarFrm() As Boolean
        If String.IsNullOrWhiteSpace(txtCi.Text) Then
            MessageBox.Show("El campo CI es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCi.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtApellido.Text) Then
            MessageBox.Show("El campo Apellido es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtApellido.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("El campo Telefono es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelefono.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class