Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class LoadingScreen
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Enum ProgressBarColor
        Green = &H1
        Red = &H2
        Yellow = &H3
    End Enum
    Private Shared Sub ChangeProgBarColor(ByVal ProgressBar_Name As Windows.Forms.ProgressBar, ByVal ProgressBar_Color As ProgressBarColor)
        SendMessage(ProgressBar_Name.Handle, &H410, ProgressBar_Color, 0)
    End Sub

    Private Sub LoadingScreen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeProgBarColor(ProgressBar, ProgressBarColor.Red)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar.Value += 1
        If ProgressBar.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            Login.Show()
        End If
    End Sub

End Class