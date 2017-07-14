<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_Factura))
        Me.Sp_consulta_Productos_FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Sp_consultaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Sp_consulta_Productos_FacturaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_Productos_FacturaTableAdapter
        Me.Sp_consultaClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaFacturaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaFacturaTableAdapter
        Me.Sp_consultaIVATableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaIVATableAdapter
        Me.Sp_consultaObsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaObsTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaObsTableAdapter
        CType(Me.Sp_consulta_Productos_FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaObsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sp_consulta_Productos_FacturaBindingSource
        '
        Me.Sp_consulta_Productos_FacturaBindingSource.DataMember = "sp_consulta_Productos_Factura"
        Me.Sp_consulta_Productos_FacturaBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_consultaClienteBindingSource
        '
        Me.Sp_consultaClienteBindingSource.DataMember = "sp_consultaCliente"
        Me.Sp_consultaClienteBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaFacturaBindingSource
        '
        Me.Sp_consultaFacturaBindingSource.DataMember = "sp_consultaFactura"
        Me.Sp_consultaFacturaBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaIVABindingSource
        '
        Me.Sp_consultaIVABindingSource.DataMember = "sp_consultaIVA"
        Me.Sp_consultaIVABindingSource.DataSource = Me.MELDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MELDataSet_sp_consulta_Productos_Factura"
        ReportDataSource1.Value = Me.Sp_consulta_Productos_FacturaBindingSource
        ReportDataSource2.Name = "MELDataSet_sp_consultaCliente"
        ReportDataSource2.Value = Me.Sp_consultaClienteBindingSource
        ReportDataSource3.Name = "MELDataSet_sp_consultaFactura"
        ReportDataSource3.Value = Me.Sp_consultaFacturaBindingSource
        ReportDataSource4.Name = "MELDataSet_sp_consultaIVA"
        ReportDataSource4.Value = Me.Sp_consultaIVABindingSource
        ReportDataSource5.Name = "MELDataSet_sp_consultaObs"
        ReportDataSource5.Value = Me.Sp_consultaObsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Factura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(846, 631)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sp_consulta_Productos_FacturaTableAdapter
        '
        Me.Sp_consulta_Productos_FacturaTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaClienteTableAdapter
        '
        Me.Sp_consultaClienteTableAdapter.ClearBeforeFill = True
        '
        'MELDataSetBindingSource
        '
        Me.MELDataSetBindingSource.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource.Position = 0
        '
        'Sp_consultaFacturaTableAdapter
        '
        Me.Sp_consultaFacturaTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaIVATableAdapter
        '
        Me.Sp_consultaIVATableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaObsBindingSource
        '
        Me.Sp_consultaObsBindingSource.DataMember = "sp_consultaObs"
        Me.Sp_consultaObsBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaObsTableAdapter
        '
        Me.Sp_consultaObsTableAdapter.ClearBeforeFill = True
        '
        'R_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 631)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-4, 129)
        Me.Name = "R_Factura"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        CType(Me.Sp_consulta_Productos_FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaObsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sp_consulta_Productos_FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consulta_Productos_FacturaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_Productos_FacturaTableAdapter
    Friend WithEvents Sp_consultaClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaFacturaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaFacturaTableAdapter
    Friend WithEvents Sp_consultaIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaIVATableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaIVATableAdapter
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_consultaObsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaObsTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaObsTableAdapter
End Class
