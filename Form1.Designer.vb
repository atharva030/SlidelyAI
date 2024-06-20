<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.Location = New Point(157, 74)
        Button1.Name = "Button1"
        Button1.Size = New Size(296, 40)
        Button1.TabIndex = 0
        Button1.Text = "Create New Submissions (CTRL + N)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DeepSkyBlue
        Button2.Location = New Point(157, 132)
        Button2.Name = "Button2"
        Button2.Size = New Size(296, 43)
        Button2.TabIndex = 1
        Button2.Text = "View Submission (CTRL + V)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(145, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(333, 20)
        Label1.TabIndex = 2
        Label1.Text = "Atharva Jagdale, Slidely Task 2- Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(751, 346)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Main Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
