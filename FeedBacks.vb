Imports System.IO
Public Class FeedBacks
    Dim user_feedback As Integer
    Dim write As StreamWriter
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If RadioButton0.Checked Then
            user_feedback = 0
        ElseIf RadioButton1.Checked Then
            user_feedback = 1
        ElseIf RadioButton2.Checked Then
            user_feedback = 2
        ElseIf RadioButton3.Checked Then
            user_feedback = 3
        ElseIf RadioButton4.Checked Then
            user_feedback = 4
        ElseIf RadioButton5.Checked Then
            user_feedback = 5
        ElseIf RadioButton6.Checked Then
            user_feedback = 6
        ElseIf RadioButton7.Checked Then
            user_feedback = 7
        ElseIf RadioButton8.Checked Then
            user_feedback = 8
        ElseIf RadioButton9.Checked Then
            user_feedback = 9
        ElseIf RadioButton10.Checked Then
            user_feedback = 10
        End If

        If File.Exists("ClientFeedback.txt") = False Then
            write = File.CreateText("ClientFeedback.txt")
            write.WriteLine(LogIn.this_client_user.ID & " Ratings:" & user_feedback)
            write.Close()

        Else
            write = File.AppendText("ClientFeedback.txt")
            write.WriteLine(LogIn.this_client_user.ID & " Ratings:" & user_feedback)
            write.Close()

        End If
        MessageBox.Show("Feedback was submitted successfully!", "Warning!")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ClientMenu.Show()
    End Sub
End Class