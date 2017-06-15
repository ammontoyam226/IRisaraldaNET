Option Explicit On

Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Sockets
Imports System.Net.NetworkInformation
Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Threading

Public Class Connection

    Private TypeConnection As TipoConnection
    Private Config As String
    Private Estado As Long
    Private EstadoAnt As Long
    Private DR As DataRow
    Private hiloMensajeServidor As Thread 'Escuchar mensajes enviados desde el servidor
    Private Strm As NetworkStream 'Utilizado para enviar datos al Servidor y recibir datos del mismo 
    Private IP As String 'Direccion del objeto de la clase Servidor 
    Private Port As String 'Puerto donde escucha el objeto de la clase Servidor 
    'Private Estado As Integer = 0
    Private tcpClient As New TcpClient
    Private HacePing As Thread
    Private TimeOutConn As Double = 50 / 1000 ' 50ms
    Private EstadoPing As Integer = 0
    Private NetworkStrm As NetworkStream
    Private _Index As Short

#Region "EVENTOS"
    Public Event ConnectClose()
    Public Event Connect()
    Public Event DatosRecibidos(ByVal datos As String, ByVal Index As Integer)
    Public Event DatosEnviados(ByVal datos As String, ByVal Index As Integer)
#End Region

    Public Sub New(ByVal Tipo As TipoConnection, ByVal IP As String, ByVal IPPort As String, Optional Index As Integer = 0)
        MyBase.New()
        Try
            RemoteHost = IP
            RemotePort = IPPort
            _Index = Index

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Public Sub New(ByVal Tipo As TipoConnection, ByVal ParSerial As String)
        MyBase.New()
        Try
            If Tipo <> TipoConnection.Serial Then
                Throw New ArgumentException("Tipo de Conexión no válida")
            End If

            If String.IsNullOrEmpty(ParSerial) Then
                Throw New ArgumentException("Parametros de conexión no válidos ")
            End If

            TypeConnection = Tipo

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Enum TipoConnection As Long
        Serial = 0
        Ethernet = 1
    End Enum

#Region "Propiedades"
    Public ReadOnly Property ConfigConnection() As String
        Get
            If TypeConnection = TipoConnection.Ethernet Then
                Config = RemoteHost + "," + RemotePort
            End If
            ConfigConnection = Config
        End Get

    End Property
#End Region

#Region "Host al que nos quermos Conectar"

    Public Property RemoteHost() As String
        Get
            RemoteHost = Ip
        End Get
        Set(ByVal Value As String)
            Ip = Value
        End Set
    End Property
#End Region

#Region "Puerto de Host al que nos queremos Conectar"
    Public Property RemotePort() As String
        Get
            RemotePort = Port
        End Get
        Set(ByVal Value As String)
            Port = Value
        End Set
    End Property
#End Region

    Public ReadOnly Property TypeConn() As TipoConnection
        Get
            TypeConn = TypeConnection
        End Get
    End Property

    Public Enum StateConnection
        Connected = 7
        Desconnected = 6
    End Enum

#Region "Estado de la Conexión"
    Public ReadOnly Property State() As Integer
        Get
            If tcpClient.Client Is Nothing Then
                Estado = 6
            ElseIf EstadoPing = 7 AndAlso tcpClient.Connected Then
                Estado = 7
            Else
                tcpClient.Close()
                Estado = 6
            End If
            State = Estado
        End Get
    End Property
#End Region

#Region "Conectar al Host"
    Public Sub Conect()

        If tcpClient.Client Is Nothing OrElse tcpClient.Client.Connected = False Then tcpClient = New TcpClient
        If Not HacePing Is Nothing AndAlso HacePing.IsAlive Then HacePing.Abort()

        Dim ar As IAsyncResult = tcpClient.BeginConnect(IP, Port, Nothing, Nothing)
        Dim wh As Threading.WaitHandle = ar.AsyncWaitHandle

        Try
            If (Not ar.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(TimeOutConn), False)) Then
                tcpClient.Close()
                Estado = 6
                wh.Close()
                Return
                'Throw New TimeoutException()
            End If
            tcpClient.EndConnect(ar)
            EstadoPing = 7

            NetworkStrm = tcpClient.GetStream()

            hiloMensajeServidor = New Thread(AddressOf GetData)
            hiloMensajeServidor.Start()

            HacePing = New Thread(AddressOf EstadoConn)
            HacePing.Start()

            If NetworkStrm.CanWrite And NetworkStrm.CanRead Then
                Estado = 7
            ElseIf Not NetworkStrm.CanRead Then
                Estado = 6

            ElseIf Not NetworkStrm.CanWrite Then
                Estado = 9

            End If

            If State = StateConnection.Connected Then
                RaiseEvent Connect()
            End If

        Catch ex As Exception
            Estado = 6
        Finally
            wh.Close()
        End Try
    End Sub
