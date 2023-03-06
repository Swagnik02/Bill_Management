Imports FontAwesome.Sharp

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HomePage.ActivateButton(sender, RGBColors.color2)
        HomePage.OpenChildForm(New Form5)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class