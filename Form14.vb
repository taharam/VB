Public Class Form14
    Dim movietime As Integer


    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        AxWMP2.settings.volume = 30
        AxWMP2.URL = "E:\三学期課題　動画・音声\振り返り映像３.wmv"
        Me.Text = "エンディングまで" & 158 - movietime


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If movietime < 158 Then
            movietime = movietime + 1
            Me.Text = "エンディングまで" & 158 - movietime
        Else
            Timer1.Enabled = False
            MsgBox("ゲームを終了してもよろしいですか?")
            If MsgBoxResult.Ok Then
                End
            Else
                Form13.Show()
            End If
        End If

    End Sub
End Class