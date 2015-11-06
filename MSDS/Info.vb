Imports System.ComponentModel

Public Class Info
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(My.Settings.SDSConnectionString)
    Dim Command As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim sdsID As Integer = 0
    Private Sub loadListboxes()
        Dim locations As DataTable = ds.Tables("SDSLocation")
        Dim departments As DataTable = ds.Tables("SDSDepartment")

        Dim locationQuery =
            From location In locations.AsEnumerable()
            Where location.Field(Of Integer)("sdsID") = sdsID
            Select New With {
                .locationName = location.Field(Of String)("locationName")}

        For Each place In locationQuery
            locationBox.Items.Add(place.locationName)
        Next

        Dim departmentQuery =
             From dept In departments.AsEnumerable()
             Where dept.Field(Of Integer)("sdsID") = sdsID
             Select New With {
                .departmentName = dept.Field(Of String)("departmentName")}

        For Each dept In departmentQuery
            departmentBox.Items.Add(dept.departmentName)
        Next
    End Sub
    Sub New(ByVal ds As SDSDataSet, ByVal id As Integer)
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Set the DataSource and ID
        Me.ds = ds
        TblSDSBindingSource.DataSource = ds
        TblSDSBindingSource.Filter = "sdsID = " & id.ToString
        sdsID = id

        If ds.Tables("SDSLocation") Is Nothing Then
            Connection.Open()
            Command.Connection = Connection

            da.SelectCommand = New OleDb.OleDbCommand("Select tblSDSLocation.sdsID, tblLocation.locationName " &
            "FROM(tblSDSLocation INNER JOIN tblLocation On tblSDSLocation.locationID = tblLocation.locationID)", Connection)

            da.Fill(ds, "SDSLocation")

            da.SelectCommand = New OleDb.OleDbCommand("Select tblSDSDepartment.sdsID, tblDepartment.departmentName " &
            "FROM(tblSDSDepartment INNER JOIN tblDepartment On tblSDSDepartment.departmentID = tblDepartment.deptID)", Connection)

            da.Fill(ds, "SDSDepartment")

            Connection.Close()
        End If
        loadListboxes()
    End Sub
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class