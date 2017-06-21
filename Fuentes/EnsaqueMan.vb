Imports System.Windows.Forms
Imports System.Data.Common
Imports System.Data
Imports System.IO


Public Class EnsaqueMan
    Dim DEmpaque As AdoSQL
    Dim DEmp As AdoSQL
    Dim DVarios As AdoSQL
    Dim DProd As AdoSQL

    Private Sub EnsaqueMan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            DEmpaque = New AdoSQL("Empaque")
            DEmp = New AdoSQL("Emp")
            DVarios = New AdoSQL("Varios")
            DProd = New AdoSQL("Productos")

            CBMaquina.Items.Clear()

            For i = 1 To 4 Step 1
                CBMaquina.Items.Add(i)
            Next

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

    Private Sub BAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BAceptar.Click

        Dim ConsecutivoActual As String = "0"

        Try

            If Eval(TSacos.Text.Trim) = 0 Then
                MsgBox("El número de sacos debe ser diferente de cero.", vbInformation)
                Exit Sub
            End If
            If Eval(TPesoSaco.Text.Trim) <= 0 Then
                MsgBox("El Peso por Saco debe ser mayor a cero", vbInformation)
                Exit Sub
            End If
            If Eval(CBMaquina.Text.Trim) = 0 Or Eval(CBMaquina.Text.Trim) > 4 Then
                MsgBox("El número de Máquina es incorrecto o no existe.", vbInformation)
                Exit Sub
            End If
            If Eval(TPesoTotal.Text.Trim) = 0 Then
                MsgBox("El peso total embalado debe ser diferente de cero.", vbInformation)
                Exit Sub
            End If
            If Trim(TCodInt.Text.Trim) = "" Then
                MsgBox("El CODIGO del producto no puede ser nulo o vacío.", vbInformation)
                Exit Sub
            End If
            If Trim(TNombre.Text.Trim) = "" Then
                MsgBox("El NOMBRE del producto no puede ser un dato vacío.", vbInformation)
                Exit Sub
            End If

            Select Case CBMaquina.Text.Trim
                Case 1
                    DVarios.Open("select * from VARIOSCONFIG where DESCRIPCION='ConsEmpaque1'")
                Case 2
                    DVarios.Open("select * from VARIOSCONFIG where DESCRIPCION='ConsEmpaque2'")

                Case 3
                    DVarios.Open("select * from VARIOSCONFIG where DESCRIPCION='ConsEmpaque3'")
                Case 4
                    DVarios.Open("select * from VARIOSCONFIG where DESCRIPCION='ConsEmpaque4'")
            End Select

            If DVarios.RecordCount Then ConsecutivoActual = DVarios.RecordSet("CANTIDAD").ToString

            DEmpaque.Open("select * from EMPAQUE" + CBMaquina.Text.Trim + " where MAQUINA=0")
            If DEmpaque.RecordCount Then
            Else
                DEmpaque.AddNew()
            End If

            DEmpaque.RecordSet("Cont") = Eval(ConsecutivoActual) + 1
            DEmpaque.RecordSet("CodProd") = CLeft(TCodInt.Text.Trim, 20)
            DEmpaque.RecordSet("NomProd") = CLeft(TNombre.Text.Trim, 30)
            DEmpaque.RecordSet("Maquina") = Eval(CBMaquina.Text.Trim)
            DEmpaque.RecordSet("Peso") = Eval(TPesoTotal.Text.Trim)
            DEmpaque.RecordSet("Sacos") = Eval(TSacos.Text.Trim)
            DEmpaque.RecordSet("PresKg") = Eval(TPesoSaco.Text.Trim)
            DEmpaque.RecordSet("Prom") = Eval(TPesoSaco.Text.Trim)
            DEmpaque.RecordSet("Fecha") = CLeft(Format(Now, "yyyy/MM/dd HH:mm:ss"), 20)
            DEmpaque.RecordSet("Fecha2") = CLeft(Format(Now, "yyyy/MM/dd HH:mm:ss"), 20)
            DEmpaque.RecordSet("FECHAF") = CLeft(Format(Now, "yyyy/MM/dd HH:mm:ss"), 20)
            DEmpaque.RecordSet("FECHAF2") = CLeft(Format(Now, "yyyy/MM/dd HH:mm:ss"), 20)

            DEmpaque.Update()

            DEmpaque.Close()

            DVarios.RecordSet("Cantidad") = DVarios.RecordSet("Cantidad") + 1
            DVarios.Update()

            DVarios.Close()


            TCodInt.Focus()

            MsgBox("Los datos han sido almacenados correctamente en la base de Datos.", vbInformation)

            Evento("Ingresa Empaque Manual de sacos " + TSacos.Text.Trim + " Maqu. " + CBMaquina.Text.Trim + " - Prod. " + TCodInt.Text.Trim + "-" + TNombre.Text.Trim + ".")

            BCancelar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click
        Try

            Limpiar_Habilitar_TextBox(Me.Controls, AccionTextBox.Limpiar)
            Limpiar_Habilitar_TextBox(Panel1.Controls, AccionTextBox.Deshabilitar)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub


    Private Sub TCodInt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TCodInt.KeyUp
        Try

            If e.KeyCode <> Keys.Enter Then Exit Sub
            If TCodInt.Text.Trim = "" Then Exit Sub

            DProd.Open("select * from PRODUCTOS where CODPROD = '" + TCodInt.Text.Trim + "'")
            If DProd.RecordCount = 0 Then Exit Sub

            TNombre.Text = DProd.RecordSet("NOMPROD").ToString.Trim
            TPesoSaco.Text = DProd.RecordSet("PRESKG").ToString.Trim

            If TSacos.Text.Trim <> "" AndAlso Eval(TSacos.Text.Trim) Then TPesoTotal.Text = Eval(TSacos.Text.Trim) * Eval(TPesoSaco.Text.Trim)

            DProd.Close()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub TNombre_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TNombre.KeyUp
        Try

            If e.KeyCode <> Keys.Enter Then Exit Sub
            If TCodInt.Text.Trim = "" Then Exit Sub

            DProd.Open("select * from PRODUCTOS where NOMPROD = '" + TNombre.Text.Trim + "'")
            If DProd.RecordCount = 0 Then Exit Sub

            TCodInt.Text = DProd.RecordSet("CODPROD").ToString.Trim
            TPesoSaco.Text = DProd.RecordSet("PRESKG").ToString.Trim

            If TSacos.Text.Trim <> "" AndAlso Eval(TSacos.Text.Trim) Then TPesoTotal.Text = Eval(TSacos.Text.Trim) * Eval(TPesoSaco.Text.Trim)

            DProd.Close()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub

    Private Sub TPesoSaco_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TPesoSaco.KeyUp
        Try

            If e.KeyCode <> Keys.Enter Then Exit Sub
            If TSacos.Text.Trim = "" AndAlso Eval(TSacos.Text.Trim) Then Exit Sub

            TPesoTotal.Text = Eval(TSacos.Text.Trim) * Eval(TPesoSaco.Text.Trim)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try

    End Sub
End Class