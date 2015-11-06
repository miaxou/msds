Imports System.ComponentModel

Public Class Info
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(My.Settings.SDSConnectionString)
    Dim Command As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim sdsID As Integer = 0
    Private Sub loadListboxes()
        'Query the dataset for the relevant information.  To limit the number of times we go back to the
        'db the dataset is populated fully and then we filter through.
        Dim locations As DataTable = ds.Tables("SDSLocation")
        Dim departments As DataTable = ds.Tables("SDSDepartment")

        'Location query based on the sdsID
        Dim locationQuery =
            From location In locations.AsEnumerable()
            Where location.Field(Of Integer)("sdsID") = sdsID
            Select New With {
                .locationName = location.Field(Of String)("locationName")}

        'Add locations to the listbox
        For Each place In locationQuery
            locationBox.Items.Add(place.locationName)
        Next

        'Department query based on the sdsID
        Dim departmentQuery =
             From dept In departments.AsEnumerable()
             Where dept.Field(Of Integer)("sdsID") = sdsID
             Select New With {
                .departmentName = dept.Field(Of String)("departmentName")}

        'Add the departments to the listbox
        For Each dept In departmentQuery
            departmentBox.Items.Add(dept.departmentName)
        Next
    End Sub
    Sub New(ByVal ds As SDSDataSet, ByVal id As Integer)
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Set the DataSource, BindingSource, Filter, and ID
        Me.ds = ds
        TblSDSBindingSource.DataSource = ds
        TblSDSBindingSource.Filter = "sdsID = " & id.ToString
        sdsID = id

        'If the location table isn't already populated in the dataset we assume this is the first
        'time the info panel is being loaded and initiate the fill commands in a try block.
        If ds.Tables("SDSLocation") Is Nothing Then
            dataBackgroundLoad.RunWorkerAsync()
        Else
            loadListboxes()
        End If
    End Sub
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub dataBackgroundLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles dataBackgroundLoad.DoWork
        Try
            Connection.Open()
            Command.Connection = Connection

            da.SelectCommand = New OleDb.OleDbCommand("Select tblSDSLocation.sdsID, tblLocation.locationName " &
            "FROM(tblSDSLocation INNER JOIN tblLocation On tblSDSLocation.locationID = tblLocation.locationID)", Connection)

            da.Fill(ds, "SDSLocation")

            da.SelectCommand = New OleDb.OleDbCommand("Select tblSDSDepartment.sdsID, tblDepartment.departmentName " &
            "FROM(tblSDSDepartment INNER JOIN tblDepartment On tblSDSDepartment.departmentID = tblDepartment.deptID)", Connection)

            da.Fill(ds, "SDSDepartment")

            Connection.Close()
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
    End Sub

    Private Sub dataBackgroundLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles dataBackgroundLoad.RunWorkerCompleted
        loadListboxes()
    End Sub
End Class