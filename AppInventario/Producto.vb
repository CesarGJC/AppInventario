﻿Public Class Producto
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objPro As New CmpInventario.Producto
            objPro.CargarCategoria(Bd1.TProducto)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        Dim objPro As New CmpInventario.Producto
        objPro.ConsultarProducto(txtBuscarCliente.Text, Bd1.TProducto)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nuevoProducto.Show()
    End Sub
End Class