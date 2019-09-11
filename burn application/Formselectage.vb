Public Class Formselectage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Visible = False
        Form1.ShowDialog()


    End Sub
End Class