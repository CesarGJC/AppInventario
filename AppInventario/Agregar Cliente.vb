Public Class NuevoCliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ObjCli As New CmpInventario.Cliente
            If ValidarFrm() Then
                ObjCli.AgregarCliente(txtCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                MsgBox("Cliente Registrado Correctamente")
                Me.Dispose()
            End If

        Catch ex As Exception
            MsgBox("Por favor completar los datos faltantes " & ex.Message)
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