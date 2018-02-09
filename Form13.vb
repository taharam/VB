Public Class Form13


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form14.Show()

    End Sub

    
    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form3.ten + Form3.point
        If TextBox1.Text < 10 Then
            TextBox2.Text = "★　これを機に、ぜひ洋楽を聞いてみてください！"
        ElseIf TextBox1.Text > 25 Then
            TextBox2.Text = "★★★　すごい！！あなたは無敵です！！"
        Else
            TextBox2.Text = "★★　さらに洋楽に関する知識を深めてください！！"

        End If
    End Sub

   
End Class