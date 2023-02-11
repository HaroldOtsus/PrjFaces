Public Class Form1
    Private Sub btnConfused_Click(sender As Object, e As EventArgs) Handles btnConfused.Click
        UCtrlEmotion1.setMood("confused")
    End Sub

    Private Sub btnCool_Click(sender As Object, e As EventArgs) Handles btnCool.Click
        UCtrlEmotion1.setMood("cool")
    End Sub

    Private Sub btnSmile_Click(sender As Object, e As EventArgs) Handles btnSmile.Click
        UCtrlEmotion1.setMood("smile")
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) Handles btnStar.Click
        UCtrlEmotion1.setMood("star")
    End Sub

    Private Sub btnTeeth_Click(sender As Object, e As EventArgs) Handles btnTeeth.Click
        UCtrlEmotion1.setMood("teeth")
    End Sub

    Private Sub btnYell_Click(sender As Object, e As EventArgs) Handles btnYell.Click
        UCtrlEmotion1.setMood("yell")
    End Sub
End Class
