Public Class Productos
    Private DProd As AdoSQL
    Private DVarios As AdoSQL
    Private Campos() As String
    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            DProd = New AdoSQL("Articulos")
            DVarios = New AdoSQL("Varios")
            BCancelar_Click(Nothing, Nothing)
            FRefrescaDGProd_Click(Nothing, Nothing)

            Campos = {"CodInt@Código", "Nombre@Nombre"}
            Campos = AsignaItemsCB(Campos, CBBuscar.ComboBox, DProd.DataTable)


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub FRefrescaDGProd_Click(sender As System.Object, e As System.EventArgs) Handles FRefrescaDGProd.Click
        Try
            DProd.Open("Select * from ARTICULOS where TIPO='PT' order BY Nombre")
            DGProd.AutoGenerateColumns = False
            DGProd.DataSource = DProd.DataTable

            If DGProd.RowCount > 0 Then DGProd_CellClick(Nothing, Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub DGProd_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGProd.CellClick
        Try
            If DGProd.RowCount = 0 Then Return
            If DGProd.CurrentCell Is Nothing Then Return

            TCodInt.Text = DGProd.Rows(DGProd.CurrentRow.Index).DataBoundItem("CODINT")

            If TCodInt.Text = "" Then Return

            DVarios.Open("Select * from ARTICULOS where TIPO='PT' and CODINT='" + TCodInt.Text + "'")

            If DVarios.RecordCount = 0 Then Return

            TNombre.Text = DVarios.RecordSet("NOMBRE")
            TRangoCap.Text = DVarios.RecordSet("RANGOCAPT")
            TTolerancia.Text = DVarios.RecordSet("TOLERANCIA")
            TPesoNom.Text = DVarios.RecordSet("PESONOM")
            'TLimInf.Text = DVarios.RecordSet("LIMINF")
            'TLimSup.Text = DVarios.RecordSet("LIMSUP")
            'TErrorT1.Text = DVarios.RecordSet("ERRORT1")
            'TErrorT2.Text = DVarios.RecordSet("ERRORT2")

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click
        Try
            Limpiar_Habilitar_TextBox(Me.Controls, AccionTextBox.Limpiar)
            Limpiar_Habilitar_TextBox(SCProductos.Panel1.Controls, AccionTextBox.Deshabilitar)
            SCProductos.Panel2.Enabled = True

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BEditar_Click(sender As System.Object, e As System.EventArgs) Handles BEditar.Click
        Try
            If DRUsuario("ModProd") Then
            Else
                MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
                Return
            End If
            Limpiar_Habilitar_TextBox(SCProductos.Panel1.Controls, AccionTextBox.Habilitar)
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BNuevo.Click
        Try
            If DRUsuario("ModProd") Then
            Else
                MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
                Return
            End If
            SCProductos.Panel2.Enabled = False
            Limpiar_Habilitar_TextBox(SCProductos.Panel1.Controls, AccionTextBox.Limpiar)
            Limpiar_Habilitar_TextBox(SCProductos.Panel1.Controls, AccionTextBox.Habilitar)
            TCodInt.Focus()
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BAceptar.Click
        Try

            If TCodInt.Text = "" Then
                MsgBox("El código del producto no puede ser una cadena vacia", vbInformation)
                Return
            End If

            If Eval(TPesoNom.Text) = 0 Then
                MsgBox("El peso del producto no puede ser cero", vbInformation)
                Return
            End If

            If Eval(TTolerancia.Text) = 0 Then
                MsgBox("La tolerancia del producto no puede ser cero", vbInformation)
                Return
            End If

            If Eval(TRangoCap.Text) = 0 Then
                MsgBox("El rango de captura del producto no puede ser cero", vbInformation)
                Return
            End If

            If TNombre.Text = "" Then
                MsgBox("El nombre del producto no puede ser una cadena vacia", vbInformation)
                Return
            End If


            DProd.Open("Select * from ARTICULOS where TIPO='PT' and CODINT='" + TCodInt.Text + "'")

            If DProd.RecordCount > 0 Then
                Resp = MsgBox("El código del producto ya existe, ¿desea sobrescribirlo?", vbYesNo)
                If Resp = vbNo Then Return
            Else
                DProd.AddNew()
            End If

            DProd.RecordSet("CODINT") = TCodInt.Text
            DProd.RecordSet("NOMBRE") = CLeft(TNombre.Text, 20)
            DProd.RecordSet("PESONOM") = Eval(TPesoNom.Text)
            DProd.RecordSet("RANGOCAPT") = Eval(TRangoCap.Text)
            DProd.RecordSet("TOLERANCIA") = Eval(TTolerancia.Text)
            'DProd.RecordSet("LIMINF") = Eval(TLimInf.Text)
            'DProd.RecordSet("LIMSUP") = Eval(TLimSup.Text)
            'DProd.RecordSet("ERRORT1") = Eval(TErrorT1.Text)
            'DVarios.RecordSet("ERRORT2") = Eval(TErrorT2.Text)


            DProd.Update()

            FRefrescaDGProd_Click(Nothing, Nothing)

            Evento("Crea o modifica producto código: " + TCodInt.Text + ", Nombre: " + TNombre.Text + " Peso Nom: " + _
                    TPesoNom.Text + " Tolerancia:" + TTolerancia.Text)


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub BBorrar_Click(sender As System.Object, e As System.EventArgs) Handles BBorrar.Click
        Dim CodInt As String
        If DRUsuario("ModProd") Then
        Else
            MsgBox("No tiene permiso para ejecutar la acción solicitada", MsgBoxStyle.Information)
            Return
        End If

        If DGProd.RowCount = 0 Then Return
        If DGProd.CurrentCell Is Nothing Then Return

        CodInt = DGProd.Rows(DGProd.CurrentRow.Index).DataBoundItem("CODINT")

        DVarios.Open("Select * from ARTICULOS where CODINT='" + CodInt + "'")

        Resp = MsgBox("¿Seguro desea eliminar el producto " + DVarios.RecordSet("NOMBRE") + "?", vbInformation, vbYesNo)
        If Resp = vbNo Then Return

        DVarios.Open("Delete from ARTICULOS where CODINT='" + CodInt + "'")

        FRefrescaDGProd_Click(Nothing, Nothing)

        Evento("Elimina articulo " + CodInt)

    End Sub

    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TBuscar_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TBuscar.KeyUp
        Try

            If TBuscar.Text = "" Then
                FRefrescaDGProd_Click(Nothing, Nothing)
                Exit Sub
            End If
            Dim x As Integer
            x = CBBuscar.SelectedIndex
            BusquedaDG(DGProd, DProd.DataTable, TBuscar.Text, Campos(x))

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub
End Class