Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Protected Friend Function getMd5Hash(ByVal input As String) As String
        'This handles hashing the password.  This application is completely noncritical so I don't have an issue using MD5 which is known
        'to be completely broken/reversible.  A good excercise would still be to update this to something non garbage but for now it works.
        Dim md5Hasher As New MD5CryptoServiceProvider()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        For i As Integer = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveBtn.Enabled = False

        Dim connectionString As String = My.Settings.msdsDBConnectionString
        Dim mSQL As String = "SELECT Count(*) FROM usersTbl WHERE pw = '" & getMd5Hash(passwordEntry.Text) & "'"

        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(mSQL, con)
                    con.Open()
                    Dim i As String = cmd.ExecuteScalar

                    If i = "0" Then
                        saveBtn.Enabled = True
                        MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Manager.Show()
                        Me.Close()
                    End If
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            saveBtn.Enabled = True
            MsgBox(ex.Message)
        End Try
    End Sub
End Class