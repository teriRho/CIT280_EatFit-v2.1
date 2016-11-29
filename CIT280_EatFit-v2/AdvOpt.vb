Public Class frmAdvOpt
    Private Sub btnBack_advop_Click(sender As Object, e As EventArgs) Handles btnBack_advop.Click
        Me.Close()
    End Sub
    Private Sub btnDeleteProfile_Click(sender As Object, e As EventArgs) Handles btnDeleteProfile.Click
        Dim boxChoice As Integer = MessageBox.Show("Are you sure?", "Delete Profile", MessageBoxButtons.YesNo)
        If boxChoice = DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile(loginName)
            MessageBox.Show("Profile Deleted")
            Application.Restart()
        End If
    End Sub
End Class
