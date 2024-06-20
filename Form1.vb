Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Register KeyPreview to handle key events in the form
        Me.KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim createForm As New Form2()
        createForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim viewForm As New Form3()
        viewForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle Ctrl+N for Create New Submissions
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button1_Click(Nothing, Nothing)
        End If

        ' Handle Ctrl+V for View Submissions
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button2_Click(Nothing, Nothing)
        End If
    End Sub

End Class
