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

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        loginBtn.Enabled = False

        Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(My.Settings.SDSConnectionString)
        Dim Command As New OleDb.OleDbCommand
        Dim connectionString As String = My.Settings.SDSConnectionString
        Dim pwQuery As String = "SELECT Count(*) FROM tblManager WHERE userPIN = @passText"

        Try
            Using con As New OleDb.OleDbConnection(connectionString)
                Using cmd As New OleDb.OleDbCommand(pwQuery, con)
                    con.Open()
                    cmd.Parameters.Add("@passText", OleDb.OleDbType.VarChar).Value = getMd5Hash(passwordEntry.Text)

                    Dim i As String = cmd.ExecuteScalar

                    If i = "0" Then
                        loginBtn.Enabled = True
                        MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Manager.Show()
                        Me.Close()
                    End If

                End Using
            End Using


        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
    End Sub
End Class