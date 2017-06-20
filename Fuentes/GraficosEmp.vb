Public Class GraficosEmp

    Private FormLoad As Boolean
    
    Private Sub BSalir_Click(sender As System.Object, e As System.EventArgs) Handles BSalir.Click
        Me.Hide()
    End Sub

    Private Sub GraficosEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            If FormLoad Then Return


            
            'For i = 0 To TLPEmpaque.RowCount - 1
            '    TLPEmpaque.RowStyles.Item(i).SizeType = SizeType.Percent
            '    TLPEmpaque.RowStyles.Item(i).Height = 50
            'Next
            'TLPEmpaque.Refresh()
            'TLPEmpaque.Visible = True

            FormLoad = True

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class