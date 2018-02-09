Imports System.Math
Public Class Form3
    Public point, ten As Integer
    Dim x1, y1, siita As Single
    Dim x2, y2, siita2 As Single


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form8.Show()

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        x1 = 300 * Cos(siita) + 400
        y1 = 200 * Sin(siita) + 200
        singers.Left = x1
        singers.Top = y1
        siita = siita + 0.05

        x2 = 100 * Cos(siita2) + x1 + singers.Width / 2
        y2 = 100 * Sin(siita2) + y1 + singers.Height / 2
        musicals.Left = x2 - musicals.Width
        musicals.Top = y2 - musicals.Height
        siita2 = siita2 + 0.5

    End Sub

   
End Class