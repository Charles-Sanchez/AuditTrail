Imports System.Xml

Public Class Form3

    Dim x As Integer
    Public Sub childform(ByVal panel As Form)
        contentPane.Controls.Clear()
        panel.TopLevel = False
        contentPane.Controls.Add(panel)
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PanelMenu.Width >= 220 Then
            Me.Timer1.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 45
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PanelMenu.Width <= 85 Then
            Me.Timer2.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 45

        End If
    End Sub

    Private Sub panelBtn_Click(sender As Object, e As EventArgs) Handles panelBtn.Click
        If PanelMenu.Width = 220 Then
            Timer2.Enabled = True
        ElseIf PanelMenu.Width = 85 Then
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        If MsgBox("Do you want to log out?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Log Out?") = MsgBoxResult.Yes Then
            Me.Close()
            Form2.Show()
        End If
    End Sub

    Private Sub PanelBtn1_Click(sender As Object, e As EventArgs) Handles PanelBtn1.Click
        childform(panelForm1)
        ' panelForm1.AllClear()
        panelForm2.Close()
        panelForm3.Close()
        panelIndicator1.Show()
        panelIndicator2.Hide()
        panelIndicator3.Hide()
    End Sub

    Private Sub PanelBtn2_Click(sender As Object, e As EventArgs) Handles PanelBtn2.Click
        childform(panelForm2)
        panelForm3.Close()
        panelIndicator2.Show()
        panelIndicator1.Hide()
        panelIndicator3.Hide()
    End Sub

    Private Sub PanelBtn3_Click(sender As Object, e As EventArgs) Handles PanelBtn3.Click
        panelForm1.Close()
        panelForm2.Close()
        childform(panelForm3)
        panelIndicator3.Show()
        panelIndicator1.Hide()
        panelIndicator2.Hide()
    End Sub


    Private Sub Clock_Tick_1(sender As Object, e As EventArgs) Handles Clock.Tick
        lblClock.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub startUpBtn_Click(sender As Object, e As EventArgs) Handles startUpBtn.Click
        panelIndicator1.Show()
        panelIndicator2.Hide()
        panelIndicator3.Hide()
        If PanelMenu.Width = 85 Then
            Timer1.Enabled = True
        End If
        childform(panelForm1)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelIndicator1.Hide()
        panelIndicator2.Hide()
        panelIndicator3.Hide()
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
