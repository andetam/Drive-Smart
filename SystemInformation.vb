Public Class SystemInformation
    Private Sub SystemInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = "CarRENT"
        txtExperience.Text = "Since 2001"
        txtLocation.Text = "Rruga Komuna e Parisit 1/3, 1001, Tirana"
        txtMotto.Text = "Your Trip, Your Way."
        txtOffers.Text = "We serve people who require a temporary vehicle at affordable daily prices."
        txtContactInfoPhone.Text = "(AL) +355 69 90 90 900"
        txtContactInfoEmail.Text = "frontdesk@carrent.com"

        ListBoxMainFunctions.Items.Clear()
        ListBoxMainFunctions.Items.Add("Log in / Log Out")
        ListBoxMainFunctions.Items.Add("Immediately see your credentials displayed in the Main Menu after logging-in.")
        ListBoxMainFunctions.Items.Add("Get to know us more by pressing 'SystemInformation' button in the Main Menu.")
        ListBoxMainFunctions.Items.Add("Rent a car according to your preferences by pressing 'Rent a Car' button in the Main Menu.")
        ListBoxMainFunctions.Items.Add("See your bank balance by pressing 'Show Bank Balance' button in the Main Menu.")
        ListBoxMainFunctions.Items.Add("Report any issue you encounter with your rented car by pressing 'Report Car Issues' button in the Main Menu.")
        ListBoxMainFunctions.Items.Add("Give feedbacks for your experience by pressing 'Feedbacks' button in the Main Menu.")

    End Sub

    Private Sub LinkLabelWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelWebsite.LinkClicked
        Process.Start("https://rentpoint.al/")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ClientMenu.Show()
    End Sub
End Class