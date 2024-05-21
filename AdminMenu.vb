Public Class AdminMenu
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAdminID.Text = LogIn.this_admin_user.ID
        txtAdminFullName.Text = LogIn.this_admin_user.FullName
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        LogIn.Show()
    End Sub

    Private Sub btnManageClients_Click(sender As Object, e As EventArgs) Handles btnManageClients.Click
        ManageClients.ShowDialog()
    End Sub

    Private Sub btnViewClients_Click(sender As Object, e As EventArgs) Handles btnViewClients.Click
        ShowClients.ShowDialog()
    End Sub

    Private Sub btnManageCars_Click(sender As Object, e As EventArgs) Handles btnManageCars.Click
        ManageCars.ShowDialog()
    End Sub

    Private Sub btnShowCars_Click(sender As Object, e As EventArgs) Handles btnShowCars.Click
        ShowCars.ShowDialog()
    End Sub

    Private Sub btnReviewPolls_Click(sender As Object, e As EventArgs) Handles btnReviewPolls.Click
        ReviewPolls.ShowDialog()
    End Sub

    Private Sub btnManageCarsProblems_Click(sender As Object, e As EventArgs) Handles btnManageCarsProblems.Click
        ManageCarsProblems.ShowDialog()
    End Sub
End Class