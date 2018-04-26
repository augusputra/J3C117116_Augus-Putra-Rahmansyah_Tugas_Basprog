Public Class Form1

    Private Sub btkecil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkecil.TextChanged
        btbesar.Text = 100 - btkecil.Text
    End Sub

    Private Sub btbesar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbesar.TextChanged
        buts.Text = 100 - btkecil.Text - btbesar.Text
    End Sub

    Private Sub buts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buts.TextChanged
        buas.Text = 100 - btkecil.Text - btbesar.Text - buts.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, f, g, h, i, j, k As Double
        a = ntkecil.Text
        b = ntbesar.Text
        c = nuts.Text
        d = nuas.Text
        f = btkecil.Text
        g = btbesar.Text
        h = buts.Text
        i = buas.Text

        k = f + g + h + i

        If k = 100 Then

            j = ((a * f / 100) + (b * g / 100) + (c * h / 100) + (d * i / 100))
            ntotal.Text = j
            If j >= 80 Then
                Label11.Text = "A"
            ElseIf j >= 70 Then
                Label11.Text = "B"
            ElseIf j >= 60 Then
                Label11.Text = "C"
            ElseIf j >= 50 Then
                Label11.Text = "D"
            Else
                Label11.Text = "E"
            End If
        Else
            MsgBox("Bobot Tidak Sama Dengan 100%", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
