Partial Class SDSDataSet
    Partial Class tblSDSDataTable
        Private Sub tblSDSDataTable_TableNewRow(ByVal sender As Object, ByVal e As System.Data.DataTableNewRowEventArgs) Handles Me.TableNewRow
            Dim sds As tblSDSRow = CType(e.Row, tblSDSRow)
            sds.dateAdded = Format(Date.Now(), "MM/dd/yyyy")
            sds.sdsName = " "
        End Sub

    End Class
End Class

'Partial Class CategoriesProductsDataSet

'    Partial Class CategoriesDataTable



'        Private Sub CategoriesDataTable_TableNewRow(ByVal sender As Object, _

'       ByVal e As System.Data.DataTableNewRowEventArgs) _

'Handles Me.TableNewRow



'            'Set defaults for non-nullable fields

'            Dim category As CategoriesRow = CType(e.Row, CategoriesRow)

'            category.CategoryName = "New Category"

'        End Sub

'    End Class


Namespace SDSDataSetTableAdapters
    Partial Public Class junctionSDSLocationTableAdapter
    End Class

    Partial Public Class tblSDSTableAdapter
    End Class
End Namespace