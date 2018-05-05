Public Class Form2

    Dim a, b, c, d, f, i As Integer
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Honda"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Cbr 250 rr")
                ComboBox2.Items.Add("Cbr 150 r")
                ComboBox2.Items.Add("Pcx")
            Case "Yamaha"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("R25")
                ComboBox2.Items.Add("Vixion 150")
                ComboBox2.Items.Add("Nmax")
            Case "Suzuki"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Gsx 250")
                ComboBox2.Items.Add("Gs 150 r")
                ComboBox2.Items.Add("Hayate")
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Cbr 250 rr"
                TextBox1.Text = "Rp. 63.000.000"
                a = 63000000
            Case "Cbr 150 r"
                TextBox1.Text = "Rp. 30.000.000"
                a = 30000000
            Case "Pcx"
                TextBox1.Text = "Rp. 28.000.000"
                a = 28000000
            Case "R25"
                TextBox1.Text = "Rp. 60.000.000"
                a = 60000000
            Case "Vixion 150"
                TextBox1.Text = "Rp. 30.000.000"
                a = 30000000
            Case "Nmax"
                TextBox1.Text = "Rp. 25.000.000"
                a = 25000000
            Case "Gsx 250"
                TextBox1.Text = "Rp. 62.000.000"
                a = 62000000
            Case "Gs 150 r"
                TextBox1.Text = "Rp. 29.000.000"
                a = 29000000
            Case "Hayate"
                TextBox1.Text = "Rp. 15.000.000"
                a = 15000000
        End Select

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.Text
            Case 6
                b = 2
            Case 12
                b = 3
        End Select
        TextBox2.Text = b
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        c = ComboBox3.Text
        d = a / c
        For i = 1 To c
            f = d + (d * (b / 100))
            d = f
            ListBox1.Items.Add("Cicilan bulan ke-" & i & " = Rp. " & f)
        Next
    End Sub
End Class