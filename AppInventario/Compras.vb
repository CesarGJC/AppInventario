Imports System.Data.SqlClient
Public Class Compras
    Public ProductoID As Integer
    Public Nombre As String
    Public Proveedor As String
    Public Cantidad As Integer

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnRealizarCompra.Click
        Try
            Cantidad = txtCantidad.Text
            Dim ObjComp1 As New CmpInventario.Inventario
            ObjComp1.AgregarCompras(dtpFecha.Value, ProductoID, txtCantidad.Text, txtPrecioCompra.Text, txtTotalCompra.Text)
            MsgBox("Compra Registrado Correctamente", vbOKOnly, "Compras")
            Dim connectionString As String = "Data Source=CESARGJC-LAP;Initial Catalog=BDinventario;Integrated Security=True" ' Define tu cadena de conexión
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "
            DECLARE @ProductoID int = @ProductoIDParam;
            DECLARE @Cantidad int = @CantidadParam;
            DECLARE @UltimaActualizacion datetime = GETDATE();

            IF EXISTS (SELECT 1 FROM Inventario WHERE ProductoID = @ProductoID)
            BEGIN
                UPDATE Inventario
                SET Cantidad = Cantidad + @Cantidad, UltimaActualizacion = @UltimaActualizacion
                WHERE ProductoID = @ProductoID;
            END
            ELSE
            BEGIN
                INSERT INTO Inventario (ProductoID, Cantidad, UltimaActualizacion)
                VALUES (@ProductoID, @Cantidad, @UltimaActualizacion);
            END
        "

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductoIDParam", ProductoID)
                    command.Parameters.AddWithValue("@CantidadParam", Cantidad)

                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Datos vacios " & ex.Message)
        End Try
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjComp As New CmpInventario.Inventario
            ObjComp.CargarCompras(Bd1.ComprasTable)
            Dim ObjPro As New CmpInventario.Producto
            ObjPro.CargarProductos1(Bd1.Productos)
            dtpFecha.Value = Now
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCompra.TextChanged
        txtTotalCompra.Text = txtCantidad.Text * txtPrecioCompra.Text
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim ObjComp As New CmpInventario.Inventario
            ObjComp.CargarCompras(Bd1.ComprasTable)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSeleccionarProducto_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProducto.Click
        Try
            txtProveedor.Clear()
            txtProducto.Clear()
            Seleccionar_Producto.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Compras_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            txtProveedor.Text = Proveedor
            txtProducto.Text = Nombre
        Catch ex As Exception

        End Try
    End Sub


End Class