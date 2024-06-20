Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form3

    Private submissions As JArray
    Private currentIndex As Integer

    Private Async Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions on form load
        Me.KeyPreview = True
        Await LoadSubmissions()
    End Sub

    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Dim response = Await client.GetAsync("http://localhost:5000/v1/users/getuser")
            If response.IsSuccessStatusCode Then
                Dim json = Await response.Content.ReadAsStringAsync()
                submissions = JArray.Parse(json)
                currentIndex = 0
                ShowSubmission(currentIndex)
            Else
                MessageBox.Show("Failed to load submissions.")
            End If
        End Using
    End Function

    Private Sub ShowSubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            TextBoxName.Text = submission("name").ToString()
            TextBoxEmail.Text = submission("email").ToString()
            TextBoxPhone.Text = submission("phoneNumber").ToString()
            TextBoxGithub.Text = submission("github_link").ToString()
            TextBoxStopwatch.Text = TimeSpan.FromMilliseconds(submission("stopwatch_time").ToObject(Of Long)()).ToString("hh\:mm\:ss")
        Else
            MessageBox.Show("No submissions available.")
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If submissions IsNot Nothing AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim idToDelete As String = submissions(currentIndex)("_id").ToString()
            DeleteEntry(idToDelete)
        End If
    End Sub

    Private Async Sub DeleteEntry(id As String)
        Try
            Using client As New HttpClient()
                Dim postData As New With {
                    .id = id
                }
                Dim json = JsonConvert.SerializeObject(postData)
                Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")

                Dim response = Await client.PostAsync("http://localhost:5000/v1/users/deleteEntry", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Entry deleted successfully.")
                    Await LoadSubmissions() ' Reload submissions after deletion
                Else
                    MessageBox.Show("Failed to delete entry.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting entry: {ex.Message}")
        End Try
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle Ctrl+P for Previous submission
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Debug.WriteLine("Ctrl+P pressed")
            If currentIndex > 0 Then
                currentIndex -= 1
                ShowSubmission(currentIndex)
            End If
        End If

        ' Handle Ctrl+N for Next submission
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Debug.WriteLine("Ctrl+N pressed")
            If currentIndex < submissions.Count - 1 Then
                currentIndex += 1
                ShowSubmission(currentIndex)
            End If
        End If

        ' Handle Ctrl+D for Delete entry
        If e.Control AndAlso e.KeyCode = Keys.D Then
            Debug.WriteLine("Ctrl+D pressed")
            If submissions IsNot Nothing AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
                Dim idToDelete As String = submissions(currentIndex)("_id").ToString()
                DeleteEntry(idToDelete)
            End If
        End If
    End Sub

End Class
