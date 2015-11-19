Public Class departmentFrm
    Dim ds As DataSet
    Dim sdsID As Integer = 0

    Public Property newDeptName As String
    Public Property newDeptID As Integer

    Public Sub New(ByVal ds As SDSDataSet, ByVal id As Integer)
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Set the DataSource, BindingSource, Filter, and ID
        Me.ds = ds
        sdsID = id
        TblDepartmentBindingSource.DataSource = ds
    End Sub

    Private Sub departmentFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblDepartmentTableAdapter.Fill(ds.Tables("tblDepartment"))
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        newDeptID = DepartmentNameComboBox.SelectedValue
        newDeptName = DepartmentNameComboBox.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class