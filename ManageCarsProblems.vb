Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class ManageCarsProblems
    Dim write As StreamWriter
    Dim read As StreamReader
    Dim current As String
    Dim problem As String
    Private Sub ManageCarsProblems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoxProblems.Items.Clear()
        If File.Exists("CarProblems.txt") Then
            read = File.OpenText("CarProblems.txt")
            Do Until read.EndOfStream
                current = read.ReadLine
                ListBoxProblems.Items.Add(current)
            Loop
            read.Close()
        Else
            MessageBox.Show("No car problems recorded yet!", "Warning!")
            Me.Close()
            AdminMenu.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminMenu.Show()
    End Sub

    Private Sub btnProblemCANNOTWait_Click(sender As Object, e As EventArgs) Handles btnProblemCANNOTWait.Click
        problem = CStr(ListBoxProblems.SelectedItem)

        If File.Exists("ProblemCannotWait.txt") = False Then
            write = File.CreateText("ProblemCannotWait.txt")
            write.WriteLine(problem)
            write.Close()
            ListBoxProblems.Items.Remove(problem)

        Else
            write = File.AppendText("ProblemCannotWait.txt")
            write.WriteLine(problem)
            write.Close()
            ListBoxProblems.Items.Remove(problem)

        End If
        MessageBox.Show("Problem was submitted successfully!", "Warning!")
    End Sub

    Private Sub btnProblemcanWait_Click(sender As Object, e As EventArgs) Handles btnProblemcanWait.Click
        problem = CStr(ListBoxProblems.SelectedItem)

        If File.Exists("ProblemCanWait.txt") = False Then
            write = File.CreateText("ProblemCanWait.txt")
            write.WriteLine(problem)
            write.Close()
            ListBoxProblems.Items.Remove(problem)

        Else
            write = File.AppendText("ProblemCanWait.txt")
            write.WriteLine(problem)
            write.Close()
            ListBoxProblems.Items.Remove(problem)

        End If
        MessageBox.Show("Problem was submitted successfully!", "Warning!")
    End Sub
End Class