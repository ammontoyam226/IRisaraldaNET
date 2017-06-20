Imports System.Data
'Imports System.String
Imports System.IO
Imports System.Data.Common
Imports System.Windows.Forms
Imports System.Threading.Thread
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Servidor

    Private DProd As AdoSQL
    Private DEmp As AdoSQL
    Private DDatos As AdoSQL
    Private DEquipos As AdoSQL
    Private DConfigVar As AdoSQL
    Private DRepeso As AdoSQL
    Private DUsuarios As AdoSQL
    Private DDatosenLinea As AdoSQL

    Private ConGSE(30) As Connection

    Private RutaArchivarGSE As String
    Private DatosEnvio(30) As String
    Private HoraGSE(30) As ULong
    Private EqAct(30) As Short
    Private Pos1(30), Pos2(30) As Integer

    Private Reportes(30), Reportes2(30), RepChk(30), RepChk2(30), RepSac(30) As String
    Private RenglonesRep(30)(), CamposRep(30)() As String
    Private RenglonesSac(30)(), CamposSac(30)() As String
    Private RenglonesChk(30)(), CamposChk(30)() As String

    'Private Tipo As String
    'Private Renglon As String
    Private FechaRep(30) As String
    Private HoraRep(30) As String

    'Private ContEnvioProd(30) As Integer
    'Private HabEnvioProd(30) As Boolean
    'Private ContEnvioMaq(30) As Integer
    'Private HabEnvioMaq(30) As Boolean
    'Private ContEnvioUsu(30) As Integer
    'Private HabEnvioUsu(30) As Boolean

    ' Variables
    Private ServAct As Short = 0
    Private Cons(4) As Integer
    Private Ref(4) As Integer
    Private Real(4) As Integer
    Private Tot(4) As Integer
    Private Pres(4) As Integer
    Private Proc(4) As Integer
    Private Estado(4) As Integer
    Private ContChk(4) As Integer
    Private UltS(4) As Integer
    Private CSUn(4) As Integer
    Private CSOv(4) As Integer
    Private ContSB1(4) As Integer
    Private ContSB2(4) As Integer
    Private SChkB1(4) As Integer
    Private SChkB2(4) As Integer
    Private CSUnB1(4) As Integer
    Private CSUnB2(4) As Integer
    Private CSOvB1(4) As Integer
    Private CSOvB2(4) As Integer
    Private UltSB1(4) As Integer
    Private UltSB2(4) As Integer

    Dim ValAntB1 As Long
    Dim ValAntB2 As Long
    Dim ValAntSacB1 As Long
    Dim ValAntSacB2 As Long

    Private TIP As ArrayControles(Of TextBox)
    Private TSegSinCon As ArrayControles(Of TextBox)
    Private TSeg As ArrayControles(Of TextBox)
    Private TEstCon As ArrayControles(Of TextBox)
    Private ShRx As ArrayControles(Of TextBox)
    Private TRx As ArrayControles(Of TextBox)
    Private TTx As ArrayControles(Of TextBox)
    Private TMsg As ArrayControles(Of TextBox)
    Private TCodProd As ArrayControles(Of TextBox)
    Private TNomProd As ArrayControles(Of TextBox)
    Private TTara As ArrayControles(Of TextBox)
    Private TPesoNom As ArrayControles(Of TextBox)
    Private TPesoReal As ArrayControles(Of TextBox)
    Private TFecha As ArrayControles(Of TextBox)
    Private TMaq As ArrayControles(Of TextBox)
    Private TLote As ArrayControles(Of TextBox)
    Private TUsuario As ArrayControles(Of TextBox)

    Private BLimpiar As ArrayControles(Of Button)
    Private BPruebaCom As ArrayControles(Of Button)
    Private BPideRep As ArrayControles(Of Button)
    Private BRecRep As ArrayControles(Of Button)
    Private BBorraRep As ArrayControles(Of Button)
    Private BPedirChk As ArrayControles(Of Button)
    Private BRecChk As ArrayControles(Of Button)
    Private BBorraChk As ArrayControles(Of Button)
    Private BHoraGSE As ArrayControles(Of Button)
    Private BRepSac As ArrayControles(Of Button)


    Private Sub Servidor_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Try

            TSegSinCon = New ArrayControles(Of TextBox)("TSegSinCon", Me)
            TSeg = New ArrayControles(Of TextBox)("TSeg", Me)
            TEstCon = New ArrayControles(Of TextBox)("TEstCon", Me)
            ShRx = New ArrayControles(Of TextBox)("ShRx", Me)

            TCodProd = New ArrayControles(Of TextBox)("TCodProd", Me)
            TNomProd = New ArrayControles(Of TextBox)("TNomProd", Me)
            TTara = New ArrayControles(Of TextBox)("TTara", Me)
            TPesoNom = New ArrayControles(Of TextBox)("TPesoNom", Me)
            TPesoReal = New ArrayControles(Of TextBox)("TPesoReal", Me)
            TFecha = New ArrayControles(Of TextBox)("TFecha", Me)
            TMaq = New ArrayControles(Of TextBox)("TMaq", Me)
            TLote = New ArrayControles(Of TextBox)("TLote", Me)
            TUsuario = New ArrayControles(Of TextBox)("TUsuario", Me)
            TIP = New ArrayControles(Of TextBox)("TIP", Me)

            TMsg = New ArrayControles(Of TextBox)("TMsg", Me)
            TRx = New ArrayControles(Of TextBox)("TRx", Me)
            TTx = New ArrayControles(Of TextBox)("TTx", Me)

            BLimpiar = New ArrayControles(Of Button)("BLimpiar", Me)
            BPruebaCom = New ArrayControles(Of Button)("BPruebaCom", Me)
            BPideRep = New ArrayControles(Of Button)("BPideRep", Me)
            BRecRep = New ArrayControles(Of Button)("BRecRep", Me)
            BBorraRep = New ArrayControles(Of Button)("BBorraRep", Me)
            BPedirChk = New ArrayControles(Of Button)("BPedirChk", Me)
            BRecChk = New ArrayControles(Of Button)("BRecChk", Me)
            BBorraChk = New ArrayControles(Of Button)("BBorraChk", Me)
            BHoraGSE = New ArrayControles(Of Button)("BHoraGSE", Me)
            BRepSac = New ArrayControles(Of Button)("BRepSac", Me)

            If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
                'MessageBox.Show("La aplicación ya se esta ejecutando", "ChronoSoft Comms", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End
            End If

            DDatos = New AdoSQL("Datos")
            DProd = New AdoSQL("Productos")
            DEquipos = New AdoSQL("Equipos")
            DEmp = New AdoSQL("Empaque")
            DRepeso = New AdoSQL("Repeso")
            DUsuarios = New AdoSQL("Usuarios")
            DDatosenLinea = New AdoSQL("DDatosenLinea")

            DEquipos.Open("select * from EQUIPOS where ACTIVO=1 order by EQUIPO")

            ReDim EqAct(DEquipos.RecordCount)
            Dim i As Short = 1

            For Each RsEquipos As DataRow In DEquipos.Rows
                EqAct(i) = RsEquipos("EQUIPO")
                If RsEquipos("TIPOCONEXION").ToString.ToUpper = "SERIAL" Then
                    '1,9600,8,0,1,0
                    ConGSE(RsEquipos("EQUIPO")) = New Connection(Connection.TipoConnection.Serial, RsEquipos("COM").ToString + ",9600,8,0,1,0", RsEquipos("EQUIPO"))
                ElseIf RsEquipos("TIPOCONEXION").ToString.ToUpper = "ETHERNET" Then
                    ConGSE(RsEquipos("EQUIPO")) = New Connection(Connection.TipoConnection.Ethernet, RsEquipos("IP").ToString, RsEquipos("IPPORT").ToString, RsEquipos("EQUIPO"))
                    TIP(RsEquipos("EQUIPO")).Text = RsEquipos("IP")
                    TabServidor.TabPages(RsEquipos("EQUIPO") - 1).Text = RsEquipos("CENTROTRABAJO")
                End If
                ConGSE(RsEquipos("EQUIPO")).Conect()
                AddHandler ConGSE(RsEquipos("EQUIPO")).DatosRecibidos, AddressOf Recibedatos
                AddHandler ConGSE(RsEquipos("EQUIPO")).DatosEnviados, AddressOf EnviaDatos
                i += 1
            Next

            TimSeg.Enabled = True

            DEquipos.Open("select * from EQUIPOS order by EQUIPO")

            Dim K As Short = 0
            For Each Fila As DataRow In DEquipos.Rows
                TabServidor.TabPages(K).Text = Fila("CENTROTRABAJO")
                K += 1
            Next

            RutaArchivarGSE = Ruta + "Aplanos\GSE"
            'Ensaque.Ensaque_Load(Nothing, Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


