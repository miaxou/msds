<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.msdsGrid = New System.Windows.Forms.DataGridView()
        Me.SdsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pdfPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDSDataSet = New SDS.SDSDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pdfViewer = New AxAcroPDFLib.AxAcroPDF()
        Me.pdfErrorLabel = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.dgvBackgroundLoad = New System.ComponentModel.BackgroundWorker()
        Me.loadingStatus = New System.Windows.Forms.Label()
        Me.infoLabel = New System.Windows.Forms.LinkLabel()
        Me.TblSDSTableAdapter = New SDS.SDSDataSetTableAdapters.tblSDSTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.msdsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pdfViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.searchBox)
        Me.GroupBox1.Controls.Add(Me.msdsGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 513)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(6, 19)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(297, 20)
        Me.searchBox.TabIndex = 0
        '
        'msdsGrid
        '
        Me.msdsGrid.AllowUserToAddRows = False
        Me.msdsGrid.AllowUserToDeleteRows = False
        Me.msdsGrid.AllowUserToResizeRows = False
        Me.msdsGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.msdsGrid.AutoGenerateColumns = False
        Me.msdsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.msdsGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.msdsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msdsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.msdsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SdsIDDataGridViewTextBoxColumn, Me.SdsNameDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.pdfPath})
        Me.msdsGrid.DataSource = Me.TblSDSBindingSource
        Me.msdsGrid.Location = New System.Drawing.Point(6, 45)
        Me.msdsGrid.MultiSelect = False
        Me.msdsGrid.Name = "msdsGrid"
        Me.msdsGrid.ReadOnly = True
        Me.msdsGrid.RowHeadersVisible = False
        Me.msdsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.msdsGrid.Size = New System.Drawing.Size(297, 462)
        Me.msdsGrid.TabIndex = 1
        '
        'SdsIDDataGridViewTextBoxColumn
        '
        Me.SdsIDDataGridViewTextBoxColumn.DataPropertyName = "sdsID"
        Me.SdsIDDataGridViewTextBoxColumn.HeaderText = "sdsID"
        Me.SdsIDDataGridViewTextBoxColumn.Name = "SdsIDDataGridViewTextBoxColumn"
        Me.SdsIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SdsIDDataGridViewTextBoxColumn.Visible = False
        Me.SdsIDDataGridViewTextBoxColumn.Width = 40
        '
        'SdsNameDataGridViewTextBoxColumn
        '
        Me.SdsNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SdsNameDataGridViewTextBoxColumn.DataPropertyName = "sdsName"
        Me.SdsNameDataGridViewTextBoxColumn.HeaderText = "Chemical Name"
        Me.SdsNameDataGridViewTextBoxColumn.Name = "SdsNameDataGridViewTextBoxColumn"
        Me.SdsNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        Me.ManufacturerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'pdfPath
        '
        Me.pdfPath.DataPropertyName = "pdfPath"
        Me.pdfPath.HeaderText = "pdfPath"
        Me.pdfPath.Name = "pdfPath"
        Me.pdfPath.ReadOnly = True
        Me.pdfPath.Visible = False
        Me.pdfPath.Width = 69
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'pdfViewer
        '
        Me.pdfViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewer.Enabled = True
        Me.pdfViewer.Location = New System.Drawing.Point(327, 46)
        Me.pdfViewer.Name = "pdfViewer"
        Me.pdfViewer.OcxState = CType(resources.GetObject("pdfViewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdfViewer.Size = New System.Drawing.Size(435, 494)
        Me.pdfViewer.TabIndex = 2
        Me.pdfViewer.TabStop = False
        '
        'pdfErrorLabel
        '
        Me.pdfErrorLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfErrorLabel.AutoSize = True
        Me.pdfErrorLabel.BackColor = System.Drawing.SystemColors.Control
        Me.pdfErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdfErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.pdfErrorLabel.Location = New System.Drawing.Point(327, 273)
        Me.pdfErrorLabel.MaximumSize = New System.Drawing.Size(435, 0)
        Me.pdfErrorLabel.MinimumSize = New System.Drawing.Size(435, 0)
        Me.pdfErrorLabel.Name = "pdfErrorLabel"
        Me.pdfErrorLabel.Size = New System.Drawing.Size(435, 20)
        Me.pdfErrorLabel.TabIndex = 3
        Me.pdfErrorLabel.Text = "Error"
        Me.pdfErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pdfErrorLabel.Visible = False
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'dgvBackgroundLoad
        '
        '
        'loadingStatus
        '
        Me.loadingStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadingStatus.Location = New System.Drawing.Point(585, 11)
        Me.loadingStatus.Name = "loadingStatus"
        Me.loadingStatus.Size = New System.Drawing.Size(177, 23)
        Me.loadingStatus.TabIndex = 4
        Me.loadingStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'infoLabel
        '
        Me.infoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoLabel.AutoSize = True
        Me.infoLabel.Location = New System.Drawing.Point(657, 30)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(105, 13)
        Me.infoLabel.TabIndex = 5
        Me.infoLabel.TabStop = True
        Me.infoLabel.Text = "Chemical Information"
        Me.infoLabel.Visible = False
        Me.infoLabel.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'TblSDSTableAdapter
        '
        Me.TblSDSTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 552)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.loadingStatus)
        Me.Controls.Add(Me.pdfErrorLabel)
        Me.Controls.Add(Me.pdfViewer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "MSDS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.msdsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pdfViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents msdsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pdfViewer As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents pdfErrorLabel As System.Windows.Forms.Label
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents dgvBackgroundLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents loadingStatus As System.Windows.Forms.Label
    Friend WithEvents SDSDataSet As SDSDataSet
    Friend WithEvents TblSDSBindingSource As BindingSource
    Friend WithEvents TblSDSTableAdapter As SDSDataSetTableAdapters.tblSDSTableAdapter
    Friend WithEvents SdsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SdsNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pdfPath As DataGridViewTextBoxColumn
    Friend WithEvents infoLabel As LinkLabel
End Class
