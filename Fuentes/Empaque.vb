﻿
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Empaque

    'Cajas de texto
    Private TCodProd As ArrayControles(Of TextBox)
    Private TNomProd As ArrayControles(Of TextBox)
    Private TStat As ArrayControles(Of TextBox)
    Private TPresKg As ArrayControles(Of TextBox)
    Private TPesoTot As ArrayControles(Of TextBox)
    Private TSacos As ArrayControles(Of TextBox)
    Private TFechaUlt As ArrayControles(Of TextBox)
    Private TPesoUlt As ArrayControles(Of TextBox)
    Private TSacChk As ArrayControles(Of TextBox)
    Private TSacxMin As ArrayControles(Of TextBox)
    Private TSacUnder As ArrayControles(Of TextBox)
    Private TSacOver As ArrayControles(Of TextBox)
    Private TSacOK As ArrayControles(Of TextBox)
    Private TPromU20E As ArrayControles(Of TextBox)
    Private TPromU100E As ArrayControles(Of TextBox)
    Private TPromU500E As ArrayControles(Of TextBox)
    Private TDesvSU20E As ArrayControles(Of TextBox)
    Private TDesvSU100E As ArrayControles(Of TextBox)
    Private TDesvSU500E As ArrayControles(Of TextBox)
    Private TMaxU20E As ArrayControles(Of TextBox)
    Private TMaxU100E As ArrayControles(Of TextBox)
    Private TMaxU500E As ArrayControles(Of TextBox)
    Private TContBasc As ArrayControles(Of TextBox)
    Private TBandChk As ArrayControles(Of TextBox)
    Private TSacosB As ArrayControles(Of TextBox)
    Private TSacChkB As ArrayControles(Of TextBox)
    Private TSacUnderB As ArrayControles(Of TextBox)
    Private TSacOverB As ArrayControles(Of TextBox)
    Private TPesoUltB As ArrayControles(Of TextBox)

    'Botones
    Private BShp As ArrayControles(Of Button)
    Private FNuevoEmp As ArrayControles(Of Button)
    Private BHistog As ArrayControles(Of Button)
    Private BProcesa As ArrayControles(Of Button)

    Private ChTorta As ArrayControles(Of Chart)


    'Variables
    Dim PesoAnt(5) As Single
    Dim ContTolva(5) As Integer
    Dim MesDia(5) As Integer

    Dim Maq(5) As Integer
    Dim ContMaq(5) As Integer

    Dim Pos1(5) As Long
    Dim Pos2(5) As Long

    Dim EquipoNo(5) As Integer
    Dim PesoSacoAnt(5) As String
    Dim Topico(5) As String

    Dim ID(5) As Long
    Dim SacGraf(5) As Long
    Dim Prom(5) As Single

    Dim SacoChKB1(5) As Boolean
    Dim SacoChKB2(5) As Boolean

    Dim ValAntB1(5) As Long
    Dim ValAntB2(5) As Long
    Dim ValAntSacB1(5) As Long
    Dim ValAntSacB2(5) As Long

    Dim Pos11(5) As Long
    Dim Pos12(5) As Long

    Dim FechaIni(5) As String
    Dim Recibido(5) As String
    Dim Archivo(5) As String
    Dim EnviadoCom(5) As String
    Dim MinRegAct(5) As Long
    Dim HoraRegAct(5) As Long
    Dim DiaRegAct(5) As Long
    Dim AcumuladoB(5) As Long

    'Variables nuevas

    Dim SacOkB(5) As Long
    Dim SacUnderB(5) As Long
    Dim SacOverB(5) As Long
    Dim SacChkB(5) As Long

    Dim DEmpaque(5) As AdoSQL
    Dim DProd(5) As AdoSQL
    Dim DVarios(5) As AdoSQL
    Dim DPesos(5) As AdoSQL
    Dim DPesosChk(5) As AdoSQL
    Dim DPesosUnOvSac(5) As AdoSQL
    Dim DVariosConfig(5) As AdoSQL
    Dim DVariosConfig2(5) As AdoSQL

    Dim SacosxMin(5) As Single


    Private Sub Empaque_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Try
            TCodProd = New ArrayControles(Of TextBox)("TCodProd", Me)
            TNomProd = New ArrayControles(Of TextBox)("TNomProd", Me)
            TStat = New ArrayControles(Of TextBox)("TStat", Me)
            TPresKg = New ArrayControles(Of TextBox)("TPresKg", Me)
            TPesoTot = New ArrayControles(Of TextBox)("TPesoTot", Me)
            TSacos = New ArrayControles(Of TextBox)("TSacos", Me)
            TFechaUlt = New ArrayControles(Of TextBox)("TFechaUlt", Me)
            TPesoUlt = New ArrayControles(Of TextBox)("TPesoUlt", Me)
            TSacChk = New ArrayControles(Of TextBox)("TSacChk", Me)
            TSacxMin = New ArrayControles(Of TextBox)("TSacxMin", Me)
            TSacUnder = New ArrayControles(Of TextBox)("TSacUnder", Me)
            TSacOver = New ArrayControles(Of TextBox)("TSacOver", Me)
            TSacOK = New ArrayControles(Of TextBox)("TSacOK", Me)
            TPromU20E = New ArrayControles(Of TextBox)("TPromU20E", Me)
            TPromU100E = New ArrayControles(Of TextBox)("TPromU100E", Me)
            TPromU500E = New ArrayControles(Of TextBox)("TPromU500E", Me)
            TDesvSU20E = New ArrayControles(Of TextBox)("TDesvSU20E", Me)
            TDesvSU100E = New ArrayControles(Of TextBox)("TDesvSU100E", Me)
            TDesvSU500E = New ArrayControles(Of TextBox)("TDesvSU500E", Me)
            TMaxU20E = New ArrayControles(Of TextBox)("TMaxU20E", Me)
            TMaxU100E = New ArrayControles(Of TextBox)("TMaxU100E", Me)
            TMaxU500E = New ArrayControles(Of TextBox)("TMaxU500E", Me)
            TContBasc = New ArrayControles(Of TextBox)("TContBasc", Me)
            TBandChk = New ArrayControles(Of TextBox)("TBandChk", Me)
            TSacosB = New ArrayControles(Of TextBox)("TSacosB", Me)
            TSacChkB = New ArrayControles(Of TextBox)("TSacChkB", Me)
            TSacUnderB = New ArrayControles(Of TextBox)("TSacUnderB", Me)
            TSacOverB = New ArrayControles(Of TextBox)("TSacOverB", Me)
            TPesoUltB = New ArrayControles(Of TextBox)("TPesoUltB", Me)

            'Botones
            BShp = New ArrayControles(Of Button)("BShp", Me)
            FNuevoEmp = New ArrayControles(Of Button)("FNuevoEmp", Me)
            BHistog = New ArrayControles(Of Button)("BHistog", Me)
            BProcesa = New ArrayControles(Of Button)("BHistog", Me)


            'Constructores Objetos conexion base de datos

            For i = 1 To 4
                DEmpaque(i) = New AdoSQL("Empaque")
                DProd(i) = New AdoSQL("PRODUCTOS")
                DVarios(i) = New AdoSQL("VARIOS")
                DPesos(i) = New AdoSQL("PESOS")
                DPesosChk(i) = New AdoSQL("PESOSCHK")
                DPesosUnOvSac(i) = New AdoSQL("PESOSUNOVSAC")
                DVariosConfig(i) = New AdoSQL("VARIOSCONFIG")
                DVariosConfig2(i) = New AdoSQL("VARIOSCONFIG")
            Next
            

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BProcesa_Click(sender As System.Object, e As System.EventArgs) Handles BProcesa1.Click
        Try

            Dim Index As Int32 = FNuevoEmp.Index(CType(sender, Button))

            SacoChKB1(Index) = False
            SacoChKB2(Index) = False

            DProd(Index).Open("select * from PRODUCTOS where CODPROD='" + Trim(TCodProd(Index).Text) + "'")
            If DProd(Index).RecordCount = 0 Then Return

            ' Saco Chequeado en B1 de la ensacadora Duplex GSE 665
            If Eval(TSacChkB(Index + 10).Text) > 0 And ValAntB1(Index) <> Eval(TSacChkB(Index + 10).Text) Then

                ValAntB1(Index) = Eval(TSacChkB(Index + 10).Text)

                DPesosChk(Index).Open("select * from PESOSCHK where MAQUINA=0")
                DPesosChk(Index).AddNew()
                DPesosChk(Index).RecordSet("Maquina") = EquipoNo
                DPesosChk(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index).Text)
                DPesosChk(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                DPesosChk(Index).RecordSet("PresKg ") = Eval(TPresKg(Index).Text)
                DPesosChk(Index).RecordSet("Fecha ") = Now
                DPesosChk(Index).RecordSet("ID ") = 0
                DPesosChk(Index).RecordSet("Bascula ") = 1
                DPesosChk(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 20)
                DPesosChk(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                DPesosChk(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")

                DPesosChk(Index).Update()
                ' GraficosEnsc2.BGraficaEnsc.Value = True '''''''OJO PENDIENTE POR FORMULARIO
                SacoChKB1(Index) = True

                'Verifica tolerancias
                If Eval(TPesoUltB(Index + 10).Text) < Eval(DProd(Index).RecordSet("PresKg") - DProd(Index).RecordSet("TolInfEmp")) Then           'Bajo Peso
                    Alarma("Saco con Bajo Peso Báscula 1 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text) + " Kg"))

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")

                    DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                    DPesosUnOvSac(Index).AddNew()

                    DPesosUnOvSac(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DPesosUnOvSac(Index).RecordSet("Maquina ") = EquipoNo
                    DPesosUnOvSac(Index).RecordSet("Bascula ") = 1
                    DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index).Text)
                    DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                    DPesosUnOvSac(Index).RecordSet("Under ") = 1
                    DPesosUnOvSac(Index).RecordSet("Over ") = 0
                    DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                    DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                    DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                    DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                    DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                    DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                    DPesosUnOvSac(Index).Update()

                    DVariosConfig(Index).RecordSet("Cantidad") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()

                End If

                If Eval(TPesoUltB(Index + 10).Text) > (Eval(DProd(Index).RecordSet("PresKg") + DProd(Index).RecordSet("TolSupEmp"))) Then     'Sobre Peso
                    Alarma("Saco con Sobre Peso Báscula 1 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text) + " Kg"))

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")

                    DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                    DPesosUnOvSac(Index).AddNew()

                    DPesosUnOvSac(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DPesosUnOvSac(Index).RecordSet("Maquina ") = Index
                    DPesosUnOvSac(Index).RecordSet("Bascula ") = 1
                    DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index).Text)
                    DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                    DPesosUnOvSac(Index).RecordSet("Under ") = 0
                    DPesosUnOvSac(Index).RecordSet("Over ") = 1
                    DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                    DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                    DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                    DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                    DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                    DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                    DPesosUnOvSac(Index).Update()

                    DVariosConfig(Index).RecordSet("Cantidad") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()
                End If
            End If

            ' Saco Chequeado en B2 de la ensacadora Duplex GSE 665

            If Eval(TSacChkB(Index + 10).Text) > 0 And ValAntB2(Index) <> Eval(TSacChkB(Index + 10).Text) Then

                ValAntB2(Index) = Eval(TSacChkB(Index + 10).Text)


                DPesosChk(Index).Open("select * from PESOSCHK where MAQUINA=0")
                DPesosChk(Index).AddNew()
                DPesosChk(Index).RecordSet("Maquina") = Index
                DPesosChk(Index).RecordSet("Peso") = Eval(TPesoUltB(Index + 10).Text)
                DPesosChk(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                DPesosChk(Index).RecordSet("PresKg ") = Eval(TPresKg(Index).Text)
                DPesosChk(Index).RecordSet("Fecha ") = Now
                DPesosChk(Index).RecordSet("ID ") = 0
                DPesosChk(Index).RecordSet("Bascula ") = 2
                DPesosChk(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 20)
                DPesosChk(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                DPesosChk(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")

                DPesosChk(Index).Update()
                'GraficosEnsc2.BGraficaEnsc.Value = True OJOOOOOOO FALTA FORMULARIO
                SacoChKB2(Index) = True


                'Verifica tolerancias
                If Eval(TPesoUltB(Index + 10).Text) < (Eval(DProd(Index).RecordSet("PresKg") - DProd(Index).RecordSet("TolInfEmp"))) Then           'Bajo Peso
                    Alarma("Saco con Bajo Peso Báscula 2 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text) + " Kg"))

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")

                    DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                    DPesosUnOvSac(Index).AddNew()

                    DPesosUnOvSac(Index).RecordSet("Cont") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DPesosUnOvSac(Index).RecordSet("Maquina ") = Index
                    DPesosUnOvSac(Index).RecordSet("Bascula ") = 2
                    DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index + 10).Text)
                    DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                    DPesosUnOvSac(Index).RecordSet("Under ") = 1
                    DPesosUnOvSac(Index).RecordSet("Over ") = 0
                    DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                    DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                    DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                    DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                    DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                    DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                    DPesosUnOvSac(Index).Update()

                    DVariosConfig(Index).RecordSet("Cantidad") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()

                End If

                If Eval(TPesoUltB(Index + 10).Text) > (Eval(DProd(Index).RecordSet("PresKg") + DProd(Index).RecordSet("TolSupEmp"))) Then     'Sobre Peso
                    Alarma("Saco con Sobre Peso Báscula 2 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text)) + " Kg")

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")

                    DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                    DPesosUnOvSac(Index).AddNew()

                    DPesosUnOvSac(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DPesosUnOvSac(Index).RecordSet("Maquina ") = Index
                    DPesosUnOvSac(Index).RecordSet("Bascula ") = 2
                    DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index + 10).Text)
                    DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                    DPesosUnOvSac(Index).RecordSet("Under ") = 0
                    DPesosUnOvSac(Index).RecordSet("Over ") = 1
                    DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                    DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                    DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                    DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                    DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                    DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                    DPesosUnOvSac(Index).Update()
                    DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()
                End If

            End If

            ' Saco Empacado en B1 de la ensacadora Duplex GSE 665

            If Eval(TSacosB(Index + 10).Text) > 0 And ValAntSacB1(Index) <> Eval(TSacosB(Index + 10).Text) And SacoChKB1(Index) = False Then

                ValAntSacB1(Index) = Eval(TSacosB(Index + 10).Text)


                DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='SacGraf" + Trim(Index) + "'")

                SacGraf(Index) = DVariosConfig(Index).RecordSet("Cantidad")

                DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsGraf21'")

                ID = DVariosConfig(Index).RecordSet("Cantidad")

                DPesos(Index).Open("select * from PESOS where MAQUINA=0 order by CONT")

                If Eval(TPesoUltB(Index + 10).Text) > 0 Then

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesos' ")

                    DPesos(Index).AddNew()
                    DPesos(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DPesos(Index).RecordSet("Maquina ") = Index
                    DPesos(Index).RecordSet("CodProd ") = Trim(TCodProd(Index).Text)
                    DPesos(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index + 10).Text)
                    DPesos(Index).RecordSet("ID ") = ID(Index)
                    DPesos(Index).RecordSet("Bascula ") = 1
                    DPesos(Index).Update()

                    DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()


                    DVariosConfig2(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ContSac21' ")

                    DVariosConfig2(Index).RecordSet("Cantidad") = DVariosConfig2(Index).RecordSet("Cantidad") + 1
                    DVariosConfig2(Index).Update()

                    'Verifica tolerancias
                    If Eval(TPesoUltB(Index + 10).Text) < (Eval(DProd(Index).RecordSet("PresKg")) - DProd(Index).RecordSet("TolInfEmp")) Then           'Bajo Peso
                        Alarma("Saco con Bajo Peso Báscula 1 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text)) + " Kg")


                        DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")

                        DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                        DPesosUnOvSac(Index).AddNew()

                        DPesosUnOvSac(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DPesosUnOvSac(Index).RecordSet("Maquina ") = Index
                        DPesosUnOvSac(Index).RecordSet("Bascula ") = 1
                        DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index + 10).Text)
                        DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                        DPesosUnOvSac(Index).RecordSet("Under ") = 1
                        DPesosUnOvSac(Index).RecordSet("Over ") = 0
                        DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                        DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                        DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                        DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                        DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                        DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                        DPesosUnOvSac(Index).Update()

                        DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DVariosConfig(Index).Update()

                    End If

                    If Eval(TPesoUltB(Index + 10).Text) > (Eval(DProd(Index).RecordSet("PresKg")) + DProd(Index).RecordSet("TolSupEmp")) Then     'Sobre Peso
                        Alarma("Saco con Sobre Peso Báscula 1 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text)) + " Kg")

                        DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")


                        DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                        DPesosUnOvSac(Index).AddNew()

                        DPesosUnOvSac(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DPesosUnOvSac(Index).RecordSet("Maquina ") = Index
                        DPesosUnOvSac(Index).RecordSet("Bascula ") = 1
                        DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index + 10).Text)
                        DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                        DPesosUnOvSac(Index).RecordSet("Under ") = 0
                        DPesosUnOvSac(Index).RecordSet("Over ") = 1
                        DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                        DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                        DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                        DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                        DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                        DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                        DPesosUnOvSac(Index).Update()

                        DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DVariosConfig(Index).Update()
                    End If

                End If


                DVariosConfig2(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ContSac21' ")

                If DVariosConfig2(Index).RecordSet("Cantidad") = SacGraf(Index) Then

                    DVariosConfig2(Index).RecordSet("Cantidad") = 0 'Reinicio el contador de sacos de la bascula 1
                    DVariosConfig2(Index).Update()



                    DVarios(Index).Open("select AVG(PESO) AS PESOPROM from PESOS where MAQUINA=" + Trim(Index) + " and BASCULA=1 and ID=" + Trim(ID(Index)) + " order by CONT desc")

                    If DVarios(Index).RecordCount = 0 Then
                        Prom(Index) = Eval(TPesoUltB(Index + 10).Text)
                    Else
                        Prom(Index) = DVarios(Index).RecordSet("PESOPROM")
                    End If

                    DPesosChk(Index).Open("select * from PESOSCHK where MAQUINA=0")
                    DPesosChk(Index).AddNew()
                    DPesosChk(Index).RecordSet("Maquina ") = Index
                    DPesosChk(Index).RecordSet("Peso ") = Prom(Index)
                    DPesosChk(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                    DPesosChk(Index).RecordSet("PresKg ") = Eval(TPresKg(Index).Text)
                    DPesosChk(Index).RecordSet("Fecha ") = Now
                    DPesosChk(Index).RecordSet("ID ") = ID(Index)
                    DPesosChk(Index).RecordSet("Bascula ") = 1
                    DPesosChk(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 20)
                    DPesosChk(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                    DPesosChk(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")

                    DPesosChk(Index).Update()

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsGraf21'")

                    DVariosConfig(Index).RecordSet("Cantidad") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()

                    'GraficosEnsc2.BGraficaEnsc.Value = True  OJO FALTA FORMULARIO
                End If

            End If

            ' Saco Empacado en B2 de la ensacadora Duplex GSE 665

            If Eval(TSacosB(Index + 10).Text) > 0 And ValAntSacB2(Index) <> Eval(TSacosB(Index + 10).Text) And SacoChKB2(Index) = False Then

                ValAntSacB2(Index) = Eval(TSacosB(Index + 10).Text)


                DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='SacGraf" + Trim(Index) + "'")


                SacGraf(Index) = DVariosConfig(Index).RecordSet("Cantidad")


                DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsGraf22'")

                ID(Index) = DVariosConfig(Index).RecordSet("Cantidad")

                DPesos(Index).Open("select * from PESOS where MAQUINA=0 order by CONT")

                If Eval(TPesoUltB(Index + 10).Text) > 0 Then


                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesos' ")


                    DPesos(Index).AddNew()
                    DPesos(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DPesos(Index).RecordSet("Maquina ") = Index
                    DPesos(Index).RecordSet("CodProd ") = Trim(TCodProd(Index).Text)
                    DPesos(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index + 10).Text)
                    DPesos(Index).RecordSet("ID ") = ID(Index)
                    DPesos(Index).RecordSet("Bascula ") = 2
                    DPesos(Index).Update()

                    DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()


                    DVariosConfig2(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ContSac22' ")

                    DVariosConfig2(Index).RecordSet("Cantidad") = DVariosConfig2(Index).RecordSet("Cantidad") + 1
                    DVariosConfig2(Index).Update()

                    'Verifica tolerancias
                    If Eval(TPesoUltB(Index + 10).Text) < (Eval(DProd(Index).RecordSet("PresKg")) - DProd(Index).RecordSet("TolInfEmp")) Then           'Bajo Peso
                        Alarma("Saco con Bajo Peso Báscula 2 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text)) + " Kg")


                        DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")



                        DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                        DPesosUnOvSac(Index).AddNew()

                        DPesosUnOvSac(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DPesosUnOvSac(Index).RecordSet("Maquina ") = Index
                        DPesosUnOvSac(Index).RecordSet("Bascula ") = 2
                        DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index).Text)
                        DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                        DPesosUnOvSac(Index).RecordSet("Under ") = 1
                        DPesosUnOvSac(Index).RecordSet("Over ") = 0
                        DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                        DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                        DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                        DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                        DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                        DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                        DPesosUnOvSac(Index).Update()

                        DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DVariosConfig(Index).Update()

                    End If

                    If Eval(TPesoUltB(Index + 10).Text) > (Eval(DProd(Index).RecordSet("PresKg")) + DProd(Index).RecordSet("TolSupEmp")) Then     'Sobre Peso
                        Alarma("Saco con Sobre Peso Báscula 2 ensacadora " + Trim(Index) + " Saco " + Trim(TSacos(Index).Text) + " Peso Saco " + Trim(Eval(TPesoUltB(Index + 10).Text)) + " Kg")


                        DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsPesosUnOvSac'")

                        DPesosUnOvSac(Index).Open(" select * from PESOSUNOVSAC where MAQUINA=0") 'Lo abro Vacío

                        DPesosUnOvSac(Index).AddNew()

                        DPesosUnOvSac(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DPesosUnOvSac(Index).RecordSet("Maquina ") = Index
                        DPesosUnOvSac(Index).RecordSet("Bascula ") = 2
                        DPesosUnOvSac(Index).RecordSet("Peso ") = Eval(TPesoUltB(Index + 10).Text)
                        DPesosUnOvSac(Index).RecordSet("Saco ") = Eval(TSacos(Index).Text)
                        DPesosUnOvSac(Index).RecordSet("Under ") = 0
                        DPesosUnOvSac(Index).RecordSet("Over ") = 1
                        DPesosUnOvSac(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                        DPesosUnOvSac(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 50)
                        DPesosUnOvSac(Index).RecordSet("PresKg ") = DProd(Index).RecordSet("PresKg")
                        DPesosUnOvSac(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                        DPesosUnOvSac(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                        DPesosUnOvSac(Index).RecordSet("Fecha ") = Now
                        DPesosUnOvSac(Index).Update()

                        DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                        DVariosConfig(Index).Update()
                    End If

                End If


                DVariosConfig2(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ContSac22' ")

                If DVariosConfig2(Index).RecordSet("Cantidad") = SacGraf(Index) Then

                    DVariosConfig2(Index).RecordSet("Cantidad") = 0 'Reinicio el contador de sacos de la bascula 2
                    DVariosConfig2(Index).Update()
                    DVarios(Index).Open("select AVG(PESO) AS PESOPROM from PESOS where MAQUINA=" + Trim(Index) + " and BASCULA=2 and ID=" + Trim(ID(Index)) + " order by CONT desc")

                    If DVarios(Index).RecordCount = 0 Then
                        Prom(Index) = Eval(TPesoUltB(Index + 10).Text)
                    Else
                        Prom(Index) = DVarios(Index).RecordSet("PESOPROM")
                    End If


                    DPesosChk(Index).Open("select * from PESOSCHK where MAQUINA=0")
                    DPesosChk(Index).AddNew()
                    DPesosChk(Index).RecordSet("Maquina ") = Index
                    DPesosChk(Index).RecordSet("Peso ") = Prom(Index)
                    DPesosChk(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
                    DPesosChk(Index).RecordSet("PresKg ") = Eval(TPresKg(Index).Text)
                    DPesosChk(Index).RecordSet("Fecha ") = Now
                    DPesosChk(Index).RecordSet("ID ") = ID(Index)
                    DPesosChk(Index).RecordSet("Bascula ") = 2
                    DPesosChk(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 20)
                    DPesosChk(Index).RecordSet("TolInfEmp ") = DProd(Index).RecordSet("TolInfEmp")
                    DPesosChk(Index).RecordSet("TolSupEmp ") = DProd(Index).RecordSet("TolSupEmp")
                    DPesosChk(Index).Update()

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsGraf22'")

                    DVariosConfig(Index).RecordSet("Cantidad") = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()

                    'GraficosEnsc2.BGraficaEnsc.Value = True 'OJO FALTA FORMULARIO
                End If


            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub FNuevoEmp1_Click(sender As System.Object, e As System.EventArgs) Handles FNuevoEmp1.Click
        Try
            Dim Index As Int32 = FNuevoEmp.Index(CType(sender, Button))

            MesDia(Index) = Format(Now, "MMdd")

            Evento("Inicia ciclo de empaque Máq." + Trim(Index))

            DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsEmpaque" + Trim(Index) + "'")

            DEmpaque(Index).AddNew()
            DEmpaque(Index).RecordSet("Cont ") = DVariosConfig(Index).RecordSet("Cantidad") + 1   ' Autonúmerico Esperar para Oracle
            DEmpaque(Index).RecordSet("CodProd ") = CLeft(TCodProd(Index).Text, 20)
            DEmpaque(Index).RecordSet("NomProd ") = CLeft(TNomProd(Index).Text, 20)
            DEmpaque(Index).RecordSet("ContBasc ") = TContBasc(Index).Text
            DEmpaque(Index).RecordSet("Maquina ") = Index
            DEmpaque(Index).RecordSet("PresKg ") = Eval(TPresKg(Index).Text)
            DEmpaque(Index).RecordSet("MesDia ") = MesDia
            DEmpaque(Index).RecordSet("Acumulado ") = AcumuladoB
            DEmpaque(Index).RecordSet("Acumulado2 ") = 0

            DEmpaque(Index).RecordSet("SacOkB ") = SacOkB(Index)
            DEmpaque(Index).RecordSet("SacChkB ") = SacChkB(Index)
            DEmpaque(Index).RecordSet("SacUnderB ") = SacUnderB(Index)
            DEmpaque(Index).RecordSet("SacOverB ") = SacOverB(Index)
            DEmpaque(Index).RecordSet("SacOkA ") = 0
            DEmpaque(Index).RecordSet("SacUnderA ") = 0
            DEmpaque(Index).RecordSet("SacOverA ") = 0
            DEmpaque(Index).RecordSet("SacChkA ") = 0

            DEmpaque(Index).RecordSet("Fecha ") = FechaC()
            DEmpaque(Index).RecordSet("Fecha2 ") = FechaC()
            DEmpaque(Index).RecordSet("FECHAF ") = Now
            DEmpaque(Index).RecordSet("FECHAF2 ") = Now
            DEmpaque(Index).Update()

            DVariosConfig(Index).RecordSet("Cantidad ") = DVariosConfig(Index).RecordSet("Cantidad") + 1
            DVariosConfig(Index).Update()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub TCodProd1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TCodProd1.TextChanged
        Try
            Dim Index As Int32 = FNuevoEmp.Index(CType(sender, Button))
            If Eval(TCodProd(Index).Text) = 0 Then Exit Sub

            DProd(Index).Open("select * from PRODUCTOS where CODPROD='" + Trim(TCodProd(Index).Text) + "'")

            If DProd(Index).RecordCount > 0 Then
                TNomProd(Index).Text = Trim(CLeft(DProd(Index).RecordSet("NomProd"), 30))
                TPresKg(Index).Text = Trim(DProd(Index).RecordSet("PresKg"))
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub TSacos1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TSacos1.TextChanged
        Try
            Dim Index As Int32 = FNuevoEmp.Index(CType(sender, Button))

            If Eval(TSacos(Index).Text) = 0 Then Exit Sub


            DVarios(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='AcumMinRep" + Trim(Index) + "'")


            DEmpaque(Index).Open("select * from EMPAQUE" + Trim(Index) + " where CONTBASC=" + Trim(TContBasc(Index).Text) + " and MAQUINA=" + Trim(Index) + " order by CONT desc")
            If DEmpaque(Index).RecordCount = 0 Then
                AcumuladoB(Index) = 0
                SacOkB(Index) = 0
                SacOverB(Index) = 0
                SacUnderB(Index) = 0
                SacChkB(Index) = 0

                FNuevoEmp1_Click(FNuevoEmp(Index), Nothing)

                Alarma("Repeso " + Trim(Index) + " Hora de Comprobar Sacos " + vbCrLf + _
                "Ponga Muestra")
                'ServidorRep2.ComenzarRep = True
                'ServEnsac2.BActivaAlarma.Value = True

                DVarios(Index).RecordSet("Cantidad") = 0
                DVarios(Index).Update()
                ' Reinicio los contadores de Sacos de la Empacadora 

                Dim ContSacAux As String = ""

                If Index = 2 Then
                    DVariosConfig2(Index).Open("UPDATE VARIOSCONFIG SET CANTIDAD=0 where DESCRIPCION='ContSac21' OR DESCRIPCION='ContSac22' ")
                Else
                    DVariosConfig2(Index).Open("UPDATE VARIOSCONFIG SET CANTIDAD=0 where DESCRIPCION='ContSac" + Index.ToString + "'")
                End If


                ' Incremento el ID de cada bascula de la empacadora 2 para queden registrados en el empaque nuevo

                If Index = 2 Then
                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsGraf21'")
                    ID(Index) = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()

                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsGraf22'")
                    ID(Index) = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()

                Else
                    DVariosConfig(Index).Open("select * from VARIOSCONFIG where DESCRIPCION='ConsGraf" + Index.ToString + "'")
                    ID(Index) = DVariosConfig(Index).RecordSet("Cantidad") + 1
                    DVariosConfig(Index).Update()
                End If
            End If

            DEmpaque(Index).Open("select TOP 1 * from EMPAQUE" + Trim(Index) + " where CONTBASC=" + Trim(TContBasc(Index).Text) + " and MAQUINA=" + Trim(Index) + " order by CONT")
            FechaIni = DEmpaque(Index).RecordSet("Fecha")

            If Index = 2 Then
                BProcesa_Click(BProcesa(2), Nothing) = True ' Proceso los datos de las dos Básculas de la Ensacadora Duplex Gse 665
            End If



            DEmpaque.MoveFirst()
            AcumuladoB = DEmpaque!Acumulado2
            SacOkB = DEmpaque!SacOkA
            SacOverB = DEmpaque!SacOverA
            SacUnderB = DEmpaque!SacUnderA
            SacChkB = DEmpaque!SacChkA


            If Eval(TSacos) <= DEmpaque!Acumulado2 Then Exit Sub


            DiaRegAct = Eval(Format(DEmpaque!Fecha2, "dd"))
            HoraRegAct = Eval(Format(DEmpaque!Fecha2, "hh"))
            MinRegAct = Eval(Format(DEmpaque!Fecha2, "nn"))

            TFechaUlt = FechaC()


            If DiaRegAct <> Eval(Format(TFechaUlt, "dd")) Then ' Corte de Fecha
                FNuevoEmp.Value = True
                DEmpaque.Requery()
            ElseIf HoraRegAct <> Eval(Format(TFechaUlt, "hh")) Then ' Corte de Hora
                FNuevoEmp.Value = True
                DEmpaque.Requery()
            ElseIf MinRegAct <= 30 And Eval(Format(TFechaUlt, "nn")) > 30 Then 'Corte de Media Hora
                FNuevoEmp.Value = True
                DEmpaque.Requery()
            End If

            DEmpaque.Requery()
            DEmpaque.MoveFirst()


            If DVariosConfig.State > 0 Then DVariosConfig.Close()
            DVariosConfig.Open("select * from VARIOSCONFIG where DESCRIPCION='AcumMinRep" + Trim(EquipoNo) + "'")
            DVariosConfig.Requery()

            If DVarios.State > 0 Then DVarios.Close()

            DVarios.Open("select * from VARIOSCONFIG where DESCRIPCION='MinRep" + Trim(EquipoNo) + "'")
            DVarios.Requery()


            If DateDiff("n", FechaIni, TFechaUlt) - DVariosConfig!Cantidad >= DVarios!Cantidad Then

                DVariosConfig!Cantidad = Int(Eval(DateDiff("n", FechaIni, TFechaUlt) / DVarios!Cantidad)) * DVarios!Cantidad
                DVariosConfig.Update()

                Alarma("Repeso " + Trim(EquipoNo) + " Hora de Comprobar Sacos " + vbCrLf + _
                "Ponga Muestra")
                ServidorRep2.ComenzarRep = True
                ServEnsac2.BActivaAlarma.Value = True

                'Else
                '
                '        If DateDiff("n", DEmpaque!Fecha, TFechaUlt) Mod DVarios!Cantidad = 0 Then
                '
                '                DVariosConfig!Cantidad = Int(Eval(DateDiff("n", FechaIni, TFechaUlt) / DVarios!Cantidad)) * DVarios!Cantidad
                '                DVariosConfig.Update
                '
                '                Alarma "Repeso " + Trim(EquipoNo) + " Hora de Comprobar Sacos " + vbCrLf + _
                '                "Ponga Muestra"
                '                ServidorRep2.ComenzarRep = True
                '                ServEnsac2.BActivaAlarma.Value = True
                '
                '        End If

            End If


            TSacOK = Eval(TSacChk) - Eval(TSacUnder) - Eval(TSacOver)

            Me.Caption = Trim(TPesoTot) + " Ensaque"


            'If Eval(TProm) > 0 Then
            '        DEmpaque!Prom = Eval(TProm)
            '        DEmpaque!DESVS = Eval(TDesvS)
            'End If
            If Eval(TPromU20) > 0 Then
                DEmpaque!Prom = Eval(TPromU20)
                DEmpaque!DESVS = Eval(TDesvSU20)
            End If

            DEmpaque!Acumulado2 = Eval(TSacos)
            DEmpaque!Sacos = DEmpaque!Acumulado2 - DEmpaque!Acumulado
            DEmpaque!PresKg = Eval(TPreset)
            DEmpaque!Peso = DEmpaque!Sacos * Eval(TPreset)

            DEmpaque!SacOkA = Eval(TSacOK)
            DEmpaque!SacUnderA = Eval(TSacUnder)
            DEmpaque!SacOverA = Eval(TSacOver)
            DEmpaque!SacChkA = Eval(TSacChk)
            DEmpaque!SACOK = DEmpaque!SacOkA - DEmpaque!SacOkB
            DEmpaque!SacUnder = DEmpaque!SacUnderA - DEmpaque!SacUnderB
            DEmpaque!SacOver = DEmpaque!SacOverA - DEmpaque!SacOverB
            DEmpaque!SACCHK = DEmpaque!SacChkA - DEmpaque!SacChkB

            DEmpaque!Fecha2 = FechaC()
            DEmpaque!FECHAF2 = Now

            DEmpaque.Update()

            TSacxMin = (DEmpaque!FECHAF2 - DEmpaque!FECHAF) * 1410
            If Eval(TSacxMin) > 0 Then TSacxMin = Format(Eval(TSacos) / TSacxMin, "#0.0")

            Torta.Column = 1
            Torta.Data = Eval(TSacUnder)
            Torta.Column = 2
            Torta.Data = Eval(TSacOK)
            Torta.Column = 3
            Torta.Data = Eval(TSacOver)

            If DVarios.State > 0 Then DVarios.Close()
            DVarios.Open("select * from ESTADU20 where MAQUINA=" + Trim(EquipoNo) + " and CODPROD='" + Trim(TCodProd) + "'")
            If DVarios.RecordCount > 0 Then
                TPromU20 = Format(DVarios!Prom, "#0.00")
                TDesvSU20 = Format(DVarios!DESVS, "#0.000")
                TMaxU20 = Format(DVarios!MaxP, "#0.00")
                TMinU20 = Format(DVarios!MinP, "#0.00")
            End If

            If DVarios.State > 0 Then DVarios.Close()
            DVarios.Open("select * from ESTADU100 where MAQUINA=" + Trim(EquipoNo) + " and CODPROD='" + Trim(TCodProd) + "'")
            If DVarios.RecordCount > 0 Then
                TPromU100 = Format(DVarios!Prom, "#0.00")
                TDesvSU100 = Format(DVarios!DESVS, "#0.000")
                TMaxU100 = Format(DVarios!MaxP, "#0.00")
                TMinU100 = Format(DVarios!MinP, "#0.00")
            End If

            If DVarios.State > 0 Then DVarios.Close()
            DVarios.Open("select * from ESTAD where MAQUINA=" + Trim(EquipoNo) + " and CODPROD='" + Trim(TCodProd) + "'")
            If DVarios.RecordCount > 0 Then
                TProm = Format(DVarios!Prom, "#0.00")
                TDesvS = Format(DVarios!DESVS, "#0.000")
                TMax = Format(DVarios!MaxP, "#0.00")
                TMin = Format(DVarios!MinP, "#0.00")
            End If





        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class