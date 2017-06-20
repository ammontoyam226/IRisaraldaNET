<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aviso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aviso))
        Me.TimIni = New System.Windows.Forms.Timer(Me.components)
        Me.TimUnload = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.TIntervalo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TimIni
        '
        Me.TimIni.Enabled = True
        '
        'TimUnload
        '
        Me.TimUnload.Interval = 10000
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 108)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "------"
        '
        'BAceptar
        '
        Me.BAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.Location = New System.Drawing.Point(214, 161)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(40, 36)
        Me.BAceptar.TabIndex = 23
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'TIntervalo
        '
        Me.TIntervalo.Location = New System.Drawing.Point(27, 177)
        Me.TIntervalo.Name = "TIntervalo"
        Me.TIntervalo.Size = New System.Drawing.Size(100, 20)
        Me.TIntervalo.TabIndex = 24
        Me.TIntervalo.Text = "6000"
        Me.TIntervalo.Visible = False
        '
        'Aviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 204)
        Me.Controls.Add(Me.TIntervalo)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aviso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mensaje Importante!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimIni As System.Windows.Forms.Timer
    Friend WithEvents TimUnload As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents TIntervalo As System.Windows.Forms.TextBox
End Class
