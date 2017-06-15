Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading.Thread


Public Class GraficasProceso1

    Private ChDatos As ArrayControles(Of Chart)
    Private OPHora As ArrayControles(Of RadioButton)
    Private TFechaIni As ArrayControles(Of TextBox)
    Private TFechaFin As ArrayControles(Of TextBox)
    Private TMuestrasGraf As ArrayControles(Of TextBox)
    Private TMuestrasDia As ArrayControles(Of TextBox)
    Private BPrevious As ArrayControles(Of Button)
    Private BNext As ArrayControles(Of Button)

    'Onjetos para conexión a base de datos
    Private DVarios As AdoSQL
    Private DDatos As AdoSQL
    Private DProd As AdoSQL
    Private GrafOk As Boolean

    Private Graficas(7) As Grafica

    'Variables

    Private Intervalo As Int16
    Private FormLoad As Boolean


    Private Sub GraficasProceso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            If FormLoad Then Return
            ChDatos = New ArrayControles(Of Chart)("ChDatos", Me)
            OPHora = New ArrayControles(Of RadioButton)("OPHora", Me)
            TFechaIni = New ArrayControles(Of TextBox)("TFechaIni", Me)
            TFechaFin = New ArrayControles(Of TextBox)("TFechaFin", Me)
            TMuestrasGraf = New ArrayControles(Of TextBox)("TMuestrasGraf", Me)
            TMuestrasDia = New ArrayControles(Of TextBox)("TMuestrasDia", Me)
            BPrevious = New ArrayControles(Of Button)("BPrevious", Me)
            BNext = New ArrayControles(Of Button)("BNext", Me)

            For i = 1 To 6
                Graficas(i) = New Grafica()
            Next

            DVarios = New AdoSQL("Varios")
            DDatos = New AdoSQL("DATOS")

            DProd = New AdoSQL("ARTICULOS")
            DProd.Open("Select * from ARTICULOS where TIPO='PT'")

            If OPHora(1).Checked Then
                Intervalo = 1
            ElseIf OPHora(4).Checked Then
                Intervalo = 4
            Else
                Intervalo = 8
            End If
            FormLoad = True
            TimSeg.Enabled = True
            TimSeg_Tick(Nothing, Nothing)

            'For Each RB As RadioButton In OPHora.Values
            '    AddHandler RB.CheckedChanged, AddressOf OPHora_CheckedChanged
            'Next


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try


    End Sub

    Private Sub FGraficar(ByVal Maquina As Int16, ByVal Fecha As Date, ByVal Proceso As String)
        Try

            Graficas(Maquina).Fecha = Fecha
            Graficas(Maquina).Intervalo = Intervalo
            Graficas(Maquina).Maq = Maquina
            Graficas(Maquina).FGraficar(ChDatos(Maquina), GrafOk, Me.Text)
            TFechaIni(Maquina).Text = ""
            TFechaFin(Maquina).Text = ""
            TMuestrasDia(Maquina).Text = ""
            TMuestrasGraf(Maquina).Text = ""

            If GrafOk Then
                TFechaIni(Maquina).Text = Graficas(Maquina).FechaInicial
                TFechaFin(Maquina).Text = Graficas(Maquina).FechaFinal
                TMuestrasDia(Maquina).Text = Graficas(Maquina).MuestrasDia
                TMuestrasGraf(Maquina).Text = Graficas(Maquina).MuestrasGraf
            End If



        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

    Private Sub OPHora_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OPHora1.CheckedChanged, OPHora4.CheckedChanged, OPHora8.CheckedChanged
        Try
            If FormLoad = False Then Return
            If sender Is Nothing Then Return

            Dim Index As Short = OPHora.Index(CType(sender, RadioButton))
            If OPHora(Index).Checked = False Then Return
            Intervalo = Index

            TimSeg_Tick(Nothing, Nothing)


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub TimSeg_Tick(sender As System.Object, e As System.EventArgs) Handles TimSeg.Tick
        Try
            For i = 1 To 6
                'FGraficar(i, CDate("2016/11/16 03:00"))

                'Se suman 5 minutos para que se alcance a apreciar las muestras que se acaban de pesar
                FGraficar(i, DateAdd(DateInterval.Minute, 5, Now), Me.Text)

                'FGraficar(i, CDate("2016/12/02 16:21"), Me.Text)
                Sleep(100)
            Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BNext1_Click(sender As System.Object, e As System.EventArgs) Handles BNext1.Click, BNext2.Click, BNext3.Click, BNext4.Click, BNext5.Click, BNext6.Click
        Try
            Dim Index As Int16
            Dim Bt As Button

            If sender Is Nothing Then Return
            Bt = CType(sender, Button)
            Index = BNext.Index(Bt)
            If Val(TFechaIni(Index).Text) = 0 Or Val(TFechaFin(Index).Text) = 0 Then Return
            TimSeg.Enabled = False
            FGraficar(Index, DateAdd(DateInterval.Hour, Intervalo, CDate(TFechaFin(Index).Text)), Me.Text)
            BPlay.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BPrevious1_Click(sender As System.Object, e As System.EventArgs) Handles BPrevious1.Click, BPrevious2.Click, BPrevious3.Click, BPrevious4.Click, BPrevious5.Click, BPrevious6.Click
        Try
            Dim Index As Int16
            Dim Bt As Button

            If sender Is Nothing Then Return
            Bt = CType(sender, Button)
            Index = BPrevious.Index(Bt)
            If Val(TFechaIni(Index).Text) = 0 Or Val(TFechaFin(Index).Text) = 0 Then Return
            TimSeg.Enabled = False
            FGraficar(Index, DateAdd(DateInterval.Hour, -Intervalo, CDate(TFechaFin(Index).Text)), Me.Text)
            BPlay.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BPlay_Click(sender As System.Object, e As System.EventArgs) Handles BPlay.Click
        Try
            BPlay.Visible = False
            TimSeg.Enabled = True
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    
End Class