Public Class Form5
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        If txtAnswer.Text = "近松門左衛門" Then
            MsgBox("正解")
        ElseIf txtAnswer.Text = "十返舎一九" Then
            MsgBox("おしい。それは『東海道中膝栗毛』の作者です。")

        ElseIf Len(txtAnswer.Text) = 0 Then
            MsgBox("何か入力してください。")

        Else
            MsgBox("はずれ")

        End If
    End Sub
End Class