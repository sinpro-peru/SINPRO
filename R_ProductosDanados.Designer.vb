<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_ProductosDanados
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_ProductosDanados))
        Me.Sp_consultaProductosDanadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Sp_consultaLogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Sp_consultaProductosDanadosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosDanadosTableAdapter
        Me.Sp_consultaLogoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
        CType(Me.Sp_consultaProductosDanadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sp_consultaProductosDanadosBindingSource
        '
        Me.Sp_consultaProductosDanadosBindingSource.DataMember = "sp_consultaProductosDanados"
        Me.Sp_consultaProductosDanadosBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_consultaLogoBindingSource
        '
        Me.Sp_consultaLogoBindingSource.DataMember = "sp_consultaLogo"
        Me.Sp_consultaLogoBindingSource.DataSource = Me.MELDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MELDataSet_sp_consultaLogo"
        ReportDataSource1.Value = Me.Sp_consultaLogoBindingSource
        ReportDataSource2.Name = "MELDataSet_sp_consultaProductosDanados"
        ReportDataSource2.Value = Me.Sp_consultaProductosDanadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.R_Productos_Danados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(696, 458)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sp_consultaProductosDanadosTableAdapter
        '
        Me.Sp_consultaProductosDanadosTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaLogoTableAdapter
        '
        Me.Sp_consultaLogoTableAdapter.ClearBeforeFill = True
        '
        'R_ProductosDanados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 458)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "R_ProductosDanados"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de productos devueltos por daños"
        CType(Me.Sp_consultaProductosDanadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaProductosDanadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaProductosDanadosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaProductosDanadosTableAdapter
    Friend WithEvents Sp_consultaLogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaLogoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
End Class
