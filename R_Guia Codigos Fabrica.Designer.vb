<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_Guia_Codigos_Fabrica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_Guia_Codigos_Fabrica))
        Me.sp_consulta_producto_pedido_guiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.sp_consultaPedidoClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_consultaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaLogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sp_consultaPedidoClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaPedidoClienteTableAdapter
        Me.sp_consultaClienteTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
        Me.sp_consulta_producto_pedido_guiaTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_producto_pedido_guiaTableAdapter
        Me.Sp_consultaLogoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
        CType(Me.sp_consulta_producto_pedido_guiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_consultaPedidoClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_consultaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sp_consulta_producto_pedido_guiaBindingSource
        '
        Me.sp_consulta_producto_pedido_guiaBindingSource.DataMember = "sp_consulta_producto_pedido_guia"
        Me.sp_consulta_producto_pedido_guiaBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_consultaPedidoClienteBindingSource
        '
        Me.sp_consultaPedidoClienteBindingSource.DataMember = "sp_consultaPedidoCliente"
        Me.sp_consultaPedidoClienteBindingSource.DataSource = Me.MELDataSet
        '
        'sp_consultaClienteBindingSource
        '
        Me.sp_consultaClienteBindingSource.DataMember = "sp_consultaCliente"
        Me.sp_consultaClienteBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaLogoBindingSource
        '
        Me.Sp_consultaLogoBindingSource.DataMember = "sp_consultaLogo"
        Me.Sp_consultaLogoBindingSource.DataSource = Me.MELDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MELDataSet_sp_consulta_producto_pedido_guia"
        ReportDataSource1.Value = Me.sp_consulta_producto_pedido_guiaBindingSource
        ReportDataSource2.Name = "MELDataSet_sp_consultaPedidoCliente"
        ReportDataSource2.Value = Me.sp_consultaPedidoClienteBindingSource
        ReportDataSource3.Name = "MELDataSet_sp_consultaCliente"
        ReportDataSource3.Value = Me.sp_consultaClienteBindingSource
        ReportDataSource4.Name = "MELDataSet_sp_consultaLogo"
        ReportDataSource4.Value = Me.Sp_consultaLogoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Guia Codigos Fabrica.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(721, 549)
        Me.ReportViewer1.TabIndex = 0
        '
        'sp_consultaPedidoClienteTableAdapter
        '
        Me.sp_consultaPedidoClienteTableAdapter.ClearBeforeFill = True
        '
        'sp_consultaClienteTableAdapter
        '
        Me.sp_consultaClienteTableAdapter.ClearBeforeFill = True
        '
        'sp_consulta_producto_pedido_guiaTableAdapter
        '
        Me.sp_consulta_producto_pedido_guiaTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaLogoTableAdapter
        '
        Me.Sp_consultaLogoTableAdapter.ClearBeforeFill = True
        '
        'R_Guia_Codigos_Fabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 549)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "R_Guia_Codigos_Fabrica"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos con código fábrica"
        CType(Me.sp_consulta_producto_pedido_guiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_consultaPedidoClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_consultaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents sp_consultaPedidoClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sp_consultaClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sp_consultaPedidoClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaPedidoClienteTableAdapter
    Friend WithEvents sp_consultaClienteTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaClienteTableAdapter
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_consulta_producto_pedido_guiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sp_consulta_producto_pedido_guiaTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consulta_producto_pedido_guiaTableAdapter
    Friend WithEvents Sp_consultaLogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaLogoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
End Class
