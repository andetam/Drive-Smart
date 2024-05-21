<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Me.NameCar = New System.Windows.Forms.TextBox()
        Me.AM = New System.Windows.Forms.TextBox()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Manufactured = New System.Windows.Forms.TextBox()
        Me.Engine = New System.Windows.Forms.TextBox()
        Me.txtCarID = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtBankID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClientFullName = New System.Windows.Forms.TextBox()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBankBalanceCheck = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameCar
        '
        Me.NameCar.Location = New System.Drawing.Point(184, 205)
        Me.NameCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameCar.Name = "NameCar"
        Me.NameCar.Size = New System.Drawing.Size(288, 27)
        Me.NameCar.TabIndex = 95
        '
        'AM
        '
        Me.AM.Location = New System.Drawing.Point(184, 247)
        Me.AM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AM.Name = "AM"
        Me.AM.Size = New System.Drawing.Size(288, 27)
        Me.AM.TabIndex = 94
        '
        'Price
        '
        Me.Price.Location = New System.Drawing.Point(184, 289)
        Me.Price.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(288, 27)
        Me.Price.TabIndex = 93
        '
        'Manufactured
        '
        Me.Manufactured.Location = New System.Drawing.Point(184, 331)
        Me.Manufactured.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Manufactured.Name = "Manufactured"
        Me.Manufactured.Size = New System.Drawing.Size(288, 27)
        Me.Manufactured.TabIndex = 92
        '
        'Engine
        '
        Me.Engine.Location = New System.Drawing.Point(184, 373)
        Me.Engine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Engine.Name = "Engine"
        Me.Engine.Size = New System.Drawing.Size(288, 27)
        Me.Engine.TabIndex = 91
        '
        'txtCarID
        '
        Me.txtCarID.Location = New System.Drawing.Point(184, 163)
        Me.txtCarID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCarID.Name = "txtCarID"
        Me.txtCarID.Size = New System.Drawing.Size(288, 27)
        Me.txtCarID.TabIndex = 90
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(68, 207)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 21)
        Me.Label28.TabIndex = 89
        Me.Label28.Text = "Car Name:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(114, 253)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 21)
        Me.Label29.TabIndex = 88
        Me.Label29.Text = "A/M:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(39, 294)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(124, 21)
        Me.Label30.TabIndex = 87
        Me.Label30.Text = "Price per Day:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(35, 335)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(128, 21)
        Me.Label31.TabIndex = 86
        Me.Label31.Text = "Manufactured:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(94, 376)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 21)
        Me.Label32.TabIndex = 85
        Me.Label32.Text = "Engine:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(103, 166)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 21)
        Me.Label33.TabIndex = 84
        Me.Label33.Text = "CarID:"
        '
        'txtBankID
        '
        Me.txtBankID.Location = New System.Drawing.Point(184, 121)
        Me.txtBankID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBankID.Name = "txtBankID"
        Me.txtBankID.Size = New System.Drawing.Size(288, 27)
        Me.txtBankID.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Bank ID:"
        '
        'txtClientFullName
        '
        Me.txtClientFullName.Location = New System.Drawing.Point(184, 79)
        Me.txtClientFullName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClientFullName.Name = "txtClientFullName"
        Me.txtClientFullName.Size = New System.Drawing.Size(288, 27)
        Me.txtClientFullName.TabIndex = 99
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(184, 37)
        Me.txtClientID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(288, 27)
        Me.txtClientID.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Client ID:"
        '
        'btnBankBalanceCheck
        '
        Me.btnBankBalanceCheck.BackColor = System.Drawing.Color.DarkBlue
        Me.btnBankBalanceCheck.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBankBalanceCheck.ForeColor = System.Drawing.Color.White
        Me.btnBankBalanceCheck.Location = New System.Drawing.Point(55, 455)
        Me.btnBankBalanceCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBankBalanceCheck.Name = "btnBankBalanceCheck"
        Me.btnBankBalanceCheck.Size = New System.Drawing.Size(451, 67)
        Me.btnBankBalanceCheck.TabIndex = 103
        Me.btnBankBalanceCheck.Text = "Bank Balance Check"
        Me.btnBankBalanceCheck.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DarkBlue
        Me.btnConfirm.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(55, 545)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(451, 68)
        Me.btnConfirm.TabIndex = 104
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkBlue
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(55, 635)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(451, 68)
        Me.btnBack.TabIndex = 105
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(563, 736)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBankBalanceCheck)
        Me.Controls.Add(Me.txtBankID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtClientFullName)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameCar)
        Me.Controls.Add(Me.AM)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Manufactured)
        Me.Controls.Add(Me.Engine)
        Me.Controls.Add(Me.txtCarID)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CheckOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameCar As TextBox
    Friend WithEvents AM As TextBox
    Friend WithEvents Price As TextBox
    Friend WithEvents Manufactured As TextBox
    Friend WithEvents Engine As TextBox
    Friend WithEvents txtCarID As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtBankID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClientFullName As TextBox
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBankBalanceCheck As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnBack As Button
End Class
