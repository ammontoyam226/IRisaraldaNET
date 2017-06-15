Public Class Maquinas
    Private DMaq As AdoSQL
    Private DVarios As AdoSQL
    Private Campos() As String
    Private Sub Maquinas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            DMaq = New AdoSQL("Maquinas")
            DVarios = New AdoSQL("Varios")
            BCancelar_Click(Nothing, Nothing)
            FRefrescaDG_Click(Nothing, Nothing)

            Campos = {"Maquina@Máquina", "Descripcion@Descripcion"}
            Campos = AsignaItemsCB(Campos, CBBuscar.ComboBox, DMaq.DataTable)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub FRefrescaDG_Click(sender As System.Object, e As System.EventArgs) Handles FRefrescaDG.Click
        Try
            DMaq.Open("Select * from MAQUINAS order by maquina")
            DGMaq.AutoGenerateColumns = False
            DGMaq.DataSource = DMaq.DataTable

            If DGMaq.RowCount > 0 Then DGMaq_CellClick(Nothing, Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub DGMaq_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGMaq.CellClick
        Try
            If DGMaq.RowCount = 0 Then Return
            If DGMaq.CurrentCell Is Nothing Then Return

            TCodMaq.Text = DGMaq.Rows(DGMaq.CurrentRow.Index).DataBoundItem("MAQUINA")

            If TCodMaq.Text = "" Then Return

            DVarios.Open("Select * from MAQUINAS where MAQUINA='" + TCodMaq.Text + "'")

            If DVarios.RecordCount = 0 Then Return

            TNombre.Text = DVarios.RecordSet("DESCRIPCION")

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click
        Try
            Limpiar_Habilitar_TextBox(Me.Controls, AccionTextBox.Limpiar)
            Limpiar_Habilitar_TextBox(SCMaquinas.Panel1.Controls, AccionTextBox.Deshabilitar)
            SCMaquinas.Panel2.Enabled = True

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BEditar_Click(sender As System.Object, e As System.EventArgs) Handles BEditar.Click
        Try
            Limpiar_Habilitar_TextBox(SCMaquinas.Panel1.Controls, AccionTextBox.Habilitar)
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BNuevo.Click
        Try
            SCMaquinas.Panel2.Enabled = False
            Limpiar_Habilitar_TextBox(SCMaquinas.Panel1.Controls, AccionTextBox.Limpiar)
            Limpiar_Habilitar_TextBox(SCMaquinas.Panel1.Controls, AccionTextBox.Habilitar)
            TCodMaq.Focus()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BAceptar.Click
        Try
            If TCodMaq.Text = "" Then
                MsgBox("El código de la máquina no puede ser una cadena vacia", vbInformation)
                Return
            End If

            If Eval(TNombre.Text) = 0 Then
                MsgBox("El nombre de la máquina no puede ser una cadena vacia", vbInformation)
                Return
            End If

            DMaq.Open("Select * from MAQUINAS where MAQUINA='" + TCodMaq.Text.Trim + "'")

            If DMaq.RecordCount > 0 Then
                Resp = MsgBox("El código de la máquina ya existe, ¿desea sobrescribirlo?", vbYesNo)
                If Resp = vbNo Then Return
            Else
                DMaq.AddNew()
            End If

            DMaq.RecordSet("MAQUINA") = TCodMaq.Text.Trim
            DMaq.RecordSet("DESCRIPCION") = CLeft(TNombre.Text, 20)

            DMaq.Update()

            FRefrescaDG_Click(Nothing, Nothing)

            Evento("Crea máquina código: " + TCodMaq.Text + ", descripción: " + TNombre.Text)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TBuscar_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TBuscar.KeyUp
        Try

            If TBuscar.Text = "" Then
                FRefrescaDG_Click(Nothing, Nothing)
                Exit Sub
            End If
            Dim x As Integer
            x = CBBuscar.SelectedIndex
            BusquedaDG(DGMaq, DMaq.DataTable, TBuscar.Text, Campos(x))

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub
End Class