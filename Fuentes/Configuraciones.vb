
Imports System
Public Class Configuraciones

    Private TNoMuestrasEnsc As ArrayControles(Of TextBox)
    Private TSacGrafEnsc As ArrayControles(Of TextBox)
    Private TMinRep As ArrayControles(Of TextBox)

    Private DVariosConfig As AdoSQL

    Private Sub Configuraciones_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Try

            TMinRep = New ArrayControles(Of TextBox)("TMinRep", TLPConfig.Controls)
            TSacGrafEnsc = New ArrayControles(Of TextBox)("TSacGrafEnsc", TLPConfig.Controls)
            TNoMuestrasEnsc = New ArrayControles(Of TextBox)("TNoMuestrasEnsc", TLPConfig.Controls)

            DVariosConfig = New AdoSQL("VARIOSCONFIG")

            DVariosConfig.Open(" select * from VARIOSCONFIG")

            For i = 1 To 4
                DVariosConfig.Find("DESCRIPCION='MuestrasEnsac" + i.ToString + "'")
                If Not DVariosConfig.EOF Then
                    TNoMuestrasEnsc(i).Text = DVariosConfig.RecordSet("Cantidad")
                End If

                DVariosConfig.Find("DESCRIPCION='SacGraf" + i.ToString + "'")
                If Not DVariosConfig.EOF Then
                    TSacGrafEnsc(i).Text = DVariosConfig.RecordSet("Cantidad")
                End If

                DVariosConfig.Find("DESCRIPCION='MinRep" + i.ToString + "'")
                If Not DVariosConfig.EOF Then
                    TMinRep(i).Text = DVariosConfig.RecordSet("Cantidad")
                End If
            Next


            DVariosConfig.Close()


        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BAceptar.Click
        Try

            For i = 1 To 4
                If Eval(TNoMuestrasEnsc(i).Text) = 0 Then
                    MsgBox("  Debe Ingresar un Dato Valido para los Sacos a Comprobar en la ensacadora " + i.ToString, vbInformation)
                    Return
                End If

                If Eval(TSacGrafEnsc(i).Text) = 0 Then
                    MsgBox(" Debe Ingresar un Dato Valido para los Sacos a Graficar en la ensacadora " + i.ToString, vbInformation)
                    Exit Sub
                End If

                If Eval(TMinRep(i).Text) <= 0 Then
                    MsgBox(" Debe Ingresar un Dato Valido para el tiempo de Muestreo en la Comprobadora " + i.ToString, vbInformation)
                    Exit Sub
                End If
            Next

            
            DVariosConfig.Open(" select * from VARIOSCONFIG")

            For i = 1 To 4
                DVariosConfig.Find("DESCRIPCION='MuestrasEnsac" + i.ToString + "'")
                If Not DVariosConfig.EOF Then
                    DVariosConfig.RecordSet("Cantidad") = Eval(TNoMuestrasEnsc(i).Text)
                    DVariosConfig.Update()
                End If

                DVariosConfig.Find("DESCRIPCION='SacGraf" + i.ToString + "'")
                If Not DVariosConfig.EOF Then
                    DVariosConfig.RecordSet("Cantidad") = Eval(TSacGrafEnsc(i).Text)
                    DVariosConfig.Update()
                End If

                DVariosConfig.Find("DESCRIPCION='MinRep" + i.ToString + "'")
                If Not DVariosConfig.EOF Then
                    DVariosConfig.RecordSet("Cantidad") = Eval(TSacGrafEnsc(i).Text)
                    DVariosConfig.Update()
                End If
            Next

            DVariosConfig.Close()

            MsgBox("Datos Almacenados Correctamente ", vbInformation)

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    
    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click
        Try
            Limpiar_Habilitar_TextBox(TLPConfig.Controls, AccionTextBox.Limpiar)
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class