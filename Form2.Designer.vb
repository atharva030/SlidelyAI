<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ButtonSubmit = New Button()
        Label4 = New Label()
        Label5 = New Label()
        TextBox4 = New TextBox()
        ButtonToggleStopwatch = New Button()
        LabelStopwatch = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(251, 77)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(265, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(251, 121)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(265, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(251, 168)
        TextBox3.Margin = New Padding(4, 5, 4, 5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(265, 27)
        TextBox3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 77)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 4
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 121)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 5
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 168)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 6
        Label3.Text = "Phone No.:"
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.BackColor = Color.DeepSkyBlue
        ButtonSubmit.ForeColor = SystemColors.ControlText
        ButtonSubmit.Location = New Point(40, 312)
        ButtonSubmit.Margin = New Padding(4, 5, 4, 5)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(476, 35)
        ButtonSubmit.TabIndex = 7
        ButtonSubmit.Text = "Submit (Ctrl + S)"
        ButtonSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(113, 31)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(340, 20)
        Label4.TabIndex = 8
        Label4.Text = "Athava Jagdale, Slidely Task 2 - Create Submission"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 218)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 20)
        Label5.TabIndex = 10
        Label5.Text = "GitHub Link for Task 2:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(251, 215)
        TextBox4.Margin = New Padding(4, 5, 4, 5)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(265, 27)
        TextBox4.TabIndex = 9
        ' 
        ' ButtonToggleStopwatch
        ' 
        ButtonToggleStopwatch.BackColor = Color.Khaki
        ButtonToggleStopwatch.Location = New Point(40, 258)
        ButtonToggleStopwatch.Margin = New Padding(4, 5, 4, 5)
        ButtonToggleStopwatch.Name = "ButtonToggleStopwatch"
        ButtonToggleStopwatch.Size = New Size(200, 35)
        ButtonToggleStopwatch.TabIndex = 11
        ButtonToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        ButtonToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' LabelStopwatch
        ' 
        LabelStopwatch.AutoSize = True
        LabelStopwatch.Location = New Point(251, 265)
        LabelStopwatch.Margin = New Padding(4, 0, 4, 0)
        LabelStopwatch.Name = "LabelStopwatch"
        LabelStopwatch.Size = New Size(63, 20)
        LabelStopwatch.TabIndex = 12
        LabelStopwatch.Text = "00:00:00"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1171, 462)
        Controls.Add(LabelStopwatch)
        Controls.Add(ButtonToggleStopwatch)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(ButtonSubmit)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        KeyPreview = True
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form2"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonToggleStopwatch As System.Windows.Forms.Button
    Friend WithEvents LabelStopwatch As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
