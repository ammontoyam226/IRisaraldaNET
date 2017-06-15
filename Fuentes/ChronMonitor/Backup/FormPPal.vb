Imports System.Threading
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class FormPPal
    Private Ruta As String
    Private HTimSeg As New Thread(AddressOf TimSeg)

    Private Sub FormPPal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

 
        Static PrimeraVez As Boolean = True
        Try
            If PrimeraVez Then

                If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
                    MessageBox.Show("La aplicación ya se esta ejecutando", "Chron Monitor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                End If

                CheckForIllegalCrossThreadCalls = False
                Ruta = Application.StartupPath

                If InStr(1, Ruta, "Fuentes") Then Ruta = Ruta.Substring(0, InStr(1, Ruta, "Fuentes") - 1)
                If Ruta.Last.ToString <> "\" Then Ruta = Ruta + "\"

                If HTimSeg.IsAlive = False Then HTimSeg.Start()

                PrimeraVez = False

                Me.WindowState = FormWindowState.Minimized
                Me.Hide()
                Notificador.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub FormPPal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            Dim Resp As Long

            Resp = MessageBox.Show("Si cierra esta aplicación se dejará de monitorear si ChronoSoft esta Abierto," + vbNewLine + " Esta seguro de cerrarla?", "Cerrar Chronos Monitor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Resp = vbNo Then
                e.Cancel = True
                Exit Sub
            End If


            Me.Notificador.Visible = False
            Me.Notificador = Nothing
            Me.ContextMenuStrip1 = Nothing
            End
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    

    Private Sub TimSeg()

        Try
            While (True)
                TSeg.Text = (Val(TSeg.Text) + 1).ToString

                If Val(TSeg.Text) > 10000 Then TSeg.Text = 0

                If Val(TSeg.Text) Mod Val(TFrecuencia.Text) = 0 Then
                    Process.Start(Ruta + "ChronoSoft Net.exe")
                End If

                THora.Text = Format(Now, "HH:mm:ss")
                Thread.Sleep(1000)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub


    Private Sub Notificador_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Notificador.MouseDoubleClick
        Show()
        WindowState = FormWindowState.Normal
        Activate()
    End Sub

    Private Sub FormPPal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
            End If
            Activate()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub mnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAbrir.Click
        Show()
        WindowState = FormWindowState.Normal
        Activate()
    End Sub

    Private Sub mnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCerrar.Click
        Dim Resp As Long

        Resp = MessageBox.Show("Si cierra esta aplicación se dejará de monitorear si ChronoSoft esta Abierto," + vbNewLine + " Esta seguro de cerrarla?", "Cerrar Chronos Monitor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Resp = vbNo Then Exit Sub

        Me.Dispose()
        Me.Close()
    End Sub


    
  
End Class
