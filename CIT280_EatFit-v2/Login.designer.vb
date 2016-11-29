<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtLoginName = New System.Windows.Forms.TextBox()
        Me.picLogin = New System.Windows.Forms.PictureBox()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(14, 211)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(153, 31)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Login"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Teal
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(14, 248)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(153, 48)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New User"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'txtLoginName
        '
        Me.txtLoginName.BackColor = System.Drawing.Color.White
        Me.txtLoginName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoginName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginName.ForeColor = System.Drawing.Color.Black
        Me.txtLoginName.Location = New System.Drawing.Point(14, 192)
        Me.txtLoginName.Name = "txtLoginName"
        Me.txtLoginName.Size = New System.Drawing.Size(153, 13)
        Me.txtLoginName.TabIndex = 5
        Me.txtLoginName.Text = "Name"
        Me.txtLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picLogin
        '
        Me.picLogin.BackColor = System.Drawing.Color.White
        Me.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogin.Image = Global.CIT280_EatFit_v2.My.Resources.Resources.eatfitlogo
        Me.picLogin.Location = New System.Drawing.Point(26, 12)
        Me.picLogin.Name = "picLogin"
        Me.picLogin.Size = New System.Drawing.Size(126, 166)
        Me.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogin.TabIndex = 6
        Me.picLogin.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CIT280_EatFit_v2.My.Resources.Resources.bkg_teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(181, 308)
        Me.Controls.Add(Me.picLogin)
        Me.Controls.Add(Me.txtLoginName)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReturn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents txtLoginName As System.Windows.Forms.TextBox
    Friend WithEvents picLogin As System.Windows.Forms.PictureBox
End Class