#Region "   Delegados para actualizar una etiqueta desde dentro de un hilo"
    Delegate Sub dlgMostrarResultado(ByVal Data As String, ByVal index As Short)
    Delegate Sub dlgEnvioDatos(ByVal Data As String, ByVal index As Short)

    Public Sub EnviaDatos(ByVal Datos As String, ByVal index As Short)
        Dim miDelegate As New dlgEnvioDatos(AddressOf EnviaDatosArchivar)
        miDelegate(Datos, index)
    End Sub

    Public Sub EnviaDatosArchivar(ByVal Data As String, ByVal index As Short)
        ConGSE(index).Archivar(Data)
    End Sub

    Public Sub Recibedatos(ByVal Datos As String, ByVal index As Short)
        Dim miDelegate As New dlgMostrarResultado(AddressOf MostrarResultadoMethod)

        If TRx(index).InvokeRequired() Then
            TRx(index).Invoke(miDelegate, Datos, index)
        Else
            miDelegate(Datos, index)
        End If

    End Sub

    Private Sub MostrarResultadoMethod(ByVal Data As String, ByVal Index As Short)
        Try
            TRx(Index).Text += Data

            If InStr(Data, "INI") Or InStr(Data, "FIN") Then
                ConGSE(Index).Archivar(Data)
            End If

            ' Reporte general
            Pos1(Index) = InStr(1, TRx(Index).Text, "FINCOPYREPORT,")
            If Pos1(Index) > 0 Then
                Pos2(Index) = InStr(1, TRx(Index).Text, "INIREPORT,")
                If Pos2(Index) > 0 And (Pos1(Index) > Pos2(Index)) Then
                    Pos1(Index) = InStr(1, TRx(Index).Text, "FINREPORT,")
                    If Pos1(Index) > Pos2(Index) Then
                        Reportes(Index) = Mid(TRx(Index).Text, Pos2(Index) + 12, Pos1(Index) - Pos2(Index) - 12)
                    Else
                        Exit Sub
                    End If
                    Pos2(Index) = InStr(Pos1(Index), TRx(Index).Text, "INICOPYREPORT,")
                    If Pos2(Index) > 0 Then
                        Pos1(Index) = InStr(Pos2(Index), TRx(Index).Text, "FINCOPYREPORT,")
                        If Pos1(Index) > Pos2(Index) Then
                            Reportes2(Index) = Mid(TRx(Index).Text, Pos2(Index) + 16, Pos1(Index) - Pos2(Index) - 16)
                        End If
                    End If
                    If Reportes(Index) <> Reportes2(Index) Then
                        Evento("BRecRep. Copia de reportes diferente: " + vbCrLf + Reportes(Index))
                        TRx(Index).Text = Mid(TRx(Index).Text, Pos1(Index) + 14)
                        Exit Sub
                    End If
                    BRecRep_Click(BRecRep(Index), Nothing)
                    TMsg(Index).Text = "LLEGARON REPORTES"
                    TRx(Index).Text = Mid(TRx(Index).Text, Pos1(Index) + 14)
                    Exit Sub
                End If
            End If

            ' Custom x cada saco
            Pos1(Index) = InStr(1, TRx(Index).Text, "INIDATA,")
            If Pos1(Index) > 0 Then
                Pos2(Index) = InStr(1, TRx(Index).Text, "FINDATA,")
                If Pos2(Index) > Pos1(Index) Then
                    RepSac(Index) = Mid(TRx(Index).Text, Pos1(Index) + 10, Pos2(Index) - Pos1(Index) - 12)
                    BRepSac_Click(BRepSac(Index), Nothing)
                    TRx(Index).Text = Mid(TRx(Index).Text, Pos2(Index) + 8)
                    'Else
                    '    TRx(Index).Text = ""
                End If

            End If

            ' Reporte de repeso
            Pos1(Index) = InStr(1, TRx(Index).Text, "FINCOPYCHECK,")
            If Pos1(Index) > 0 Then
                Pos2(Index) = InStr(1, TRx(Index).Text, "INICHECK,")
                If Pos2(Index) > 0 And (Pos1(Index) > Pos2(Index)) Then
                    Pos1(Index) = InStr(1, TRx(Index).Text, "FINCHECK,")
                    If Pos1(Index) > Pos2(Index) Then
                        RepChk(Index) = Mid(TRx(Index).Text, Pos2(Index) + 11, Pos1(Index) - Pos2(Index) - 13)
                    Else
                        Exit Sub
                    End If
                    Pos2(Index) = InStr(Pos1(Index), TRx(Index).Text, "INICOPYCHECK,")
                    If Pos2(Index) > 0 Then
                        Pos1(Index) = InStr(Pos2(Index), TRx(Index).Text, "FINCOPYCHECK,")
                        If Pos1(Index) > Pos2(Index) Then
                            RepChk2(Index) = Mid(TRx(Index).Text, Pos2(Index) + 15, Pos1(Index) - Pos2(Index) - 17)
                        End If
                    End If
                    If RepChk(Index) <> RepChk2(Index) Then
                        Evento("BRecRep. Copia de reportes diferente: " + vbCrLf + Reportes(Index))
                        TRx(Index).Text = Mid(TRx(Index).Text, Pos1(Index) + 14)
                        Exit Sub
                    End If
                    BRecChk_Click(BRecChk(Index), Nothing)
                    TMsg(Index).Text = "LLEGARON REPORTES"
                    TRx(Index).Text = Mid(TRx(Index).Text, Pos1(Index) + 14)
                    Exit Sub
                End If

            End If

            Pos1(Index) = InStr(1, TRx(Index).Text, "COMUNICACIONES OK")
            If Pos1(Index) <> 0 Then
                TRx(Index).Text = Mid(TRx(Index).Text, Pos1(Index) + 37)
                MsgBox("COMUNICACIONES OK EMPACADORA " + Index.ToString + "!!!!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

#End Region

    Private Sub ConGSE_Connect()
        TEstCon1.Text = "7"
        TEstCon1.BackColor = Color.GreenYellow
    End Sub

    'Private Sub BRecRep1_Click(sender As System.Object, e As System.EventArgs, Optional ByVal Reportes As String = "") Handles BRecRep1.Click    
    Private Sub BRecRep_Click(sender As System.Object, e As System.EventArgs) Handles BRecRep1.Click

        Dim Index As Short = BRecRep.Index(CType(sender, Button))
        Dim CodProd, ConsBasc, Sacos, SacChk, Presentacion, SacUnder, SacOver, FechaIni, HoraIni, FechaFin, HoraFin, Pestotal, NomProd As String
        Dim CodEmp As String = ""
        Dim CodEtiq As String = ""
        Dim CodFor = "0000"
        Dim LP = "0000"

        Try

            RenglonesRep(Index) = Reportes(Index).Split(Chr(13))

            For i = 0 To RenglonesRep(Index).Length - 1

                If RenglonesRep(Index)(i).Length < 6 Then Continue For
                CamposRep(Index) = RenglonesRep(Index)(i).Split(",")

                ConsBasc = CamposRep(Index)(0)
                CodProd = CamposRep(Index)(1)
                Sacos = CamposRep(Index)(2)
                Pestotal = CamposRep(Index)(3)
                Presentacion = CamposRep(Index)(4)
                SacChk = CamposRep(Index)(5)
                SacUnder = CamposRep(Index)(6)
                SacOver = CamposRep(Index)(7)
                FechaIni = "20" + CamposRep(Index)(8)
                HoraIni = CamposRep(Index)(9)
                FechaFin = "20" + CamposRep(Index)(10)
                HoraFin = CamposRep(Index)(11)

                If Eval(CodProd) = 0 OrElse Eval(ConsBasc) = 0 OrElse Eval(Sacos) = 0 Then Continue For

                FechaIni = CLeft(FechaIni, 10) + " " + CLeft(HoraIni, 8)
                FechaFin = CLeft(FechaFin, 10) + " " + CLeft(HoraFin, 8)

                If FechaIni.Length <> 19 Then FechaIni = Now.ToString("yyyy/MM/dd HH:mm:ss")
                If FechaFin.Length <> 19 Then FechaFin = Now.ToString("yyyy/MM/dd HH:mm:ss")

                If IsDate(FechaIni) = False Then FechaIni = Now.ToString("yyyy/MM/dd HH:mm:ss")
                If IsDate(FechaFin) = False Then FechaFin = Now.ToString("yyyy/MM/dd HH:mm:ss")


                DProd.Open("select * from PRODUCTOS where CODPROD='" + CodProd + "'")

                NomProd = "No Existe"
                If DProd.RecordCount > 0 Then
                    CodProd = DProd.RecordSet("CODPROD").ToString
                    NomProd = DProd.RecordSet("NOMPROD").ToString
                    CodEmp = DProd.RecordSet("CODEMP").ToString
                    Pestotal = DProd.RecordSet("PRESKG").ToString
                End If

                'DEmp.Open("select * from EMPAQUE where FECHAINI>'" + Format(DateAdd(DateInterval.Day, -15, Now), "yyyy/MM/dd HH:mm:ss") + "' and CONTBASC=" + ConsBasc + " and MAQUINA=" + EquipoNo.ToString)
                DEmp.Open("select * from EMPAQUE where CODPROD='" + Trim(CodProd) + "' and CONTBASC=" + Trim(ConsBasc) + " and MAQUINA=" + Index.ToString)
                If DEmp.RecordCount = 0 Then
                    DEmp.AddNew()
                    DEmp.RecordSet("CONTBASC") = ConsBasc
                    DEmp.RecordSet("CODPROD") = CodProd
                    DEmp.RecordSet("NOMPROD") = NomProd
                    DEmp.RecordSet("SACOS") = Sacos
                    DEmp.RecordSet("MESDIA") = Date.Now
                    DEmp.RecordSet("PESO") = Eval(Pestotal) * Eval(Sacos)
                    DEmp.RecordSet("MAQUINA") = Index
                    DEmp.RecordSet("FECHA") = FechaIni
                    DEmp.RecordSet("FECHA2") = FechaFin
                    DEmp.RecordSet("PRESKG") = Pestotal
                    DEmp.RecordSet("SACUNDER") = SacUnder
                    DEmp.RecordSet("SACOVER") = SacOver
                    DEmp.RecordSet("SACOK") = SacChk
                    DEmp.RecordSet("SACCHK") = Eval(SacChk) - Eval(SacUnder) - Eval(SacOver)
                    DEmp.RecordSet("PRESEMP") = Presentacion

                    DEmp.Update()
                    Evento("Crea registro de empaque Maquina " + Index.ToString + " ContBasc " + Trim(ConsBasc) + " REF " + Trim(CodProd))
                    '
                End If
            Next


            BBorraRep_Click(BBorraRep(Index), Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

    Private Sub BPedirChk_Click(sender As System.Object, e As System.EventArgs) Handles BPedirChk1.Click, BPedirChk2.Click, BPedirChk3.Click, BPedirChk4.Click

        Try
            Dim Index As Short = BPedirChk.Index(CType(sender, Button))

            If ConGSE(Index).State = Connection.StateConnection.Connected Then
                ConGSE(Index).SendData("#ReporteS1#")
                TTx(Index).Text += "#ReporteS1#"
            End If

            Sleep(200)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub



    Private Sub BPideRep_Click(sender As System.Object, e As System.EventArgs) Handles BPideRep1.Click, BPideRep2.Click, BPideRep3.Click, BPideRep4.Click
        Try
            Dim Index As Short = BPideRep.Index(CType(sender, Button))
            If ConGSE(Index).State = Connection.StateConnection.Connected Then
                ConGSE(Index).SendData("#ReporteS0#")
                TTx(Index).Text += "#ReporteS0#"
            Else
                TMsg(Index).Text = "El canal IP está cerrado"
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BBorraRep_Click(sender As System.Object, e As System.EventArgs) Handles BBorraRep1.Click, BBorraRep2.Click, BBorraRep3.Click, BBorraRep4.Click
        Try
            Dim Index As Short = BBorraRep.Index(CType(sender, Button))
            If ConGSE(Index).State = Connection.StateConnection.Connected Then
                ConGSE(Index).SendData(vbCr + "#BorraReporteS0#" + vbCr)
                TTx(Index).Text += "#BorraReporteS0#"
                Sleep(200)
                'WriteFile(Ruta + "APlanos\GSE_" + Index.ToString + "_" + Now.ToString("yyMMdd") + ".txt", "BorraReporteS0" + vbCrLf)
                'ConGSE(Index).Archivar("BorraReporteS0")
            Else
                Evento("No hay conexión de red en " + Me.Name)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Evento(ex.ToString)
        End Try




    End Sub

    Private Sub TimSeg_Tick(sender As System.Object, e As System.EventArgs) Handles TimSeg.Tick

        For Index As Short = 1 To EqAct.Length - 1
            ServAct = EqAct(Index)
            If Val(TSegSinCon(ServAct).Text) > 10000 Then TSegSinCon(ServAct).Text = 1
            If Val(TSeg(ServAct).Text) > 10000 Then TSeg(ServAct).Text = 1
            TSeg(ServAct).Text = Val(TSeg(ServAct).Text) + 1

            'Verificación para capturar reportes en modo test al pegar archivo en el control
            'If TRx1.Focused Then
            '    If InStr(1, TRx1.Text, "FINREPORT,") Then
            '        MostrarResultadoMethod(TRx(Index).Text)
            '    End If
            'End If

            If ConGSE(ServAct).State = Connection.StateConnection.Connected Then
                TEstCon(ServAct).Text = "7"
                TEstCon(ServAct).BackColor = Color.GreenYellow
                TSegSinCon(ServAct).Text = 1
            Else
                TEstCon(ServAct).BackColor = Color.White
                TEstCon(ServAct).Text = "6"
                TSegSinCon(ServAct).Text = Val(TSegSinCon(ServAct).Text) + 1

            End If

            If Eval(TSegSinCon(ServAct).Text) Mod 300 = 0 Then
                Alarma("No hay comunicación con balanza: " + TabServidor.TabPages(ServAct - 1).Text)
            End If

            If Not ConGSE(ServAct) Is Nothing Then
                If Eval(TSegSinCon(ServAct).Text) Mod 10 = 0 Then
                    ConGSE(ServAct).Conect()
                End If
            End If

            If Eval(TSeg(ServAct).Text) Mod (600 + ServAct) = 0 Then
                BPideRep_Click(BPideRep(ServAct), Nothing)
            End If

            If Eval(TSeg(ServAct).Text) Mod 3600 = 0 Then
                BHoraGSE_Click(BHoraGSE(ServAct), Nothing)
            End If
        Next

    End Sub

    Private Sub BLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BLimpiar1.Click, BLimpiar2.Click, BLimpiar3.Click, BLimpiar4.Click

        Try
            Dim Index As Short = BLimpiar.Index(CType(sender, Button))
            TRx(Index).Clear()
            TTx(Index).Clear()
        Catch ex As Exception
            Debug.Print(ex.ToString)
            Evento(ex.ToString)

        End Try
    End Sub

    Private Sub BPruebaCom_Click(sender As System.Object, e As System.EventArgs) Handles BPruebaCom1.Click, BPruebaCom2.Click, BPruebaCom3.Click, BPruebaCom4.Click

        Try
            Dim Index As Short = BPruebaCom.Index(CType(sender, Button))

            If ConGSE(Index).State = Connection.StateConnection.Connected Then
                ConGSE(Index).SendData("#PruebaComM0#")
                TTx(Index).Text = "#PruebaComM0#"
            Else
                MsgBox("El canal de Comunicaciones está cerrado", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub BRecChk_Click(sender As System.Object, e As System.EventArgs) Handles BRecChk1.Click, BRecChk2.Click, BRecChk3.Click, BRecChk4.Click
        Dim CodProd, ConsChk, Peso, Presentacion, SacUnder, SacOver, FechaIni, HoraIni, NomProd As String
        Dim CodEmp As String = ""
        Dim CodEtiq As String = ""
        Dim CodFor = "0000"
        Dim LP = "0000"
        Dim Index As Short = BRecChk.Index(CType(sender, Button))
        Try

            RenglonesChk(Index) = RepChk(Index).Split(Chr(13))


            For i = 0 To RenglonesChk(Index).Length - 1

                If RenglonesChk(Index)(i).Length < 6 Then Continue For
                CamposChk(Index) = RenglonesChk(Index)(i).Split(",")

                ConsChk = CamposChk(Index)(0)
                CodProd = CamposChk(Index)(1)
                Peso = CamposChk(Index)(2)
                Presentacion = CamposChk(Index)(3)
                SacUnder = CamposChk(Index)(4)
                SacOver = CamposChk(Index)(5)
                FechaIni = "20" + CamposChk(Index)(6)
                HoraIni = CamposChk(Index)(7)


                If Eval(CodProd) = 0 OrElse Eval(ConsChk) = 0 Then Continue For

                FechaIni = CLeft(FechaIni, 10) + " " + CLeft(HoraIni, 8)

                If FechaIni.Length <> 19 Then FechaIni = Now.ToString("yyyy/MM/dd HH:mm:ss")

                If IsDate(FechaIni) = False Then FechaIni = Now.ToString("yyyy/MM/dd HH:mm:ss")

                DProd.Open("select * from PRODUCTOS where CODPROD='" + CodProd + "'")

                NomProd = "No Existe"
                If DProd.RecordCount > 0 Then
                    CodProd = DProd.RecordSet("CODPROD").ToString
                    NomProd = DProd.RecordSet("NOMPROD").ToString
                    CodEmp = DProd.RecordSet("CODEMP").ToString
                    Presentacion = DProd.RecordSet("PRESKG").ToString
                End If

                'DEmp.Open("select * from EMPAQUE where FECHAINI>'" + Format(DateAdd(DateInterval.Day, -15, Now), "yyyy/MM/dd HH:mm:ss") + "' and CONTBASC=" + ConsBasc + " and MAQUINA=" + EquipoNo.ToString)
                DRepeso.Open("select * from REPESO" + Index.ToString + " where CODPROD='" + Trim(CodProd) + "' and CONT=" + Trim(ConsChk) + " and MAQUINA=" + Index.ToString)
                If DRepeso.RecordCount = 0 Then
                    DRepeso.AddNew()
                    DRepeso.RecordSet("CONT") = ConsChk
                    DRepeso.RecordSet("CODPROD") = CodProd
                    DRepeso.RecordSet("NOMPROD") = NomProd
                    DRepeso.RecordSet("PESO") = Peso
                    DRepeso.RecordSet("FECHA") = FechaIni.ToString
                    DRepeso.RecordSet("TOLSUP") = SacUnder
                    DRepeso.RecordSet("TOLINF") = SacOver
                    DRepeso.RecordSet("PRESEMP") = Presentacion
                    DRepeso.RecordSet("MAQUINA") = Index

                    DRepeso.Update()
                    Evento("Crea registro de empaque Maquina " + Index.ToString + " ContBasc " + Trim(ConsChk) + " REF " + Trim(CodProd))

                End If
            Next

            BBorraChk_Click(BBorraChk(Index), Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub


    Private Sub BBorraChk_Click(sender As System.Object, e As System.EventArgs) Handles BBorraChk1.Click
        Try
            Dim Index As Short = BBorraChk.Index(CType(sender, Button))

            If ConGSE(Index).State = Connection.StateConnection.Connected Then
                ConGSE(Index).SendData(vbCr + "#BorraReporteS1#" + vbCr)
                TTx(Index).Text += "#BorraReporteS1#"
                Sleep(200)
            Else
                MsgBox("El canal de Comunicaciones está cerrado", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub


    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'En caso de pegar texto en TRx
        MostrarResultadoMethod(Nothing, Nothing)

    End Sub

    Private Sub BHoraGSE_Click(sender As System.Object, e As System.EventArgs) Handles BHoraGSE1.Click, BHoraGSE2.Click, BHoraGSE3.Click,
        BHoraGSE4.Click
        Try

            Dim Index As Short = BHoraGSE.Index(CType(sender, Button))
            HoraGSE(Index) = DateDiff(DateInterval.Second, CDate("1970/1/1"), Now)

            If ConGSE(Index).State = Connection.StateConnection.Connected Then
                ConGSE(Index).SendData("#ActHoraGSE" + Trim(HoraGSE(Index).ToString) + "#")
                TTx(Index).Text = "ActHoraGSE" + Trim(HoraGSE(Index).ToString)
                Evento("Hora actualizada GSE Empaque" + Index.ToString)
            Else
                MsgBox("El canal de Comunicaciones está cerrado", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub



    Private Sub BRepSac_Click(sender As System.Object, e As System.EventArgs) Handles BRepSac1.Click, BRepSac2.Click, BRepSac3.Click, BRepSac4.Click



        Dim Index As Short = BRepSac.Index(CType(sender, Button))

        'RenglonesSac(Index) = RepSac(Index).Split(Chr(13))

        Try
            'If RenglonesSac(Index)(1).Length < 6 Then Exit Sub
            'CamposSac(Index) = RenglonesSac(Index)(1).Split(",")
            CamposSac(Index) = RepSac(Index).Split(",")
            Cons(Index) = CamposSac(Index)(1)
            Ref(Index) = CamposSac(Index)(3)
            Real(Index) = CamposSac(Index)(5)
            Tot(Index) = CamposSac(Index)(7)
            Pres(Index) = Eval(CamposSac(Index)(9))
            Proc(Index) = CamposSac(Index)(11)
            Estado(Index) = CamposSac(Index)(13)
            ContChk(Index) = CamposSac(Index)(15)
            UltS(Index) = Eval(CamposSac(Index)(17))
            CSUn(Index) = CamposSac(Index)(19)
            CSOv(Index) = CamposSac(Index)(21)

            If Index = 1 Or Index = 4 Then
                DDatosenLinea.Open("select * from DATOSENLINEA where MAQUINA=" + Index.ToString + " and BASCULA=1")
                DDatosenLinea.RecordSet("BASCULA") = 1
                DDatosenLinea.RecordSet("SACOK") = ContChk(Index) - CSOv(Index) - CSUn(Index)
                DDatosenLinea.RecordSet("SACCHK") = ContChk(Index)
                DDatosenLinea.RecordSet("SACOVER") = CSOv(Index)
                DDatosenLinea.RecordSet("SACUNDER") = CSUn(Index)
                DDatosenLinea.RecordSet("ULTSAC") = UltS(Index)

                DDatosenLinea.RecordSet("CONT") = Cons(Index)
                DDatosenLinea.RecordSet("CODPROD") = Ref(Index)
                'DDatosenLinea.RecordSet("MAQUINA") = Index
                DDatosenLinea.RecordSet("PRESKG") = Pres(Index)
                DDatosenLinea.RecordSet("PESO") = Tot(Index)
                DDatosenLinea.RecordSet("ESTADO") = Estado(Index)
                DDatosenLinea.RecordSet("PROCESO") = Proc(Index)
                DDatosenLinea.Update()

            Else
                ContSB1(Index) = CamposSac(Index)(23)
                ContSB2(Index) = CamposSac(Index)(25)
                SChkB1(Index) = CamposSac(Index)(27)
                SChkB2(Index) = CamposSac(Index)(29)
                CSUnB1(Index) = CamposSac(Index)(31)
                CSUnB2(Index) = CamposSac(Index)(33)
                CSOvB1(Index) = CamposSac(Index)(35)
                CSOvB2(Index) = CamposSac(Index)(37)
                UltSB1(Index) = Eval(CamposSac(Index)(39))
                UltSB2(Index) = Eval(CamposSac(Index)(41))

                ' Saco Chequeado en B1 de la ensacadora Duplex GSE 665
                If Eval(SChkB1(Index)) > 0 And ValAntB1 <> Eval(SChkB1(Index)) Then
                    ValAntB1 = Eval(SChkB1(Index))
                    DDatosenLinea.Open("select * from DATOSENLINEA where MAQUINA=" + Index.ToString + "and BASCULA=1")
                    DDatosenLinea.RecordSet("BASCULA") = 1                                       
                    DDatosenLinea.RecordSet("SACOK") = SChkB1(Index) - CSOvB1(Index) - CSUnB1(Index)
                    DDatosenLinea.RecordSet("SACCHK") = SChkB1(Index)
                    DDatosenLinea.RecordSet("SACOVER") = CSOvB1(Index)
                    DDatosenLinea.RecordSet("SACUNDER") = CSUnB1(Index)                   
                    DDatosenLinea.RecordSet("ULTSAC") = UltSB1(Index)

                    DDatosenLinea.RecordSet("CONT") = Cons(Index)
                    DDatosenLinea.RecordSet("CODPROD") = Ref(Index)
                    'DDatosenLinea.RecordSet("MAQUINA") = Index                    
                    DDatosenLinea.RecordSet("PRESKG") = Pres(Index)
                    DDatosenLinea.RecordSet("PESO") = Tot(Index)
                    DDatosenLinea.RecordSet("ESTADO") = Estado(Index)
                    DDatosenLinea.RecordSet("PROCESO") = Proc(Index)
                    DDatosenLinea.Update()
                End If

                ' Saco Chequeado en B2 de la ensacadora Duplex GSE 665
                If Eval(SChkB2(Index)) > 0 And ValAntB2 <> Eval(SChkB2(Index)) Then
                    ValAntB2 = Eval(SChkB2(Index))
                    DDatosenLinea.Open("select * from DATOSENLINEA where MAQUINA=" + Index.ToString + "and BASCULA=2")
                    DDatosenLinea.RecordSet("BASCULA") = 2
                    DDatosenLinea.RecordSet("SACOK") = SChkB2(Index) - CSOvB2(Index) - CSUnB2(Index)
                    DDatosenLinea.RecordSet("SACCHK") = SChkB2(Index)
                    DDatosenLinea.RecordSet("SACOVER") = CSOvB2(Index)
                    DDatosenLinea.RecordSet("SACUNDER") = CSUnB2(Index)                  
                    DDatosenLinea.RecordSet("ULTSAC") = UltSB2(Index)

                    DDatosenLinea.RecordSet("CONT") = Cons(Index)
                    DDatosenLinea.RecordSet("CODPROD") = Ref(Index)
                    'DDatosenLinea.RecordSet("MAQUINA") = Index
                    DDatosenLinea.RecordSet("PRESKG") = Pres(Index)
                    DDatosenLinea.RecordSet("PESO") = Tot(Index)
                    DDatosenLinea.RecordSet("ESTADO") = Estado(Index)
                    DDatosenLinea.RecordSet("PROCESO") = Proc(Index)
                    DDatosenLinea.Update()
                End If
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

End Class