Imports System.Security.Cryptography

Public Class ShowCars
    Private Sub ShowCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cars_query = From car In ManageCars.ViewsDataSet.Cars
                         Let formats = car.PricePerDay.ToString("C2")
                         Select car.CarID, car.Category, car._A_M, car.CarName,
                                formats, car.ManufactureYear, car.Engine

        DataGridViewCars.DataSource = cars_query.ToList
        DataGridViewCars.CurrentCell = Nothing
        DataGridViewCars.Columns("CarID").HeaderText = "Car ID"
        DataGridViewCars.Columns("Category").HeaderText = "Category"
        DataGridViewCars.Columns("_A_M").HeaderText = "Automatic/Manual"
        DataGridViewCars.Columns("CarName").HeaderText = "Car's Name"
        DataGridViewCars.Columns("formats").HeaderText = "Price Per Day in $"
        DataGridViewCars.Columns("ManufactureYear").HeaderText = "Manufacture Year"
        DataGridViewCars.Columns("Engine").HeaderText = "Engine"

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMenu.Show()
    End Sub
End Class