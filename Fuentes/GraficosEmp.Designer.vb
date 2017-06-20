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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraficosEmp))
        Me.TLPEmpaque = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChEmp = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TFechaIni = New System.Windows.Forms.TextBox()
        Me.TFechaFin = New System.Windows.Forms.TextBox()
        Me.BPrevious = New System.Windows.Forms.Button()
        Me.BNext = New System.Windows.Forms.Button()
        Me.TimActualiza = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnGraficas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnActAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TLPEmpaque.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ChEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLPEmpaque
        '
        Me.TLPEmpaque.ColumnCount = 1
        Me.TLPEmpaque.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPEmpaque.Controls.Add(Me.ChEmp, 0, 0)
        Me.TLPEmpaque.Controls.Add(Me.Panel1, 0, 1)
        Me.TLPEmpaque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPEmpaque.Location = New System.Drawing.Point(0, 0)
        Me.TLPEmpaque.Name = "TLPEmpaque"
        Me.TLPEmpaque.RowCount = 6
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.49323!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.336326!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.7489!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.336326!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.7489!))
        Me.TLPEmpaque.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.336326!))
        Me.TLPEmpaque.Size = New System.Drawing.Size(1350, 729)
        Me.TLPEmpaque.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TFechaIni)
        Me.Panel1.Controls.Add(Me.TFechaFin)
        Me.Panel1.Controls.Add(Me.BPrevious)
        Me.Panel1.Controls.Add(Me.BNext)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 32)
        Me.Panel1.TabIndex = 3
        '
        'ChEmp
        '
        Me.ChEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChEmp.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea3.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea3.AxisX2.MajorTickMark.Enabled = False
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.Name = "ChartArea1"
        Me.ChEmp.ChartAreas.Add(ChartArea3)
        Me.ChEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChEmp.Location = New System.Drawing.Point(3, 3)
        Me.ChEmp.Name = "ChEmp"
        Me.ChEmp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
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
        Me.ChEmp.Series.Add(Series5)
        Me.ChEmp.Series.Add(Series6)
        Me.ChEmp.Size = New System.Drawing.Size(1344, 201)
        Me.ChEmp.TabIndex = 10
        Me.ChEmp.Text = "BOQUILLA 1"
        Title3.DockedToChartArea = "ChartArea1"
        Title3.Name = "Title1"
        Me.ChEmp.Titles.Add(Title3)
        '
        'TFechaIni
        '
        Me.TFechaIni.Location = New System.Drawing.Point(49, 4)
        Me.TFechaIni.Name = "TFechaIni"
        Me.TFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.TFechaIni.TabIndex = 9
        '
        'TFechaFin
        '
        Me.TFechaFin.Location = New System.Drawing.Point(1191, 4)
        Me.TFechaFin.Name = "TFechaFin"
        Me.TFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.TFechaFin.TabIndex = 8
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
        'BNext
        '
        Me.BNext.Image = CType(resources.GetObject("BNext.Image"), System.Drawing.Image)
        Me.BNext.Location = New System.Drawing.Point(1296, 0)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(39, 30)
        Me.BNext.TabIndex = 6
        Me.BNext.UseVisualStyleBackColor = True
        '
        'TimActualiza
        '
        Me.TimActualiza.Enabled = True
        Me.TimActualiza.Interval = 3000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.mnGraficas})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSalir})
        Me.ArchivoToolStripMenuItem.Image = CType(resources.GetObject("ArchivoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'mnSalir
        '
        Me.mnSalir.Name = "mnSalir"
        Me.mnSalir.Size = New System.Drawing.Size(152, 22)
        Me.mnSalir.Text = "Salir"
        '
        'mnGraficas
        '
        Me.mnGraficas.Checked = True
        Me.mnGraficas.CheckOnClick = True
        Me.mnGraficas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnGraficas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnGraficas.DoubleClickEnabled = True
        Me.mnGraficas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnActAuto})
        Me.mnGraficas.Image = CType(resources.GetObject("mnGraficas.Image"), System.Drawing.Image)
        Me.mnGraficas.Name = "mnGraficas"
        Me.mnGraficas.Size = New System.Drawing.Size(64, 20)
        Me.mnGraficas.Text = "Gráficas"
        '
        'mnActAuto
        '
        Me.mnActAuto.Checked = True
        Me.mnActAuto.CheckOnClick = True
        Me.mnActAuto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnActAuto.Name = "mnActAuto"
        Me.mnActAuto.Size = New System.Drawing.Size(157, 22)
        Me.mnActAuto.Text = "Actualizar Auto"
        '
        'GraficosEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TLPEmpaque)
        Me.Name = "GraficosEmp"
        Me.Text = "GraficosEmp"
        Me.TLPEmpaque.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ChEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TLPEmpaque As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BNext As System.Windows.Forms.Button
    Friend WithEvents BPrevious As System.Windows.Forms.Button
    Friend WithEvents ChEmp As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TFechaIni As System.Windows.Forms.TextBox
    Friend WithEvents TFechaFin As System.Windows.Forms.TextBox
    Friend WithEvents TimActualiza As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnGraficas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnActAuto As System.Windows.Forms.ToolStripMenuItem
End Class
