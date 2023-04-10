Imports System.Data.SQLite
Imports FontAwesome.Sharp

Public Class Login
    'selecting the database
    Public dbCommand As String = ""
    Public bindingSrc As BindingSource

    Public dbName As String = "Information.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public connString As String = "Data Source=" & dbPath & ";Version=3"

    Public connection As New SQLiteConnection(connString)
    Public command As New SQLiteCommand("", connection)

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.White
        End If
    End Sub
    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.White
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.White

        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.White
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            HomePage.connection.Open()
            HomePage.IconButton5.Text = "Connection " & HomePage.connection.State.ToString
            Me.Hide()
            HomePage.Show()
        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Please Enter: USER ID and PASSWORD !!")
        Else
            MsgBox("Wrong: 'User ID & Password' ")
        End If


    End Sub
End Class