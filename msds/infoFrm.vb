Imports System.ComponentModel

Public Class infoFrm
    'Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(My.Settings.SDSConnectionString)
    'Dim Command As New OleDb.OleDbCommand
    'Dim da As New OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim sdsID As Integer = 0
    Dim result As String = ""
    'Query the dataset for the relevant information.  To limit the number of times we go back to the
    'db the dataset is populated fully and then we filter through.
    'Dim locations As DataTable
    'Dim departments As DataTable

    Public Sub loadListboxes()
        'locations = ds.Tables("SDSLocation")
        'departments = ds.Tables("SDSDepartment")
        ''Location query based on the sdsID
        'Dim locationQuery =
        '    From location In locations.AsEnumerable()
        '    Where location.Field(Of Integer)("sdsID") = sdsID
        '    Select New With {
        '        .locationName = location.Field(Of String)("locationName"),
        '        .sdsLocationID = location.Field(Of Integer)("sdsLocationID")}


        'Add locations to the listbox
        'locationBox.DataSource = locationQuery.ToList()
        'locationBox.DisplayMember = "locationName"
        'locationBox.ValueMember = "sdsLocationID"

        'Department query based on the sdsID
        'Dim departmentQuery =
        '     From dept In departments.AsEnumerable()
        '     Where dept.Field(Of Integer)("sdsID") = sdsID
        '     Select New With {
        '        .departmentName = dept.Field(Of String)("departmentName"),
        '        .sdsDepartmentID = dept.Field(Of Integer)("sdsDepartmentID")}

        'Add the departments to the listbox
        'departmentBox.DataSource = departmentQuery.ToList()
        'departmentBox.DisplayMember = "departmentName"
        'departmentBox.ValueMember = "sdsDepartmentID"

    End Sub
    Sub New(ByVal ds As SDSDataSet, ByVal id As Integer)
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Set the DataSource, BindingSource, Filter, and ID
        Me.ds = ds
        sdsID = id
        TblSDSBindingSource.DataSource = ds
        TblSDSBindingSource.Filter = "sdsID = " & sdsID
        JunctionSDSLocationBindingSource.DataSource = ds
        JunctionSDSDepartmentBindingSource.DataSource = ds

        'If the location table isn't already populated in the dataset we assume this is the first
        'time the info panel is being loaded and initiate the fill commands in a try block.
        'If ds.Tables("SDSDepartment") Is Nothing Then
        '    dataBackgroundLoad.RunWorkerAsync()
        'Else
        '    loadListboxes()
        'End If
    End Sub
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles Me.Load
        JunctionSDSLocationTableAdapter.Fill(ds.Tables("junctionSDSLocation"), sdsID)
        JunctionSDSDepartmentTableAdapter.Fill(ds.Tables("junctionSDSDepartment"), sdsID)

        If Me.Owner.Name = "Manager" Then
            For Each ctrl As Control In infoBox.Controls
                If (TypeOf ctrl Is TextBox) Then
                    CType(ctrl, TextBox).ReadOnly = False
                Else
                    ctrl.Enabled = True
                    ctrl.Visible = True
                End If
            Next

            DateAddedTextBox.ReadOnly = True
            'locationBox.SelectionMode = SelectionMode.One
            'departmentBox.SelectionMode = SelectionMode.One
            'This is populating the autocomplete for the manufacturer row.  This should hopefully help maintain consistency of case and
            'spelling across manufacturers.
            For Each dr As DataRow In ds.Tables("tblSDS").Rows
                ManufacturerTextBox.AutoCompleteCustomSource.Add(dr("manufacturer").ToString())
            Next
        Else
            locationDataGridView.DefaultCellStyle.SelectionBackColor = locationDataGridView.DefaultCellStyle.BackColor
            locationDataGridView.DefaultCellStyle.SelectionForeColor = locationDataGridView.DefaultCellStyle.ForeColor
            departmentDataGridView.DefaultCellStyle.SelectionBackColor = departmentDataGridView.DefaultCellStyle.BackColor
            departmentDataGridView.DefaultCellStyle.SelectionForeColor = departmentDataGridView.DefaultCellStyle.ForeColor
        End If
    End Sub

    Private Sub dataBackgroundLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles dataBackgroundLoad.DoWork
        Try
            'Connection.Open()
            'Command.Connection = Connection

            'da.SelectCommand = New OleDb.OleDbCommand("Select tblSDSLocation.sdsLocationID, tblSDSLocation.sdsID, tblLocation.locationName " &
            '"FROM(tblSDSLocation INNER JOIN tblLocation On tblSDSLocation.locationID = tblLocation.locationID)", Connection)

            'da.Fill(ds, "SDSLocation")

            'da.SelectCommand = New OleDb.OleDbCommand("Select tblSDSDepartment.sdsDepartmentID, tblSDSDepartment.sdsID, tblDepartment.departmentName " &
            '"FROM(tblSDSDepartment INNER JOIN tblDepartment On tblSDSDepartment.departmentID = tblDepartment.deptID)", Connection)

            'da.Fill(ds, "SDSDepartment")

            'Connection.Close()
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
    End Sub

    Private Sub dataBackgroundLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles dataBackgroundLoad.RunWorkerCompleted
        'loadListboxes()
    End Sub

    Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click
        'Open file dialog to make filling in the path easy.  Initial directory if blank will get you to the root of the MSDS folder,
        'otherwise it'll open in the directory currently set.
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        If PdfPathTextBox.Text IsNot "" Then
            fd.InitialDirectory = PdfPathTextBox.Text.Substring(0, PdfPathTextBox.Text.LastIndexOf("\"))
        End If

        fd.Filter = "PDF File (*.PDF)|*.PDF"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            PdfPathTextBox.Text = fd.FileName
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        If SdsNameTextBox.Text.Trim = "" Then
            Manager.TblSDSDataGridView.Rows.RemoveAt(0)
        End If
        TblSDSBindingSource.CancelEdit()
        JunctionSDSLocationBindingSource.CancelEdit()
        JunctionSDSDepartmentBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        fieldValidation()

        If result = "" Then
            TblSDSBindingSource.EndEdit()
            JunctionSDSLocationTableAdapter.Update(ds)
            JunctionSDSDepartmentTableAdapter.Update(ds)
            Me.Close()
        Else
            result = "The following fields cannot be blank:" & vbNewLine & result
            MsgBox(result)
        End If
    End Sub

    Private Sub SdsNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles SdsNameTextBox.GotFocus
        If SdsNameTextBox.Text = " " Then
            SdsNameTextBox.Text = ""
        End If
    End Sub

    Private Sub fieldValidation()
        result = ""

        If SdsNameTextBox.Text.Trim = "" Then
            result = result & "SDS Name" & vbNewLine
        End If

        If ManufacturerTextBox.Text.Trim = "" Then
            result = result & "Manufacturer" & vbNewLine
        End If

        If PdfPathTextBox.Text.Trim = "" Then
            result = result & "PDF Path" & vbNewLine
        End If
    End Sub

    Private Sub delLocationBtn_Click(sender As Object, e As EventArgs) Handles delLocationBtn.Click
        For Each dr As DataGridViewRow In locationDataGridView.SelectedRows
            locationDataGridView.Rows.Remove(dr)
        Next
    End Sub

    Private Sub addLocationBtn_Click(sender As Object, e As EventArgs) Handles addLocationBtn.Click
        Dim locationFrm As New locationFrm(ds, sdsID)

        If locationFrm.ShowDialog = DialogResult.OK Then
            Dim dr As DataRow()
            dr = ds.Tables("junctionSDSLocation").Select("locationName = '" & locationFrm.newLocationName & "'")
            If dr.Length <= 0 Then
                Dim newLocationRow As DataRow
                newLocationRow = ds.Tables("junctionSDSLocation").NewRow

                With newLocationRow
                    .Item("sdsID") = sdsID
                    .Item("locationID") = locationFrm.newLocationID
                    .Item("locationName") = locationFrm.newLocationName
                End With

                ds.Tables("junctionSDSLocation").Rows.Add(newLocationRow)
            End If
        End If
    End Sub

    Private Sub delDeptBtn_Click(sender As Object, e As EventArgs) Handles delDeptBtn.Click
        For Each dr As DataGridViewRow In departmentDataGridView.SelectedRows
            departmentDataGridView.Rows.Remove(dr)
        Next
    End Sub

    Private Sub addDeptBtn_Click(sender As Object, e As EventArgs) Handles addDeptBtn.Click
        Dim departmentFrm As New departmentFrm(ds, sdsID)

        If departmentFrm.ShowDialog = DialogResult.OK Then
            Dim dr As DataRow()
            dr = ds.Tables("junctionSDSDepartment").Select("departmentName = '" & departmentFrm.newDeptName & "'")
            If dr.Length <= 0 Then
                Dim newDepartmentRow As DataRow
                newDepartmentRow = ds.Tables("junctionSDSDepartment").NewRow

                With newDepartmentRow
                    .Item("sdsID") = sdsID
                    .Item("departmentID") = departmentFrm.newDeptID
                    .Item("departmentName") = departmentFrm.newDeptName
                End With

                ds.Tables("junctionSDSDepartment").Rows.Add(newDepartmentRow)
            End If
        End If
    End Sub
End Class