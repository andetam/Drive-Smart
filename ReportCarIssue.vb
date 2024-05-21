Imports System.IO
Public Class ReportCarIssue
    Dim write As StreamWriter
    Dim cID As String
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        cID = txtCarID.Text
        If File.Exists("CarProblems.txt") = False Then
            write = File.CreateText("CarProblems.txt")
            write.WriteLine(cID)
            write.Close()

        Else
            write = File.AppendText("CarProblems.txt")
            write.WriteLine(cID)
            write.Close()

        End If

        MessageBox.Show("Car problem recorded successfully!", "Attention!")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ClientMenu.Show()
    End Sub
End Class