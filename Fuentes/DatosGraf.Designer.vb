<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosGraf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosGraf))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TMensaje = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TCodProd = New System.Windows.Forms.TextBox()
        Me.TNomProd = New System.Windows.Forms.TextBox()
        Me.TPeso = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TPesoReal = New System.Windows.Forms.Label()
        Me.TPresKg = New System.Windows.Forms.TextBox()
        Me.TProm = New System.Windows.Forms.TextBox()
        Me.TMaquina = New System.Windows.Forms.TextBox()
        Me.TFecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBascula = New System.Windows.Forms.TextBox()
        Me.TID = New System.Windows.Forms.TextBox()
        Me.TMenSacChK = New System.Windows.Forms.Label()
        Me.BGrafEnsac = New System.Windows.Forms.Button()
        Me.BGrafRep = New System.Windows.Forms.Button()
        Me.DGPesos = New System.Windows.Forms.DataGridView()
        Me.clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGPesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BSalir, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(358, 25)
        Me.ToolStrip1.TabIndex = 38
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
        'TMensaje
        '
        Me.TMensaje.AutoSize = True
        Me.TMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMensaje.Location = New System.Drawing.Point(37, 29)
        Me.TMensaje.Name = "TMensaje"
        Me.TMensaje.Size = New System.Drawing.Size(302, 13)
        Me.TMensaje.TabIndex = 40
        Me.TMensaje.Text = "Peso de los sacos Programados para ser Graficados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Producto:"
        '
        'TCodProd
        '
        Me.TCodProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TCodProd.Location = New System.Drawing.Point(32, 72)
        Me.TCodProd.Name = "TCodProd"
        Me.TCodProd.Size = New System.Drawing.Size(100, 20)
        Me.TCodProd.TabIndex = 42
        '
        'TNomProd
        '
        Me.TNomProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TNomProd.Location = New System.Drawing.Point(32, 98)
        Me.TNomProd.Name = "TNomProd"
        Me.TNomProd.Size = New System.Drawing.Size(201, 20)
        Me.TNomProd.TabIndex = 43
        '
        'TPeso
        '
        Me.TPeso.AutoSize = True
        Me.TPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPeso.Location = New System.Drawing.Point(29, 139)
        Me.TPeso.Name = "TPeso"
        Me.TPeso.Size = New System.Drawing.Size(44, 13)
        Me.TPeso.TabIndex = 44
        Me.TPeso.Text = "PresKg:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Máquina:"
        '
        'TPesoReal
        '
        Me.TPesoReal.AutoSize = True
        Me.TPesoReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoReal.Location = New System.Drawing.Point(29, 163)
        Me.TPesoReal.Name = "TPesoReal"
        Me.TPesoReal.Size = New System.Drawing.Size(54, 13)
        Me.TPesoReal.TabIndex = 47
        Me.TPesoReal.Text = "Promedio:"
        '
        'TPresKg
        '
        Me.TPresKg.Location = New System.Drawing.Point(109, 132)
        Me.TPresKg.Name = "TPresKg"
        Me.TPresKg.Size = New System.Drawing.Size(71, 20)
        Me.TPresKg.TabIndex = 48
        Me.TPresKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TProm
        '
        Me.TProm.Location = New System.Drawing.Point(109, 158)
        Me.TProm.Name = "TProm"
        Me.TProm.Size = New System.Drawing.Size(71, 20)
        Me.TProm.TabIndex = 49
        Me.TProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TMaquina
        '
        Me.TMaquina.Location = New System.Drawing.Point(109, 184)
        Me.TMaquina.Name = "TMaquina"
        Me.TMaquina.Size = New System.Drawing.Size(71, 20)
        Me.TMaquina.TabIndex = 50
        Me.TMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TFecha
        '
        Me.TFecha.Location = New System.Drawing.Point(109, 210)
        Me.TFecha.Name = "TFecha"
        Me.TFecha.Size = New System.Drawing.Size(100, 20)
        Me.TFecha.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(186, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Kg"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(187, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Kg"
        '
        'TBascula
        '
        Me.TBascula.Location = New System.Drawing.Point(270, 175)
        Me.TBascula.Name = "TBascula"
        Me.TBascula.Size = New System.Drawing.Size(71, 20)
        Me.TBascula.TabIndex = 55
        Me.TBascula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TBascula.Visible = False
        '
        'TID
        '
        Me.TID.Location = New System.Drawing.Point(270, 202)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(71, 20)
        Me.TID.TabIndex = 56
        Me.TID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TID.Visible = False
        '
        'TMenSacChK
        '
        Me.TMenSacChK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMenSacChK.ForeColor = System.Drawing.Color.Red
        Me.TMenSacChK.Location = New System.Drawing.Point(40, 245)
        Me.TMenSacChK.Name = "TMenSacChK"
        Me.TMenSacChK.Size = New System.Drawing.Size(302, 44)
        Me.TMenSacChK.TabIndex = 57
        Me.TMenSacChK.Text = "El punto seleccionado de la Grafica equivale a un saco Chequeado, en donde el pro" & _
    "medio es el peso del saco."
        Me.TMenSacChK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BGrafEnsac
        '
        Me.BGrafEnsac.Location = New System.Drawing.Point(267, 125)
        Me.BGrafEnsac.Name = "BGrafEnsac"
        Me.BGrafEnsac.Size = New System.Drawing.Size(75, 23)
        Me.BGrafEnsac.TabIndex = 58
        Me.BGrafEnsac.Text = "BGrafEnsac"
        Me.BGrafEnsac.UseVisualStyleBackColor = True
        Me.BGrafEnsac.Visible = False
        '
        'BGrafRep
        '
        Me.BGrafRep.Location = New System.Drawing.Point(267, 153)
        Me.BGrafRep.Name = "BGrafRep"
        Me.BGrafRep.Size = New System.Drawing.Size(75, 23)
        Me.BGrafRep.TabIndex = 59
        Me.BGrafRep.Text = "BGrafRep"
        Me.BGrafRep.UseVisualStyleBackColor = True
        Me.BGrafRep.Visible = False
        '
        'DGPesos
        '
        Me.DGPesos.AllowUserToAddRows = False
        Me.DGPesos.AllowUserToDeleteRows = False
        Me.DGPesos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        Me.DGPesos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGPesos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPesos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clasificacion})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPesos.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGPesos.EnableHeadersVisualStyles = False
        Me.DGPesos.Location = New System.Drawing.Point(250, 87)
        Me.DGPesos.Name = "DGPesos"
        Me.DGPesos.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGPesos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGPesos.RowHeadersVisible = False
        Me.DGPesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGPesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPesos.Size = New System.Drawing.Size(79, 143)
        Me.DGPesos.TabIndex = 60
        '
        'clasificacion
        '
        Me.clasificacion.DataPropertyName = "Peso"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.clasificacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.clasificacion.HeaderText = "Pesos"
        Me.clasificacion.Name = "clasificacion"
        Me.clasificacion.ReadOnly = True
        Me.clasificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clasificacion.Width = 60
        '
        'DatosGraf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.BGrafRep)
        Me.Controls.Add(Me.BGrafEnsac)
        Me.Controls.Add(Me.TMenSacChK)
        Me.Controls.Add(Me.TID)
        Me.Controls.Add(Me.TBascula)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TFecha)
        Me.Controls.Add(Me.TMaquina)
        Me.Controls.Add(Me.TProm)
        Me.Controls.Add(Me.TPresKg)
        Me.Controls.Add(Me.TPesoReal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TPeso)
        Me.Controls.Add(Me.TNomProd)
        Me.Controls.Add(Me.TCodProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TMensaje)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DGPesos)
        Me.Name = "DatosGraf"
        Me.Text = "Datos Saco Graficado"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGPesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TMensaje As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TCodProd As System.Windows.Forms.TextBox
    Friend WithEvents TNomProd As System.Windows.Forms.TextBox
    Friend WithEvents TPeso As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TPesoReal As System.Windows.Forms.Label
    Friend WithEvents TPresKg As System.Windows.Forms.TextBox
    Friend WithEvents TProm As System.Windows.Forms.TextBox
    Friend WithEvents TMaquina As System.Windows.Forms.TextBox
    Friend WithEvents TFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBascula As System.Windows.Forms.TextBox
    Friend WithEvents TID As System.Windows.Forms.TextBox
    Friend WithEvents TMenSacChK As System.Windows.Forms.Label
    Friend WithEvents BGrafEnsac As System.Windows.Forms.Button
    Friend WithEvents BGrafRep As System.Windows.Forms.Button
    Friend WithEvents DGPesos As System.Windows.Forms.DataGridView
    Friend WithEvents clasificacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
