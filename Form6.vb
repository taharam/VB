Public Class Form6


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form7.Show()
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If CheckBox2.Checked Then
            Label5.Visible = True
            Label6.Visible = False
            Label7.Visible = True
            Label9.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Button1.Visible = True
            Form3.ten = Form3.ten + 5
            My.Computer.Audio.Play(My.Resources.seikai, AudioPlayMode.Background)
        Else
            Label6.Visible = True
            Label5.Visible = False
            Label7.Visible = True
            Label9.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Button1.Visible = True
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Button1.Visible = False
    End Sub
End Class