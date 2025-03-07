Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles progressBar.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If prog.Width < 630 Then
            prog.Width += 8
        End If

        If prog.Width >= 630 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
        End If
    End Sub

End Class