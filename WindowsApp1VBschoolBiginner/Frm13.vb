Public Class Frm13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '5回繰り替えし
        'For i As Integer = 0 To 4
        '    MsgBox($"{i}回目です。")
        'Next
    End Sub

    Private Sub Form13_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '全体を黒で塗りつぶします。
        e.Graphics.Clear(Color.Black)

        '赤い円を描画します。
        'e.Graphics.DrawEllipse(Pens.Red, 50, 60, 200, 160)

        '↓繰り返し処理使わずにかく
        '５つの赤い円を描画します。
        'e.Graphics.DrawEllipse(Pens.Red, 10, 10, 200, 200)
        'e.Graphics.DrawEllipse(Pens.Red, 20, 20, 200, 200)
        'e.Graphics.DrawEllipse(Pens.Red, 30, 30, 200, 200)
        'e.Graphics.DrawEllipse(Pens.Red, 40, 40, 200, 200)
        'e.Graphics.DrawEllipse(Pens.Red, 50, 50, 200, 200)

        '↓更に繰り返し処理でかく
        '5回DrawEllipseを実行しますが、同じ座標なので結果は1つの円に見えます。
        'For i As Integer = 0 To 4
        '    'e.Graphics.DrawEllipse(Pens.Red, 10, 10, 200, 200)

        '    '↓カウンター変数に書き換え
        '    e.Graphics.DrawEllipse(Pens.Red, (i + 1) * 10, (i + 1) * 10, 200, 200)
        'Next


        '↓カウンター変数＝回数に書き換え
        For i As Integer = 1 To 5
            e.Graphics.DrawEllipse(Pens.Red, i * 10, i * 10, 200, 200)
        Next

        'Stepの活用
        'For i As Integer = 10 To 50 Step 10
        '    e.Graphics.DrawEllipse(Pens.Beige, i, i, 200, 200)
        'Next
    End Sub
End Class