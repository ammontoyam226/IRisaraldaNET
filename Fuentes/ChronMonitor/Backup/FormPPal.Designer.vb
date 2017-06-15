<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPPal
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPPal))
        Me.Notificador = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnAbrir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnCerrar = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.THora = New System.Windows.Forms.ToolStripStatusLabel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TSeg = New System.Windows.Forms.TextBox
        Me.TFrecuencia = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Notificador
        '
        Me.Notificador.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Notificador.Icon = CType(resources.GetObject("Notificador.Icon"), System.Drawing.Icon)
        Me.Notificador.Text = "Chronos Monitor"
        Me.Notificador.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAbrir, Me.mnCerrar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 48)
        '
        'mnAbrir
        '
        Me.mnAbrir.Image = CType(resources.GetObject("mnAbrir.Image"), System.Drawing.Image)
        Me.mnAbrir.Name = "mnAbrir"
        Me.mnAbrir.Size = New System.Drawing.Size(116, 22)
        Me.mnAbrir.Text = "&Abrir"
        '
        'mnCerrar
        '
        Me.mnCerrar.Image = CType(resources.GetObject("mnCerrar.Image"), System.Drawing.Image)
        Me.mnCerrar.Name = "mnCerrar"
        Me.mnCerrar.Size = New System.Drawing.Size(116, 22)
        Me.mnCerrar.Text = "&Cerrar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar, Me.THora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 92)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBar
        '
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'THora
        '
        Me.THora.Name = "THora"
        Me.THora.Size = New System.Drawing.Size(55, 17)
        Me.THora.Text = "HH:mm:ss"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(243, 65)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Atención:" & Global.Microsoft.VisualBasic.ChrW(10) & "Este Programa abre automáticamente" & Global.Microsoft.VisualBasic.ChrW(10) & "ChronoSoft en caso que se haya cerra" & _
            "do" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TSeg)
        Me.Panel1.Controls.Add(Me.TFrecuencia)
        Me.Panel1.Location = New System.Drawing.Point(261, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 69)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Segundos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Frecuencia de Chequeo"
        '
        'TSeg
        '
        Me.TSeg.Location = New System.Drawing.Point(130, 29)
        Me.TSeg.Name = "TSeg"
        Me.TSeg.Size = New System.Drawing.Size(47, 20)
        Me.TSeg.TabIndex = 1
        '
        'TFrecuencia
        '
        Me.TFrecuencia.Location = New System.Drawing.Point(130, 3)
        Me.TFrecuencia.Name = "TFrecuencia"
        Me.TFrecuencia.Size = New System.Drawing.Size(47, 20)
        Me.TFrecuencia.TabIndex = 0
        Me.TFrecuencia.Text = "60"
        '
        'FormPPal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 114)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPPal"
        Me.Text = "Monitor de ChronoSoft"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Notificador As System.Windows.Forms.NotifyIcon
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents THora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TSeg As System.Windows.Forms.TextBox
    Friend WithEvents TFrecuencia As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCerrar As System.Windows.Forms.ToolStripMenuItem

End Class
