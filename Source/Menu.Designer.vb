<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Hangman = New System.Windows.Forms.Label()
        Me.Start_btn = New System.Windows.Forms.Button()
        Me.About_btn = New System.Windows.Forms.Button()
        Me.Help_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Hangman
        '
        Me.Hangman.AutoSize = True
        Me.Hangman.Font = New System.Drawing.Font("Tempus Sans ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hangman.Location = New System.Drawing.Point(64, 9)
        Me.Hangman.Name = "Hangman"
        Me.Hangman.Size = New System.Drawing.Size(144, 38)
        Me.Hangman.TabIndex = 3
        Me.Hangman.Text = "Hangman"
        '
        'Start_btn
        '
        Me.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_btn.Location = New System.Drawing.Point(84, 54)
        Me.Start_btn.Name = "Start_btn"
        Me.Start_btn.Size = New System.Drawing.Size(104, 38)
        Me.Start_btn.TabIndex = 4
        Me.Start_btn.Text = "Start"
        Me.Start_btn.UseVisualStyleBackColor = True
        '
        'About_btn
        '
        Me.About_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.About_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About_btn.Location = New System.Drawing.Point(84, 98)
        Me.About_btn.Name = "About_btn"
        Me.About_btn.Size = New System.Drawing.Size(104, 38)
        Me.About_btn.TabIndex = 5
        Me.About_btn.Text = "About"
        Me.About_btn.UseVisualStyleBackColor = True
        '
        'Help_btn
        '
        Me.Help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Help_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help_btn.Location = New System.Drawing.Point(84, 142)
        Me.Help_btn.Name = "Help_btn"
        Me.Help_btn.Size = New System.Drawing.Size(104, 38)
        Me.Help_btn.TabIndex = 6
        Me.Help_btn.Text = "Help"
        Me.Help_btn.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(84, 186)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(104, 38)
        Me.Exit_btn.TabIndex = 7
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(273, 256)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Help_btn)
        Me.Controls.Add(Me.About_btn)
        Me.Controls.Add(Me.Start_btn)
        Me.Controls.Add(Me.Hangman)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hangman As System.Windows.Forms.Label
    Friend WithEvents Start_btn As System.Windows.Forms.Button
    Friend WithEvents About_btn As System.Windows.Forms.Button
    Friend WithEvents Help_btn As System.Windows.Forms.Button
    Friend WithEvents Exit_btn As System.Windows.Forms.Button
End Class
