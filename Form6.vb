Imports System.Data.SQLite
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form6
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        HomePage.command.Connection = HomePage.connection
        HomePage.command.CommandText = "SELECT * FROM Consumer_Details WHERE Consumer_ID = " & "'" & TextBox1.Text & "'"

        Dim rdr As SQLiteDataReader = HomePage.command.ExecuteReader
        Using rdr
            While (rdr.Read())
                TextBox2.Text = rdr.GetString(1)
                TextBox3.Text = rdr.GetInt64(2)
                TextBox4.Text = rdr.GetString(3)
                TextBox5.Text = rdr.GetString(4)
                TextBox6.Text = rdr.GetInt32(5)

            End While
        End Using
    End Sub
End Class