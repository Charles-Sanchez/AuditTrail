Imports MySql.Data.MySqlClient

Public Class panelForm3

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE info.`accounts` " _
                & "SET username = '" & Tbx_Username.Text & "', " _
                & "password = '" & Tbx_Password.Text & "' " _
                & "WHERE id = 1"
            Command = New MySqlCommand(Query, MysqlConn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Credentials are updated successfully")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Tbx_Username.Text = ""
            Tbx_Password.Text = ""
            MysqlConn.Dispose()
        End Try
    End Sub



    Private Sub Btn_Credentials_Click(sender As Object, e As EventArgs) Handles Btn_Credentials.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM accounts WHERE id = 1"
            Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader

            While READER.Read
                Tbx_Username.Text = READER.GetString("username")
                Tbx_Password.Text = READER.GetString("password")
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub panelForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GreetUser()
        Label3.Text = "Hello,"
        GunaPictureBox1.Controls.Add(Label5)
        GunaPictureBox1.Controls.Add(Label3)

    End Sub

    Private Sub lblUsernameHelp_Click(sender As Object, e As EventArgs) Handles lblUsernameHelp.Click
        MsgBox("Only Accepts 20 characters including spaces.", MsgBoxStyle.Information, "Username")
    End Sub

    Private Sub lblPasswordHelp_Click(sender As Object, e As EventArgs) Handles lblPasswordHelp.Click
        MsgBox("Only Accepts 20 characters including spaces.", MsgBoxStyle.Information, "Password")
    End Sub

    Private Sub GreetUser()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=info"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM accounts WHERE id = 1"
            Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader

            While READER.Read
                Label5.Text = READER.GetString("firstName").ToString & vbCrLf _
                    & READER.GetString("surname") & "!"
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


End Class