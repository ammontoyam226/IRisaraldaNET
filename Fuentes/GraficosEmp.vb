Public Class GraficosEmp

    Private DEmpaque As AdoSQL
    Private FormLoad As Boolean
    Private Graficas As Grafica
    Private GrafOk As Boolean
    
    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub GraficosEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            If FormLoad Then Return

            DEmpaque = New AdoSQL("EMPAQUE")
            
            'For i = 0 To TLPEmpaque.RowCount - 1
            '    TLPEmpaque.RowStyles.Item(i).SizeType = SizeType.Percent
            '    TLPEmpaque.RowStyles.Item(i).Height = 50
            'Next
            'TLPEmpaque.Refresh()
            'TLPEmpaque.Visible = True

            FormLoad = True

            Graficas = New Grafica

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BGraficaScalaEnscB1_Click(sender As System.Object, e As System.EventArgs)
        Try
            ''GrafEnscB1.

            'Dim pen As New System.Drawing.Pen(Brushes.Blue)
            'Dim sizef As New System.Drawing.SizeF(GrafEnscB1.Width, -180)
            'pen.Color = Color.Green
            'pen.Width = 3

            ''GrafEnscB1.Scale(sizef)
            'GrafEnscB1.CreateGraphics.DrawLine(pen, -1, 90, Me.Width, 90)
            'pen.Color = Color.Blue
            'Dim x(2) As Single
            'Dim y(2) As Single


            'x(0) = -1
            'x(1) = Me.Width
            'y(0) = 45
            'y(1) = 45
            'GrafEnscB1.CreateGraphics.DrawLine(pen, x(0), y(0), x(1), y(1))
            'y(0) = 135
            'y(1) = 135
            'GrafEnscB1.CreateGraphics.DrawLine(pen, x(0), y(0), x(1), y(1))
            ''GrafEnscB1.l (-1, 0)-(ScaleWidth, 0), vbGreen
            ''GrafEnsc2B1.Line (-1, Eval(0.125))-(ScaleWidth, Eval(0.125)), vbBlue
            ''GrafEnsc2B1.Line (-1, Eval(-0.125))-(ScaleWidth, Eval(-0.125)), vbBlue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TimActualiza_Tick(sender As System.Object, e As System.EventArgs) Handles TimActualiza.Tick
        Try
            If mnActAuto.Checked = False Then
                Return
            End If


            DEmpaque.Open("select top 10 * from EMPAQUE" + Empacadora.ToString + " where MAQUINA=" + Empacadora.ToString + " order by FECHA desc")
            If DEmpaque.RecordCount = 0 Then Return

            TFechaIni.Text = Format(DEmpaque.RecordSet("Fecha"), "yyyy-MM-dd HH:00:00")
            TFechaFin.Text = Format(DateAdd(DateInterval.Hour, 1, DEmpaque.RecordSet("Fecha")), "yyyy-MM-dd HH:00:00")

            Graficas.Fecha = CDate(TFechaIni.Text)
            Graficas.Intervalo = 1
            Graficas.Basc = 1
            Graficas.Maq = Empacadora
            Graficas.FGraficar(ChEmp, GrafOk, "Emp")
            ChEmp.Titles(0).Text = "CARTA DE CONTROL PESO NETO ENSACADORA 1"
            ChEmp.Titles(0).ForeColor = Color.Red


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub mnSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class