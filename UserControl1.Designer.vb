<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        'Chart1
        '
        Me.Chart1.AlwaysRecreateHotregions = True
        Me.Chart1.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Chart1.BorderLineColor = System.Drawing.Color.Black
        Me.Chart1.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.Chart1.BorderLineWidth = 2
        Me.Chart1.BorderSkin.FrameBackColor = System.Drawing.Color.Black
        Me.Chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.Area3DStyle.Clustered = True
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic
        ChartArea1.Area3DStyle.WallWidth = 3
        ChartArea1.AxisX.LabelsAutoFitMaxFontSize = 9
        ChartArea1.AxisX.LabelsAutoFitStyle = CType(((((Dundas.Charting.WinControl.LabelsAutoFitStyle.IncreaseFont Or Dundas.Charting.WinControl.LabelsAutoFitStyle.DecreaseFont) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.OffsetLabels) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep30) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep45), Dundas.Charting.WinControl.LabelsAutoFitStyle)
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.AxisX.Margin = False
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea1.AxisX.MinorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.AxisX.Title = "Meses"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelsAutoFitMaxFontSize = 9
        ChartArea1.AxisY.LabelsAutoFitStyle = CType(((((Dundas.Charting.WinControl.LabelsAutoFitStyle.IncreaseFont Or Dundas.Charting.WinControl.LabelsAutoFitStyle.DecreaseFont) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.OffsetLabels) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep30) _
                    Or Dundas.Charting.WinControl.LabelsAutoFitStyle.LabelsAngleStep45), Dundas.Charting.WinControl.LabelsAutoFitStyle)
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea1.AxisY.MinorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.AxisY.Title = "Cant. Vendida"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Eras Medium ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        ChartArea1.Name = "Default"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.AutoFitText = False
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend1.BorderColor = System.Drawing.Color.LightSlateGray
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Top
        Legend1.DockToChartArea = "Default"
        Legend1.Enabled = False
        Legend1.LegendStyle = Dundas.Charting.WinControl.LegendStyle.Row
        Legend1.Name = "Default"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.WaterLilies
        Series1.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Series1.BackGradientType = Dundas.Charting.WinControl.GradientType.VerticalCenter
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.Color = System.Drawing.Color.MediumTurquoise
        Series1.CustomAttributes = "DrawingStyle=LightToDark"
        Series1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.LegendText = "Ventas"
        Series1.Name = "Series1"
        Series1.PaletteCustomColors = New System.Drawing.Color(-1) {}
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series1.XValueIndexed = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.Int
        Series2.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Series2.BackGradientType = Dundas.Charting.WinControl.GradientType.VerticalCenter
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.ChartType = "StackedColumn"
        Series2.Color = System.Drawing.Color.IndianRed
        Series2.CustomAttributes = "DrawingStyle=LightToDark"
        Series2.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.LegendText = "Devoluciones"
        Series2.Name = "Series2"
        Series2.PaletteCustomColors = New System.Drawing.Color(-1) {}
        Series2.ShowLabelAsValue = True
        Series2.SmartLabels.Enabled = True
        Series2.XValueIndexed = True
        Series2.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.YValuesPerPoint = 2
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(400, 251)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Title1"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.UI.ContextMenu.Enabled = True
        Me.Chart1.UI.Toolbar.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.UI.Toolbar.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.NotSet
        Me.Chart1.UI.Toolbar.Enabled = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.Chart1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(400, 251)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart

End Class
