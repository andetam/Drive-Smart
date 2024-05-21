Public Class ClientMenu
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        LogIn.Show()
    End Sub

    Private Sub ClientMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewsDataSet.BankBalance' table. You can move, or remove it, as needed.
        Me.BankBalanceTableAdapter.Fill(Me.ViewsDataSet.BankBalance)

        txtBankID.Text = LogIn.this_client_user.BankID
        txtClientFullName.Text = LogIn.this_client_user.FullName
        txtClientID.Text = LogIn.this_client_user.ID
    End Sub

    Private Sub btnFeedbacks_Click(sender As Object, e As EventArgs) Handles btnFeedbacks.Click
        FeedBacks.ShowDialog()
    End Sub

    Private Sub btnSystemInformation_Click(sender As Object, e As EventArgs) Handles btnSystemInformation.Click
        SystemInformation.ShowDialog()
    End Sub

    Private Sub btnRentaCar_Click(sender As Object, e As EventArgs) Handles btnRentaCar.Click
        Category.ShowDialog()
    End Sub

    Private Sub btnReportCarIssues_Click(sender As Object, e As EventArgs) Handles btnReportCarIssues.Click
        ReportCarIssue.ShowDialog()
    End Sub

End Class