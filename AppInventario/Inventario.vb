Imports System.Data.SqlClient
Public Class Inventario
    Dim InventarioID1 As Integer
    Dim ProductoId1 As Integer
    Dim Nombre1 As String
    Dim Cantidad1 As Integer
    Dim UltimaActualizacion1 As String
    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            NuevoInventario.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub VerificarInventario()
        Dim connectionString As String = "Data Source=(local);Initial Catalog=BDinventario;Integrated Security=True"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "
            SELECT p.Nombre, i.Cantidad 
            FROM Inventario i
            JOIN Productos p ON i.ProductoID = p.ProductoID
            WHERE i.Cantidad <= 5"

            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        Dim aviso As String = "Producto con poco Stock" & vbCrLf
                        While reader.Read()
                            aviso &= "Producto: " & reader("Nombre").ToString() & " - Cantidad: " & reader("Cantidad").ToString() & vbCrLf
                        End While
                        MessageBox.Show(aviso, "Aviso de Inventario Bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            VerificarInventario()
            Dim ObjInv As New CmpInventario.Inventario
            ObjInv.CargarInventario(Bd1.InventarioTA)
            Dim ObjPro1 As New CmpInventario.Producto
            ObjPro1.CargarCategoria(Bd1.Categorias)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim ObjInv As New CmpInventario.Inventario
            ObjInv.CargarInventario(Bd1.InventarioTA)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim InventarioId As Integer = dgvInventario.Item("InventarioID", dgvInventario.CurrentRow.Index).Value
        Dim ObjInv As New CmpInventario.Inventario
        Try
            If MsgBox("Desea Eliminar Inventario", vbYesNo, "ELiminar Invetario") = MsgBoxResult.Yes Then
                ObjInv.EliminarInventario(InventarioId)
                MsgBox("Eliminado Correctamente")
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Dim f As New EditarInventario
        Dim ObjInv As New CmpInventario.Inventario
        InventarioID1 = dgvInventario.Item("InventarioID", dgvInventario.CurrentRow.Index).Value
        ProductoId1 = dgvInventario.Item("ProductoIDDataGridViewTextBoxColumn", dgvInventario.CurrentRow.Index).Value
        Nombre1 = dgvInventario.Item("NombreDataGridViewTextBoxColumn", dgvInventario.CurrentRow.Index).Value
        Cantidad1 = dgvInventario.Item("Cantidad", dgvInventario.CurrentRow.Index).Value
        UltimaActualizacion1 = dgvInventario.Item("UltimaActualizacion", dgvInventario.CurrentRow.Index).Value
        Try
            f.InventarioID1 = InventarioID1
            f.ProductoID1 = ProductoId1
            f.Nombre = Nombre1
            f.Cantidad1 = Cantidad1
            f.UltimaActualizacion1 = UltimaActualizacion1
            f.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbCategoria_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedValueChanged
        Try
            Dim Categoria = cbCategoria.SelectedValue
            Dim ObjPro As New CmpInventario.Inventario
            ObjPro.ConsultarPorCategoria(Categoria, Bd1.InventarioTA)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscarInventario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarInventario.TextChanged
        Try
            Dim ObjInv As New CmpInventario.Inventario
            ObjInv.ConsultarInventario(txtBuscarInventario.Text, Bd1.InventarioTA)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteInventario.ShowDialog()
    End Sub
End Class