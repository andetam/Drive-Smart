Imports System.IO
Public Class CheckOut

    Dim total, newBalance, balance As Double
    Dim flag As Boolean
    Dim write As StreamWriter
    Dim read As StreamReader
    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBankID.Text = LogIn.this_client_user.BankID
        txtClientFullName.Text = LogIn.this_client_user.FullName
        txtClientID.Text = LogIn.this_client_user.ID

        txtCarID.Text = Category.my_carID
        NameCar.Text = Category.Get_CarName(Category.my_carID)
        AM.Text = Category.Get_AM(Category.my_carID)
        Price.Text = Category.Get_Price(Category.my_carID)
        Manufactured.Text = Category.Get_ManufactureYear(Category.my_carID)
        Engine.Text = Category.Get_Engine(Category.my_carID)

        total = Price.Text
    End Sub

    Private Sub btnBankBalanceCheck_Click(sender As Object, e As EventArgs) Handles btnBankBalanceCheck.Click

        DB_Balance(balance)
        New_Balance(newBalance, total, balance)


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If flag Then
            If File.Exists("NewBalance.txt") = False Then
                write = File.CreateText("NewBalance.txt")
                write.WriteLine(LogIn.this_client_user.ID & " " & balance)
                write.Close()

            Else
                write = File.AppendText("NewBalance.txt")
                write.WriteLine(LogIn.this_client_user.ID & " " & balance)
                write.Close()

            End If

            If File.Exists("OccupiedCar.txt") = False Then
                write = File.CreateText("OccupiedCar.txt")
                write.WriteLine(Category.my_carID)
                write.Close()

            Else
                write = File.AppendText("OccupiedCar.txt")
                write.WriteLine(Category.my_carID)
                write.Close()

            End If
            MessageBox.Show("Car is rented successfully!", "Warning!")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ClientMenu.Show()
    End Sub

    Sub New_Balance(ByRef newBalance As Double, total As Integer, balance As Integer)
        If balance > total Then
            flag = True
            newBalance = balance - total
            MessageBox.Show("You have enough balance!", "Attention!")
        Else
            MessageBox.Show("You do not have enough balance!", "Attention!")
        End If
    End Sub

    Sub DB_Balance(ByRef balance As Double)
        If File.Exists("NewBalance.txt") = False Then
            Dim query = From bal In ClientMenu.ViewsDataSet.BankBalance
                        Where bal.BankID = LogIn.this_client_user.BankID
                        Select bal.BankBalance

            Dim result() As Integer = query.ToArray
            balance = result(0)
        Else
            Dim ids() As String = File.ReadAllLines("NewBalance.txt")
            For i As Integer = 0 To ids.Count - 1
                If LogIn.this_client_user.ID = ids(i).Substring(0, ids(i).IndexOf(" ")) Then
                    balance = ids(i).Substring(ids(i).IndexOf(" ") + 1)
                Else
                    Dim query = From bal In ClientMenu.ViewsDataSet.BankBalance
                                Where bal.BankID = LogIn.this_client_user.BankID
                                Select bal.BankBalance

                    Dim result() As Integer = query.ToArray
                    balance = result(0)
                End If
            Next
        End If


    End Sub


End Class