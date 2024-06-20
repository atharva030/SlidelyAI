<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        TextBox1 = New System.Windows.Forms.TextBox()
        TextBox2 = New System.Windows.Forms.TextBox()
        TextBox3 = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        ButtonSubmit = New System.Windows.Forms.Button()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        TextBox4 = New System.Windows.Forms.TextBox()
        ButtonToggleStopwatch = New System.Windows.Forms.Button()
        LabelStopwatch = New System.Windows.Forms.Label()
        Timer1 = New System.Windows.Forms.Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New System.Drawing.Point(116, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(200, 20)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New System.Drawing.Point(116, 90)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New System.Drawing.Size(200, 20)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New System.Drawing.Point(116, 130)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New System.Drawing.Size(200, 20)
        TextBox3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(30, 50)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 4
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(30, 90)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 5
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(30, 130)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 13)
        Label3.TabIndex = 6
        Label3.Text = "Phone No.:"
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.Location = New System.Drawing.Point(120, 220)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New System.Drawing.Size(100, 23)
        ButtonSubmit.TabIndex = 7
        ButtonSubmit.Text = "Submit (Ctrl + S)"
        ButtonSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(30, 20)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(212, 13)
        Label4.TabIndex = 8
        Label4.Text = "John Doe, Slidely Task 2 - Create Submission"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(30, 170)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(80, 13)
        Label5.TabIndex = 10
        Label5.Text = "GitHub Link for Task 2:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New System.Drawing.Point(116, 170)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New System.Drawing.Size(200, 20)
        TextBox4.TabIndex = 9
        ' 
        ' ButtonToggleStopwatch
        ' 
        ButtonToggleStopwatch.Location = New System.Drawing.Point(30, 260)
        ButtonToggleStopwatch.Name = "ButtonToggleStopwatch"
        ButtonToggleStopwatch.Size = New System.Drawing.Size(130, 23)
        ButtonToggleStopwatch.TabIndex = 11
        ButtonToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        ButtonToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' LabelStopwatch
        ' 
        LabelStopwatch.AutoSize = True
        LabelStopwatch.Location = New System.Drawing.Point(200, 265)
        LabelStopwatch.Name = "LabelStopwatch"
        LabelStopwatch.Size = New System.Drawing.Size(49, 13)
        LabelStopwatch.TabIndex = 12
        LabelStopwatch.Text = "00:00:00"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Enabled = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(350, 300)
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
