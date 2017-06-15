<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosEnLinea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosEnLinea))
        Me.SCContenedor = New System.Windows.Forms.SplitContainer()
        Me.BGrafica6 = New System.Windows.Forms.Button()
        Me.BGrafica5 = New System.Windows.Forms.Button()
        Me.BGrafica4 = New System.Windows.Forms.Button()
        Me.BGrafica3 = New System.Windows.Forms.Button()
        Me.BGrafica2 = New System.Windows.Forms.Button()
        Me.BGrafica1 = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        CType(Me.SCContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCContenedor.Panel1.SuspendLayout()
        Me.SCContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'SCContenedor
        '
        Me.SCContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SCContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCContenedor.Location = New System.Drawing.Point(0, 0)
        Me.SCContenedor.Name = "SCContenedor"
        '
        'SCContenedor.Panel1
        '
        Me.SCContenedor.Panel1.Controls.Add(Me.BGrafica6)
        Me.SCContenedor.Panel1.Controls.Add(Me.BGrafica5)
        Me.SCContenedor.Panel1.Controls.Add(Me.BGrafica4)
        Me.SCContenedor.Panel1.Controls.Add(Me.BGrafica3)
        Me.SCContenedor.Panel1.Controls.Add(Me.BGrafica2)
        Me.SCContenedor.Panel1.Controls.Add(Me.BGrafica1)
        Me.SCContenedor.Panel1.Controls.Add(Me.BSalir)
        Me.SCContenedor.Size = New System.Drawing.Size(1190, 441)
        Me.SCContenedor.SplitterDistance = 105
        Me.SCContenedor.TabIndex = 30
        '
        'BGrafica6
        '
        Me.BGrafica6.Location = New System.Drawing.Point(0, 306)
        Me.BGrafica6.Name = "BGrafica6"
        Me.BGrafica6.Size = New System.Drawing.Size(103, 50)
        Me.BGrafica6.TabIndex = 6
        Me.BGrafica6.Text = "IS6"
        Me.BGrafica6.UseVisualStyleBackColor = True
        '
        'BGrafica5
        '
        Me.BGrafica5.Location = New System.Drawing.Point(0, 255)
        Me.BGrafica5.Name = "BGrafica5"
        Me.BGrafica5.Size = New System.Drawing.Size(103, 50)
        Me.BGrafica5.TabIndex = 5
        Me.BGrafica5.Text = "TETRA"
        Me.BGrafica5.UseVisualStyleBackColor = True
        '
        'BGrafica4
        '
        Me.BGrafica4.Location = New System.Drawing.Point(0, 204)
        Me.BGrafica4.Name = "BGrafica4"
        Me.BGrafica4.Size = New System.Drawing.Size(103, 50)
        Me.BGrafica4.TabIndex = 4
        Me.BGrafica4.Text = "BUANLIR 3"
        Me.BGrafica4.UseVisualStyleBackColor = True
        '
        'BGrafica3
        '
        Me.BGrafica3.Location = New System.Drawing.Point(-2, 153)
        Me.BGrafica3.Name = "BGrafica3"
        Me.BGrafica3.Size = New System.Drawing.Size(103, 50)
        Me.BGrafica3.TabIndex = 3
        Me.BGrafica3.Text = "BUANLIR 1 Y 2"
        Me.BGrafica3.UseVisualStyleBackColor = True
        '
        'BGrafica2
        '
        Me.BGrafica2.Location = New System.Drawing.Point(-2, 102)
        Me.BGrafica2.Name = "BGrafica2"
        Me.BGrafica2.Size = New System.Drawing.Size(103, 50)
        Me.BGrafica2.TabIndex = 2
        Me.BGrafica2.Text = "ELECSTER 3"
        Me.BGrafica2.UseVisualStyleBackColor = True
        '
        'BGrafica1
        '
        Me.BGrafica1.Location = New System.Drawing.Point(-2, 51)
        Me.BGrafica1.Name = "BGrafica1"
        Me.BGrafica1.Size = New System.Drawing.Size(103, 50)
        Me.BGrafica1.TabIndex = 1
        Me.BGrafica1.Text = "ELECSTER 1 Y 2"
        Me.BGrafica1.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.Location = New System.Drawing.Point(-1, 0)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(103, 50)
        Me.BSalir.TabIndex = 0
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'DatosEnLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 441)
        Me.Controls.Add(Me.SCContenedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatosEnLinea"
        Me.Text = "Datos En Línea"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SCContenedor.Panel1.ResumeLayout(False)
        CType(Me.SCContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SCContenedor As System.Windows.Forms.SplitContainer
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BGrafica3 As System.Windows.Forms.Button
    Friend WithEvents BGrafica2 As System.Windows.Forms.Button
    Friend WithEvents BGrafica1 As System.Windows.Forms.Button
    Friend WithEvents BGrafica4 As System.Windows.Forms.Button
    Friend WithEvents BGrafica5 As System.Windows.Forms.Button
    Friend WithEvents BGrafica6 As System.Windows.Forms.Button

End Class
