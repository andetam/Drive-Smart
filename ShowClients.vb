Public Class ShowClients
    Private Sub ShowClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clients_query = From cli In ManageClients.ViewsDataSet.Client
                            Select cli.ClientID, cli.ClientPassword, cli.FirstName,
                                cli.LastName, cli.BankID

        DataGridViewClients.DataSource = clients_query.ToList
        DataGridViewClients.CurrentCell = Nothing
        DataGridViewClients.Columns("ClientID").HeaderText = "Client ID"
        DataGridViewClients.Columns("ClientPassword").HeaderText = "Client's Password"
        DataGridViewClients.Columns("FirstName").HeaderText = "First Name"
        DataGridViewClients.Columns("LastName").HeaderText = "Last Name"
        DataGridViewClients.Columns("BankID").HeaderText = "Bank ID"

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMenu.Show()
    End Sub
End Class