<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Import
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Import))
        Me.stepOne = New System.Windows.Forms.Label()
        Me.importList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.stepTwo = New System.Windows.Forms.Label()
        Me.chemManTextBox = New System.Windows.Forms.TextBox()
        Me.importLabel = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.MsdsDBDataSet = New MSDS.msdsDBDataSet()
        Me.ChemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChemTblTableAdapter = New MSDS.msdsDBDataSetTableAdapters.chemTblTableAdapter()
        Me.TableAdapterManager = New MSDS.msdsDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.MsdsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stepOne
        '
        Me.stepOne.AutoSize = True
        Me.stepOne.Location = New System.Drawing.Point(13, 13)
        Me.stepOne.Name = "stepOne"
        Me.stepOne.Size = New System.Drawing.Size(228, 13)
        Me.stepOne.TabIndex = 0
        Me.stepOne.Text = "Drag and drop items to import in the box below:"
        '
        'importList
        '
        Me.importList.AllowDrop = True
        Me.importList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.importList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.importList.FullRowSelect = True
        Me.importList.Location = New System.Drawing.Point(16, 29)
        Me.importList.Name = "importList"
        Me.importList.Size = New System.Drawing.Size(489, 156)
        Me.importList.TabIndex = 1
        Me.importList.UseCompatibleStateImageBehavior = False
        Me.importList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Name"
        Me.ColumnHeader1.Width = 182
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Path"
        Me.ColumnHeader2.Width = 303
        '
        'stepTwo
        '
        Me.stepTwo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stepTwo.AutoSize = True
        Me.stepTwo.Location = New System.Drawing.Point(13, 205)
        Me.stepTwo.Name = "stepTwo"
        Me.stepTwo.Size = New System.Drawing.Size(148, 13)
        Me.stepTwo.TabIndex = 2
        Me.stepTwo.Text = "Enter the Manufacturer name:"
        '
        'chemManTextBox
        '
        Me.chemManTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chemManTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.chemManTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.chemManTextBox.Location = New System.Drawing.Point(16, 221)
        Me.chemManTextBox.Name = "chemManTextBox"
        Me.chemManTextBox.Size = New System.Drawing.Size(489, 20)
        Me.chemManTextBox.TabIndex = 3
        '
        'importLabel
        '
        Me.importLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.importLabel.AutoSize = True
        Me.importLabel.Location = New System.Drawing.Point(13, 284)
        Me.importLabel.Name = "importLabel"
        Me.importLabel.Size = New System.Drawing.Size(87, 13)
        Me.importLabel.TabIndex = 4
        Me.importLabel.Text = "0 Items to import."
        '
        'saveBtn
        '
        Me.saveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveBtn.Location = New System.Drawing.Point(430, 271)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 5
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.Location = New System.Drawing.Point(349, 271)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 6
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'MsdsDBDataSet
        '
        Me.MsdsDBDataSet.DataSetName = "msdsDBDataSet"
        Me.MsdsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChemTblBindingSource
        '
        Me.ChemTblBindingSource.DataMember = "chemTbl"
        Me.ChemTblBindingSource.DataSource = Me.MsdsDBDataSet
        '
        'ChemTblTableAdapter
        '
        Me.ChemTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chemTblTableAdapter = Me.ChemTblTableAdapter
        Me.TableAdapterManager.UpdateOrder = MSDS.msdsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Import
        '
        Me.AcceptButton = Me.saveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(525, 317)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.importLabel)
        Me.Controls.Add(Me.chemManTextBox)
        Me.Controls.Add(Me.stepTwo)
        Me.Controls.Add(Me.importList)
        Me.Controls.Add(Me.stepOne)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Import"
        Me.Text = "Import"
        CType(Me.MsdsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stepOne As System.Windows.Forms.Label
    Friend WithEvents importList As System.Windows.Forms.ListView
    Friend WithEvents stepTwo As System.Windows.Forms.Label
    Friend WithEvents chemManTextBox As System.Windows.Forms.TextBox
    Friend WithEvents importLabel As System.Windows.Forms.Label
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents MsdsDBDataSet As MSDS.msdsDBDataSet
    Friend WithEvents ChemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChemTblTableAdapter As MSDS.msdsDBDataSetTableAdapters.chemTblTableAdapter
    Friend WithEvents TableAdapterManager As MSDS.msdsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
