Imports CarRentalSystem.ViewsDataSetTableAdapters

Public Class ManageCars
    Private Sub ManageCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewsDataSet.Cars' table. You can move, or remove it, as needed.
        Me.CarsTableAdapter.Fill(Me.ViewsDataSet.Cars)

    End Sub

    Private Sub btnUpdateTable_Click(sender As Object, e As EventArgs) Handles btnUpdateTable.Click
        BindingSource1.EndEdit()
        CarsTableAdapter.Update(ViewsDataSet.Cars)
        MessageBox.Show("Table was updated successfully!", "Attention!")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMenu.Show()
    End Sub
End Class