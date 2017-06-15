Imports System.Windows.Forms
Imports System.Data.Common
Imports System.Data
Imports System.IO


Public Class Usuarios
    Private DUsuarios As AdoNet
    Private DVarios As AdoNet
    Private Col As ArrayControles(Of CheckBox)
    Private DCargos As AdoNet
    Private DUsuariosDesc As AdoSQL

    Private NuevoUsu As Boolean, ModificaUsu As Boolean

    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DUsuarios = New AdoNet("Usuarios", CONN, DbProvedor)
            DUsuarios.Open("Select * from USUARIOS ")

            DUsuariosDesc = New AdoSQL("UsuariosDesc")
            DUsuariosDesc.Open("Select * from USUARIOSDESC order BY posicion ")

            'Se realiza un ciclo para agregar todos los permisos de la tabla al treview

            For Each fila As DataRow In DUsuariosDesc.Rows
                TVUsuarios.CheckBoxes = True
                TVUsuarios.Nodes.Add(fila("DESCRIPCION"))
            Next


            DVarios = New AdoNet("Varios", CONN, DbProvedor)

            DCargos = New AdoNet("CARGOS", CONN, DbProvedor)
            DCargos.Open("Select * from CARGOS order by CODCARGO")

            LLenaComboBox(TCargo, DCargos.DataTable, "CARGO")

            LLenaComboBox(OpComBoxUsua, DUsuarios.DataTable, "USUARIO")


            'Col = New ArrayControles(Of CheckBox)("Col", Me)

            DUsuarios.Find("USUARIO='" + OpComBoxUsua.Text + "'")
            If DUsuarios.EOF Then Exit Sub

            OpComBoxUsua_SelectedIndexChanged(Nothing, Nothing)

            'For i As Integer = 4 To DUsuarios.DataTable.Columns.Count - 1
            '    TVUsuarios.Nodes(i - 4).Checked = DUsuarios.RecordSet.Item(i)
            'Next

            'For i As Integer = 1 To Col.Count - 1 ' Voy desde el 1 hasta el count -1
            '    AddHandler Col(i).CheckedChanged, AddressOf Col_CheckedChanged
            'Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub
    Private Sub Col_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim Chk As CheckBox = CType(sender, CheckBox)
            Dim Index As Integer = Col.Index(Chk)

            MsgBox(Index.ToString)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Dim Clave As String
        Dim ContChek As Long

        Try

            For Each CCol As TreeNode In TVUsuarios.Nodes
                If CCol.Checked = True Then
                    ContChek += 1
                    Exit For
                End If
            Next

            If ContChek = 0 AndAlso TCargo.Text <> "OERARIO" Then
                MsgBox("El Usuario debe tener al menos un Permiso para poder ser Creado", MsgBoxStyle.Information)
                Exit Sub
            End If

            If Val(TCodOperario.Text) = 0 And TCargo.Text = "OPERARIO" Then
                MsgBox("Debe asignar un código de operario para el un permiso con cargo de OPERARIO", MsgBoxStyle.Information)
                Exit Sub
            End If


            Clave = UCase(TClave.Text.Trim)
            TClave.Text = ""
            For K = 1 To Len(Clave)
                TClave.Text = TClave.Text + Chr(Asc(Mid(Clave, K, 1)) + (K * 2) + 5)
            Next K

            DUsuarios.Find("Usuario='" + OpComBoxUsua.Text + "'")

            If DUsuarios.EOF = False Then
                Resp = MessageBox.Show("El Usuario ya existe desea Sobre escribirlo", "ChronoSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If Resp = vbNo Then Exit Sub
            Else
                DUsuarios.AddNew()
            End If

            DUsuarios.RecordSet("Usuario") = UCase(TUsuario.Text)
            DUsuarios.RecordSet("Clave") = TClave.Text.Trim
            DUsuarios.RecordSet("Cargo") = CLeft(UCase(TCargo.Text.Trim), 20)
            DUsuarios.RecordSet("CodOperario") = Val(TCodOperario.Text)

            For i = 4 To DUsuarios.DataTable.Columns.Count - 1
                DUsuarios.RecordSet(i) = TVUsuarios.Nodes(i - 4).Checked
            Next

            DUsuarios.Update()

            PanelPerm.Enabled = False
            TUsuario.Text = ""
            TClave.Text = ""
            TUsuario.ReadOnly = True
            TClave.ReadOnly = True
            TCargo.Enabled = False
            PanNueUsua.Text = "Usuario"
            BCancelar_Click(Nothing, Nothing)
            'BEliminar.Enabled = True
            'BNuevo.Enabled = True
            'BModificar.Enabled = True
            BAceptar.Enabled = False
            BCancelar.Enabled = False

            MsgBox("Los cambios serán aplicados una vez reinicie ChronoSoft", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub



    Private Sub OpComBoxUsua_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpComBoxUsua.SelectedIndexChanged
        Try
            If NuevoUsu = True Or ModificaUsu = True Then Exit Sub

            DUsuarios.Find("USUARIO='" + OpComBoxUsua.Text + "'")
            If DUsuarios.EOF Then Exit Sub

            TUsuario.Text = DUsuarios.RecordSet("USUARIO")
            TCargo.Text = DUsuarios.RecordSet("CARGO")
            TCodOperario.Text = DUsuarios.RecordSet("CODOPERARIO")

            TClave.Text = ""

            For K = 1 To Len(DUsuarios.RecordSet("Clave").ToString())
                TClave.Text = TClave.Text + Chr(Asc(Mid(DUsuarios.RecordSet("Clave").ToString(), K, 1)) - (K * 2) - 5)
            Next K
            'For Each CCol As CheckBox In Col.Values
            '    CCol.Checked = DUsuarios.RecordSet.Item(i)
            'Next
            For i As Integer = 4 To DUsuarios.DataTable.Columns.Count - 1
                TVUsuarios.Nodes(i - 4).Checked = DUsuarios.RecordSet.Item(i)
            Next
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    

    Private Sub TUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TUsuario.TextChanged
        TUsuario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TClave.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub mnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnModificar.Click
        Try
            PanNueUsua.Enabled = True
            PanelPerm.Enabled = True
            TClave.ReadOnly = False
            TCodOperario.ReadOnly = False
            TCargo.Enabled = True
            DUsuarios.Find("USUARIO='" + OpComBoxUsua.Text + "'")
            If DUsuarios.EOF Then Exit Sub

            TUsuario.Text = DUsuarios.RecordSet("Usuario").ToString
            TClave.Text = ""

            For K = 1 To Len(DUsuarios.RecordSet("Clave").ToString())
                TClave.Text = TClave.Text + Chr(Asc(Mid(DUsuarios.RecordSet("Clave").ToString(), K, 1)) - (K * 2) - 5)
            Next K

            PanNueUsua.Text = "Modificar Usuario"
            ModificaUsu = True
            '  MsgBox(TUsuario.Text + TClave.Text)
        Catch ex As Exception

        End Try
        'BEliminar.Enabled = False
        'BNuevo.Enabled = False
        BAceptar.Enabled = True
        BCancelar.Enabled = True
    End Sub

    Private Sub mnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnEliminar.Click
        Try

            Resp = MsgBox("¿Seguro desea eliminar al usuario " + OpComBoxUsua.Text + " de ChronoSoft?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If Resp = vbNo Then Return

            DUsuarios.Find("USUARIO='" + OpComBoxUsua.Text + "'")

            If DUsuarios.EOF Then Exit Sub

            DVarios.Delete("Delete FROM USUARIOS where USUARIO='" + OpComBoxUsua.Text + "'")

            OpComBoxUsua.Text = ""
            BCancelar_Click(Nothing, Nothing)

            MsgBox("Proceso Finalizado", vbInformation)

            Usuarios_Load(Nothing, Nothing)
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub mnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnNuevo.Click
        Try
            PanelPerm.Enabled = True
            TUsuario.ReadOnly = False
            Limpiar_Habilitar_TextBox(Me.Controls, AccionTextBox.Limpiar)
            TClave.ReadOnly = False
            TCodOperario.ReadOnly = False
            TCargo.Enabled = True

            OpComBoxUsua.Items.Add("")
            OpComBoxUsua.Text = ""
            OpComBoxUsua.Items.Remove("")

            For Each CCol As TreeNode In TVUsuarios.Nodes
                CCol.Checked = False
                CCol.BackColor = Color.White
                CCol.ForeColor = Color.Black
            Next

            OpComBoxUsua.Enabled = False
            OpComBoxUsua.Text = ""
            PanNueUsua.Text = "Nuevo Usuario"
            NuevoUsu = True
            mnModificar.Enabled = False
            BAceptar.Enabled = True
            BCancelar.Enabled = True

            MsgBox("Si el usuario es OPERARIO debe asignar un código de operario", vbInformation)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click, mnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaD.ShowDialog()
    End Sub

    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click
        Dim RepSap As CrystalRep
        Dim Datos As String = ""
        Dim Datos1 As String = ""
        Dim NumPermisos As String = ""
        Dim PermisosUsua As String = ""
        Dim Caracter As String = Chr(35)
        Dim Separador As String = " "
        Dim AuxPermisos As String = ""
        Try

            RepSap = New CrystalRep

            For i As Integer = 3 To DUsuarios.DataTable.Columns.Count - 1
                If i - 3 > 0 AndAlso (i - 3) Mod 10 = 0 Then
                    Caracter = Chr(Asc(Caracter) + 1)
                End If
                Datos += ((i - 2).ToString + "-" + Col(i).Text).PadRight(35, " ") + Caracter
                NumPermisos += (i - 2).ToString + Separador
            Next

            For Each RUsua As DataRow In DUsuarios.Rows
                Datos1 += RUsua("USUARIO").ToString.Trim.PadRight(30, " ") + "#"
                AuxPermisos = ""
                Separador = " "
                For i As Int32 = 3 To RUsua.ItemArray.Count - 1
                    If i > 9 And i <= 10 Then
                        Separador = "  "
                    ElseIf i > 10 And i < 20 Then
                        Separador = "   "
                    ElseIf i > 21 And i < 30 Then
                        Separador = "   "
                    End If
                    If RUsua(i) = True Then
                        AuxPermisos += "1" + Separador
                    Else
                        AuxPermisos += "0" + Separador
                    End If
                Next
                PermisosUsua += AuxPermisos.PadRight(160, " ")
            Next


            With RepSap
                .ServerName = ServidorSQL
                'If TipoServer <> "SQLSERVER" Then .ServerName = NomDB
                .DataBaseName = NomDB
                .UserId = UserDB
                .Password = PWD
                .Formulas(0) = "PLANTA='" + Planta + "'"
                .Formulas(1) = "DATOS='" + Datos + "'"
                .Formulas(2) = "DATOS1='" + Datos1 + "'"
                .Formulas(3) = "NUMPERMISOS='" + NumPermisos + "'"
                .Formulas(4) = "PERMISOSUSUA='" + PermisosUsua + "'"
                '.Formulas(1) = "HORA='" + Format(Now, "HH:mm") + "'"
                .Destination = CrystalRep.Destinacion.crToWindows
                .WindowState = FormWindowState.Maximized
                .ChoosePrint = True
                .MaximizeBox = True
                .MinimizeBox = True
                .ReportFileName = RutaRep + "rpUsuarios.rpt"
                .PrintReport()
            End With


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click
        Try

            TUsuario.Text = ""
            TCodOperario.Text = ""
            TClave.Text = ""
            TCargo.Items.Add("")
            TCargo.Text = ""
            TCargo.Items.Remove("")
            OpComBoxUsua.Text = ""
            OpComBoxUsua.Enabled = True
            TUsuario.ReadOnly = True
            TClave.ReadOnly = True
            TCodOperario.ReadOnly = True
            TCargo.Enabled = False
            PanelPerm.Enabled = False

            For Each CCol As TreeNode In TVUsuarios.Nodes
                CCol.Checked = False
                CCol.BackColor = Color.White
                CCol.ForeColor = Color.Black
            Next

            PanNueUsua.Text = "Usuario"
            NuevoUsu = False
            ModificaUsu = False

            mnModificar.Enabled = True
            'BNuevo.Enabled = True
            BAceptar.Enabled = False
            BCancelar.Enabled = False

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

    Private Sub TVUsuarios_AfterCheck(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TVUsuarios.AfterCheck
        If TVUsuarios.Nodes(e.Node.Index).Checked Then
            TVUsuarios.Nodes(e.Node.Index).BackColor = Color.Green
            TVUsuarios.Nodes(e.Node.Index).ForeColor = Color.White
        Else
            TVUsuarios.Nodes(e.Node.Index).BackColor = Color.White
            TVUsuarios.Nodes(e.Node.Index).ForeColor = Color.Black
        End If
    End Sub
End Class