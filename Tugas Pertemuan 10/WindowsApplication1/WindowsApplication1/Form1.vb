Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, i As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a
        For i = 1 To b - 1
            d = a * c
            a = d
        Next

        TextBox3.Text = d
    End Sub
End Class
