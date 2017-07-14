<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl6
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Me.Chart1 = New Dundas.Charting.WinControl.Chart
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserControl6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        '
        'Chart1
        '
        Me.Chart1.AlwaysRecreateHotregions = True
        Me.Chart1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Chart1.BackGradientEndColor = System.Drawing.Color.White
        Me.Chart1.BorderLineColor = System.Drawing.Color.DimGray
        Me.Chart1.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.Chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSlateGray
        Me.Chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.CornflowerBlue
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        Me.Chart1.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.FrameThin5
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MinorTickMark.Size = 2.0!
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.LabelStyle.Format = "N0"
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.Margin = False
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MinorTickMark.Size = 2.0!
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        ChartArea1.BorderWidth = 2
        ChartArea1.Name = "Default"
        ChartArea1.ShadowOffset = 2
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.White
        Legend1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Bottom
        Legend1.Name = "Default"
        Legend1.ShadowOffset = 2
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Series1.BorderWidth = 3
        Series1.ChartType = "Line"
        Series1.CustomAttributes = "RadarDrawingStyle=Area"
        Series1.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!)
        Series1.Name = "Series1"
        Series1.PaletteCustomColors = New System.Drawing.Color(-1) {}
        Series1.ShadowOffset = 1
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series2.BorderColor = System.Drawing.Color.Firebrick
        Series2.BorderWidth = 3
        Series2.ChartType = "Line"
        Series2.Color = System.Drawing.Color.Firebrick
        Series2.CustomAttributes = "RadarDrawingStyle=Area"
        Series2.Font = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.LabelFormat = "N0"
        Series2.Name = "Series2"
        Series2.PaletteCustomColors = New System.Drawing.Color(-1) {}
        Series2.ShadowOffset = 1
        Series2.ShowLabelAsValue = True
        Series2.SmartLabels.Enabled = True
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(401, 353)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Ventas por mes"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Chart1.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent
        Me.Chart1.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss
        Me.Controls.Add(Me.Chart1)
        Me.Name = "UserControl6"
        Me.Size = New System.Drawing.Size(401, 353)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart

End Class
