<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class locationFrm
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
        Dim LocationNameLabel As System.Windows.Forms.Label
        Me.SDSDataSet = New SDS.SDSDataSet()
        Me.TblLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLocationTableAdapter = New SDS.SDSDataSetTableAdapters.tblLocationTableAdapter()
        Me.TableAdapterManager = New SDS.SDSDataSetTableAdapters.TableAdapterManager()
        Me.LocationNameComboBox = New System.Windows.Forms.ComboBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        LocationNameLabel = New System.Windows.Forms.Label()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LocationNameLabel
        '
        LocationNameLabel.AutoSize = True
        LocationNameLabel.Location = New System.Drawing.Point(29, 44)
        LocationNameLabel.Name = "LocationNameLabel"
        LocationNameLabel.Size = New System.Drawing.Size(51, 13)
        LocationNameLabel.TabIndex = 1
        LocationNameLabel.Text = "Location:"
        '
        'SDSDataSet
        '
        Me.SDSDataSet.DataSetName = "SDSDataSet"
        Me.SDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLocationBindingSource
        '
        Me.TblLocationBindingSource.DataMember = "tblLocation"
        Me.TblLocationBindingSource.DataSource = Me.SDSDataSet
        '
        'TblLocationTableAdapter
        '
        Me.TblLocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.junctionSDSDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.junctionSDSLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblLocationTableAdapter = Me.TblLocationTableAdapter
        Me.TableAdapterManager.tblManagerTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SDS.SDSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LocationNameComboBox
        '
        Me.LocationNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLocationBindingSource, "locationName", True))
        Me.LocationNameComboBox.DataSource = Me.TblLocationBindingSource
        Me.LocationNameComboBox.DisplayMember = "locationName"
        Me.LocationNameComboBox.FormattingEnabled = True
        Me.LocationNameComboBox.Location = New System.Drawing.Point(86, 41)
        Me.LocationNameComboBox.Name = "LocationNameComboBox"
        Me.LocationNameComboBox.Size = New System.Drawing.Size(208, 21)
        Me.LocationNameComboBox.TabIndex = 2
        Me.LocationNameComboBox.ValueMember = "locationID"
        '
        'addBtn
        '
        Me.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.addBtn.Location = New System.Drawing.Point(219, 68)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 23)
        Me.addBtn.TabIndex = 3
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.Location = New System.Drawing.Point(138, 68)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'locationFrm
        '
        Me.AcceptButton = Me.addBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(336, 117)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(LocationNameLabel)
        Me.Controls.Add(Me.LocationNameComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "locationFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Add Location"
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SDSDataSet As SDSDataSet
    Friend WithEvents TblLocationBindingSource As BindingSource
    Friend WithEvents TblLocationTableAdapter As SDSDataSetTableAdapters.tblLocationTableAdapter
    Friend WithEvents TableAdapterManager As SDSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocationNameComboBox As ComboBox
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
End Class
