<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents managerBox As GroupBox
    Friend WithEvents SDSDataSet As SDSDataSet
    Friend WithEvents TblSDSBindingSource As BindingSource
    Friend WithEvents TblSDSTableAdapter As SDSDataSetTableAdapters.tblSDSTableAdapter
    Friend WithEvents TableAdapterManager As SDSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSDSDataGridView As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditRecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents sdsUpdated As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager))
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemManDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.searchEditBox = New System.Windows.Forms.TextBox()
        Me.managerBox = New System.Windows.Forms.GroupBox()
        Me.TblSDSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sdsUpdated = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDSDataSet = New SDS.SDSDataSet()
        Me.TblSDSTableAdapter = New SDS.SDSDataSetTableAdapters.tblSDSTableAdapter()
        Me.TableAdapterManager = New SDS.SDSDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.managerBox.SuspendLayout()
        CType(Me.TblSDSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'saveBtn
        '
        Me.saveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveBtn.Location = New System.Drawing.Point(813, 452)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 6
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelBtn.Location = New System.Drawing.Point(732, 452)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 5
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'searchEditBox
        '
        Me.searchEditBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchEditBox.Location = New System.Drawing.Point(6, 19)
        Me.searchEditBox.Name = "searchEditBox"
        Me.searchEditBox.Size = New System.Drawing.Size(882, 20)
        Me.searchEditBox.TabIndex = 0
        '
        'managerBox
        '
        Me.managerBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.managerBox.Controls.Add(Me.TblSDSDataGridView)
        Me.managerBox.Controls.Add(Me.searchEditBox)
        Me.managerBox.Controls.Add(Me.saveBtn)
        Me.managerBox.Controls.Add(Me.cancelBtn)
        Me.managerBox.Location = New System.Drawing.Point(12, 27)
        Me.managerBox.Name = "managerBox"
        Me.managerBox.Size = New System.Drawing.Size(894, 481)
        Me.managerBox.TabIndex = 7
        Me.managerBox.TabStop = False
        Me.managerBox.Text = "Manager"
        '
        'TblSDSDataGridView
        '
        Me.TblSDSDataGridView.AllowUserToAddRows = False
        Me.TblSDSDataGridView.AllowUserToDeleteRows = False
        Me.TblSDSDataGridView.AllowUserToResizeRows = False
        Me.TblSDSDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblSDSDataGridView.AutoGenerateColumns = False
        Me.TblSDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSDSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.sdsUpdated, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9})
        Me.TblSDSDataGridView.DataSource = Me.TblSDSBindingSource
        Me.TblSDSDataGridView.Location = New System.Drawing.Point(6, 45)
        Me.TblSDSDataGridView.Name = "TblSDSDataGridView"
        Me.TblSDSDataGridView.ReadOnly = True
        Me.TblSDSDataGridView.RowHeadersVisible = False
        Me.TblSDSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblSDSDataGridView.Size = New System.Drawing.Size(882, 401)
        Me.TblSDSDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sdsID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "sdsID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'sdsUpdated
        '
        Me.sdsUpdated.DataPropertyName = "sdsUpdated"
        Me.sdsUpdated.HeaderText = "Updated"
        Me.sdsUpdated.Name = "sdsUpdated"
        Me.sdsUpdated.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sdsName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "manufacturer"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Manufacturer"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 95
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "supplier"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idcNum"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDC #"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "masterNum"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Master #"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 74
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "mroNum"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MRO #"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 67
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "pdfPath"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PDF Path"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 78
        '
        'TblSDSBindingSource
        '
        Me.TblSDSBindingSource.DataMember = "tblSDS"
        Me.TblSDSBindingSource.DataSource = Me.SDSDataSet
        '
        'SDSDataSet
        '
        Me.SDSDataSet.DataSetName = "SDSDataSet"
        Me.SDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSDSTableAdapter
        '
        Me.TblSDSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.junctionSDSLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblManagerTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSTableAdapter = Me.TblSDSTableAdapter
        Me.TableAdapterManager.UpdateOrder = SDS.SDSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(918, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.CancelToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.EditRecToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.LocationsToolStripMenuItem, Me.DepartmentsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AddNewToolStripMenuItem.Text = "Add New..."
        '
        'EditRecToolStripMenuItem
        '
        Me.EditRecToolStripMenuItem.Name = "EditRecToolStripMenuItem"
        Me.EditRecToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.EditRecToolStripMenuItem.Text = "Edit..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LocationsToolStripMenuItem
        '
        Me.LocationsToolStripMenuItem.Name = "LocationsToolStripMenuItem"
        Me.LocationsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.LocationsToolStripMenuItem.Text = "Locations..."
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DepartmentsToolStripMenuItem.Text = "Departments..."
        '
        'Manager
        '
        Me.AcceptButton = Me.saveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 520)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.managerBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SDS Manager"
        Me.managerBox.ResumeLayout(False)
        Me.managerBox.PerformLayout()
        CType(Me.TblSDSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemManDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemPathDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents searchEditBox As System.Windows.Forms.TextBox
    Friend WithEvents KeyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemManDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemPathDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
