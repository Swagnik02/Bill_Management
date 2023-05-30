Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Windows

Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button3.Visible = True
        Button4.Visible = False
        Button5.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Visible = False
        Button4.Visible = True
        Button5.Visible = True
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HomePage.command.Connection = HomePage.connection
        HomePage.command.CommandText = "INSERT INTO Consumer_Details values('" & TextBox1.Text & "'," & "'" & TextBox2.Text & "'," & TextBox3.Text & "," & "'" & TextBox4.Text & "'," & "'" & TextBox5.Text & "'," & TextBox6.Text & ")"

        HomePage.command.ExecuteNonQuery()
        MsgBox("ID added successfully")
        HomePage.connection.Close()
        HomePage.connection.Open()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        HomePage.command.Connection = HomePage.connection
        HomePage.command.CommandText = "UPDATE Consumer_Details SET Name = " & "'" & TextBox2.Text & "'" & ", Mobile_No = " & TextBox3.Text & ", Email_ID = " & "'" & TextBox4.Text & "'" & ", Address = " & "'" & TextBox5.Text & "'" & ", PINCode = " & "'" & TextBox6.Text & "'" & " WHERE Consumer_ID=" & "'" & TextBox1.Text & "'"

        HomePage.command.ExecuteNonQuery()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        HomePage.command.Connection = HomePage.connection
        HomePage.command.CommandText = "DELETE FROM Consumer_Details WHERE Consumer_ID=" & "'" & TextBox1.Text & "'"


        'WHERE Name = " & "'" & TextBox2.Text & "'" & ", Mobile_No = " & TextBox3.Text & ", Email_ID = " & "'" & TextBox4.Text & "'" & ", Address = " & "'" & TextBox5.Text & "'" & ", PINCode = " & "'" & TextBox6.Text & "'" & " WHERE Consumer_ID=" & "'" & TextBox1.Text & "'"

        HomePage.command.ExecuteNonQuery()
    End Sub
End Class