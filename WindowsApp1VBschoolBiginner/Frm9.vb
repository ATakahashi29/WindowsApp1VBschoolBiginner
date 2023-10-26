'クラススコープ
Public Class Frm9

    'プロシージャスコープ
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ブロックスコープ
        Try
            Dim userName As String
            userName = InputBox("お名前を教えてください。")

            If Len(userName) > 0 Then
                MsgBox("こんにちは、" & userName & "さん。")
            End If
        Catch ex As Exception
            'ここに書いた処理はエラー発生時にだけ実行されます。
            MsgBox("エラー発生 " & ex.Message)
        End Try
    End Sub
End Class