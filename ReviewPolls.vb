Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Public Class ReviewPolls
    Sub ShowReviewsPieChart()
        Dim clients_feedback() As String = File.ReadAllLines("ClientFeedback.txt")
        Dim ratings(clients_feedback.Count - 1) As Integer
        Dim rate0, rate1, rate2, rate3, rate4, rate5, rate6, rate7, rate8, rate9, rate10 As Integer

        For i As Integer = 0 To clients_feedback.Count - 1
            ratings(i) = clients_feedback(i).Substring(clients_feedback(i).IndexOf(":") + 1)
        Next

        For i As Integer = 0 To ratings.Count - 1
            If ratings(i) = 0 Then
                rate0 += 1
            ElseIf ratings(i) = 1 Then
                rate1 += 1
            ElseIf ratings(i) = 2 Then
                rate2 += 1
            ElseIf ratings(i) = 3 Then
                rate3 += 1
            ElseIf ratings(i) = 4 Then
                rate4 += 1
            ElseIf ratings(i) = 5 Then
                rate5 += 1
            ElseIf ratings(i) = 6 Then
                rate6 += 1
            ElseIf ratings(i) = 7 Then
                rate7 += 1
            ElseIf ratings(i) = 8 Then
                rate8 += 1
            ElseIf ratings(i) = 9 Then
                rate9 += 1
            ElseIf ratings(i) = 10 Then
                rate10 += 1
            End If
        Next

        Dim ratings_results() As Double = {rate1, rate2, rate3, rate4, rate5, rate6, rate7, rate8, rate9, rate10}
        Dim percentage(ratings_results.Count - 1) As Decimal
        Dim names() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"}
        Dim quantitiesTotal As Decimal = 0
        Dim sweepAnglesTotal As Decimal = 0
        Dim my_brushes() As Brush = {Brushes.DarkRed, Brushes.Red, Brushes.DarkOrange, Brushes.Orange, Brushes.SandyBrown,
            Brushes.Yellow, Brushes.Khaki, Brushes.LightGreen, Brushes.LawnGreen, Brushes.ForestGreen,
            Brushes.DarkGreen}
        Dim element As Graphics = PictureBoxReviewsPieChart.CreateGraphics
        Dim radius As Integer = 100
        Dim centreW As Integer = 105
        Dim centreH As Integer = 155
        For i As Integer = 0 To ratings_results.Count - 1
            quantitiesTotal += ratings_results(i)
        Next

        For i As Integer = 0 To ratings_results.Count - 1
            percentage(i) = ratings_results(i) / quantitiesTotal
        Next

        For i As Integer = 0 To ratings_results.Count - 1
            element.FillPie(my_brushes(i), centreW - radius, centreH - radius, 2 * radius, 2 * radius,
            sweepAnglesTotal, percentage(i) * 360)
            sweepAnglesTotal += CDec(percentage(i) * 360)
            element.FillRectangle(my_brushes(i), 220, 20 + 30 * i, 20, 20)
            element.DrawString(names(i), Me.Font, Brushes.Black, 250, 22 + 30 * i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowPieChart.Click
        ShowReviewsPieChart()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMenu.Show()
    End Sub
End Class