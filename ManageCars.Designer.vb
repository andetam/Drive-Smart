<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCars
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
        Dim CarIDLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim A_MLabel As System.Windows.Forms.Label
        Dim CarNameLabel As System.Windows.Forms.Label
        Dim PricePerDayLabel As System.Windows.Forms.Label
        Dim ManufactureYearLabel As System.Windows.Forms.Label
        Dim EngineLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageCars))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewsDataSet = New CarRentalSystem.ViewsDataSet()
        Me.CarsTableAdapter = New CarRentalSystem.ViewsDataSetTableAdapters.CarsTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUpdateTable = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New CarRentalSystem.ViewsDataSetTableAdapters.TableAdapterManager()
        Me.CarIDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.A_MTextBox = New System.Windows.Forms.TextBox()
        Me.CarNameTextBox = New System.Windows.Forms.TextBox()
        Me.PricePerDayTextBox = New System.Windows.Forms.TextBox()
        Me.ManufactureYearDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EngineTextBox = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CarIDLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        A_MLabel = New System.Windows.Forms.Label()
        CarNameLabel = New System.Windows.Forms.Label()
        PricePerDayLabel = New System.Windows.Forms.Label()
        ManufactureYearLabel = New System.Windows.Forms.Label()
        EngineLabel = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CarIDLabel
        '
        CarIDLabel.AutoSize = True
        CarIDLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarIDLabel.ForeColor = System.Drawing.Color.DarkBlue
        CarIDLabel.Location = New System.Drawing.Point(135, 56)
        CarIDLabel.Name = "CarIDLabel"
        CarIDLabel.Size = New System.Drawing.Size(65, 21)
        CarIDLabel.TabIndex = 1
        CarIDLabel.Text = "Car ID:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.ForeColor = System.Drawing.Color.DarkBlue
        CategoryLabel.Location = New System.Drawing.Point(114, 99)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(86, 21)
        CategoryLabel.TabIndex = 3
        CategoryLabel.Text = "Category:"
        '
        'A_MLabel
        '
        A_MLabel.AutoSize = True
        A_MLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_MLabel.ForeColor = System.Drawing.Color.DarkBlue
        A_MLabel.Location = New System.Drawing.Point(151, 142)
        A_MLabel.Name = "A_MLabel"
        A_MLabel.Size = New System.Drawing.Size(49, 21)
        A_MLabel.TabIndex = 5
        A_MLabel.Text = "A/M:"
        '
        'CarNameLabel
        '
        CarNameLabel.AutoSize = True
        CarNameLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarNameLabel.ForeColor = System.Drawing.Color.DarkBlue
        CarNameLabel.Location = New System.Drawing.Point(105, 185)
        CarNameLabel.Name = "CarNameLabel"
        CarNameLabel.Size = New System.Drawing.Size(95, 21)
        CarNameLabel.TabIndex = 7
        CarNameLabel.Text = "Car Name:"
        '
        'PricePerDayLabel
        '
        PricePerDayLabel.AutoSize = True
        PricePerDayLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PricePerDayLabel.ForeColor = System.Drawing.Color.DarkBlue
        PricePerDayLabel.Location = New System.Drawing.Point(75, 228)
        PricePerDayLabel.Name = "PricePerDayLabel"
        PricePerDayLabel.Size = New System.Drawing.Size(125, 21)
        PricePerDayLabel.TabIndex = 9
        PricePerDayLabel.Text = "Price Per Day:"
        '
        'ManufactureYearLabel
        '
        ManufactureYearLabel.AutoSize = True
        ManufactureYearLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ManufactureYearLabel.ForeColor = System.Drawing.Color.DarkBlue
        ManufactureYearLabel.Location = New System.Drawing.Point(40, 271)
        ManufactureYearLabel.Name = "ManufactureYearLabel"
        ManufactureYearLabel.Size = New System.Drawing.Size(160, 21)
        ManufactureYearLabel.TabIndex = 11
        ManufactureYearLabel.Text = "Manufacture Year:"
        '
        'EngineLabel
        '
        EngineLabel.AutoSize = True
        EngineLabel.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EngineLabel.ForeColor = System.Drawing.Color.DarkBlue
        EngineLabel.Location = New System.Drawing.Point(131, 314)
        EngineLabel.Name = "EngineLabel"
        EngineLabel.Size = New System.Drawing.Size(69, 21)
        EngineLabel.TabIndex = 13
        EngineLabel.Text = "Engine:"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Cars"
        Me.BindingSource1.DataSource = Me.ViewsDataSet
        '
        'ViewsDataSet
        '
        Me.ViewsDataSet.DataSetName = "ViewsDataSet"
        Me.ViewsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.btnUpdateTable})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(624, 27)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnUpdateTable
        '
        Me.btnUpdateTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUpdateTable.Image = CType(resources.GetObject("btnUpdateTable.Image"), System.Drawing.Image)
        Me.btnUpdateTable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdateTable.Name = "btnUpdateTable"
        Me.btnUpdateTable.Size = New System.Drawing.Size(29, 24)
        Me.btnUpdateTable.Text = "Update Table"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BankBalanceTableAdapter = Nothing
        Me.TableAdapterManager.CarsTableAdapter = Me.CarsTableAdapter
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.SystemAdminTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CarRentalSystem.ViewsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarIDTextBox
        '
        Me.CarIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CarID", True))
        Me.CarIDTextBox.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarIDTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.CarIDTextBox.Location = New System.Drawing.Point(229, 56)
        Me.CarIDTextBox.Name = "CarIDTextBox"
        Me.CarIDTextBox.Size = New System.Drawing.Size(321, 27)
        Me.CarIDTextBox.TabIndex = 2
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Category", True))
        Me.CategoryTextBox.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.CategoryTextBox.Location = New System.Drawing.Point(229, 99)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(321, 27)
        Me.CategoryTextBox.TabIndex = 4
        '
        'A_MTextBox
        '
        Me.A_MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "A/M", True))
        Me.A_MTextBox.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_MTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.A_MTextBox.Location = New System.Drawing.Point(229, 142)
        Me.A_MTextBox.Name = "A_MTextBox"
        Me.A_MTextBox.Size = New System.Drawing.Size(321, 27)
        Me.A_MTextBox.TabIndex = 6
        '
        'CarNameTextBox
        '
        Me.CarNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CarName", True))
        Me.CarNameTextBox.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarNameTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.CarNameTextBox.Location = New System.Drawing.Point(229, 185)
        Me.CarNameTextBox.Name = "CarNameTextBox"
        Me.CarNameTextBox.Size = New System.Drawing.Size(321, 27)
        Me.CarNameTextBox.TabIndex = 8
        '
        'PricePerDayTextBox
        '
        Me.PricePerDayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "PricePerDay", True))
        Me.PricePerDayTextBox.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PricePerDayTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.PricePerDayTextBox.Location = New System.Drawing.Point(229, 228)
        Me.PricePerDayTextBox.Name = "PricePerDayTextBox"
        Me.PricePerDayTextBox.Size = New System.Drawing.Size(321, 27)
        Me.PricePerDayTextBox.TabIndex = 10
        '
        'ManufactureYearDateTimePicker
        '
        Me.ManufactureYearDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "ManufactureYear", True))
        Me.ManufactureYearDateTimePicker.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufactureYearDateTimePicker.Location = New System.Drawing.Point(229, 271)
        Me.ManufactureYearDateTimePicker.Name = "ManufactureYearDateTimePicker"
        Me.ManufactureYearDateTimePicker.Size = New System.Drawing.Size(321, 27)
        Me.ManufactureYearDateTimePicker.TabIndex = 12
        '
        'EngineTextBox
        '
        Me.EngineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Engine", True))
        Me.EngineTextBox.Font = New System.Drawing.Font("Franklin Gothic Book", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngineTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.EngineTextBox.Location = New System.Drawing.Point(229, 314)
        Me.EngineTextBox.Name = "EngineTextBox"
        Me.EngineTextBox.Size = New System.Drawing.Size(321, 27)
        Me.EngineTextBox.TabIndex = 14
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkBlue
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Book", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(180, 369)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(264, 60)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'ManageCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(624, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(EngineLabel)
        Me.Controls.Add(Me.EngineTextBox)
        Me.Controls.Add(ManufactureYearLabel)
        Me.Controls.Add(Me.ManufactureYearDateTimePicker)
        Me.Controls.Add(PricePerDayLabel)
        Me.Controls.Add(Me.PricePerDayTextBox)
        Me.Controls.Add(CarNameLabel)
        Me.Controls.Add(Me.CarNameTextBox)
        Me.Controls.Add(A_MLabel)
        Me.Controls.Add(Me.A_MTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(CarIDLabel)
        Me.Controls.Add(Me.CarIDTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageCars"
        Me.Text = "ManageCars"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ViewsDataSet As ViewsDataSet
    Friend WithEvents CarsTableAdapter As ViewsDataSetTableAdapters.CarsTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents btnUpdateTable As ToolStripButton
    Friend WithEvents TableAdapterManager As ViewsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarIDTextBox As TextBox
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents A_MTextBox As TextBox
    Friend WithEvents CarNameTextBox As TextBox
    Friend WithEvents PricePerDayTextBox As TextBox
    Friend WithEvents ManufactureYearDateTimePicker As DateTimePicker
    Friend WithEvents EngineTextBox As TextBox
    Friend WithEvents btnBack As Button
End Class
