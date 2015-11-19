Public Class locationFrm
    Dim ds As DataSet
    Dim sdsID As Integer = 0

    Public Property newLocationName As String
    Public Property newLocationID As Integer

    Public Sub New(ByVal ds As SDSDataSet, ByVal id As Integer)
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Set the DataSource, BindingSource, Filter, and ID
        Me.ds = ds
        sdsID = id
        TblLocationBindingSource.DataSource = ds
    End Sub

    Private Sub Locations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblLocationTableAdapter.Fill(ds.Tables("tblLocation"))
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        newLocationID = LocationNameComboBox.SelectedValue
        newLocationName = LocationNameComboBox.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class