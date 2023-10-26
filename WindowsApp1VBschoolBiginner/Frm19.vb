Public Class Frm19

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me. = 同じインスタンス(変数)内の
        Dim result As Integer = Me.Add(3, 4)
        MsgBox(result)
    End Sub

    ''' <summary>
    ''' 足し算します。
    ''' </summary>
    ''' <param name="x">引数１</param>
    ''' <param name="y">引数２</param>
    ''' <returns>合計</returns>
    Public Function Add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    '～～～valueエラーで一時的にコメントアウト中～～～
    'Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Debug.WriteLine(value)
    'End Sub


End Class