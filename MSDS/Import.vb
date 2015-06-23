Imports System.IO
Imports System.Data.SQLite

Public Class Import
    Dim importCount As Integer = 0

    Private Sub Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            chemManTextBox.AutoCompleteCustomSource.Add(dr("chemMan").ToString())
        Next
    End Sub

    Private Sub ChemTblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ChemTblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MsdsDBDataSet)

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        MsdsDBDataSet.RejectChanges()
        Me.Close()
    End Sub

    Private Sub importList_DragDrop(sender As Object, e As DragEventArgs) Handles importList.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String = e.Data.GetData(DataFormats.FileDrop)
            Dim PathName As String
            Dim i As Integer

            ' Loop through the array and add the files to the list.
            For i = 0 To MyFiles.Length - 1
                PathName = Path.GetFileNameWithoutExtension(MyFiles(i))
                If Not Me.importList.Items.Cast(Of ListViewItem)().Any(Function(lvi) lvi.Text = PathName) Then
                    importList.Items.Add(New ListViewItem(New String() {PathName, MyFiles(i)}))
                    importCount = importCount + 1
                End If
            Next
            importLabel.Text = importCount & " Items to be imported."
        End If
    End Sub

    Private Sub importList_DragEnter(sender As Object, e As DragEventArgs) Handles importList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub importList_KeyDown(sender As Object, e As KeyEventArgs) Handles importList.KeyDown
        If e.KeyCode = Keys.Delete Then
            For Each i As ListViewItem In importList.SelectedItems
                importList.Items.Remove(i)
                importCount = importCount - 1
            Next
            importLabel.Text = importCount & " Items to be imported."
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If importList.Items.Count > 0 And chemManTextBox.Text <> "" Then
            saveBtn.Enabled = False

            Dim prodName As String
            Dim path As String
            Dim connectionString As String = My.Settings.msdsDBConnectionString
            Dim mSQL As String

            Try
                For Each i As ListViewItem In importList.Items
                    prodName = i.SubItems(0).Text
                    path = i.SubItems(1).Text

                    'MsgBox(prodName & " AND " & path)

                    mSQL = "INSERT INTO chemTBL (chemMan, chemName, chemPath) VALUES ('" & chemManTextBox.Text & "','" & prodName & "','" & path & "')"

                    Using con As New SQLiteConnection(connectionString)
                        Using cmd As New SQLiteCommand(mSQL, con)
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End Using
                Next
            Catch ex As Exception
                MsgBox(ex)
            End Try

            ChemTblTableAdapter.Update(MsdsDBDataSet)
            Main.refreshData()
            Manager.refreshData()
            Me.Close()

        Else
            MessageBox.Show("Make sure all fields are completed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class