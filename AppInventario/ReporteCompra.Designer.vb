﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCompra
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteCompra))
        Me.ComprasTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDinventarioDataSet = New AppInventario.BDinventarioDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComprasTATableAdapter = New AppInventario.BDinventarioDataSetTableAdapters.ComprasTATableAdapter()
        CType(Me.ComprasTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComprasTABindingSource
        '
        Me.ComprasTABindingSource.DataMember = "ComprasTA"
        Me.ComprasTABindingSource.DataSource = Me.BDinventarioDataSet
        '
        'BDinventarioDataSet
        '
        Me.BDinventarioDataSet.DataSetName = "BDinventarioDataSet"
        Me.BDinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ComprasTABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AppInventario.ReporteCompra.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 342)
        Me.ReportViewer1.TabIndex = 0
        '
        'ComprasTATableAdapter
        '
        Me.ComprasTATableAdapter.ClearBeforeFill = True
        '
        'ReporteCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 342)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteCompra"
        CType(Me.ComprasTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComprasTABindingSource As BindingSource
    Friend WithEvents BDinventarioDataSet As BDinventarioDataSet
    Friend WithEvents ComprasTATableAdapter As BDinventarioDataSetTableAdapters.ComprasTATableAdapter
End Class
