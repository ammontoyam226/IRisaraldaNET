
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Grafica

    Private _CodProd As String
    Private _Maquina As Int16
    Private _FechaIni As Date
    Private DDatos As AdoSQL
    Private DProd As AdoSQL
    Private DVarios As AdoSQL
    Private DTurnos As AdoSQL
    Private _Tabla As String
    Private ValorEjeX As Double
    Private ValorEjeY As Double
    Private _Incremento As Int16
    Private _Intervalo As Int16
    Private XLimSup As Int16
    Private FechaIni As String
    Private FechaFin As String
    Private _MuestrasGraf As Int16
    Private _MuestrasDia As Int16
    Private _MaquinaDB As Int16
    Private AuxMaqDB As String
    Private PesoNom As Double
    Private LimInf As Double
    Private LimSup As Double
    Private ErrorT1 As Double
    Private ErrorT2 As Double
    Private HoraInt As Short
    Private Turno As Short

    'Constructor de la clase
    Public Sub New()
        MyBase.New()

        DDatos = New AdoSQL("DATOS")
        DProd = New AdoSQL("ARTICULOS")
        DVarios = New AdoSQL("VARIOS")
        DTurnos = New AdoSQL("TURNOS")

    End Sub

    'Propiedades de la clase

    Public Property CodProd() As String
        Get
            Return _CodProd
        End Get
        Set(value As String)
            _CodProd = value
        End Set
    End Property

    Public Property Maq() As Int16
        Get
            Return _Maquina
        End Get
        Set(value As Int16)
            _Maquina = value
        End Set
    End Property

    Public WriteOnly Property Fecha As Date
        Set(value As Date)
            _FechaIni = value
        End Set
    End Property

    Public WriteOnly Property Tabla As String
        Set(value As String)
            _Tabla = value
        End Set
    End Property

    Public WriteOnly Property Incremento As Int16
        Set(value As Int16)
            _Incremento = value
        End Set
    End Property

    Public WriteOnly Property Intervalo As Int16
        Set(value As Int16)
            _Intervalo = value
        End Set
    End Property

    Public ReadOnly Property MuestrasGraf As Int16
        Get
            Return _MuestrasGraf
        End Get
    End Property

    Public ReadOnly Property MuestrasDia As Int16
        Get
            Return _MuestrasDia
        End Get
    End Property


    Public ReadOnly Property FechaInicial As String
        Get
            Return FechaIni
        End Get
    End Property


    Public ReadOnly Property FechaFinal As String
        Get
            Return FechaFin
        End Get
    End Property
    'Metodo graficar

    Public Sub FGraficar(ByRef Grafica As Chart, ByRef GraficaOK As Boolean, ByVal Proceso As String)

        Try
            'Validaciones
            If Grafica Is Nothing Then Return
            If Val(_Maquina) = 0 Then Return
            If IsDBNull(_FechaIni) Then Return


            
            Grafica.Titles(0).Text = ""
            Grafica.Series.Clear()
            _MaquinaDB = 0


            'Se mapea el número de grafica con la maquina de la base de datos

            If Proceso = "ELECSTER 1 Y 2" Then
                _MaquinaDB = _Maquina
            End If

            If Proceso = "BUANLIR 1 Y 2" Then
                If _Maquina = 1 Then _MaquinaDB = 13
                If _Maquina = 2 Then _MaquinaDB = 14
                If _Maquina = 4 Then _MaquinaDB = 18
                If _Maquina = 5 Then _MaquinaDB = 19
            End If

            If Proceso = "ELECSTER 3" Then
                If _Maquina = 1 Then _MaquinaDB = 15
                If _Maquina = 2 Then _MaquinaDB = 16
                If _Maquina = 3 Then _MaquinaDB = 17
            End If

            If Proceso = "BUANLIR 3" Then
                If _Maquina = 1 Then _MaquinaDB = 10
                If _Maquina = 2 Then _MaquinaDB = 11
                If _Maquina = 3 Then _MaquinaDB = 12
            End If

            If Proceso = "TETRA" Then
                If _Maquina = 1 Then _MaquinaDB = 70
                If _Maquina = 2 Then _MaquinaDB = 80
                If _Maquina = 3 Then _MaquinaDB = 81
                If _Maquina = 4 Then _MaquinaDB = 90
                If _Maquina = 5 Then _MaquinaDB = 91
            End If

            If Proceso = "IS6" Then
                If _Maquina = 1 Then _MaquinaDB = 20
                If _Maquina = 2 Then _MaquinaDB = 21
                If _Maquina = 3 Then _MaquinaDB = 22
            End If
            
            FechaFin = _FechaIni.ToString("yyyy/MM/dd HH:mm")
            FechaIni = DateAdd(DateInterval.Hour, -_Intervalo, _FechaIni).ToString("yyyy/MM/dd HH:mm")

            'Revisamos el turno de operación para dejar la horaini del turno
            DTurnos.Open("Select * from TURNOS")

            HoraInt = Val(CDate(_FechaIni).Hour.ToString)

            If (HoraInt >= 22 AndAlso HoraInt <= 24) Or HoraInt < 6 Then
                Turno = 1
            ElseIf HoraInt >= 6 AndAlso HoraInt < 14 Then
                Turno = 2
            ElseIf HoraInt >= 14 AndAlso HoraInt < 22 Then
                Turno = 3
            End If

            If Val(CDate(FechaIni).Hour.ToString) < 22 And Turno = 1 Then
                DTurnos.Find("TURNO=1")
                FechaIni = CDate(FechaIni).ToString("yyyy/MM/dd") + " " + DTurnos.RecordSet("HORAINI")
            ElseIf Val(CDate(FechaIni).Hour.ToString) < 6 And Turno = 2 Then
                DTurnos.Find("TURNO=2")
                FechaIni = CDate(FechaIni).ToString("yyyy/MM/dd") + " " + DTurnos.RecordSet("HORAINI")
            ElseIf Val(CDate(FechaIni).Hour.ToString) < 14 And Turno = 3 Then
                DTurnos.Find("TURNO=3")
                FechaIni = CDate(FechaIni).ToString("yyyy/MM/dd") + " " + DTurnos.RecordSet("HORAINI")
            End If


            If _Intervalo = 1 Then
                Incremento = 0.1
            ElseIf _Intervalo = 4 Then
                Incremento = 0.5
            Else
                Incremento = 1
            End If

            DVarios.Open("select top 1 * from DATOS where FECHA BETWEEN '" + FechaIni + "' AND '" + FechaFin + "'" + _
                      " and MAQ=" + _MaquinaDB.ToString + " ORDER BY FECHA DESC")

            If DVarios.RecordCount > 0 Then
                CodProd = DVarios.RecordSet("CodProd")
            Else
                GraficaOK = False
                Return
            End If

            Grafica.Series.Add("Peso")
            Grafica.Series("Peso").ChartType = SeriesChartType.FastLine
            Grafica.Series("Peso").XValueType = ChartValueType.Time

            Grafica.Series("Peso").YValueType = ChartValueType.Double
            Grafica.Series("Peso").Color = Color.Blue
            Grafica.Series("Peso").BorderWidth = 1.5

            Grafica.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Hours


            Grafica.Series.Add("LimInf")
            Grafica.Series("LimInf").ChartType = SeriesChartType.FastLine
            Grafica.Series("LimInf").XValueType = ChartValueType.Time
            Grafica.Series("LimInf").YValueType = ChartValueType.Double
            Grafica.Series("LimInf").Color = Color.Red
            Grafica.Series("LimInf").BorderWidth = 0.5
            Grafica.Series("LimInf").BorderDashStyle = ChartDashStyle.Dash

            Grafica.Series.Add("LimSup")
            Grafica.Series("LimSup").ChartType = SeriesChartType.FastLine
            Grafica.Series("LimSup").XValueType = ChartValueType.Time
            Grafica.Series("LimSup").YValueType = ChartValueType.Double
            Grafica.Series("LimSup").BorderDashStyle = ChartDashStyle.Dash
            Grafica.Series("LimSup").Color = Color.Red
            Grafica.Series("LimSup").BorderWidth = 0.5

            Grafica.Series.Add("PesoNom")
            Grafica.Series("PesoNom").ChartType = SeriesChartType.FastLine
            Grafica.Series("PesoNom").XValueType = ChartValueType.Time
            Grafica.Series("PesoNom").YValueType = ChartValueType.Double
            Grafica.Series("PesoNom").BorderDashStyle = ChartDashStyle.Dash
            Grafica.Series("PesoNom").Color = Color.Green
            Grafica.Series("PesoNom").BorderWidth = 1

            DProd.Open("Select * from ARTICULOS where TIPO='PT' and CODINT='" + _CodProd + "'")
            If DProd.RecordCount = 0 Then
                GraficaOK = False
                Return
            End If


            PesoNom = DProd.RecordSet("PESONOM")
            LimSup = PesoNom + DProd.RecordSet("TOLERANCIA")
            LimInf = PesoNom - DProd.RecordSet("TOLERANCIA")
            ErrorT1 = DProd.RecordSet("ERRORT1")
            ErrorT2 = DProd.RecordSet("ERRORT2")

            Grafica.Titles(0).Text = "Máquina # " + _MaquinaDB.ToString + ": " + DProd.RecordSet("NOMBRE")

            Grafica.ChartAreas(0).AxisY.Minimum = LimInf - 5
            Grafica.ChartAreas(0).AxisY.Maximum = LimSup + 5
            Grafica.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Hours


            Grafica.ChartAreas(0).AxisX.Interval = _Incremento
            'Grafica.ChartAreas(0).AxisX.Interval = 0.5
            Grafica.ChartAreas(0).AxisX.IsLabelAutoFit = False
            'grafica(Maquina).ChartAreas(0).AxisX2.IntervalType = DateTimeIntervalType.Minutes
            'grafica(Maquina).ChartAreas(0).AxisX2.Interval = 0.5

            Grafica.ChartAreas(0).CursorX.IsUserSelectionEnabled = True
            Grafica.ChartAreas(0).CursorX.IsUserEnabled = True



            DVarios.Open("select codprod from DATOS where FECHA >='" + CDate(FechaIni).ToString("yyyy/MM/dd") + "' AND CODPROD='" + CodProd + _
                            "' and MAQ=" + _MaquinaDB.ToString + " ORDER BY FECHA DESC")

            If DVarios.RecordCount > 0 Then _MuestrasDia = DVarios.RecordCount


            'Graficamos los límites y el peso nominal


            'Abrimos la consulta para cargar los datos a mostrar
            DDatos.Open(" Select PESO,FECHA from DATOS where PESO<>0 AND MAQ=" + _MaquinaDB.ToString + " AND CODPROD='" + CodProd _
              + "' AND FECHA BETWEEN '" + FechaIni + "' AND '" + FechaFin + "' order by fecha")

            _MuestrasGraf = DDatos.RecordCount

            For Each Fila As DataRow In DDatos.Rows
                ValorEjeY = Fila("PESO")
                Dim X As Date = CDate(Fila("FECHA"))
                'ValorEjeX = Math.Round(DateDiff(DateInterval.Second, CDate(FechaIni), CDate(Fila("Fecha"))) / 60, 2)
                If ValorEjeY < 0 Then ValorEjeY = 0
                'Grafica.Series("Peso").Points.AddXY(ValorEjeX, ValorEjeY)
                Grafica.Series("Peso").Points.AddXY(X, ValorEjeY)
                Grafica.Series("PesoNom").Points.AddXY(X, PesoNom)
                Grafica.Series("LimInf").Points.AddXY(X, LimInf)
                Grafica.Series("LimSup").Points.AddXY(X, LimSup)
            Next

            GraficaOK = True

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
















End Class
