Imports System.Data.SQLite
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form5
    Public c_ID As String
    Public mnth As String
    Public Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        ' Define the border color and thickness
        Dim borderColor As Color = Color.SteelBlue
        Dim borderWidth As Integer = 2

        ' Draw the border
        ControlPaint.DrawBorder(e.Graphics, Panel2.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub

    Public Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Form8.Label2.Text = TextBox4.Text
        Form8.Show()
        HomePage.Hide()
    End Sub

    Public Sub form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ref()
    End Sub
    Public Sub ref()
        TextBox1.Text = HomePage.c_ID

        HomePage.command.Connection = HomePage.connection

        'MsgBox("Select Consumer_ID,Name,Meter_No,Total,Email_ID From Bill_Details, Connection_Details, Consumer_Details Where Consumer_ID =" & "'" & TextBox1.Text & "' AND Month = " & "'" & HomePage.mnth & "'")

        HomePage.command.CommandText = "Select Consumer_ID,Name,Meter_No,Total,Email_ID From Bill_Details, Connection_Details, Consumer_Details Where Consumer_ID =" & "'" & TextBox1.Text & "'"

        Dim rdr As SQLiteDataReader = HomePage.command.ExecuteReader
        Using rdr
            While (rdr.Read())
                TextBox2.Text = rdr.GetString(1)
                TextBox3.Text = rdr.GetString(2)
                TextBox4.Text = rdr.GetInt32(3)
                TextBox5.Text = rdr.GetString(4)
            End While
        End Using

        'MsgBox("CON ID = " & HomePage.mnth)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class