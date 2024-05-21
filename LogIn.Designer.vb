<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonClient = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSystemAdmin = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnCloseSystem = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewsDataSet = New CarRentalSystem.ViewsDataSet()
        Me.SystemAdminTableAdapter = New CarRentalSystem.ViewsDataSetTableAdapters.SystemAdminTableAdapter()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(341, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log In"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonClient)
        Me.GroupBox1.Controls.Add(Me.RadioButtonSystemAdmin)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(43, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 133)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "I am a:"
        '
        'RadioButtonClient
        '
        Me.RadioButtonClient.AutoSize = True
        Me.RadioButtonClient.Location = New System.Drawing.Point(51, 82)
        Me.RadioButtonClient.Name = "RadioButtonClient"
        Me.RadioButtonClient.Size = New System.Drawing.Size(80, 27)
        Me.RadioButtonClient.TabIndex = 1
        Me.RadioButtonClient.TabStop = True
        Me.RadioButtonClient.Text = "Client"
        Me.RadioButtonClient.UseVisualStyleBackColor = True
        '
        'RadioButtonSystemAdmin
        '
        Me.RadioButtonSystemAdmin.AutoSize = True
        Me.RadioButtonSystemAdmin.Location = New System.Drawing.Point(51, 38)
        Me.RadioButtonSystemAdmin.Name = "RadioButtonSystemAdmin"
        Me.RadioButtonSystemAdmin.Size = New System.Drawing.Size(152, 27)
        Me.RadioButtonSystemAdmin.TabIndex = 0
        Me.RadioButtonSystemAdmin.TabStop = True
        Me.RadioButtonSystemAdmin.Text = "System Admin"
        Me.RadioButtonSystemAdmin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(416, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(398, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLogIn.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Location = New System.Drawing.Point(122, 287)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(233, 66)
        Me.btnLogIn.TabIndex = 4
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnCloseSystem
        '
        Me.btnCloseSystem.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCloseSystem.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseSystem.ForeColor = System.Drawing.Color.White
        Me.btnCloseSystem.Location = New System.Drawing.Point(445, 289)
        Me.btnCloseSystem.Name = "btnCloseSystem"
        Me.btnCloseSystem.Size = New System.Drawing.Size(233, 66)
        Me.btnCloseSystem.TabIndex = 5
        Me.btnCloseSystem.Text = "Close System"
        Me.btnCloseSystem.UseVisualStyleBackColor = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "SystemAdmin"
        Me.BindingSource1.DataSource = Me.ViewsDataSet
        '
        'ViewsDataSet
        '
        Me.ViewsDataSet.DataSetName = "ViewsDataSet"
        Me.ViewsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SystemAdminTableAdapter
        '
        Me.SystemAdminTableAdapter.ClearBeforeFill = True
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtUserID.Location = New System.Drawing.Point(506, 138)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(227, 28)
        Me.txtUserID.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtPassword.Location = New System.Drawing.Point(506, 186)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(227, 28)
        Me.txtPassword.TabIndex = 7
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(800, 398)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.btnCloseSystem)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogIn"
        Me.Text = "LogIn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonClient As RadioButton
    Friend WithEvents RadioButtonSystemAdmin As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnCloseSystem As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ViewsDataSet As ViewsDataSet
    Friend WithEvents SystemAdminTableAdapter As ViewsDataSetTableAdapters.SystemAdminTableAdapter
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
