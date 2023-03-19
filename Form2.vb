Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoadingScreen
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBarCust.Value += 1
        If ProgressBarCust.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            Login.Show()
        End If
    End Sub
    Private Sub ProgressBarCust_Click(sender As Object, e As EventArgs) Handles ProgressBarCust.Click
        ProgressBarCust.ForeColor = Color.Black
    End Sub

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class