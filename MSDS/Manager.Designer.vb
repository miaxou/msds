<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
        Dim ChemManLabel As System.Windows.Forms.Label
        Dim ChemNameLabel As System.Windows.Forms.Label
        Dim ChemPathLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager))
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemManDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdsDBDataSet = New MSDS.msdsDBDataSet()
        Me.ChemTblTableAdapter = New MSDS.msdsDBDataSetTableAdapters.chemTblTableAdapter()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New MSDS.msdsDBDataSetTableAdapters.TableAdapterManager()
        Me.ChemManTextBox = New System.Windows.Forms.TextBox()
        Me.ChemNameTextBox = New System.Windows.Forms.TextBox()
        Me.ChemPathTextBox = New System.Windows.Forms.TextBox()
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
        Me.browseBtn = New System.Windows.Forms.Button()
        Me.msdsEditGrid = New System.Windows.Forms.DataGridView()
        Me.KeyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemManDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemPathDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.searchEditBox = New System.Windows.Forms.TextBox()
        ChemManLabel = New System.Windows.Forms.Label()
        ChemNameLabel = New System.Windows.Forms.Label()
        ChemPathLabel = New System.Windows.Forms.Label()
        CType(Me.ChemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.msdsEditGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChemManLabel
        '
        ChemManLabel.AutoSize = True
        ChemManLabel.Location = New System.Drawing.Point(425, 113)
        ChemManLabel.Name = "ChemManLabel"
        ChemManLabel.Size = New System.Drawing.Size(73, 13)
        ChemManLabel.TabIndex = 3
        ChemManLabel.Text = "Manufacturer:"
        '
        'ChemNameLabel
        '
        ChemNameLabel.AutoSize = True
        ChemNameLabel.Location = New System.Drawing.Point(460, 87)
        ChemNameLabel.Name = "ChemNameLabel"
        ChemNameLabel.Size = New System.Drawing.Size(38, 13)
        ChemNameLabel.TabIndex = 5
        ChemNameLabel.Text = "Name:"
        '
        'ChemPathLabel
        '
        ChemPathLabel.AutoSize = True
        ChemPathLabel.Location = New System.Drawing.Point(466, 165)
        ChemPathLabel.Name = "ChemPathLabel"
        ChemPathLabel.Size = New System.Drawing.Size(32, 13)
        ChemPathLabel.TabIndex = 7
        ChemPathLabel.Text = "Path:"
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "key"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        Me.KeyDataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyDataGridViewTextBoxColumn.Visible = False
        '
        'ChemNameDataGridViewTextBoxColumn
        '
        Me.ChemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChemNameDataGridViewTextBoxColumn.DataPropertyName = "chemName"
        Me.ChemNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ChemNameDataGridViewTextBoxColumn.Name = "ChemNameDataGridViewTextBoxColumn"
        Me.ChemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChemManDataGridViewTextBoxColumn
        '
        Me.ChemManDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChemManDataGridViewTextBoxColumn.DataPropertyName = "chemMan"
        Me.ChemManDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ChemManDataGridViewTextBoxColumn.Name = "ChemManDataGridViewTextBoxColumn"
        Me.ChemManDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChemPathDataGridViewTextBoxColumn
        '
        Me.ChemPathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChemPathDataGridViewTextBoxColumn.DataPropertyName = "chemPath"
        Me.ChemPathDataGridViewTextBoxColumn.HeaderText = "Path"
        Me.ChemPathDataGridViewTextBoxColumn.Name = "ChemPathDataGridViewTextBoxColumn"
        Me.ChemPathDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChemPathDataGridViewTextBoxColumn.Visible = False
        '
        'ChemTblBindingSource
        '
        Me.ChemTblBindingSource.DataMember = "chemTbl"
        Me.ChemTblBindingSource.DataSource = Me.MsdsDBDataSet
        '
        'MsdsDBDataSet
        '
        Me.MsdsDBDataSet.DataSetName = "msdsDBDataSet"
        Me.MsdsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChemTblTableAdapter
        '
        Me.ChemTblTableAdapter.ClearBeforeFill = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(809, 498)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 5
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(728, 498)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chemTblTableAdapter = Me.ChemTblTableAdapter
        Me.TableAdapterManager.UpdateOrder = MSDS.msdsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ChemManTextBox
        '
        Me.ChemManTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ChemManTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ChemManTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemTblBindingSource, "chemMan", True))
        Me.ChemManTextBox.Location = New System.Drawing.Point(504, 110)
        Me.ChemManTextBox.Name = "ChemManTextBox"
        Me.ChemManTextBox.Size = New System.Drawing.Size(299, 20)
        Me.ChemManTextBox.TabIndex = 1
        '
        'ChemNameTextBox
        '
        Me.ChemNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemTblBindingSource, "chemName", True))
        Me.ChemNameTextBox.Location = New System.Drawing.Point(504, 84)
        Me.ChemNameTextBox.Name = "ChemNameTextBox"
        Me.ChemNameTextBox.Size = New System.Drawing.Size(299, 20)
        Me.ChemNameTextBox.TabIndex = 0
        '
        'ChemPathTextBox
        '
        Me.ChemPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemTblBindingSource, "chemPath", True))
        Me.ChemPathTextBox.Location = New System.Drawing.Point(504, 165)
        Me.ChemPathTextBox.Name = "ChemPathTextBox"
        Me.ChemPathTextBox.Size = New System.Drawing.Size(299, 20)
        Me.ChemPathTextBox.TabIndex = 2
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ChemTblBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(904, 25)
        Me.BindingNavigator1.TabIndex = 9
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'browseBtn
        '
        Me.browseBtn.Location = New System.Drawing.Point(809, 163)
        Me.browseBtn.Name = "browseBtn"
        Me.browseBtn.Size = New System.Drawing.Size(75, 23)
        Me.browseBtn.TabIndex = 3
        Me.browseBtn.Text = "Browse"
        Me.browseBtn.UseVisualStyleBackColor = True
        '
        'msdsEditGrid
        '
        Me.msdsEditGrid.AllowUserToAddRows = False
        Me.msdsEditGrid.AllowUserToDeleteRows = False
        Me.msdsEditGrid.AllowUserToResizeRows = False
        Me.msdsEditGrid.AutoGenerateColumns = False
        Me.msdsEditGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.msdsEditGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn1, Me.ChemNameDataGridViewTextBoxColumn1, Me.ChemManDataGridViewTextBoxColumn1, Me.ChemPathDataGridViewTextBoxColumn1})
        Me.msdsEditGrid.DataSource = Me.ChemTblBindingSource
        Me.msdsEditGrid.Location = New System.Drawing.Point(0, 54)
        Me.msdsEditGrid.Name = "msdsEditGrid"
        Me.msdsEditGrid.ReadOnly = True
        Me.msdsEditGrid.RowHeadersVisible = False
        Me.msdsEditGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.msdsEditGrid.Size = New System.Drawing.Size(419, 478)
        Me.msdsEditGrid.TabIndex = 10
        '
        'KeyDataGridViewTextBoxColumn1
        '
        Me.KeyDataGridViewTextBoxColumn1.DataPropertyName = "key"
        Me.KeyDataGridViewTextBoxColumn1.HeaderText = "key"
        Me.KeyDataGridViewTextBoxColumn1.Name = "KeyDataGridViewTextBoxColumn1"
        Me.KeyDataGridViewTextBoxColumn1.ReadOnly = True
        Me.KeyDataGridViewTextBoxColumn1.Visible = False
        '
        'ChemNameDataGridViewTextBoxColumn1
        '
        Me.ChemNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChemNameDataGridViewTextBoxColumn1.DataPropertyName = "chemName"
        Me.ChemNameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.ChemNameDataGridViewTextBoxColumn1.Name = "ChemNameDataGridViewTextBoxColumn1"
        Me.ChemNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ChemManDataGridViewTextBoxColumn1
        '
        Me.ChemManDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChemManDataGridViewTextBoxColumn1.DataPropertyName = "chemMan"
        Me.ChemManDataGridViewTextBoxColumn1.HeaderText = "Manufacturer"
        Me.ChemManDataGridViewTextBoxColumn1.Name = "ChemManDataGridViewTextBoxColumn1"
        Me.ChemManDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ChemPathDataGridViewTextBoxColumn1
        '
        Me.ChemPathDataGridViewTextBoxColumn1.DataPropertyName = "chemPath"
        Me.ChemPathDataGridViewTextBoxColumn1.HeaderText = "chemPath"
        Me.ChemPathDataGridViewTextBoxColumn1.Name = "ChemPathDataGridViewTextBoxColumn1"
        Me.ChemPathDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ChemPathDataGridViewTextBoxColumn1.Visible = False
        '
        'searchEditBox
        '
        Me.searchEditBox.Location = New System.Drawing.Point(0, 31)
        Me.searchEditBox.Name = "searchEditBox"
        Me.searchEditBox.Size = New System.Drawing.Size(419, 20)
        Me.searchEditBox.TabIndex = 11
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 541)
        Me.Controls.Add(Me.searchEditBox)
        Me.Controls.Add(Me.msdsEditGrid)
        Me.Controls.Add(Me.browseBtn)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(ChemPathLabel)
        Me.Controls.Add(Me.ChemPathTextBox)
        Me.Controls.Add(ChemNameLabel)
        Me.Controls.Add(Me.ChemNameTextBox)
        Me.Controls.Add(ChemManLabel)
        Me.Controls.Add(Me.ChemManTextBox)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Name = "Manager"
        Me.Text = "Manager"
        CType(Me.ChemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.msdsEditGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msdsEditGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MsdsDBDataSet As MSDS.msdsDBDataSet
    Friend WithEvents ChemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChemTblTableAdapter As MSDS.msdsDBDataSetTableAdapters.chemTblTableAdapter
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As MSDS.msdsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChemManTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChemPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents browseBtn As System.Windows.Forms.Button
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemManDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemPathDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemManDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemPathDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents searchEditBox As System.Windows.Forms.TextBox
End Class
