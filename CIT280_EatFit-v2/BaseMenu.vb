Imports System.IO
Public Class frmWelcome
    Private Sub Label2_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub btnLunch_Click(sender As Object, e As EventArgs) Handles btnLunch.Click
        My.Forms.frmLunch.Text = Now.ToString
        My.Forms.frmLunch.Show()
    End Sub
    Private Sub btnBreakfast_Click(sender As Object, e As EventArgs) Handles btnBreakfast.Click
        My.Forms.frmBreakfast.Text = Now.ToString
        My.Forms.frmBreakfast.Show()
    End Sub
    Private Sub btnDinner_Click(sender As Object, e As EventArgs) Handles btnDinner.Click
        My.Forms.frmDinner.Text = Now.ToString
        My.Forms.frmDinner.Show()
    End Sub
    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        My.Forms.frmSnack.Text = Now.ToString
        My.Forms.frmSnack.Show()
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btnLight_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        My.Forms.frmLight.Text = Now.ToString
        My.Forms.frmLight.Show()
    End Sub
    Private Sub btnHeavy_Click(sender As Object, e As EventArgs) Handles btnHeavy.Click
        My.Forms.frmHeavy.Text = Now.ToString
        My.Forms.frmHeavy.Show()
    End Sub
    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbCard.Clear()
        loadcard()
    End Sub
    Private Sub loadcard()
        'parses strings from text and assigns associated variables
        Try
            'Name
            Dim readname = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("Name"))
            basic_name = readname.Substring(readname.LastIndexOf(":") + 2)
            rtbCard.Text += "Welcome " & CStr(basic_name) & "!" & vbNewLine
            'Sex
            Dim readsex = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("Sex"))
            basic_sex = readsex.Substring(readsex.LastIndexOf(":") + 2)
            rtbCard.Text += "Sex: " & CStr(basic_sex) & vbNewLine
            'Age
            Dim readage = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("Age"))
            basic_age = readage.Substring(readage.LastIndexOf(":") + 2)
            rtbCard.Text += "Age: " & CStr(basic_age) & " years old" & vbNewLine
            'Height
            Dim readheight = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("Height"))
            basic_height = readheight.Substring(readheight.LastIndexOf(":") + 2)
            rtbCard.Text += "Height: " & CStr(basic_height) & " inches" & vbNewLine
            'Weight
            Dim readweight = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("Weight"))
            basic_weight = readweight.Substring(readweight.LastIndexOf(":") + 2)
            rtbCard.Text += "Weight: " & CStr(basic_weight) & " lbs" & vbNewLine
            'BMI
            Dim readbmi = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("BMI"))
            basic_BMI = readbmi.Substring(readbmi.LastIndexOf(":") + 2)
            rtbCard.Text += "BMI: " & CStr(basic_BMI) & vbNewLine
            'Goal Weight
            Dim readGweight = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("Goal Weight"))
            basic_Gweight = readGweight.Substring(readGweight.LastIndexOf(":") + 2)
            rtbCard.Text += "Goal Weight: " & CStr(basic_Gweight) & " lbs" & vbNewLine
            'Goal Date
            Dim readGdate = File.ReadAllLines(loginName).FirstOrDefault(Function(x) x.Contains("Goal Date"))
            basic_Gdate = readGdate.Substring(readGdate.LastIndexOf(":") + 2)
            rtbCard.Text += "Goal Date: " & CStr(basic_Gdate) & vbNewLine
        Catch ex As Exception
            MsgBox("Could not load card")
        End Try
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Restart()
    End Sub
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        frmAdvOpt.Show()
    End Sub
End Class