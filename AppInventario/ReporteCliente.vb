Public Class ReporteCliente
    Private Sub ReporteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ClientesTableAdapter.Fill(Me.BDinventarioDataSet.Clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class