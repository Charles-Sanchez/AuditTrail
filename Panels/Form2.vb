Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        PictureBox5.Image = My.Resources.exitwt
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.exitbk
    End Sub

    Private Sub PictureBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseClick
        Application.Exit()
    End Sub
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Enter Password..." Then
            TextBox2.Text = ""
            TextBox2.PasswordChar = "●"
            TextBox2.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Enter Password..."
            TextBox2.PasswordChar = ""
            TextBox2.ForeColor = Color.DarkGray
        End If
    End Sub


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Enter Username..." Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter Username..."
            TextBox1.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            logInBtn.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub logInBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles logInBtn.MouseClick
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM accounts where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()

            Dim count As Integer

            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")
                Me.Close()
                Form3.Show()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicated")
            Else
                MessageBox.Show("Username and Password are not correct")
            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TextBox1.Text = ""
            TextBox2.Text = ""
            MysqlConn.Dispose()
        End Try
        'Me.Close()
        'Form3.Show()
    End Sub

    Private Sub lblLoginHelp_Click(sender As Object, e As EventArgs) Handles lblLoginHelp.Click
        MsgBox("Only accepts 20 characters including spaces." & vbCrLf & vbCrLf & "In case you forgot your account or password, please contact the developer.", MsgBoxStyle.Information, "Help?")

    End Sub
End Class

