Imports System.ComponentModel
Imports System.IO

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingStatus.Text = "Loading..."
        'Split the database call to a separate thread so the application appears to open quicker.
        dgvBackgroundLoad.RunWorkerAsync()

        'Set the viewer box default visibility and handle the searchbox text
        pdfViewer.Visible = False
        searchBox.Text = "Search..."
        searchBox.ForeColor = Color.Gray
    End Sub

    Private Sub displayPDF()
        'Check if referenced file exists and, if so, show it.  If not show the error instead.
        If File.Exists(msdsGrid.CurrentRow.Cells(3).Value) Then
            pdfViewer.Visible = True
            pdfErrorLabel.Visible = False
            infoLabel.Visible = True

            'Try to show the file, if failed assume PDF reader is missing and try to catch that gracefully.
            Try
                pdfViewer.LoadFile(msdsGrid.CurrentRow.Cells(3).Value)
            Catch ex As Exception
                MessageBox.Show("An acceptable PDF Reader, which is required to view this file, may not be installed.", "PDF Reader Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        ElseIf msdsGrid.CurrentRow.Cells(3).Value = "" Then
            pdfViewer.Visible = False
            pdfErrorLabel.Text = "No path to PDF available."
            pdfErrorLabel.Visible = True
            infoLabel.Visible = False
        Else
            pdfViewer.Visible = False
            pdfErrorLabel.Text = msdsGrid.CurrentRow.Cells(3).Value & " could not be found.  Please check the path and try again."
            pdfErrorLabel.Visible = True
            infoLabel.Visible = False
        End If
    End Sub

    'Public Sub refreshData()
    '    This initiates a call back to the DB to pull new data, only referenced when updates are saved on the manager or import screen.
    '    ChemTblTableAdapter.Fill(Me.MsdsDBDataSet.chemTbl)
    '    ChemTblBindingSource.Sort = "chemMan"
    '    loadingStatus.Text = "Loaded " & MsdsDBDataSet.chemTbl.Count & " records"
    'End Sub

    Private Sub searchBox_GotFocus(sender As Object, e As EventArgs) Handles searchBox.GotFocus
        'Remove the search text and set the color back to default when this has focus.
        If searchBox.Text = "Search..." Then
            searchBox.Text = ""
            searchBox.ForeColor = Color.Black
        End If
    End Sub

    'Allow arrow and enter keys to function while the focus is on the searchbox for convienence sake.
    Private Sub searchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles searchBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                If msdsGrid.CurrentRow.Index < msdsGrid.Rows.Count - 1 Then
                    msdsGrid.CurrentCell = msdsGrid(msdsGrid.CurrentCell.ColumnIndex, msdsGrid.CurrentCell.RowIndex + 1)
                End If
                e.Handled = True
            Case Keys.Up
                If msdsGrid.CurrentRow.Index > 0 Then
                    msdsGrid.CurrentCell = msdsGrid(msdsGrid.CurrentCell.ColumnIndex, msdsGrid.CurrentCell.RowIndex - 1)
                End If
                e.Handled = True
            Case Keys.Enter
                If msdsGrid.SelectedRows.Count <> 0 Then
                    displayPDF()
                End If
                e.Handled = True
        End Select
    End Sub

    Private Sub searchBox_LostFocus(sender As Object, e As EventArgs) Handles searchBox.LostFocus
        'When they leave the searchbox and it's empty, set the search text back to default
        If searchBox.Text = "" Then
            searchBox.Text = "Search..."
            searchBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        'Don't filter based on the default text
        If searchBox.Text = "Search..." Then
            Exit Sub
        End If

        'Filter DataGrid
        TblSDSBindingSource.Filter = "sdsName like '%" & searchBox.Text & "%' OR manufacturer like '%" & searchBox.Text & "%'"

    End Sub

    Private Sub msdsGrid_DoubleClick(sender As Object, e As EventArgs) Handles msdsGrid.DoubleClick
        'Handle doubleclick on grid.
        displayPDF()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Private Sub ManagerToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    'Prevent multiple instances of the manager window from spawning.
    '    If Application.OpenForms().OfType(Of Manager).Any Then
    '        MsgBox("Manager window already open!")
    '    Else
    '        Login.Show()
    '    End If
    'End Sub

    Private Sub msdsGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles msdsGrid.KeyDown
        'Handle enter key from grid.
        If e.KeyCode = Keys.Enter Then
            displayPDF()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgvBackgroundLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles dgvBackgroundLoad.DoWork
        'Try to initiate the database.  If not throw a friendly error and exit gracefully.  Most likely this is caused by the DB not being
        'present.
        Try
            Me.TblSDSTableAdapter.Fill(Me.SDSDataSet.tblSDS)
            TblSDSBindingSource.Sort = "sdsName"
        Catch ex As Exception
            MessageBox.Show("Database error encountered!", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Private Sub dgvBackgroundLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles dgvBackgroundLoad.RunWorkerCompleted
        'Once the background worker completes show the record count and reset bindingsource.
        loadingStatus.Text = "Loaded " & SDSDataSet.tblSDS.Count & " records"
        TblSDSBindingSource.ResetBindings(False)
    End Sub

    Private Sub infoLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles infoLabel.LinkClicked
        Dim infoFrm As New Info(Me.SDSDataSet, msdsGrid.CurrentRow.Cells(0).Value)
        infoFrm.ShowDialog()
    End Sub
End Class
