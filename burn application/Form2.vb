Public Class Form2

    Private Sub Burn_databaseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Burn_databaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Burn_databaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Burn_data_base_2003DataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Burn_data_base_2003DataSet.Burn_database' table. You can move, or remove it, as needed.
        Me.Burn_databaseTableAdapter.Fill(Me.Burn_data_base_2003DataSet.Burn_database)

    End Sub

 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Male"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                Try
                    Me.Burn_databaseTableAdapter.FillBymale(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Case "Female"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                Try
                    Me.Burn_databaseTableAdapter.FillByfemale(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Case "All"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        labelcounter.Text = Burn_databaseDataGridView.RowCount - 1

    End Sub

 
  

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged


        Select Case ComboBox2.Text
            Case "less than 30%"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                Try
                    Me.Burn_databaseTableAdapter.FillBylessthan301(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Case "31% to 50%"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                Try
                    Me.Burn_databaseTableAdapter.FillBy30t50(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Case "51% to 65%"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                Try
                    Me.Burn_databaseTableAdapter.FillBy50t65(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Case "more than 65%"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                Try
                    Me.Burn_databaseTableAdapter.FillBy65t100(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Case "All"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
        End Select

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.Text
            Case "< 1 year"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                Try
                    Me.Burn_databaseTableAdapter.FillByinfant(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Case "1 to 5 years"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                Try
                    Me.Burn_databaseTableAdapter.FillBychild(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Case "6 to 15 years"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                Try
                    Me.Burn_databaseTableAdapter.FillByaldolecent(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Case "16 to 30 years"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                Try
                    Me.Burn_databaseTableAdapter.FillByadult(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Case "30 to 50 years"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                Try
                    Me.Burn_databaseTableAdapter.FillByold(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Case ">50 years"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                Try
                    Me.Burn_databaseTableAdapter.FillByeldder(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Case "All'"
                Try
                    Me.Burn_databaseTableAdapter.FillByall(Me.Burn_data_base_2003DataSet.Burn_database)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
        End Select
    End Sub
End Class