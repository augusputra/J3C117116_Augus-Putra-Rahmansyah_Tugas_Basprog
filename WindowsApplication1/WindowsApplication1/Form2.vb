Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a, b, c, d As Single
        a = txtn1.Text
        b = txtn2.Text
        c = txtn3.Text
        d = (a + b + c) / 3
        rataan.Text = d
        If d > 80 Then
            hadiah.Text = "Rp. 10.000.000"
            MsgBox("Selemat Anda Mendapatkan Hadiah Rp. 1.000.000", MsgBoxStyle.Information, "Pesan")
        ElseIf d > 70 Then
            hadiah.Text = "Rp. 7.500.000"
            MsgBox("Selemat Anda Mendapatkan Hadiah Rp. 7.500.000", MsgBoxStyle.Information, "Pesan")
        Else
            hadiah.Text = "Sertifikat"
            MsgBox("Selemat Anda Mendapatkan Sertifikat", MsgBoxStyle.Information, "Pesan")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtnama.Clear()
        txtn1.Clear()
        txtn2.Clear()
        txtn3.Clear()
        rataan.Text = ".............................................."
        hadiah.Text = ".............................................."
    End Sub
End Class