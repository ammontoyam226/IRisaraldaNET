<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcercaD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AcercaD))
        Me.BOk = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TPlanta = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOk
        '
        Me.BOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BOk.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOk.ForeColor = System.Drawing.Color.Navy
        Me.BOk.Image = CType(resources.GetObject("BOk.Image"), System.Drawing.Image)
        Me.BOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BOk.Location = New System.Drawing.Point(334, 469)
        Me.BOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BOk.Name = "BOk"
        Me.BOk.Size = New System.Drawing.Size(77, 25)
        Me.BOk.TabIndex = 0
        Me.BOk.Text = "&Aceptar"
        Me.BOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(29, 43)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(200, 431)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.RichTextBox2.Location = New System.Drawing.Point(314, 222)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(139, 26)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = "Ingenio Risaralda"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(275, 311)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(217, 38)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Captura de Datos de Empacadoras y Comprobadoras"
        '
        'TPlanta
        '
        Me.TPlanta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPlanta.Location = New System.Drawing.Point(292, 390)
        Me.TPlanta.Name = "TPlanta"
        Me.TPlanta.Size = New System.Drawing.Size(228, 53)
        Me.TPlanta.TabIndex = 17
        Me.TPlanta.Text = " ---------"
        Me.TPlanta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.RichTextBox3.Location = New System.Drawing.Point(261, 128)
        Me.RichTextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(138, 28)
        Me.RichTextBox3.TabIndex = 18
        Me.RichTextBox3.Text = "Desarrollado por:"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.DarkBlue
        Me.RichTextBox5.Location = New System.Drawing.Point(272, 155)
        Me.RichTextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.Size = New System.Drawing.Size(223, 21)
        Me.RichTextBox5.TabIndex = 20
        Me.RichTextBox5.Text = "Tecnimática S.A.S. Colombia  "
        '
        'RichTextBox6
        '
        Me.RichTextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox6.ForeColor = System.Drawing.Color.DarkBlue
        Me.RichTextBox6.Location = New System.Drawing.Point(261, 200)
        Me.RichTextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.Size = New System.Drawing.Size(47, 24)
        Me.RichTextBox6.TabIndex = 21
        Me.RichTextBox6.Text = "Para:"
        '
        'RichTextBox7
        '
        Me.RichTextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox7.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox7.Location = New System.Drawing.Point(261, 290)
        Me.RichTextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.Size = New System.Drawing.Size(114, 24)
        Me.RichTextBox7.TabIndex = 22
        Me.RichTextBox7.Text = "Descripción:"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(261, 371)
        Me.RichTextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(90, 24)
        Me.RichTextBox4.TabIndex = 23
        Me.RichTextBox4.Text = "Licenciado a:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(311, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ChronoSoft.Net"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(341, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Copyright"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcercaD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BOk
        Me.ClientSize = New System.Drawing.Size(537, 510)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox7)
        Me.Controls.Add(Me.RichTextBox6)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.BOk)
        Me.Controls.Add(Me.TPlanta)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AcercaD"
        Me.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerda de..."
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BOk As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TPlanta As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
