Public Class Form1
    Private Sub btnShowMessage_Click(sender As Object, e As EventArgs) Handles btnShowMessage.Click
        Dim Title As String

        Title = txtTitle.Text

        Dim Message1 As String
        Message1 = txtMessage1.Text
        Dim Message2 As String
        Message2 = txtxMessage2.Text
        Dim Message3 As String
        Message3 = txtMessage3.Text
        MsgBox(" 1 " & txtMessage1.Text & " 2 " & txtxMessage2.Text & " 3 " & txtMessage3.Text)











    End Sub
End Class
