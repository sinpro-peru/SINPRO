<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl3
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
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Me.Chart1 = New Dundas.Charting.WinControl.Chart
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.AlwaysRecreateHotregions = True
        Me.Chart1.BackGradientEndColor = System.Drawing.Color.White
        Me.Chart1.BackImageTranspColor = System.Drawing.Color.White
        Me.Chart1.BorderLineColor = System.Drawing.Color.DimGray
        Me.Chart1.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.Chart1.BorderLineWidth = 2
        Me.Chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSlateGray
        Me.Chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue
        Me.Chart1.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Chart1.BorderSkin.FrameBorderWidth = 2
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        Me.Chart1.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.FrameThin5
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.AxisX.LabelStyle.FontColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MinorTickMark.Size = 2.0!
        ChartArea1.AxisY.LabelStyle.FontColor = System.Drawing.Color.White
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MinorTickMark.Size = 2.0!
        ChartArea1.BackColor = System.Drawing.Color.Gainsboro
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        ChartArea1.Name = "Default"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Top
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Bottom
        Legend1.Name = "Default"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.Vegas
        Series1.BackGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.ChartType = "Pie"
        Series1.CustomAttributes = "PieLabelStyle=Outside, DrawingStyle=LightToDark, PieDrawingStyle=Concave"
        Series1.EmptyPointStyle.CustomAttributes = "PieLabelStyle=Ellipse, Exploded=True"
        Series1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.LabelFormat = "P"
        Series1.Name = "Series1"
        Series1.PaletteCustomColors = New System.Drawing.Color(-1) {}
        Series1.ShadowColor = System.Drawing.Color.White
        Series1.ShadowOffset = 1
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series1.SmartLabels.MaxMovingDistance = 100
        Series1.XValueIndexed = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(518, 422)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Total Ventas por vendedor"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.UI.Toolbar.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue
        Me.Chart1.UI.Toolbar.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue
        Me.Chart1.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent
        '
        'UserControl3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Chart1)
        Me.Name = "UserControl3"
        Me.Size = New System.Drawing.Size(518, 425)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart

End Class
