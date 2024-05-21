<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnFeedbacks = New System.Windows.Forms.Button()
        Me.txtClientFullName = New System.Windows.Forms.TextBox()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRentaCar = New System.Windows.Forms.Button()
        Me.btnReportCarIssues = New System.Windows.Forms.Button()
        Me.btnSystemInformation = New System.Windows.Forms.Button()
        Me.txtBankID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewsDataSet = New CarRentalSystem.ViewsDataSet()
        Me.BankBalanceTableAdapter = New CarRentalSystem.ViewsDataSetTableAdapters.BankBalanceTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLogOut.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(460, 254)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(290, 66)
        Me.btnLogOut.TabIndex = 23
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnFeedbacks
        '
        Me.btnFeedbacks.BackColor = System.Drawing.Color.DarkBlue
        Me.btnFeedbacks.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedbacks.ForeColor = System.Drawing.Color.White
        Me.btnFeedbacks.Location = New System.Drawing.Point(242, 254)
        Me.btnFeedbacks.Name = "btnFeedbacks"
        Me.btnFeedbacks.Size = New System.Drawing.Size(169, 66)
        Me.btnFeedbacks.TabIndex = 22
        Me.btnFeedbacks.Text = "Feedbacks"
        Me.btnFeedbacks.UseVisualStyleBackColor = False
        '
        'txtClientFullName
        '
        Me.txtClientFullName.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientFullName.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtClientFullName.Location = New System.Drawing.Point(550, 148)
        Me.txtClientFullName.Name = "txtClientFullName"
        Me.txtClientFullName.Size = New System.Drawing.Size(213, 30)
        Me.txtClientFullName.TabIndex = 21
        '
        'txtClientID
        '
        Me.txtClientID.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientID.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtClientID.Location = New System.Drawing.Point(550, 105)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(213, 30)
        Me.txtClientID.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(431, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(445, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Client ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(531, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 39)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Client View"
        '
        'btnRentaCar
        '
        Me.btnRentaCar.BackColor = System.Drawing.Color.DarkBlue
        Me.btnRentaCar.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRentaCar.ForeColor = System.Drawing.Color.White
        Me.btnRentaCar.Location = New System.Drawing.Point(40, 154)
        Me.btnRentaCar.Name = "btnRentaCar"
        Me.btnRentaCar.Size = New System.Drawing.Size(371, 66)
        Me.btnRentaCar.TabIndex = 15
        Me.btnRentaCar.Text = "Rent a Car"
        Me.btnRentaCar.UseVisualStyleBackColor = False
        '
        'btnReportCarIssues
        '
        Me.btnReportCarIssues.BackColor = System.Drawing.Color.DarkBlue
        Me.btnReportCarIssues.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportCarIssues.ForeColor = System.Drawing.Color.White
        Me.btnReportCarIssues.Location = New System.Drawing.Point(40, 254)
        Me.btnReportCarIssues.Name = "btnReportCarIssues"
        Me.btnReportCarIssues.Size = New System.Drawing.Size(169, 66)
        Me.btnReportCarIssues.TabIndex = 13
        Me.btnReportCarIssues.Text = "Report Car Issues"
        Me.btnReportCarIssues.UseVisualStyleBackColor = False
        '
        'btnSystemInformation
        '
        Me.btnSystemInformation.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSystemInformation.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemInformation.ForeColor = System.Drawing.Color.White
        Me.btnSystemInformation.Location = New System.Drawing.Point(40, 58)
        Me.btnSystemInformation.Name = "btnSystemInformation"
        Me.btnSystemInformation.Size = New System.Drawing.Size(371, 66)
        Me.btnSystemInformation.TabIndex = 12
        Me.btnSystemInformation.Text = "Who are we?"
        Me.btnSystemInformation.UseVisualStyleBackColor = False
        '
        'txtBankID
        '
        Me.txtBankID.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankID.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtBankID.Location = New System.Drawing.Point(550, 190)
        Me.txtBankID.Name = "txtBankID"
        Me.txtBankID.Size = New System.Drawing.Size(213, 30)
        Me.txtBankID.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(452, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Bank ID:"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "BankBalance"
        Me.BindingSource1.DataSource = Me.ViewsDataSet
        '
        'ViewsDataSet
        '
        Me.ViewsDataSet.DataSetName = "ViewsDataSet"
        Me.ViewsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BankBalanceTableAdapter
        '
        Me.BankBalanceTableAdapter.ClearBeforeFill = True
        '
        'ClientMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.txtBankID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnFeedbacks)
        Me.Controls.Add(Me.txtClientFullName)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRentaCar)
        Me.Controls.Add(Me.btnReportCarIssues)
        Me.Controls.Add(Me.btnSystemInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientMenu"
        Me.Text = "ClientMenu"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnFeedbacks As Button
    Friend WithEvents txtClientFullName As TextBox
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRentaCar As Button
    Friend WithEvents btnReportCarIssues As Button
    Friend WithEvents btnSystemInformation As Button
    Friend WithEvents txtBankID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ViewsDataSet As ViewsDataSet
    Friend WithEvents BankBalanceTableAdapter As ViewsDataSetTableAdapters.BankBalanceTableAdapter
End Class
