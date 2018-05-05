Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, faktor, d, kuadrat, i, x, y, fibo As Integer
        a = TextBox1.Text
        b = a
        For i = 1 To a - 1
            d = b - i
            faktor = a * d
            a = faktor
        Next
        TextBox2.Text = faktor

        a = TextBox1.Text
        x = 1
        y = 0
        For i = 1 To a
            fibo = x + y
            x = y
            y = fibo
            TextBox3.Text = fibo
        Next

        a = TextBox1.Text

        kuadrat = a * a
        TextBox4.Text = kuadrat
    End Sub
End Class