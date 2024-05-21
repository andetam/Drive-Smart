<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewPolls
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
        Me.PictureBoxReviewsPieChart = New System.Windows.Forms.PictureBox()
        Me.btnShowPieChart = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBoxReviewsPieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxReviewsPieChart
        '
        Me.PictureBoxReviewsPieChart.Location = New System.Drawing.Point(26, 23)
        Me.PictureBoxReviewsPieChart.Name = "PictureBoxReviewsPieChart"
        Me.PictureBoxReviewsPieChart.Size = New System.Drawing.Size(392, 419)
        Me.PictureBoxReviewsPieChart.TabIndex = 0
        Me.PictureBoxReviewsPieChart.TabStop = False
        '
        'btnShowPieChart
        '
        Me.btnShowPieChart.BackColor = System.Drawing.Color.DarkBlue
        Me.btnShowPieChart.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPieChart.ForeColor = System.Drawing.Color.White
        Me.btnShowPieChart.Location = New System.Drawing.Point(21, 448)
        Me.btnShowPieChart.Name = "btnShowPieChart"
        Me.btnShowPieChart.Size = New System.Drawing.Size(165, 52)
        Me.btnShowPieChart.TabIndex = 1
        Me.btnShowPieChart.Text = "Show Pie Chart"
        Me.btnShowPieChart.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkBlue
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(240, 448)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(165, 52)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'ReviewPolls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(429, 525)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnShowPieChart)
        Me.Controls.Add(Me.PictureBoxReviewsPieChart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReviewPolls"
        Me.Text = "ReviewPolls"
        CType(Me.PictureBoxReviewsPieChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxReviewsPieChart As PictureBox
    Friend WithEvents btnShowPieChart As Button
    Friend WithEvents btnBack As Button
End Class
