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
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CBBuscar = New System.Windows.Forms.ToolStripComboBox()
        Me.TBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.TLPConfig = New System.Windows.Forms.TableLayoutPanel()
        Me.TMinRep4 = New System.Windows.Forms.TextBox()
        Me.TMinRep3 = New System.Windows.Forms.TextBox()
        Me.TMinRep2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TSacGrafEnsc2 = New System.Windows.Forms.TextBox()
        Me.TSacGrafEnsc1 = New System.Windows.Forms.TextBox()
        Me.TNoMuestrasEnsc4 = New System.Windows.Forms.TextBox()
        Me.TMinRep1 = New System.Windows.Forms.TextBox()
        Me.TNoMuestrasEnsc3 = New System.Windows.Forms.TextBox()
        Me.TSacGrafEnsc4 = New System.Windows.Forms.TextBox()
        Me.TNoMuestrasEnsc2 = New System.Windows.Forms.TextBox()
        Me.TSacGrafEnsc3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNoMuestrasEnsc1 = New System.Windows.Forms.TextBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.ToolStripButton()
        Me.BEditar = New System.Windows.Forms.ToolStripButton()
        Me.BNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BBorrar = New System.Windows.Forms.ToolStripButton()
        Me.BActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.BImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.TLPConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BSalir, Me.ToolStripSeparator9, Me.BEditar, Me.ToolStripSeparator8, Me.BNuevo, Me.ToolStripSeparator5, Me.BBorrar, Me.ToolStripSeparator6, Me.BActualizar, Me.ToolStripLabel2, Me.CBBuscar, Me.TBuscar, Me.BImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 25)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
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
        'TLPConfig
        '
        Me.TLPConfig.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLPConfig.ColumnCount = 4
        Me.TLPConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TLPConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TLPConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TLPConfig.Controls.Add(Me.TMinRep4, 3, 5)
        Me.TLPConfig.Controls.Add(Me.TMinRep3, 3, 4)
        Me.TLPConfig.Controls.Add(Me.TMinRep2, 3, 3)
        Me.TLPConfig.Controls.Add(Me.Label12, 2, 4)
        Me.TLPConfig.Controls.Add(Me.Label11, 2, 5)
        Me.TLPConfig.Controls.Add(Me.Label10, 2, 3)
        Me.TLPConfig.Controls.Add(Me.Label9, 2, 2)
        Me.TLPConfig.Controls.Add(Me.TSacGrafEnsc2, 1, 5)
        Me.TLPConfig.Controls.Add(Me.TSacGrafEnsc1, 1, 4)
        Me.TLPConfig.Controls.Add(Me.TNoMuestrasEnsc4, 1, 3)
        Me.TLPConfig.Controls.Add(Me.TMinRep1, 3, 2)
        Me.TLPConfig.Controls.Add(Me.TNoMuestrasEnsc3, 1, 2)
        Me.TLPConfig.Controls.Add(Me.TSacGrafEnsc4, 3, 1)
        Me.TLPConfig.Controls.Add(Me.TNoMuestrasEnsc2, 1, 1)
        Me.TLPConfig.Controls.Add(Me.TSacGrafEnsc3, 3, 0)
        Me.TLPConfig.Controls.Add(Me.Label8, 2, 1)
        Me.TLPConfig.Controls.Add(Me.Label7, 2, 0)
        Me.TLPConfig.Controls.Add(Me.Label6, 0, 5)
        Me.TLPConfig.Controls.Add(Me.Label5, 0, 4)
        Me.TLPConfig.Controls.Add(Me.Label4, 0, 3)
        Me.TLPConfig.Controls.Add(Me.Label3, 0, 2)
        Me.TLPConfig.Controls.Add(Me.Label2, 0, 1)
        Me.TLPConfig.Controls.Add(Me.Label1, 0, 0)
        Me.TLPConfig.Controls.Add(Me.TNoMuestrasEnsc1, 1, 0)
        Me.TLPConfig.Location = New System.Drawing.Point(12, 50)
        Me.TLPConfig.Name = "TLPConfig"
        Me.TLPConfig.RowCount = 6
        Me.TLPConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLPConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLPConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLPConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLPConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLPConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLPConfig.Size = New System.Drawing.Size(708, 195)
        Me.TLPConfig.TabIndex = 32
        '
        'TMinRep4
        '
        Me.TMinRep4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TMinRep4.Location = New System.Drawing.Point(646, 171)
        Me.TMinRep4.Name = "TMinRep4"
        Me.TMinRep4.Size = New System.Drawing.Size(58, 20)
        Me.TMinRep4.TabIndex = 23
        Me.TMinRep4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TMinRep3
        '
        Me.TMinRep3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TMinRep3.Location = New System.Drawing.Point(646, 137)
        Me.TMinRep3.Name = "TMinRep3"
        Me.TMinRep3.Size = New System.Drawing.Size(58, 20)
        Me.TMinRep3.TabIndex = 22
        Me.TMinRep3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TMinRep2
        '
        Me.TMinRep2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TMinRep2.Location = New System.Drawing.Point(646, 105)
        Me.TMinRep2.Name = "TMinRep2"
        Me.TMinRep2.Size = New System.Drawing.Size(58, 20)
        Me.TMinRep2.TabIndex = 21
        Me.TMinRep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(355, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(284, 14)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Tiempo de Muestreo de Sacos Comprobadora 3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(355, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(284, 14)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Tiempo de Muestreo de Sacos Comprobadora 4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(355, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(284, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tiempo de Muestreo de Sacos Comprobadora 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(355, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(284, 14)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tiempo de Muestreo de Sacos Comprobadora 1"
        '
        'TSacGrafEnsc2
        '
        Me.TSacGrafEnsc2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TSacGrafEnsc2.Location = New System.Drawing.Point(295, 171)
        Me.TSacGrafEnsc2.Name = "TSacGrafEnsc2"
        Me.TSacGrafEnsc2.Size = New System.Drawing.Size(53, 20)
        Me.TSacGrafEnsc2.TabIndex = 16
        Me.TSacGrafEnsc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSacGrafEnsc1
        '
        Me.TSacGrafEnsc1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TSacGrafEnsc1.Location = New System.Drawing.Point(295, 137)
        Me.TSacGrafEnsc1.Name = "TSacGrafEnsc1"
        Me.TSacGrafEnsc1.Size = New System.Drawing.Size(53, 20)
        Me.TSacGrafEnsc1.TabIndex = 15
        Me.TSacGrafEnsc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TNoMuestrasEnsc4
        '
        Me.TNoMuestrasEnsc4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TNoMuestrasEnsc4.Location = New System.Drawing.Point(295, 105)
        Me.TNoMuestrasEnsc4.Name = "TNoMuestrasEnsc4"
        Me.TNoMuestrasEnsc4.Size = New System.Drawing.Size(53, 20)
        Me.TNoMuestrasEnsc4.TabIndex = 14
        Me.TNoMuestrasEnsc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TMinRep1
        '
        Me.TMinRep1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TMinRep1.Location = New System.Drawing.Point(646, 73)
        Me.TMinRep1.Name = "TMinRep1"
        Me.TMinRep1.Size = New System.Drawing.Size(58, 20)
        Me.TMinRep1.TabIndex = 13
        Me.TMinRep1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TNoMuestrasEnsc3
        '
        Me.TNoMuestrasEnsc3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TNoMuestrasEnsc3.Location = New System.Drawing.Point(295, 73)
        Me.TNoMuestrasEnsc3.Name = "TNoMuestrasEnsc3"
        Me.TNoMuestrasEnsc3.Size = New System.Drawing.Size(53, 20)
        Me.TNoMuestrasEnsc3.TabIndex = 12
        Me.TNoMuestrasEnsc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSacGrafEnsc4
        '
        Me.TSacGrafEnsc4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TSacGrafEnsc4.Location = New System.Drawing.Point(646, 41)
        Me.TSacGrafEnsc4.Name = "TSacGrafEnsc4"
        Me.TSacGrafEnsc4.Size = New System.Drawing.Size(58, 20)
        Me.TSacGrafEnsc4.TabIndex = 11
        Me.TSacGrafEnsc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TNoMuestrasEnsc2
        '
        Me.TNoMuestrasEnsc2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TNoMuestrasEnsc2.Location = New System.Drawing.Point(295, 41)
        Me.TNoMuestrasEnsc2.Name = "TNoMuestrasEnsc2"
        Me.TNoMuestrasEnsc2.Size = New System.Drawing.Size(53, 20)
        Me.TNoMuestrasEnsc2.TabIndex = 10
        Me.TNoMuestrasEnsc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSacGrafEnsc3
        '
        Me.TSacGrafEnsc3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TSacGrafEnsc3.Location = New System.Drawing.Point(646, 9)
        Me.TSacGrafEnsc3.Name = "TSacGrafEnsc3"
        Me.TSacGrafEnsc3.Size = New System.Drawing.Size(58, 20)
        Me.TSacGrafEnsc3.TabIndex = 9
        Me.TSacGrafEnsc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(355, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Sacos a Graficar Ensc. 4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(355, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sacos a Graficar Ensc. 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sacos a Graficar Ensc. 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(284, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sacos a Graficar Ensc. 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Muestras a Comprobar en Ensc. 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Muestras a Comprobar en Ensc. 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Muestras a Comprobar en Ensc. 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Muestras a Comprobar en Ensc. 1"
        '
        'TNoMuestrasEnsc1
        '
        Me.TNoMuestrasEnsc1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TNoMuestrasEnsc1.Location = New System.Drawing.Point(295, 9)
        Me.TNoMuestrasEnsc1.Name = "TNoMuestrasEnsc1"
        Me.TNoMuestrasEnsc1.Size = New System.Drawing.Size(53, 20)
        Me.TNoMuestrasEnsc1.TabIndex = 1
        Me.TNoMuestrasEnsc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BCancelar
        '
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.Location = New System.Drawing.Point(375, 280)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(35, 31)
        Me.BCancelar.TabIndex = 34
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.Location = New System.Drawing.Point(334, 280)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(35, 31)
        Me.BAceptar.TabIndex = 33
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
        'BEditar
        '
        Me.BEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BEditar.Image = CType(resources.GetObject("BEditar.Image"), System.Drawing.Image)
        Me.BEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(23, 22)
        Me.BEditar.Text = "Editar"
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
        'BBorrar
        '
        Me.BBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BBorrar.Image = CType(resources.GetObject("BBorrar.Image"), System.Drawing.Image)
        Me.BBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(23, 22)
        Me.BBorrar.Text = "Borrar"
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
        'BImprimir
        '
        Me.BImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BImprimir.Image = CType(resources.GetObject("BImprimir.Image"), System.Drawing.Image)
        Me.BImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(23, 22)
        Me.BImprimir.Text = "Imprimir Materias Primas"
        '
        'Configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 350)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TLPConfig)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Configuraciones"
        Me.Text = "Configuraciones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TLPConfig.ResumeLayout(False)
        Me.TLPConfig.PerformLayout()
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
    Friend WithEvents TLPConfig As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TNoMuestrasEnsc1 As System.Windows.Forms.TextBox
    Friend WithEvents TSacGrafEnsc2 As System.Windows.Forms.TextBox
    Friend WithEvents TSacGrafEnsc1 As System.Windows.Forms.TextBox
    Friend WithEvents TNoMuestrasEnsc4 As System.Windows.Forms.TextBox
    Friend WithEvents TMinRep1 As System.Windows.Forms.TextBox
    Friend WithEvents TNoMuestrasEnsc3 As System.Windows.Forms.TextBox
    Friend WithEvents TSacGrafEnsc4 As System.Windows.Forms.TextBox
    Friend WithEvents TNoMuestrasEnsc2 As System.Windows.Forms.TextBox
    Friend WithEvents TSacGrafEnsc3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TMinRep4 As System.Windows.Forms.TextBox
    Friend WithEvents TMinRep3 As System.Windows.Forms.TextBox
    Friend WithEvents TMinRep2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
End Class
