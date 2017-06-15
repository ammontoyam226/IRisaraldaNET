Public Class Ensaque

    Public TConsec As ArrayControles(Of TextBox)
    Public TPreset As ArrayControles(Of TextBox)
    Public TCodProd As ArrayControles(Of TextBox)
    Public TStat As ArrayControles(Of TextBox)
    Public TPesoTot As ArrayControles(Of TextBox)
    Public TSacUnder As ArrayControles(Of TextBox)
    Public TSacOver As ArrayControles(Of TextBox)
    Public TPesoUlt As ArrayControles(Of TextBox)
    Public TBandChk As ArrayControles(Of TextBox)
    Public TSacChk As ArrayControles(Of TextBox)
    Public TPesSac As ArrayControles(Of TextBox)



    Public Sub Ensaque_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TConsec = New ArrayControles(Of TextBox)("TConsec", Me)
        TPreset = New ArrayControles(Of TextBox)("TPreset", Me)
        TCodProd = New ArrayControles(Of TextBox)("TCodProd", Me)
        TStat = New ArrayControles(Of TextBox)("TStat", Me)
        TPesoTot = New ArrayControles(Of TextBox)("TPesoTot", Me)
        TSacUnder = New ArrayControles(Of TextBox)("TSacUnder", Me)
        TSacOver = New ArrayControles(Of TextBox)("TSacOver", Me)
        TPesoUlt = New ArrayControles(Of TextBox)("TPesoUlt", Me)
        TBandChk = New ArrayControles(Of TextBox)("TBandChk", Me)
        TSacChk = New ArrayControles(Of TextBox)("TSacChk", Me)
        TPesSac = New ArrayControles(Of TextBox)("TPesSac", Me)


    End Sub
End Class