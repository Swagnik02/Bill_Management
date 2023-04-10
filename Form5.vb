Imports System.Data.SQLite
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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

    Private Sub form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form4.c_ID
        HomePage.command.Connection = HomePage.connection
        HomePage.command.CommandText = "SELECT * FROM Consumer_Details WHERE Consumer_ID = " & "'" & Form4.c_ID & "'"

        Dim rdr As SQLiteDataReader = HomePage.command.ExecuteReader
        Using rdr
            While (rdr.Read())
                TextBox2.Text = rdr.GetInt32(1)
                'TextBox3.Text = rdr.GetInt32(3)
                'TextBox4.Text = rdr.GetInt32(4)
                TextBox5.Text = rdr.GetInt32(5)
            End While
        End Using
    End Sub
End Class