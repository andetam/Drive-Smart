<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnManageClients = New System.Windows.Forms.Button()
        Me.btnReviewPolls = New System.Windows.Forms.Button()
        Me.btnShowCars = New System.Windows.Forms.Button()
        Me.btnManageCars = New System.Windows.Forms.Button()
        Me.btnViewClients = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdminID = New System.Windows.Forms.TextBox()
        Me.txtAdminFullName = New System.Windows.Forms.TextBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnManageCarsProblems = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManageClients
        '
        Me.btnManageClients.BackColor = System.Drawing.Color.DarkBlue
        Me.btnManageClients.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageClients.ForeColor = System.Drawing.Color.White
        Me.btnManageClients.Location = New System.Drawing.Point(44, 35)
        Me.btnManageClients.Name = "btnManageClients"
        Me.btnManageClients.Size = New System.Drawing.Size(169, 66)
        Me.btnManageClients.TabIndex = 0
        Me.btnManageClients.Text = "Manage Clients"
        Me.btnManageClients.UseVisualStyleBackColor = False
        '
        'btnReviewPolls
        '
        Me.btnReviewPolls.BackColor = System.Drawing.Color.DarkBlue
        Me.btnReviewPolls.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReviewPolls.ForeColor = System.Drawing.Color.White
        Me.btnReviewPolls.Location = New System.Drawing.Point(44, 231)
        Me.btnReviewPolls.Name = "btnReviewPolls"
        Me.btnReviewPolls.Size = New System.Drawing.Size(169, 66)
        Me.btnReviewPolls.TabIndex = 1
        Me.btnReviewPolls.Text = "Review Polls"
        Me.btnReviewPolls.UseVisualStyleBackColor = False
        '
        'btnShowCars
        '
        Me.btnShowCars.BackColor = System.Drawing.Color.DarkBlue
        Me.btnShowCars.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowCars.ForeColor = System.Drawing.Color.White
        Me.btnShowCars.Location = New System.Drawing.Point(246, 131)
        Me.btnShowCars.Name = "btnShowCars"
        Me.btnShowCars.Size = New System.Drawing.Size(169, 66)
        Me.btnShowCars.TabIndex = 2
        Me.btnShowCars.Text = "Show Cars"
        Me.btnShowCars.UseVisualStyleBackColor = False
        '
        'btnManageCars
        '
        Me.btnManageCars.BackColor = System.Drawing.Color.DarkBlue
        Me.btnManageCars.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageCars.ForeColor = System.Drawing.Color.White
        Me.btnManageCars.Location = New System.Drawing.Point(44, 131)
        Me.btnManageCars.Name = "btnManageCars"
        Me.btnManageCars.Size = New System.Drawing.Size(169, 66)
        Me.btnManageCars.TabIndex = 3
        Me.btnManageCars.Text = "Manage Cars"
        Me.btnManageCars.UseVisualStyleBackColor = False
        '
        'btnViewClients
        '
        Me.btnViewClients.BackColor = System.Drawing.Color.DarkBlue
        Me.btnViewClients.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewClients.ForeColor = System.Drawing.Color.White
        Me.btnViewClients.Location = New System.Drawing.Point(246, 36)
        Me.btnViewClients.Name = "btnViewClients"
        Me.btnViewClients.Size = New System.Drawing.Size(169, 66)
        Me.btnViewClients.TabIndex = 4
        Me.btnViewClients.Text = "Show Clients"
        Me.btnViewClients.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(518, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Admin View"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(447, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Admin ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(437, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Full Name:"
        '
        'txtAdminID
        '
        Me.txtAdminID.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminID.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtAdminID.Location = New System.Drawing.Point(551, 114)
        Me.txtAdminID.Name = "txtAdminID"
        Me.txtAdminID.Size = New System.Drawing.Size(213, 27)
        Me.txtAdminID.TabIndex = 8
        '
        'txtAdminFullName
        '
        Me.txtAdminFullName.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminFullName.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtAdminFullName.Location = New System.Drawing.Point(551, 163)
        Me.txtAdminFullName.Name = "txtAdminFullName"
        Me.txtAdminFullName.Size = New System.Drawing.Size(213, 27)
        Me.txtAdminFullName.TabIndex = 9
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLogOut.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(455, 231)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(292, 66)
        Me.btnLogOut.TabIndex = 10
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnManageCarsProblems
        '
        Me.btnManageCarsProblems.BackColor = System.Drawing.Color.DarkBlue
        Me.btnManageCarsProblems.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageCarsProblems.ForeColor = System.Drawing.Color.White
        Me.btnManageCarsProblems.Location = New System.Drawing.Point(246, 231)
        Me.btnManageCarsProblems.Name = "btnManageCarsProblems"
        Me.btnManageCarsProblems.Size = New System.Drawing.Size(169, 66)
        Me.btnManageCarsProblems.TabIndex = 11
        Me.btnManageCarsProblems.Text = "Manage Cars' Problems"
        Me.btnManageCarsProblems.UseVisualStyleBackColor = False
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(800, 325)
        Me.Controls.Add(Me.btnManageCarsProblems)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.txtAdminFullName)
        Me.Controls.Add(Me.txtAdminID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewClients)
        Me.Controls.Add(Me.btnManageCars)
        Me.Controls.Add(Me.btnShowCars)
        Me.Controls.Add(Me.btnReviewPolls)
        Me.Controls.Add(Me.btnManageClients)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminMenu"
        Me.Text = "AdminMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManageClients As Button
    Friend WithEvents btnReviewPolls As Button
    Friend WithEvents btnShowCars As Button
    Friend WithEvents btnManageCars As Button
    Friend WithEvents btnViewClients As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdminID As TextBox
    Friend WithEvents txtAdminFullName As TextBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnManageCarsProblems As Button
End Class
