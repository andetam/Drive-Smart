Public Class ManageClients
    Private Sub ManageClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewsDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.ViewsDataSet.Client)
        MessageBox.Show("Admin must NOT change any record's BankID field!", "Warning!")
    End Sub

    Private Sub btnUpdateTable_Click(sender As Object, e As EventArgs) Handles btnUpdateTable.Click
        BindingSource1.EndEdit()
        ClientTableAdapter.Update(ViewsDataSet.Client)
        MessageBox.Show("Table was updated successfully!", "Attention!")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMenu.Show()
    End Sub
End Class