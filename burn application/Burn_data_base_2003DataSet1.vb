Partial Class Burn_data_base_2003DataSet
    Partial Class Burn_databaseDataTable

        Private Sub Burn_databaseDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AgeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
