<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl5
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
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid
        Me.Chart1 = New Dundas.Charting.WinControl.Chart
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'propertyGrid
        '
        Me.propertyGrid.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid.Location = New System.Drawing.Point(0, 13)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(130, 130)
        Me.propertyGrid.TabIndex = 0
        '
        'UserControl5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        '
        'Chart1
        '
        Me.Chart1.AlwaysRecreateHotregions = True
        Me.Chart1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Chart1.BackGradientEndColor = System.Drawing.Color.White
        Me.Chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.Chart1.BorderLineColor = System.Drawing.Color.DimGray
        Me.Chart1.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.Chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSlateGray
        Me.Chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.CornflowerBlue
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        Me.Chart1.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.FrameThin5
        ChartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic
        ChartArea1.AxisX.Enabled = Dundas.Charting.WinControl.AxisEnabled.[True]
        ChartArea1.AxisX.LabelsAutoFitMaxFontSize = 8
        ChartArea1.AxisX.LabelsAutoFitStyle = CType(((((((Dundas.Charting.WinControl.LabelsAutoFitStyle.IncreaseFont Or Dundas.Charting.WinControl.LabelsAutoFitStyle.DecreaseFont) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.OffsetLabels) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep30) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep45) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep90) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.WordWrap), Dundas.Charting.WinControl.LabelsAutoFitStyle)
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Eras Medium ITC", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.AxisX.MajorGrid.Interval = 0
        ChartArea1.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorTickMark.Enabled = False
        ChartArea1.AxisX.MajorTickMark.Interval = 0
        ChartArea1.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.Margin = False
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.LabelsAutoFitStyle = CType(((((((Dundas.Charting.WinControl.LabelsAutoFitStyle.IncreaseFont Or Dundas.Charting.WinControl.LabelsAutoFitStyle.DecreaseFont) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.OffsetLabels) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep30) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep45) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep90) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.WordWrap), Dundas.Charting.WinControl.LabelsAutoFitStyle)
        ChartArea1.AxisX2.LabelStyle.Font = New System.Drawing.Font("Eras Medium ITC", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.LabelStyle.ShowEndLabels = False
        ChartArea1.AxisX2.MajorGrid.Interval = 0
        ChartArea1.AxisX2.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.MajorTickMark.Interval = 0
        ChartArea1.AxisX2.MajorTickMark.IntervalOffset = 0
        ChartArea1.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.Enabled = Dundas.Charting.WinControl.AxisEnabled.[True]
        ChartArea1.AxisY.LabelsAutoFit = False
        ChartArea1.AxisY.LabelsAutoFitMaxFontSize = 8
        ChartArea1.AxisY.LabelsAutoFitStyle = CType(((((((Dundas.Charting.WinControl.LabelsAutoFitStyle.IncreaseFont Or Dundas.Charting.WinControl.LabelsAutoFitStyle.DecreaseFont) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.OffsetLabels) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep30) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep45) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep90) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.WordWrap), Dundas.Charting.WinControl.LabelsAutoFitStyle)
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.Format = "C"
        ChartArea1.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.Interval = 0
        ChartArea1.AxisY.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorTickMark.Interval = 0
        ChartArea1.AxisY.MajorTickMark.IntervalOffset = 0
        ChartArea1.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY2.LabelsAutoFitStyle = CType(((((((Dundas.Charting.WinControl.LabelsAutoFitStyle.IncreaseFont Or Dundas.Charting.WinControl.LabelsAutoFitStyle.DecreaseFont) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.OffsetLabels) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep30) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep45) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep90) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.WordWrap), Dundas.Charting.WinControl.LabelsAutoFitStyle)
        ChartArea1.AxisY2.LabelStyle.Font = New System.Drawing.Font("Eras Medium ITC", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.LabelStyle.ShowEndLabels = False
        ChartArea1.AxisY2.MajorGrid.Interval = 0
        ChartArea1.AxisY2.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY2.MajorTickMark.Interval = 0
        ChartArea1.AxisY2.MajorTickMark.IntervalOffset = 0
        ChartArea1.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.BackColor = System.Drawing.Color.Gainsboro
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        ChartArea1.Name = "Default"
        ChartArea1.ShadowOffset = 2
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.AutoFitText = False
        Legend1.BackColor = System.Drawing.Color.White
        Legend1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Bottom
        Legend1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Legend1.ShadowOffset = 2
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Series1.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.ChartType = "Bar"
        Series1.Color = System.Drawing.Color.DodgerBlue
        Series1.CustomAttributes = "BarLabelStyle=Right, DrawingStyle=Cylinder"
        Series1.Font = New System.Drawing.Font("Eras Medium ITC", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.LabelFormat = "C2"
        Series1.LegendText = "Evaluación"
        Series1.Name = "Series1"
        Series1.PaletteCustomColors = New System.Drawing.Color(-1) {}
        Series1.ShadowOffset = 1
        Series1.SmartLabels.Enabled = True
        Series1.SmartLabels.HideOverlapped = False
        Series1.XValueIndexed = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[String]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.ChartType = "Bar"
        Series2.Color = System.Drawing.Color.Maroon
        Series2.CustomAttributes = "BarLabelStyle=Right, DrawingStyle=Cylinder"
        Series2.Font = New System.Drawing.Font("Eras Medium ITC", 6.75!)
        Series2.LabelFormat = "c2"
        Series2.LegendText = "Comparación"
        Series2.Name = "Series2"
        Series2.PaletteCustomColors = New System.Drawing.Color(-1) {}
        Series2.XValueIndexed = True
        Series2.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[String]
        Series2.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(458, 740)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Ventas por estado"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Chart1.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent
        Me.Chart1.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss
        Me.Controls.Add(Me.Chart1)
        Me.Name = "UserControl5"
        Me.Size = New System.Drawing.Size(458, 740)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart

End Class
