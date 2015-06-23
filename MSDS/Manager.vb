Public Class Manager
    Dim errorState = False

    Public Sub refreshData()
        'This initiates a call back to the DB to pull new data, only referenced when updates are saved on the manager screen.
        Me.ChemTblTableAdapter.Fill(Me.MsdsDBDataSet.chemTbl)
    End Sub

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try to initiate the database.  If not throw a friendly error and exit gracefully.  Most likely this is caused by the DB not being
        'present.
        Try
            'Remove the DB constraints and handle them on save to avoid null exceptions.
            Me.MsdsDBDataSet.EnforceConstraints = False
            Me.ChemTblTableAdapter.Fill(Me.MsdsDBDataSet.chemTbl)
        Catch ex As SQLite.SQLiteException
            MessageBox.Show("Database error encountered!", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

        'This is populating the autocomplete for the manufacturer row.  This should hopefully help maintain consistency of case and
        'spelling across manufacturers.
        For Each dr As DataRow In MsdsDBDataSet.chemTbl.Rows
            ChemManTextBox.AutoCompleteCustomSource.Add(dr("chemMan").ToString())
        Next

        'Handle searchbox
        searchEditBox.Text = "Search..."
        searchEditBox.ForeColor = Color.Gray
    End Sub

    'Run through all rows/cells and check for empty values.  If found set an error flag and change error state.
    Private Sub errorCheck()
        If msdsEditGrid.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In msdsEditGrid.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value.ToString().Length = 0 Then
                        cell.ErrorText = "Please Enter A Value"
                        msdsEditGrid.Rows(cell.RowIndex).ErrorText = "Please Enter A Value"
                    Else
                        cell.ErrorText = ""
                        msdsEditGrid.Rows(cell.RowIndex).ErrorText = ""
                    End If

                    If cell.ErrorText.Length > 0 Then
                        errorState = True
                    End If
                Next
            Next
        Else
            errorState = True
        End If

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Disable multiple save clicks
        saveBtn.Enabled = False
        'Hack-y way to force the datagrid to update.  We're clearing the filter and forcing moves which ensures
        'that the datagrid will be updated when error checking is performed.  Probably (hopefully) a better way to handle this.
        dataNavigator.MovePreviousItem.PerformClick()
        dataNavigator.MoveNextItem.PerformClick()
        errorCheck()

        'If error state is false update the dataset, refresh the data on the main form, and close the manager
        If errorState = False Then
            ChemTblTableAdapter.Update(MsdsDBDataSet)
            Main.refreshData()
            Me.Close()
            'If an error is found reset everything and prompt for correction.
        Else
            MessageBox.Show("Please correct validation errors before saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            errorState = False
            saveBtn.Enabled = True
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        MsdsDBDataSet.RejectChanges()
        Me.Close()
    End Sub

    Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click
        'Open file dialog to make filling in the path easy.  Initial directory if blank will get you to the root of the MSDS folder,
        'otherwise it'll open in the directory currently set.
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        If ChemPathTextBox.Text = "" Then
            fd.InitialDirectory = My.Settings.startingPath
        Else
            fd.InitialDirectory = ChemPathTextBox.Text.Substring(0, ChemPathTextBox.Text.LastIndexOf("\"))
        End If

        fd.Filter = "PDF File (*.PDF)|*.PDF|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            ChemPathTextBox.Text = fd.FileName
        End If
    End Sub

    Private Sub searchEditBox_GotFocus(sender As Object, e As EventArgs) Handles searchEditBox.GotFocus
        If searchEditBox.Text = "Search..." Then
            searchEditBox.Text = ""
            searchEditBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub searchEditBox_KeyDown(sender As Object, e As KeyEventArgs) Handles searchEditBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                If msdsEditGrid.CurrentRow.Index < msdsEditGrid.Rows.Count - 1 Then
                    msdsEditGrid.CurrentCell = msdsEditGrid(msdsEditGrid.CurrentCell.ColumnIndex, msdsEditGrid.CurrentCell.RowIndex + 1)
                End If
                e.Handled = True
            Case Keys.Up
                If msdsEditGrid.CurrentRow.Index > 0 Then
                    msdsEditGrid.CurrentCell = msdsEditGrid(msdsEditGrid.CurrentCell.ColumnIndex, msdsEditGrid.CurrentCell.RowIndex - 1)
                End If
                e.Handled = True
        End Select
    End Sub

    Private Sub searchEditBox_LostFocus(sender As Object, e As EventArgs) Handles searchEditBox.LostFocus
        If searchEditBox.Text = "" Then
            searchEditBox.Text = "Search..."
            searchEditBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub searchEditBox_TextChanged(sender As Object, e As EventArgs) Handles searchEditBox.TextChanged
        If searchEditBox.Text = "Search..." Then
            Exit Sub
        End If

        'Filter datagrid
        ChemTblBindingSource.Filter = "chemName like '%" & searchEditBox.Text & "%' OR chemMan like '%" & searchEditBox.Text & "%'"
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of Import).Any Then
            MsgBox("Import window already open!")
        Else
            Import.Show()
        End If
    End Sub
End Class