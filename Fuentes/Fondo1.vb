Imports System.Windows.Forms
Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Threading
Imports System.IO
Imports System.Data.Common
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Public Class Fondo1
    Protected currentGradientShift As Integer = 10
    Protected gradiantStep As Integer = 5
    Private Cont As Double
    Private DTmuertos As AdoNet
    Private PedirUsuario As Boolean
    Private Hora As String
    Private HoraIniTurno(3) As String
    Private DTurnos As AdoSQL
    Private DOPs As AdoNet
    Private DBaches As AdoNet
    Private DConsumos As AdoNet
    Private DEmpaque As AdoNet
    Private DFor As AdoNet
    Private DDatosFor As AdoNet
    Private DVarios As AdoNet
    Private DAlarmas As AdoNet

    Private SentenciaPeso As String

    Private Sub Inactividad()
        Try
            'Set currentForm variable to the current instance of the Form class.

            Dim ActiveControl As Control = Nothing
            'Set currentForm variable to the current instance of the Form class.
            Static PrevControlName As String
            Static PrevFormName As String
            Static ExpiredTime As Int32
            Const IDLEMINUTES = 10

            ' MsgBox(ActiveForm.Name)
            Dim ExpiredMinutes As Int32

            If Application.OpenForms.Count = 0 Then Return

            Dim ActiveForm As Form = Application.OpenForms.Item(Application.OpenForms.Count - 1)

            ActiveControl = ActiveForm.ActiveControl
            If Not ActiveForm Is Nothing AndAlso ActiveControl Is Nothing Then
                ExpiredTime = ExpiredTime + 10
            ElseIf (PrevControlName = "") Or (PrevFormName = "") Or (ActiveForm.Name <> PrevFormName) _
            Or (ActiveControl.Name <> PrevControlName) Then
                PrevControlName = ActiveControl.Name
                PrevFormName = ActiveForm.Name
                ExpiredTime = 0
            Else
                ' ...otherwise the user was idle during the time interval, so
                ' increment the total expired time.
                ExpiredTime = ExpiredTime + 10
            End If

            'Does the total expired time exceed the IDLEMINUTES?
            ExpiredMinutes = ExpiredTime / 60
            If ExpiredMinutes >= IDLEMINUTES Then
                ' ...if so, then reset the expired time to zero...
                ExpiredTime = 0

                For Each AF As Form In Application.OpenForms
                    If UCase(AF.Name) = "FONDO1" Or (InStr(AF.Name, "Form")) Then Continue For
                    AF.Close()
                Next

                If Acceso.Visible = False Then Acceso.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Fondo1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Fondo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Acceso.ShowDialog()
        
        DTurnos = New AdoSQL("DVARIOS")
        DAlarmas = New AdoNet("ALARMAS", CONN, DbProvedor)

        TimSeg.Enabled = True

        'DTurnos.Open("Select * from TURNOS where PLANTA='" + Planta + "'")

        ''Hacemos un recorrido por 3 turnos, deben haber 3 en la base de datos
        'For i = 1 To 3
        '    DTurnos.Refresh()
        '    DTurnos.Find("TURNO=" + i.ToString)
        '    If Not DTurnos.EOF Then HoraIniTurno(i) = DTurnos.RecordSet("HORAINI")
        'Next
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Evento("Sale de ChronoSoft")
        Me.Close()
        Me.Dispose()
        End
    End Sub

    'Private Sub BUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUsuarios.Click
    '    Try
    '        If DRUsuario("UsuaMod") Then
    '        Else
    '            MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
    '            Exit Sub
    '        End If
    '        Usuarios.ShowDialog()
    '    Catch ex As Exception
    '        MsgError(ex.ToString)
    '    End Try
    'End Sub

    'Private Sub mnBaseDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBaseDatos.Click
    '    Try
    '        If DRUsuario("Config") Then
    '        Else
    '            MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
    '            Exit Sub
    '        End If

    '        RespInput = ""
    '        If InputBox.InputBox("Acceso", "Dígite la clave de acceso", RespInput, False) <> DialogResult.OK Then Return
    '        If ValidaClave(RespInput) = False Then
    '            MsgBox("Clave de acceso no válida", MsgBoxStyle.Information)
    '            Return
    '        End If


    '        BasedeDatos.ShowDialog()
    '    Catch ex As Exception
    '        MsgError(ex.ToString)
    '    End Try
    'End Sub

   

    Private Sub TimSeg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimSeg.Tick
        Try
            Cont = Cont + 1
            If Cont > 100000 Then Cont = 1
            If Cont Mod 10 = 0 Then

                If ReadConfigVar("InactividadChr") = "SI" Then
                    If ServComM = False Then Inactividad()
                End If

                If File.Exists(Ruta + "a") = True Then
                    Evento(" Se cierra ChronoSoft por archivo a")
                    BSalir_Click(Nothing, Nothing)
                End If

            End If
            Application.DoEvents()

            If ServComM Then
                If Cont Mod 3600 = 0 Then
                    'mnBackupDB_Click(Nothing, Nothing)
                End If

                If VerAlarmas Then
                    If Cont = 1 Then
                        SCEscritorio.SplitterDistance = 604
                    End If
                    If Cont Mod 30 = 0 Or Cont = 1 Then
                        FRefrescaDG_Click(Nothing, Nothing)
                    End If
                End If
            End If
        Catch Ex As FileNotFoundException
            Evento("Programa" + Ex.FileName + " no encontrado")
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    'Private Sub mnCambioUsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCambioUsua.Click
    '    Acceso.ShowDialog()
    'End Sub

    Private Sub BMaquinas_Click(sender As System.Object, e As System.EventArgs) Handles BMaquinas.Click
        Try
            'If DRUsuario("VerMaq") Then
            'Else
            '    MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            'Ensaque.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub BAlarma_Click(sender As System.Object, e As System.EventArgs) Handles BAlarma.Click
        VerAlarmas = True
        SCEscritorio.Panel1Collapsed = False
        SCEscritorio.SplitterDistance = 604
        FRefrescaDG_Click(Nothing, Nothing)
    End Sub


    Private Sub BReportes_Click(sender As System.Object, e As System.EventArgs) Handles BReportes.Click
        Try
            If DRUsuario("VerRep") Then
            Else
                MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
                Exit Sub
            End If
            Reportes.Show()
            'Prueba.Show()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
        
    End Sub

    Public Sub BServidor_Click(sender As System.Object, e As System.EventArgs) Handles BServidor.Click
        If ServComM Then
        Else
            MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
            Exit Sub
        End If
        Servidor.Show()
    End Sub

    Private Sub BUsuarios_Click(sender As System.Object, e As System.EventArgs) Handles BUsuarios.Click
        Try
            If DRUsuario("VerUsua") Then
            Else
                MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
                Exit Sub
            End If
            Usuarios.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BDatosEnLinea_Click(sender As System.Object, e As System.EventArgs) Handles BDatosEnLinea.Click
        GraficosEmp.ShowDialog()
    End Sub

    Public Sub FRefrescaDG_Click(sender As System.Object, e As System.EventArgs) Handles FRefrescaDG.Click
        Try

            DAlarmas.Open("delete from ALARMAS where FECHA<'" + Format(DateAdd("d", -2, Now), "yyyy/MM/dd HH:mm:ss") + "'")
            DAlarmas.Open("select * from ALARMAS WHERE REC=0 order by ID desc")
            DGAlarmas.AutoGenerateColumns = False
            DGAlarmas.DataSource = DAlarmas.DataTable

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub DGAlarmas_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGAlarmas.CellContentDoubleClick
        Try
            If DGAlarmas.CurrentCell Is Nothing Then Return
            Dim ID As Long = DGAlarmas.Rows(e.RowIndex).DataBoundItem("ID")

            If ID = 0 Then Return

            DAlarmas.Open("Update ALARMAS set REC=1 where ID=" + ID.ToString)
            DAlarmas.Open("select * from ALARMAS WHERE REC=0 order by ID desc")
            DGAlarmas.AutoGenerateColumns = False
            DGAlarmas.DataSource = DAlarmas.DataTable
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BCerrarPanelAlarm_Click(sender As System.Object, e As System.EventArgs)
        SCEscritorio.Panel1Collapsed = True
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles LAlarma.Click
        SCEscritorio.Panel1Collapsed = True
    End Sub

    Private Sub BBaseDatos_Click(sender As System.Object, e As System.EventArgs) Handles BBaseDatos.Click
        Try
            RespInput = ""
            If InputBox.InputBox("Acceso", "Dígite la clave de acceso", RespInput, False) <> DialogResult.OK Then Return
            If ValidaClave(RespInput) = False Then
                MsgBox("Clave de acceso no válida", MsgBoxStyle.Information)
                Return
            End If
            BasedeDatos.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BCambioUsuario_Click(sender As System.Object, e As System.EventArgs) Handles BCambioUsuario.Click
        Try
            Acceso.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

  
    Private Sub BProductos_Click(sender As System.Object, e As System.EventArgs) Handles BProductos.Click
        Try
            If DRUsuario("VerProd") Then
            Else
                MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
                Exit Sub
            End If
            Productos.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub DGAlarmas_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DGAlarmas.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                Dim Selfila As DataGridViewSelectedRowCollection
                Dim ID As Long
                Selfila = DGAlarmas.SelectedRows
                If DGAlarmas.SelectedRows.Count <= 0 Then Exit Sub

                For Each vfila As DataGridViewRow In Selfila
                    ID = DGAlarmas.Rows(vfila.Index).DataBoundItem("ID")
                    DAlarmas.Open("Update ALARMAS set REC=1 where ID=" + ID.ToString)
                    DGAlarmas.Rows.Remove(vfila)
                Next
            End If

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BConfiguraciones_Click(sender As System.Object, e As System.EventArgs) Handles BConfiguraciones.Click
        Try
            Configuraciones.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BEmpaque_Click(sender As System.Object, e As System.EventArgs) Handles BEmpaque.Click
        Try
            Empaque.ShowDialog()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class
