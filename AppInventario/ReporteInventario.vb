Public Class ReporteInventario
    Private Sub ReporteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDinventarioDataSet.InventarioTA' Puede moverla o quitarla según sea necesario.
        Me.InventarioTATableAdapter.X(Me.BDinventarioDataSet.InventarioTA)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class