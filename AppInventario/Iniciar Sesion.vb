Imports System.Data.SqlClient
Public Class iniciosesion
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsuario.Text = ""
        txtPassword.Text = ""

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click

        ' Obtener los valores ingresados por el usuario
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtPassword.Text

        ' Verificar si los campos están vacíos
        If String.IsNullOrWhiteSpace(usuario) OrElse String.IsNullOrWhiteSpace(contrasena) Then
            MessageBox.Show("Por favor, ingrese un usuario y una contraseña.")
            Return
        End If

        ' Cadena de conexión a tu base de datos
        Dim connectionString As String = "Data Source=CESARGJC-LAP;Initial Catalog=BDinventario;Integrated Security=True"

        ' Consulta SQL para verificar el usuario y la contraseña
        Dim query As String = "SELECT Rol FROM [dbo].[Usuario] WHERE [Usuario] = @Usuario AND [Contrasena] = @Contrasena"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Pasar los parámetros a la consulta
                command.Parameters.AddWithValue("@Usuario", usuario)
                command.Parameters.AddWithValue("@Contrasena", contrasena)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    ' Verificar si el resultado no es nulo (usuario encontrado)
                    If result IsNot Nothing Then
                        ' Aquí podrías verificar el valor de "Rol" y proceder según el rol del usuario
                        Dim rol As Byte = CType(result, Byte)
                        Menú.Show()
                        Me.Dispose()
                    Else
                        MessageBox.Show("Usuario o contraseña incorrectos.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        usuarios.Show()
    End Sub
End Class