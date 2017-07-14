<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_Catalogo_Productos_Fotos
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Sp_consultaLogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.Table_Catalogo_Productos_FotosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_indice_ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaLogoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
        Me.Table_indice_ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_Catalogo_Productos_FotosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_indice_ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_indice_ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MELDataSet_sp_consultaLogo"
        ReportDataSource1.Value = Me.Sp_consultaLogoBindingSource
        ReportDataSource2.Name = "MELDataSet_Table_Catalogo_Productos_Fotos"
        ReportDataSource2.Value = Me.Table_Catalogo_Productos_FotosBindingSource
        ReportDataSource3.Name = "MELDataSet_Table_indice_Modelos"
        ReportDataSource3.Value = Me.Table_indice_ModelosBindingSource
        ReportDataSource4.Name = "MELDataSet_Table_indice_Productos"
        ReportDataSource4.Value = Me.Table_indice_ProductosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.Catalogo_Productos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(679, 528)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sp_consultaLogoBindingSource
        '
        Me.Sp_consultaLogoBindingSource.DataMember = "sp_consultaLogo"
        Me.Sp_consultaLogoBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_Catalogo_Productos_FotosBindingSource
        '
        Me.Table_Catalogo_Productos_FotosBindingSource.DataMember = "Table_Catalogo_Productos_Fotos"
        Me.Table_Catalogo_Productos_FotosBindingSource.DataSource = Me.MELDataSet
        '
        'Table_indice_ModelosBindingSource
        '
        Me.Table_indice_ModelosBindingSource.DataMember = "Table_indice_Modelos"
        Me.Table_indice_ModelosBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaLogoTableAdapter
        '
        Me.Sp_consultaLogoTableAdapter.ClearBeforeFill = True
        '
        'Table_indice_ProductosBindingSource
        '
        Me.Table_indice_ProductosBindingSource.DataMember = "Table_indice_Productos"
        Me.Table_indice_ProductosBindingSource.DataSource = Me.MELDataSet
        '
        'R_Catalogo_Productos_Fotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 528)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "R_Catalogo_Productos_Fotos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Productos"
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_Catalogo_Productos_FotosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_indice_ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_indice_ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Table_Catalogo_Productos_FotosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaLogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaLogoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
    Friend WithEvents Table_indice_ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_indice_ProductosBindingSource As System.Windows.Forms.BindingSource
End Class
