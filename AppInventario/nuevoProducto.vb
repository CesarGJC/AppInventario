Public Class nuevoProducto

    Public opcion As String
    Public nombre As String
    Private Sub nuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objPro As New CmpInventario.Producto

        If opcion = "CREAR" Then
            If objPro.Crear(txtNombre.Text, txtPrecio.Text, txtCat.Text) Then
                MsgBox("Producto Registrado Correctamente")
                Close()
            Else
                MsgBox("Error al guardar Producto!")

            End If
        Else
            objPro.Editar(txtNombre.Text, txtPrecio.Text, txtCat.Text)
            MsgBox("Se ha editado los datos del Producto correctamente")
        End If
    End Sub
End Class