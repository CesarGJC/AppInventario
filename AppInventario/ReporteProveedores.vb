Public Class ReporteProveedores
    Private Sub ReporteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDinventarioDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BDinventarioDataSet.Proveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class