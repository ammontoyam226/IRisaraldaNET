Imports Microsoft.Reporting.WinForms


Public Class Reportes
    Private FechaIni As String
    Private FechaFin As String

    Private DConsultas As AdoSQL
    Private DSentenciaSQl As AdoSQL
    Private DReportesDesc As AdoSQL
    Private DTurnos As AdoSQL


    Private rds As ReportDataSource
    Private Sub Reportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            DConsultas = New AdoSQL("Consultas")
            DSentenciaSQl = New AdoSQL("SENTENCIA")
            DReportesDesc = New AdoSQL("REPORTESDESC")
            DTurnos = New AdoSQL("TURNOS")

            TFechaIni.Value = Now
            TFechaFin.Value = DateAdd(DateInterval.Day, 1, Now)
            THoraIni.Value = CDate(Format(Now, "yyyy/MM/dd 00:00"))
            THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd 00:00"))

            DReportesDesc.Open("Select * from REPORTESDESC order BY POSICION")

            For Each Fila As DataRow In DReportesDesc.Rows
                TVReportes.Nodes.Add(Fila("REPDESC"))
            Next

            rds = New ReportDataSource
            rds.Name = "DataSet1"

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub BGenerar_Click(sender As System.Object, e As System.EventArgs)
        Try
            BCDate_Click(Nothing, Nothing)
            DSentenciaSQl.Open("Select * from CDATOS")
            rds.Value = DSentenciaSQl.DataSet.Tables(0)
            RvReportes.LocalReport.DataSources.Clear()
            RvReportes.LocalReport.DataSources.Add(rds)

            RvReportes.LocalReport.ReportPath = RutaRep + "ReporteDatos.rdlc"
            Me.RvReportes.RefreshReport()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub



    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

   
    Private Sub BCDate_Click(sender As System.Object, e As System.EventArgs) Handles BCDate.Click
        Try
            FechaIni = Format(TFechaIni.Value, "yyyy/MM/dd ") + Format(THoraIni.Value, "HH:mm")
            FechaFin = Format(TFechaFin.Value, "yyyy/MM/dd ") + Format(THoraFin.Value, "HH:mm")

            If CDate(FechaFin) <= CDate(FechaIni) Then
                MsgBox("La Fecha Inicial no puede ser Superior o Igual a la Fecha Final", MsgBoxStyle.Exclamation, "Error en Fechas")
                Exit Sub
            End If

            DConsultas.Open("Select * from CONSULTAS")

            DConsultas.RecordSet("F1") = FechaIni
            DConsultas.RecordSet("F2") = FechaFin
            DConsultas.Update()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    
    Private Sub TVReportes_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TVReportes.AfterSelect
        Try
            BCDate_Click(Nothing, Nothing)
            
            Select Case e.Node.Text

                Case "Listado General"

                    DSentenciaSQl.Open("Select * from CDATOS")
                    rds.Value = DSentenciaSQl.DataSet.Tables(0)
                    RvReportes.LocalReport.DataSources.Clear()
                    RvReportes.LocalReport.DataSources.Add(rds)

                    RvReportes.LocalReport.ReportPath = RutaRep + "rpDatos.rdlc"
                    Me.RvReportes.RefreshReport()

                Case "Resumen x Producto"

                    DSentenciaSQl.Open("Select * from CMUESTXPROD")
                    rds.Value = DSentenciaSQl.DataSet.Tables(0)
                    RvReportes.LocalReport.DataSources.Clear()
                    RvReportes.LocalReport.DataSources.Add(rds)
                    RvReportes.LocalReport.ReportPath = RutaRep + "rpMuestxProd.rdlc"
                    RvReportes.RefreshReport()

                Case "Resumen x Línea"

                    DSentenciaSQl.Open("Select * from CMUESTXLINEA")
                    rds.Value = DSentenciaSQl.DataSet.Tables(0)
                    RvReportes.LocalReport.DataSources.Clear()
                    RvReportes.LocalReport.DataSources.Add(rds)
                    RvReportes.LocalReport.ReportPath = RutaRep + "rpMuestxLinea.rdlc"
                    RvReportes.RefreshReport()

            End Select
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub OPTurno1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPTurno1.Click
        Try
            TFechaIni.Value = Now
            TFechaFin.Value = Now

            DTurnos.Open("Select * from TURNOS where TURNO=1")

            If DTurnos.RecordCount > 0 Then
                TFechaIni.Value = DateAdd(DateInterval.Day, -1, Now)
                THoraIni.Value = CDate(Format(DateAdd(DateInterval.Day, -1, Now), "yyyy/MM/dd " + DTurnos.RecordSet("HORAINI").ToString))
                THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd " + DTurnos.RecordSet("HORAFIN").ToString))
            Else
                THoraIni.Value = CDate(Format(DateAdd(DateInterval.Day, -1, Now), "yyyy/MM/dd 22:00"))
                THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd 06:00"))
            End If


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub OPTurno2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPTurno2.Click
        Try
            TFechaIni.Value = Now
            TFechaFin.Value = Now

            DTurnos.Open("Select * from TURNOS where TURNO=2")

            If DTurnos.RecordCount > 0 Then
                THoraIni.Value = CDate(Format(Now, "yyyy/MM/dd " + DTurnos.RecordSet("HORAINI").ToString))
                THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd " + DTurnos.RecordSet("HORAFIN").ToString))
            Else
                THoraIni.Value = CDate(Format(Now, "yyyy/MM/dd 06:00"))
                THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd 14:00"))
            End If


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub OPTurno3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPTurno3.Click
        Try
            TFechaIni.Value = Now
            TFechaFin.Value = Now

            DTurnos.Open("Select * from TURNOS where TURNO=3")

            If DTurnos.RecordCount > 0 Then
                THoraIni.Value = CDate(Format(Now, "yyyy/MM/dd " + DTurnos.RecordSet("HORAINI").ToString))
                THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd " + DTurnos.RecordSet("HORAFIN").ToString))
            Else
                THoraIni.Value = CDate(Format(Now, "yyyy/MM/dd 14:00"))
                THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd 22:00"))
            End If


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub OP24Horas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OP24Horas.Click
        Try
            TFechaIni.Value = Now
            TFechaFin.Value = DateAdd(DateInterval.Day, 1, Now)
            THoraIni.Value = CDate(Format(Now, "yyyy/MM/dd 00:00"))
            THoraFin.Value = CDate(Format(Now, "yyyy/MM/dd 00:00"))
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    
End Class