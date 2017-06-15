<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.THoraIni = New System.Windows.Forms.DateTimePicker()
        Me.TFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.THoraFin = New System.Windows.Forms.DateTimePicker()
        Me.TFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GBTurno = New System.Windows.Forms.GroupBox()
        Me.OPTurno3 = New System.Windows.Forms.RadioButton()
        Me.OPTurno2 = New System.Windows.Forms.RadioButton()
        Me.OPTurno1 = New System.Windows.Forms.RadioButton()
        Me.OP24Horas = New System.Windows.Forms.RadioButton()
        Me.TVReportes = New System.Windows.Forms.TreeView()
        Me.BCDate = New System.Windows.Forms.Button()
        Me.RvReportes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GBTurno.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BSalir, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(203, 25)
        Me.ToolStrip1.TabIndex = 32
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.THoraIni)
        Me.GroupBox1.Controls.Add(Me.TFechaIni)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 54)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desde:"
        '
        'THoraIni
        '
        Me.THoraIni.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.THoraIni.CustomFormat = "HH:mm"
        Me.THoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.THoraIni.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.THoraIni.Location = New System.Drawing.Point(132, 25)
        Me.THoraIni.Name = "THoraIni"
        Me.THoraIni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.THoraIni.ShowUpDown = True
        Me.THoraIni.Size = New System.Drawing.Size(55, 20)
        Me.THoraIni.TabIndex = 2
        '
        'TFechaIni
        '
        Me.TFechaIni.CustomFormat = "yyyy/MM/dd"
        Me.TFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TFechaIni.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TFechaIni.Location = New System.Drawing.Point(44, 25)
        Me.TFechaIni.Name = "TFechaIni"
        Me.TFechaIni.Size = New System.Drawing.Size(82, 20)
        Me.TFechaIni.TabIndex = 1
        Me.TFechaIni.Value = New Date(2011, 12, 5, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.THoraFin)
        Me.GroupBox2.Controls.Add(Me.TFechaFin)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 54)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasta:"
        '
        'THoraFin
        '
        Me.THoraFin.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.THoraFin.CustomFormat = "HH:mm"
        Me.THoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.THoraFin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.THoraFin.Location = New System.Drawing.Point(132, 23)
        Me.THoraFin.Name = "THoraFin"
        Me.THoraFin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.THoraFin.ShowUpDown = True
        Me.THoraFin.Size = New System.Drawing.Size(55, 20)
        Me.THoraFin.TabIndex = 2
        Me.THoraFin.Value = New Date(2008, 12, 29, 0, 0, 0, 0)
        '
        'TFechaFin
        '
        Me.TFechaFin.CustomFormat = "yyyy/MM/dd"
        Me.TFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TFechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TFechaFin.Location = New System.Drawing.Point(44, 23)
        Me.TFechaFin.Name = "TFechaFin"
        Me.TFechaFin.Size = New System.Drawing.Size(82, 20)
        Me.TFechaFin.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GBTurno)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TVReportes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BCDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RvReportes)
        Me.SplitContainer1.Size = New System.Drawing.Size(1148, 733)
        Me.SplitContainer1.SplitterDistance = 203
        Me.SplitContainer1.TabIndex = 0
        '
        'GBTurno
        '
        Me.GBTurno.Controls.Add(Me.OPTurno3)
        Me.GBTurno.Controls.Add(Me.OPTurno2)
        Me.GBTurno.Controls.Add(Me.OPTurno1)
        Me.GBTurno.Controls.Add(Me.OP24Horas)
        Me.GBTurno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTurno.Location = New System.Drawing.Point(16, 172)
        Me.GBTurno.Name = "GBTurno"
        Me.GBTurno.Size = New System.Drawing.Size(166, 67)
        Me.GBTurno.TabIndex = 42
        Me.GBTurno.TabStop = False
        Me.GBTurno.Text = "Turnos:"
        '
        'OPTurno3
        '
        Me.OPTurno3.AutoSize = True
        Me.OPTurno3.Location = New System.Drawing.Point(96, 44)
        Me.OPTurno3.Name = "OPTurno3"
        Me.OPTurno3.Size = New System.Drawing.Size(66, 18)
        Me.OPTurno3.TabIndex = 3
        Me.OPTurno3.TabStop = True
        Me.OPTurno3.Text = "Turno 3"
        Me.OPTurno3.UseVisualStyleBackColor = True
        '
        'OPTurno2
        '
        Me.OPTurno2.AutoSize = True
        Me.OPTurno2.Location = New System.Drawing.Point(7, 44)
        Me.OPTurno2.Name = "OPTurno2"
        Me.OPTurno2.Size = New System.Drawing.Size(66, 18)
        Me.OPTurno2.TabIndex = 2
        Me.OPTurno2.TabStop = True
        Me.OPTurno2.Text = "Turno 2"
        Me.OPTurno2.UseVisualStyleBackColor = True
        '
        'OPTurno1
        '
        Me.OPTurno1.AutoSize = True
        Me.OPTurno1.Location = New System.Drawing.Point(96, 25)
        Me.OPTurno1.Name = "OPTurno1"
        Me.OPTurno1.Size = New System.Drawing.Size(66, 18)
        Me.OPTurno1.TabIndex = 1
        Me.OPTurno1.TabStop = True
        Me.OPTurno1.Text = "Turno 1"
        Me.OPTurno1.UseVisualStyleBackColor = True
        '
        'OP24Horas
        '
        Me.OP24Horas.AutoSize = True
        Me.OP24Horas.Location = New System.Drawing.Point(7, 25)
        Me.OP24Horas.Name = "OP24Horas"
        Me.OP24Horas.Size = New System.Drawing.Size(72, 18)
        Me.OP24Horas.TabIndex = 0
        Me.OP24Horas.TabStop = True
        Me.OP24Horas.Text = "24 Horas"
        Me.OP24Horas.UseVisualStyleBackColor = True
        '
        'TVReportes
        '
        Me.TVReportes.Location = New System.Drawing.Point(12, 254)
        Me.TVReportes.Name = "TVReportes"
        Me.TVReportes.Size = New System.Drawing.Size(181, 109)
        Me.TVReportes.TabIndex = 41
        '
        'BCDate
        '
        Me.BCDate.Location = New System.Drawing.Point(79, 12)
        Me.BCDate.Name = "BCDate"
        Me.BCDate.Size = New System.Drawing.Size(75, 23)
        Me.BCDate.TabIndex = 40
        Me.BCDate.Text = "BCDate"
        Me.BCDate.UseVisualStyleBackColor = True
        Me.BCDate.Visible = False
        '
        'RvReportes
        '
        Me.RvReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvReportes.Location = New System.Drawing.Point(0, 0)
        Me.RvReportes.Name = "RvReportes"
        Me.RvReportes.Size = New System.Drawing.Size(941, 733)
        Me.RvReportes.TabIndex = 0
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 733)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GBTurno.ResumeLayout(False)
        Me.GBTurno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents THoraIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents TFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents THoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents TFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RvReportes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BCDate As System.Windows.Forms.Button
    Friend WithEvents TVReportes As System.Windows.Forms.TreeView
    Friend WithEvents GBTurno As System.Windows.Forms.GroupBox
    Friend WithEvents OPTurno3 As System.Windows.Forms.RadioButton
    Friend WithEvents OPTurno2 As System.Windows.Forms.RadioButton
    Friend WithEvents OPTurno1 As System.Windows.Forms.RadioButton
    Friend WithEvents OP24Horas As System.Windows.Forms.RadioButton
    'Friend WithEvents ChrColMedDataSet As ChronoSoftNet.ChrColMedDataSet
End Class
