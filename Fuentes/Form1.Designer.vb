<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TLPEmpaque = New System.Windows.Forms.TableLayoutPanel()
        Me.ChEmpB1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TFechaIniB1 = New System.Windows.Forms.TextBox()
        Me.TFechaFinB1 = New System.Windows.Forms.TextBox()
        Me.BPreviousB1 = New System.Windows.Forms.Button()
        Me.BNextB1 = New System.Windows.Forms.Button()
        Me.ChEmpB2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChRep = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TFechaIniRep = New System.Windows.Forms.TextBox()
        Me.TFechaFinRep = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TFechaIniB2 = New System.Windows.Forms.TextBox()
        Me.TFechaFinB2 = New System.Windows.Forms.TextBox()
        Me.BPreviousB2 = New System.Windows.Forms.Button()
        Me.BNextB2 = New System.Windows.Forms.Button()
        Me.TLPEmpaque.SuspendLayout()
        CType(Me.ChEmpB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ChEmpB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLPEmpaque
        '
        Me.TLPEmpaque.ColumnCount = 1
        Me.TLPEmpaque.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPEmpaque.Controls.Add(Me.Panel3, 0, 3)
        Me.TLPEmpaque.Controls.Add(Me.Panel2, 0, 5)
        Me.TLPEmpaque.Controls.Add(Me.ChRep, 0, 4)
        Me.TLPEmpaque.Controls.Add(Me.ChEmpB2, 0, 2)
        Me.TLPEmpaque.Controls.Add(Me.Panel1, 0, 1)
        Me.TLPEmpaque.Controls.Add(Me.ChEmpB1, 0, 0)
        Me.TLPEmpaque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPEmpaque.Location = New System.Drawing.Point(0, 0)
        Me.TLPEmpaque.Name = "TLPEmpaque"
        Me.TLPEmpaque.RowCount = 6
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.32833!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.005005!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.32833!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.005005!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.32833!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.005005!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPEmpaque.Size = New System.Drawing.Size(1350, 729)
        Me.TLPEmpaque.TabIndex = 0
        '
        'ChEmpB1
        '
        Me.ChEmpB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChEmpB1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea3.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea3.AxisX2.MajorTickMark.Enabled = False
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.Name = "ChartArea1"
        Me.ChEmpB1.ChartAreas.Add(ChartArea3)
        Me.ChEmpB1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChEmpB1.Location = New System.Drawing.Point(3, 3)
        Me.ChEmpB1.Name = "ChEmpB1"
        Me.ChEmpB1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series5.BorderWidth = 3
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series5.IsValueShownAsLabel = True
        Series5.IsVisibleInLegend = False
        Series5.Name = "Series1"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series6.MarkerSize = 10
        Series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series6.Name = "Series2"
        Series6.YValuesPerPoint = 2
        Me.ChEmpB1.Series.Add(Series5)
        Me.ChEmpB1.Series.Add(Series6)
        Me.ChEmpB1.Size = New System.Drawing.Size(1344, 200)
        Me.ChEmpB1.TabIndex = 11
        Me.ChEmpB1.Text = "BOQUILLA 1"
        Title5.DockedToChartArea = "ChartArea1"
        Title5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.Name = "Title1"
        Title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title6.Name = "TituloEmp"
        Me.ChEmpB1.Titles.Add(Title5)
        Me.ChEmpB1.Titles.Add(Title6)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TFechaIniB1)
        Me.Panel1.Controls.Add(Me.TFechaFinB1)
        Me.Panel1.Controls.Add(Me.BPreviousB1)
        Me.Panel1.Controls.Add(Me.BNextB1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 30)
        Me.Panel1.TabIndex = 12
        '
        'TFechaIniB1
        '
        Me.TFechaIniB1.Location = New System.Drawing.Point(49, 4)
        Me.TFechaIniB1.Name = "TFechaIniB1"
        Me.TFechaIniB1.Size = New System.Drawing.Size(100, 20)
        Me.TFechaIniB1.TabIndex = 9
        '
        'TFechaFinB1
        '
        Me.TFechaFinB1.Location = New System.Drawing.Point(1191, 4)
        Me.TFechaFinB1.Name = "TFechaFinB1"
        Me.TFechaFinB1.Size = New System.Drawing.Size(100, 20)
        Me.TFechaFinB1.TabIndex = 8
        '
        'BPreviousB1
        '
        Me.BPreviousB1.Image = CType(resources.GetObject("BPreviousB1.Image"), System.Drawing.Image)
        Me.BPreviousB1.Location = New System.Drawing.Point(3, -1)
        Me.BPreviousB1.Name = "BPreviousB1"
        Me.BPreviousB1.Size = New System.Drawing.Size(40, 29)
        Me.BPreviousB1.TabIndex = 7
        Me.BPreviousB1.UseVisualStyleBackColor = True
        '
        'BNextB1
        '
        Me.BNextB1.Image = CType(resources.GetObject("BNextB1.Image"), System.Drawing.Image)
        Me.BNextB1.Location = New System.Drawing.Point(1296, 0)
        Me.BNextB1.Name = "BNextB1"
        Me.BNextB1.Size = New System.Drawing.Size(39, 30)
        Me.BNextB1.TabIndex = 6
        Me.BNextB1.UseVisualStyleBackColor = True
        '
        'ChEmpB2
        '
        Me.ChEmpB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChEmpB2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.AxisX2.MajorTickMark.Enabled = False
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.Name = "ChartArea1"
        Me.ChEmpB2.ChartAreas.Add(ChartArea2)
        Me.ChEmpB2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChEmpB2.Location = New System.Drawing.Point(3, 245)
        Me.ChEmpB2.Name = "ChEmpB2"
        Me.ChEmpB2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series3.BorderWidth = 3
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.IsValueShownAsLabel = True
        Series3.IsVisibleInLegend = False
        Series3.Name = "Series1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.MarkerSize = 10
        Series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series4.Name = "Series2"
        Series4.YValuesPerPoint = 2
        Me.ChEmpB2.Series.Add(Series3)
        Me.ChEmpB2.Series.Add(Series4)
        Me.ChEmpB2.Size = New System.Drawing.Size(1344, 200)
        Me.ChEmpB2.TabIndex = 14
        Me.ChEmpB2.Text = "BOQUILLA 1"
        Title3.DockedToChartArea = "ChartArea1"
        Title3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Title3.Name = "Title1"
        Title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title4.Name = "TituloEmp"
        Me.ChEmpB2.Titles.Add(Title3)
        Me.ChEmpB2.Titles.Add(Title4)
        '
        'ChRep
        '
        Me.ChRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChRep.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX2.MajorTickMark.Enabled = False
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.Name = "ChartArea1"
        Me.ChRep.ChartAreas.Add(ChartArea1)
        Me.ChRep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChRep.Location = New System.Drawing.Point(3, 487)
        Me.ChRep.Name = "ChRep"
        Me.ChRep.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.IsValueShownAsLabel = True
        Series1.IsVisibleInLegend = False
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.MarkerSize = 10
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series2.Name = "Series2"
        Series2.YValuesPerPoint = 2
        Me.ChRep.Series.Add(Series1)
        Me.ChRep.Series.Add(Series2)
        Me.ChRep.Size = New System.Drawing.Size(1344, 200)
        Me.ChRep.TabIndex = 15
        Me.ChRep.Text = "BOQUILLA 1"
        Title1.DockedToChartArea = "ChartArea1"
        Title1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title2.Name = "TituloEmp"
        Me.ChRep.Titles.Add(Title1)
        Me.ChRep.Titles.Add(Title2)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TFechaIniRep)
        Me.Panel2.Controls.Add(Me.TFechaFinRep)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 693)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 33)
        Me.Panel2.TabIndex = 16
        '
        'TFechaIniRep
        '
        Me.TFechaIniRep.Location = New System.Drawing.Point(52, 6)
        Me.TFechaIniRep.Name = "TFechaIniRep"
        Me.TFechaIniRep.Size = New System.Drawing.Size(100, 20)
        Me.TFechaIniRep.TabIndex = 13
        '
        'TFechaFinRep
        '
        Me.TFechaFinRep.Location = New System.Drawing.Point(1194, 6)
        Me.TFechaFinRep.Name = "TFechaFinRep"
        Me.TFechaFinRep.Size = New System.Drawing.Size(100, 20)
        Me.TFechaFinRep.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(6, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1299, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TFechaIniB2)
        Me.Panel3.Controls.Add(Me.TFechaFinB2)
        Me.Panel3.Controls.Add(Me.BPreviousB2)
        Me.Panel3.Controls.Add(Me.BNextB2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 451)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1344, 30)
        Me.Panel3.TabIndex = 17
        '
        'TFechaIniB2
        '
        Me.TFechaIniB2.Location = New System.Drawing.Point(52, 6)
        Me.TFechaIniB2.Name = "TFechaIniB2"
        Me.TFechaIniB2.Size = New System.Drawing.Size(100, 20)
        Me.TFechaIniB2.TabIndex = 13
        '
        'TFechaFinB2
        '
        Me.TFechaFinB2.Location = New System.Drawing.Point(1194, 6)
        Me.TFechaFinB2.Name = "TFechaFinB2"
        Me.TFechaFinB2.Size = New System.Drawing.Size(100, 20)
        Me.TFechaFinB2.TabIndex = 12
        '
        'BPreviousB2
        '
        Me.BPreviousB2.Image = CType(resources.GetObject("BPreviousB2.Image"), System.Drawing.Image)
        Me.BPreviousB2.Location = New System.Drawing.Point(6, 1)
        Me.BPreviousB2.Name = "BPreviousB2"
        Me.BPreviousB2.Size = New System.Drawing.Size(40, 29)
        Me.BPreviousB2.TabIndex = 11
        Me.BPreviousB2.UseVisualStyleBackColor = True
        '
        'BNextB2
        '
        Me.BNextB2.Image = CType(resources.GetObject("BNextB2.Image"), System.Drawing.Image)
        Me.BNextB2.Location = New System.Drawing.Point(1299, 2)
        Me.BNextB2.Name = "BNextB2"
        Me.BNextB2.Size = New System.Drawing.Size(39, 30)
        Me.BNextB2.TabIndex = 10
        Me.BNextB2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.TLPEmpaque)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TLPEmpaque.ResumeLayout(False)
        CType(Me.ChEmpB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ChEmpB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLPEmpaque As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ChEmpB1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TFechaIniB1 As System.Windows.Forms.TextBox
    Friend WithEvents TFechaFinB1 As System.Windows.Forms.TextBox
    Friend WithEvents BPreviousB1 As System.Windows.Forms.Button
    Friend WithEvents BNextB1 As System.Windows.Forms.Button
    Friend WithEvents ChEmpB2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChRep As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TFechaIniRep As System.Windows.Forms.TextBox
    Friend WithEvents TFechaFinRep As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TFechaIniB2 As System.Windows.Forms.TextBox
    Friend WithEvents TFechaFinB2 As System.Windows.Forms.TextBox
    Friend WithEvents BPreviousB2 As System.Windows.Forms.Button
    Friend WithEvents BNextB2 As System.Windows.Forms.Button
End Class
