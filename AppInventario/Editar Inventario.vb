Public Class EditarInventario
    Public InventarioID1 As Integer
    Public ProductoID1 As Integer
    Public Nombre As String
    Public Cantidad1 As Integer
    Public UltimaActualizacion1 As String


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub EditarInventario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            txtInventarioID.Text = InventarioID1
            txtNombre.Text = Nombre
            txtCantidad.Text = Cantidad1
            dtpFecha.Value = UltimaActualizacion1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtNombre.Text = Nombre
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Producto As Integer = ProductoID1
            Dim ObjInv As New CmpInventario.Inventario
            ObjInv.EditarInventario(txtInventarioID.Text, Producto, txtCantidad.Text, dtpFecha.Value)
            MsgBox("Inventario Editado Correctamente", vbOKOnly, "Editar Inventario")
            Dispose()
        Catch ex As Exception
            MsgBox("Datos vacios " & ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class