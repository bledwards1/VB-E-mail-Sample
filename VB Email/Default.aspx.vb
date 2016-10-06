
' Written by Brad Edwards
' 6/14/2014
' http://tomballpc.com


' Be sure to import this

Imports System.Net.Mail

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myMessage As MailMessage = New MailMessage()
        myMessage.Subject = "Test Message" ' Enter the subject here
        myMessage.Body = "Hello world, from TomballPC.com" ' Message body
        myMessage.From = New MailAddress("youremail@yourdomain.com", "Enter your name")
        myMessage.To.Add(New MailAddress("youremail@yourdomain.com", "Enter recipient name"))

        Dim mySmtpClient As SmtpClient = New SmtpClient()
        mySmtpClient.Send(myMessage)
    End Sub
End Class
