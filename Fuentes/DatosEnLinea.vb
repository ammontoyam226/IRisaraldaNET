Public Class DatosEnLinea

    Private BGrafica As ArrayControles(Of Button)


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BGrafica1_Click(sender As System.Object, e As System.EventArgs) Handles BGrafica1.Click, BGrafica2.Click, _
        BGrafica3.Click, BGrafica4.Click, BGrafica5.Click, BGrafica6.Click
        Try
            Dim Index As Short = BGrafica.Index(CType(sender, Button))
            SCContenedor.Panel2.Controls.Clear()
            GraficasProceso1.Text = BGrafica(Index).Text
            GraficasProceso1.TopLevel = False
            GraficasProceso1.Location = New Point(0.0)
            GraficasProceso1.WindowState = FormWindowState.Normal
            GraficasProceso1.Visible = True

            GraficasProceso1.Show()
            SCContenedor.Panel2.Controls.Add(GraficasProceso1)
            GraficasProceso1.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub DatosEnLinea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            BGrafica = New ArrayControles(Of Button)("BGrafica", Me.Controls)
            'Se empieza a graficar el primer proceso
            BGrafica1_Click(BGrafica1, Nothing)
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class
