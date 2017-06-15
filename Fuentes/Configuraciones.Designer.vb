<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuraciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuraciones))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CBBuscar = New System.Windows.Forms.ToolStripComboBox()
        Me.TBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.BImprimir = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BSalir, Me.ToolStripSeparator9, Me.BEditar, Me.ToolStripSeparator8, Me.BNuevo, Me.ToolStripSeparator5, Me.BBorrar, Me.ToolStripSeparator6, Me.BActualizar, Me.ToolStripLabel2, Me.CBBuscar, Me.TBuscar, Me.BImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(879, 25)
        Me.ToolStrip1.TabIndex = 31
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
        'BEditar
        '
        Me.BEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BEditar.Image = CType(resources.GetObject("BEditar.Image"), System.Drawing.Image)
        Me.BEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(23, 22)
        Me.BEditar.Text = "Editar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'BNuevo
        '
        Me.BNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNuevo.Image = CType(resources.GetObject("BNuevo.Image"), System.Drawing.Image)
        Me.BNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(23, 22)
        Me.BNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BBorrar
        '
        Me.BBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BBorrar.Image = CType(resources.GetObject("BBorrar.Image"), System.Drawing.Image)
        Me.BBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(23, 22)
        Me.BBorrar.Text = "Borrar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BActualizar
        '
        Me.BActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BActualizar.Image = CType(resources.GetObject("BActualizar.Image"), System.Drawing.Image)
        Me.BActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.Size = New System.Drawing.Size(23, 22)
        Me.BActualizar.Text = "Actualizar"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel2.Text = "Buscar"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBBuscar
        '
        Me.CBBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBuscar.DropDownWidth = 80
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(75, 25)
        Me.CBBuscar.ToolTipText = "Seleccione el campo a buscar"
        '
        'TBuscar
        '
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(80, 25)
        Me.TBuscar.ToolTipText = "Digite el valor a consultar"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 50)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(841, 232)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'Configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 350)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Configuraciones"
        Me.Text = "Configuraciones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CBBuscar As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents TBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
