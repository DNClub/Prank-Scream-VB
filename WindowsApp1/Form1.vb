Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Threading.Thread.Sleep(NumericUpDown1.Value * 1000)
        Form2.Show()
    End Sub
End Class
