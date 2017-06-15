Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports System.Windows.Forms

Public Class CrystalRep
    Private RepFilNam As String
    Private ServName As String
    Private DB As String
    Private User As String
    Private Pass As String
    Private SelForm As String
    Private CrFormulas As List(Of String)
    Private Max As Boolean = True
    Private Min As Boolean = True
    Private WindStat As FormWindowState = FormWindowState.Maximized
    Private Dest As Long = 0
    Private ConfigPrint As Boolean = False

    Private Form As Form
    Private CrystalReportViewer1 As CrystalReportViewer
    Private TypeArch As ExportDestinationType
    Private RutaExport As String

#Region "Inicializacion de la Clase CrystalRep"
    Public Sub New()
        MyBase.New()
        Try

            CrFormulas = New List(Of String)
            For i As Integer = 0 To 100
                CrFormulas.Insert(i, "")
            Next

            CrystalReportViewer1 = New CrystalReportViewer
            CrystalReportViewer1.ActiveViewIndex = -1
            CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
            CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
            CrystalReportViewer1.Name = "CrystalReportViewer1"
            CrystalReportViewer1.TabIndex = 0
            CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CrystalReportViewer1.ShowRefreshButton = False
            CrystalReportViewer1.ShowCloseButton = False
            CrystalReportViewer1.ShowGroupTreeButton = False

            Form = New Form
            Form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Form.ClientSize = New Size(778, 465)
            Form.Controls.Add(Me.CrystalReportViewer1)
            Form.MaximizeBox = Me.MaximizeBox
            Form.MinimizeBox = Me.MinimizeBox
            Form.Name = "Form1"
            Form.FormBorderStyle = FormBorderStyle.FixedDialog
            Form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Form.Text = "Reportes"
            Form.WindowState = Me.WindowState
            Form.ResumeLayout(False)
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
#End Region
#Region "Metodo donde se genera le Reporte"
    Public Sub PrintReport()
        Try

            Dim Campo As String = ""
            Dim Valor As String = ""
            Dim reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            Dim logonInfo As TableLogOnInfo = New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()

            Form.MaximizeBox = Me.MaximizeBox
            Form.MinimizeBox = Me.MinimizeBox
            Form.WindowState = Me.WindowState

            'reportDocument1.Load(Me.ReportFileName, OpenReportMethod.OpenReportByTempCopy)
            reportDocument1.FileName = Me.ReportFileName
            With crConnectionInfo
                .ServerName = Me.ServerName
                .DatabaseName = Me.DataBaseName
                .UserID = Me.UserId
                .Password = Me.Password
            End With

            For Each Table As Table In reportDocument1.Database.Tables
                logonInfo = Table.LogOnInfo
                logonInfo.ConnectionInfo = crConnectionInfo
                Table.ApplyLogOnInfo(logonInfo)
            Next

            'Validamos si el reporte tiene subreportes para pasarle los datos de Conexión
            SubReporte(reportDocument1)

            For Each Formula As String In CrFormulas
                If String.IsNullOrEmpty(Formula) Then Continue For
                Campo = CLeft(Formula, InStr(1, Formula, "=") - 1)
                Valor = Mid(Formula, InStr(1, Formula, "=") + 1)
                reportDocument1.DataDefinition.FormulaFields(Campo).Text = Valor
            Next

            reportDocument1.RecordSelectionFormula = Me.SelectionFormula
            reportDocument1.Refresh()

            If Destination = Destinacion.crToDisk Then
                reportDocument1.ExportToDisk(Me.FormatFile, Me.RutaExp)
                Return
            End If

            If Destination = Destinacion.crToWindows Then
                CrystalReportViewer1.ReportSource = reportDocument1
                CrystalReportViewer1.Refresh()
                Form.Show()
                Return
            End If

            If Me.ChoosePrint = True And Destination = Destinacion.crToPrinter Then
                Dim Pri As PrintDialog
                Pri = New PrintDialog

                If Pri.ShowDialog <> Windows.Forms.DialogResult.OK Then Return

                Dim P As PageSetupDialog
                P = New PageSetupDialog
                P.PageSettings = New System.Drawing.Printing.PageSettings
                P.PrinterSettings = New System.Drawing.Printing.PrinterSettings

                P.ShowNetwork = False
                If P.ShowDialog <> System.Windows.Forms.DialogResult.OK Then Return
                reportDocument1.PrintToPrinter(Pri.PrinterSettings, P.PageSettings, 0)
                Return

            End If

            reportDocument1.PrintToPrinter(1, False, 0, 0)


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
#End Region
#Region "Propiedades de la Clase CrystalRep"
#Region "Nombre del archivo .rpt a visualizar"
    Public Property ReportFileName() As String
        Get
            ReportFileName = RepFilNam
        End Get

        Set(ByVal value As String)
            RepFilNam = value
        End Set
    End Property
