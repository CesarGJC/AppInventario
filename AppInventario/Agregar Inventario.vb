Public Class NuevoInventario
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        nuevoProducto.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Producto As Integer = cbProducto.SelectedValue
        Try
            Dim ObjInv As New CmpInventario.Inventario
            ObjInv.AgregarInventario(Producto, txtCantidad.Text, dtpFecha.Value)
            MsgBox("Inventario Registrado Correctamente")
            Dispose()
        Catch ex As Exception
            MsgBox("Datos vacios " & ex.Message)
        End Try
    End Sub

    Private Sub NuevoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Value = Now
        Try
        Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
        Catch ex As Exception

        End Try
    End Sub
End Class