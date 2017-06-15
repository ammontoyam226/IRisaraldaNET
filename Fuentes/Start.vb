Imports System.IO

Public Class Start

    Private Sub TimStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimStart.Tick
        TimStart.Enabled = False
        Me.Dispose()
        Me.Close()
        Fondo1.Show()
    End Sub

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TimStart.Enabled = True
    End Sub

End Class