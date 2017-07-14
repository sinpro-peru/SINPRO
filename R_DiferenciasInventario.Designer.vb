<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_DiferenciasInventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Sp_consultaDiferenciasInventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaDiferenciasInventarioTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaDiferenciasInventarioTableAdapter
        Me.Sp_consultaLogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaLogoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaDiferenciasInventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.R_Diferencias_Inv.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(752, 594)
        Me.ReportViewer1.TabIndex = 0
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_consultaDiferenciasInventarioBindingSource
        '
        Me.Sp_consultaDiferenciasInventarioBindingSource.DataMember = "sp_consultaDiferenciasInventario"
        Me.Sp_consultaDiferenciasInventarioBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaDiferenciasInventarioTableAdapter
        '
        Me.Sp_consultaDiferenciasInventarioTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaLogoBindingSource
        '
        Me.Sp_consultaLogoBindingSource.DataMember = "sp_consultaLogo"
        Me.Sp_consultaLogoBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaLogoTableAdapter
        '
        Me.Sp_consultaLogoTableAdapter.ClearBeforeFill = True
        '
        'R_DiferenciasInventario
        '
        ReportDataSource1.Name = "MELDataSet_sp_consultaLogo"
        ReportDataSource1.Value = Me.Sp_consultaLogoBindingSource
        ReportDataSource2.Name = "MELDataSet_sp_consultaDiferenciasInventario"
        ReportDataSource2.Value = Me.Sp_consultaDiferenciasInventarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 594)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "R_DiferenciasInventario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R_DiferenciasInventario"
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaDiferenciasInventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaDiferenciasInventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaDiferenciasInventarioTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaDiferenciasInventarioTableAdapter
    Friend WithEvents Sp_consultaLogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaLogoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
End Class
