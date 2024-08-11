Public Class ReporteProducto
    Private Sub ReporteProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDinventarioDataSet.ProductosTA' Puede moverla o quitarla según sea necesario.
        Me.ProductosTATableAdapter.Fill(Me.BDinventarioDataSet.ProductosTA)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class