#End Region
#Region "Enviar Datos"

    Public Sub SendData(ByVal Datos As String)
        Try
            If NetworkStrm.CanWrite And NetworkStrm.CanRead Then

                '' Send the NetworkStream into a byte buffer.
                Dim bytes() As Byte

                'bytes = ASCIIEncoding.ASCII.GetBytes(Datos)
                bytes = Encoding.Default.GetBytes(Datos)

                If IsNothing(bytes) Then Exit Sub

                NetworkStrm.Write(bytes, 0, bytes.Length)
                NetworkStrm.Flush()

                If tcpClient.Connected Then Estado = 7
                RaiseEvent DatosEnviados(Datos, _Index)

            ElseIf Not NetworkStrm.CanRead Then
                Estado = 6

            ElseIf Not NetworkStrm.CanWrite Then
                Estado = 9
            End If


            'Me.Archivar(Datos)

        Catch ex As Exception
            'Evento(ex.ToString)
        End Try
    End Sub
#End Region
#Region "Obtener Dato, es decir la funcion de lectura de datos"

    Public Sub GetData()
        Try

            While True
                Try
                    If NetworkStrm.CanWrite And NetworkStrm.CanRead Then
                        ' Read the NetworkStream into a byte buffer.
                        'Dim bytes(tcpClient.Available) As Byte
                        Dim bytes(2048) As Byte
                        'If NetworkStrm.DataAvailable = False Then Exit Sub

                        NetworkStrm.Read(bytes, 0, bytes.Length)
                        '' Output the data received from the host to the console.
                        RaiseEvent DatosRecibidos(Encoding.Default.GetString(bytes), _Index)


                        If tcpClient.Connected Then Estado = 7

                    ElseIf Not NetworkStrm.CanRead Then
                        Estado = 6

                    ElseIf Not NetworkStrm.CanWrite Then
                        Estado = 9

                    End If

                Catch e As Exception
                    Exit While
                End Try

            End While

            RaiseEvent ConnectClose()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Close Conection"
    Public Sub Close()
        Try
            'If tcpClient.Connected Then 
            tcpClient.Close()
            Estado = 6
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Ping de Conectividad"
    Dim Ping As New NetworkInformation.Ping
    Dim myPingCompletedEventHandler As NetworkInformation.PingCompletedEventHandler = New NetworkInformation.PingCompletedEventHandler(AddressOf PingCompletedCallback)

    Private Sub EstadoConn()
        Dim Intervalo As Integer = 2 ' segundos que pasan para hacer ping
        Dim ValorPrevio As DateTime = DateTime.Parse(Now)
        Dim ValorAct As DateTime

        While True
            Try
                ValorAct = DateTime.Parse(Now)
                If ValorAct.Subtract(ValorPrevio).Duration.Seconds > Intervalo Then
                    ValorPrevio = DateTime.Parse(Now)
                    Dim waiter As AutoResetEvent = New AutoResetEvent(False)
                    AddHandler Ping.PingCompleted, myPingCompletedEventHandler
                    Ping.SendAsync(IP, 1000, waiter)
                End If

                Thread.Sleep(1000)

            Catch ex As Exception
                EstadoPing = 6
            End Try
        End While
    End Sub

    Private Sub PingCompletedCallback(ByVal sender As Object, ByVal e As PingCompletedEventArgs)
        Try

            If e.Reply.Status = NetworkInformation.IPStatus.Success Then
                EstadoPing = 7
            Else
                EstadoPing = 6
            End If
            '*do something*
            RemoveHandler Ping.PingCompleted, myPingCompletedEventHandler

        Catch ex As Exception
            EstadoPing = 6
        End Try
    End Sub
#End Region


#Region "Archivar "
    Public Sub Archivar(ByVal Datos As String)
        Try
            'WriteFile(Ruta + "APlanos\GSE" + _Index.ToString + "_" + Now.ToString("yyMMdd") + ".txt", vbCrLf + Now.ToString("HH:mm:ss") + vbCrLf)
            WriteFile(Ruta + "APlanos\GSE" + _Index.ToString + "_" + Now.ToString("yyMMdd") + ".txt", Datos + vbCrLf)
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
#End Region

End Class


