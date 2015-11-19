Imports System.ComponentModel

Public Class Manager
    Dim newCount As Integer = 0

    Private Sub deleteFunction()
        'Handle delete function to allow for deletion of multiple rows
        Dim delConfirmation As Integer = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Delete", MessageBoxButtons.YesNo)

        If delConfirmation = DialogResult.Yes Then
            For Each dr As DataGridViewRow In TblSDSDataGridView.SelectedRows
                TblSDSDataGridView.Rows.Remove(dr)
            Next
        End If
    End Sub

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblSDSTableAdapter.Fill(SDSDataSet.tblSDS)
        TblSDSBindingSource.Sort = "sdsName"

        'Handle searchbox
        searchEditBox.Text = "Search..."
        searchEditBox.ForeColor = Color.Gray
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveFunction()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        cancelFunction()
    End Sub

    Private Sub searchEditBox_GotFocus(sender As Object, e As EventArgs) Handles searchEditBox.GotFocus
        'Remove the search text and set the color back to default when this has focus.
        If searchEditBox.Text = "Search..." Then
            searchEditBox.Text = ""
            searchEditBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub searchEditBox_KeyDown(sender As Object, e As KeyEventArgs) Handles searchEditBox.KeyDown
        'Allow use of arrow keys while the searchbox has focus for convienence sake.
        Select Case e.KeyCode
            Case Keys.Down
                If TblSDSDataGridView.CurrentRow.Index < TblSDSDataGridView.Rows.Count - 1 Then
                    TblSDSDataGridView.CurrentCell = TblSDSDataGridView(TblSDSDataGridView.CurrentCell.ColumnIndex, TblSDSDataGridView.CurrentCell.RowIndex + 1)
                End If
                e.Handled = True
            Case Keys.Up
                If TblSDSDataGridView.CurrentRow.Index > 0 Then
                    TblSDSDataGridView.CurrentCell = TblSDSDataGridView(TblSDSDataGridView.CurrentCell.ColumnIndex, TblSDSDataGridView.CurrentCell.RowIndex - 1)
                End If
                e.Handled = True
        End Select
    End Sub

    Private Sub searchEditBox_LostFocus(sender As Object, e As EventArgs) Handles searchEditBox.LostFocus
        'When they leave the searchbox and it's empty, set the search text back to default
        If searchEditBox.Text = "" Then
            searchEditBox.Text = "Search..."
            searchEditBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub searchEditBox_TextChanged(sender As Object, e As EventArgs) Handles searchEditBox.TextChanged
        'Don't filter based on the default text
        If searchEditBox.Text = "Search..." Then
            Exit Sub
        End If

        'Filter datagrid
        TblSDSBindingSource.Filter = "sdsName like '%" & searchEditBox.Text & "%' OR manufacturer like '%" & searchEditBox.Text & "%'"
    End Sub

    Private Sub TblSDSDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles TblSDSDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            deleteFunction()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        saveFunction()
    End Sub
    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        cancelFunction()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        deleteFunction()
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        addFunction()
    End Sub

    Private Sub saveFunction()
        TblSDSTableAdapter.Update(SDSDataSet)
        Main.refreshData()
        Me.Close()
    End Sub

    Private Sub cancelFunction()
        SDSDataSet.RejectChanges()
        Me.Close()
    End Sub

    Private Sub editFunction()
        Dim editFrm As New infoFrm(Me.SDSDataSet, TblSDSDataGridView.CurrentRow.Cells(0).Value)
        editFrm.ShowDialog(Me)
    End Sub

    Private Sub addFunction()
        newCount = newCount - 1
        TblSDSBindingSource.Filter = ""
        TblSDSBindingSource.AddNew()
        TblSDSBindingSource.EndEdit()

        Dim editFrm As New infoFrm(Me.SDSDataSet, newCount)
        editFrm.ShowDialog(Me)

        TblSDSBindingSource.Filter = "sdsName like '%" & searchEditBox.Text & "%' OR manufacturer like '%" & searchEditBox.Text & "%'"
    End Sub

    Private Sub EditRecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRecToolStripMenuItem.Click
        editFunction()
    End Sub

    Private Sub TblSDSDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblSDSDataGridView.CellDoubleClick
        editFunction()
    End Sub
End Class