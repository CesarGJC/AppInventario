Public Class ReporteCompra
    Private Sub ReporteCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDinventarioDataSet.ComprasTA' Puede moverla o quitarla según sea necesario.
        Me.ComprasTATableAdapter.Fill(Me.BDinventarioDataSet.ComprasTA)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class