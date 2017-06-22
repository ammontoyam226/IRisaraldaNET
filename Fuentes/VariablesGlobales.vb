Option Explicit On
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Common  ' Espacio que permite la conexion bilateral Acces o Sql
Imports System.IO
Imports System.Threading.Thread
Imports System.Text
Module VariablesGlobales

#Region "Declaracion de Variables En el módulo"

    Public RutaDB As String
    Public Ruta As String
    Public Sentencia As String
    Public TipoServer As String
    Public TipoServerNept As String
    Public RutaDBCB As String
    Public CONN As DbConnection
    Public CONNCB As DbConnection
    Public DbProvedor As DbProviderFactory
    Public DbProvedorCB As DbProviderFactory
    Public CONNMimico As DbConnection
    Public DbProvedorMimico As DbProviderFactory
    Public RutaMimico As String

    Public Resp As Long
    Public ServidorSQL As String
    Public PWD As String
    Public PWDCB As String
    Public UserDBCB As String
    Public UserDB As String
    Public NomDB As String
    Public NomDBCB As String
    Public RutaRep As String
    Public Planta As String
    Public DRUsuario As DataRow
    Public RespInput As String
    Public NombrePC As String
    Public Usuario As String
    Public Fuentes As Boolean
    Public ServComM As Boolean
    Public ServCHR As Boolean
    Public ServMicros As Boolean
    Public ServComMVisual As Boolean
    Public ServComMBP As Boolean
    Private List As New List(Of TextBox)
    Private ListBool As New List(Of Boolean)
    Public ReportesSap As Boolean = True
    Public RutaCB As String
    Public TolvaMatrizDif As Int32
    Public LoteCortesMP As String
    Public ContCortesMP As String
    Public Sesion As String
    Public VerAlarmas As Boolean

    Public Empacadora As Integer
    Public ProcesoFiltrar As String


    Public NMaq As Integer

#End Region

#Region "Funcion que reemplaza al VAL, no interesa la configuracion decimal 'EVAL'"
    Public Function Eval(ByVal Valor As String) As Double
        Dim Aux As String = ""
        Aux = Replace(Valor, ",", ".")
        Eval = Format(Val(Aux), ".000")
    End Function
#End Region

#Region "Evento"
    Public Sub Evento(ByVal Frase As String)
        Try
            Dim Archivo As FileStream
            Frase = UCase(Frase)
            Dim byteData() As Byte
            byteData = Encoding.Default.GetBytes(Frase.PadRight(85, Chr(32)) + vbTab + Usuario.PadRight(20, Chr(32)) + vbTab + NombrePC.PadRight(20, Chr(32)) + vbTab + Format(Now, "HH:mm:ss") + vbNewLine)
            'Frase + Space(20) + Space(20) + Usuario + Space(20) + NombrePC + Space(20) + Space(20) + Format(Now, "HH:mm:ss")
            Archivo = New FileStream(Ruta + "Aplanos\Eventos_" + Format(Now, "yyMMdd") + ".txt", FileMode.Append)
            Archivo.Write(byteData, 0, byteData.Length)
            Archivo.Close()
        Catch ex As IOException
            Return
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Leer escribir ConfigVAr"
    Public Function ReadConfigVar(ByVal Campo As String) As String

        Dim DConfigVar As AdoNet

        DConfigVar = New AdoNet("CONFIGVAR", CONN, DbProvedor)
        DConfigVar.Open("select * from CONFIGVAR where CAMPO='" + Campo + "'")

        ReadConfigVar = ""
        If DConfigVar.RecordCount > 0 Then ReadConfigVar = DConfigVar.RecordSet("VALOR").ToString
    End Function
    Public Sub WriteConfigVar(ByVal Campo As String, ByVal Valor As String)

        Dim DConfigVar As AdoNet

        DConfigVar = New AdoNet("CONFIGVAR", CONN, DbProvedor)
        DConfigVar.Open("select * from CONFIGVAR where CAMPO='" + Campo + "'")

        If DConfigVar.RecordCount = 0 Then
            MsgError("Campo no encontrado en la tabla configvar")
            Return
        End If
        DConfigVar.RecordSet("VALOR") = Valor
        DConfigVar.Update()

    End Sub
#End Region

#Region "Leer escribir FechasCierre"

    'Public Enum Tipo As Integer
    '    MP = 0      'Materia Prima
    '    PT = 1      'Producto Terminado
    '    AD = 2      'Adictivos
    '    PR = 3      'Premezclas
    '    EM = 4      'Empaques
    '    ET = 5      'Etiquetas
    'End Enum

    Public Enum ClaseFecha As Integer
        FISICO = 0      'Fecha de cierre inventario Fisico
        UNO = 1       'Fecha de cierre sistema uno
        COMPARATIVOINV = 2      'Fecha cierre modulo COMPARATIVOINV (Resumen Inventarios)
        ULTRESET = 3      'Ultima fecha de reset 
    End Enum


    Public Function ReadFechasCierre(ByVal Campo As String, ByVal ClaseFecha As ClaseFecha) As String

        Dim DFechasCierre As AdoNet

        DFechasCierre = New AdoNet("FECHASCIERRE", CONN, DbProvedor)
        DFechasCierre.Open("select * from FECHASCIERRE where TIPO='" + Campo + "'")

        ReadFechasCierre = ""
        If DFechasCierre.RecordCount > 0 Then ReadFechasCierre = DFechasCierre.RecordSet(ClaseFecha.ToString).ToString
    End Function
    Public Sub WriteFechasCierre(ByVal Campo As String, ByVal Valor As String, ByVal ClaseFecha As ClaseFecha)

        Dim DFechasCierre As AdoNet

        DFechasCierre = New AdoNet("FECHASCIERRE", CONN, DbProvedor)
        DFechasCierre.Open("select * from FECHASCIERRE where TIPO='" + Campo.ToString + "'")

        If DFechasCierre.RecordCount = 0 Then
            MsgError("Campo no encontrado en la tabla configvar")
            Return
        End If
        DFechasCierre.RecordSet(ClaseFecha.ToString) = Valor
        DFechasCierre.Update()

    End Sub
#End Region

#Region "Asignar Datos de DataTable a DataGridView"
    Public Sub AsignaDataGrid(ByVal DG As DataGridView, ByVal DT As DataTable, Optional ByVal NomDGCol As Boolean = False)

        If DG Is Nothing Then _
            Throw New ArgumentException("Asignación no valida para el datagridview")

        DG.Rows.Clear()

        If DT Is Nothing Then Return

        For y As Integer = 0 To DT.Rows.Count - 1
            DG.Rows.Add()
            For i As Integer = 0 To DG.Columns.Count - 1
                If DG.Columns(i).Name.Contains("_NI_") Then Continue For
                If NomDGCol = True Then
                    Dim Pos As Integer = DG.Columns(i).Name.IndexOf("_")
                    Dim Campo As String = DG.Columns(i).Name.Substring(Pos + 1)
                    DG.Rows(y).Cells(DG.Columns(i).Name).Value = DT.Rows(y).Item(Campo)
                Else
                    DG.Rows(y).Cells(DG.Columns(i).Name).Value = DT.Rows(y).Item(DG.Columns(i).Name)
                End If
            Next
        Next
    End Sub
#End Region

#Region "Funcion LEFT"
    Public Function CLeft(ByVal Texto As String, ByVal N As Long) As String
        Dim Dato As String
        Dato = (Texto + New String(" ", N)).Substring(0, N).Trim
        CLeft = Dato
    End Function
#End Region

#Region "Funcion RIGHT"
    Public Function CRight(ByVal Texto As String, ByVal N As Long) As String
        Dim Dato As String
        If Len(Texto) <= 0 OrElse Len(Texto) < N Then
            CRight = ""
            Exit Function
        End If
        Dato = Texto.Substring(Texto.Length - N, N).Trim
        CRight = Dato
    End Function
#End Region


