Imports System.Windows.Forms.DataVisualization.Charting

Public Class GraficosEmp

    Private DEmpaque As AdoSQL
    Private FormLoad As Boolean
    Public Graficas As Grafica
    Public GraficasRep As GraficaRep
    Private GrafOk As Boolean
    Private DVarios As AdoSQL
    Private CompararX As Single
    
    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub GraficosEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            If FormLoad Then Return

            DEmpaque = New AdoSQL("EMPAQUE")

            If Empacadora = 1 Or Empacadora = 3 Then
                TLPEmpaque.RowStyles.Item(1).SizeType = SizeType.Absolute
                TLPEmpaque.RowStyles.Item(1).Height = 0
                TLPEmpaque.RowStyles.Item(0).Height = 50
                TLPEmpaque.RowStyles.Item(3).Height = 50
            End If

            FormLoad = True

            Graficas = New Grafica
            GraficasRep = New GraficaRep

            DVarios = New AdoSQL("VARIOS")



            'ChRep = New Chart()


            'Agrego La grafica nueva a la posición 0,5 del tableloyutpanel

            'TLPEmpaque.Controls.Add(ChRep, 0, 4)
            'Dim cellPos As New TableLayoutPanelCellPosition(0, 0)
            'Dim cellPos2 As New TableLayoutPanelCellPosition(0, 4)
            'Dim cellPos3 As New TableLayoutPanelCellPosition(0, 2)

            'TLPEmpaque.SetCellPosition(ChEmpB1, cellPos)
            'TLPEmpaque.SetCellPosition(ChRep, cellPos2)
            'TLPEmpaque.SetCellPosition(ChEmpB2, cellPos3)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

   
    Private Sub TimActualiza_Tick(sender As System.Object, e As System.EventArgs) Handles TimActualiza.Tick
        Try
            If ChActAutom.Checked = False Then
                Return
            End If

            'Se grafican los pesos checkeados

            DEmpaque.Open("select top 10 * from EMPAQUE" + Empacadora.ToString + " where MAQUINA=" + Empacadora.ToString + " order by FECHA desc")
            If DEmpaque.RecordCount = 0 Then Return

            TFechaIni.Text = Format(DEmpaque.RecordSet("Fecha"), "yyyy-MM-dd HH:00:00")
            TFechaFin.Text = Format(DateAdd(DateInterval.Hour, 1, DEmpaque.RecordSet("Fecha")), "yyyy-MM-dd HH:00:00")

            Graficas.Fecha = CDate(TFechaIni.Text)
            Graficas.Intervalo = 1
            Graficas.Basc = 1
            Graficas.Maq = Empacadora
            Graficas.FGraficar(ChEmpB1)
            TCodProd.Text = Graficas.CodProd

            If Empacadora = 2 Or Empacadora = 4 Then
                Graficas.Fecha = CDate(TFechaIni.Text)
                Graficas.Intervalo = 1
                Graficas.Basc = 2
                Graficas.Maq = Empacadora
                Graficas.FGraficar(ChEmpB2)
                TCodProd.Text = Graficas.CodProd
            End If

            'Se grafican los pesos de la tabla repeso

            TFechaIniRep.Text = Format(DEmpaque.RecordSet("Fecha"), "yyyy-MM-dd HH:00:00")
            TFechaFinRep.Text = Format(DateAdd(DateInterval.Hour, 1, DEmpaque.RecordSet("Fecha")), "yyyy-MM-dd HH:00:00")

            GraficasRep.Fecha = CDate(TFechaIniRep.Text)
            GraficasRep.Intervalo = 1
            GraficasRep.Maq = Empacadora
            GraficasRep.FGraficar(ChRep)
            TCodProdRep.Text = GraficasRep.CodProd

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub mnSalir_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub BPrevious_Click(sender As System.Object, e As System.EventArgs) Handles BPrevious.Click
        Try
            TFechaIni.Text = Format(DateAdd(DateInterval.Hour, -1, CDate(TFechaIni.Text)), "yyyy-MM-dd HH:00:00")
            TFechaFin.Text = Format(DateAdd(DateInterval.Hour, -1, CDate(TFechaFin.Text)), "yyyy-MM-dd HH:00:00")

            Graficas.Fecha = CDate(TFechaIni.Text)
            Graficas.Intervalo = 1
            Graficas.Basc = 1
            Graficas.Maq = Empacadora
            Graficas.FGraficar(ChEmpB1)
            TCodProd.Text = Graficas.CodProd
            
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BNext_Click(sender As System.Object, e As System.EventArgs) Handles BNext.Click
        Try
            TFechaIni.Text = Format(DateAdd(DateInterval.Hour, 1, CDate(TFechaIni.Text)), "yyyy-MM-dd HH:00:00")
            TFechaFin.Text = Format(DateAdd(DateInterval.Hour, 1, CDate(TFechaFin.Text)), "yyyy-MM-dd HH:00:00")

            Graficas.Fecha = CDate(TFechaIni.Text)
            Graficas.Intervalo = 1
            Graficas.Basc = 1
            Graficas.Maq = Empacadora
            Graficas.FGraficar(ChEmpB1)
            TCodProd.Text = Graficas.CodProd
            If Empacadora = 2 Or Empacadora = 4 Then
                Graficas.Fecha = CDate(TFechaIni.Text)
                Graficas.Intervalo = 1
                Graficas.Basc = 2
                Graficas.Maq = Empacadora
                Graficas.FGraficar(ChEmpB2)
                TCodProd.Text = Graficas.CodProd
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

   
    Private Sub BNextRep_Click(sender As System.Object, e As System.EventArgs) Handles BNextRep.Click
        Try
            TFechaIniRep.Text = Format(DateAdd(DateInterval.Hour, 1, CDate(TFechaIniRep.Text)), "yyyy-MM-dd HH:00:00")
            TFechaFinRep.Text = Format(DateAdd(DateInterval.Hour, 1, CDate(TFechaFinRep.Text)), "yyyy-MM-dd HH:00:00")

            GraficasRep.Fecha = CDate(TFechaIniRep.Text)
            GraficasRep.Intervalo = 1
            GraficasRep.Basc = 1
            GraficasRep.Maq = Empacadora
            GraficasRep.FGraficar(ChRep)
            TCodProdRep.Text = GraficasRep.CodProd
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BPreviousRep_Click(sender As System.Object, e As System.EventArgs) Handles BPreviousRep.Click
        Try
            TFechaIniRep.Text = Format(DateAdd(DateInterval.Hour, -1, CDate(TFechaIniRep.Text)), "yyyy-MM-dd HH:00:00")
            TFechaFinRep.Text = Format(DateAdd(DateInterval.Hour, -1, CDate(TFechaFinRep.Text)), "yyyy-MM-dd HH:00:00")

            GraficasRep.Fecha = CDate(TFechaIniRep.Text)
            GraficasRep.Intervalo = 1
            GraficasRep.Basc = 1
            GraficasRep.Maq = Empacadora
            GraficasRep.FGraficar(ChRep)
            TCodProdRep.Text = GraficasRep.CodProd

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BFiltrarEmp_Click(sender As System.Object, e As System.EventArgs) Handles BFiltrarEmp.Click
        Try
            ProcesoFiltrar = "ensaque"
            FiltroFecha.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BFiltrarRep_Click(sender As System.Object, e As System.EventArgs) Handles BFiltrarRep.Click
        Try
            ProcesoFiltrar = "comprobación"
            FiltroFecha.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub ChEmpB2_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ChEmpB2.MouseDown
        Try

            Dim hitResult As HitTestResult = ChEmpB2.HitTest(e.X, e.Y)
            Dim selectedDataPoint As DataPoint = Nothing

            If hitResult.Series Is Nothing Then Return
            If hitResult.Series.Name <> "PesoPunto" Then
                hitResult = Nothing
                Return
            End If

            If hitResult.ChartElementType = ChartElementType.DataPoint Then
                selectedDataPoint = CType(hitResult.Object, DataPoint)
                If TCodProd.Text = "" Then Return

                DVarios.Open("select * from PESOSCHK where CODPROD='" + TCodProd.Text + "' and MAQUINA=" + Empacadora.ToString + " and BASCULA=2 and FECHA between '" + TFechaIni.Text + "' and '" + TFechaFin.Text + "' order by Fecha")
                If DVarios.RecordCount = 0 Then Exit Sub

                For Each Fila As DataRow In DVarios.Rows
                    CompararX = Math.Round(Eval(Minute(Fila("FECHA")) + Second(Fila("FECHA")) / 100), 2)
                    If CompararX >= selectedDataPoint.XValue - 0.3 And CompararX <= selectedDataPoint.XValue + 0.3 Then
                        DatosGraf.TCodProd.Text = Fila("CODPROD")
                        DatosGraf.TID.Text = Fila("ID")
                        DatosGraf.TMaquina.Text = Fila("MAQUINA")
                        DatosGraf.TProm.Text = Fila("PESO")
                        DatosGraf.TNomProd.Text = Fila("NOMPROD")
                        DatosGraf.TPresKg.Text = Fila("PRESKG")
                        DatosGraf.TBascula.Text = Fila("BASCULA")
                        DatosGraf.TFecha.Text = Format(Fila("FECHA"), "yyyy-MM-dd HH:mm:ss")
                        DatosGraf.DatosGraf_Load(Nothing, Nothing)
                        DatosGraf.BGrafEnsac_Click(Nothing, Nothing)
                        DatosGraf.Show()
                        Exit For
                    End If
                Next


            End If

            hitResult = Nothing
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub ChEmpB1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ChEmpB1.MouseDown
        Try
            Dim hitResult As HitTestResult = ChEmpB1.HitTest(e.X, e.Y)
            Dim selectedDataPoint As DataPoint = Nothing

            If hitResult.Series Is Nothing Then Return
            If hitResult.Series.Name <> "PesoPunto" Then
                hitResult = Nothing
                Return
            End If


            If hitResult.ChartElementType = ChartElementType.DataPoint Then
                selectedDataPoint = CType(hitResult.Object, DataPoint)
                If TCodProd.Text = "" Then Return

                DVarios.Open("select * from PESOSCHK where CODPROD='" + TCodProd.Text + "' and MAQUINA=" + Empacadora.ToString + " and BASCULA=1 and FECHA between '" + TFechaIni.Text + "' and '" + TFechaFin.Text + "' order by Fecha")
                If DVarios.RecordCount = 0 Then Exit Sub

                For Each Fila As DataRow In DVarios.Rows
                    CompararX = Math.Round(Eval(Minute(Fila("FECHA")) + Second(Fila("FECHA")) / 100), 2)
                    If CompararX >= selectedDataPoint.XValue - 0.3 And CompararX <= selectedDataPoint.XValue + 0.3 Then
                        DatosGraf.TCodProd.Text = Fila("CODPROD")
                        DatosGraf.TID.Text = Fila("ID")
                        DatosGraf.TMaquina.Text = Fila("MAQUINA")
                        DatosGraf.TProm.Text = Fila("PESO")
                        DatosGraf.TNomProd.Text = Fila("NOMPROD")
                        DatosGraf.TPresKg.Text = Fila("PRESKG")
                        DatosGraf.TBascula.Text = Fila("BASCULA")
                        DatosGraf.TFecha.Text = Format(Fila("FECHA"), "yyyy-MM-dd HH:mm:ss")
                        DatosGraf.DatosGraf_Load(Nothing, Nothing)
                        DatosGraf.BGrafEnsac_Click(Nothing, Nothing)
                        DatosGraf.Show()
                        Exit For
                    End If
                Next


            End If

            hitResult = Nothing
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    
    Private Sub BSalir_Click_1(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ChRep_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ChRep.MouseDown
        Try
            Dim hitResult As HitTestResult = ChRep.HitTest(e.X, e.Y)
            Dim selectedDataPoint As DataPoint = Nothing

            If hitResult.Series Is Nothing Then Return
            If hitResult.Series.Name <> "PesoPunto" Then
                hitResult = Nothing
                Return
            End If

            If hitResult.ChartElementType = ChartElementType.DataPoint Then
                selectedDataPoint = CType(hitResult.Object, DataPoint)
                If TCodProd.Text = "" Then Return

                DVarios.Open("select * from REPESO where MAQUINA=" + Empacadora.ToString + " and FECHA between '" + TFechaIniRep.Text + "' and '" + TFechaFinRep.Text + "' order by Fecha")
                If DVarios.RecordCount = 0 Then Exit Sub

                For Each Fila As DataRow In DVarios.Rows
                    CompararX = Math.Round(Eval(Minute(Fila("FECHA")) + Second(Fila("FECHA")) / 100), 2)
                    If CompararX >= selectedDataPoint.XValue - 0.3 And CompararX <= selectedDataPoint.XValue + 0.3 Then
                        DatosGraf.TCodProd.Text = Fila("CODPROD")
                        DatosGraf.TMaquina.Text = Fila("MAQUINA")
                        DatosGraf.TProm.Text = Fila("PESO")
                        DatosGraf.TNomProd.Text = Fila("NOMPROD")
                        DatosGraf.TPresKg.Text = Fila("PRESEMPKG")
                        DatosGraf.TFecha.Text = Format(Fila("FECHA"), "yyyy-MM-dd HH:mm:ss")
                        DatosGraf.DatosGraf_Load(Nothing, Nothing)
                        DatosGraf.BGrafRep_Click(Nothing, Nothing)
                        DatosGraf.Show()
                        Exit For
                    End If
                Next
            End If

            hitResult = Nothing
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class