<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_NC_Pendientes
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Sp_consultaLogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaLogoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
        Me.Sp_consultaNCPendientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaNCPendientesTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaNCPendientesTableAdapter
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaNCPendientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "MELDataSet_sp_consultaLogo"
        ReportDataSource5.Value = Me.Sp_consultaLogoBindingSource
        ReportDataSource6.Name = "MELDataSet_sp_consultaNCPendientes"
        ReportDataSource6.Value = Me.Sp_consultaNCPendientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.R_NC_Pendientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(696, 458)
        Me.ReportViewer1.TabIndex = 0
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
        'Sp_consultaLogoTableAdapter
        '
        Me.Sp_consultaLogoTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaNCPendientesBindingSource
        '
        Me.Sp_consultaNCPendientesBindingSource.DataMember = "sp_consultaNCPendientes"
        Me.Sp_consultaNCPendientesBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaNCPendientesTableAdapter
        '
        Me.Sp_consultaNCPendientesTableAdapter.ClearBeforeFill = True
        '
        'R_NC_Pendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 458)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "R_NC_Pendientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de crédito pendientes"
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaNCPendientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaLogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaLogoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
    Friend WithEvents Sp_consultaNCPendientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaNCPendientesTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaNCPendientesTableAdapter
End Class
