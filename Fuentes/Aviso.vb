Public Class Aviso

    Private Sub Aviso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TimIni_Tick(sender As System.Object, e As System.EventArgs) Handles TimIni.Tick
        Try
            TimIni.Enabled = False
            TimUnload.Interval = TIntervalo.Text
            TimUnload.Enabled = True
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BAceptar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TimUnload_Tick(sender As System.Object, e As System.EventArgs) Handles TimUnload.Tick
        Me.Close()
        Me.Dispose()
    End Sub
End Class