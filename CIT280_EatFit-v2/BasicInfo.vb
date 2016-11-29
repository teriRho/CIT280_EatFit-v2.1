Imports System.IO
Public Class window_basicinfo
    Public Sub btnBasicSubmit_Click(sender As Object, e As EventArgs) Handles btnBasicSubmit.Click
        If rtbVerify.Text.Length > 0 Then
            storeprofile()
        Else
            MsgBox("Please verify first")
        End If
    End Sub
    Public Sub checkname()
        'check/store Name
        If txtName.Text.Length > 0 Then
            basic_name = txtName.Text
            basic_errorflag = False
        Else
            lblName.ForeColor = Color.Orange
            basic_errorflag = True
        End If
    End Sub
    Public Sub checksex()
        'check/store Sex
        Select Case True
            Case radFemale.Checked
                basic_sex = "Female"
                basic_errorflag = False

            Case radMale.Checked
                basic_sex = "Male"
                basic_errorflag = False
            Case Else
                lblSex.ForeColor = Color.Orange
                basic_errorflag = True
        End Select
    End Sub
    Public Sub checkage()
        'check/store Age
        If IsNumeric(txtAge.Text) Then
            basic_age = txtAge.Text
            basic_errorflag = False
        Else
            lblAge.ForeColor = Color.Orange
            basic_errorflag = True
        End If
    End Sub
    Public Sub checkheight()
        'check/store Height (convert height to inches)
        Try
            basic_height = (txtFt.Text * 12) + (txtInches.Text)
            basic_errorflag = False
        Catch heighterror As Exception
            lblHeight.ForeColor = Color.Orange
            basic_errorflag = True
        End Try
    End Sub
    Public Sub checkweight()
        'check/store Weight
        If IsNumeric(txtWeight.Text) Then
            basic_weight = txtWeight.Text
            basic_errorflag = False
        Else
            lblWeight.ForeColor = Color.Orange
            basic_errorflag = True
        End If
    End Sub
    Public Sub checkBMI()
        'check/calculate BMI
        If IsNumeric(txtBMI.Text) Then
            basic_BMI = txtBMI.Text
            basic_errorflag = False
        Else
            lblBMI.ForeColor = Color.Orange
            basic_errorflag = True
        End If
    End Sub
    Public Sub btnBMICalculate_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        'formula from http://www.bmi-calculator.net/bmi-formula.php
        Try
            basic_weight = txtWeight.Text
            basic_height = (txtFt.Text * 12) + (txtInches.Text)
            basic_BMI = ((basic_weight / (basic_height * basic_height)) * 703)
            txtBMI.Text = basic_BMI
        Catch BMIerror As Exception
            MsgBox("Invalid Height or Weight")
        End Try
    End Sub
    Public Sub checkgoalweight()
        'check/store goal weight
        If IsNumeric(txtGweight.Text) Then
            basic_Gweight = txtGweight.Text
            basic_errorflag = False
        Else
            lblGWeight.ForeColor = Color.Orange
            basic_errorflag = True
        End If
    End Sub
    Public Sub checkgoaldate()
        'store goal date
        basic_Gdate = dtpGdate.Text
    End Sub
    Public Sub checkerrors()
        'check errors/finalize
        If basic_errorflag = True Then
            MsgBox("Some fields are missing. Please correct those highlighted in orange.")
        Else
            lblName.ForeColor = Color.Black
            lblSex.ForeColor = Color.Black
            lblAge.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblWeight.ForeColor = Color.Black
            lblBMI.ForeColor = Color.Black
            lblGWeight.ForeColor = Color.Black
        End If
    End Sub
    Public Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        checkname()
        checksex()
        checkage()
        checkheight()
        checkweight()
        checkBMI()
        checkgoalweight()
        checkgoaldate()
        checkerrors()
        rtbVerify.Clear()
        rtbVerify.AppendText("Name: " & basic_name & vbNewLine)
        rtbVerify.AppendText("Sex: " & basic_sex & vbNewLine)
        rtbVerify.AppendText("Age: " & basic_age & vbNewLine)
        rtbVerify.AppendText("Height: " & basic_height & vbNewLine)
        rtbVerify.AppendText("Weight: " & basic_weight & vbNewLine)
        rtbVerify.AppendText("BMI: " & basic_BMI & vbNewLine)
        rtbVerify.AppendText("Goal Weight: " & basic_Gweight & vbNewLine)
        rtbVerify.AppendText("Goal Date: " & basic_Gdate & vbNewLine)
    End Sub
    Public Sub storeprofile()
        'stores profile as text file in bin/debug as username.text
        Try
            Using Writer As StreamWriter = New StreamWriter(basic_name)
                Writer.WriteLine(rtbVerify.Text)
            End Using
            MsgBox("Profile created")
            Login.Show()
            Me.Close()
        Catch storeerror As Exception
            MsgBox("Invalid input detected")
        End Try
    End Sub
    Private Sub btnNext_gen_Click(sender As Object, e As EventArgs) Handles btnNext_gen.Click
        tcBasicInfo.SelectedTab = tabBody
    End Sub
    Private Sub btnNext_bod_Click(sender As Object, e As EventArgs) Handles btnNext_bod.Click
        tcBasicInfo.SelectedTab = tabGoals
    End Sub
    Private Sub btnNext_goa_Click(sender As Object, e As EventArgs) Handles btnNext_goa.Click
        tcBasicInfo.SelectedTab = tabSummary
    End Sub
    Private Sub btnBack_gen_Click(sender As Object, e As EventArgs) Handles btnBack_gen.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub btnBack_bod_Click(sender As Object, e As EventArgs) Handles btnBack_bod.Click
        tcBasicInfo.SelectedTab = tabGeneral
    End Sub
    Private Sub btnBack_goals_Click(sender As Object, e As EventArgs) Handles btnBack_goals.Click
        tcBasicInfo.SelectedTab = tabBody
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnback_sum.Click
        tcBasicInfo.SelectedTab = tabGoals
    End Sub
End Class
