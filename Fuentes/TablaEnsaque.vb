Imports System.Windows.Forms
Imports System.Data.Common
Imports System.Data
Imports System.IO


Public Class TablaEnsaque

    Private DEmpaque As AdoSQL
    Private DVarios As AdoSQL
    Private DEmp As AdoSQL
    Private Campos() As String

    Private Sub TablaEnsaque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            DEmpaque = New AdoSQL("CEmpaque")
            DVarios = New AdoSQL("Varios")
            DEmp = New AdoSQL("Eaque#")

            Limpiar_Habilitar_TextBox(Me.Controls, AccionTextBox.Limpiar)
            Limpiar_Habilitar_TextBox(SCProductos.Panel1.Controls, AccionTextBox.Deshabilitar)
            SCProductos.Panel2.Enabled = True

            FRefrescaDGEmpaque_Click(Nothing, Nothing)

            Campos = {"CodProd@Código", "NomProd@Nombre"}
            Campos = AsignaItemsCB(Campos, CBBuscar.ComboBox, DEmpaque.DataTable)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub FRefrescaDGEmpaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FRefrescaDGEmpaque.Click
        Try

            DEmpaque.Open("Select * from CEMPAQUE order BY CONT")
            DGEmpaque.AutoGenerateColumns = False
            DGEmpaque.DataSource = DEmpaque.DataTable

            If DGEmpaque.RowCount > 0 Then DGEmpaque_CellClick(Nothing, Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub DGEmpaque_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGEmpaque.CellClick
        Try

            If DGEmpaque.RowCount = 0 Then Return
            If DGEmpaque.CurrentCell Is Nothing Then Return

            TCodInt.Text = DGEmpaque.Rows(DGEmpaque.CurrentRow.Index).DataBoundItem("CODPROD")

            If TCodInt.Text = "" Then Return

            DVarios.Open("Select MAX(NOMPROD) AS NOMPROD, SUM(PESO + PESODEV + RESIDUO) AS PESOTOTAL, SUM(SACOS + SACOSDEV) AS SACOSTOTAL, MIN(FECHA) AS FECHAINICIAL, MAX(FECHA2) AS FECHAFIN from CEMPAQUE where CODPROD='" + TCodInt.Text + "'")

            If DVarios.RecordCount = 0 Then Return

            TNombre.Text = DVarios.RecordSet("NOMPROD")
            TTotSacos.Text = DVarios.RecordSet("SACOSTOTAL")
            TTotPeso.Text = DVarios.RecordSet("PESOTOTAL")

            TFechaIni.Text = DVarios.RecordSet("FECHAINICIAL")
            TFechaFin.Text = DVarios.RecordSet("FECHAFIN")

            DVarios.Close()


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub TBuscar_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBuscar.KeyUp
        Try
            If TBuscar.Text = "" Then
                FRefrescaDGEmpaque_Click(Nothing, Nothing)
                Exit Sub
            End If
            Dim x As Integer
            x = CBBuscar.SelectedIndex
            BusquedaDG(DGEmpaque, DEmpaque.DataTable, TBuscar.Text, Campos(x))

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBorrar.Click

        Dim CodInt As String, Maq As Integer, cont As String

        Try
            If DRUsuario("EMPMOD") Then
            Else
                MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
                Return
            End If

            If DGEmpaque.RowCount = 0 Then Return
            If DGEmpaque.CurrentCell Is Nothing Then Return

            Resp = MsgBox("Seguro desea eliminar el registro actual.", MsgBoxStyle.YesNo, "ChronoSoft")
            If Resp = vbNo Then Exit Sub


            CodInt = DGEmpaque.Rows(DGEmpaque.CurrentRow.Index).DataBoundItem("CODPROD")
            Maq = DGEmpaque.Rows(DGEmpaque.CurrentRow.Index).DataBoundItem("MAQUINA")
            cont = DGEmpaque.Rows(DGEmpaque.CurrentRow.Index).DataBoundItem("CONT")

            DEmp.Open("Delete from EMPAQUE" + Maq.ToString + " where CODPROD='" + CodInt + "' and CONT =' " + cont.Trim + "' and MAQUINA = " + Maq.ToString)

            DEmp.Close()

            FRefrescaDGEmpaque_Click(Nothing, Nothing)

            Evento("Elimina REGISTRO DE EMPAQUE DE PRODUCTO " + CodInt + " Maqu. " + Maq.ToString)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BEnsaqueMan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEnsaqueMan.Click
        Try

            If DRUsuario("EMPMOD") Then
            Else
                MsgBox("No puede realizar la acción solicitada.", MsgBoxStyle.Information, "ChronoSoftNet")
                Exit Sub
            End If

            EnsaqueMan.ShowDialog()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class