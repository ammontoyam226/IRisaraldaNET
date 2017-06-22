Public Class DatosGraf

    Private DProd As AdoSQL
    Private DPesos As AdoSQL
    Private DPesosChk As AdoSQL
    Private Prom As Single

    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    
    

    Public Sub BGrafEnsac_Click(sender As System.Object, e As System.EventArgs) Handles BGrafEnsac.Click
        Try
            TMensaje.Text = "Peso de los sacos Programados para ser Graficados"

            DProd.Open("select * from PRODUCTOS where CODPROD='" + Trim(TCodProd.Text) + "'")
            If DProd.RecordCount = 0 Then Return

            'TNomProd = B.DProd!NomProd
            'TPresKg = B.DProd!PresKg


            DPesos.Open("select AVG(PESO) AS PROMPESO from PESOS where MAQUINA=" + Trim(TMaquina.Text) + " and ID=" + Trim(TID.Text) + " and BASCULA=" + Trim(TBascula.Text))

            If DPesos.RecordCount = 0 Then
                TMenSacChK.Visible = True
                Return
            End If
            Prom = 0

            If Not IsDBNull(DPesos.RecordSet("PROMPESO")) Then
                Prom = Math.Round(DPesos.RecordSet("PROMPESO"), 2)
            End If

            DPesosChk.Open(" select * from PESOSCHK where  MAQUINA=" + Trim(TMaquina.Text) + " and ID=" + Trim(TID.Text) + " and BASCULA=" + Trim(TBascula.Text) + " and Fecha='" + Trim(TFecha.Text) + "'")


            If DPesosChk.RecordSet("Peso") < Prom Or DPesosChk.RecordSet("Peso") > Prom Then
                DPesosChk.RecordSet("Peso") = Prom
                DPesosChk.Update()
                TProm.Text = Prom.ToString
            End If

            DPesos.Close()
            DPesos.Open("select * from PESOS where MAQUINA=" + Trim(TMaquina.Text) + " and ID=" + Trim(TID.Text) + " and BASCULA=" + Trim(TBascula.Text))
            DGPesos.DataSource = DPesos.DataTable

            DPesos.Close()
            DPesosChk.Close()
            DProd.Close()

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Private Sub BGrafRep_Click(sender As System.Object, e As System.EventArgs) Handles BGrafRep.Click
        Try

            TMensaje.Text = "Peso del sacos de la Comprobadora Graficado"
            TPeso.Text = "PesoBruto"
            TPesoReal.Text = "PesoReal"
            DGPesos.Visible = False

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub

    Public Sub DatosGraf_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try

            DProd = New AdoSQL("PRODUCTOS")
            DPesos = New AdoSQL("PESOS")
            DPesosChk = New AdoSQL("PESOSCHK")

            TMenSacChK.Visible = False
        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class