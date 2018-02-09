Public Class Form10


    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWMP2.settings.volume = 30
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Button2.Visible = False
        AxWMP2.URL = "E:\三学期課題　動画・音声\DSMN.wmv"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "1978" Then
            Label5.Visible = True
            Label6.Visible = False
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Button2.Visible = True
            Form3.point = Form3.point + 10
            My.Computer.Audio.Play(My.Resources.seikai, AudioPlayMode.Background)

        Else
            Label6.Visible = True
            Label5.Visible = False
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Button2.Visible = True
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWMP2.settings.volume = 0
        Form11.Show()

    End Sub


End Class