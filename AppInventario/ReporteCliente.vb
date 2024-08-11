Public Class ReporteCliente
    Private Sub ReporteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDinventarioDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BDinventarioDataSet.Clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class