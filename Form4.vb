Imports FontAwesome.Sharp

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        HomePage.ActivateButton(HomePage.IconButton2)
        form5.Label7.Text = TextBox1.Text
        HomePage.OpenChildForm(New form5)

    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub

End Class