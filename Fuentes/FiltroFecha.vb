Public Class FiltroFecha

    Private Sub BAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BAceptar.Click
        Try

            If ProcesoFiltrar = "Ensaque" Then
                GraficosEmp.TFechaIni.Text = Format(TFechaIni.Value, "yyyy-MM-dd") + " " + Format(THoraIni.Value, "HH:mm")
                GraficosEmp.TFechaFin.Text = Format(DateAdd(DateInterval.Hour, 1, CDate(TFechaIni.Text)), "yyyy-MM-dd HH:00:00")
                GraficosEmp.Graficas.Fecha = CDate(TFechaIni.Text)
                GraficosEmp.Graficas.Intervalo = 1
                GraficosEmp.Graficas.Basc = 1
                GraficosEmp.Graficas.Maq = Empacadora
                GraficosEmp.Graficas.FGraficar(GraficosEmp.ChEmpB1)
                GraficosEmp.TCodProd.Text = GraficosEmp.Graficas.CodProd
                If Empacadora = 2 Or Empacadora = 4 Then
                    GraficosEmp.Graficas.Fecha = CDate(TFechaIni.Text)
                    GraficosEmp.Graficas.Intervalo = 1
                    GraficosEmp.Graficas.Basc = 2
                    GraficosEmp.Graficas.Maq = Empacadora
                    GraficosEmp.Graficas.FGraficar(GraficosEmp.ChEmpB2)
                End If
            End If

            If ProcesoFiltrar = "comprobación" Then
                GraficosEmp.TFechaIniRep.Text = Format(TFechaIni.Value, "yyyy-MM-dd") + " " + Format(THoraIni.Value, "HH:mm")
                GraficosEmp.TFechaFinRep.Text = Format(DateAdd(DateInterval.Hour, 1, CDate(TFechaIni.Text)), "yyyy-MM-dd HH:00:00")
                GraficosEmp.GraficasRep.Fecha = CDate(TFechaIni.Text)
                GraficosEmp.GraficasRep.Intervalo = 1
                GraficosEmp.GraficasRep.Basc = 1
                GraficosEmp.GraficasRep.Maq = Empacadora
                GraficosEmp.GraficasRep.FGraficar(GraficosEmp.ChEmpB1)
                GraficosEmp.TCodProdRep.Text = GraficosEmp.GraficasRep.CodProd
            End If

            BCancelar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub FiltroFecha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            LMensaje.Text = "En la gráfica de " + ProcesoFiltrar + " solo se mostrará los datos en un rango de una hora"
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class