#Region "Busqueda de datos en Módulos empleando ComboBox"
    Public Function AsignaItemsCB(ByVal ArrayCampos() As String, ByVal CB As ComboBox, ByVal DT As DataTable) As String()

        Dim Campos() As String = {"", ""}
        Dim Texto() As String = {"", ""}
        Dim Pos As Long
        Dim i As Integer
        Dim Dimension As Integer

        CB.Items.Clear()

        Dimension = ArrayCampos.Length - 1
        ReDim Campos(Dimension)
        ReDim Texto(Dimension)

        For Each Dato As String In ArrayCampos
            Pos = Dato.IndexOf("@")
            If Pos = 0 Then
                MsgBox("Debe mandar el caracter @ para distinguir los campos del texto a mostrar ", MsgBoxStyle.Exclamation)
                AsignaItemsCB = Campos
                Exit Function
            End If
            Campos(i) = CLeft(Dato, Pos)
            Texto(i) = Dato.Substring(Pos + 1)
            i += 1
        Next


        For i = 0 To Dimension

            For Each DC As DataColumn In DT.Columns
                If DC.ColumnName.ToString.ToUpper = Campos(i).ToUpper Then
                    CB.Items.Add(Texto(i))
                    Exit For
                Else
                    'MsgBox("Algún campo de la lista enviada no existe en la tabla, favor verificar", MsgBoxStyle.Critical)
                End If
            Next
        Next
        AsignaItemsCB = Campos

    End Function
    Public Sub BusquedaDG(ByVal DG As DataGridView, ByVal DT As DataTable, ByVal Valor As String,
     ByVal Campo As String, Optional ByRef Encontrado As Boolean = False)
        Try

            Dim DFil() As DataRow
            Dim Tipo As String, Consulta As String
            Dim DTAux As New DataTable

            DG.CurrentCell = Nothing

            If DT.Rows.Count = 0 OrElse DG.Rows.Count = 0 OrElse Valor = "" OrElse Campo = "" Then Exit Sub

            If DG.DataSource Is Nothing = False Then
                DT.DefaultView.RowFilter = Campo + " LIKE '%" + Valor + "%'"
                DG.Refresh()
            Else

                'Tipo = DT.Columns.Item(Campo).GetType.Name
                Tipo = DT.Rows(0).Item(Campo).GetType.Name
                Consulta = Campo + "=" + Valor.ToUpper.Trim
                If Tipo = "String" Then
                    Consulta = Campo + " LIKE '%" + Valor + "%'"
                    DFil = DT.Select(Consulta)
                    If DFil.Length <= 0 Then
                        Encontrado = False
                        Exit Sub
                    End If
                    Encontrado = True
                    For Each C As DataColumn In DT.Columns
                        DTAux.Columns.Add(C.ColumnName)
                    Next

                    For Each R As DataRow In DFil
                        DTAux.ImportRow(R)
                    Next

                    If InStr(1, DG.Columns(0).Name, "_") > 0 Then
                        AsignaDataGrid(DG, DTAux, True)
                    Else
                        AsignaDataGrid(DG, DTAux)
                    End If

                    DG.Rows(0).Selected = True
                    DG.FirstDisplayedScrollingRowIndex = 0
                    DG.CurrentCell = DG(0, 0)
                Else
                    DFil = DT.Select(Consulta)
                    If DFil.Length <= 0 Then
                        Encontrado = False
                        Exit Sub
                    End If

                    For Each Filasel As DataGridViewRow In DG.Rows
                        If Filasel.Cells(Campo).Value Is Nothing _
                            OrElse Filasel.Cells Is Nothing Then
                            Continue For
                        End If
                        If Valor.ToUpper = Filasel.Cells(Campo).Value.ToString.ToUpper.Trim Then

                            DG.Rows(Filasel.Index).Selected = True
                            DG.FirstDisplayedScrollingRowIndex = Filasel.Index
                            DG.CurrentCell = DG(0, Filasel.Index)

                            Encontrado = True
                            Exit For
                        End If
                    Next
                End If
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub
    Public Sub BusquedaDGContains(ByVal DG As DataGridView, ByVal Campo As String, ByVal Valor As String, Optional ByRef Encontrado As Boolean = False)
        'Sobre cargamos el metodo de tal forma que permita filtar un datagrid sin que tengamos la tabla
        DG.CurrentCell = Nothing
        Dim Cont As Integer = 0
        Try
            For Each Filasel As DataGridViewRow In DG.Rows
                Filasel.Visible = True
            Next
            'If QuitarFiltro = True And Fila = 0 Then Exit Sub

            For Each Filasel As DataGridViewRow In DG.Rows
                Cont += 1
                If Filasel.Cells(Campo).Value Is Nothing _
                    OrElse Filasel.Cells Is Nothing OrElse Filasel.Visible = False Then
                    Continue For
                End If
                If DG.DataSource Is Nothing Then
                    If Filasel.Cells(Campo).Value.ToString.Contains(Valor) = False Then
                        Filasel.Visible = False
                    Else
                        Encontrado = True
                    End If
                Else
                    If Filasel.DataBoundItem(Campo).ToString.Contains(Valor) = False Then
                        Filasel.Visible = False
                    Else
                        Encontrado = True
                    End If
                End If
                'If Filasel.DataBoundItem(Campo).ToString.Contains(Valor) = False Then
                '    Filasel.Visible = False
                '    'If Filasel.Cells(Campo).Value.ToString.Contains(Valor) = False Then
                '    Filasel.Visible = False
                'Else
                '    Encontrado = True

                'End If
            Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Public Sub BusquedaDGCond(ByVal DG As DataGridView, ByVal Campo As String, ByVal Valor As String, ByVal Condicion As String, Optional ByRef Encontrado As Boolean = False)
        'Sobre cargamos el metodo de tal forma que permita filtar un datagrid sin que tengamos la tabla
        Dim Cont As Integer = 0
        Try
            DG.CurrentCell = Nothing
            If Condicion = "" Then Return
            For Each Filasel As DataGridViewRow In DG.Rows
                Filasel.Visible = True
            Next
            'If QuitarFiltro = True And Fila = 0 Then Exit Sub

            For Each Filasel As DataGridViewRow In DG.Rows
                Cont += 1
                If Filasel.Cells(Campo).Value Is Nothing _
                    OrElse Filasel.Cells Is Nothing OrElse Filasel.Visible = False Then
                    Continue For
                End If
                Select Case Condicion
                    Case "<>"
                        If Filasel.Cells(Campo).Value.ToString = Valor Then
                            Filasel.Visible = False
                        Else
                            Encontrado = True
                        End If
                    Case ">"
                        If Filasel.Cells(Campo).Value.ToString <= Valor Then
                            Filasel.Visible = False
                        Else
                            Encontrado = True
                        End If
                    Case "<"
                        If Filasel.Cells(Campo).Value.ToString >= Valor Then
                            Filasel.Visible = False
                        Else
                            Encontrado = True
                        End If
                    Case ">="
                        If Filasel.Cells(Campo).Value.ToString < Valor Then
                            Filasel.Visible = False
                        Else
                            Encontrado = True
                        End If
                    Case "<="
                        If Filasel.Cells(Campo).Value.ToString > Valor Then
                            Filasel.Visible = False
                        Else
                            Encontrado = True
                        End If
                    Case Else
                        Return
                End Select
            Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Public Sub BusquedaDG(ByVal DG As DataGridView, ByVal Campo As String, ByVal Valor As String, Optional ByRef Encontrado As Boolean = False, Optional ByVal QuitarFiltro As Boolean = False, Optional ByRef Fila As Integer = 0)
        'Sobre cargamos el metodo de tal forma que permita filtar un datagrid sin que tengamos la tabla
        Dim Cont As Integer = 0
        Try
            For Each Filasel As DataGridViewRow In DG.Rows
                Filasel.Visible = True
            Next
            If QuitarFiltro = True And Fila = 0 Then Exit Sub

            For Each Filasel As DataGridViewRow In DG.Rows
                Cont += 1
                If Filasel.Cells(Campo).Value Is Nothing _
                    OrElse Filasel.Cells Is Nothing OrElse Filasel.Visible = False Then
                    Continue For
                End If
                If Filasel.Cells(Campo).Value.ToString <> Valor Then
                    If Fila = 0 Then Filasel.Visible = False
                Else
                    Encontrado = True
                    If Fila <> 0 Then Exit For
                End If
            Next
            Fila = Cont - 1

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
    Public Function TipoCampo(ByVal Campo As String, ByVal DT As DataTable) As String
        TipoCampo = DT.Rows(0).Item(Campo).GetType.Name
    End Function
