<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCarsProblems
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
        Me.ListBoxProblems = New System.Windows.Forms.ListBox()
        Me.btnProblemCANNOTWait = New System.Windows.Forms.Button()
        Me.btnProblemcanWait = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxProblems
        '
        Me.ListBoxProblems.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxProblems.ForeColor = System.Drawing.Color.DarkBlue
        Me.ListBoxProblems.FormattingEnabled = True
        Me.ListBoxProblems.ItemHeight = 21
        Me.ListBoxProblems.Location = New System.Drawing.Point(55, 108)
        Me.ListBoxProblems.Name = "ListBoxProblems"
        Me.ListBoxProblems.Size = New System.Drawing.Size(185, 235)
        Me.ListBoxProblems.TabIndex = 0
        '
        'btnProblemCANNOTWait
        '
        Me.btnProblemCANNOTWait.BackColor = System.Drawing.Color.DarkBlue
        Me.btnProblemCANNOTWait.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProblemCANNOTWait.ForeColor = System.Drawing.Color.White
        Me.btnProblemCANNOTWait.Location = New System.Drawing.Point(309, 49)
        Me.btnProblemCANNOTWait.Name = "btnProblemCANNOTWait"
        Me.btnProblemCANNOTWait.Size = New System.Drawing.Size(276, 73)
        Me.btnProblemCANNOTWait.TabIndex = 1
        Me.btnProblemCANNOTWait.Text = "Problem can not Wait"
        Me.btnProblemCANNOTWait.UseVisualStyleBackColor = False
        '
        'btnProblemcanWait
        '
        Me.btnProblemcanWait.BackColor = System.Drawing.Color.DarkBlue
        Me.btnProblemcanWait.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProblemcanWait.ForeColor = System.Drawing.Color.White
        Me.btnProblemcanWait.Location = New System.Drawing.Point(309, 159)
        Me.btnProblemcanWait.Name = "btnProblemcanWait"
        Me.btnProblemcanWait.Size = New System.Drawing.Size(276, 73)
        Me.btnProblemcanWait.TabIndex = 2
        Me.btnProblemcanWait.Text = "Problem can Wait"
        Me.btnProblemcanWait.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkBlue
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(309, 270)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(276, 73)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(52, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "The following car ID's have been reported with issues "
        '
        'ManageCarsProblems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(642, 391)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnProblemcanWait)
        Me.Controls.Add(Me.btnProblemCANNOTWait)
        Me.Controls.Add(Me.ListBoxProblems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageCarsProblems"
        Me.Text = "ManageCarsProblems"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxProblems As ListBox
    Friend WithEvents btnProblemCANNOTWait As Button
    Friend WithEvents btnProblemcanWait As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
End Class
