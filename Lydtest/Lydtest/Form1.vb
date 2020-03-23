Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Users\gm\source\repos\Lydtest\Lydtest\Resources\Bender-03.wav", AudioPlayMode.Background)
    End Sub
End Class
