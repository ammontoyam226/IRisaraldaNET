<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltroFecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FiltroFecha))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.THoraIni = New System.Windows.Forms.DateTimePicker()
        Me.TFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.LMensaje = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BCancelar)
        Me.GroupBox1.Controls.Add(Me.BAceptar)
        Me.GroupBox1.Controls.Add(Me.LMensaje)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de Fechas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.THoraIni)
        Me.GroupBox2.Controls.Add(Me.TFechaIni)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 96)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Inicial:"
        '
        'THoraIni
        '
        Me.THoraIni.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.THoraIni.CustomFormat = "HH:mm"
        Me.THoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.THoraIni.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.THoraIni.Location = New System.Drawing.Point(44, 60)
        Me.THoraIni.Name = "THoraIni"
        Me.THoraIni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.THoraIni.ShowUpDown = True
        Me.THoraIni.Size = New System.Drawing.Size(82, 20)
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
        'LMensaje
        '
        Me.LMensaje.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMensaje.Location = New System.Drawing.Point(210, 34)
        Me.LMensaje.Name = "LMensaje"
        Me.LMensaje.Size = New System.Drawing.Size(165, 122)
        Me.LMensaje.TabIndex = 39
        Me.LMensaje.Text = "En la gráfica de ensaque solo se mostrará los datos en un rango de una hora"
        Me.LMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BCancelar
        '
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.Location = New System.Drawing.Point(212, 154)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(40, 36)
        Me.BCancelar.TabIndex = 41
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.Location = New System.Drawing.Point(166, 154)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(40, 36)
        Me.BAceptar.TabIndex = 40
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'FiltroFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FiltroFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtrar fecha de inicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LMensaje As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents THoraIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents TFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
End Class
