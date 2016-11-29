<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class window_basicinfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tcBasicInfo = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.btnBack_gen = New System.Windows.Forms.Button()
        Me.btnNext_gen = New System.Windows.Forms.Button()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.tabBody = New System.Windows.Forms.TabPage()
        Me.btnBack_bod = New System.Windows.Forms.Button()
        Me.btnNext_bod = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.txtFt = New System.Windows.Forms.TextBox()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblLbs = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblFt = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.tabGoals = New System.Windows.Forms.TabPage()
        Me.btnBack_goals = New System.Windows.Forms.Button()
        Me.btnNext_goa = New System.Windows.Forms.Button()
        Me.dtpGdate = New System.Windows.Forms.DateTimePicker()
        Me.lblGdate = New System.Windows.Forms.Label()
        Me.txtGweight = New System.Windows.Forms.TextBox()
        Me.lblGWeight = New System.Windows.Forms.Label()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.btnback_sum = New System.Windows.Forms.Button()
        Me.btnBasicSubmit = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.rtbVerify = New System.Windows.Forms.RichTextBox()
        Me.tcBasicInfo.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabBody.SuspendLayout()
        Me.tabGoals.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcBasicInfo
        '
        Me.tcBasicInfo.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tcBasicInfo.Controls.Add(Me.tabGeneral)
        Me.tcBasicInfo.Controls.Add(Me.tabBody)
        Me.tcBasicInfo.Controls.Add(Me.tabGoals)
        Me.tcBasicInfo.Controls.Add(Me.tabSummary)
        Me.tcBasicInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcBasicInfo.ItemSize = New System.Drawing.Size(56, 18)
        Me.tcBasicInfo.Location = New System.Drawing.Point(0, 0)
        Me.tcBasicInfo.Multiline = True
        Me.tcBasicInfo.Name = "tcBasicInfo"
        Me.tcBasicInfo.SelectedIndex = 0
        Me.tcBasicInfo.Size = New System.Drawing.Size(261, 258)
        Me.tcBasicInfo.TabIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.LightSeaGreen
        Me.tabGeneral.BackgroundImage = Global.CIT280_EatFit_v2.My.Resources.Resources.bkg_teal
        Me.tabGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabGeneral.Controls.Add(Me.btnBack_gen)
        Me.tabGeneral.Controls.Add(Me.btnNext_gen)
        Me.tabGeneral.Controls.Add(Me.radFemale)
        Me.tabGeneral.Controls.Add(Me.radMale)
        Me.tabGeneral.Controls.Add(Me.txtName)
        Me.tabGeneral.Controls.Add(Me.txtAge)
        Me.tabGeneral.Controls.Add(Me.lblName)
        Me.tabGeneral.Controls.Add(Me.lblSex)
        Me.tabGeneral.Controls.Add(Me.lblAge)
        Me.tabGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabGeneral.ForeColor = System.Drawing.Color.White
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(253, 232)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        '
        'btnBack_gen
        '
        Me.btnBack_gen.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnBack_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack_gen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack_gen.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack_gen.Location = New System.Drawing.Point(7, 197)
        Me.btnBack_gen.Name = "btnBack_gen"
        Me.btnBack_gen.Size = New System.Drawing.Size(25, 25)
        Me.btnBack_gen.TabIndex = 8
        Me.btnBack_gen.Text = "<"
        Me.btnBack_gen.UseVisualStyleBackColor = False
        '
        'btnNext_gen
        '
        Me.btnNext_gen.BackColor = System.Drawing.Color.DarkOrange
        Me.btnNext_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext_gen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext_gen.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNext_gen.Location = New System.Drawing.Point(221, 199)
        Me.btnNext_gen.Name = "btnNext_gen"
        Me.btnNext_gen.Size = New System.Drawing.Size(25, 25)
        Me.btnNext_gen.TabIndex = 7
        Me.btnNext_gen.Text = ">"
        Me.btnNext_gen.UseVisualStyleBackColor = False
        '
        'radFemale
        '
        Me.radFemale.Appearance = System.Windows.Forms.Appearance.Button
        Me.radFemale.AutoSize = True
        Me.radFemale.BackColor = System.Drawing.Color.Transparent
        Me.radFemale.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radFemale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radFemale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radFemale.Location = New System.Drawing.Point(147, 92)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(72, 28)
        Me.radFemale.TabIndex = 6
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = False
        '
        'radMale
        '
        Me.radMale.Appearance = System.Windows.Forms.Appearance.Button
        Me.radMale.AutoSize = True
        Me.radMale.BackColor = System.Drawing.Color.Transparent
        Me.radMale.Checked = True
        Me.radMale.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radMale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radMale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radMale.Location = New System.Drawing.Point(87, 92)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(54, 28)
        Me.radMale.TabIndex = 5
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(87, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(80, 15)
        Me.txtName.TabIndex = 4
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.Location = New System.Drawing.Point(87, 140)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(43, 15)
        Me.txtAge.TabIndex = 3
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(32, 54)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Transparent
        Me.lblSex.Location = New System.Drawing.Point(47, 98)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(34, 16)
        Me.lblSex.TabIndex = 1
        Me.lblSex.Text = "Sex"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Location = New System.Drawing.Point(47, 139)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 16)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age"
        '
        'tabBody
        '
        Me.tabBody.BackColor = System.Drawing.Color.LightSeaGreen
        Me.tabBody.BackgroundImage = Global.CIT280_EatFit_v2.My.Resources.Resources.bkg_teal
        Me.tabBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabBody.Controls.Add(Me.btnBack_bod)
        Me.tabBody.Controls.Add(Me.btnNext_bod)
        Me.tabBody.Controls.Add(Me.btnBMI)
        Me.tabBody.Controls.Add(Me.txtBMI)
        Me.tabBody.Controls.Add(Me.txtWeight)
        Me.tabBody.Controls.Add(Me.txtInches)
        Me.tabBody.Controls.Add(Me.txtFt)
        Me.tabBody.Controls.Add(Me.lblBMI)
        Me.tabBody.Controls.Add(Me.lblLbs)
        Me.tabBody.Controls.Add(Me.lblWeight)
        Me.tabBody.Controls.Add(Me.lblInches)
        Me.tabBody.Controls.Add(Me.lblFt)
        Me.tabBody.Controls.Add(Me.lblHeight)
        Me.tabBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBody.ForeColor = System.Drawing.Color.White
        Me.tabBody.Location = New System.Drawing.Point(4, 22)
        Me.tabBody.Name = "tabBody"
        Me.tabBody.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBody.Size = New System.Drawing.Size(253, 232)
        Me.tabBody.TabIndex = 1
        Me.tabBody.Text = "Body"
        '
        'btnBack_bod
        '
        Me.btnBack_bod.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnBack_bod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack_bod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack_bod.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack_bod.Location = New System.Drawing.Point(7, 197)
        Me.btnBack_bod.Name = "btnBack_bod"
        Me.btnBack_bod.Size = New System.Drawing.Size(25, 25)
        Me.btnBack_bod.TabIndex = 16
        Me.btnBack_bod.Text = "<"
        Me.btnBack_bod.UseVisualStyleBackColor = False
        '
        'btnNext_bod
        '
        Me.btnNext_bod.BackColor = System.Drawing.Color.DarkOrange
        Me.btnNext_bod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext_bod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext_bod.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNext_bod.Location = New System.Drawing.Point(221, 199)
        Me.btnNext_bod.Name = "btnNext_bod"
        Me.btnNext_bod.Size = New System.Drawing.Size(25, 25)
        Me.btnNext_bod.TabIndex = 15
        Me.btnNext_bod.Text = ">"
        Me.btnNext_bod.UseVisualStyleBackColor = False
        '
        'btnBMI
        '
        Me.btnBMI.BackColor = System.Drawing.Color.Teal
        Me.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBMI.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBMI.Location = New System.Drawing.Point(144, 130)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(17, 20)
        Me.btnBMI.TabIndex = 14
        Me.btnBMI.Text = "?"
        Me.btnBMI.UseVisualStyleBackColor = False
        '
        'txtBMI
        '
        Me.txtBMI.BackColor = System.Drawing.Color.White
        Me.txtBMI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMI.ForeColor = System.Drawing.Color.Black
        Me.txtBMI.Location = New System.Drawing.Point(95, 132)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(42, 15)
        Me.txtBMI.TabIndex = 13
        Me.txtBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.White
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.ForeColor = System.Drawing.Color.Black
        Me.txtWeight.Location = New System.Drawing.Point(95, 96)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(42, 15)
        Me.txtWeight.TabIndex = 9
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInches
        '
        Me.txtInches.BackColor = System.Drawing.Color.White
        Me.txtInches.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInches.ForeColor = System.Drawing.Color.Black
        Me.txtInches.Location = New System.Drawing.Point(144, 57)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(23, 15)
        Me.txtInches.TabIndex = 6
        Me.txtInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFt
        '
        Me.txtFt.BackColor = System.Drawing.Color.White
        Me.txtFt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFt.ForeColor = System.Drawing.Color.Black
        Me.txtFt.Location = New System.Drawing.Point(95, 57)
        Me.txtFt.Name = "txtFt"
        Me.txtFt.Size = New System.Drawing.Size(23, 15)
        Me.txtFt.TabIndex = 5
        Me.txtFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.BackColor = System.Drawing.Color.Transparent
        Me.lblBMI.Location = New System.Drawing.Point(55, 131)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(34, 16)
        Me.lblBMI.TabIndex = 12
        Me.lblBMI.Text = "BMI"
        '
        'lblLbs
        '
        Me.lblLbs.AutoSize = True
        Me.lblLbs.BackColor = System.Drawing.Color.Transparent
        Me.lblLbs.Location = New System.Drawing.Point(138, 95)
        Me.lblLbs.Name = "lblLbs"
        Me.lblLbs.Size = New System.Drawing.Size(29, 16)
        Me.lblLbs.TabIndex = 11
        Me.lblLbs.Text = "lbs"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblWeight.Location = New System.Drawing.Point(33, 95)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(56, 16)
        Me.lblWeight.TabIndex = 10
        Me.lblWeight.Text = "Weight"
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.BackColor = System.Drawing.Color.Transparent
        Me.lblInches.Location = New System.Drawing.Point(170, 56)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(53, 16)
        Me.lblInches.TabIndex = 8
        Me.lblInches.Text = "inches"
        '
        'lblFt
        '
        Me.lblFt.AutoSize = True
        Me.lblFt.BackColor = System.Drawing.Color.Transparent
        Me.lblFt.Location = New System.Drawing.Point(121, 56)
        Me.lblFt.Name = "lblFt"
        Me.lblFt.Size = New System.Drawing.Size(16, 16)
        Me.lblFt.TabIndex = 7
        Me.lblFt.Text = "ft"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.Transparent
        Me.lblHeight.Location = New System.Drawing.Point(33, 56)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(53, 16)
        Me.lblHeight.TabIndex = 4
        Me.lblHeight.Text = "Height"
        '
        'tabGoals
        '
        Me.tabGoals.BackColor = System.Drawing.Color.LightSeaGreen
        Me.tabGoals.BackgroundImage = Global.CIT280_EatFit_v2.My.Resources.Resources.bkg_teal
        Me.tabGoals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabGoals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabGoals.Controls.Add(Me.btnBack_goals)
        Me.tabGoals.Controls.Add(Me.btnNext_goa)
        Me.tabGoals.Controls.Add(Me.dtpGdate)
        Me.tabGoals.Controls.Add(Me.lblGdate)
        Me.tabGoals.Controls.Add(Me.txtGweight)
        Me.tabGoals.Controls.Add(Me.lblGWeight)
        Me.tabGoals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabGoals.ForeColor = System.Drawing.Color.White
        Me.tabGoals.Location = New System.Drawing.Point(4, 22)
        Me.tabGoals.Name = "tabGoals"
        Me.tabGoals.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGoals.Size = New System.Drawing.Size(253, 232)
        Me.tabGoals.TabIndex = 2
        Me.tabGoals.Text = "Goals"
        '
        'btnBack_goals
        '
        Me.btnBack_goals.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnBack_goals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack_goals.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack_goals.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack_goals.Location = New System.Drawing.Point(7, 197)
        Me.btnBack_goals.Name = "btnBack_goals"
        Me.btnBack_goals.Size = New System.Drawing.Size(25, 25)
        Me.btnBack_goals.TabIndex = 17
        Me.btnBack_goals.Text = "<"
        Me.btnBack_goals.UseVisualStyleBackColor = False
        '
        'btnNext_goa
        '
        Me.btnNext_goa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNext_goa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext_goa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext_goa.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNext_goa.Location = New System.Drawing.Point(221, 199)
        Me.btnNext_goa.Name = "btnNext_goa"
        Me.btnNext_goa.Size = New System.Drawing.Size(25, 25)
        Me.btnNext_goa.TabIndex = 16
        Me.btnNext_goa.Text = ">"
        Me.btnNext_goa.UseVisualStyleBackColor = False
        '
        'dtpGdate
        '
        Me.dtpGdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGdate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpGdate.CalendarMonthBackground = System.Drawing.Color.Teal
        Me.dtpGdate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtpGdate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpGdate.CalendarTrailingForeColor = System.Drawing.Color.MediumOrchid
        Me.dtpGdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGdate.Location = New System.Drawing.Point(122, 98)
        Me.dtpGdate.Name = "dtpGdate"
        Me.dtpGdate.Size = New System.Drawing.Size(99, 22)
        Me.dtpGdate.TabIndex = 12
        '
        'lblGdate
        '
        Me.lblGdate.AutoSize = True
        Me.lblGdate.BackColor = System.Drawing.Color.Transparent
        Me.lblGdate.Location = New System.Drawing.Point(38, 103)
        Me.lblGdate.Name = "lblGdate"
        Me.lblGdate.Size = New System.Drawing.Size(78, 16)
        Me.lblGdate.TabIndex = 11
        Me.lblGdate.Text = "Goal Date"
        '
        'txtGweight
        '
        Me.txtGweight.BackColor = System.Drawing.Color.White
        Me.txtGweight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGweight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGweight.ForeColor = System.Drawing.Color.Black
        Me.txtGweight.Location = New System.Drawing.Point(122, 69)
        Me.txtGweight.Name = "txtGweight"
        Me.txtGweight.Size = New System.Drawing.Size(42, 15)
        Me.txtGweight.TabIndex = 10
        Me.txtGweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGWeight
        '
        Me.lblGWeight.AutoSize = True
        Me.lblGWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblGWeight.Location = New System.Drawing.Point(23, 68)
        Me.lblGWeight.Name = "lblGWeight"
        Me.lblGWeight.Size = New System.Drawing.Size(93, 16)
        Me.lblGWeight.TabIndex = 6
        Me.lblGWeight.Text = "Goal Weight"
        '
        'tabSummary
        '
        Me.tabSummary.BackColor = System.Drawing.Color.LightSeaGreen
        Me.tabSummary.BackgroundImage = Global.CIT280_EatFit_v2.My.Resources.Resources.bkg_purple
        Me.tabSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabSummary.Controls.Add(Me.btnback_sum)
        Me.tabSummary.Controls.Add(Me.btnBasicSubmit)
        Me.tabSummary.Controls.Add(Me.btnVerify)
        Me.tabSummary.Controls.Add(Me.rtbVerify)
        Me.tabSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSummary.ForeColor = System.Drawing.Color.White
        Me.tabSummary.Location = New System.Drawing.Point(4, 22)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(253, 232)
        Me.tabSummary.TabIndex = 3
        Me.tabSummary.Text = "Summary"
        '
        'btnback_sum
        '
        Me.btnback_sum.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnback_sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback_sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback_sum.ForeColor = System.Drawing.SystemColors.Control
        Me.btnback_sum.Location = New System.Drawing.Point(7, 197)
        Me.btnback_sum.Name = "btnback_sum"
        Me.btnback_sum.Size = New System.Drawing.Size(25, 25)
        Me.btnback_sum.TabIndex = 18
        Me.btnback_sum.Text = "<"
        Me.btnback_sum.UseVisualStyleBackColor = False
        '
        'btnBasicSubmit
        '
        Me.btnBasicSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBasicSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBasicSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBasicSubmit.ForeColor = System.Drawing.Color.White
        Me.btnBasicSubmit.Location = New System.Drawing.Point(163, 98)
        Me.btnBasicSubmit.Name = "btnBasicSubmit"
        Me.btnBasicSubmit.Size = New System.Drawing.Size(82, 25)
        Me.btnBasicSubmit.TabIndex = 14
        Me.btnBasicSubmit.Text = "Submit"
        Me.btnBasicSubmit.UseVisualStyleBackColor = False
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.ForeColor = System.Drawing.Color.White
        Me.btnVerify.Location = New System.Drawing.Point(163, 65)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(81, 25)
        Me.btnVerify.TabIndex = 1
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'rtbVerify
        '
        Me.rtbVerify.BackColor = System.Drawing.Color.White
        Me.rtbVerify.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbVerify.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtbVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbVerify.ForeColor = System.Drawing.Color.Black
        Me.rtbVerify.Location = New System.Drawing.Point(7, 6)
        Me.rtbVerify.Name = "rtbVerify"
        Me.rtbVerify.ReadOnly = True
        Me.rtbVerify.Size = New System.Drawing.Size(150, 185)
        Me.rtbVerify.TabIndex = 0
        Me.rtbVerify.Text = ""
        '
        'window_basicinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(261, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcBasicInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "window_basicinfo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Creation"
        Me.tcBasicInfo.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabBody.ResumeLayout(False)
        Me.tabBody.PerformLayout()
        Me.tabGoals.ResumeLayout(False)
        Me.tabGoals.PerformLayout()
        Me.tabSummary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabSummary As System.Windows.Forms.TabPage
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents rtbVerify As System.Windows.Forms.RichTextBox
    Friend WithEvents tabGoals As System.Windows.Forms.TabPage
    Friend WithEvents dtpGdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGdate As System.Windows.Forms.Label
    Friend WithEvents txtGweight As System.Windows.Forms.TextBox
    Friend WithEvents lblGWeight As System.Windows.Forms.Label
    Friend WithEvents tabBody As System.Windows.Forms.TabPage
    Friend WithEvents btnBMI As System.Windows.Forms.Button
    Friend WithEvents txtBMI As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtInches As System.Windows.Forms.TextBox
    Friend WithEvents txtFt As System.Windows.Forms.TextBox
    Friend WithEvents lblBMI As System.Windows.Forms.Label
    Friend WithEvents lblLbs As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblInches As System.Windows.Forms.Label
    Friend WithEvents lblFt As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents tcBasicInfo As System.Windows.Forms.TabControl
    Friend WithEvents btnBasicSubmit As System.Windows.Forms.Button
    Friend WithEvents btnNext_gen As System.Windows.Forms.Button
    Friend WithEvents btnNext_bod As System.Windows.Forms.Button
    Friend WithEvents btnNext_goa As System.Windows.Forms.Button
    Friend WithEvents btnBack_gen As System.Windows.Forms.Button
    Friend WithEvents btnBack_bod As System.Windows.Forms.Button
    Friend WithEvents btnBack_goals As System.Windows.Forms.Button
    Friend WithEvents btnback_sum As System.Windows.Forms.Button

End Class
