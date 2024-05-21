Imports System.ComponentModel
Imports System.IO
Public Class Category
    Public my_carID As String
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCarID11.Text = "C_1"
        Name11.Text = Get_CarName("C_1")
        AM11.Text = Get_AM("C_1")
        Price11.Text = Get_Price("C_1")
        Manufactured11.Text = Get_ManufactureYear("C_1")
        Engine11.Text = Get_Engine("C_1")

        txtCarID12.Text = "C_2"
        Name12.Text = Get_CarName("C_2")
        AM12.Text = Get_AM("C_2")
        Price12.Text = Get_Price("C_2")
        Manufactured12.Text = Get_ManufactureYear("C_2")
        Engine12.Text = Get_Engine("C_2")

        txtCarID13.Text = "C_8"
        Name13.Text = Get_CarName("C_8")
        AM13.Text = Get_AM("C_8")
        Price13.Text = Get_Price("C_8")
        Manufactured13.Text = Get_ManufactureYear("C_8")
        Engine13.Text = Get_Engine("C_8")

        txtCarID21.Text = "C_3"
        Name21.Text = Get_CarName("C_3")
        AM21.Text = Get_AM("C_3")
        Price21.Text = Get_Price("C_3")
        Manufactured21.Text = Get_ManufactureYear("C_3")
        Engine21.Text = Get_Engine("C_3")

        txtCarID22.Text = "C_5"
        Name22.Text = Get_CarName("C_5")
        AM22.Text = Get_AM("C_5")
        Price22.Text = Get_Price("C_5")
        Manufactured22.Text = Get_ManufactureYear("C_5")
        Engine22.Text = Get_Engine("C_5")

        txtCarID23.Text = "C_6"
        Name23.Text = Get_CarName("C_6")
        AM23.Text = Get_AM("C_6")
        Price23.Text = Get_Price("C_6")
        Manufactured23.Text = Get_ManufactureYear("C_6")
        Engine23.Text = Get_Engine("C_6")

        txtCarID31.Text = "C_4"
        Name31.Text = Get_CarName("C_4")
        AM31.Text = Get_AM("C_4")
        Price31.Text = Get_Price("C_4")
        Manufactured31.Text = Get_ManufactureYear("C_4")
        Engine31.Text = Get_Engine("C_4")

        txtCarID32.Text = "C_7"
        Name32.Text = Get_CarName("C_7")
        AM32.Text = Get_AM("C_7")
        Price32.Text = Get_Price("C_7")
        Manufactured32.Text = Get_ManufactureYear("C_7")
        Engine32.Text = Get_Engine("C_7")

        txtCarID33.Text = "C_9"
        Name33.Text = Get_CarName("C_9")
        AM33.Text = Get_AM("C_9")
        Price33.Text = Get_Price("C_9")
        Manufactured33.Text = Get_ManufactureYear("C_9")
        Engine33.Text = Get_Engine("C_9")



    End Sub

    Function Get_CarName(id As String) As String
        Dim query = From car In ManageCars.ViewsDataSet.Cars
                    Where car.CarID = id
                    Select car.CarName

        Dim queryResult() As String = query.ToArray
        Return queryResult(0)
    End Function

    Function Get_AM(id As String) As String
        Dim query = From car In ManageCars.ViewsDataSet.Cars
                    Where car.CarID = id
                    Select car._A_M

        Dim queryResult() As String = query.ToArray
        Return queryResult(0)
    End Function

    Function Get_Price(id As String) As Double
        Dim query = From car In ManageCars.ViewsDataSet.Cars
                    Where car.CarID = id
                    Select car.PricePerDay

        Dim queryResult() As Integer = query.ToArray
        Return queryResult(0)
    End Function

    Function Get_ManufactureYear(id As String) As Date
        Dim query = From car In ManageCars.ViewsDataSet.Cars
                    Where car.CarID = id
                    Select car.ManufactureYear

        Dim queryResult() As Date = query.ToArray
        Return queryResult(0)
    End Function

    Function Get_Engine(id As String) As String
        Dim query = From car In ManageCars.ViewsDataSet.Cars
                    Where car.CarID = id
                    Select car.Engine

        Dim queryResult() As String = query.ToArray
        Return queryResult(0)
    End Function

    Private Sub btnGetCarL1_Click(sender As Object, e As EventArgs) Handles btnGetCarL1.Click
        my_carID = "C_1"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If

    End Sub

    Private Sub btnGetCarL2_Click(sender As Object, e As EventArgs) Handles btnGetCarL2.Click
        my_carID = "C_2"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnGetCarL3_Click(sender As Object, e As EventArgs) Handles btnGetCarL3.Click
        my_carID = "C_8"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnGetCarC1_Click(sender As Object, e As EventArgs) Handles btnGetCarC1.Click
        my_carID = "C_3"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnGetCarC2_Click(sender As Object, e As EventArgs) Handles btnGetCarC2.Click
        my_carID = "C_5"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnGetCarC3_Click(sender As Object, e As EventArgs) Handles btnGetCarC3.Click
        my_carID = "C_6"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnGetCarE1_Click(sender As Object, e As EventArgs) Handles btnGetCarE1.Click
        my_carID = "C_4"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnGetCarE2_Click(sender As Object, e As EventArgs) Handles btnGetCarE2.Click
        my_carID = "C_7"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnGetCarE3_Click(sender As Object, e As EventArgs) Handles btnGetCarE3.Click
        my_carID = "C_9"
        If CheckCarAvailAbility(my_carID) Then
            MessageBox.Show("Unfortunately this car is occupied!", "Warning")
        Else
            CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ClientMenu.Show()
    End Sub

    Function CheckCarAvailAbility(id As String) As Boolean
        Dim flag As Boolean
        If File.Exists("OccupiedCar.txt") Then
            Dim OccupCarID() As String = File.ReadAllLines("OccupiedCar.txt")
            For i As Integer = 0 To OccupCarID.Count - 1
                If id = OccupCarID(i) Then
                    flag = True
                End If
            Next
        Else
            flag = False
        End If


        Return flag
    End Function

End Class