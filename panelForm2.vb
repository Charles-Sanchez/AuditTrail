Imports System.IO
Imports MySql.Data.MySqlClient
Public Class panelForm2
    Private Sub lblExpenditureHelp_Click(sender As Object, e As EventArgs) Handles lblExpenditureHelp.Click
        MsgBox("Only Accepts 20 characters including spaces.", MsgBoxStyle.Information, "Expenditure")

    End Sub

    Private Sub lblAmountHelp_Click(sender As Object, e As EventArgs) Handles lblAmountHelp.Click
        MsgBox("Only accepts integer value." & vbCrLf & "No comma and spaces.", MsgBoxStyle.Information, "Amount")
    End Sub

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim remainingBal As String
    Dim totalExp As String
    Dim totaloutwardexp As String
    Dim totalinwardexp As String
    Dim cashFlowInward As String
    Dim cashFlowOutward As String
    Dim proj_key As String = panelForm1.Tbx_ProjCode_Read.Text

    Public Sub panelForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim categorySet As New HashSet(Of String)()
        Dim moneyFlowSet As New HashSet(Of String)()
        projName.Text = panelForm1.Tbx_ProjName_Write.Text
        categorySet.Add("material")
        categorySet.Add("labor")
        moneyFlowSet.Add("inward")
        moneyFlowSet.Add("outward")

        Categories.Items.AddRange(categorySet.ToArray())
        MoneyFlow.Items.AddRange(moneyFlowSet.ToArray())
        BalanceCheck()
    End Sub
    Private Sub BalanceCheck()
        UpdateTable()
        CalculateBalance()
        CalculateTotalExpenses()
        CalculateTotalInwardExpenses()
        CalculateTotalOutwardExpenses()
        LoadChart()
        Tbx_RemainingBudget.Text = remainingBal
        Tbx_TotalOutward.Text = totalExp
        Tbx_TotalOutward.Text = totaloutwardexp
        Tbx_InwardExp.Text = totalinwardexp
    End Sub

    Private Sub UpdateTable()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from projects." & panelForm1.Tbx_ProjCode_Read.Text
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            GunaDataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

            GunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("No Project Selected From The Directory")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CalculateBalance()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT " _
                & "(SELECT Budget from info.directories WHERE CONCAT(year, proj_id) =" _
                & "'" & panelForm1.Tbx_ProjCode_Read.Text & "') -" _
                & "(SUM(CASE WHEN cash_flow = 'outward' THEN projects.`" & panelForm1.Tbx_ProjCode_Read.Text _
                & "`" & ".amount ELSE 0 END) -" _
                & "SUM(CASE WHEN cash_flow = 'inward' THEN projects.`" & panelForm1.Tbx_ProjCode_Read.Text _
                & "`.amount ELSE 0 END))" _
                & "FROM projects." & "`" & panelForm1.Tbx_ProjCode_Read.Text & "`"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim result As Object

            result = COMMAND.ExecuteScalar
            If Not IsDBNull(result) AndAlso Convert.ToDouble(result) < 0 Then
                MessageBox.Show("Client's expenses exceeded the original budget!")
            ElseIf Not IsDBNull(result) AndAlso Convert.ToDouble(result) = 0.0 Then
                MessageBox.Show("Client's expenses spent the whole original budget")
            End If
            remainingBal = If(result IsNot DBNull.Value, result.ToString(), panelForm1.Tbx_Budget.Text)
        Catch ex As Exception
            MessageBox.Show("Project Budget Is Not Selected From The Directory")
        Finally
            UpdateTable()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ResetForms()
        Tbx_TimeRecord.Text = ""
        Tbx_Amount.Text = ""
        Tbx_Expenditure.Text = ""
        Tbx_TimeRecord.Text = ""
        Categories.Text = "Categories"
        MoneyFlow.Text = "Money Flow"
    End Sub

    Private Sub CalculateTotalExpenses()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT " _
                & "SUM(CASE WHEN cash_flow = 'outward' THEN projects.`" & panelForm1.Tbx_ProjCode_Read.Text _
                & "`" & ".amount ELSE 0 END) -" _
                & "SUM(CASE WHEN cash_flow = 'inward' THEN projects.`" & panelForm1.Tbx_ProjCode_Read.Text _
                & "`.amount ELSE 0 END)" _
                & "FROM projects." & "`" & panelForm1.Tbx_ProjCode_Read.Text & "`"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim result As Object
            result = COMMAND.ExecuteScalar
            totalExp = If(result IsNot DBNull.Value, result.ToString(), panelForm1.Tbx_Budget.Text)
        Catch ex As Exception
            MessageBox.Show("Can't Calculate Total Expenses Since No Project Selected From The Directory")
        Finally
            UpdateTable()
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub CalculateTotalInwardExpenses()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT COALESCE(SUM(CASE WHEN cash_flow = 'inward' THEN projects.`" & panelForm1.Tbx_ProjCode_Read.Text _
                  & "`" & ".amount ELSE 0 END), 0) " _
                  & "FROM projects." & "`" & panelForm1.Tbx_ProjCode_Read.Text & "`"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim res As Object
            res = COMMAND.ExecuteScalar
            totalinwardexp = If(res IsNot DBNull.Value, res.ToString(), panelForm1.Tbx_Budget.Text)
        Catch ex As Exception
            MessageBox.Show("Can't Calculate Total Inward Expenses Since No Project Selected From The Directory")
        Finally
            UpdateTable()
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub CalculateTotalOutwardExpenses()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT COALESCE(SUM(CASE WHEN cash_flow = 'outward' THEN projects.`" & panelForm1.Tbx_ProjCode_Read.Text _
                  & "`" & ".amount ELSE 0 END), 0) " _
                  & "FROM projects." & "`" & panelForm1.Tbx_ProjCode_Read.Text & "`"


            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim result As Object
            result = COMMAND.ExecuteScalar
            totaloutwardexp = If(result IsNot DBNull.Value, result.ToString(), panelForm1.Tbx_Budget.Text)
        Catch ex As Exception
            MessageBox.Show("Can't Calculate Total Outward Expenses Since No Project Selected From The Directory")
        Finally
            UpdateTable()
            MysqlConn.Dispose()
        End Try
    End Sub



    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "DELETE FROM projects.`" & panelForm1.Tbx_ProjCode_Read.Text & "` " _
                & "WHERE record_time = STR_TO_DATE('" & Tbx_TimeRecord.Text & "', '%m/%d/%Y %H:%i:%s')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.ExecuteNonQuery()
            MessageBox.Show("Entry Deleted Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            BalanceCheck()
            ResetForms()
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub LoadChart()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SUM(CASE WHEN cash_flow = 'inward' THEN projects.`" & panelForm1.Tbx_ProjCode_Read.Text _
                & "`.amount ELSE 0 END) AS inward, SUM(CASE WHEN cash_flow = 'outward' THEN projects.`" _
                & panelForm1.Tbx_ProjCode_Read.Text & "`.amount ELSE 0 END) AS outward, " _
                & "info.`directories`.Budget " _
                & "FROM projects.`" & panelForm1.Tbx_ProjCode_Read.Text & "`" _
                & " CROSS JOIN info.`directories` WHERE CONCAT(info.`directories`.year, info.`directories`.proj_id) = '" _
                & panelForm1.Tbx_ProjCode_Read.Text & "' GROUP BY info.`directories`.Budget"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            ExpensesChart.Series("CashFlow").Points.Clear()
            While READER.Read
                ExpensesChart.Series("CashFlow").Points.AddXY("Original Budget", READER.GetDouble("Budget"))
                ExpensesChart.Series("CashFlow").Points.AddXY("Outward", READER.GetDouble("outward"))
                ExpensesChart.Series("CashFlow").Points.AddXY("Inward", READER.GetDouble("inward"))
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Can't Load Chart Since No Project Is Selected From The Directory")
            ExpensesChart.Series("CashFlow").Points.Clear()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GunaDataGridView1.Rows(e.RowIndex)

            Tbx_TimeRecord.Text = row.Cells("record_time").Value.ToString
            Categories.Text = row.Cells("category").Value.ToString
            MoneyFlow.Text = row.Cells("cash_flow").Value.ToString
            Tbx_Expenditure.Text = row.Cells("expenditure").Value.ToString
            Tbx_Amount.Text = row.Cells("amount").Value.ToString
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "UPDATE projects.`" & panelForm1.Tbx_ProjCode_Read.Text & "` " _
                & "SET expenditure = '" & Tbx_Expenditure.Text & "', " _
                & "amount = '" & Tbx_Amount.Text & "', " _
                & "category = '" & Categories.Text & "', " _
                & "cash_flow = '" & MoneyFlow.Text & "' " _
                & " WHERE record_time = STR_TO_DATE('" & Tbx_TimeRecord.Text & "', '%m/%d/%Y %H:%i:%s')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.ExecuteNonQuery()
            MessageBox.Show("Entry Updated Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            BalanceCheck()
            ResetForms()
            MysqlConn.Dispose()
        End Try

    End Sub


    Private Sub Btn_Insert_Click(sender As Object, e As EventArgs) Handles Btn_Insert.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=projects"

        Try
            MysqlConn.Open()
            Dim query As String

            query = "insert into projects." & "`" & panelForm1.Tbx_ProjCode_Read.Text & "`" & "(record_time, expenditure, category, amount, cash_flow) " _
                & "values (now(), '" & Tbx_Expenditure.Text & "', " & "'" & Categories.Text & "', " _
                & "'" & Tbx_Amount.Text & "', '" & MoneyFlow.Text & "')"

            COMMAND = New MySqlCommand(query, MysqlConn)
            COMMAND.ExecuteNonQuery()
            MessageBox.Show("entry added successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            BalanceCheck()
            ResetForms()
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub projName_Click(sender As Object, e As EventArgs) Handles projName.Click
        ' projName.Text = 
    End Sub

    Private Sub Tbx_RemainingBudget_TextChanged(sender As Object, e As EventArgs) Handles Tbx_RemainingBudget.TextChanged

    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Tbx_TotalOutward_TextChanged(sender As Object, e As EventArgs) Handles Tbx_TotalOutward.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

End Class