Imports System.Windows.Controls
Public Class form5

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        ' Define the border color and thickness
        Dim borderColor As Color = Color.SteelBlue
        Dim borderWidth As Integer = 2

        ' Draw the border
        ControlPaint.DrawBorder(e.Graphics, Panel2.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Form8.Label2.Text = TextBox5.Text
        Form8.Show()
        HomePage.Hide()
    End Sub

    Private Sub conID_Click(sender As Object, e As EventArgs)

    End Sub
End Class