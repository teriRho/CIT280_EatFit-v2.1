Imports System.IO
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        loginName = txtLoginName.Text
        If My.Computer.FileSystem.FileExists(loginName) Then
            frmWelcome.Show()
            Me.Close()
        Else
            MsgBox("Profile not found")
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        window_basicinfo.Show()
        Me.Close()
    End Sub
End Class
