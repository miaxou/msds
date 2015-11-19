<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class departmentFrm
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
        Dim DepartmentNameLabel As System.Windows.Forms.Label
        Me.SDSDataSet = New SDS.SDSDataSet()
        Me.TblDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDepartmentTableAdapter = New SDS.SDSDataSetTableAdapters.tblDepartmentTableAdapter()
        Me.TableAdapterManager = New SDS.SDSDataSetTableAdapters.TableAdapterManager()
        Me.DepartmentNameComboBox = New System.Windows.Forms.ComboBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        DepartmentNameLabel = New System.Windows.Forms.Label()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentNameLabel
        '
        DepartmentNameLabel.AutoSize = True
        DepartmentNameLabel.Location = New System.Drawing.Point(15, 44)
        DepartmentNameLabel.Name = "DepartmentNameLabel"
        DepartmentNameLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentNameLabel.TabIndex = 1
        DepartmentNameLabel.Text = "Department:"
        '
        'SDSDataSet
        '
        Me.SDSDataSet.DataSetName = "SDSDataSet"
        Me.SDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDepartmentBindingSource
        '
        Me.TblDepartmentBindingSource.DataMember = "tblDepartment"
        Me.TblDepartmentBindingSource.DataSource = Me.SDSDataSet
        '
        'TblDepartmentTableAdapter
        '
        Me.TblDepartmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.junctionSDSDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.junctionSDSLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentTableAdapter = Me.TblDepartmentTableAdapter
        Me.TableAdapterManager.tblLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblManagerTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SDS.SDSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DepartmentNameComboBox
        '
        Me.DepartmentNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDepartmentBindingSource, "departmentName", True))
        Me.DepartmentNameComboBox.DataSource = Me.TblDepartmentBindingSource
        Me.DepartmentNameComboBox.DisplayMember = "departmentName"
        Me.DepartmentNameComboBox.FormattingEnabled = True
        Me.DepartmentNameComboBox.Location = New System.Drawing.Point(86, 41)
        Me.DepartmentNameComboBox.Name = "DepartmentNameComboBox"
        Me.DepartmentNameComboBox.Size = New System.Drawing.Size(208, 21)
        Me.DepartmentNameComboBox.TabIndex = 2
        Me.DepartmentNameComboBox.ValueMember = "deptID"
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(219, 68)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 23)
        Me.addBtn.TabIndex = 3
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(138, 68)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'departmentFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 117)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(DepartmentNameLabel)
        Me.Controls.Add(Me.DepartmentNameComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "departmentFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Add Department"
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SDSDataSet As SDSDataSet
    Friend WithEvents TblDepartmentBindingSource As BindingSource
    Friend WithEvents TblDepartmentTableAdapter As SDSDataSetTableAdapters.tblDepartmentTableAdapter
    Friend WithEvents TableAdapterManager As SDSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentNameComboBox As ComboBox
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
End Class
