﻿Imports System.Collections.ObjectModel
Imports System.Data.SQLite
Imports System.Net.Mime.MediaTypeNames
Imports FontAwesome.Sharp

Public Class Form4

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        HomePage.ActivateButton(HomePage.IconButton2)
        HomePage.OpenChildForm(New form5)
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HomePage.command.Connection = HomePage.connection
        HomePage.command.CommandText = "SELECT * FROM Bill_Details WHERE C_ID = " & "'" & TextBox1.Text & "'"

        HomePage.c_ID = TextBox1.Text

        'MsgBox("CON ID = " & HomePage.c_ID)

        Dim rdr As SQLiteDataReader = HomePage.command.ExecuteReader
        Using rdr
            While (rdr.Read())
                TextBox3.Text = rdr.GetInt32(1)
                TextBox4.Text = rdr.GetInt32(2)
                TextBox5.Text = rdr.GetInt32(3)
                TextBox6.Text = rdr.GetInt32(4)
                TextBox7.Text = rdr.GetInt32(5)
                TextBox8.Text = rdr.GetInt32(6)
            End While
        End Using
    End Sub
End Class