#End Region




#Region "Asignar Datos de un DATATABLE a un ComboBox"
    Public Sub LLenaComboBox(ByVal CB As ComboBox, ByVal DT As DataTable, ByVal Campo As String, Optional ByVal No As Integer = 0)
        CB.Items.Clear()

        For i As Integer = 0 To DT.Rows.Count - 1
            CB.Items.Add(DT.Rows(i).Item(Campo).ToString)
            If No > 0 AndAlso i = No - 1 Then Exit For
        Next
    End Sub
#End Region

#Region "Restringir el ingreso de datos a un TextBox de solo Números"

    Public Sub TextNum(ByVal Text As TextBox, Optional ByVal PuntoDec As Boolean = False)
        ' Si en la caja de texto se perimite el ingreseo de decimales
        ListBool.Add(PuntoDec)
        List.Add(Text)
        For i As Integer = 0 To List.Count - 1 ' Voy desde el 1 hasta el count -1
            AddHandler List(i).KeyPress, AddressOf TextSolo_Numeros
        Next

    End Sub
    Private Sub TextSolo_Numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Dim txt As TextBox = CType(sender, TextBox)
            Dim Index As Integer = List.IndexOf(txt)
            Dim Deci As Boolean = ListBool(Index)

            If Deci Then
                If (IsNumeric(e.KeyChar)) OrElse (e.KeyChar = ChrW(Keys.Back)) Or (e.KeyChar = ".") And (txt.Text.Contains(".") = False) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                Exit Sub
            End If

            If (IsNumeric(e.KeyChar)) Or _
               (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Limpiar todos los TextBox de un Formulario"

    Public Enum AccionTextBox As Integer
        Habilitar = 1
        Deshabilitar = 2
        Limpiar = 3
    End Enum


    Public Sub Limpiar_Habilitar_TextBox(ByVal Ctrls As Control.ControlCollection, ByVal Limpiar_Habilitar As AccionTextBox)
        'hace un chequeo por todos los textbox del formulario
        For Each oControl As Control In Ctrls
            If Ctrls.Count > 0 AndAlso (TypeOf oControl Is Panel OrElse TypeOf oControl Is GroupBox) Then
                Limpiar_Habilitar_TextBox(oControl.Controls, Limpiar_Habilitar)
            End If
            If TypeOf oControl Is TextBox Then
                If Limpiar_Habilitar = 3 Then
                    oControl.Text = ""
                ElseIf Limpiar_Habilitar = 1 Then 'Habilita para escritura las cajas de texto
                    CType(oControl, TextBox).ReadOnly = False
                ElseIf Limpiar_Habilitar = 2 Then 'Pone readonly las cajas de texto
                    CType(oControl, TextBox).ReadOnly = True
                End If

                'CType(oControl, TextBox).BackColor = Color.White
            End If
        Next
    End Sub
#End Region

#Region "Sumar Columna de un DataGridView"
    Public Function SumColumn(ByVal DG As DataGridView, ByVal Campo As String) As Double
        Try
            SumColumn = 0
            For Each Filasel As DataGridViewRow In DG.Rows
                If Filasel.Cells(Campo).Value Is Nothing _
                    OrElse Filasel.Cells Is Nothing OrElse Filasel.Visible = False Then
                    Continue For
                End If
                SumColumn += Eval(Filasel.Cells(Campo).Value)
            Next
        Catch ex As Exception
            MsgError(ex.ToString)
            SumColumn = 0
        End Try
    End Function
#End Region

#Region "Mensaje de Error"
    Public Sub MsgError(ByVal Msg As String)
        MessageBox.Show(Msg, My.Application.Info.AssemblyName.ToString, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Evento(Msg)
    End Sub
#End Region

#Region "Escritura Archivo"
    Public Sub WriteFile(ByVal Ruta As String, ByVal Msg As String, Optional ByVal SobreEscb As Boolean = True)
        If String.IsNullOrEmpty(Ruta) OrElse String.IsNullOrEmpty(Msg) Then
            Throw New ArgumentException( _
                        "Datos erroneos para la escritura del archivo")
        End If

        If Directory.Exists(Path.GetDirectoryName(Ruta)) = False Then
            MsgError("La ruta No es Válida para la generación del archivo")
            Return
        End If

        Dim Wrt As StreamWriter
        Wrt = New StreamWriter(Ruta, SobreEscb)
        Wrt.WriteLine(Msg.Trim)
        Wrt.Close()
        Wrt.Dispose()
    End Sub
#End Region
#Region "Alarma"
    Public Sub Alarma(ByVal Mensaje As String)
        Try
            Dim DAlArmas As AdoNet

            DAlArmas = New AdoNet("Alarmas", CONN, DbProvedor)
            DAlArmas.Open("Select * from ALARMAS WHERE ID=0")
            If String.IsNullOrEmpty(Mensaje) Then Return

            DAlArmas.AddNew()
            DAlArmas.RecordSet("ALARMA") = CLeft(Mensaje, 100)
            DAlArmas.RecordSet("FECHA") = Format(Now, "yyyy/MM/dd HH:mm:ss")
            DAlArmas.RecordSet("NOMBREPC") = NombrePC
            DAlArmas.Update()

            If VerAlarmas Then
                Fondo1.SCEscritorio.Panel1Collapsed = False
                Fondo1.FRefrescaDG_Click(Nothing, Nothing)
                Fondo1.SCEscritorio.SplitterDistance = 604
            End If

            Evento(Mensaje)

            If File.Exists(Ruta + "Alarmas.exe") = False Then Return

            'Process.Start(Ruta + "Alarmas.exe")
            Resp = Shell(Ruta + "Alarmas.exe", AppWinStyle.NormalFocus)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Totaliza o finaliza baches"

    Public Sub TotFinBache(ByVal Recordset As DataRow)

        Dim DConsumos As New AdoNet("CONSUMOS", CONN, DbProvedor)
        Dim DBaches As New AdoNet("Baches", CONN, DbProvedor)
        Try
            If Recordset Is Nothing Then _
            Throw New ArgumentException("Faltan datos en el bache a procesar")

            DBaches.Open("Select * from BACHES where CONT=" + Recordset("CONT").ToString)

            If DBaches.RecordCount = 0 Then Return

            DConsumos.Open("Select sum(PESOMETA) AS PESOMETA, sum(PESOREAL) AS PESOREAL  from COSNUMOS where CONT=" + Recordset("CONT").ToString)

            If IsDBNull(DConsumos.RecordSet("PESOMETA")) OrElse IsDBNull(DConsumos.RecordSet("PESOREAL")) Then Return

            DBaches.RecordSet("PESOREAL") = DConsumos.RecordSet("PESOREAL")

            If Math.Abs(DBaches.RecordSet("PESOMETA") - DConsumos.RecordSet("PESOMETA")) < Eval(0.05) Then
                DBaches.RecordSet("ESTADO") = 10 'El bache está completo
            End If

            DBaches.Update()


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Clave Dinamica"

    Public Function ValidaClave(ByVal Clave As String) As Boolean
        Dim ClaveReal As String
        If String.IsNullOrEmpty(Clave) Then _
            Throw New ArgumentException("Clave no válida")
        ClaveReal = Today.Day.ToString + Today.Month.ToString + Now.Hour.ToString
        ValidaClave = False
        If Clave = ClaveReal Then ValidaClave = True
        Return ValidaClave
    End Function

#End Region

#Region "Exportar Consumos"
    Public Sub ExportAr()
        Dim SumaForm As Single
        Dim ExportOk As Boolean
        Dim DOPs As AdoNet
        Dim DCExportArConsumos As AdoNet
        Dim DEmpaque As AdoNet
        Dim DFor As AdoNet
        Dim DBaches As AdoNet
        Dim DExportAr As AdoNet
        Dim SumaReal() As Single
        Dim CodMatB() As String
        Dim j As Integer
        Dim Sentencia As String
        Dim RutaSave As String

        Try
            DOPs = New AdoNet("OPS", CONN, DbProvedor)
            DCExportArConsumos = New AdoNet("Export", CONN, DbProvedor)
            DBaches = New AdoNet("BACHES", CONN, DbProvedor)
            DExportAr = New AdoNet("ExportArc", CONN, DbProvedor)
            DFor = New AdoNet("FORMULAS", CONN, DbProvedor)
            DEmpaque = New AdoNet("EMPAQUE", CONN, DbProvedor)

            DOPs.Open("select * from OPS where FINALIZADO='S' and FINOPEMP='S' and EXPORT=0")

            If DOPs.RecordCount = 0 Then Exit Sub

            For Each Recordset As DataRow In DOPs.Rows

                DBaches.Open("select * from BACHES where OP=" + Recordset("OP").ToString + " order by CONT")

                If DBaches.RecordCount = 0 Or DBaches.RecordCount <> Recordset("Meta") Then GoTo SigOP 'Verificamos que el numero de baches sea igual a los programados

                ReDim SumaReal(Recordset("CantMatFor"))

                For Each BachesRecordset As DataRow In DBaches.Rows

                    DCExportArConsumos.Open(" select * from CEXPORTARCONSUMOS where OP=" + Recordset("OP").ToString + " and CONT=" + BachesRecordset("Cont").ToString)
                    If DCExportArConsumos.RecordCount = 0 Then GoTo SigOP
                    If DCExportArConsumos.RecordCount <> Recordset("CantMatFor") Then GoTo SigOP 'Exit Sub
                Next

                DCExportArConsumos.Open(" select CODMAT,CODMATB, sum(PESOREAL)as PESOTOTINGRE from CEXPORTARCONSUMOS where OP=" + Recordset("OP").ToString + " group by CODMAT,CODMATB")
                j = 0
                If Recordset("CantMatFor") < DCExportArConsumos.RecordCount Then
                    ReDim SumaReal(DCExportArConsumos.RecordCount)
                End If

                ReDim CodMatB(SumaReal.Length - 1)

                For Each RecordCExp As DataRow In DCExportArConsumos.Rows
                    SumaReal(j) = RecordCExp("PESOTOTINGRE")
                    CodMatB(j) = RecordCExp("CODMATB")
                    j = j + 1
                Next

                SumaForm = 0
                For j = 0 To UBound(SumaReal) - 1  ' Creamos los resgistros que vamos a exportar

                    DExportAr.Open("select * from EXPORTAR where CODLOTE='0'")
                    DExportAr.AddNew()
                    DExportAr.RecordSet("CodLote") = Recordset("LoteProd")
                    DExportAr.RecordSet("CodProd") = CodMatB(j)
                    DExportAr.RecordSet("FechaC") = Recordset("FechaC")
                    DExportAr.RecordSet("FechaCr") = Recordset("FechaCr")
                    DExportAr.RecordSet("FhVence") = Recordset("FechaVenc")
                    'DExportAr!cantprod = DOPs!Porc * DOPs!Meta * DDatosFor!Valor * 0.01
                    DExportAr.RecordSet("CantProd") = Format(SumaReal(j), ".00")
                    DExportAr.Update()
                    SumaForm = SumaForm + Format(SumaReal(j), ".00")
                Next

                DEmpaque.Open("Select CODEMP, SUM(SACOS) as SUMSACOS FROM EMPAQUE where OP='" + Recordset("OP").ToString + "' GROUP BY CODEMP")

                For Each RECEMP As DataRow In DEmpaque.Rows
                    DExportAr.Open("select * from EXPORTAR where CODLOTE='0'")
                    DExportAr.AddNew()
                    DExportAr.RecordSet("CodLote") = Recordset("LoteProd")
                    DExportAr.RecordSet("CodProd") = RECEMP("CODEMP").ToString
                    DExportAr.RecordSet("FechaC") = Recordset("FechaC")
                    DExportAr.RecordSet("FechaCr") = Recordset("FechaCr")
                    DExportAr.RecordSet("FhVence") = Recordset("FechaVenc")
                    'DExportAr!cantprod = DOPs!Porc * DOPs!Meta * DDatosFor!Valor * 0.01
                    DExportAr.RecordSet("CantProd") = Format(RECEMP("SUMSACOS"), ".00")
                    DExportAr.Update()
                Next

                Sentencia = "select * from EXPORTAR where CODLOTE='" + Recordset("LoteProd").ToString + "'"
                'RutaSave = Ruta + "Ofimatica\ChrOP_" + Recordset("OP").ToString + ".xlsx"
                RutaSave = Ruta + "Ofimatica\ChrOP_" + Recordset("OP").ToString + ".csv"
                Dim CodF As String
                DFor.Open("select * from FORMULAS where CODFOR='" + Recordset("CodFor").ToString + "' and LP='" + Recordset("LP").ToString + "'")
                CodF = 0
                If DFor.RecordCount > 0 Then CodF = DFor.RecordSet("CODFORB")
                ' ExportOk = ExporExcel(Sentencia, RutaSave, CodF, SumaForm) 'Enviamos parametros a la Funcion que exporta a Excel lo Consumos
                ExportOk = ExportArText(Sentencia, RutaSave, CodF, SumaForm) 'Enviamos parametros a la Funcion que exporta a Excel lo Consumos

                If ExportOk Then
                    Evento("Se realizó la exportación a Ofimática con éxito OP:" + Recordset("OP").ToString)
                    DExportAr.Delete("delete from EXPORTAR where CODLOTE='" + Recordset("LoteProd").ToString + "'")
                    Recordset("Export") = True
                    DOPs.Update()
                End If



SigOP:
            Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try


    End Sub

    Private Function ExportArText(ByVal Sentencia As String, ByVal RutaSave As String, ByVal Formula As String, ByVal SumaForm As Single) As Boolean
        Dim DVarios As AdoNet
        Dim Contenido As String = ""
        Dim Caracter As Char = ","


        Try
            DVarios = New AdoNet("Varios", CONN, DbProvedor)
            DVarios.Open(Sentencia)

            If DVarios.RecordCount = 0 Then
                ExportArText = False
                Exit Function
            End If

            For Each Col As DataColumn In DVarios.DataTable.Columns
                Contenido += Col.ColumnName + Caracter
            Next

            Contenido = Mid(Contenido, 1, InStrRev(Contenido, Caracter) - 1)
            Contenido += vbNewLine

            ' Escribimos el registro de los datos del la Fórmula

            Contenido += DVarios.RecordSet("CODLOTE").ToString + Caracter
            Contenido += Formula + Caracter + DVarios.RecordSet("FECHAC").ToString + Caracter
            Contenido += DVarios.RecordSet("FECHACR").ToString + Caracter
            Contenido += DVarios.RecordSet("FHVENCE").ToString + Caracter
            Contenido += Format(SumaForm, ".00") + vbNewLine

            For Each Recordset As DataRow In DVarios.Rows
                Dim Col() As Object
                Col = Recordset.ItemArray
                For Each item As Object In Col
                    Contenido += item.ToString + Caracter
                Next
                Contenido = Mid(Contenido, 1, InStrRev(Contenido, Caracter) - 1)
                Contenido += vbNewLine
            Next

            WriteFile(RutaSave, Contenido, False)
            ExportArText = True

        Catch ex As Exception
            MsgError(ex.ToString)
            ExportArText = False
        End Try

    End Function




#End Region

#Region "Historicos"

    Public Function MakeHist(Optional ByVal Intervalo As Long = 3) As Boolean

        Dim CONNH As DbConnection
        Dim RutaDBH As String
        Dim DVarios As New AdoNet("VARIOS", CONN, DbProvedor)
        Dim DVarios1 As New AdoNet("VARIOS1", CONN, DbProvedor)
        Dim DVariosH As AdoNet
        Dim DCopyH As AdoNet
        Dim FechaLim As String


        Try

            If Intervalo <= 0 Then _
            Throw New ArgumentException("El intervalo de traslado de información no puede ser menor o igual a cero")


            RutaDBH = "Data Source=" + ServidorSQL + "; Initial Catalog=" + NomDB + "H " + "; User Id=" + UserDB + "; Password=" + PWD

            CONNH = DbProvedor.CreateConnection
            CONNH.ConnectionString = RutaDBH
            FechaLim = Format(DateAdd("m", -Intervalo, Now), "yyyy/MM/dd")

            DVariosH = New AdoNet("VARIOSH", CONNH, DbProvedor)
            DCopyH = New AdoNet("COPYH", CONNH, DbProvedor)


            '------------------------------Traslada los baches y consumos a los historicos ----------------------------------
            'If TipoServer = "SQLSERVER" Then
            DVarios.Open("Select COUNT(*) as DB from sys.databases where NAME='" + NomDB + "H'")
            If DVarios.RecordSet("DB") = 0 Then _
                Throw New ArgumentException("La base de datos de históricos no existe")

            CompareTable("Baches", CONNH)
            CompareTable("Consumos", CONNH)



            DVariosH.Open("select * from BACHES where Cont=0")
            DCopyH.Open("select * from CONSUMOS where Cont=0")
            DVarios.Open("select * from BACHES where Fecha<'" + FechaLim + "'")

            For Each RecordSet As DataRow In DVarios.Rows

                DVarios1.Open("select * from CONSUMOS where CONT=" + RecordSet("CONT").ToString)

                For Each RecordC As DataRow In DVarios1.Rows
                    DCopyH.AddNew()
                    For i As Integer = 0 To DVarios1.DataTable.Columns.Count - 1
                        DCopyH.RecordSet(i) = RecordC(i)
                    Next
                    DCopyH.Update()
                    Application.DoEvents()
                Next

                DVarios1.Delete("delete from CONSUMOS where CONT=" + RecordSet("CONT").ToString)

                DVariosH.AddNew()
                For i As Integer = 0 To DVarios.DataTable.Columns.Count - 1
                    DVariosH.RecordSet(i) = RecordSet(i)
                Next
                DVariosH.Update()
                Application.DoEvents()
            Next

            DVarios.Delete("delete from BACHES where Fecha<'" + FechaLim + "'")


            '------------------------------Copia la tabla de EMPAQUE a los historicos ----------------------------------
            CompareTable("Empaque", CONNH)

            DVarios.Open("select * from EMPAQUE where Fechaini<'" + FechaLim + "'")

            For Each RecordSet As DataRow In DVarios.Rows

                DVariosH.Open("select * from EMPAQUE where Cont=" + RecordSet("CONT").ToString)

                If DVariosH.RecordCount = 0 Then
                    DVariosH.AddNew()
                End If
                For i As Integer = 0 To DVarios.DataTable.Columns.Count - 1
                    DVariosH.RecordSet(i) = RecordSet(i)
                Next
                DVariosH.Update()
                Application.DoEvents()
            Next
            DVarios.Delete("delete from EMPAQUE where Fechaini<'" + FechaLim + "'")

            Return True
        Catch ex As Exception
            MsgError(ex.ToString)
            Return False
        End Try
    End Function
    Private Sub CompareTable(ByVal Tabla As String, ByVal CONNH As DbConnection)
        Dim DVarios As New AdoNet("VARIOS", CONN, DbProvedor)
        Dim DVariosH As New AdoNet("VARIOSH", CONNH, DbProvedor)
        Dim CampoExist As Boolean
        Try
            DVarios.Open("select * from " + Tabla)
            DVariosH.Open("select * from " + Tabla)

            For Each Column As DataColumn In DVarios.DataTable.Columns
                CampoExist = True
                For Each Col As DataColumn In DVariosH.DataTable.Columns
                    CampoExist = False
                    If Col.ColumnName = Column.ColumnName Then
                        CampoExist = True
                        Exit For
                    End If
                Next
                If CampoExist = False Then
                    CreaCampo(Tabla, Column, CONNH)
                End If
            Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
    Private Sub CreaCampo(ByVal Tabla As String, ByVal Campo As DataColumn, ByVal CONNH As DbConnection)
        Dim Tipo As String
        Dim Comand As Common.DbCommand

        Try
            Comand = DbProvedor.CreateCommand

            If CONNH.State <> ConnectionState.Connecting Then CONNH.Open()

            Tipo = Campo.DataType.Name

            If Tipo = "Byte" OrElse Tipo = "Single" OrElse Tipo = "Int32" OrElse Tipo = "Short" OrElse Tipo = "Long" OrElse Tipo = "Double" Then
                Tipo = "REAL"
            ElseIf Tipo = "String" Then
                Tipo = "NVARCHAR(50)"
            ElseIf Tipo = "Boolean" Then
                Tipo = "Bit"
            End If

            Comand.Connection = CONNH
            Comand.CommandText = "alter Table " + Tabla + " ADD " + Campo.ColumnName + " " + Tipo + " NULL "

            Comand.ExecuteNonQuery()
            CONNH.Close()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Verificar el Servidor SQLSERVER"
    Public Function VerificaServSQL(ByVal ServidorSQL As String) As Boolean
        Dim SqlServer As DataTable
        Dim Servidores As DbDataSourceEnumerator
        Dim Ip() As Net.IPAddress
        Dim Host As String
        Dim ServExist As Boolean
        Try

            Servidores = DbProvedor.CreateDataSourceEnumerator
            SqlServer = Servidores.GetDataSources

            For Each servSQL As DataRow In SqlServer.Rows
                ServExist = False
                If Eval(ServidorSQL) = 127 OrElse ServidorSQL.ToUpper.Contains("HOST") Then
                    If ServidorSQL.Contains("\") Then
                        ServidorSQL = My.Computer.Name + Mid(ServidorSQL, InStr(ServidorSQL, "\"))
                    Else
                        ServidorSQL = My.Computer.Name
                    End If
                End If

                If Eval(ServidorSQL) > 0 Then
                    Ip = Net.Dns.GetHostAddresses(servSQL("ServerName"))
                    Host = Ip(0).ToString

                    If ServidorSQL.Contains("\") Then
                        'Ip = CLeft(ServidorSQL, InStr(ServidorSQL, "\") - 1)
                        'Host = Net.Dns.GetHostEntry(Ip).HostName.ToUpper + Mid(ServidorSQL, InStr(ServidorSQL, "\"))

                        If ServidorSQL.ToUpper = Host.ToUpper & "\" & servSQL("InstanceName").ToString.ToUpper Then
                            ServExist = True
                            Exit For
                        End If
                    Else

                        If ServidorSQL = Host Then
                            ServExist = True
                            Exit For
                        End If
                    End If

                    'Ip = Net.Dns.GetHostAddresses(servSQL("ServerName"))
                Else
                    If ServidorSQL.Contains("\") Then
                        If ServidorSQL.ToString.ToUpper = servSQL("ServerName").ToString.ToUpper & "\" & servSQL("InstanceName").ToString.ToUpper Then
                            ServExist = True
                            Exit For
                        End If
                        'servSQL("ServerName") & "\" & servSQL("InstanceName")
                    Else
                        If ServidorSQL.ToString.ToUpper = servSQL("ServerName").ToString.ToUpper Then
                            ServExist = True
                            Exit For
                        End If
                    End If
                End If
            Next

            Return ServExist

        Catch ex As Exception
            Return False
            MsgError(ex.ToString)
        End Try
    End Function
#End Region

#Region "Inventarios"

    Public Enum TipoInv As Integer
        CHRONOS = 1
        FISICO = 2
        UNO = 3
    End Enum

    Public Enum DetOperacion As Integer
        NINGUNO = 0
        ENMP = 1         'Entrada MP desde el módulo cortes
        CONSUMO = 2      'Consumos ChronoSoft
        SLPT = 3      'Despacho de  producto terminado
        INGMANUAL = 4  'Ingreso Manual(Det bache), entra consmos, entra bache
        LEEINVENTARIO = 5 'Lee inventario de sistema UNO
        SLMP = 6          'Salidas de MP en los cortes de lote
        ENPT = 7         'Entrada Producto terminado a bodega
        AJUSTEINVENTARIO = 8 'Ajuste de inventario
    End Enum







    Public Function TramaEtiquetaMP(ByVal Corte As String, ByVal CodInt As String, ByVal Nombre As String, Optional ByVal Lote As String = "", Optional ByVal Condicion As String = "-", Optional ByVal Ubicacion As String = "-", Optional ByVal PesoProm As String = "0") As String

        Dim Sentencia As String = ""
        Dim Separador As String = "K"

        TramaEtiquetaMP = ""
        Sentencia = "^XA" + vbNewLine
        Sentencia += "^FO50,10^ADN,10,10" + vbNewLine  'Ubicación Planta
        Sentencia += "^FD" + Planta + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO560,10^ADN,10,10" + vbNewLine 'Fecha Impresion
        Sentencia += "^FDFECHA IMP." + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO680,10^ADN,10,10^FD" + Now.ToString("yy/MM/dd") + vbNewLine
        Sentencia += "^FS" + vbNewLine

        'Parte de impresion de texto en la etiqueta


        Sentencia += "^FO50,185^ADN,15,15" + vbNewLine
        Sentencia += "^FDCODIGO: " + CLeft(CodInt, 10) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO400,185^ADN,15,15" + vbNewLine
        Sentencia += "^FDUBICACION: " + CLeft(Ubicacion, 3) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,225^ADN,15,15" + vbNewLine
        Sentencia += "^FD" + CLeft(Nombre, 25) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,265^ADN,15,15" + vbNewLine
        Sentencia += "^FDLOTE: " + CLeft(Lote, 15) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,305^ADN,15,15" + vbNewLine
        Sentencia += "^FDPESO PROMEDIO: " + CLeft(PesoProm, 5) + " Kg" + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,345^ADN,15,15" + vbNewLine
        Sentencia += "^FDCONDICION: " + CLeft(Condicion, 10) + vbNewLine
        Sentencia += "^FS" + vbNewLine

        'Parte para impresion del codigo de barras

        Sentencia += "^FO100,45^BY1.5,2" + vbNewLine
        Sentencia += "^B3N,N,100,Y,N" + vbNewLine
        Sentencia += "^FDINIMP" + Separador    '  INIXXX#  indica el inicio de trama
        Sentencia += Ubicacion + Separador  'Condición
        Sentencia += Replace(PesoProm, ",", ".") + Separador       'Peso promedio saco
        Sentencia += Corte + Separador 'Codigo corte
        Sentencia += "FIN" + vbNewLine  'Fin de trama 
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^XZ" + vbNewLine  'Fin de trama para impresion
        TramaEtiquetaMP = Sentencia

        

    End Function

    Public Function TramaEtiquetaPT(ByVal CodInt As String, ByVal Present As String, ByVal Nombre As String, Optional ByVal Lote As String = "", Optional ByVal Condicion As String = "-", Optional ByVal Ubicacion As String = "-", Optional ByVal Sacos As String = "0", Optional ByVal BachesMeta As String = "0", Optional ByVal Observ As String = "") As String

        Dim Sentencia As String = ""

        Dim Separador As String = "K"

        TramaEtiquetaPT = ""
        Sentencia = "^XA" + vbNewLine
        Sentencia += "^FO50,10^ADN,10,10" + vbNewLine  'Planta
        Sentencia += "^FD" + Planta + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO560,10^ADN,10,10" + vbNewLine 'Fecha Impresion
        Sentencia += "^FDFECHA IMP." + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO680,10^ADN,10,10^FD" + Now.ToString("yy/MM/dd") + vbNewLine
        Sentencia += "^FS" + vbNewLine



        'Parte para impresion del codigo de barras
        Sentencia += "^FO100,45^BY1.5,2" + vbNewLine
        Sentencia += "^B3N,N,100,Y,N" + vbNewLine
        Sentencia += "^FDINIPT" + Separador   '  INI  indica el inicio de trama
        Sentencia += Condicion + Separador  'Condición
        Sentencia += Ubicacion + Separador       'Campo Destino de la tabla empaque
        Sentencia += Present + Separador       'Presentacion
        Sentencia += Lote + Separador       'Como lote se maneja el numero de la OP
        'Sentencia += CodInt + Separador 'Codigo Producto
        Sentencia += "FIN" + vbNewLine  'Fin de trama 
        Sentencia += "^FS" + vbNewLine



        'Parte de impresion de texto en la etiqueta
        If Condicion = "NC" Then
            Condicion = "NO CONFORME"
        Else
            Condicion = "CONFORME"
        End If

        Sentencia += "^FO50,185^ADN,15,15" + vbNewLine
        Sentencia += "^FDCODIGO: " + CLeft(CodInt, 10) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO400,185^ADN,15,15" + vbNewLine
        Sentencia += "^FDUBICACION: " + CLeft(Ubicacion, 3) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,215^ADN,15,15" + vbNewLine
        Sentencia += "^FD" + CLeft(Nombre, 25) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,245^ADN,15,15" + vbNewLine
        Sentencia += "^FDLOTE: " + CLeft(Lote, 15) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO500,245^ADN,15,15" + vbNewLine
        Sentencia += "^FDSACOS: " + Sacos + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,275^ADN,12,12" + vbNewLine
        Sentencia += "^FD" + Condicion + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO300,275^ADN,12,12" + vbNewLine
        Sentencia += "^FDPRESENT: " + Present + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO500,275^ADN,12,12" + vbNewLine
        Sentencia += "^FDBACHES: " + BachesMeta + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,315^ADN,10,10" + vbNewLine
        Sentencia += "^FD" + CLeft(Observ, 58) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^XZ" + vbNewLine  'Fin de trama para impresion
        TramaEtiquetaPT = Sentencia

    End Function

    Public Function TramaEtiquetaEMET(ByVal CodInt As String, ByVal Nombre As String, ByVal Ubicacion As String, ByVal Tipo As String) As String

        Dim Sentencia As String = ""

        Dim Separador As String = "K"

        TramaEtiquetaEMET = ""
        Sentencia = "^XA" + vbNewLine
        Sentencia += "^FO50,10^ADN,10,10" + vbNewLine  'Planta
        Sentencia += "^FD" + Planta + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO560,10^ADN,10,10" + vbNewLine 'Fecha Impresion
        Sentencia += "^FDFECHA IMP." + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO680,10^ADN,10,10^FD" + Now.ToString("yy/MM/dd") + vbNewLine
        Sentencia += "^FS" + vbNewLine


        'Parte para impresion del codigo de barras
        Sentencia += "^FO100,45^BY1.5,2" + vbNewLine
        Sentencia += "^B3N,N,100,Y,N" + vbNewLine
        Sentencia += "^FDINI" + Tipo + Separador   '  INI  indica el inicio de trama
        Sentencia += CodInt + Separador  'Codigo
        Sentencia += Ubicacion + Separador       'Ubicacion
        Sentencia += "FIN" + vbNewLine  'Fin de trama 
        Sentencia += "^FS" + vbNewLine


        Sentencia += "^FO50,185^ADN,15,15" + vbNewLine
        Sentencia += "^FDCODIGO: " + CLeft(CodInt, 10) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,215^ADN,15,15" + vbNewLine
        Sentencia += "^FD" + CLeft(Nombre, 25) + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO50,245^ADN,15,15" + vbNewLine
        Sentencia += "^FDUBICACION: " + Ubicacion + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^XZ" + vbNewLine  'Fin de trama para impresion
        TramaEtiquetaEMET = Sentencia

    End Function

    Public Function TramaEtiquetaPR(ByVal OP As String)
        Dim CodInt As String = ""
        Dim Sentencia As String = ""
        Dim Separador As String = "K"
        Dim Peso As String
        Dim DDatosFor As New AdoNet("DATOSFOR", CONN, DbProvedor)
        Dim DOPs As New AdoNet("OPs", CONN, DbProvedor)

        DOPs.Open("select * from OPS where OP='" + OP + "'")

        DDatosFor.Open("select * from DATOSFOR where CODFOR='" + DOPs.RecordSet("CODFOR") + "' and LP='" + DOPs.RecordSet("LP") + "' and TIPOMAT=7")

        Peso = DDatosFor.RecordSet("PESOMETA").ToString
        CodInt = DDatosFor.RecordSet("CODMAT").ToString


        Sentencia = "^XA" + vbNewLine
        Sentencia += "^FO50,10^ADN,10,10" + vbNewLine  'Planta
        Sentencia += "^FD" + Planta + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO560,10^ADN,10,10" + vbNewLine 'Fecha Impresion
        Sentencia += "^FDFECHA IMP." + vbNewLine
        Sentencia += "^FS" + vbNewLine
        Sentencia += "^FO680,10^ADN,10,10^FD" + Now.ToString("yy/MM/dd") + vbNewLine
        Sentencia += "^FS" + vbNewLine

        'Parte para impresion del codigo de barras
        Sentencia += "^FO50,45^BY1.5,2" + vbCrLf
        Sentencia += "^B3N,N,100,Y,N" + vbCrLf
        Sentencia += "^FDINIPR" + Separador
        Sentencia += OP + Separador + Peso + Separador
        Sentencia += "FIN" + vbNewLine  'Fin de trama 
        Sentencia += "^FS" + vbCrLf

        Sentencia += "^FO50,168^ADN,30,30" + vbCrLf
        Sentencia += "^FDOP:" + OP + vbCrLf
        Sentencia += "^FS" + vbCrLf
        Sentencia += "^FO400,174^ADN,15,15" + vbCrLf
        Sentencia += "^FDCODIGO:" + CodInt + vbCrLf
        Sentencia += "^FS" + vbCrLf
        Sentencia += "^FO50,208^ADN,30,30" + vbCrLf
        Sentencia += "^FDPESO:" + Peso + " Kg" + vbCrLf
        Sentencia += "^FS" + vbCrLf
        Sentencia += "^FO50,248^ADN,30,30" + vbCrLf
        Sentencia += "^FDFORM:" + DDatosFor.RecordSet("CODFORB").ToString + vbCrLf
        Sentencia += "^FS" + vbCrLf
        Sentencia += "^FO400,254^ADN,15,15" + vbCrLf
        Sentencia += "^FDNO.ORDEN:" + DOPs.RecordSet("LP").ToString + vbCrLf
        Sentencia += "^FS" + vbCrLf
        Sentencia += "^FO50,304^ADN,25,25" + vbCrLf
        Sentencia += "^FD" + vbCrLf
        Sentencia += DOPs.RecordSet("NOMFOR").ToString + vbCrLf
        Sentencia += "^FS" + vbCrLf
        Sentencia += "^FO50,344^ADN,10,10" + vbNewLine
        Sentencia += "^FD" + DOPs.RecordSet("OBSERVOP").ToString + vbNewLine
        Sentencia += "^FS" + vbNewLine


        Sentencia += "^XZ" + vbCrLf
        TramaEtiquetaPR = Sentencia
    End Function


#End Region


#Region "Metodo para el descuento de los cortes de Materia prima"
    Public Sub CortesLote(ByVal CodMat As String, ByVal Cantidad As Single, ByRef Lote As String, ByRef Corte As String)
        Try
            Dim DCortesMP As AdoNet
            Dim DObsCortesMP As AdoNet
            Dim EntInventario As Double = 0
            Dim SalidaInventario As Double = 0

            If CodMat = "" Or Cantidad <= 0 Then
                ' Throw New ArgumentException( _
                '       "Parametros no válidos para el metodo de cortes MP")
                Evento("Parametros no válidos para el metodo de cortes MP CodMat " + CodMat.ToString + " Cant. " + Cantidad.ToString)
                Return
            End If

            Lote = ""
            Corte = ""
            DCortesMP = New AdoNet("CORTESLOTE", CONN, DbProvedor)
            DObsCortesMP = New AdoNet("OBSCORTESMP", CONN, DbProvedor)

            DCortesMP.Open("select * from CORTESLOTE where CODMAT='" + CodMat + "' and ESTADO='A'")

            If DCortesMP.RecordCount = 0 Then Return

            'Se buscan las entradas de inventario en la tabla OBSCORTES donde tipo=3
            DObsCortesMP.Open("select SUM(CANTIDAD) as ENTINVENTARIO from OBSCORTESMP where CORTE=" + DCortesMP.RecordSet("CONT").ToString + " and TIPO=3")

            If DObsCortesMP.RecordCount AndAlso Not IsDBNull(DObsCortesMP.RecordSet("ENTINVENTARIO")) Then
                EntInventario = DObsCortesMP.RecordSet("ENTINVENTARIO")
            End If

            'Se buscan las salidas de inventario en la tabla OBSCORTES donde tipo=4
            DObsCortesMP.Open("select SUM(CANTIDAD) as SALINVENTARIO from OBSCORTESMP where CORTE=" + DCortesMP.RecordSet("CONT").ToString + " and TIPO=4")

            If DObsCortesMP.RecordCount AndAlso Not IsDBNull(DObsCortesMP.RecordSet("SALINVENTARIO")) Then
                SalidaInventario = DObsCortesMP.RecordSet("SALINVENTARIO")
            End If

            DCortesMP.RecordSet("CONSUMO") += Cantidad

            If (DCortesMP.RecordSet("INVINI") + EntInventario - (DCortesMP.RecordSet("CONSUMO") + SalidaInventario)) < DCortesMP.RecordSet("Alarma") Then
                Evento("Alarma de CORTE DE LOTE " + DCortesMP.RecordSet("NOMMAT").ToString)
                Alarma("Alarma de CORTE DE LOTE " + DCortesMP.RecordSet("NOMMAT").ToString)
            End If
            If Eval(DCortesMP.RecordSet("FECHAINI").ToString) = 0 Then DCortesMP.RecordSet("FECHAINI") = Format(Now, "yyyy/MM/dd HH:mm:ss")
            DCortesMP.RecordSet("FECHAFIN") = Format(Now, "yyyy/MM/dd HH:mm:ss")
            Corte = DCortesMP.RecordSet("CONT")
            Lote = DCortesMP.RecordSet("Lote")
            DCortesMP.Update()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Metodo para el Manejo de las Tolvas"

    Public Enum ProcesoPlanta As Integer
        DOSIFICACION = 1
        EMPAQUE = 2
        PELETIZADO = 3
    End Enum

    Public Sub DescTolvas(ByVal Tolva As String, ByVal Cantidad As Single, ByVal CodMat As String, ByVal Proceso As ProcesoPlanta, Optional ByVal OP As String = "-")
        Try
            Dim DTolvas As AdoNet
            Dim DArt As AdoNet
            Dim DTolvasHist As AdoNet
            Dim DRetaque As AdoNet
            Dim DCortesMP As AdoNet
            If Convert.ToInt32(Tolva) = 0 OrElse Cantidad = 0 Then
                Return
            End If

            DTolvas = New AdoNet("TOLVAS", CONN, DbProvedor)
            DArt = New AdoNet("Articulos", CONN, DbProvedor)
            DTolvasHist = New AdoNet("TOLVASHIST", CONN, DbProvedor)
            DRetaque = New AdoNet("RETAQUE", CONN, DbProvedor)
            DCortesMP = New AdoNet("CORTESLOTE", CONN, DbProvedor)



            DTolvasHist.Open("select * from TolvasHist where CONT=0")
            DRetaque.Open("select * from Retaque where CONT=0")

            DTolvas.Open("select * from TOLVAS where TOLVA=" + Tolva + " and PROCESO='" + Proceso.ToString + "'")
            If DTolvas.RecordCount = 0 Then Return

            DTolvas.RecordSet("TOTAL") += Cantidad
            DTolvas.RecordSet("OP") = OP
            If DTolvas.RecordSet("ALARMA") > 0 And DTolvas.RecordSet("TOTAL") < DTolvas.RecordSet("ALARMA") Then
                Alarma("Nivel mínimo de " + Trim(DTolvas.RecordSet("Nombre")) + " Tolva " + Tolva.ToString)
            End If
            If DTolvas.RecordSet("TOTAL") < -10000 Then DTolvas.RecordSet("TOTAL") = 0
            If DTolvas.RecordSet("CODINT") <> CodMat Then
                '                                Evento "CAMBIO EN TOLVA " + Trim(Tolva) + " de cód:" + Trim(DTolvas.Recordset("CODMAT")) + " a cód: " + Trim(CodMatTolva)
                DTolvas.RecordSet("CODINT") = CodMat
                DArt.Open("select * from ARTICULOS where CODINT='" + CodMat.ToString + "'")
                If DArt.RecordCount > 0 Then
                    DTolvas.RecordSet("NOMBRE") = CLeft(DArt.RecordSet("NOMBRE"), 30)
                Else
                    DTolvas.RecordSet("NOMBRE") = "-"
                End If
            End If


            DTolvasHist.AddNew()
            DTolvasHist.RecordSet("TOLVA") = DTolvas.RecordSet("TOLVA")
            DTolvasHist.RecordSet("FECHA") = Now.ToString("yyyy/MM/dd HH:mm:ss")
            DTolvasHist.RecordSet("ACTIVA") = DTolvas.RecordSet("ACTIVA")
            DTolvasHist.RecordSet("CODINT") = DTolvas.RecordSet("CODINT")
            DTolvasHist.RecordSet("NOMBRE") = DTolvas.RecordSet("NOMBRE")
            DTolvasHist.RecordSet("TOTAL") = DTolvas.RecordSet("TOTAL")
            DTolvasHist.RecordSet("OP") = DTolvas.RecordSet("OP")
            DTolvasHist.RecordSet("PROCESO") = Proceso.ToString

            DTolvasHist.Update()

            DTolvas.Update()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Suma Paquete Premezclas"

    Public Function SumPaqPrem(ByVal CodFor As String, ByVal LP As String) As Double
        SumPaqPrem = 0
        Dim DDatosFor As AdoNet
        DDatosFor = New AdoNet("Datosfor", CONN, DbProvedor)

        DDatosFor.Open("Select PESOMETA from DATOSFOR where TIPOMAT=7 AND CODFOR='" + CodFor + "' and LP='" + LP + "'")

        If DDatosFor.RecordCount = 0 Then
            SumPaqPrem = 0
            Exit Function
        End If
        If Not IsDBNull(DDatosFor.RecordSet("PESOMETA")) Then SumPaqPrem = DDatosFor.RecordSet("PESOMETA")
    End Function

#End Region

#Region "Valida baches por tanda de premezclas"

    Public Function FValidaTandas(ByVal Codfor As String, ByVal LP As String, ByVal Tandas As Int16, ByVal Porc As Int32)
        Dim DDatosFor As AdoNet
        Dim DBasculas As AdoNet
        Dim Capac As Double

        FValidaTandas = True
        DDatosFor = New AdoNet("DATOSFOR", CONN, DbProvedor)
        DBasculas = New AdoNet("basculas", CONN, DbProvedor)

        DBasculas.Open("Select * from BASCULAS where TIPOMAT=6")
        If DBasculas.RecordCount > 0 Then
            Capac = DBasculas.RecordSet("CAPAC")
        Else
            FValidaTandas = False
            Exit Function
        End If



        DDatosFor.Open("Select * from DATOSFOR where TIPOMAT=6 and CODFOR='" + Codfor + "' and LP='" + LP + "'")

        For Each Recordset As DataRow In DDatosFor.Rows

            If Recordset("PESOMETA") * Porc / 100 * Tandas > Capac Then
                FValidaTandas = False
                Exit Function
            End If
        Next

    End Function



#End Region


#Region "Filtros Formulación"

    'Función que crea los radiobutton necesarios para aplicar filtros en los formularios de formulación y fórmulas
    'Máximo hasta 12 filtros. El OPTodos se deja fijo en el formulario porque eses filtro siempre va.

    Public Sub FiltrosFormulacion(ByVal GB As GroupBox, ByVal OPFiltro As RadioButton, ByVal PosIniX As Int16, ByVal PosIniY As Int16)


        Dim DFormFiltros As AdoNet
        DFormFiltros = New AdoNet("FormFiltros", CONN, DbProvedor)
        DFormFiltros.Open("Select * from FORMFILTROS where habilitado=1 and PLANTA='" + Planta + "' order by POSICION")

        Dim Y As Integer = 1
        Dim X As Integer = 0
        Dim Count As Integer = 1

        For Each Recordset As DataRow In DFormFiltros.Rows

            If Count > 12 Then Exit For
            Dim RB As RadioButton = New RadioButton()
            With OPFiltro
                RB.Name = "OPFiltro" + Count.ToString
                RB.Location = New Point(PosIniX + X, PosIniY * Y)
                RB.Size = .Size
            End With
            RB.Text = CLeft(Recordset("NOMFILTRO"), 10)
            'OP.BackColor = Color.SteelBlue
            RB.Parent = GB
            RB.AutoSize = True
            If Y > 4 Then
                Y = 1
                X = 100
            Else
                Y += 1
            End If
            Count += 1
        Next

    End Sub


#End Region

#Region "Filtros Recepción Empaque"

    'Función que crea los radiobutton necesarios para aplicar filtros en los formularios de recepción de empaque y recepción de empaque costos
    'Máximo hasta 15 filtros.

    Public Sub FiltrosRecEmpaque(ByVal GB As GroupBox, ByVal OPFiltro As RadioButton, ByVal PosIniX As Int16, ByVal PosIniY As Int16)


        Dim DUbicaciones As AdoNet
        DUbicaciones = New AdoNet("UBICACIONES", CONN, DbProvedor)
        DUbicaciones.Open("Select * from UBICACIONES where TIPO='PT' and POSICION>0 and HABILITADA=1 and PLANTA='" + Planta + "' order by posicion")

        Dim Y As Integer = 20
        Dim X As Integer = 150
        Dim Count As Integer = 1
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0

        For Each Recordset As DataRow In DUbicaciones.Rows

            If Count > 15 Then Exit For
            Dim RB As RadioButton = New RadioButton()
            With OPFiltro
                RB.Name = "OPFiltro" + Count.ToString
                RB.Location = New Point(PosIniX + Columna * X, PosIniY + Fila * Y)
                RB.Size = .Size
                RB.Font = .Font
            End With
            RB.Text = CLeft(Recordset("DESCRIPCION"), 20)
            'OP.BackColor = Color.SteelBlue
            RB.Parent = GB
            RB.AutoSize = True
            RB.Visible = True
            If Count Mod 5 = 0 Then
                Columna = 0
                Fila += 1
            Else
                Columna += 1
            End If
            Count += 1
        Next
    End Sub


#End Region



#Region "FechaC"
    Public Function FechaC() As String
        FechaC = Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Function
#End Region

End Module

