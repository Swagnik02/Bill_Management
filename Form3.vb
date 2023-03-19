Imports System.Runtime.InteropServices
Imports System.Xml
Imports FontAwesome.Sharp
Public Class HomePage
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'

        'Form'

    End Sub
    'Methods'
    Public Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            '            currentBtn.BackColor = SystemColors.HotTrack
            '            currentBtn.ForeColor = Color.Ivory
            currentBtn.FlatAppearance.BorderSize = 3
            currentBtn.FlatAppearance.BorderColor = Color.SteelBlue
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
        End If
    End Sub

    Public Sub DisableButton()
        If currentBtn IsNot Nothing Then
            '            currentBtn.BackColor = Color.FromArgb(0, 0, 64)
            '            currentBtn.ForeColor = SystemColors.ActiveCaption
            currentBtn.FlatAppearance.BorderSize = 0
            currentBtn.TextAlign = ContentAlignment.MiddleLeft

        End If
    End Sub
    Public Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub Reset()
        DisableButton()
    End Sub
    'Menu buttons Cliks'
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender)
        OpenChildForm(New Form4)
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender)
        OpenChildForm(New Form5)
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender)
        OpenChildForm(New Form6)
    End Sub
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender)
        OpenChildForm(New Form7)
    End Sub
    Private Sub IconButton5_Click(sender As Object, e As EventArgs)
        ActivateButton(sender)
        OpenChildForm(New Form8)
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd")
        Label3.Text = Date.Now.ToString("MMM")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class