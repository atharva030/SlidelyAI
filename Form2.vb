Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class Form2

    Dim stopwatch As New Stopwatch()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch.Start()
        Timer1.Start()
        LabelStopwatch.Text = "00:00:00.000"

        ' Register KeyPreview to handle key events in the form
        Me.KeyPreview = True
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        SubmitForm()
    End Sub

    Private Sub SubmitForm()
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim phoneNumber As String = TextBox3.Text
        Dim githubLink As String = TextBox4.Text
        Dim elapsedTimeMs As Long = stopwatch.ElapsedMilliseconds

        Dim postData As New With {
            .name = name,
            .email = email,
            .phoneNumber = phoneNumber,
            .github_link = githubLink,
            .stopwatch_time = elapsedTimeMs
        }

        Dim json As String = JsonConvert.SerializeObject(postData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response = client.PostAsync("http://localhost:5000/v1/users/createUser", content).Result
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Form submitted successfully!")
                Me.Hide()
                Dim mainForm As New Form1()
                mainForm.Show()
            Else
                MessageBox.Show("Failed to submit form.")
            End If
        End Using
    End Sub

    Private Sub ButtonToggleStopwatch_Click(sender As Object, e As EventArgs) Handles ButtonToggleStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Stop()
        Else
            stopwatch.Start()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        Dim elapsed = stopwatch.Elapsed
        LabelStopwatch.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle Ctrl+S for submitting the form
        If e.Control AndAlso e.KeyCode = Keys.S Then
            SubmitForm()
        End If

        ' Handle Ctrl+T for toggling stopwatch
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        End If
    End Sub

End Class
