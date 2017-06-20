<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraficosEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraficosEmp))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TLPEmpaque = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BNext = New System.Windows.Forms.Button()
        Me.BPrevious = New System.Windows.Forms.Button()
        Me.ChDatos4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TFechaIni1 = New System.Windows.Forms.TextBox()
        Me.TFechaFin1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TLPEmpaque.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ChDatos4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BSalir, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(964, 25)
        Me.ToolStrip1.TabIndex = 40
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BSalir
        '
        Me.BSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(23, 22)
        Me.BSalir.Text = "Salir"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'TLPEmpaque
        '
        Me.TLPEmpaque.ColumnCount = 1
        Me.TLPEmpaque.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPEmpaque.Controls.Add(Me.ChDatos4, 0, 0)
        Me.TLPEmpaque.Controls.Add(Me.Panel1, 0, 1)
        Me.TLPEmpaque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPEmpaque.Location = New System.Drawing.Point(0, 25)
        Me.TLPEmpaque.Name = "TLPEmpaque"
        Me.TLPEmpaque.RowCount = 6
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.49323!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.336326!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.7489!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.336326!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.7489!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.336326!))
        Me.TLPEmpaque.Size = New System.Drawing.Size(964, 662)
        Me.TLPEmpaque.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TFechaIni1)
        Me.Panel1.Controls.Add(Me.TFechaFin1)
        Me.Panel1.Controls.Add(Me.BPrevious)
        Me.Panel1.Controls.Add(Me.BNext)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 191)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 29)
        Me.Panel1.TabIndex = 3
        '
        'BNext
        '
        Me.BNext.Image = CType(resources.GetObject("BNext.Image"), System.Drawing.Image)
        Me.BNext.Location = New System.Drawing.Point(916, 0)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(39, 30)
        Me.BNext.TabIndex = 6
        Me.BNext.UseVisualStyleBackColor = True
        '
        'BPrevious
        '
        Me.BPrevious.Image = CType(resources.GetObject("BPrevious.Image"), System.Drawing.Image)
        Me.BPrevious.Location = New System.Drawing.Point(3, -1)
        Me.BPrevious.Name = "BPrevious"
        Me.BPrevious.Size = New System.Drawing.Size(40, 29)
        Me.BPrevious.TabIndex = 7
        Me.BPrevious.UseVisualStyleBackColor = True
        '
        'ChDatos4
        '
        Me.ChDatos4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChDatos4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX2.MajorTickMark.Enabled = False
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.Name = "ChartArea1"
        Me.ChDatos4.ChartAreas.Add(ChartArea1)
        Me.ChDatos4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChDatos4.Location = New System.Drawing.Point(3, 3)
        Me.ChDatos4.Name = "ChDatos4"
        Me.ChDatos4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
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
        Me.ChDatos4.Series.Add(Series1)
        Me.ChDatos4.Series.Add(Series2)
        Me.ChDatos4.Size = New System.Drawing.Size(958, 182)
        Me.ChDatos4.TabIndex = 10
        Me.ChDatos4.Text = "BOQUILLA 1"
        Title1.DockedToChartArea = "ChartArea1"
        Title1.Name = "Title1"
        Me.ChDatos4.Titles.Add(Title1)
        '
        'TFechaIni1
        '
        Me.TFechaIni1.Location = New System.Drawing.Point(49, 4)
        Me.TFechaIni1.Name = "TFechaIni1"
        Me.TFechaIni1.Size = New System.Drawing.Size(100, 20)
        Me.TFechaIni1.TabIndex = 9
        '
        'TFechaFin1
        '
        Me.TFechaFin1.Location = New System.Drawing.Point(811, 4)
        Me.TFechaFin1.Name = "TFechaFin1"
        Me.TFechaFin1.Size = New System.Drawing.Size(100, 20)
        Me.TFechaFin1.TabIndex = 8
        '
        'GraficosEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 687)
        Me.Controls.Add(Me.TLPEmpaque)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "GraficosEmp"
        Me.Text = "GraficosEmp"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TLPEmpaque.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ChDatos4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TLPEmpaque As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BNext As System.Windows.Forms.Button
    Friend WithEvents BPrevious As System.Windows.Forms.Button
    Friend WithEvents ChDatos4 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TFechaIni1 As System.Windows.Forms.TextBox
    Friend WithEvents TFechaFin1 As System.Windows.Forms.TextBox
End Class
