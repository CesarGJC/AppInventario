﻿Public Class Producto
    Dim ProductoID1 As Integer
    Dim Nombre As String
    Dim Precio As Decimal
    Dim Descripcion As String

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarProducto(Bd1.ProductoTA)
            Dim ObjPro1 As New CmpInventario.Producto
            ObjPro1.CargarCategoria(Bd1.Categorias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.ConsultarProducto(txtBuscarCliente.Text, Bd1.ProductoTA)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            nuevoProducto.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim ObjPro As New CmpInventario.Producto
        Dim ProductoID
        ProductoID = dgvProducto.Item("ProductoID", dgvProducto.CurrentRow.Index).Value
        Try
            If MsgBox("Desea Eliminar Producto", vbYesNo, "ELiminar Producto") = MsgBoxResult.Yes Then
                ObjPro.EliminarProducto(ProductoID)
                MsgBox("Eliminado Correctamente")
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error: " & ex.Message)
        End Try
    End Sub
    Private Sub cbCategoria_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedValueChanged
        Try
            Dim Categoria = cbCategoria.SelectedValue
            Dim ObjPro As New CmpInventario.Producto
            ObjPro.ConsultarPorCategoria(Categoria, Bd1.ProductoTA)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Recargarfrm()
        Dim objPro As New CmpInventario.Producto
        objPro.CargarProducto(Bd1.ProductoTA)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objPro As New CmpInventario.Producto
        objPro.CargarProducto(Bd1.ProductoTA)
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Dim f As New EditarProducto
        ProductoID1 = dgvProducto.Item("ProductoID", dgvProducto.CurrentRow.Index).Value
        Nombre = dgvProducto.Item("DataGridViewTextBoxColumn1", dgvProducto.CurrentRow.Index).Value
        Precio = dgvProducto.Item("PrecioDataGridViewTextBoxColumn", dgvProducto.CurrentRow.Index).Value
        Descripcion = dgvProducto.Item("DescripcionDataGridViewTextBoxColumn", dgvProducto.CurrentRow.Index).Value
        Try
            f.ProductoID1 = ProductoID1
            f.Nombre = Nombre
            f.Precio = Precio
            f.Descripcion = Descripcion
            f.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
End Class