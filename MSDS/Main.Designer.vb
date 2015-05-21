<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.msdsGrid = New System.Windows.Forms.DataGridView()
        Me.ChemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdsDBDataSet = New MSDS.msdsDBDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pdfViewer = New AxAcroPDFLib.AxAcroPDF()
        Me.ChemTblTableAdapter = New MSDS.msdsDBDataSetTableAdapters.chemTblTableAdapter()
        Me.pdfErrorLabel = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemManDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChemPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.msdsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Size = New System.Drawing.Size(309, 512)
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
        Me.msdsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.ChemNameDataGridViewTextBoxColumn, Me.ChemManDataGridViewTextBoxColumn, Me.ChemPathDataGridViewTextBoxColumn})
        Me.msdsGrid.DataSource = Me.ChemTblBindingSource
        Me.msdsGrid.Location = New System.Drawing.Point(6, 45)
        Me.msdsGrid.MultiSelect = False
        Me.msdsGrid.Name = "msdsGrid"
        Me.msdsGrid.ReadOnly = True
        Me.msdsGrid.RowHeadersVisible = False
        Me.msdsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.msdsGrid.Size = New System.Drawing.Size(297, 461)
        Me.msdsGrid.TabIndex = 1
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagerToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManagerToolStripMenuItem
        '
        Me.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem"
        Me.ManagerToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ManagerToolStripMenuItem.Text = "Manager"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'pdfViewer
        '
        Me.pdfViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewer.Enabled = True
        Me.pdfViewer.Location = New System.Drawing.Point(327, 37)
        Me.pdfViewer.Name = "pdfViewer"
        Me.pdfViewer.OcxState = CType(resources.GetObject("pdfViewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdfViewer.Size = New System.Drawing.Size(504, 502)
        Me.pdfViewer.TabIndex = 2
        Me.pdfViewer.TabStop = False
        '
        'ChemTblTableAdapter
        '
        Me.ChemTblTableAdapter.ClearBeforeFill = True
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
        Me.pdfErrorLabel.Location = New System.Drawing.Point(327, 277)
        Me.pdfErrorLabel.MaximumSize = New System.Drawing.Size(504, 0)
        Me.pdfErrorLabel.MinimumSize = New System.Drawing.Size(504, 0)
        Me.pdfErrorLabel.Name = "pdfErrorLabel"
        Me.pdfErrorLabel.Size = New System.Drawing.Size(504, 20)
        Me.pdfErrorLabel.TabIndex = 3
        Me.pdfErrorLabel.Text = "Error"
        Me.pdfErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pdfErrorLabel.Visible = False
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "key"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        Me.KeyDataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyDataGridViewTextBoxColumn.Visible = False
        Me.KeyDataGridViewTextBoxColumn.Width = 30
        '
        'ChemNameDataGridViewTextBoxColumn
        '
        Me.ChemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChemNameDataGridViewTextBoxColumn.DataPropertyName = "chemName"
        Me.ChemNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
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
        Me.ChemPathDataGridViewTextBoxColumn.DataPropertyName = "chemPath"
        Me.ChemPathDataGridViewTextBoxColumn.HeaderText = "chemPath"
        Me.ChemPathDataGridViewTextBoxColumn.Name = "ChemPathDataGridViewTextBoxColumn"
        Me.ChemPathDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChemPathDataGridViewTextBoxColumn.Visible = False
        Me.ChemPathDataGridViewTextBoxColumn.Width = 80
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 551)
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
        CType(Me.ChemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MsdsDBDataSet As MSDS.msdsDBDataSet
    Friend WithEvents ChemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChemTblTableAdapter As MSDS.msdsDBDataSetTableAdapters.chemTblTableAdapter
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents ManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pdfViewer As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents pdfErrorLabel As System.Windows.Forms.Label
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemManDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemPathDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
