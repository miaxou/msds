Public Class Manager

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try to initiate the database.  If not throw a friendly error and exit gracefully.  Most likely this is caused by the DB not being
        'present.
        Try
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

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'I'm like 99% positive there's a more elegant way to handle these errors but this works for now.  Basically create an empty string
        ' and add error messages to it as necessary.
        Dim errorMsg As String = ""

        If ChemManTextBox.Text = "" Then
            errorMsg = errorMsg & "MSDS Manufacturer Cannot Be Blank." & Environment.NewLine
        End If

        If ChemNameTextBox.Text = "" Then
            errorMsg = errorMsg & "MSDS Name Cannot Be Blank." & Environment.NewLine
        End If

        If ChemPathTextBox.Text = "" Then
            errorMsg = errorMsg & "MSDS Path Cannot Be Blank." & Environment.NewLine
        End If

        'If the string is still empty assume no errors.  If text was entered into the boxes the datagrid won't populate until you move
        'off the record.  My crappy hack for that was to move records twice (once in both directions) to force the populate before
        'handling the update.  Both directions is required because if you're at the top or bottom then one or the other doesn't actually
        'work.  There really must be a better way to handle this too.  Then call the refresh on the main page to update that grid
        'immediately and close this form.
        If errorMsg = "" Then
            BindingNavigator1.MoveNextItem.PerformClick()
            BindingNavigator1.MovePreviousItem.PerformClick()
            ChemTblTableAdapter.Update(MsdsDBDataSet)
            Main.refreshData()
            Me.Close()
        Else
            MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            fd.InitialDirectory = "S:\Public\MSDS"
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

    Private Sub searchEditBox_Enter(sender As Object, e As EventArgs) Handles searchEditBox.Enter
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
End Class