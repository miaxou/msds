Imports System.IO

Public Class Main

    Public Declare Auto Function FindExecutable Lib "shell32.dll" (ByVal lpFile As String, ByVal lpDirectory As String, ByVal lpResult As String) As Int32

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try to initiate the database.  If not throw a friendly error and exit gracefully.  Most likely this is caused by the DB not being
        'present.
        Try
            Me.ChemTblTableAdapter.Fill(Me.MsdsDBDataSet.chemTbl)
            ChemTblBindingSource.Sort = "chemMan"
        Catch ex As SQLite.SQLiteException
            MessageBox.Show("Database error encountered!", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

        'Set the viewer box default visibility and handle the searchbox
        pdfViewer.Visible = False
        searchBox.Text = "Search..."
        searchBox.ForeColor = Color.Gray
    End Sub

    Private Sub displayPDF()
        'Check if referenced file exists and, if so, show it.  If not show the error instead.
        If File.Exists(msdsGrid.CurrentRow.Cells(3).Value) Then
            'Check to see if a PDF reader is available before opening file.
            Dim intRetval As Integer = FindExecutable(msdsGrid.CurrentRow.Cells(3).Value, "", "")

            If intRetval <= 32 Then
                MessageBox.Show("An acceptable PDF Reader, which is required to view this file, may not be installed.", "PDF Reader Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                pdfViewer.Visible = True
                pdfErrorLabel.Visible = False
                Me.pdfViewer.LoadFile(msdsGrid.CurrentRow.Cells(3).Value)
            End If
        Else
            pdfViewer.Visible = False
            pdfErrorLabel.Text = msdsGrid.CurrentRow.Cells(3).Value & " could not be found.  Please check the path and try again."
            pdfErrorLabel.Visible = True
        End If
    End Sub

    Public Sub refreshData()
        'This initiates a call back to the DB to pull new data, only referenced when updates are saved on the manager screen.
        Me.ChemTblTableAdapter.Fill(Me.MsdsDBDataSet.chemTbl)
        ChemTblBindingSource.Sort = "chemMan"
    End Sub

    Private Sub searchBox_Enter(sender As Object, e As EventArgs) Handles searchBox.Enter
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
        If searchBox.Text = "" Then
            searchBox.Text = "Search..."
            searchBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        If searchBox.Text = "Search..." Then
            Exit Sub
        End If

        'Filter datagrid
        ChemTblBindingSource.Filter = "chemName like '%" & searchBox.Text & "%' OR chemMan like '%" & searchBox.Text & "%'"

    End Sub

    Private Sub msdsGrid_DoubleClick(sender As Object, e As EventArgs) Handles msdsGrid.DoubleClick
        displayPDF()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub msdsGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles msdsGrid.KeyDown
        If e.KeyCode = Keys.Enter Then
            displayPDF()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