#End Region
#Region "Variables empleadas para establecer la conexion con el servidor"
    Public Property ServerName() As String
        Get
            ServerName = ServName
        End Get

        Set(ByVal value As String)
            ServName = value
        End Set
    End Property

    Public Property DataBaseName() As String
        Get
            DataBaseName = DB
        End Get

        Set(ByVal value As String)
            DB = value
        End Set
    End Property

    Public Property UserId() As String
        Get
            UserId = User
        End Get

        Set(ByVal value As String)
            User = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Password = Pass
        End Get

        Set(ByVal value As String)
            Pass = value
        End Set
    End Property
#End Region
#Region "Select empleando el selection Formula"
    Public Property SelectionFormula() As String
        Get
            SelectionFormula = SelForm
        End Get

        Set(ByVal value As String)
            SelForm = value
        End Set
    End Property
#End Region
#Region "Formulas del reporte"
    Public WriteOnly Property Formulas(ByVal Index As Integer) As String
        Set(ByVal value As String)
            CrFormulas(Index) = value
        End Set
    End Property
#End Region
#Region "ControlBox independiente es decir MaxBox y MinBox, tambien el WindowState"
    Public Property MaximizeBox() As Boolean
        Get
            MaximizeBox = Max
        End Get

        Set(ByVal value As Boolean)
            Max = value
        End Set
    End Property

    Public Property MinimizeBox() As Boolean
        Get
            MinimizeBox = Min
        End Get

        Set(ByVal value As Boolean)
            Min = value
        End Set
    End Property

    Public Property WindowState() As System.Windows.Forms.FormWindowState
        Get
            WindowState = WindStat

        End Get

        Set(ByVal value As FormWindowState)
            WindStat = value
        End Set
    End Property
#End Region
#Region "Destination, es decir a donde vamos a obtener el reporte Impresora o Windows"
    Public Enum Destinacion As Long
        crToWindows = 0
        crToPrinter = 1
        crToDisk = 2
    End Enum
    Public Property Destination() As Destinacion
        Get
            Destination = Dest
        End Get
        Set(ByVal value As Destinacion)
            Dest = value
        End Set
    End Property
#End Region
#Region "Destinacion ToDisk"
#Region "FormatFile"
    Public Property FormatFile As ExportFormatType
        Get
            FormatFile = TypeArch

        End Get
        Set(ByVal value As ExportFormatType)
            TypeArch = value
        End Set
    End Property
#End Region
#Region "Nombre de Archivo A Exportar"
    Public Property RutaExp As String
        Get
            RutaExp = RutaExport
        End Get
        Set(ByVal value As String)
            RutaExport = value
        End Set
    End Property
#End Region
#End Region
#Region "Opcion de seleccion de impresora a la hora de imprimir el reporte"

    Public Property ChoosePrint() As Boolean
        Get
            ChoosePrint = ConfigPrint
        End Get
        Set(ByVal value As Boolean)
            ConfigPrint = value
        End Set
    End Property
#End Region
#End Region
#Region "Metodo para los SubReporte"
    Private Sub SubReporte(ByRef Reporte As ReportDocument)
        Try
            Dim crSections As Sections
            Dim crSubreportDocument As New ReportDocument
            Dim crSubreportObject As SubreportObject
            Dim crReportObjects As ReportObjects
            Dim crDatabase As Database
            Dim crTables As Tables
            Dim crTableLogOnInfo As TableLogOnInfo
            Dim ConecxionInfo = New ConnectionInfo

            With ConecxionInfo
                .ServerName = Me.ServerName
                .DatabaseName = Me.DataBaseName
                .UserID = Me.UserId
                .Password = Me.Password
            End With
            'esto aquí ES PARA TENER LOS INFORMES subinformes 
            ' establecer el objeto de las secciones de la sección del informe actual 
            crSections = Reporte.ReportDefinition.Sections
            ' recorrer todos los sectores para encontrar todos los objetos de informe 

            For Each CrSection As Section In crSections
                crReportObjects = CrSection.ReportObjects
                ' recorrer todos los objetos de informe en el que encontrar todos los subinformes 

                For Each crReportObject As ReportObject In crReportObjects
                    If (crReportObject.Kind = ReportObjectKind.SubreportObject) Then
                        'crSubreportObject = (SubreportObject) crReportObject
                        crSubreportObject = CType(crReportObject, SubreportObject)
                        crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)
                        crDatabase = crSubreportDocument.Database
                        crTables = crDatabase.Tables

                        For Each Tabla As Table In crTables
                            crTableLogOnInfo = Tabla.LogOnInfo
                            crTableLogOnInfo.ConnectionInfo = ConecxionInfo
                            Tabla.ApplyLogOnInfo(crTableLogOnInfo)
                        Next

                    End If
                Next


            Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
#End Region

End Class
