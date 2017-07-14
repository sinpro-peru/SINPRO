<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_NotaCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_NotaCredito))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Sp_consultaNC_rdlcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Sp_consultaproductosNC_rdlcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaNC_rdlcTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaNC_rdlcTableAdapter
        Me.MELDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaproductosNC_rdlcTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaproductosNC_rdlcTableAdapter
        CType(Me.Sp_consultaNC_rdlcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaproductosNC_rdlcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MELDataSet_sp_consultaNC_rdlc"
        ReportDataSource1.Value = Me.Sp_consultaNC_rdlcBindingSource
        ReportDataSource2.Name = "MELDataSet_sp_consultaproductosNC_rdlc"
        ReportDataSource2.Value = Me.Sp_consultaproductosNC_rdlcBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Nc.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(804, 464)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sp_consultaNC_rdlcBindingSource
        '
        Me.Sp_consultaNC_rdlcBindingSource.DataMember = "sp_consultaNC_rdlc"
        Me.Sp_consultaNC_rdlcBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.EnforceConstraints = False
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_consultaproductosNC_rdlcBindingSource
        '
        Me.Sp_consultaproductosNC_rdlcBindingSource.DataMember = "sp_consultaproductosNC_rdlc"
        Me.Sp_consultaproductosNC_rdlcBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaNC_rdlcTableAdapter
        '
        Me.Sp_consultaNC_rdlcTableAdapter.ClearBeforeFill = True
        '
        'MELDataSetBindingSource
        '
        Me.MELDataSetBindingSource.DataSource = Me.MELDataSet
        Me.MELDataSetBindingSource.Position = 0
        '
        'Sp_consultaproductosNC_rdlcTableAdapter
        '
        Me.Sp_consultaproductosNC_rdlcTableAdapter.ClearBeforeFill = True
        '
        'R_NotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 464)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-4, 129)
        Me.Name = "R_NotaCredito"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Nota de crédito"
        CType(Me.Sp_consultaNC_rdlcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaproductosNC_rdlcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaNC_rdlcBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaNC_rdlcTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaNC_rdlcTableAdapter
    Friend WithEvents MELDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaproductosNC_rdlcBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaproductosNC_rdlcTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaproductosNC_rdlcTableAdapter
End Class
