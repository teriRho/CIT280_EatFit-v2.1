<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.btnBreakfast = New System.Windows.Forms.Button()
        Me.btnLunch = New System.Windows.Forms.Button()
        Me.btnDinner = New System.Windows.Forms.Button()
        Me.btnSnack = New System.Windows.Forms.Button()
        Me.btnLight = New System.Windows.Forms.Button()
        Me.btnHeavy = New System.Windows.Forms.Button()
        Me.lblMeal = New System.Windows.Forms.Label()
        Me.lblWorkout = New System.Windows.Forms.Label()
        Me.rtbCard = New System.Windows.Forms.RichTextBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBreakfast
        '
        Me.btnBreakfast.BackColor = System.Drawing.Color.Teal
        Me.btnBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreakfast.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBreakfast.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBreakfast.Location = New System.Drawing.Point(216, 158)
        Me.btnBreakfast.Name = "btnBreakfast"
        Me.btnBreakfast.Size = New System.Drawing.Size(103, 37)
        Me.btnBreakfast.TabIndex = 0
        Me.btnBreakfast.Text = "Breakfast"
        Me.btnBreakfast.UseVisualStyleBackColor = False
        '
        'btnLunch
        '
        Me.btnLunch.BackColor = System.Drawing.Color.Teal
        Me.btnLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLunch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLunch.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLunch.Location = New System.Drawing.Point(336, 158)
        Me.btnLunch.Name = "btnLunch"
        Me.btnLunch.Size = New System.Drawing.Size(103, 37)
        Me.btnLunch.TabIndex = 1
        Me.btnLunch.Text = "Lunch"
        Me.btnLunch.UseVisualStyleBackColor = False
        '
        'btnDinner
        '
        Me.btnDinner.BackColor = System.Drawing.Color.Teal
        Me.btnDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDinner.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDinner.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDinner.Location = New System.Drawing.Point(216, 201)
        Me.btnDinner.Name = "btnDinner"
        Me.btnDinner.Size = New System.Drawing.Size(103, 37)
        Me.btnDinner.TabIndex = 2
        Me.btnDinner.Text = "Dinner"
        Me.btnDinner.UseVisualStyleBackColor = False
        '
        'btnSnack
        '
        Me.btnSnack.BackColor = System.Drawing.Color.Teal
        Me.btnSnack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSnack.Location = New System.Drawing.Point(336, 201)
        Me.btnSnack.Name = "btnSnack"
        Me.btnSnack.Size = New System.Drawing.Size(103, 37)
        Me.btnSnack.TabIndex = 3
        Me.btnSnack.Text = "Snack"
        Me.btnSnack.UseVisualStyleBackColor = False
        '
        'btnLight
        '
        Me.btnLight.BackColor = System.Drawing.Color.Teal
        Me.btnLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLight.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLight.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLight.Location = New System.Drawing.Point(216, 63)
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Size = New System.Drawing.Size(103, 37)
        Me.btnLight.TabIndex = 4
        Me.btnLight.Text = "Light"
        Me.btnLight.UseVisualStyleBackColor = False
        '
        'btnHeavy
        '
        Me.btnHeavy.BackColor = System.Drawing.Color.Teal
        Me.btnHeavy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeavy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeavy.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHeavy.Location = New System.Drawing.Point(336, 63)
        Me.btnHeavy.Name = "btnHeavy"
        Me.btnHeavy.Size = New System.Drawing.Size(103, 37)
        Me.btnHeavy.TabIndex = 5
        Me.btnHeavy.Text = "Heavy"
        Me.btnHeavy.UseVisualStyleBackColor = False
        '
        'lblMeal
        '
        Me.lblMeal.AutoSize = True
        Me.lblMeal.BackColor = System.Drawing.Color.Transparent
        Me.lblMeal.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMeal.Location = New System.Drawing.Point(226, 119)
        Me.lblMeal.Name = "lblMeal"
        Me.lblMeal.Size = New System.Drawing.Size(213, 23)
        Me.lblMeal.TabIndex = 6
        Me.lblMeal.Text = "Select a Meal Type"
        '
        'lblWorkout
        '
        Me.lblWorkout.AutoSize = True
        Me.lblWorkout.BackColor = System.Drawing.Color.Transparent
        Me.lblWorkout.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkout.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWorkout.Location = New System.Drawing.Point(203, 24)
        Me.lblWorkout.Name = "lblWorkout"
        Me.lblWorkout.Size = New System.Drawing.Size(254, 23)
        Me.lblWorkout.TabIndex = 7
        Me.lblWorkout.Text = "Select a Workout Type"
        '
        'rtbCard
        '
        Me.rtbCard.BackColor = System.Drawing.Color.Teal
        Me.rtbCard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbCard.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtbCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCard.ForeColor = System.Drawing.Color.White
        Me.rtbCard.Location = New System.Drawing.Point(12, 44)
        Me.rtbCard.Name = "rtbCard"
        Me.rtbCard.ReadOnly = True
        Me.rtbCard.Size = New System.Drawing.Size(166, 151)
        Me.rtbCard.TabIndex = 8
        Me.rtbCard.Text = ""
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(395, 287)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(62, 23)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.DimGray
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.SystemColors.Control
        Me.btnOptions.Location = New System.Drawing.Point(327, 287)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(62, 23)
        Me.btnOptions.TabIndex = 10
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(462, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.rtbCard)
        Me.Controls.Add(Me.lblWorkout)
        Me.Controls.Add(Me.lblMeal)
        Me.Controls.Add(Me.btnHeavy)
        Me.Controls.Add(Me.btnLight)
        Me.Controls.Add(Me.btnSnack)
        Me.Controls.Add(Me.btnDinner)
        Me.Controls.Add(Me.btnLunch)
        Me.Controls.Add(Me.btnBreakfast)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmWelcome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EatFit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBreakfast As Button
    Friend WithEvents btnLunch As Button
    Friend WithEvents btnDinner As Button
    Friend WithEvents btnSnack As Button
    Friend WithEvents btnLight As Button
    Friend WithEvents btnHeavy As Button
    Friend WithEvents lblMeal As Label
    Friend WithEvents lblWorkout As Label
    Friend WithEvents rtbCard As System.Windows.Forms.RichTextBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
End Class
