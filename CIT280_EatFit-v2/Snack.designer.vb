﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnack
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
        Me.txtSDrink = New System.Windows.Forms.TextBox()
        Me.txtSFruit = New System.Windows.Forms.TextBox()
        Me.txtSGrain = New System.Windows.Forms.TextBox()
        Me.txtSProtein = New System.Windows.Forms.TextBox()
        Me.pbSDrink = New System.Windows.Forms.PictureBox()
        Me.pbSFruit = New System.Windows.Forms.PictureBox()
        Me.pbSGrain = New System.Windows.Forms.PictureBox()
        Me.pbSProtein = New System.Windows.Forms.PictureBox()
        CType(Me.pbSDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSGrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSProtein, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSDrink
        '
        Me.txtSDrink.Location = New System.Drawing.Point(351, 143)
        Me.txtSDrink.Name = "txtSDrink"
        Me.txtSDrink.Size = New System.Drawing.Size(100, 20)
        Me.txtSDrink.TabIndex = 35
        Me.txtSDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSFruit
        '
        Me.txtSFruit.Location = New System.Drawing.Point(245, 143)
        Me.txtSFruit.Name = "txtSFruit"
        Me.txtSFruit.Size = New System.Drawing.Size(100, 20)
        Me.txtSFruit.TabIndex = 34
        Me.txtSFruit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSGrain
        '
        Me.txtSGrain.Location = New System.Drawing.Point(139, 143)
        Me.txtSGrain.Name = "txtSGrain"
        Me.txtSGrain.Size = New System.Drawing.Size(100, 20)
        Me.txtSGrain.TabIndex = 33
        Me.txtSGrain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSProtein
        '
        Me.txtSProtein.Location = New System.Drawing.Point(33, 143)
        Me.txtSProtein.Name = "txtSProtein"
        Me.txtSProtein.Size = New System.Drawing.Size(100, 20)
        Me.txtSProtein.TabIndex = 32
        Me.txtSProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbSDrink
        '
        Me.pbSDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbSDrink.Location = New System.Drawing.Point(351, 28)
        Me.pbSDrink.Name = "pbSDrink"
        Me.pbSDrink.Size = New System.Drawing.Size(100, 100)
        Me.pbSDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSDrink.TabIndex = 31
        Me.pbSDrink.TabStop = False
        '
        'pbSFruit
        '
        Me.pbSFruit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbSFruit.Location = New System.Drawing.Point(245, 28)
        Me.pbSFruit.Name = "pbSFruit"
        Me.pbSFruit.Size = New System.Drawing.Size(100, 100)
        Me.pbSFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSFruit.TabIndex = 30
        Me.pbSFruit.TabStop = False
        '
        'pbSGrain
        '
        Me.pbSGrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbSGrain.Location = New System.Drawing.Point(139, 28)
        Me.pbSGrain.Name = "pbSGrain"
        Me.pbSGrain.Size = New System.Drawing.Size(100, 100)
        Me.pbSGrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSGrain.TabIndex = 29
        Me.pbSGrain.TabStop = False
        '
        'pbSProtein
        '
        Me.pbSProtein.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbSProtein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbSProtein.Location = New System.Drawing.Point(33, 28)
        Me.pbSProtein.Name = "pbSProtein"
        Me.pbSProtein.Size = New System.Drawing.Size(100, 100)
        Me.pbSProtein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSProtein.TabIndex = 28
        Me.pbSProtein.TabStop = False
        '
        'frmSnack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(484, 186)
        Me.Controls.Add(Me.txtSDrink)
        Me.Controls.Add(Me.txtSFruit)
        Me.Controls.Add(Me.txtSGrain)
        Me.Controls.Add(Me.txtSProtein)
        Me.Controls.Add(Me.pbSDrink)
        Me.Controls.Add(Me.pbSFruit)
        Me.Controls.Add(Me.pbSGrain)
        Me.Controls.Add(Me.pbSProtein)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSnack"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snack"
        CType(Me.pbSDrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSGrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSProtein, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtSDrink As TextBox
    Private WithEvents txtSFruit As TextBox
    Private WithEvents txtSGrain As TextBox
    Private WithEvents txtSProtein As TextBox
    Private WithEvents pbSDrink As PictureBox
    Private WithEvents pbSFruit As PictureBox
    Private WithEvents pbSGrain As PictureBox
    Public WithEvents pbSProtein As System.Windows.Forms.PictureBox
End Class
