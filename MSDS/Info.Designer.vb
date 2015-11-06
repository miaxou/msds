<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Info
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SdsNameLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim DateAddedLabel As System.Windows.Forms.Label
        Dim IdcUseLabel As System.Windows.Forms.Label
        Dim InBookLabel As System.Windows.Forms.Label
        Dim IdcNumLabel As System.Windows.Forms.Label
        Dim MroNumLabel As System.Windows.Forms.Label
        Dim PdfPathLabel As System.Windows.Forms.Label
        Me.dataBackgroundLoad = New System.ComponentModel.BackgroundWorker()
        Me.locationBox = New System.Windows.Forms.ListBox()
        Me.departmentBox = New System.Windows.Forms.ListBox()
        Me.infoBox = New System.Windows.Forms.GroupBox()
        Me.DateAddedTextBox = New System.Windows.Forms.TextBox()
        Me.TblSDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDSDataSet = New SDS.SDSDataSet()
        Me.PdfPathTextBox = New System.Windows.Forms.TextBox()
        Me.MroNumTextBox = New System.Windows.Forms.TextBox()
        Me.IdcNumTextBox = New System.Windows.Forms.TextBox()
        Me.InBookCheckBox = New System.Windows.Forms.CheckBox()
        Me.IdcUseCheckBox = New System.Windows.Forms.CheckBox()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.SdsNameTextBox = New System.Windows.Forms.TextBox()
        Me.departmentLabel = New System.Windows.Forms.Label()
        Me.locationLabel = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New SDS.SDSDataSetTableAdapters.TableAdapterManager()
        Me.TblSDSTableAdapter = New SDS.SDSDataSetTableAdapters.tblSDSTableAdapter()
        SdsNameLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        DateAddedLabel = New System.Windows.Forms.Label()
        IdcUseLabel = New System.Windows.Forms.Label()
        InBookLabel = New System.Windows.Forms.Label()
        IdcNumLabel = New System.Windows.Forms.Label()
        MroNumLabel = New System.Windows.Forms.Label()
        PdfPathLabel = New System.Windows.Forms.Label()
        Me.infoBox.SuspendLayout()
        CType(Me.TblSDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SdsNameLabel
        '
        SdsNameLabel.AutoSize = True
        SdsNameLabel.Location = New System.Drawing.Point(6, 24)
        SdsNameLabel.Name = "SdsNameLabel"
        SdsNameLabel.Size = New System.Drawing.Size(84, 13)
        SdsNameLabel.TabIndex = 4
        SdsNameLabel.Text = "Chemical Name:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Location = New System.Drawing.Point(323, 24)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(73, 13)
        ManufacturerLabel.TabIndex = 6
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.Location = New System.Drawing.Point(42, 49)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(48, 13)
        SupplierLabel.TabIndex = 8
        SupplierLabel.Text = "Supplier:"
        '
        'DateAddedLabel
        '
        DateAddedLabel.AutoSize = True
        DateAddedLabel.Location = New System.Drawing.Point(329, 49)
        DateAddedLabel.Name = "DateAddedLabel"
        DateAddedLabel.Size = New System.Drawing.Size(67, 13)
        DateAddedLabel.TabIndex = 10
        DateAddedLabel.Text = "Date Added:"
        '
        'IdcUseLabel
        '
        IdcUseLabel.AutoSize = True
        IdcUseLabel.Location = New System.Drawing.Point(40, 76)
        IdcUseLabel.Name = "IdcUseLabel"
        IdcUseLabel.Size = New System.Drawing.Size(50, 13)
        IdcUseLabel.TabIndex = 12
        IdcUseLabel.Text = "IDC Use:"
        '
        'InBookLabel
        '
        InBookLabel.AutoSize = True
        InBookLabel.Location = New System.Drawing.Point(129, 76)
        InBookLabel.Name = "InBookLabel"
        InBookLabel.Size = New System.Drawing.Size(47, 13)
        InBookLabel.TabIndex = 14
        InBookLabel.Text = "In Book:"
        '
        'IdcNumLabel
        '
        IdcNumLabel.AutoSize = True
        IdcNumLabel.Location = New System.Drawing.Point(37, 104)
        IdcNumLabel.Name = "IdcNumLabel"
        IdcNumLabel.Size = New System.Drawing.Size(53, 13)
        IdcNumLabel.TabIndex = 16
        IdcNumLabel.Text = "IDC Num:"
        '
        'MroNumLabel
        '
        MroNumLabel.AutoSize = True
        MroNumLabel.Location = New System.Drawing.Point(30, 130)
        MroNumLabel.Name = "MroNumLabel"
        MroNumLabel.Size = New System.Drawing.Size(60, 13)
        MroNumLabel.TabIndex = 18
        MroNumLabel.Text = "MRO Num:"
        '
        'PdfPathLabel
        '
        PdfPathLabel.AutoSize = True
        PdfPathLabel.Location = New System.Drawing.Point(340, 74)
        PdfPathLabel.Name = "PdfPathLabel"
        PdfPathLabel.Size = New System.Drawing.Size(56, 13)
        PdfPathLabel.TabIndex = 20
        PdfPathLabel.Text = "PDF Path:"
        '
        'locationBox
        '
        Me.locationBox.FormattingEnabled = True
        Me.locationBox.Location = New System.Drawing.Point(96, 155)
        Me.locationBox.Name = "locationBox"
        Me.locationBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.locationBox.Size = New System.Drawing.Size(190, 95)
        Me.locationBox.TabIndex = 0
        '
        'departmentBox
        '
        Me.departmentBox.FormattingEnabled = True
        Me.departmentBox.Location = New System.Drawing.Point(402, 155)
        Me.departmentBox.Name = "departmentBox"
        Me.departmentBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.departmentBox.Size = New System.Drawing.Size(190, 95)
        Me.departmentBox.TabIndex = 1
        '
        'infoBox
        '
        Me.infoBox.Controls.Add(Me.DateAddedTextBox)
        Me.infoBox.Controls.Add(PdfPathLabel)
        Me.infoBox.Controls.Add(Me.PdfPathTextBox)
        Me.infoBox.Controls.Add(MroNumLabel)
        Me.infoBox.Controls.Add(Me.MroNumTextBox)
        Me.infoBox.Controls.Add(IdcNumLabel)
        Me.infoBox.Controls.Add(Me.IdcNumTextBox)
        Me.infoBox.Controls.Add(InBookLabel)
        Me.infoBox.Controls.Add(Me.InBookCheckBox)
        Me.infoBox.Controls.Add(IdcUseLabel)
        Me.infoBox.Controls.Add(Me.IdcUseCheckBox)
        Me.infoBox.Controls.Add(DateAddedLabel)
        Me.infoBox.Controls.Add(SupplierLabel)
        Me.infoBox.Controls.Add(Me.SupplierTextBox)
        Me.infoBox.Controls.Add(ManufacturerLabel)
        Me.infoBox.Controls.Add(Me.ManufacturerTextBox)
        Me.infoBox.Controls.Add(SdsNameLabel)
        Me.infoBox.Controls.Add(Me.SdsNameTextBox)
        Me.infoBox.Controls.Add(Me.departmentBox)
        Me.infoBox.Controls.Add(Me.departmentLabel)
        Me.infoBox.Controls.Add(Me.locationLabel)
        Me.infoBox.Controls.Add(Me.locationBox)
        Me.infoBox.Location = New System.Drawing.Point(12, 12)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(612, 270)
        Me.infoBox.TabIndex = 2
        Me.infoBox.TabStop = False
        '
        'DateAddedTextBox
        '
        Me.DateAddedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSDSBindingSource, "dateAdded", True))
        Me.DateAddedTextBox.Location = New System.Drawing.Point(402, 46)
        Me.DateAddedTextBox.Name = "DateAddedTextBox"
        Me.DateAddedTextBox.ReadOnly = True
        Me.DateAddedTextBox.Size = New System.Drawing.Size(190, 20)
        Me.DateAddedTextBox.TabIndex = 23
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
        'PdfPathTextBox
        '
        Me.PdfPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSDSBindingSource, "pdfPath", True))
        Me.PdfPathTextBox.Location = New System.Drawing.Point(402, 71)
        Me.PdfPathTextBox.Name = "PdfPathTextBox"
        Me.PdfPathTextBox.ReadOnly = True
        Me.PdfPathTextBox.Size = New System.Drawing.Size(190, 20)
        Me.PdfPathTextBox.TabIndex = 21
        '
        'MroNumTextBox
        '
        Me.MroNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSDSBindingSource, "mroNum", True))
        Me.MroNumTextBox.Location = New System.Drawing.Point(96, 127)
        Me.MroNumTextBox.Name = "MroNumTextBox"
        Me.MroNumTextBox.ReadOnly = True
        Me.MroNumTextBox.Size = New System.Drawing.Size(80, 20)
        Me.MroNumTextBox.TabIndex = 19
        '
        'IdcNumTextBox
        '
        Me.IdcNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSDSBindingSource, "idcNum", True))
        Me.IdcNumTextBox.Location = New System.Drawing.Point(96, 101)
        Me.IdcNumTextBox.Name = "IdcNumTextBox"
        Me.IdcNumTextBox.ReadOnly = True
        Me.IdcNumTextBox.Size = New System.Drawing.Size(80, 20)
        Me.IdcNumTextBox.TabIndex = 17
        '
        'InBookCheckBox
        '
        Me.InBookCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblSDSBindingSource, "inBook", True))
        Me.InBookCheckBox.Enabled = False
        Me.InBookCheckBox.Location = New System.Drawing.Point(182, 71)
        Me.InBookCheckBox.Name = "InBookCheckBox"
        Me.InBookCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.InBookCheckBox.TabIndex = 15
        Me.InBookCheckBox.UseVisualStyleBackColor = True
        '
        'IdcUseCheckBox
        '
        Me.IdcUseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblSDSBindingSource, "idcUse", True))
        Me.IdcUseCheckBox.Enabled = False
        Me.IdcUseCheckBox.Location = New System.Drawing.Point(96, 71)
        Me.IdcUseCheckBox.Name = "IdcUseCheckBox"
        Me.IdcUseCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IdcUseCheckBox.TabIndex = 13
        Me.IdcUseCheckBox.UseVisualStyleBackColor = True
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSDSBindingSource, "supplier", True))
        Me.SupplierTextBox.Location = New System.Drawing.Point(96, 46)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.ReadOnly = True
        Me.SupplierTextBox.Size = New System.Drawing.Size(190, 20)
        Me.SupplierTextBox.TabIndex = 9
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSDSBindingSource, "manufacturer", True))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(402, 21)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.ReadOnly = True
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(190, 20)
        Me.ManufacturerTextBox.TabIndex = 7
        '
        'SdsNameTextBox
        '
        Me.SdsNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSDSBindingSource, "sdsName", True))
        Me.SdsNameTextBox.Location = New System.Drawing.Point(96, 21)
        Me.SdsNameTextBox.Name = "SdsNameTextBox"
        Me.SdsNameTextBox.ReadOnly = True
        Me.SdsNameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.SdsNameTextBox.TabIndex = 5
        '
        'departmentLabel
        '
        Me.departmentLabel.AutoSize = True
        Me.departmentLabel.Location = New System.Drawing.Point(326, 155)
        Me.departmentLabel.Name = "departmentLabel"
        Me.departmentLabel.Size = New System.Drawing.Size(70, 13)
        Me.departmentLabel.TabIndex = 2
        Me.departmentLabel.Text = "Departments:"
        '
        'locationLabel
        '
        Me.locationLabel.AutoSize = True
        Me.locationLabel.Location = New System.Drawing.Point(34, 155)
        Me.locationLabel.Name = "locationLabel"
        Me.locationLabel.Size = New System.Drawing.Size(56, 13)
        Me.locationLabel.TabIndex = 1
        Me.locationLabel.Text = "Locations:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblSDSTableAdapter = Me.TblSDSTableAdapter
        Me.TableAdapterManager.UpdateOrder = SDS.SDSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSDSTableAdapter
        '
        Me.TblSDSTableAdapter.ClearBeforeFill = True
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 287)
        Me.Controls.Add(Me.infoBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Info"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Info"
        Me.infoBox.ResumeLayout(False)
        Me.infoBox.PerformLayout()
        CType(Me.TblSDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataBackgroundLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents locationBox As ListBox
    Friend WithEvents departmentBox As ListBox
    Friend WithEvents infoBox As GroupBox
    Friend WithEvents departmentLabel As Label
    Friend WithEvents locationLabel As Label
    Friend WithEvents TblSDSBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As SDSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SdsNameTextBox As TextBox
    Friend WithEvents SDSDataSet As SDSDataSet
    Friend WithEvents ManufacturerTextBox As TextBox
    Friend WithEvents TblSDSTableAdapter As SDSDataSetTableAdapters.tblSDSTableAdapter
    Friend WithEvents PdfPathTextBox As TextBox
    Friend WithEvents MroNumTextBox As TextBox
    Friend WithEvents IdcNumTextBox As TextBox
    Friend WithEvents InBookCheckBox As CheckBox
    Friend WithEvents IdcUseCheckBox As CheckBox
    Friend WithEvents SupplierTextBox As TextBox
    Friend WithEvents DateAddedTextBox As TextBox
End Class
