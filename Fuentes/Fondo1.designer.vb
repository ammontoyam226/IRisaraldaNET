<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fondo1
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fondo1))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SCEscritorio = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.LAlarma = New System.Windows.Forms.Label()
        Me.FRefrescaDG = New System.Windows.Forms.Button()
        Me.DGAlarmas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BCambioUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BReportes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BProductos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.BMaquinas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.BAlarma = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BServidor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BDatosEnLinea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BBaseDatos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TPlanta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimSeg = New System.Windows.Forms.Timer(Me.components)
        Me.TimRestore = New System.Windows.Forms.Timer(Me.components)
        Me.BConfiguraciones = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.SCEscritorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCEscritorio.Panel1.SuspendLayout()
        Me.SCEscritorio.Panel2.SuspendLayout()
        Me.SCEscritorio.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DGAlarmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.SCEscritorio)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ToolStrip)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TPlanta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 701)
        Me.Panel1.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.Panel1, "Programa de Producción")
        '
        'SCEscritorio
        '
        Me.SCEscritorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SCEscritorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCEscritorio.Location = New System.Drawing.Point(104, 0)
        Me.SCEscritorio.Name = "SCEscritorio"
        '
        'SCEscritorio.Panel1
        '
        Me.SCEscritorio.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SCEscritorio.Panel2
        '
        Me.SCEscritorio.Panel2.Controls.Add(Me.PictureBox2)
        Me.SCEscritorio.Panel2.Controls.Add(Me.Label7)
        Me.SCEscritorio.Panel2.Controls.Add(Me.Label8)
        Me.SCEscritorio.Panel2.Controls.Add(Me.Label9)
        Me.SCEscritorio.Panel2.Controls.Add(Me.Label10)
        Me.SCEscritorio.Panel2.Controls.Add(Me.Label11)
        Me.SCEscritorio.Panel2.Controls.Add(Me.Label12)
        Me.SCEscritorio.Size = New System.Drawing.Size(951, 701)
        Me.SCEscritorio.SplitterDistance = 568
        Me.SCEscritorio.TabIndex = 26
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.LAlarma)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.FRefrescaDG)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DGAlarmas)
        Me.SplitContainer2.Size = New System.Drawing.Size(566, 699)
        Me.SplitContainer2.SplitterDistance = 91
        Me.SplitContainer2.TabIndex = 0
        '
        'LAlarma
        '
        Me.LAlarma.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LAlarma.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LAlarma.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAlarma.ForeColor = System.Drawing.Color.DarkBlue
        Me.LAlarma.Location = New System.Drawing.Point(0, 0)
        Me.LAlarma.Name = "LAlarma"
        Me.LAlarma.Size = New System.Drawing.Size(566, 91)
        Me.LAlarma.TabIndex = 23
        Me.LAlarma.Text = "PANEL DE ALARMAS"
        Me.LAlarma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.LAlarma, "Haga clic para cerrar")
        '
        'FRefrescaDG
        '
        Me.FRefrescaDG.Location = New System.Drawing.Point(435, 73)
        Me.FRefrescaDG.Name = "FRefrescaDG"
        Me.FRefrescaDG.Size = New System.Drawing.Size(75, 23)
        Me.FRefrescaDG.TabIndex = 3
        Me.FRefrescaDG.Text = "FRefrescaDG"
        Me.FRefrescaDG.UseVisualStyleBackColor = True
        Me.FRefrescaDG.Visible = False
        '
        'DGAlarmas
        '
        Me.DGAlarmas.AllowUserToAddRows = False
        Me.DGAlarmas.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue
        Me.DGAlarmas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlarmas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGAlarmas.ColumnHeadersHeight = 40
        Me.DGAlarmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGAlarmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.OldLace
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAlarmas.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGAlarmas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGAlarmas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGAlarmas.EnableHeadersVisualStyles = False
        Me.DGAlarmas.Location = New System.Drawing.Point(0, 0)
        Me.DGAlarmas.Name = "DGAlarmas"
        Me.DGAlarmas.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlarmas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGAlarmas.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGAlarmas.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGAlarmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGAlarmas.Size = New System.Drawing.Size(566, 604)
        Me.DGAlarmas.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Fecha"
        Me.Column1.HeaderText = "Fecha"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Alarma"
        Me.Column2.HeaderText = "Mensaje"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 500
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(71, 307)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(256, 97)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(160, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "V.17.6.12"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(123, 508)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Desarrollado por"
        Me.ToolTip.SetToolTip(Me.Label8, "ChronoSoft Net Tecnimática Ltda")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(94, 524)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Tecnimática S.A.S"
        Me.ToolTip.SetToolTip(Me.Label9, "ChronoSoft Net Tecnimática Ltda")
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1, 462)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(357, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "-"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(50, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(277, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Sistema de captura de datos de pesaje"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(0, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(327, 55)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "   ChronoSoft   "
        Me.ToolTip.SetToolTip(Me.Label12, "ChronoSoft Net Tecniática Ltda")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(459, 319)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 153)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.BSalir, Me.ToolStripSeparator6, Me.BCambioUsuario, Me.ToolStripSeparator9, Me.BReportes, Me.ToolStripSeparator12, Me.BUsuarios, Me.ToolStripSeparator13, Me.BProductos, Me.ToolStripSeparator14, Me.BMaquinas, Me.ToolStripSeparator20, Me.BAlarma, Me.ToolStripSeparator1, Me.BServidor, Me.ToolStripSeparator2, Me.BDatosEnLinea, Me.BBaseDatos, Me.ToolStripSeparator4, Me.BConfiguraciones, Me.ToolStripSeparator3})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(104, 701)
        Me.ToolStrip.TabIndex = 24
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(101, 6)
        '
        'BSalir
        '
        Me.BSalir.AutoSize = False
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BSalir.ImageTransparentColor = System.Drawing.Color.Black
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(103, 50)
        Me.BSalir.Text = "Salir"
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(101, 6)
        '
        'BCambioUsuario
        '
        Me.BCambioUsuario.AutoSize = False
        Me.BCambioUsuario.Image = CType(resources.GetObject("BCambioUsuario.Image"), System.Drawing.Image)
        Me.BCambioUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BCambioUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BCambioUsuario.Name = "BCambioUsuario"
        Me.BCambioUsuario.Size = New System.Drawing.Size(103, 50)
        Me.BCambioUsuario.Text = "Cambio Usuario"
        Me.BCambioUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(101, 6)
        '
        'BReportes
        '
        Me.BReportes.AutoSize = False
        Me.BReportes.Image = CType(resources.GetObject("BReportes.Image"), System.Drawing.Image)
        Me.BReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BReportes.Name = "BReportes"
        Me.BReportes.Size = New System.Drawing.Size(103, 50)
        Me.BReportes.Text = "Reportes"
        Me.BReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BReportes.ToolTipText = "Reportes"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(101, 6)
        '
        'BUsuarios
        '
        Me.BUsuarios.AutoSize = False
        Me.BUsuarios.Image = CType(resources.GetObject("BUsuarios.Image"), System.Drawing.Image)
        Me.BUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Size = New System.Drawing.Size(103, 50)
        Me.BUsuarios.Text = "Usuarios"
        Me.BUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(101, 6)
        '
        'BProductos
        '
        Me.BProductos.AutoSize = False
        Me.BProductos.Image = CType(resources.GetObject("BProductos.Image"), System.Drawing.Image)
        Me.BProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BProductos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Size = New System.Drawing.Size(103, 50)
        Me.BProductos.Text = "Productos"
        Me.BProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(101, 6)
        '
        'BMaquinas
        '
        Me.BMaquinas.AutoSize = False
        Me.BMaquinas.Image = CType(resources.GetObject("BMaquinas.Image"), System.Drawing.Image)
        Me.BMaquinas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BMaquinas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BMaquinas.Name = "BMaquinas"
        Me.BMaquinas.Size = New System.Drawing.Size(103, 50)
        Me.BMaquinas.Text = "Máquinas"
        Me.BMaquinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(101, 6)
        '
        'BAlarma
        '
        Me.BAlarma.AutoSize = False
        Me.BAlarma.Image = CType(resources.GetObject("BAlarma.Image"), System.Drawing.Image)
        Me.BAlarma.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BAlarma.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BAlarma.Name = "BAlarma"
        Me.BAlarma.Size = New System.Drawing.Size(103, 50)
        Me.BAlarma.Text = "Alarma"
        Me.BAlarma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(101, 6)
        '
        'BServidor
        '
        Me.BServidor.AutoSize = False
        Me.BServidor.Image = CType(resources.GetObject("BServidor.Image"), System.Drawing.Image)
        Me.BServidor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BServidor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BServidor.Name = "BServidor"
        Me.BServidor.Size = New System.Drawing.Size(103, 50)
        Me.BServidor.Text = "Servidor Balanzas"
        Me.BServidor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(101, 6)
        '
        'BDatosEnLinea
        '
        Me.BDatosEnLinea.AutoSize = False
        Me.BDatosEnLinea.Image = CType(resources.GetObject("BDatosEnLinea.Image"), System.Drawing.Image)
        Me.BDatosEnLinea.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BDatosEnLinea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BDatosEnLinea.Name = "BDatosEnLinea"
        Me.BDatosEnLinea.Size = New System.Drawing.Size(103, 50)
        Me.BDatosEnLinea.Text = "Datos En Línea"
        Me.BDatosEnLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(101, 6)
        '
        'BBaseDatos
        '
        Me.BBaseDatos.AutoSize = False
        Me.BBaseDatos.Image = CType(resources.GetObject("BBaseDatos.Image"), System.Drawing.Image)
        Me.BBaseDatos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BBaseDatos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BBaseDatos.Name = "BBaseDatos"
        Me.BBaseDatos.Size = New System.Drawing.Size(103, 50)
        Me.BBaseDatos.Text = "Base de Datos"
        Me.BBaseDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(101, 6)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(506, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "V.16.12.1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(475, 542)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Desarrollado por"
        Me.ToolTip.SetToolTip(Me.Label3, "ChronoSoft Net Tecnimática Ltda")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(446, 558)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tecnimática Ltda."
        Me.ToolTip.SetToolTip(Me.Label4, "ChronoSoft Net Tecnimática Ltda")
        '
        'TPlanta
        '
        Me.TPlanta.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPlanta.ForeColor = System.Drawing.Color.White
        Me.TPlanta.Location = New System.Drawing.Point(346, 496)
        Me.TPlanta.Name = "TPlanta"
        Me.TPlanta.Size = New System.Drawing.Size(369, 17)
        Me.TPlanta.TabIndex = 16
        Me.TPlanta.Text = "-"
        Me.TPlanta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(396, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Sistema de captura de datos de pesaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(354, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 55)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "   ChronoSoft   "
        Me.ToolTip.SetToolTip(Me.Label1, "ChronoSoft Net Tecniática Ltda")
        '
        'TimSeg
        '
        Me.TimSeg.Interval = 1000
        '
        'TimRestore
        '
        Me.TimRestore.Interval = 51111
        '
        'BConfiguraciones
        '
        Me.BConfiguraciones.AutoSize = False
        Me.BConfiguraciones.Image = CType(resources.GetObject("BConfiguraciones.Image"), System.Drawing.Image)
        Me.BConfiguraciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BConfiguraciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BConfiguraciones.Name = "BConfiguraciones"
        Me.BConfiguraciones.Size = New System.Drawing.Size(103, 50)
        Me.BConfiguraciones.Text = "Base de Datos"
        Me.BConfiguraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Fondo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1055, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Fondo1"
        Me.Text = "ChronoSoft Net"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SCEscritorio.Panel1.ResumeLayout(False)
        Me.SCEscritorio.Panel2.ResumeLayout(False)
        Me.SCEscritorio.Panel2.PerformLayout()
        CType(Me.SCEscritorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCEscritorio.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DGAlarmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TimSeg As System.Windows.Forms.Timer
    Friend WithEvents TimRestore As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TPlanta As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BProductos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BMaquinas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BAlarma As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BReportes As System.Windows.Forms.ToolStripButton
    Friend WithEvents BUsuarios As System.Windows.Forms.ToolStripButton
    Friend WithEvents BServidor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BDatosEnLinea As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SCEscritorio As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LAlarma As System.Windows.Forms.Label
    Friend WithEvents FRefrescaDG As System.Windows.Forms.Button
    Friend WithEvents DGAlarmas As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BBaseDatos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BCambioUsuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BConfiguraciones As System.Windows.Forms.ToolStripButton

End Class
