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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraficosEmp))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TimActualiza = New System.Windows.Forms.Timer(Me.components)
        Me.TLPEmpaque = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TFechaIni = New System.Windows.Forms.TextBox()
        Me.TFechaFin = New System.Windows.Forms.TextBox()
        Me.BPrevious = New System.Windows.Forms.Button()
        Me.BNext = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TFechaIniRep = New System.Windows.Forms.TextBox()
        Me.TFechaFinRep = New System.Windows.Forms.TextBox()
        Me.BPreviousRep = New System.Windows.Forms.Button()
        Me.BNextRep = New System.Windows.Forms.Button()
        Me.ChRep = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChEmpB2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChEmpB1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BImprimir = New System.Windows.Forms.ToolStripButton()
        Me.BFiltrarEmp = New System.Windows.Forms.ToolStripButton()
        Me.BFiltrarRep = New System.Windows.Forms.ToolStripButton()
        Me.TCodProdRep = New System.Windows.Forms.ToolStripTextBox()
        Me.TCodProd = New System.Windows.Forms.ToolStripTextBox()
        Me.ChActAutom = New System.Windows.Forms.CheckBox()
        Me.TLPEmpaque.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ChRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChEmpB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChEmpB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimActualiza
        '
        Me.TimActualiza.Enabled = True
        Me.TimActualiza.Interval = 3000
        '
        'TLPEmpaque
        '
        Me.TLPEmpaque.ColumnCount = 1
        Me.TLPEmpaque.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPEmpaque.Controls.Add(Me.Panel3, 0, 2)
        Me.TLPEmpaque.Controls.Add(Me.Panel2, 0, 4)
        Me.TLPEmpaque.Controls.Add(Me.ChRep, 0, 3)
        Me.TLPEmpaque.Controls.Add(Me.ChEmpB2, 0, 1)
        Me.TLPEmpaque.Controls.Add(Me.ChEmpB1, 0, 0)
        Me.TLPEmpaque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPEmpaque.Location = New System.Drawing.Point(0, 0)
        Me.TLPEmpaque.Name = "TLPEmpaque"
        Me.TLPEmpaque.RowCount = 5
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.82087!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.82087!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.268704!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.82087!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.268704!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPEmpaque.Size = New System.Drawing.Size(1350, 729)
        Me.TLPEmpaque.TabIndex = 43
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TFechaIni)
        Me.Panel3.Controls.Add(Me.TFechaFin)
        Me.Panel3.Controls.Add(Me.BPrevious)
        Me.Panel3.Controls.Add(Me.BNext)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 437)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1344, 32)
        Me.Panel3.TabIndex = 17
        '
        'TFechaIni
        '
        Me.TFechaIni.Location = New System.Drawing.Point(52, 6)
        Me.TFechaIni.Name = "TFechaIni"
        Me.TFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.TFechaIni.TabIndex = 13
        '
        'TFechaFin
        '
        Me.TFechaFin.Location = New System.Drawing.Point(1194, 6)
        Me.TFechaFin.Name = "TFechaFin"
        Me.TFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.TFechaFin.TabIndex = 12
        '
        'BPrevious
        '
        Me.BPrevious.Image = CType(resources.GetObject("BPrevious.Image"), System.Drawing.Image)
        Me.BPrevious.Location = New System.Drawing.Point(6, 1)
        Me.BPrevious.Name = "BPrevious"
        Me.BPrevious.Size = New System.Drawing.Size(40, 29)
        Me.BPrevious.TabIndex = 11
        Me.BPrevious.UseVisualStyleBackColor = True
        '
        'BNext
        '
        Me.BNext.Image = CType(resources.GetObject("BNext.Image"), System.Drawing.Image)
        Me.BNext.Location = New System.Drawing.Point(1299, 2)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(39, 30)
        Me.BNext.TabIndex = 10
        Me.BNext.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TFechaIniRep)
        Me.Panel2.Controls.Add(Me.TFechaFinRep)
        Me.Panel2.Controls.Add(Me.BPreviousRep)
        Me.Panel2.Controls.Add(Me.BNextRep)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 692)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 34)
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
        'BPreviousRep
        '
        Me.BPreviousRep.Image = CType(resources.GetObject("BPreviousRep.Image"), System.Drawing.Image)
        Me.BPreviousRep.Location = New System.Drawing.Point(6, 1)
        Me.BPreviousRep.Name = "BPreviousRep"
        Me.BPreviousRep.Size = New System.Drawing.Size(40, 29)
        Me.BPreviousRep.TabIndex = 11
        Me.BPreviousRep.UseVisualStyleBackColor = True
        '
        'BNextRep
        '
        Me.BNextRep.Image = CType(resources.GetObject("BNextRep.Image"), System.Drawing.Image)
        Me.BNextRep.Location = New System.Drawing.Point(1299, 2)
        Me.BNextRep.Name = "BNextRep"
        Me.BNextRep.Size = New System.Drawing.Size(39, 30)
        Me.BNextRep.TabIndex = 10
        Me.BNextRep.UseVisualStyleBackColor = True
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
        Me.ChRep.Location = New System.Drawing.Point(3, 475)
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
        Me.ChRep.Size = New System.Drawing.Size(1344, 211)
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
        Me.ChEmpB2.Location = New System.Drawing.Point(3, 220)
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
        Me.ChEmpB2.Size = New System.Drawing.Size(1344, 211)
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
        Me.ChEmpB1.Size = New System.Drawing.Size(1344, 211)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BSalir, Me.ToolStripSeparator9, Me.ToolStripSeparator2, Me.BImprimir, Me.BFiltrarEmp, Me.BFiltrarRep, Me.TCodProdRep, Me.TCodProd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1350, 25)
        Me.ToolStrip1.TabIndex = 44
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BImprimir
        '
        Me.BImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BImprimir.Image = CType(resources.GetObject("BImprimir.Image"), System.Drawing.Image)
        Me.BImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(23, 22)
        Me.BImprimir.Text = "Imprimir Materias Primas"
        '
        'BFiltrarEmp
        '
        Me.BFiltrarEmp.Image = CType(resources.GetObject("BFiltrarEmp.Image"), System.Drawing.Image)
        Me.BFiltrarEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BFiltrarEmp.Name = "BFiltrarEmp"
        Me.BFiltrarEmp.Size = New System.Drawing.Size(104, 22)
        Me.BFiltrarEmp.Text = "Filtrar Ensaque"
        Me.BFiltrarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'BFiltrarRep
        '
        Me.BFiltrarRep.Image = CType(resources.GetObject("BFiltrarRep.Image"), System.Drawing.Image)
        Me.BFiltrarRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BFiltrarRep.Name = "BFiltrarRep"
        Me.BFiltrarRep.Size = New System.Drawing.Size(98, 22)
        Me.BFiltrarRep.Text = "Filtrar Repeso"
        Me.BFiltrarRep.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'TCodProdRep
        '
        Me.TCodProdRep.Name = "TCodProdRep"
        Me.TCodProdRep.Size = New System.Drawing.Size(100, 25)
        Me.TCodProdRep.Visible = False
        '
        'TCodProd
        '
        Me.TCodProd.Name = "TCodProd"
        Me.TCodProd.Size = New System.Drawing.Size(100, 25)
        Me.TCodProd.Visible = False
        '
        'ChActAutom
        '
        Me.ChActAutom.AutoSize = True
        Me.ChActAutom.Checked = True
        Me.ChActAutom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChActAutom.Location = New System.Drawing.Point(408, 4)
        Me.ChActAutom.Name = "ChActAutom"
        Me.ChActAutom.Size = New System.Drawing.Size(145, 17)
        Me.ChActAutom.TabIndex = 45
        Me.ChActAutom.Text = "Actualización Automática"
        Me.ChActAutom.UseVisualStyleBackColor = True
        '
        'GraficosEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ChActAutom)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TLPEmpaque)
        Me.Name = "GraficosEmp"
        Me.Text = "GraficosEmp"
        Me.TLPEmpaque.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ChRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChEmpB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChEmpB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimActualiza As System.Windows.Forms.Timer
    Friend WithEvents TLPEmpaque As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TFechaIni As System.Windows.Forms.TextBox
    Friend WithEvents TFechaFin As System.Windows.Forms.TextBox
    Friend WithEvents BPrevious As System.Windows.Forms.Button
    Friend WithEvents BNext As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TFechaIniRep As System.Windows.Forms.TextBox
    Friend WithEvents TFechaFinRep As System.Windows.Forms.TextBox
    Friend WithEvents BPreviousRep As System.Windows.Forms.Button
    Friend WithEvents BNextRep As System.Windows.Forms.Button
    Friend WithEvents ChRep As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChEmpB2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChEmpB1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChActAutom As System.Windows.Forms.CheckBox
    Friend WithEvents BFiltrarEmp As System.Windows.Forms.ToolStripButton
    Friend WithEvents BFiltrarRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents TCodProdRep As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TCodProd As System.Windows.Forms.ToolStripTextBox
End Class
