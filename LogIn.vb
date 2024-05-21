Certainly! Here 's the fixed code with the modifications to handle the `IndexOutOfRangeException`:

```vb
Public Class LogIn

    'MessageBox.Show("ok")

    Dim terminateClientLogIn, terminateAdminLogIn As Integer
    Public this_admin_user As New SystemAdmin
    Public this_client_user As New Client

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewsDataSet.SystemAdmin' table. You can move, or remove it, as needed.
        Me.SystemAdminTableAdapter.Fill(Me.ViewsDataSet.SystemAdmin)

        RadioButtonClient.Checked = False
        RadioButtonSystemAdmin.Checked = False
    End Sub

    Private Sub btnCloseSystem_Click(sender As Object, e As EventArgs) Handles btnCloseSystem.Click
        Me.Close()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim credentialsRrrorMessage As String = "Credentials not found in the Database. Try again!"
        Dim errorTitle As String = "Warning!"
        Dim logInTypeError As String = "Log-in type was not specified!"
        Dim security As String = "Due to security measurements, this program will immediately terminate!"

        If RadioButtonClient.Checked Then
            If Validate_Client(txtUserID.Text) = txtPassword.Text Then
                this_client_user.ID = txtUserID.Text
                this_client_user.Password = txtPassword.Text
                this_client_user.FullName = Get_Client_First_Name(txtUserID.Text) & " " &
                    Get_Client_Last_Name(txtUserID.Text)
                this_client_user.BankID = Get_Client_Bank_ID(txtUserID.Text)
                ClientMenu.ShowDialog()
            Else
                terminateClientLogIn += 1
                MessageBox.Show(credentialsRrrorMessage, errorTitle)
            End If

        ElseIf RadioButtonSystemAdmin.Checked Then
            If Validate_Admin(txtUserID.Text) = txtPassword.Text Then
                this_admin_user.ID = txtUserID.Text
                this_admin_user.Password = txtPassword.Text
                this_admin_user.FullName = Get_Admin_First_Name(txtUserID.Text) & " " &
                    Get_Admin_Last_Name(txtUserID.Text)
                AdminMenu.ShowDialog()
            Else
                terminateAdminLogIn += 1
                MessageBox.Show(credentialsRrrorMessage, errorTitle)
            End If

        ElseIf RadioButtonSystemAdmin.Checked = False And RadioButtonClient.Checked Then
            MessageBox.Show(logInTypeError, errorTitle)
        End If

        If terminateAdminLogIn > 3 Or terminateClientLogIn > 3 Then
            MessageBox.Show(security, errorTitle)
            Me.Close()
        End If

        txtPassword.Clear()
        txtUserID.Clear()
    End Sub

    Function Validate_Admin(adminID As String) As String
        Dim query_password = From adm In ViewsDataSet.SystemAdmin
                             Where adm.AdminID = adminID
                             Select adm.AdminPassword

        Dim queryReturn() As String = query_password.ToArray
        If queryReturn.Length > 0 Then
            Return queryReturn(0)
        Else
            Return "" ' Or any default value you want to return when no result is found
        End If
    End Function

    Function Get_Admin_First_Name(adminID As String) As String
        Dim query_password = From adm In ViewsDataSet.SystemAdmin
                             Where adm.AdminID = adminID
                             Select adm.FirstName

        Dim queryReturn() As String = query_password.ToArray
        If queryReturn.Length > 0 Then
            Return queryReturn(0)
        Else
            Return "" ' Or any default value you want to return when no result is found
        End If
    End Function

    Function Get_Admin_Last_Name(adminID As String) As String
        Dim query_password = From adm In ViewsDataSet.SystemAdmin
                             Where adm.AdminID = adminID
                             Select adm.LastName

        Dim queryReturn() As String = query_password.ToArray
        If queryReturn.Length > 0 Then
            Return queryReturn(0)
        Else
            Return "" ' Or any default value you want to return when no result is found
        End If
    End Function

    Function Validate_Client(clientID As String) As String
        Dim query_password = From cli In ManageClients.ViewsDataSet.Client
                             Where cli.ClientID = clientID
                             Select cli.ClientPassword

        Dim queryReturn() As String = query_password.ToArray
        If queryReturn.Length > 0 Then
            Return queryReturn(0)
        Else
            Return "" ' Or any default value you want to return when no result is found
        End If
    End Function

    Function Get_Client_First_Name(clientID As String) As String
        Dim query_password = From cli In ManageClients.ViewsDataSet.Client
                             Where cli.ClientID = clientID
                             Select cli.FirstName

        Dim queryReturn() As String = query_password.ToArray
        If queryReturn.Length > 0 Then
            Return queryReturn(0)
        Else
            Return "" ' Or any default value you want to return when no result is found
        End If
    End Function

    Function Get_Client_Last_Name(clientID As String) As String
        Dim query_password = From cli In ManageClients.ViewsDataSet.Client
                             Where cli.ClientID = clientID
                             Select cli.LastName

        Dim queryReturn() As String = query_password.ToArray
        If queryReturn.Length > 0 Then
            Return queryReturn(0)
        Else
            Return "" ' Or any default value you want to return when no result is found
        End If
    End Function

    Function Get_Client_Bank_ID(clientID As String) As String
        Dim query_password = From cli In ManageClients.ViewsDataSet.Client
                             Where cli.ClientID = clientID
                             Select cli.BankID

        Dim queryReturn() As String = query_password.ToArray
        If queryReturn.Length > 0 Then
            Return queryReturn(0)
        Else
            Return "" ' Or any default value you want to return when no result is found
        End If
    End Function

End Class

Public Class SystemAdmin

    Private m_ID As String
    Private m_Password As String
    Private m_FullName As String

    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(value As String)
            m_Password = value
        End Set
    End Property

    Public Property FullName() As String
        Get
            Return m_FullName
        End Get
        Set(value As String)
            m_FullName = value
        End Set
    End Property

End Class

Public Class Client

    Private m_ID As String
    Private m_Password As String
    Private m_FullName As String
    Private m_BankID As String
    Private m_CarID As String

    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(value As String)
            m_Password = value
        End Set
   