<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBoxName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxPhone = New TextBox()
        TextBoxGithub = New TextBox()
        TextBoxStopwatch = New TextBox()
        LabelName = New Label()
        LabelEmail = New Label()
        LabelPhone = New Label()
        LabelGithub = New Label()
        LabelStopwatch = New Label()
        ButtonPrev = New Button()
        ButtonNext = New Button()
        ButtonDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 20)
        Label1.TabIndex = 0
        Label1.Text = "Atharva Jagdale, Slidely Task 2 - View Submissions"
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(160, 60)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.ReadOnly = True
        TextBoxName.Size = New Size(376, 27)
        TextBoxName.TabIndex = 1
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(160, 100)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.ReadOnly = True
        TextBoxEmail.Size = New Size(376, 27)
        TextBoxEmail.TabIndex = 2
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Location = New Point(160, 140)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.ReadOnly = True
        TextBoxPhone.Size = New Size(376, 27)
        TextBoxPhone.TabIndex = 3
        ' 
        ' TextBoxGithub
        ' 
        TextBoxGithub.Location = New Point(160, 180)
        TextBoxGithub.Name = "TextBoxGithub"
        TextBoxGithub.ReadOnly = True
        TextBoxGithub.Size = New Size(376, 27)
        TextBoxGithub.TabIndex = 4
        ' 
        ' TextBoxStopwatch
        ' 
        TextBoxStopwatch.Location = New Point(160, 220)
        TextBoxStopwatch.Name = "TextBoxStopwatch"
        TextBoxStopwatch.ReadOnly = True
        TextBoxStopwatch.Size = New Size(376, 27)
        TextBoxStopwatch.TabIndex = 5
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(40, 60)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(49, 20)
        LabelName.TabIndex = 6
        LabelName.Text = "Name"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(40, 100)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(46, 20)
        LabelEmail.TabIndex = 7
        LabelEmail.Text = "Email"
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Location = New Point(40, 140)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(77, 20)
        LabelPhone.TabIndex = 8
        LabelPhone.Text = "Phone No."
        ' 
        ' LabelGithub
        ' 
        LabelGithub.AutoSize = True
        LabelGithub.Location = New Point(40, 180)
        LabelGithub.Name = "LabelGithub"
        LabelGithub.Size = New Size(83, 20)
        LabelGithub.TabIndex = 9
        LabelGithub.Text = "Github Link"
        ' 
        ' LabelStopwatch
        ' 
        LabelStopwatch.AutoSize = True
        LabelStopwatch.Location = New Point(40, 220)
        LabelStopwatch.Name = "LabelStopwatch"
        LabelStopwatch.Size = New Size(79, 20)
        LabelStopwatch.TabIndex = 10
        LabelStopwatch.Text = "Stopwatch"
        ' 
        ' ButtonPrev
        ' 
        ButtonPrev.BackColor = Color.Khaki
        ButtonPrev.Location = New Point(40, 270)
        ButtonPrev.Name = "ButtonPrev"
        ButtonPrev.Size = New Size(166, 29)
        ButtonPrev.TabIndex = 11
        ButtonPrev.Text = "Previous (Ctrl + P)"
        ButtonPrev.UseVisualStyleBackColor = False
        ' 
        ' ButtonNext
        ' 
        ButtonNext.BackColor = Color.DeepSkyBlue
        ButtonNext.Location = New Point(212, 270)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(168, 29)
        ButtonNext.TabIndex = 12
        ButtonNext.Text = "Next (Ctrl + N)"
        ButtonNext.UseVisualStyleBackColor = False
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.BackColor = Color.Red
        ButtonDelete.Location = New Point(386, 270)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(150, 29)
        ButtonDelete.TabIndex = 13
        ButtonDelete.Text = "Delete (Ctrl + D)"
        ButtonDelete.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 394)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonNext)
        Controls.Add(ButtonPrev)
        Controls.Add(LabelStopwatch)
        Controls.Add(LabelGithub)
        Controls.Add(LabelPhone)
        Controls.Add(LabelEmail)
        Controls.Add(LabelName)
        Controls.Add(TextBoxStopwatch)
        Controls.Add(TextBoxGithub)
        Controls.Add(TextBoxPhone)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxName)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxGithub As TextBox
    Friend WithEvents TextBoxStopwatch As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelGithub As Label
    Friend WithEvents LabelStopwatch As Label
    Friend WithEvents ButtonPrev As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonDelete As Button
End Class
