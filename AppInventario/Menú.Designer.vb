<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menú
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menú))
        Me.Panelcabera = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tmocultarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panelcabera.SuspendLayout()
        Me.Panelmenu.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelcabera
        '
        Me.Panelcabera.BackColor = System.Drawing.Color.Red
        Me.Panelcabera.Controls.Add(Me.btnRestaurar)
        Me.Panelcabera.Controls.Add(Me.btnMinimizar)
        Me.Panelcabera.Controls.Add(Me.btnMaximizar)
        Me.Panelcabera.Controls.Add(Me.btnCerrar)
        Me.Panelcabera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelcabera.Location = New System.Drawing.Point(0, 0)
        Me.Panelcabera.Margin = New System.Windows.Forms.Padding(2)
        Me.Panelcabera.Name = "Panelcabera"
        Me.Panelcabera.Size = New System.Drawing.Size(862, 32)
        Me.Panelcabera.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(806, 0)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(31, 32)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(778, 0)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 32)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(806, 0)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 32)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(832, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 32)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panelmenu.Controls.Add(Me.Panel16)
        Me.Panelmenu.Controls.Add(Me.Panel12)
        Me.Panelmenu.Controls.Add(Me.btnInventario)
        Me.Panelmenu.Controls.Add(Me.btnCompra)
        Me.Panelmenu.Controls.Add(Me.Panel4)
        Me.Panelmenu.Controls.Add(Me.Panel9)
        Me.Panelmenu.Controls.Add(Me.btnUsuario)
        Me.Panelmenu.Controls.Add(Me.Panel7)
        Me.Panelmenu.Controls.Add(Me.btnProveedores)
        Me.Panelmenu.Controls.Add(Me.Panel5)
        Me.Panelmenu.Controls.Add(Me.btnCliente)
        Me.Panelmenu.Controls.Add(Me.Panel1)
        Me.Panelmenu.Controls.Add(Me.btnReporte)
        Me.Panelmenu.Controls.Add(Me.btnProducto)
        Me.Panelmenu.Controls.Add(Me.PictureBox1)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 32)
        Me.Panelmenu.Margin = New System.Windows.Forms.Padding(2)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(165, 496)
        Me.Panelmenu.TabIndex = 1
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Red
        Me.Panel16.Location = New System.Drawing.Point(0, 188)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(4, 41)
        Me.Panel16.TabIndex = 7
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Red
        Me.Panel12.Location = New System.Drawing.Point(0, 229)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(4, 41)
        Me.Panel12.TabIndex = 6
        '
        'btnInventario
        '
        Me.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Image = CType(resources.GetObject("btnInventario.Image"), System.Drawing.Image)
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.Location = New System.Drawing.Point(8, 188)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(165, 41)
        Me.btnInventario.TabIndex = 9
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnCompra
        '
        Me.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompra.FlatAppearance.BorderSize = 0
        Me.btnCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompra.ForeColor = System.Drawing.Color.White
        Me.btnCompra.Image = CType(resources.GetObject("btnCompra.Image"), System.Drawing.Image)
        Me.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompra.Location = New System.Drawing.Point(11, 274)
        Me.btnCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(165, 41)
        Me.btnCompra.TabIndex = 6
        Me.btnCompra.Text = "Compra"
        Me.btnCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(0, 274)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 41)
        Me.Panel4.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Red
        Me.Panel9.Location = New System.Drawing.Point(0, 398)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(4, 41)
        Me.Panel9.TabIndex = 6
        Me.Panel9.Visible = False
        '
        'btnUsuario
        '
        Me.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.White
        Me.btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), System.Drawing.Image)
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.Location = New System.Drawing.Point(2, 398)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(165, 41)
        Me.btnUsuario.TabIndex = 8
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuario.UseVisualStyleBackColor = True
        Me.btnUsuario.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Red
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(0, 101)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(4, 41)
        Me.Panel7.TabIndex = 7
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Red
        Me.Panel8.Location = New System.Drawing.Point(0, 38)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(4, 41)
        Me.Panel8.TabIndex = 5
        '
        'btnProveedores
        '
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(2, 229)
        Me.btnProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(161, 41)
        Me.btnProveedores.TabIndex = 10
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(0, 146)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 41)
        Me.Panel5.TabIndex = 6
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Red
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Location = New System.Drawing.Point(0, 36)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(4, 41)
        Me.Panel10.TabIndex = 8
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Red
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(4, 41)
        Me.Panel11.TabIndex = 7
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Red
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Location = New System.Drawing.Point(0, 4)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(4, 41)
        Me.Panel13.TabIndex = 7
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Red
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(4, 41)
        Me.Panel15.TabIndex = 7
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Red
        Me.Panel14.Location = New System.Drawing.Point(0, 2)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(4, 41)
        Me.Panel14.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Red
        Me.Panel6.Location = New System.Drawing.Point(0, 38)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(4, 41)
        Me.Panel6.TabIndex = 5
        '
        'btnCliente
        '
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.ForeColor = System.Drawing.Color.White
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCliente.Location = New System.Drawing.Point(2, 101)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(165, 41)
        Me.btnCliente.TabIndex = 5
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, 353)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 41)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 41)
        Me.Panel3.TabIndex = 5
        '
        'btnReporte
        '
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.White
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(2, 353)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(165, 41)
        Me.btnReporte.TabIndex = 3
        Me.btnReporte.Text = "Reportes"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducto.FlatAppearance.BorderSize = 0
        Me.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducto.ForeColor = System.Drawing.Color.White
        Me.btnProducto.Image = CType(resources.GetObject("btnProducto.Image"), System.Drawing.Image)
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.Location = New System.Drawing.Point(2, 146)
        Me.btnProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(165, 41)
        Me.btnProducto.TabIndex = 3
        Me.btnProducto.Text = "Productos"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.Panel2)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(165, 32)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(697, 496)
        Me.PanelContenedor.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(697, 496)
        Me.Panel2.TabIndex = 4
        '
        'tmocultarmenu
        '
        '
        'tmMostrarmenu
        '
        '
        'Menú
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 528)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.Panelcabera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menú"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.Panelcabera.ResumeLayout(False)
        Me.Panelmenu.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelcabera As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents tmocultarmenu As Timer
    Friend WithEvents tmMostrarmenu As Timer
    Friend WithEvents btnProducto As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCompra As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnReporte As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel14 As Panel
End Class
