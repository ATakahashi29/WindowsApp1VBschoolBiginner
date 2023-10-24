Public Class Form13


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'ブレイクで確認するコード1
        'Dim i As Integer
        'Do While i < 5
        '    i += 1
        '    Debug.Print(i.ToString)
        'Loop

        'ブレイクで確認するコード2
        '条件に合致しない場合でもとりあえず1回は処理が実行される
        'Dim isTest As Boolean = False

        'Do
        '    Debug.Print(Now.ToString("HH:mm:ss"))
        'Loop While isTest

        'ブレイクで確認するコード3
        'Dim i As Integer

        'Do Until i = 5
        '    i += 1
        '    Debug.Print(i.ToString)
        'Loop

        'ブレイクで確認するコード4 EixtDo
        'Do
        '    Dim answer As MsgBoxResult
        '    answer = MsgBox("まだ続けますか？", vbYesNo Or vbQuestion)

        '    If answer = vbNo Then
        '        Exit Do
        '    End If
        'Loop

        'ブレイクで確認するコード5  Continue Do

        Const HiraganaStart As Integer = &H3041 'Unicodeで最初のひらがなのコードポイント
        Const HiraganaEnd As Integer = &H3096 'Unicodeで最後のひらがなのコードポイント

        Dim r As New Random
        Dim result As String = ""

        Do
            Dim moji As String = Char.ConvertFromUtf32(r.Next(HiraganaStart, HiraganaEnd + 1))

            If moji Like "[ゃゅょ]" AndAlso Not (result.LastOrDefault Like "[きしちにひみりぎじびぴ]") Then
                Continue Do
            End If

            result &= moji
        Loop Until Len(result) = 100


        MsgBox(result)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Do
            While True
                Continue While '内側の While ～ End While を先頭から実行する。
                Exit While '内側の While ～ End While を抜ける。
                Continue Do '外側の Do ～ Loop を先頭から実行する。
                Exit Do '外側の Do ～ Loop を抜ける。
            End While
        Loop
    End Sub
End Class