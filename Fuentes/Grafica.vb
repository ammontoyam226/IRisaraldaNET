
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Grafica

    Private _CodProd As String
    Private _Maquina As Int16
    Private _Basc As Int16
    Private _FechaIni As Date
    Private DDatos As AdoSQL
    Private DProd As AdoSQL
    Private DVarios As AdoSQL
    Private DTurnos As AdoSQL
    Private DEmp As AdoSQL
    Private _Tabla As String
    Private ValorEjeX As Double
    Private ValorEjeY As Double
    Private _Incremento As Int16
    Private _Intervalo As Int16
    Private XLimSup As Int16
    Private FechaIni As Date
    Private FechaFin As Date
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
    Private Mensaje, AuxMensaje As String
    Private FechaIniString As String
    Private FechaFinString As String

    'Constructor de la clase
    Public Sub New()
        MyBase.New()

        DDatos = New AdoSQL("DATOS")
        DProd = New AdoSQL("ARTICULOS")
        DVarios = New AdoSQL("VARIOS")
        DTurnos = New AdoSQL("TURNOS")
        DEmp = New AdoSQL("EMPAQUE")

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

    Public Property Basc() As Int16
        Get
            Return _Basc
        End Get
        Set(value As Int16)
            _Basc = value
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

    Public Sub FGraficar(ByRef Grafica As Chart)

        Try
            'Validaciones
            If Grafica Is Nothing Then Return
            If Val(_Maquina) = 0 Then Return
            If IsDBNull(_FechaIni) Then Return

            Grafica.Titles(0).Text = "CARTA DE CONTROL PESO NETO ENSACADORA " + _Maquina.ToString + " BÁSCULA " + _Basc.ToString
            Grafica.Titles(0).ForeColor = Color.Red
            Grafica.Series.Clear()

            FechaFin = DateAdd(DateInterval.Hour, _Intervalo, _FechaIni)
            FechaIni = _FechaIni

            FechaIniString = FechaIni.ToString("yyyy-MM-dd HH:00:00")
            FechaFinString = FechaFin.ToString("yyyy-MM-dd HH:00:00")

            If _Intervalo = 1 Then
                Incremento = 0.1
            ElseIf _Intervalo = 4 Then
                Incremento = 0.5
            Else
                Incremento = 1
            End If

            DEmp.Open("select distinct CODPROD from EMPAQUE" + _Maquina.ToString + " where MAQUINA=" + _Maquina.ToString + " and FECHA between '" + FechaIniString + "' and '" + FechaFinString + "'")


            If DEmp.RecordCount = 0 Then
                'GraficaOK = False
                Return
            End If

            Dim CodProds() As Long

            Mensaje = ""
            AuxMensaje = ""

            ReDim CodProds(DEmp.RecordCount)


            If DEmp.RecordCount > 1 Then
                ' Se evalua si es algunas de las empacadoras para mostrar el producto que estan empacando sino piden que ingresen el producto a graficar
                If ServComM = True Or GraficosEmp.ChActAutom.Checked Then

                    DEmp.Open("select * from EMPAQUE" + _Maquina.ToString + " where MAQUINA=" + _Maquina.ToString + " and FECHA between '" + FechaIniString + "' and '" + FechaFinString + "' order by CONT desc")


                    DVarios.Open("select * from PESOSCHK where MAQUINA=" + _Maquina.ToString + " and CODPROD='" + DEmp.RecordSet("CodProd") + "' and BASCULA=" + _Basc.ToString + " and FECHA between '" + FechaIniString + "' and '" + FechaFinString + "' order by Fecha")

                Else
                    Mensaje = " En el Intervalo de Tiempo Seleccionado se empacaron Varios Productos " + vbCrLf + _
                    " Los Productos son: " + vbCrLf
                    Dim i = 0
                    For Each Fila As DataRow In DEmp.Rows
                        DProd.Open("select * from PRODUCTOS where CODPROD='" + DEmp.RecordSet("CodProd") + "'")
                        If DProd.RecordCount Then
                            AuxMensaje = AuxMensaje + DProd.RecordSet("CodProd") + " " + DProd.RecordSet("NomProd") + vbCrLf
                            CodProds(i) = Eval(DProd.RecordSet("CodProd"))
                        Else
                            AuxMensaje = AuxMensaje + "------ Producto " + Trim(DEmp.RecordSet("CodProd")) + " no Existe " + vbCrLf
                            CodProds(i) = 0
                        End If
                        i = i + 1
                    Next
                    Mensaje = Mensaje + AuxMensaje + " Ingrese el Código del Producto del Cual desea Observar la Grafica"
                    RespInput = ""
                    InputBox.InputBox("ChronoSoft", Mensaje, RespInput)
                    If Eval(RespInput) > 0 Then
                        Dim CodOk As Boolean
                        CodOk = False
                        For i = 0 To DEmp.RecordCount - 1
                            If CodProds(i) = RespInput Then CodOk = True
                        Next i
                        If CodOk = False Then
                            MsgBox("Ingrese un Código valido para el Producto", vbExclamation)
                            Exit Sub
                        End If

                        'selecciono los datos de los sacos chequeados en un intervalo de una Hora
                        DVarios.Open("select * from PESOSCHK where MAQUINA=" + _Maquina.ToString + " and CODPROD='" + Trim(RespInput) + "' and BASCULA=" + _Basc.ToString + " and FECHA between '" + FechaIniString + "' and '" + FechaFinString + "' order by Fecha")
                    End If
                End If
            Else

                'selecciono los datos de los sacos chequeados en un intervalo de una Hora
                DVarios.Open("select * from PESOSCHK where MAQUINA=" + _Maquina.ToString + " and CODPROD='" + DEmp.RecordSet("CodProd") + "' and BASCULA=" + _Basc.ToString + " and FECHA between '" + FechaIniString + "' and '" + FechaFinString + "' order by Fecha")

            End If


            If DVarios.RecordCount = 0 Then
                'MsgBox "No se realizo Chequeo de Sacos Verifique la cantidad de sacos empacados en el intervalo de tiempo seleccionado", vbInformation
                Aviso.Label1.Text = "No se realizó Cheq. de Sacos Verif. la cantidad de sacos empacad. en el interv. de tiempo seleccionado Empac. " + _Maquina.ToString
                Aviso.Show()
                Exit Sub
            End If
            _CodProd = ""
            _CodProd = DVarios.RecordSet("CODPROD")

            Grafica.Series.Add("Peso")
            Grafica.Series("Peso").ChartType = SeriesChartType.Line
            Grafica.Series("Peso").XValueType = ChartValueType.Time
            Grafica.Series("Peso").YValueType = ChartValueType.Double
            Grafica.Series("Peso").Color = Color.Red
            Grafica.Series("Peso").BorderWidth = 1.5


            Grafica.Series.Add("LimInf")
            Grafica.Series("LimInf").ChartType = SeriesChartType.FastLine
            Grafica.Series("LimInf").XValueType = ChartValueType.Time
            Grafica.Series("LimInf").YValueType = ChartValueType.Double
            Grafica.Series("LimInf").Color = Color.Blue
            Grafica.Series("LimInf").BorderWidth = 0.5
            Grafica.Series("LimInf").BorderDashStyle = ChartDashStyle.Dash

            Grafica.Series.Add("LimSup")
            Grafica.Series("LimSup").ChartType = SeriesChartType.FastLine
            Grafica.Series("LimSup").XValueType = ChartValueType.Time
            Grafica.Series("LimSup").YValueType = ChartValueType.Double
            Grafica.Series("LimSup").BorderDashStyle = ChartDashStyle.Dash
            Grafica.Series("LimSup").Color = Color.Blue
            Grafica.Series("LimSup").BorderWidth = 0.5

            Grafica.Series.Add("PesoNom")
            Grafica.Series("PesoNom").ChartType = SeriesChartType.FastLine
            Grafica.Series("PesoNom").XValueType = ChartValueType.Time
            Grafica.Series("PesoNom").YValueType = ChartValueType.Double
            Grafica.Series("PesoNom").BorderDashStyle = ChartDashStyle.Dash
            Grafica.Series("PesoNom").Color = Color.Green
            Grafica.Series("PesoNom").BorderWidth = 1

            Grafica.Series.Add("PesoPunto")
            Grafica.Series("PesoPunto").ChartType = SeriesChartType.Point
            Grafica.Series("PesoPunto").XValueType = ChartValueType.Time
            Grafica.Series("PesoPunto").YValueType = ChartValueType.Double
            Grafica.Series("PesoPunto").BorderDashStyle = ChartDashStyle.Solid
            Grafica.Series("PesoPunto").Color = Color.Black
            Grafica.Series("PesoPunto").MarkerSize = 8
            Grafica.Series("PesoPunto").MarkerStyle = MarkerStyle.Circle




            PesoNom = DVarios.RecordSet("PRESKG")
            LimSup = Math.Round(PesoNom + DVarios.RecordSet("TOLSUPEMP"), 1)
            LimInf = Math.Round(PesoNom - DVarios.RecordSet("TOLINFEMP"), 1)

            Grafica.Titles(1).Text = DVarios.RecordSet("CODPROD") + " " + DVarios.RecordSet("NOMPROD")

            Grafica.ChartAreas(0).AxisY.Minimum = LimInf - 0.1
            Grafica.ChartAreas(0).AxisY.Maximum = LimSup + 0.1
            Grafica.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Minutes
            Grafica.ChartAreas(0).AxisX.Interval = _Incremento

            Grafica.ChartAreas(0).AxisX.IsLabelAutoFit = False

            Grafica.ChartAreas(0).CursorX.IsUserSelectionEnabled = True
            Grafica.ChartAreas(0).CursorX.IsUserEnabled = True

            'Graficamos los límites y el peso nominal

            For Each Fila As DataRow In DVarios.Rows
                ValorEjeY = Math.Round(Fila("PESO"), 1)
                Dim X As Date = Fila("FECHA")
                'Dim X As Single = Eval(Minute(Fila("FECHA")) + Second(Fila("FECHA")) / 100)
                'ValorEjeX = Math.Round(DateDiff(DateInterval.Second, CDate(FechaIni), CDate(Fila("Fecha"))) / 60, 2)
                If ValorEjeY < 0 Then ValorEjeY = 0
                'Grafica.Series("Peso").Points.AddXY(ValorEjeX, ValorEjeY)
                Grafica.Series("Peso").Points.AddXY(X, ValorEjeY)
                Grafica.Series("PesoPunto").Points.AddXY(X, ValorEjeY)
                Grafica.Series("PesoNom").Points.AddXY(X, PesoNom)
                Grafica.Series("LimInf").Points.AddXY(X, LimInf)
                'Grafica.Series("LimInf").Points.AddXY(X, 49.8)
                Grafica.Series("LimSup").Points.AddXY(X, LimSup)

            Next

            'Grafica.DataSource = DVarios.DataTable
            'Grafica.Series("Peso").XValueMember = "Fecha"
            'Grafica.Series("Peso").YValueMembers = "Peso"
            'Grafica.Series("PesoPunto").XValueMember = "Fecha"
            'Grafica.Series("PesoPunto").YValueMembers = "Peso"

            'GraficaOK = True

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
















End Class
