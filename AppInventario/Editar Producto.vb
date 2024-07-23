Public Class EditarProducto
    Public ProductoID1 As Integer
    Public Nombre As String
    Public Precio As Decimal
    Public Descripcion As String
    Public Marca As String

    Private Sub EditarProducto_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            txtID.Text = ProductoID1
            txtNombre.Text = Nombre
            txtPrecio.Text = Precio
            txtDescripcion.Text = Descripcion
            txtMarca.Text = Marca
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim ObjPro As New CmpInventario.Producto
            ObjPro.EditarProducto(txtID.Text, txtNombre.Text, txtPrecio.Text, txtDescripcion.Text, txtMarca.Text)
            MsgBox("Producto Editado Correctamente", vbOKOnly, "Editar Producto")
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class