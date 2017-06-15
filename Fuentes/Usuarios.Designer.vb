<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PanelPerm = New System.Windows.Forms.Panel()
        Me.TVUsuarios = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpComBoxUsua = New System.Windows.Forms.ComboBox()
        Me.PanNueUsua = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TCodOperario = New System.Windows.Forms.TextBox()
        Me.TCargo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.mnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.mnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.mnModificar = New System.Windows.Forms.ToolStripButton()
        Me.BImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelPerm.SuspendLayout()
        Me.PanNueUsua.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.OtrosToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PanelPerm
        '
        Me.PanelPerm.BackColor = System.Drawing.Color.Transparent
        Me.PanelPerm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelPerm.Controls.Add(Me.TVUsuarios)
        Me.PanelPerm.Enabled = False
        Me.PanelPerm.Location = New System.Drawing.Point(361, 70)
        Me.PanelPerm.Name = "PanelPerm"
        Me.PanelPerm.Size = New System.Drawing.Size(446, 280)
        Me.PanelPerm.TabIndex = 35
        '
        'TVUsuarios
        '
        Me.TVUsuarios.Location = New System.Drawing.Point(29, 18)
        Me.TVUsuarios.Name = "TVUsuarios"
        Me.TVUsuarios.Size = New System.Drawing.Size(378, 244)
        Me.TVUsuarios.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Lista de Usuarios"
        '
        'OpComBoxUsua
        '
        Me.OpComBoxUsua.FormattingEnabled = True
        Me.OpComBoxUsua.Location = New System.Drawing.Point(12, 90)
        Me.OpComBoxUsua.Name = "OpComBoxUsua"
        Me.OpComBoxUsua.Size = New System.Drawing.Size(338, 21)
        Me.OpComBoxUsua.TabIndex = 36
        '
        'PanNueUsua
        '
        Me.PanNueUsua.Controls.Add(Me.Label5)
        Me.PanNueUsua.Controls.Add(Me.TCodOperario)
        Me.PanNueUsua.Controls.Add(Me.TCargo)
        Me.PanNueUsua.Controls.Add(Me.Label4)
        Me.PanNueUsua.Controls.Add(Me.TUsuario)
        Me.PanNueUsua.Controls.Add(Me.Label3)
        Me.PanNueUsua.Controls.Add(Me.TClave)
        Me.PanNueUsua.Controls.Add(Me.Label2)
        Me.PanNueUsua.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanNueUsua.Location = New System.Drawing.Point(12, 118)
        Me.PanNueUsua.Name = "PanNueUsua"
        Me.PanNueUsua.Size = New System.Drawing.Size(338, 191)
        Me.PanNueUsua.TabIndex = 43
        Me.PanNueUsua.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Código Operario:"
        '
        'TCodOperario
        '
        Me.TCodOperario.Location = New System.Drawing.Point(115, 120)
        Me.TCodOperario.Name = "TCodOperario"
        Me.TCodOperario.ReadOnly = True
        Me.TCodOperario.Size = New System.Drawing.Size(112, 21)
        Me.TCodOperario.TabIndex = 28
        Me.TCodOperario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TCargo
        '
        Me.TCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TCargo.FormattingEnabled = True
        Me.TCargo.Location = New System.Drawing.Point(114, 51)
        Me.TCargo.Name = "TCargo"
        Me.TCargo.Size = New System.Drawing.Size(113, 23)
        Me.TCargo.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cargo:"
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(114, 20)
        Me.TUsuario.MaxLength = 20
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.ReadOnly = True
        Me.TUsuario.Size = New System.Drawing.Size(112, 21)
        Me.TUsuario.TabIndex = 22
        Me.TUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Clave:"
        '
        'TClave
        '
        Me.TClave.Location = New System.Drawing.Point(115, 85)
        Me.TClave.Name = "TClave"
        Me.TClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TClave.ReadOnly = True
        Me.TClave.Size = New System.Drawing.Size(112, 21)
        Me.TClave.TabIndex = 21
        Me.TClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Usuario:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BSalir, Me.ToolStripSeparator2, Me.mnNuevo, Me.ToolStripSeparator3, Me.mnEliminar, Me.ToolStripSeparator4, Me.mnModificar, Me.ToolStripSeparator5, Me.BImprimir, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(834, 25)
        Me.ToolStrip1.TabIndex = 44
        Me.ToolStrip1.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BCancelar
        '
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.Location = New System.Drawing.Point(168, 319)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(35, 31)
        Me.BCancelar.TabIndex = 46
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.Location = New System.Drawing.Point(127, 319)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(35, 31)
        Me.BAceptar.TabIndex = 45
        Me.BAceptar.UseVisualStyleBackColor = True
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
        'mnNuevo
        '
        Me.mnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnNuevo.Image = CType(resources.GetObject("mnNuevo.Image"), System.Drawing.Image)
        Me.mnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnNuevo.Name = "mnNuevo"
        Me.mnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.mnNuevo.Text = "Nuevo"
        '
        'mnEliminar
        '
        Me.mnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnEliminar.Image = CType(resources.GetObject("mnEliminar.Image"), System.Drawing.Image)
        Me.mnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnEliminar.Name = "mnEliminar"
        Me.mnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.mnEliminar.Text = "Eliminar"
        '
        'mnModificar
        '
        Me.mnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnModificar.Image = CType(resources.GetObject("mnModificar.Image"), System.Drawing.Image)
        Me.mnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnModificar.Name = "mnModificar"
        Me.mnModificar.Size = New System.Drawing.Size(23, 22)
        Me.mnModificar.Text = "Modificar"
        '
        'BImprimir
        '
        Me.BImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BImprimir.Image = CType(resources.GetObject("BImprimir.Image"), System.Drawing.Image)
        Me.BImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(23, 22)
        Me.BImprimir.Text = "Imprimir Listado Usuarios"
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
        Me.mnSalir.Size = New System.Drawing.Size(98, 22)
        Me.mnSalir.Text = "Salir"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Image = CType(resources.GetObject("OtrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de...."
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 379)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanNueUsua)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpComBoxUsua)
        Me.Controls.Add(Me.PanelPerm)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelPerm.ResumeLayout(False)
        Me.PanNueUsua.ResumeLayout(False)
        Me.PanNueUsua.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelPerm As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpComBoxUsua As System.Windows.Forms.ComboBox
    Friend WithEvents PanNueUsua As System.Windows.Forms.GroupBox
    Friend WithEvents TUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TClave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TCargo As System.Windows.Forms.ComboBox
    Friend WithEvents TVUsuarios As System.Windows.Forms.TreeView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TCodOperario As System.Windows.Forms.TextBox
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
End Class
