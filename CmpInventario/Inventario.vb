﻿Public Class Inventario
    Public Sub AgregarInventario(ProductoID As Integer, Cantidad As Integer, Date1 As String)
        Dim adap As New BDTableAdapters.InventarioTableAdapter
        adap.AgregarInventario(ProductoID, Cantidad, Date1)
    End Sub
    Public Sub CargarInventario(Categoria As BD.InventarioTADataTable)
        Dim adap As New BDTableAdapters.InventarioTATableAdapter
        adap.Fill(Categoria)
    End Sub
    Public Sub EliminarInventario(InvenarioID As Integer)
        Dim adap As New BDTableAdapters.InventarioTableAdapter
        adap.EliminarInventario(InvenarioID)
    End Sub
    Public Sub EditarInventario(InventarioID As Integer, ProductoID As Integer, Cantidad As Integer, Date1 As String)
        Dim adap As New BDTableAdapters.InventarioTableAdapter
        adap.EditarInventario(ProductoID, Cantidad, Date1, InventarioID)
    End Sub
    Public Sub ConsultarPorCategoria(Inventario As String, ds As BD.InventarioTADataTable)
        Dim adap As New BDTableAdapters.InventarioTATableAdapter
        adap.ConsultarPorCategoria(ds, Inventario)
    End Sub
    Public Sub ConsultarInventario(Inventario As String, ds As BD.InventarioTADataTable)
        Dim adap As New BDTableAdapters.InventarioTATableAdapter
        adap.ConsultarInventario(ds, Inventario)
    End Sub
End Class