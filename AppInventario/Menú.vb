Imports System.Runtime.InteropServices

Public Class Menú
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMenssage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal mparam As Integer, ByVal lparam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panelcabera_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelcabera.MouseMove
        ReleaseCapture()
        SendMenssage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmocultarmenu_Tick(sender As Object, e As EventArgs) Handles tmocultarmenu.Tick
        If Panelmenu.Width <= 60 Then
            Me.tmocultarmenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width - 20

        End If
    End Sub

    Private Sub tmMostrarmenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarmenu.Tick
        If Panelmenu.Width >= 220 Then
            Me.tmMostrarmenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width + 20
        End If
    End Sub


    Private Sub Abrirforenpanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Abrirforenpanel(New Reporte)

    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Abrirforenpanel(New Productos)
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Abrirforenpanel(New Clientes)
    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        Compras.ShowDialog()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Abrirforenpanel(New Inventario)
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Abrirforenpanel(New Proveedores)
    End Sub
End Class