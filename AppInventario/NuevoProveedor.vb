Public Class NuevoProveedor
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Function ValidarFrm() As Boolean
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El campo Nombre es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("El campo Telefono es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelefono.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ObjPro As New CmpInventario.Proveedor
            If ValidarFrm() Then
                ObjPro.AgregarProveedor(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                MsgBox("Proveedor Registrado Correctamente")
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Por favor completar los datos faltantes" & ex.Message)
        End Try
    End Sub
End Class