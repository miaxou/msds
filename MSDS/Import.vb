Imports System.IO
Imports System.Data.SQLite

Public Class Import
    Dim importCount As Integer = 0

    Private Sub Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is populating the autocomplete for the manufacturer row.  This should hopefully help maintain consistency of case and
        'spelling across manufacturers.
        For Each dr As DataRow In Manager.MsdsDBDataSet.chemTbl.Rows
            chemManTextBox.AutoCompleteCustomSource.Add(dr("chemMan").ToString())
        Next
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub importList_DragDrop(sender As Object, e As DragEventArgs) Handles importList.DragDrop
        'Handle drag and drop of files.
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim PathName() As String = e.Data.GetData(DataFormats.FileDrop)
            Dim FileName As String
            Dim i As Integer

            ' Loop through the array and add the files to the listview.  Update import count.
            For i = 0 To PathName.Length - 1
                FileName = Path.GetFileNameWithoutExtension(PathName(i))
                If Not Me.importList.Items.Cast(Of ListViewItem)().Any(Function(lvi) lvi.Text = FileName) Then
                    importList.Items.Add(New ListViewItem(New String() {FileName, PathName(i)}))
                    importCount = importCount + 1
                End If
            Next
            importLabel.Text = importCount & " Items to be imported."
        End If
    End Sub

    Private Sub importList_DragEnter(sender As Object, e As DragEventArgs) Handles importList.DragEnter
        'Visual cue for drag and drop of files.
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub importList_KeyDown(sender As Object, e As KeyEventArgs) Handles importList.KeyDown
        'Handle delete key to work for removing files from the list
        If e.KeyCode = Keys.Delete Then
            For Each i As ListViewItem In importList.SelectedItems
                importList.Items.Remove(i)
                importCount = importCount - 1
            Next
            importLabel.Text = importCount & " Items to be imported."
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Handle updating of database/validation
        If importList.Items.Count > 0 And chemManTextBox.Text <> "" Then
            'Disable save button to prevent multiple clicks
            saveBtn.Enabled = False

            'Set connection string from App settings
            Dim connectionString As String = My.Settings.msdsDBConnectionString

            Try
                Using con As New SQLiteConnection(connectionString)
                    Using cmd As New SQLiteCommand("INSERT INTO chemTBL (chemMan, chemName, chemPath) VALUES (@manText, @prodText, @pathText)", con)

                        con.Open()

                        For Each i As ListViewItem In importList.Items
                            'Add command parameters and set their value
                            cmd.Parameters.Add("@manText", Data.DbType.String).Value = chemManTextBox.Text
                            cmd.Parameters.Add("@prodText", Data.DbType.String).Value = i.SubItems(0).Text
                            cmd.Parameters.Add("@pathText", Data.DbType.String).Value = i.SubItems(1).Text

                            'Execute
                            cmd.ExecuteNonQuery()
                        Next
                    End Using
                End Using
            Catch ex As Exception
                saveBtn.Enabled = True
                MsgBox(ex.Message)
            End Try

            Main.refreshData()
            Manager.refreshData()
            Me.Close()

        ElseIf chemManTextBox.Text = "" Then
            MessageBox.Show("Manufacturer field must be completed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Please add files to be imported before saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class