
Imports System.String
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.Common
Imports System.Data
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class Acceso

    Private IndAces As Integer = 0
    Private ACuUser As String = ""
    Private ACuPass As String = ""

    Private DUsuarios As AdoNet
    Private DConfig As AdoSQL

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
        End
    End Sub


    Public Sub Acceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Verifica si el usuario ya esta corriendo chronosoft

            If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
                'MessageBox.Show("La aplicación ya se esta ejecutando", "ChronoSoft", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            End If

            Ruta = Application.StartupPath
            If Ruta.Last.ToString <> "\" Then Ruta = Ruta + "\"

            If InStr(Ruta, "NET") > 0 Then
                'Ruta = Ruta.Substring(0, InStr(Ruta, "Fuentes") - 1)
                Fuentes = True
            End If

            If File.Exists(Ruta + "Ruta.txt") = False Then
                MsgBox("No existe el archivo ruta el cual contiene el nombre del Motor de Base de Datos", MsgBoxStyle.Information)
                End
            Else
                Dim rd As StreamReader = New StreamReader(Ruta + "Ruta.txt", True)
                ServidorSQL = rd.ReadLine.Trim
                'NomDB = rd.ReadLine.Trim
                rd.Close()
            End If

            NomDB = "ChrIngRis"
            UserDB = "Admin"
            PWD = "NEP"

            If File.Exists(Ruta + "a") = True Then
                Evento(" Se cierra ChronoSoft por archivo a " + Me.Name)
                End
            End If

            RutaRep = Ruta + "DB\"


            DbProvedor = DbProviderFactories.GetFactory("System.Data.SqlClient")
            RutaDB = "Data Source=" + ServidorSQL + "; Initial Catalog=" + NomDB + "; User Id=" + UserDB + "; Password=" + PWD

            'Toma los parametros del Provedor segun el caso
            CONN = DbProvedor.CreateConnection
            CONN.ConnectionString = RutaDB

            DUsuarios = New AdoNet("Usuarios", CONN, DbProvedor)
            DUsuarios.Open("select * from USUARIOS order by USUARIO")

            NombrePC = My.Computer.Name.ToUpper

            Sesion = Environment.UserName.ToUpper

            If ReadConfigVar("SERVCOMM").ToUpper = NombrePC Then ServComM = True
            If ReadConfigVar("SERVCHR").ToUpper = NombrePC Then ServCHR = True

            DConfig = New AdoSQL("CONFIG")

            If Fuentes Then
                TUsuario.Text = "A"
                TClave.Text = "A"
                BOk_Click(Nothing, Nothing)
            End If


            Planta = ReadConfigVar("PLANTA")

            Fondo1.TPlanta.Text = Planta



            'Se creo este usuario para que se pueda abrir automaticamente en el servidor 
            If ServCHR Or ServComM Then
                TUsuario.Text = "A"
                TClave.Text = "A"
                BOk_Click(Nothing, Nothing)
            End If



        Catch ex As Exception
            MsgError(ex.ToString)
        End Try


    End Sub


    Private Sub TUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TUsuario.TextChanged
        TUsuario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClave.TextChanged
        TClave.CharacterCasing = CharacterCasing.Upper
    End Sub


    Private Sub TClave_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TClave.KeyUp
        If e.KeyCode = Keys.Enter Then BOk_Click(Nothing, Nothing)
    End Sub

  
    Private Sub TUsuario_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TUsuario.KeyUp
        If e.KeyCode = Keys.Enter Then TClave.Focus()

    End Sub

    Private Sub BOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOk.Click
        Dim ClaveReal As String
        If TClave.Text = "" Or TUsuario.Text = "" Then Exit Sub
        Try
            IndAces += 1

            DUsuarios.Find("USUARIO='" + TUsuario.Text.Trim + "'")

            ' DRUsu = DTUsuarios.Select("USUARIO='" + TUsuario.Text.Trim + "'")

            If DUsuarios.EOF = True Then
                MsgBox("Usuario no registrado en ChronoSoft", MsgBoxStyle.Information)
                If IndAces = 3 Then
                    End
                End If
                TUsuario.Focus()
                Exit Sub
            End If
            ClaveReal = ""
            For K = 1 To Len(DUsuarios.RecordSet("Clave").ToString)
                ClaveReal = ClaveReal + Chr(Asc(Mid(DUsuarios.RecordSet("Clave").ToString, K, 1)) - (K * 2) - 5)
            Next

            If TClave.Text.Trim <> ClaveReal Then
                MsgBox("Contraseña Incorrecta", MsgBoxStyle.Information)
                If IndAces = 3 Then
                    End
                End If
                TClave.Focus()
                Exit Sub
            End If

            If Convert.ToBoolean(DUsuarios.RecordSet("Activo")) = False Then
                MsgBox(" El Usuario " + TUsuario.Text.Trim + " Se encuentra desactivado Comuníquese con el Administrador de Sistemas ", MsgBoxStyle.Information)
                TUsuario.Text = ""
                TClave.Text = ""
                TUsuario.Focus()
                Exit Sub

            End If

            NombrePC = My.Computer.Name
            Usuario = TUsuario.Text
            DRUsuario = DUsuarios.RecordSet

            Fondo1.Text = Ruta + "ChronoSoft Net, ServSQL: " + ServidorSQL + " Sesión: " + Sesion + " UsuarioChr: " + Usuario

            Evento("Entra a ChronoSoft")

            DConfig.Open("Select * from CONFIG")

            For i = 1 To 4
                If NombrePC = DConfig.RecordSet("ENSACADORA" + i.ToString) Then
                    Empacadora = i
                    'Abrir el formulario empaque y la grafica correspondiente
                    Exit For
                End If
            Next

            If ServComM = True Then
                VerAlarmas = True
                Fondo1.SCEscritorio.Panel1Collapsed = False
                Fondo1.SCEscritorio.SplitterDistance = 604
                'Fondo1.BServidor_Click(Nothing, Nothing)
            Else
                Fondo1.SCEscritorio.Panel1Collapsed = True
            End If

            Me.Close()
            Me.Dispose()


        Catch ex As Exception
            MsgBox(ex.ToString())
            Evento(ex.ToString)
        End Try

    End Sub

End Class



