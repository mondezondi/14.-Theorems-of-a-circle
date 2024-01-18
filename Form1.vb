Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = Val(TextBox1.Text)
        b = a * 2

        TextBox2.Text = b


    End Sub
End Class
