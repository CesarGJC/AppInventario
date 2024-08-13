Public Class ReporteProducto
    Private Sub ReporteProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProductosTATableAdapter.Fill(Me.BDinventarioDataSet.ProductosTA)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class